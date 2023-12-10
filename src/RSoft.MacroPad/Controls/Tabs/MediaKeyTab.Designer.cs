namespace RSoft.MacroPad.Controls.Tabs
{
    partial class MediaKeyTab
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
            this.rbTrackPrev = new System.Windows.Forms.RadioButton();
            this.rbTrackNext = new System.Windows.Forms.RadioButton();
            this.rbTrackPlay = new System.Windows.Forms.RadioButton();
            this.rbVolUp = new System.Windows.Forms.RadioButton();
            this.rbVolDown = new System.Windows.Forms.RadioButton();
            this.rbVolMute = new System.Windows.Forms.RadioButton();
            this.rbMediaPlayer = new System.Windows.Forms.RadioButton();
            this.rbCalculator = new System.Windows.Forms.RadioButton();
            this.rbLocalComputer = new System.Windows.Forms.RadioButton();
            this.rbHomepage = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbSearch = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbTrackPrev
            // 
            this.rbTrackPrev.AutoSize = true;
            this.rbTrackPrev.Location = new System.Drawing.Point(4, 4);
            this.rbTrackPrev.Name = "rbTrackPrev";
            this.rbTrackPrev.Size = new System.Drawing.Size(93, 17);
            this.rbTrackPrev.TabIndex = 0;
            this.rbTrackPrev.TabStop = true;
            this.rbTrackPrev.Text = "Previous track";
            this.rbTrackPrev.UseVisualStyleBackColor = true;
            this.rbTrackPrev.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbTrackNext
            // 
            this.rbTrackNext.AutoSize = true;
            this.rbTrackNext.Location = new System.Drawing.Point(4, 27);
            this.rbTrackNext.Name = "rbTrackNext";
            this.rbTrackNext.Size = new System.Drawing.Size(74, 17);
            this.rbTrackNext.TabIndex = 0;
            this.rbTrackNext.TabStop = true;
            this.rbTrackNext.Text = "Next track";
            this.rbTrackNext.UseVisualStyleBackColor = true;
            this.rbTrackNext.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbTrackPlay
            // 
            this.rbTrackPlay.AutoSize = true;
            this.rbTrackPlay.Location = new System.Drawing.Point(4, 50);
            this.rbTrackPlay.Name = "rbTrackPlay";
            this.rbTrackPlay.Size = new System.Drawing.Size(86, 17);
            this.rbTrackPlay.TabIndex = 0;
            this.rbTrackPlay.TabStop = true;
            this.rbTrackPlay.Text = "Play / Pause";
            this.rbTrackPlay.UseVisualStyleBackColor = true;
            this.rbTrackPlay.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbVolUp
            // 
            this.rbVolUp.AutoSize = true;
            this.rbVolUp.Location = new System.Drawing.Point(129, 4);
            this.rbVolUp.Name = "rbVolUp";
            this.rbVolUp.Size = new System.Drawing.Size(75, 17);
            this.rbVolUp.TabIndex = 0;
            this.rbVolUp.TabStop = true;
            this.rbVolUp.Text = "Volume up";
            this.rbVolUp.UseVisualStyleBackColor = true;
            this.rbVolUp.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbVolDown
            // 
            this.rbVolDown.AutoSize = true;
            this.rbVolDown.Location = new System.Drawing.Point(129, 27);
            this.rbVolDown.Name = "rbVolDown";
            this.rbVolDown.Size = new System.Drawing.Size(89, 17);
            this.rbVolDown.TabIndex = 0;
            this.rbVolDown.TabStop = true;
            this.rbVolDown.Text = "Volume down";
            this.rbVolDown.UseVisualStyleBackColor = true;
            this.rbVolDown.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbVolMute
            // 
            this.rbVolMute.AutoSize = true;
            this.rbVolMute.Location = new System.Drawing.Point(129, 50);
            this.rbVolMute.Name = "rbVolMute";
            this.rbVolMute.Size = new System.Drawing.Size(97, 17);
            this.rbVolMute.TabIndex = 0;
            this.rbVolMute.TabStop = true;
            this.rbVolMute.Text = "Mute / Unmute";
            this.rbVolMute.UseVisualStyleBackColor = true;
            this.rbVolMute.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbMediaPlayer
            // 
            this.rbMediaPlayer.AutoSize = true;
            this.rbMediaPlayer.Location = new System.Drawing.Point(260, 4);
            this.rbMediaPlayer.Name = "rbMediaPlayer";
            this.rbMediaPlayer.Size = new System.Drawing.Size(85, 17);
            this.rbMediaPlayer.TabIndex = 0;
            this.rbMediaPlayer.TabStop = true;
            this.rbMediaPlayer.Text = "Media player";
            this.rbMediaPlayer.UseVisualStyleBackColor = true;
            this.rbMediaPlayer.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbCalculator
            // 
            this.rbCalculator.AutoSize = true;
            this.rbCalculator.Location = new System.Drawing.Point(260, 27);
            this.rbCalculator.Name = "rbCalculator";
            this.rbCalculator.Size = new System.Drawing.Size(73, 17);
            this.rbCalculator.TabIndex = 0;
            this.rbCalculator.TabStop = true;
            this.rbCalculator.Text = "Calculator";
            this.rbCalculator.UseVisualStyleBackColor = true;
            this.rbCalculator.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbLocalComputer
            // 
            this.rbLocalComputer.AutoSize = true;
            this.rbLocalComputer.Location = new System.Drawing.Point(260, 50);
            this.rbLocalComputer.Name = "rbLocalComputer";
            this.rbLocalComputer.Size = new System.Drawing.Size(96, 17);
            this.rbLocalComputer.TabIndex = 0;
            this.rbLocalComputer.TabStop = true;
            this.rbLocalComputer.Text = "Local computer";
            this.rbLocalComputer.UseVisualStyleBackColor = true;
            this.rbLocalComputer.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbHomepage
            // 
            this.rbHomepage.AutoSize = true;
            this.rbHomepage.Location = new System.Drawing.Point(390, 4);
            this.rbHomepage.Name = "rbHomepage";
            this.rbHomepage.Size = new System.Drawing.Size(79, 17);
            this.rbHomepage.TabIndex = 0;
            this.rbHomepage.TabStop = true;
            this.rbHomepage.Text = "Homepage";
            this.rbHomepage.UseVisualStyleBackColor = true;
            this.rbHomepage.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(390, 27);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 0;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            this.rbEmail.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbSearch
            // 
            this.rbSearch.AutoSize = true;
            this.rbSearch.Location = new System.Drawing.Point(390, 50);
            this.rbSearch.Name = "rbSearch";
            this.rbSearch.Size = new System.Drawing.Size(59, 17);
            this.rbSearch.TabIndex = 0;
            this.rbSearch.TabStop = true;
            this.rbSearch.Text = "Search";
            this.rbSearch.UseVisualStyleBackColor = true;
            this.rbSearch.Click += new System.EventHandler(this.KeyChanged);
            // 
            // MediaKeyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbSearch);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbHomepage);
            this.Controls.Add(this.rbLocalComputer);
            this.Controls.Add(this.rbCalculator);
            this.Controls.Add(this.rbMediaPlayer);
            this.Controls.Add(this.rbVolMute);
            this.Controls.Add(this.rbTrackPlay);
            this.Controls.Add(this.rbVolDown);
            this.Controls.Add(this.rbTrackNext);
            this.Controls.Add(this.rbVolUp);
            this.Controls.Add(this.rbTrackPrev);
            this.MaximumSize = new System.Drawing.Size(1800, 120);
            this.MinimumSize = new System.Drawing.Size(800, 120);
            this.Name = "MediaKeyTab";
            this.Size = new System.Drawing.Size(800, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTrackPrev;
        private System.Windows.Forms.RadioButton rbTrackNext;
        private System.Windows.Forms.RadioButton rbTrackPlay;
        private System.Windows.Forms.RadioButton rbVolUp;
        private System.Windows.Forms.RadioButton rbVolDown;
        private System.Windows.Forms.RadioButton rbVolMute;
        private System.Windows.Forms.RadioButton rbMediaPlayer;
        private System.Windows.Forms.RadioButton rbCalculator;
        private System.Windows.Forms.RadioButton rbLocalComputer;
        private System.Windows.Forms.RadioButton rbHomepage;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbSearch;
    }
}
