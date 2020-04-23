using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCapture
{
    public partial class DialogueForm : Form
    {
        enum Game
        {
            RUNESCAPE,
            OLDSCHOOL
        }

        int xPos;
        int yPos;

        public DialogueForm()
        {
            InitializeComponent();
            gameCB.SelectedIndex = 0;
        }

        private void ScreenshotBtn_Click(object sender, EventArgs e)
        {
            TakeScreenshot();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveScreenshot();
        }

        private void InstantSaveBtn_Click(object sender, EventArgs e)
        {
            TakeScreenshot();
            SaveScreenshot();
        }

        private async void FindDialogueBtn_Click(object sender, EventArgs e)
        {
            screenshotBtn.Enabled = false;
            instantSaveBtn.Enabled = false;

            Tuple<int, int> start = null;

            Game game = gameCB.SelectedIndex == 0 ? Game.RUNESCAPE : Game.OLDSCHOOL;

            await Task.Run(() =>
            {
                start = FindDialogue(game);
            });

            if (start == null)
            {
                MessageBox.Show("Dialogue not found.");
            }
            else
            {
                xPos = start.Item1;
                yPos = start.Item2;
                screenshotBtn.Enabled = true;
                instantSaveBtn.Enabled = true;
            }
        }

        private Tuple<int, int> FindDialogue(Game game)
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(screenshot as Image);
                graphics.CopyFromScreen(screen.Bounds.Left, screen.Bounds.Top, 0, 0, screenshot.Size);

                Bitmap search;
                int xOffset;
                int yOffset;

                switch (game)
                {
                    case Game.RUNESCAPE:
                        search = new Bitmap(Properties.Resources.template);
                        xOffset = 220;
                        yOffset = 125;
                        break;
                    case Game.OLDSCHOOL:
                        search = new Bitmap(Properties.Resources.template_old);
                        xOffset = 0;
                        yOffset = 0;
                        break;
                    default:
                        return null;
                }

                for (int y = 0; y < screenshot.Height; y++)
                {
                    int consecutivePixels = 0;

                    for (int x = 0; x < screenshot.Width; x++)
                    {
                        if (consecutivePixels < search.Width && screenshot.GetPixel(x, y).Equals(search.GetPixel(consecutivePixels, 0)))
                        {
                            if (consecutivePixels > 50)
                            {
                                return new Tuple<int, int>(x - consecutivePixels + screen.Bounds.Left - xOffset, y - yOffset + screen.Bounds.Top);
                            }

                            consecutivePixels++;
                        }
                        else
                        {
                            consecutivePixels = 0;
                        }
                    }
                }
            }

            return null;
        }

        private void TakeScreenshot()
        {
            int xSize;
            int ySize;

            if (gameCB.SelectedIndex == 0)
            {
                xSize = 522;
                ySize = 146;
            }
            else
            {
                xSize = 518;
                ySize = 141;
            }

            Bitmap screenshot = new Bitmap(xSize, ySize);
            Graphics graphics = Graphics.FromImage(screenshot as Image);
            graphics.CopyFromScreen(xPos, yPos, 0, 0, screenshot.Size);

            dialoguePb.SizeMode = PictureBoxSizeMode.Zoom;
            dialoguePb.Image = screenshot;

            saveBtn.Enabled = true;
        }

        private void SaveScreenshot()
        {
            Image image = dialoguePb.Image;
            if (image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Png Image|*.png",
                    Title = "Save the dialogue screenshot",
                    FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"),
                    InitialDirectory = GetDirectory()
                };

                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                    image.Save(fileStream, ImageFormat.Png);
                    fileStream.Close();
                }
            }
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = GetDirectory(),
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }

        public static string GetDirectory()
        {
            string directory =  Environment.CurrentDirectory + @"\Dialogue Screenshots";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return directory;
        }

        private void stitchBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            List<Bitmap> images = new List<Bitmap>();

            foreach (string fileName in openFileDialog.FileNames)
            {
                images.Add(new Bitmap(fileName));
            }

            if (images.Count > 0)
            {
                StitchForm form = new StitchForm(images);
                form.Show();
            }
        }
    }
}