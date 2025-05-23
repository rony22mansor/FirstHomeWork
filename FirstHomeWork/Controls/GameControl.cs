using FirstHomeWork.Helpers;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FirstHomeWork
{
    public partial class GameControl : UserControl
    {


        private MainForm parent;
        private int timeLeftInSeconds;
        private DifficultyLevel currentDifficulty;
        private Guna2Panel selectedPanel;
        private int selectedLevelNumber;

        public GameControl(MainForm parentForm, DifficultyLevel difficulty = DifficultyLevel.Hard)
        {
            InitializeComponent();
            LoadLevelImages();
            PopulateDropdowns();
            parent = parentForm;
            selectedLevelNumber = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DifficultyLevel difficulty = SelectedDifficulty;
            GameMode gameMode = SelectedPlayerMode;
            parent.LoadControl(new GameplayControl(parent, gameMode, selectedLevelNumber, difficulty));
        }


        private void LoadLevelImages()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "Levels");

            for (int i = 1; i <= 5; i++)
            {
                string imgPath = Path.Combine(imagePath, $"level{i}.jpg");
                if (File.Exists(imgPath))
                {
                    Guna2PictureBox pb = new Guna2PictureBox
                    {
                        Image = Image.FromFile(imgPath),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Dock = DockStyle.Fill,
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle,
                        FillColor = Color.Transparent,
                        Cursor = Cursors.Hand
                    };

                    Guna2Panel panel = new Guna2Panel
                    {
                        Size = new Size(250, 250),
                        Padding = new Padding(14),
                        Margin = new Padding(20, 0, 20, 0),
                        FillColor = Color.Transparent,
                        BorderRadius = 10,


                        Tag = i
                    };
                    panel.ShadowDecoration.BorderRadius = 10;
                    panel.ShadowDecoration.Enabled = true;
                    panel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                    panel.ShadowDecoration.Depth = 60;
                    panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 8);

                    pb.Click += (s, e) =>
                    {
                        if (selectedPanel != null)
                        {
                            selectedPanel.FillColor = Color.Transparent;
                        }
                        selectedPanel = panel;
                        selectedPanel.BorderRadius = 10;
                        selectedPanel.FillColor = Color.FromArgb(94, 148, 255);
                        selectedLevelNumber = (int)panel.Tag;
                    };

                    panel.Controls.Add(pb);
                    levels.Controls.Add(panel);

                    if (i == 1)
                    {
                        selectedPanel = panel;
                        selectedPanel.BorderRadius = 10;
                        selectedPanel.FillColor = Color.FromArgb(94, 148, 255);
                        selectedLevelNumber = 1;
                    }
                }
            }
        }

        private void PopulateDropdowns()
        {
            difficultyDropDown.DataSource = Enum.GetValues(typeof(DifficultyLevel));
            difficultyDropDown.SelectedIndex = 0;

            gameModeDropDown.DataSource = Enum.GetValues(typeof(GameMode));
            gameModeDropDown.SelectedIndex = 0;
        }


        public DifficultyLevel SelectedDifficulty
        {
            get
            {
                if (difficultyDropDown.SelectedItem != null)
                {
                    return (DifficultyLevel)difficultyDropDown.SelectedItem;
                }
                return DifficultyLevel.Easy;
            }
        }

        public GameMode SelectedPlayerMode
        {
            get
            {
                if (gameModeDropDown.SelectedItem != null)
                {
                    return (GameMode)gameModeDropDown.SelectedItem;
                }
                return GameMode.Attempts;
            }
        }

        private void difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine($"Difficulty changed to: {SelectedDifficulty}");
        }

        private void gameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine($"Player Mode changed to: {SelectedPlayerMode}");
        }
    }
}
