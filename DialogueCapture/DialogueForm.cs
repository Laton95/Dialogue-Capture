using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DialogueCapture
{
    public partial class dialogueFrm : Form
    {
        int xPos;
        int yPos;

        int clicks = 0;

        public dialogueFrm()
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

        private void FindDialogueBtn_Click(object sender, EventArgs e)
        {
            FindDialogue();
        }

        private void FindDialogue()
        {
            bool found = false;

            foreach (Screen screen in Screen.AllScreens)
            {
                if (found)
                {
                    break;
                }

                Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(screenshot as Image);
                graphics.CopyFromScreen(screen.Bounds.Left, screen.Bounds.Top, 0, 0, screenshot.Size);

                Bitmap search;
                int xOffset;
                int yOffset;

                if (gameCB.SelectedIndex == 0)
                {
                    search = new Bitmap(Properties.Resources.template);
                    xOffset = 220;
                    yOffset = 125;
                }
                else
                {
                    search = new Bitmap(Properties.Resources.template_old);
                    xOffset = 0;
                    yOffset = 0;
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
                                
                                xPos = x - consecutivePixels + screen.Bounds.Left - xOffset;
                                yPos = y - yOffset;
                                found = true;
                                break;
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

            if (!found)
            {
                MessageBox.Show("Dialogue not found.");
            }
            else
            {
                screenshotBtn.Enabled = true;
                instantSaveBtn.Enabled = true;
            }
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
                string folderName = getFolderPath();
                
                try
                {
                    Directory.CreateDirectory(folderName);
                    string path = string.Format(folderName + "/{0}.png", DateTime.Now.ToString("ss-mm-HH-dd-MM-yyyy"));

                    image.Save(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + " (Probably bad subfolder name).");
                }
            }
        }

        private string getFolderPath()
        {
            string folderName = "Dialogue Screenshots";
            string subfolder = subfolderTb.Text;

            if (subfolder.Length > 0)
            {
                folderName += @"\" + subfolder;
            }

            return folderName;
        }

        private void FrameTmr_Tick(object sender, EventArgs e)
        {
            if (dialoguePb.Image != null)
            {
                TakeScreenshot();
            }
        }

        private void AnimatedCb_CheckedChanged(object sender, EventArgs e)
        {
            frameTmr.Enabled = animatedCb.Checked;
        }

        private void DialoguePb_Click(object sender, EventArgs e)
        {
            clicks++;
            if (clicks > 2)
            {
                animatedCb.Visible = true;
            }
        }

        private void FolderBtn_Click(object sender, EventArgs e)
        {
            string folderName = getFolderPath();
            
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderName,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }
    }
}