using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueCapture
{
    public partial class ImageSortItem : UserControl
    {
        public Button UpBtn { get; private set; }
        public Button DownBtn { get; private set; }
        public int Index { get; set; }
        public Image Image { get; set; }

        public ImageSortItem(Image image)
        {
            InitializeComponent();

            UpBtn = upBtn;
            DownBtn = downBtn;

            Image = image;
            imagePb.Image = image;
            imagePb.Width = image.Width;
            imagePb.Height = image.Height;

            upBtn.Left = imagePb.Right + 3;
            downBtn.Left = imagePb.Right + 3;
            downBtn.Top = imagePb.Bottom - downBtn.Height;

            this.Width = imagePb.Width + upBtn.Width + 9;
            this.Height = imagePb.Height + 6;
        }
    }
}
