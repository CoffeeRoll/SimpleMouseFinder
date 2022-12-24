namespace WinFormsApp1
{
    partial class MainForm
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
            this.bStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOuterColor = new System.Windows.Forms.ComboBox();
            this.cbInnerColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nOuterRad = new System.Windows.Forms.NumericUpDown();
            this.nInnerRad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nOuterThick = new System.Windows.Forms.NumericUpDown();
            this.nInnerThick = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pPreview = new System.Windows.Forms.Panel();
            this.nAlpha = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nOuterRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInnerRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOuterThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInnerThick)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // bStartStop
            // 
            this.bStartStop.Location = new System.Drawing.Point(12, 12);
            this.bStartStop.Name = "bStartStop";
            this.bStartStop.Size = new System.Drawing.Size(222, 41);
            this.bStartStop.TabIndex = 0;
            this.bStartStop.Text = "Start";
            this.bStartStop.UseVisualStyleBackColor = true;
            this.bStartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Outer Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inner Color:";
            // 
            // cbOuterColor
            // 
            this.cbOuterColor.FormattingEnabled = true;
            this.cbOuterColor.Location = new System.Drawing.Point(84, 16);
            this.cbOuterColor.Name = "cbOuterColor";
            this.cbOuterColor.Size = new System.Drawing.Size(121, 23);
            this.cbOuterColor.TabIndex = 3;
            this.cbOuterColor.SelectedIndexChanged += new System.EventHandler(this.cbOuterColor_SelectedIndexChanged);
            // 
            // cbInnerColor
            // 
            this.cbInnerColor.FormattingEnabled = true;
            this.cbInnerColor.Location = new System.Drawing.Point(84, 16);
            this.cbInnerColor.Name = "cbInnerColor";
            this.cbInnerColor.Size = new System.Drawing.Size(121, 23);
            this.cbInnerColor.TabIndex = 4;
            this.cbInnerColor.SelectedIndexChanged += new System.EventHandler(this.cbInnerColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Outer Radius: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inner Radius: ";
            // 
            // nOuterRad
            // 
            this.nOuterRad.Location = new System.Drawing.Point(93, 45);
            this.nOuterRad.Name = "nOuterRad";
            this.nOuterRad.Size = new System.Drawing.Size(112, 23);
            this.nOuterRad.TabIndex = 7;
            this.nOuterRad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nOuterRad.ValueChanged += new System.EventHandler(this.nOuterRad_ValueChanged);
            // 
            // nInnerRad
            // 
            this.nInnerRad.Location = new System.Drawing.Point(90, 45);
            this.nInnerRad.Name = "nInnerRad";
            this.nInnerRad.Size = new System.Drawing.Size(115, 23);
            this.nInnerRad.TabIndex = 8;
            this.nInnerRad.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nInnerRad.ValueChanged += new System.EventHandler(this.nInnerRad_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Outer Thickness: ";
            // 
            // nOuterThick
            // 
            this.nOuterThick.Location = new System.Drawing.Point(109, 74);
            this.nOuterThick.Name = "nOuterThick";
            this.nOuterThick.Size = new System.Drawing.Size(96, 23);
            this.nOuterThick.TabIndex = 10;
            this.nOuterThick.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nOuterThick.ValueChanged += new System.EventHandler(this.nOuterThick_ValueChanged);
            // 
            // nInnerThick
            // 
            this.nInnerThick.Location = new System.Drawing.Point(106, 74);
            this.nInnerThick.Name = "nInnerThick";
            this.nInnerThick.Size = new System.Drawing.Size(99, 23);
            this.nInnerThick.TabIndex = 12;
            this.nInnerThick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nInnerThick.ValueChanged += new System.EventHandler(this.nInnerThick_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inner Thickness: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbOuterColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nOuterThick);
            this.groupBox1.Controls.Add(this.nOuterRad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outer Ring";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbInnerColor);
            this.groupBox2.Controls.Add(this.nInnerThick);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nInnerRad);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inner Ring";
            // 
            // pPreview
            // 
            this.pPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPreview.Location = new System.Drawing.Point(240, 12);
            this.pPreview.Name = "pPreview";
            this.pPreview.Size = new System.Drawing.Size(291, 278);
            this.pPreview.TabIndex = 15;
            // 
            // nAlpha
            // 
            this.nAlpha.Location = new System.Drawing.Point(59, 296);
            this.nAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nAlpha.Name = "nAlpha";
            this.nAlpha.Size = new System.Drawing.Size(171, 23);
            this.nAlpha.TabIndex = 16;
            this.nAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nAlpha.ValueChanged += new System.EventHandler(this.nAlpha_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alpha:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nAlpha);
            this.Controls.Add(this.pPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bStartStop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nOuterRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInnerRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOuterThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInnerThick)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bStartStop;
        private Label label1;
        private Label label2;
        private ComboBox cbOuterColor;
        private ComboBox cbInnerColor;
        private Label label3;
        private Label label4;
        private NumericUpDown nOuterRad;
        private NumericUpDown nInnerRad;
        private Label label5;
        private NumericUpDown nOuterThick;
        private NumericUpDown nInnerThick;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel pPreview;
        private NumericUpDown nAlpha;
        private Label label7;
    }
}