using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class GameControl : UserControl
    {

        public enum DifficultyLevel { Easy, Normal, Hard }
        private MainForm parent;
        private int timeLeftInSeconds;
        private DifficultyLevel currentDifficulty;

        public GameControl(MainForm parentForm, DifficultyLevel difficulty = DifficultyLevel.Hard)
        {
            InitializeComponent();
            SetDifficulty(difficulty);
            InitializeTimer();
            UpdateTimerDisplay();
            parent = parentForm;
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new MainMenuControl(parent));
            gameTimer.Stop();


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
                    timeLeftInSeconds = 3 * 60; // 3 دقائق
                    break;
                case DifficultyLevel.Normal:
                    timeLeftInSeconds = 2 * 60; // 2 دقيقة
                    break;
                case DifficultyLevel.Hard:
                    timeLeftInSeconds = 1 * 60; // 1 دقيقة
                    break;
            }
        }


        private void InitializeTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeftInSeconds--;
            UpdateTimerDisplay();

            if (timeLeftInSeconds <= 10)
            {
                SystemSounds.Beep.Play();
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

                // return to main menu after the timer finished
                parent.LoadControl(new MainMenuControl(parent));

                if (this.Parent is Form parentForm)
                {
                    parentForm.Controls.Remove(this);
                }
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

        public void ResetTimer(int minutes = 1)
        {

            SetDifficulty(currentDifficulty);
            gameTimer.Stop();
            gameTimer.Start();
            lblTimer.ForeColor = Color.Black;
            UpdateTimerDisplay();
        }

        private void GameControl_Load(object sender, EventArgs e)
        {

        }
    }
}

