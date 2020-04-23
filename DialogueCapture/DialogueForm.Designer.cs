namespace DialogueCapture
{
    partial class DialogueForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogueForm));
            this.dialoguePb = new System.Windows.Forms.PictureBox();
            this.screenshotBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.findDialogueBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.gameCB = new System.Windows.Forms.ComboBox();
            this.instantSaveBtn = new System.Windows.Forms.Button();
            this.stitchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dialoguePb)).BeginInit();
            this.SuspendLayout();
            // 
            // dialoguePb
            // 
            this.dialoguePb.Location = new System.Drawing.Point(12, 12);
            this.dialoguePb.Name = "dialoguePb";
            this.dialoguePb.Size = new System.Drawing.Size(1044, 292);
            this.dialoguePb.TabIndex = 0;
            this.dialoguePb.TabStop = false;
            // 
            // screenshotBtn
            // 
            this.screenshotBtn.Enabled = false;
            this.screenshotBtn.Location = new System.Drawing.Point(767, 310);
            this.screenshotBtn.Name = "screenshotBtn";
            this.screenshotBtn.Size = new System.Drawing.Size(97, 23);
            this.screenshotBtn.TabIndex = 1;
            this.screenshotBtn.Text = "Take Screenshot";
            this.screenshotBtn.UseVisualStyleBackColor = true;
            this.screenshotBtn.Click += new System.EventHandler(this.ScreenshotBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(870, 310);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save Screenshot";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // findDialogueBtn
            // 
            this.findDialogueBtn.Location = new System.Drawing.Point(161, 310);
            this.findDialogueBtn.Name = "findDialogueBtn";
            this.findDialogueBtn.Size = new System.Drawing.Size(80, 23);
            this.findDialogueBtn.TabIndex = 4;
            this.findDialogueBtn.Text = "Find Dialogue";
            this.findDialogueBtn.UseVisualStyleBackColor = true;
            this.findDialogueBtn.Click += new System.EventHandler(this.FindDialogueBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(247, 310);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.openFolderBtn.TabIndex = 8;
            this.openFolderBtn.Text = "Open Folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // gameCB
            // 
            this.gameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameCB.FormattingEnabled = true;
            this.gameCB.Items.AddRange(new object[] {
            "Runescape",
            "Old School Runescape"});
            this.gameCB.Location = new System.Drawing.Point(12, 312);
            this.gameCB.MaxDropDownItems = 2;
            this.gameCB.Name = "gameCB";
            this.gameCB.Size = new System.Drawing.Size(143, 21);
            this.gameCB.TabIndex = 9;
            // 
            // instantSaveBtn
            // 
            this.instantSaveBtn.Enabled = false;
            this.instantSaveBtn.Location = new System.Drawing.Point(975, 310);
            this.instantSaveBtn.Name = "instantSaveBtn";
            this.instantSaveBtn.Size = new System.Drawing.Size(81, 23);
            this.instantSaveBtn.TabIndex = 3;
            this.instantSaveBtn.Text = "Quick Take";
            this.instantSaveBtn.UseVisualStyleBackColor = true;
            this.instantSaveBtn.Click += new System.EventHandler(this.InstantSaveBtn_Click);
            // 
            // stitchBtn
            // 
            this.stitchBtn.Location = new System.Drawing.Point(328, 310);
            this.stitchBtn.Name = "stitchBtn";
            this.stitchBtn.Size = new System.Drawing.Size(87, 23);
            this.stitchBtn.TabIndex = 10;
            this.stitchBtn.Text = "Stitch Dialogue";
            this.stitchBtn.UseVisualStyleBackColor = true;
            this.stitchBtn.Click += new System.EventHandler(this.stitchBtn_Click);
            // 
            // dialogueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 341);
            this.Controls.Add(this.stitchBtn);
            this.Controls.Add(this.gameCB);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.findDialogueBtn);
            this.Controls.Add(this.instantSaveBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.screenshotBtn);
            this.Controls.Add(this.dialoguePb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dialogueFrm";
            this.Text = "Dialogue Snapper";
            ((System.ComponentModel.ISupportInitialize)(this.dialoguePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dialoguePb;
        private System.Windows.Forms.Button screenshotBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button findDialogueBtn;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.ComboBox gameCB;
        private System.Windows.Forms.Button instantSaveBtn;
        private System.Windows.Forms.Button stitchBtn;
    }
}

