namespace RSoft.MacroPad.Controls.Tabs
{
    partial class SystemKeyTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rbPower = new System.Windows.Forms.RadioButton();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.rbWake = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbPower
            // 
            this.rbPower.AutoSize = true;
            this.rbPower.Location = new System.Drawing.Point(4, 4);
            this.rbPower.Name = "rbPower";
            this.rbPower.Size = new System.Drawing.Size(55, 17);
            this.rbPower.TabIndex = 0;
            this.rbPower.TabStop = true;
            this.rbPower.Text = "Power";
            this.rbPower.UseVisualStyleBackColor = true;
            this.rbPower.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.Location = new System.Drawing.Point(4, 27);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(52, 17);
            this.rbSleep.TabIndex = 0;
            this.rbSleep.TabStop = true;
            this.rbSleep.Text = "Sleep";
            this.rbSleep.UseVisualStyleBackColor = true;
            this.rbSleep.Click += new System.EventHandler(this.KeyChanged);
            // 
            // rbWake
            // 
            this.rbWake.AutoSize = true;
            this.rbWake.Location = new System.Drawing.Point(4, 50);
            this.rbWake.Name = "rbWake";
            this.rbWake.Size = new System.Drawing.Size(54, 17);
            this.rbWake.TabIndex = 0;
            this.rbWake.TabStop = true;
            this.rbWake.Text = "Wake";
            this.rbWake.UseVisualStyleBackColor = true;
            this.rbWake.Click += new System.EventHandler(this.KeyChanged);
            // 
            // SystemKeyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbWake);
            this.Controls.Add(this.rbSleep);
            this.Controls.Add(this.rbPower);
            this.MaximumSize = new System.Drawing.Size(1800, 120);
            this.MinimumSize = new System.Drawing.Size(800, 120);
            this.Name = "SystemKeyTab";
            this.Size = new System.Drawing.Size(800, 120);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RadioButton rbPower;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.Windows.Forms.RadioButton rbWake;
    }
}
