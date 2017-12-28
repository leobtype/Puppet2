namespace Puppet2
{
    partial class ConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "画像サイズ倍率（パーセント）";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Puppet2.Properties.Settings.Default, "PictureScale", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = global::Puppet2.Properties.Settings.Default.PictureScale;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "動作の速さ（速い～遅い）";
            // 
            // trackBar1
            // 
            this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Puppet2.Properties.Settings.Default, "BlinkDuration", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(15, 70);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(257, 45);
            this.trackBar1.SmallChange = 50;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = global::Puppet2.Properties.Settings.Default.BlinkDuration;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "まばたきの頻度（少ない～多い）";
            // 
            // trackBar2
            // 
            this.trackBar2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Puppet2.Properties.Settings.Default, "BlinkFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar2.LargeChange = 100;
            this.trackBar2.Location = new System.Drawing.Point(12, 138);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Minimum = 50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(260, 45);
            this.trackBar2.SmallChange = 50;
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TickFrequency = 50;
            this.trackBar2.Value = global::Puppet2.Properties.Settings.Default.BlinkFrequency;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Puppet2.Properties.Settings.Default, "ConfigLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = global::Puppet2.Properties.Settings.Default.ConfigLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "設定 - Puppet2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}