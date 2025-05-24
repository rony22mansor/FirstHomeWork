using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using FirstHomeWork.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class GameplayControl : UserControl
    {
        private MainForm parent;
        private int timeLeftInSeconds;
        private DifficultyLevel currentDifficulty;
        private GameMode selectedGameMode;
        private int selectedLevel;
        private List<DifferenceSpot> differences = new List<DifferenceSpot>();
        private int differencesFound = 0;
        private Mat imgO;
        private Mat imgE;
        private int inflationValue = 0;

        public GameplayControl(MainForm parentForm, GameMode gameMode, int level, DifficultyLevel difficulty = DifficultyLevel.Hard)
        {
            Console.WriteLine("level: " + (level));
            Console.WriteLine("difficulty: " + (difficulty));
            Console.WriteLine("gameMode: " + (gameMode));
            InitializeComponent();

            SetDifficulty(difficulty);
            GetInlationValue(difficulty);
            InitializeTimer();
            UpdateTimerDisplay();
            parent = parentForm;

            try
            {
                string imagePathO = Path.Combine(Application.StartupPath, "Resources", "Levels", $"level{level}.jpg");
                string imagePathE = Path.Combine(Application.StartupPath, "Resources", "Levels", $"level{level}_e.jpg");
                imgO = CvInvoke.Imread(imagePathO);
                imgE = CvInvoke.Imread(imagePathE);
                pbOriginalImage.Image = Image.FromFile(imagePathO);
                pbEditedImage.Image = Image.FromFile(imagePathE);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while loading images: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FindDifferences();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new GameControl(parent));
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
                    timeLeftInSeconds = 3 * 60; // 3 minutes
                    break;

                case DifficultyLevel.Normal:
                    timeLeftInSeconds = 2 * 60; // 2 minutes
                    break;

                case DifficultyLevel.Hard:
                    timeLeftInSeconds = 1 * 60; // 1 minute
                    break;
            }
        }

        private void InitializeTimer()
        {
            // Check if gameTimer is already initialized by the designer
            if (gameTimer == null)
            {
                gameTimer = new Timer();
            }
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
                // This block will make the timer text blink red/dark red
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
                lblTimer.ForeColor = Color.DarkRed; // Ensure it's dark red when time is up
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
            lblTimer.Text = $"Time: {minutes:00}:{seconds:00}";

            // Ensure timer color resets if it goes above 10 seconds again (e.g., if difficulty changes mid-game)
            if (timeLeftInSeconds > 10 && lblTimer.ForeColor != Color.Black)
            {
                lblTimer.ForeColor = Color.Black;
            }
        }

        public void ResetTimer(int minutes = 1)
        {
            SetDifficulty(currentDifficulty); // This will set timeLeftInSeconds based on currentDifficulty
            gameTimer.Stop();
            gameTimer.Start();
            lblTimer.ForeColor = Color.Black; // Reset color to black
            UpdateTimerDisplay();
        }


        private void FindDifferences()
        {
            differences.Clear();

            Mat diff = new Mat();
            Console.WriteLine("imgE: " + (imgE));
            Console.WriteLine("imgO: " + (imgO));
            CvInvoke.AbsDiff(imgO, imgE, diff);

            Mat gray = new Mat();
            CvInvoke.CvtColor(diff, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(gray, gray, 40, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            using (var contours = new VectorOfVectorOfPoint())
            {
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(gray, contours, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                    if (rect.Width > 3 && rect.Height > 5)
                    {

                        rect.Inflate(inflationValue, inflationValue);
                        differences.Add(new DifferenceSpot(rect));

                    }
                }
            }

            this.differencesFoundLabel.Text = $"{differences.Count} / {differencesFound}";

            Console.WriteLine(differences.Count);
        }

        private void GetInlationValue(DifficultyLevel difficulty)
        {
            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    inflationValue = 15;
                    break;

                case DifficultyLevel.Normal:
                    inflationValue = 6;
                    break;

                case DifficultyLevel.Hard:
                    inflationValue = 2;
                    break;
            }

        }


        private void pbOriginalImage_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("OriginalImage sender: " + (sender));
            Console.WriteLine("OriginalImage e: " + (e.Location));
        }

        private void pbEditedImage_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("EditedImage sender: " + (sender));
            Console.WriteLine("EditedImagee: " + (e.Location));
        }
    }
}