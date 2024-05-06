namespace Music_Player
{
    partial class frm_player
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_player));
            wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            lstPlay = new ListBox();
            btnFolder = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)wmp1).BeginInit();
            SuspendLayout();
            // 
            // wmp1
            // 
            wmp1.Enabled = true;
            wmp1.Location = new Point(12, 12);
            wmp1.Name = "wmp1";
            wmp1.OcxState = (AxHost.State)resources.GetObject("wmp1.OcxState");
            wmp1.Size = new Size(652, 484);
            wmp1.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(678, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(110, 48);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open Videos";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstPlay
            // 
            lstPlay.FormattingEnabled = true;
            lstPlay.Location = new Point(12, 502);
            lstPlay.Name = "lstPlay";
            lstPlay.Size = new Size(776, 164);
            lstPlay.TabIndex = 2;
            lstPlay.SelectedIndexChanged += lstPlay_SelectedIndexChanged;
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(678, 76);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(114, 48);
            btnFolder.TabIndex = 3;
            btnFolder.Text = "Choose Folder";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnClose
            // 
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(678, 146);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 45);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frm_player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 673);
            Controls.Add(btnClose);
            Controls.Add(btnFolder);
            Controls.Add(lstPlay);
            Controls.Add(btnOpen);
            Controls.Add(wmp1);
            Name = "frm_player";
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)wmp1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private ListBox lstPlay;
        private Button btnFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnClose;
    }
}
