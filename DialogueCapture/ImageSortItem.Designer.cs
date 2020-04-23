namespace DialogueCapture
{
    partial class ImageSortItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePb = new System.Windows.Forms.PictureBox();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePb
            // 
            this.imagePb.Location = new System.Drawing.Point(3, 3);
            this.imagePb.Name = "imagePb";
            this.imagePb.Size = new System.Drawing.Size(128, 83);
            this.imagePb.TabIndex = 0;
            this.imagePb.TabStop = false;
            // 
            // upBtn
            // 
            this.upBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.upBtn.Location = new System.Drawing.Point(137, 3);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 25);
            this.upBtn.TabIndex = 1;
            this.upBtn.Text = "Move Up";
            this.upBtn.UseVisualStyleBackColor = true;
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(137, 61);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 25);
            this.downBtn.TabIndex = 2;
            this.downBtn.Text = "Move Down";
            this.downBtn.UseVisualStyleBackColor = true;
            // 
            // ImageSortItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.imagePb);
            this.Name = "ImageSortItem";
            this.Size = new System.Drawing.Size(215, 89);
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePb;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
    }
}
