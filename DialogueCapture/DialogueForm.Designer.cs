namespace DialogueCapture
{
    partial class dialogueFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogueFrm));
            this.dialoguePb = new System.Windows.Forms.PictureBox();
            this.screenshotBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.instantSaveBtn = new System.Windows.Forms.Button();
            this.findDialogueBtn = new System.Windows.Forms.Button();
            this.subfolderTb = new System.Windows.Forms.TextBox();
            this.subfolderLbl = new System.Windows.Forms.Label();
            this.frameTmr = new System.Windows.Forms.Timer(this.components);
            this.animatedCb = new System.Windows.Forms.CheckBox();
            this.folderBtn = new System.Windows.Forms.Button();
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
            this.dialoguePb.Click += new System.EventHandler(this.DialoguePb_Click);
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
            // findDialogueBtn
            // 
            this.findDialogueBtn.Location = new System.Drawing.Point(12, 310);
            this.findDialogueBtn.Name = "findDialogueBtn";
            this.findDialogueBtn.Size = new System.Drawing.Size(80, 23);
            this.findDialogueBtn.TabIndex = 4;
            this.findDialogueBtn.Text = "Find Dialogue";
            this.findDialogueBtn.UseVisualStyleBackColor = true;
            this.findDialogueBtn.Click += new System.EventHandler(this.FindDialogueBtn_Click);
            // 
            // subfolderTb
            // 
            this.subfolderTb.Location = new System.Drawing.Point(585, 312);
            this.subfolderTb.Name = "subfolderTb";
            this.subfolderTb.Size = new System.Drawing.Size(100, 20);
            this.subfolderTb.TabIndex = 5;
            // 
            // subfolderLbl
            // 
            this.subfolderLbl.AutoSize = true;
            this.subfolderLbl.Location = new System.Drawing.Point(484, 315);
            this.subfolderLbl.Name = "subfolderLbl";
            this.subfolderLbl.Size = new System.Drawing.Size(95, 13);
            this.subfolderLbl.TabIndex = 6;
            this.subfolderLbl.Text = "Optional subfolder:";
            // 
            // frameTmr
            // 
            this.frameTmr.Interval = 10;
            this.frameTmr.Tick += new System.EventHandler(this.FrameTmr_Tick);
            // 
            // animatedCb
            // 
            this.animatedCb.AutoSize = true;
            this.animatedCb.Location = new System.Drawing.Point(691, 314);
            this.animatedCb.Name = "animatedCb";
            this.animatedCb.Size = new System.Drawing.Size(70, 17);
            this.animatedCb.TabIndex = 7;
            this.animatedCb.Text = "Animated";
            this.animatedCb.UseVisualStyleBackColor = true;
            this.animatedCb.Visible = false;
            this.animatedCb.CheckedChanged += new System.EventHandler(this.AnimatedCb_CheckedChanged);
            // 
            // folderBtn
            // 
            this.folderBtn.Location = new System.Drawing.Point(98, 310);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBtn.TabIndex = 8;
            this.folderBtn.Text = "Open Folder";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // dialogueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 341);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.animatedCb);
            this.Controls.Add(this.subfolderLbl);
            this.Controls.Add(this.subfolderTb);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dialoguePb;
        private System.Windows.Forms.Button screenshotBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button instantSaveBtn;
        private System.Windows.Forms.Button findDialogueBtn;
        private System.Windows.Forms.TextBox subfolderTb;
        private System.Windows.Forms.Label subfolderLbl;
        private System.Windows.Forms.Timer frameTmr;
        private System.Windows.Forms.CheckBox animatedCb;
        private System.Windows.Forms.Button folderBtn;
    }
}

