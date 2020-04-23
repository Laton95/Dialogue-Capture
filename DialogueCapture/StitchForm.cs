using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCapture
{
    public partial class StitchForm : Form
    {
        private ImageSortItem[] items;

        public StitchForm(List<Bitmap> images)
        {
            InitializeComponent();

            items = new ImageSortItem[images.Count];

            for (int i = 0; i < items.Length; i++)
            {
                ImageSortItem item = new ImageSortItem(images[i]);
                item.Index = i;
                item.UpBtn.Click += (s, e) =>
                {
                    item.Index--;
                    items[item.Index + 1] = items[item.Index];
                    items[item.Index + 1].Index = item.Index + 1;
                    items[item.Index] = item;
                    RefreshPanel(items);
                };
                item.DownBtn.Click += (s, e) =>
                {
                    item.Index++;
                    items[item.Index - 1] = items[item.Index];
                    items[item.Index - 1].Index = item.Index - 1;
                    items[item.Index] = item;
                    RefreshPanel(items);
                };
                items[i] = item;
            }

            RefreshPanel(items);

            saveBtn.Left = imagePnl.Left + 3;
            saveBtn.Top = imagePnl.Bottom + 3;
        }

        private void RefreshPanel(ImageSortItem[] items)
        {
            foreach (ImageSortItem item in items)
            {
                imagePnl.Controls.Add(item);
                item.UpBtn.Enabled = true;
                item.DownBtn.Enabled = true;
                if (item.Index == 0)
                {
                    item.UpBtn.Enabled = false;
                }
                else if (item.Index == items.Length - 1)
                {
                    item.DownBtn.Enabled = false;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<Image> images = (items.Select(item => item.Image)).ToList();

            Bitmap image = StitchDialogues(images);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Png Image|*.png",
                Title = "Save the dialogue screenshot",
                FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"),
                InitialDirectory = DialogueForm.GetDirectory()
            };

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                FileStream fileStream = (FileStream)saveFileDialog.OpenFile();
                image.Save(fileStream, ImageFormat.Png);
                fileStream.Close();
            }

            this.Close();
        }

        private Bitmap StitchDialogues(List<Image> images)
        {
            Bitmap result = new Bitmap(images.Max(i => i.Width), images.Sum(i => i.Height));

            using (Graphics g = Graphics.FromImage(result))
            {
                int y = 0;
                foreach (Image image in images)
                {
                    g.DrawImage(image, new Rectangle(0, y, image.Width, image.Height));
                    y += image.Height;
                }
            }

            return result;
        }
    }
}
