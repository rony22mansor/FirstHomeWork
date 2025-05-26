using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using FirstHomeWork.Forms;
using FirstHomeWork.Helpers;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
namespace FirstHomeWork
{
    public partial class GameplayControl : UserControl
    {
        //declaring
        #region
        private MainForm parent;
        private DebugingForm df;
        private Helpers.SoundPlayer sp = new Helpers.SoundPlayer();
        private Mat imgO;
        private Mat imgE;
        private int timeLeftInSeconds;
        private int attemptsLeft;
        private int inflationValue;
        private GameMode gameMode;
        private List<Rectangle> differences = new List<Rectangle>();
        private List<Rectangle> discoveredDifferences = new List<Rectangle>();
        private int differencesCount = 0;
        private int discoveredDifferencesCount = 0;
        private Timer fadeTimer;
        private int fadeAlpha = 255;
        private bool isGameEnded = false;


        #endregion

        public GameplayControl(MainForm parentForm, GameMode gameMode, int level, DifficultyLevel difficulty = DifficultyLevel.Hard)
        {
            parent = parentForm;
            this.gameMode = gameMode;
            SetDifficultyOptions(difficulty);
            InitializeComponent();
            InitializeGameModeElements();
            InitializeImages(level);
            FindDifferences(inflationValue);
            ShowDebuggingForm();
        }

        // init the game
        #region
        private void InitializeImages(int level)
        {

            string imagePathO = Path.Combine(Application.StartupPath, "Resources", "Levels", $"level{level}.jpg");
            string imagePathE = Path.Combine(Application.StartupPath, "Resources", "Levels", $"level{level}_e.jpg");
            imgO = CvInvoke.Imread(imagePathO);
            imgE = CvInvoke.Imread(imagePathE);
            pbOriginalImage.Image = Image.FromFile(imagePathO);
            pbEditedImage.Image = Image.FromFile(imagePathE);
        }
        private void InitializeGameModeElements()
        {
            if (gameMode == GameMode.Timer)
            {
                InitializeTimer();
                UpdateTimerDisplay();
                lblAttempts.Visible = false;
                lblTimer.Visible = true;
            }
            else
            {
                InitializeAttempts();
                UpdateAttemptsDisplay();
                lblTimer.Visible = false;
                lblAttempts.Visible = true;
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
            lblAttempts.Text = $"Attempts: {attemptsLeft}";
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
                gameTimer = null;
            }
        }

        public void SetDifficultyOptions(DifficultyLevel difficulty)
        {
            switch (difficulty)
            {
                case DifficultyLevel.Easy:
                    timeLeftInSeconds = 90;
                    attemptsLeft = 15;
                    inflationValue = 15;
                    break;
                case DifficultyLevel.Normal:
                    timeLeftInSeconds = 60;
                    attemptsLeft = 10;
                    inflationValue = 6;
                    break;
                case DifficultyLevel.Hard:
                    timeLeftInSeconds = 30;
                    attemptsLeft = 8;
                    inflationValue = 2;
                    break;
            }
        }
        #endregion

        //game logic
        #region

        
        private void OnGameWon()
        {
            isGameEnded = true;
            sp.PlaySound(@"Resources\Sounds\congrats.wav");
            WinDialog winDialog = new WinDialog();
            winDialog.ShowDialog();
            Console.WriteLine(isGameEnded);

           
            if (df != null)
            {
                df.Close();
            }
           
            parent.LoadControl(new MainMenuControl(parent));

            if (this.Parent is Form parentForm)
            {
                parentForm.Controls.Remove(this);
            }
        }

        private void OnGameOver()
        {
            sp.PlaySound(@"Resources\Sounds\lose.wav");
            LoseDialog loseDialog = new LoseDialog();
            loseDialog.ShowDialog();
            isGameEnded = true;

            if (df != null)
            {
                df.Close();
            }
            parent.LoadControl(new MainMenuControl(parent));

            if (this.Parent is Form parentForm)
            {
                parentForm.Controls.Remove(this);
            }
        }

