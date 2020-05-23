namespace CG_Lab2
{
    partial class Form1
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
            this.glControl1 = new OpenTK.GLControl();
            this.openButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.quadsRadioButton = new System.Windows.Forms.RadioButton();
            this.textureRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tfMinTrackBar = new System.Windows.Forms.TrackBar();
            this.tfWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quadStripRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(200, 0);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(512, 512);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(83, 31);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(12, 178);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 323);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // quadsRadioButton
            // 
            this.quadsRadioButton.AutoSize = true;
            this.quadsRadioButton.Checked = true;
            this.quadsRadioButton.Location = new System.Drawing.Point(15, 63);
            this.quadsRadioButton.Name = "quadsRadioButton";
            this.quadsRadioButton.Size = new System.Drawing.Size(71, 21);
            this.quadsRadioButton.TabIndex = 3;
            this.quadsRadioButton.TabStop = true;
            this.quadsRadioButton.Text = "Quads";
            this.quadsRadioButton.UseVisualStyleBackColor = true;
            // 
            // textureRadioButton
            // 
            this.textureRadioButton.AutoSize = true;
            this.textureRadioButton.Location = new System.Drawing.Point(15, 114);
            this.textureRadioButton.Name = "textureRadioButton";
            this.textureRadioButton.Size = new System.Drawing.Size(77, 21);
            this.textureRadioButton.TabIndex = 4;
            this.textureRadioButton.Text = "Texture";
            this.textureRadioButton.UseVisualStyleBackColor = true;
            this.textureRadioButton.CheckedChanged += new System.EventHandler(this.textureRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transfer Function";
            // 
            // tfMinTrackBar
            // 
            this.tfMinTrackBar.Location = new System.Drawing.Point(74, 224);
            this.tfMinTrackBar.Maximum = 4000;
            this.tfMinTrackBar.Name = "tfMinTrackBar";
            this.tfMinTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tfMinTrackBar.Size = new System.Drawing.Size(56, 277);
            this.tfMinTrackBar.SmallChange = 100;
            this.tfMinTrackBar.TabIndex = 6;
            this.tfMinTrackBar.ValueChanged += new System.EventHandler(this.tfMinTrackBar_ValueChanged);
            // 
            // tfWidthTrackBar
            // 
            this.tfWidthTrackBar.Location = new System.Drawing.Point(138, 224);
            this.tfWidthTrackBar.Maximum = 4000;
            this.tfWidthTrackBar.Minimum = 1;
            this.tfWidthTrackBar.Name = "tfWidthTrackBar";
            this.tfWidthTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tfWidthTrackBar.Size = new System.Drawing.Size(56, 277);
            this.tfWidthTrackBar.SmallChange = 100;
            this.tfWidthTrackBar.TabIndex = 7;
            this.tfWidthTrackBar.Value = 2000;
            this.tfWidthTrackBar.ValueChanged += new System.EventHandler(this.tfWidthTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Layer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Width";
            // 
            // quadStripRadioButton
            // 
            this.quadStripRadioButton.AutoSize = true;
            this.quadStripRadioButton.Location = new System.Drawing.Point(15, 87);
            this.quadStripRadioButton.Name = "quadStripRadioButton";
            this.quadStripRadioButton.Size = new System.Drawing.Size(93, 21);
            this.quadStripRadioButton.TabIndex = 11;
            this.quadStripRadioButton.TabStop = true;
            this.quadStripRadioButton.Text = "QuadStrip";
            this.quadStripRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 513);
            this.Controls.Add(this.quadStripRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfWidthTrackBar);
            this.Controls.Add(this.tfMinTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textureRadioButton);
            this.Controls.Add(this.quadsRadioButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "CG_lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfWidthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton quadsRadioButton;
        private System.Windows.Forms.RadioButton textureRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tfMinTrackBar;
        private System.Windows.Forms.TrackBar tfWidthTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton quadStripRadioButton;
    }
}

