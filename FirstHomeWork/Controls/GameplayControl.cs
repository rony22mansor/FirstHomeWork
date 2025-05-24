using FirstHomeWork.Helpers;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Media; 
using System.Reflection;
using System.IO;
namespace FirstHomeWork
{
    public partial class GameplayControl : UserControl
    {


        private MainForm parent;
        private int timeLeftInSeconds;
        private DifficultyLevel currentDifficulty;
        private GameMode selectedGameMode;
        private int selectedLevel;
        private int attemptsLeft;
        private bool gameOver = false;
        private bool isProcessingClick = false;
        public GameplayControl(MainForm parentForm, GameMode gameMode, int level, DifficultyLevel difficulty = DifficultyLevel.Hard)
        {
            Console.WriteLine("level: " + (level));
            Console.WriteLine("difficulty: " + (difficulty));
            Console.WriteLine("gameMode: " + (gameMode));
            selectedGameMode = gameMode;
            selectedLevel = level;
            InitializeComponent();
            SetDifficulty(difficulty);
            InitializeTimer();
            UpdateTimerDisplay();
            InitializeGameElements();
            parent = parentForm;
        }

        private void InitializeGameElements()
        {
            if (selectedGameMode == GameMode.Timer)
            {
                InitializeTimer();
                UpdateTimerDisplay();
                lblAttempts.Visible = false;
                lblTimer.Visible = true;
            }
            else // Attempts mode
            {
                InitializeAttempts();
                UpdateAttemptsDisplay();
                lblTimer.Visible = false;
                lblAttempts.Visible = true;
            }
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new GameControl(parent));
            if (gameTimer !=null) { gameTimer.Stop(); }
            


            if (this.Parent is Form parentForm)
            {
                parentForm.Controls.Remove(this);

            }
        }
        public void SetDifficulty(DifficultyLevel difficulty)
        {
            currentDifficulty = difficulty;

            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    timeLeftInSeconds = 3 * 60;
                    attemptsLeft = 15;
                    break;
                case DifficultyLevel.Normal:
                    timeLeftInSeconds = 2 * 60;
                    attemptsLeft = 10; 
                    break;
                case DifficultyLevel.Hard:
                    timeLeftInSeconds = 1 * 60;
                    attemptsLeft = 8;
                    break;
            }
        }


        private void InitializeTimer()
        {
            if (gameTimer != null)
            {
                gameTimer.Tick -= GameTimer_Tick; 
                gameTimer.Stop();
                gameTimer.Dispose();
            }

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }


        private void InitializeAttempts()
        {
            
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
                gameTimer = null;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeftInSeconds--;
            UpdateTimerDisplay();

            if (timeLeftInSeconds <= 10)
            {
                PlayCustomSound();
            }

            if (timeLeftInSeconds <= 10)
            {
                lblTimer.ForeColor = Color.Red;


                if (timeLeftInSeconds % 2 == 0)
                {
                    lblTimer.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblTimer.ForeColor = Color.Red;
                }
            }

            if (timeLeftInSeconds <= 0)
            {
                gameTimer.Stop();
                lblTimer.ForeColor = Color.DarkRed;
                MessageBox.Show("انتهى الوقت!", "Game Over",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);

               
                parent.LoadControl(new MainMenuControl(parent));

                if (this.Parent is Form parentForm)
                {
                    parentForm.Controls.Remove(this);
                }
            }
        }

        private void PlayCustomSound()
        {
           
            
                
                string soundPath = @"Resources\Sounds\Alarm_Clock_Sound.wav";
                if (File.Exists(soundPath))
                {
                    var player = new SoundPlayer(soundPath);
                    player.Play();
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            
        }


        private void UpdateTimerDisplay()
        {

            int minutes = timeLeftInSeconds / 60;
            int seconds = timeLeftInSeconds % 60;
            lblTimer.Text = $"{minutes:00}:{seconds:00}";


            if (timeLeftInSeconds <= 10)
            {
                lblTimer.ForeColor = Color.Red;
            }
        }


        private void UpdateAttemptsDisplay()
        {
            lblAttempts.Text = $"Attempts: {attemptsLeft}";

            if (attemptsLeft <= 3) 
            {
                lblAttempts.ForeColor = Color.Red;
            }
            else
            {
                lblAttempts.ForeColor = Color.Black;
            }
        }





       /* private void GameplayControl_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left && selectedGameMode == GameMode.Attempts && !gameOver)
            {
                DecrementAttempt();
            }
        }

        public void DecrementAttempt()
        {
            if (attemptsLeft > 0)
            {
                attemptsLeft--;
                UpdateAttemptsDisplay();

               
                this.BackColor = Color.FromArgb(255, 200, 200);
                Timer colorTimer = new Timer();
                colorTimer.Interval = 200;
                colorTimer.Tick += (s, e) => {
                    this.BackColor = Color.White;
                    colorTimer.Stop();
                };
                colorTimer.Start();

                SystemSounds.Beep.Play();

                if (attemptsLeft <= 0)
                {
                    gameOver = true;
                    MessageBox.Show("انتهت جميع المحاولات!", "Game Over",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                    ReturnToMainMenu();
                }
            }
        }
       */

        private void ReturnToMainMenu()
        {
            parent.LoadControl(new MainMenuControl(parent));
            if (this.Parent is Form parentForm)
            {
                parentForm.Controls.Remove(this);
            }
        }


        public void ResetGameElements()
        {
            SetDifficulty(currentDifficulty);

            if (selectedGameMode == GameMode.Timer)
            {
                gameTimer.Stop();
                gameTimer.Start();
                lblTimer.ForeColor = Color.Black;
                UpdateTimerDisplay();
            }
            else
            {
                UpdateAttemptsDisplay();
                lblAttempts.ForeColor = Color.Black;
            }
        }

        private void GameControl_Load(object sender, EventArgs e)
        {
        }
    }
}