        private void FindDifferences(int infaltionValue)
        {
            differences.Clear();

            Mat diff = new Mat();
            CvInvoke.AbsDiff(imgO, imgE, diff);

            Mat gray = new Mat();
            CvInvoke.CvtColor(diff, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(gray, gray, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            using (var contours = new VectorOfVectorOfPoint())
            {
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(gray, contours, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                    if (rect.Width > 3 && rect.Height > 3)
                    {
                        rect.Inflate(infaltionValue, infaltionValue);
                        differences.Add(rect);
                    }
                }
            }

            differencesCount = differences.Count;
            this.differencesFoundLabel.Text = $"{differencesCount} / {discoveredDifferencesCount}";
           
            df = new DebugingForm(diff.ToBitmap(), gray.ToBitmap());
        }

        private Point GetImageCoordinates(PictureBox pictureBox, Point clickPoint)
        {
            int originalImageWidth = pictureBox.Image.Width;
            int originalImageHeight = pictureBox.Image.Height;

            int pictureBoxWidth = pictureBox.Width;
            int pictureBoxHeight = pictureBox.Height;

            Point imageCoordinates = new Point();

            double imageAspectRatio = (double)originalImageWidth / originalImageHeight;
            double pictureBoxAspectRatio = (double)pictureBoxWidth / pictureBoxHeight;

            int displayedImageWidth;
            int displayedImageHeight;
            int xOffset = 0;
            int yOffset = 0;

            if (imageAspectRatio > pictureBoxAspectRatio)
            {
                displayedImageWidth = pictureBoxWidth;
                displayedImageHeight = (int)(pictureBoxWidth / imageAspectRatio);
                yOffset = (pictureBoxHeight - displayedImageHeight) / 2;
            }
            else
            {
                displayedImageHeight = pictureBoxHeight;
                displayedImageWidth = (int)(pictureBoxHeight * imageAspectRatio);
                xOffset = (pictureBoxWidth - displayedImageWidth) / 2;
            }

            int adjustedClickX = clickPoint.X - xOffset;
            int adjustedClickY = clickPoint.Y - yOffset;

            imageCoordinates.X = (int)(adjustedClickX * ((double)originalImageWidth / displayedImageWidth));
            imageCoordinates.Y = (int)(adjustedClickY * ((double)originalImageHeight / displayedImageHeight));

            return imageCoordinates;
        }

        #endregion

        //actions
        #region
        private void pbEditedImage_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPointInImage = GetImageCoordinates(pbEditedImage, e.Location);
            bool foundDifference = false;
            for (int i = differences.Count - 1; i >= 0; i--)
            {
                Rectangle diff = differences[i];
                if (diff.Contains(clickPointInImage))
                {
                    foundDifference = true;
                    discoveredDifferences.Add(diff);
                    differences.RemoveAt(i);
                    discoveredDifferencesCount += 1;
                    DrawDiscoveredDifference(diff);
                    UpdateDifferencesFoundDisplay();

                    break;
                }
            }
            if (gameMode == GameMode.Attempts)
            {
                if (!foundDifference)
                {
                    attemptsLeft--;
                    UpdateAttemptsDisplay();
                    if (attemptsLeft <= 0)
                    {
                        OnGameOver();
                    }
                }
            }


            sp.PlaySound(foundDifference ? @"Resources\Sounds\right.wav" : @"Resources\Sounds\wrong.wav");
            ShowFeedbackIcon(foundDifference);


            if (differences.Count == 0)
            {
                OnGameWon();
            }
        }

        private void pbOriginalImage_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPointInImage = GetImageCoordinates(pbOriginalImage, e.Location);
            bool foundDifference = false;
            for (int i = differences.Count - 1; i >= 0; i--)
            {
                Rectangle diff = differences[i];
                if (diff.Contains(clickPointInImage))
                {
                    foundDifference = true;
                    discoveredDifferences.Add(diff);
                    differences.RemoveAt(i);
                    discoveredDifferencesCount += 1;
                    DrawDiscoveredDifference(diff);
                    UpdateDifferencesFoundDisplay();

                    if (differences.Count == 0)
                    {
                        OnGameWon();
                    }
                    break;
                }
            }
            if (gameMode == GameMode.Attempts)
            {
                if (!foundDifference)
                {
                    attemptsLeft--;
                    UpdateAttemptsDisplay();
                    if (attemptsLeft <= 0)
                    {
                        OnGameOver();
                    }
                }
            }
            sp.PlaySound(foundDifference ? @"Resources\Sounds\right.wav" : @"Resources\Sounds\wrong.wav");
            ShowFeedbackIcon(foundDifference);
        }

        private void DrawDiscoveredDifference(Rectangle rect)
        {
            void DrawBorder(Graphics g, Rectangle r)
            {
                using (var outerPen = new System.Drawing.Pen(Color.White, 5))
                {
                    outerPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    g.DrawRectangle(outerPen, r);
                }
                using (var middlePen = new System.Drawing.Pen(Color.FromArgb(94, 148, 255), 3))
                {
                    middlePen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    g.DrawRectangle(middlePen, r);
                }
                using (var innerPen = new System.Drawing.Pen(Color.Black, 1))
                {
                    innerPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    g.DrawRectangle(innerPen, r);
                }
            }

            if (pbOriginalImage.Image != null)
            {
                using (Graphics g = Graphics.FromImage(pbOriginalImage.Image))
                {
                    DrawBorder(g, rect);
                }
                pbOriginalImage.Invalidate();
            }

            if (pbEditedImage.Image != null)
            {
                using (Graphics g = Graphics.FromImage(pbEditedImage.Image))
                {
                    DrawBorder(g, rect);
                }
                pbEditedImage.Invalidate();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            parent.LoadControl(new GameControl(parent));
            if (gameTimer != null) { gameTimer.Stop(); }
            if (df != null)
            {
                df.Close();
            }
            if (this.Parent is Form parentForm)
            {
                parentForm.Controls.Remove(this);
            }
        }
        #endregion

        // updating timer and attempts
        #region
        private void UpdateDifferencesFoundDisplay()
        {
            this.differencesFoundLabel.Text = $"{differencesCount} / {discoveredDifferencesCount}";
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameEnded)  return; 
            Console.WriteLine("Tike: " + isGameEnded);
            
            timeLeftInSeconds--;
            UpdateTimerDisplay();

            if (timeLeftInSeconds <= 10)
            {
                sp.PlaySound(@"Resources\Sounds\Alarm_Clock_Sound.wav");
            }

            if (timeLeftInSeconds <= 10)
            {
                lblTimer.ForeColor = Color.FromArgb(216, 49, 54);


                if (timeLeftInSeconds % 2 == 0)
                {
                    lblTimer.ForeColor = Color.FromArgb(160, 20, 24);
                }
                else
                {
                    lblTimer.ForeColor = Color.FromArgb(216, 49, 54);
                }
            }

            if (timeLeftInSeconds <= 0)
            {
                gameTimer.Stop();
                lblTimer.ForeColor = Color.FromArgb(160, 20, 24);
                OnGameOver();
            }
        }

        private void UpdateTimerDisplay()
        {

            int minutes = timeLeftInSeconds / 60;
            int seconds = timeLeftInSeconds % 60;
            lblTimer.Text = $"Timer: {minutes:00}:{seconds:00}";
           

            if (timeLeftInSeconds <= 10)
            {
                lblTimer.ForeColor = Color.FromArgb(216, 49, 54);
            }
        }

        private void UpdateAttemptsDisplay()
        {
            lblAttempts.Text = $"Attempts: {attemptsLeft}";
            if (attemptsLeft <= differencesCount)
            {
                lblAttempts.ForeColor = Color.FromArgb(216, 49, 54);
            }
            else
            {
                lblAttempts.ForeColor = Color.Black;
            }
        }

        #endregion


        //visual effects
        #region
        private void ShowFeedbackIcon(bool isCorrect)
        {
            string rightIconPath = Path.Combine(Application.StartupPath, "Resources", "Graphics", "right.png");
            string wrongIconPath = Path.Combine(Application.StartupPath, "Resources", "Graphics", "wrong.png");

            Image rightIcon = Image.FromFile(rightIconPath);
            Image wrongIcon = Image.FromFile(wrongIconPath);
            pbFeedbackIcon.Image = isCorrect ? rightIcon : wrongIcon;
            pbFeedbackIcon.Visible = true;
            fadeAlpha = 255;
            pbFeedbackIcon.Image = SetImageOpacity(pbFeedbackIcon.Image, fadeAlpha / 255f);
            fadeTimer.Start();
        }
        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            fadeAlpha -= 2;
            if (fadeAlpha <= 0)
            {
                fadeTimer.Stop();
                pbFeedbackIcon.Visible = false;
                return;
            }

            pbFeedbackIcon.Image = SetImageOpacity(pbFeedbackIcon.Image, fadeAlpha / 255f);
        }

        private Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }


        #endregion

        //debugging
        #region
        private void ShowDebuggingForm()
        {
            df.Show();
        }


        #endregion

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeTimer_Tick;

            pbFeedbackIcon.BackColor = Color.Transparent;
            pbFeedbackIcon.Visible = false;
        }
    }
}