namespace Centroide
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            PTB = new PictureBox();
            TIMER = new System.Windows.Forms.Timer(components);
            Yplus = new Button();
            Yminus = new Button();
            Xplus = new Button();
            Xminus = new Button();
            ClearButton = new Button();
            CenterButton = new Button();
            AngleSqr = new Label();
            ScaleMin = new Button();
            ScaleUp = new Button();
            RotateLeft = new Button();
            RotateRight = new Button();
            RotateRight2 = new Button();
            RotateLeft2 = new Button();
            ScaleUp2 = new Button();
            ScaleMin2 = new Button();
            Xminus2 = new Button();
            Xplus2 = new Button();
            Yminus2 = new Button();
            Yplus2 = new Button();
            label1 = new Label();
            label2 = new Label();
            AngleTrig = new Label();
            AngleSqrTextBox = new TextBox();
            AngleTrigTextBox = new TextBox();
            InTriangAngle = new Label();
            InputAngleSqr = new Label();
            ((System.ComponentModel.ISupportInitialize)PTB).BeginInit();
            SuspendLayout();
            // 
            // PTB
            // 
            PTB.BackColor = SystemColors.ActiveCaptionText;
            PTB.Location = new Point(-1, 92);
            PTB.Name = "PTB";
            PTB.Size = new Size(1165, 585);
            PTB.TabIndex = 0;
            PTB.TabStop = false;
            // 
            // TIMER
            // 
            TIMER.Enabled = true;
            TIMER.Tick += TIMER_Tick;
            // 
            // Yplus
            // 
            Yplus.Location = new Point(252, 850);
            Yplus.Name = "Yplus";
            Yplus.Size = new Size(150, 46);
            Yplus.TabIndex = 1;
            Yplus.Text = "Y+";
            Yplus.UseVisualStyleBackColor = true;
            Yplus.Click += button1_Click;
            // 
            // Yminus
            // 
            Yminus.Location = new Point(252, 935);
            Yminus.Name = "Yminus";
            Yminus.Size = new Size(150, 46);
            Yminus.TabIndex = 2;
            Yminus.Text = "Y-";
            Yminus.UseVisualStyleBackColor = true;
            Yminus.Click += Yminus_Click;
            // 
            // Xplus
            // 
            Xplus.Location = new Point(439, 893);
            Xplus.Name = "Xplus";
            Xplus.Size = new Size(150, 46);
            Xplus.TabIndex = 3;
            Xplus.Text = "X+";
            Xplus.UseVisualStyleBackColor = true;
            Xplus.Click += button3_Click;
            // 
            // Xminus
            // 
            Xminus.Location = new Point(62, 893);
            Xminus.Name = "Xminus";
            Xminus.Size = new Size(150, 46);
            Xminus.TabIndex = 4;
            Xminus.Text = "X-";
            Xminus.UseVisualStyleBackColor = true;
            Xminus.Click += button4_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Lime;
            ClearButton.Location = new Point(952, 716);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 46);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // CenterButton
            // 
            CenterButton.Location = new Point(771, 716);
            CenterButton.Name = "CenterButton";
            CenterButton.Size = new Size(150, 46);
            CenterButton.TabIndex = 8;
            CenterButton.Text = "Center";
            CenterButton.UseVisualStyleBackColor = true;
            CenterButton.Click += CenterButton_Click;
            // 
            // AngleSqr
            // 
            AngleSqr.AutoSize = true;
            AngleSqr.BackColor = SystemColors.ButtonHighlight;
            AngleSqr.Font = new Font("Segoe UI", 15F);
            AngleSqr.Location = new Point(12, 20);
            AngleSqr.Name = "AngleSqr";
            AngleSqr.Size = new Size(281, 54);
            AngleSqr.TabIndex = 9;
            AngleSqr.Text = "Angle Square: ";
            AngleSqr.Click += AngleTag_Click;
            // 
            // ScaleMin
            // 
            ScaleMin.Location = new Point(952, 850);
            ScaleMin.Name = "ScaleMin";
            ScaleMin.Size = new Size(150, 46);
            ScaleMin.TabIndex = 10;
            ScaleMin.Text = "Scale-";
            ScaleMin.UseVisualStyleBackColor = true;
            ScaleMin.Click += ScaleMin_Click;
            // 
            // ScaleUp
            // 
            ScaleUp.Location = new Point(771, 850);
            ScaleUp.Name = "ScaleUp";
            ScaleUp.Size = new Size(150, 46);
            ScaleUp.TabIndex = 11;
            ScaleUp.Text = "Scale+";
            ScaleUp.UseVisualStyleBackColor = true;
            ScaleUp.Click += ScaleUp_Click;
            // 
            // RotateLeft
            // 
            RotateLeft.Location = new Point(771, 928);
            RotateLeft.Name = "RotateLeft";
            RotateLeft.Size = new Size(150, 46);
            RotateLeft.TabIndex = 12;
            RotateLeft.Text = "<- Rotate";
            RotateLeft.UseVisualStyleBackColor = true;
            RotateLeft.Click += RotateLeft_Click;
            // 
            // RotateRight
            // 
            RotateRight.Location = new Point(952, 928);
            RotateRight.Name = "RotateRight";
            RotateRight.Size = new Size(150, 46);
            RotateRight.TabIndex = 13;
            RotateRight.Text = "Rotate ->";
            RotateRight.UseVisualStyleBackColor = true;
            RotateRight.Click += RotateRight_Click;
            // 
            // RotateRight2
            // 
            RotateRight2.Location = new Point(952, 1206);
            RotateRight2.Name = "RotateRight2";
            RotateRight2.Size = new Size(150, 46);
            RotateRight2.TabIndex = 21;
            RotateRight2.Text = "Rotate ->";
            RotateRight2.UseVisualStyleBackColor = true;
            RotateRight2.Click += RotateRight2_Click;
            // 
            // RotateLeft2
            // 
            RotateLeft2.Location = new Point(771, 1206);
            RotateLeft2.Name = "RotateLeft2";
            RotateLeft2.Size = new Size(150, 46);
            RotateLeft2.TabIndex = 20;
            RotateLeft2.Text = "<- Rotate";
            RotateLeft2.UseVisualStyleBackColor = true;
            RotateLeft2.Click += RotateLeft2_Click;
            // 
            // ScaleUp2
            // 
            ScaleUp2.Location = new Point(771, 1128);
            ScaleUp2.Name = "ScaleUp2";
            ScaleUp2.Size = new Size(150, 46);
            ScaleUp2.TabIndex = 19;
            ScaleUp2.Text = "Scale+";
            ScaleUp2.UseVisualStyleBackColor = true;
            ScaleUp2.Click += ScaleUp2_Click;
            // 
            // ScaleMin2
            // 
            ScaleMin2.Location = new Point(952, 1128);
            ScaleMin2.Name = "ScaleMin2";
            ScaleMin2.Size = new Size(150, 46);
            ScaleMin2.TabIndex = 18;
            ScaleMin2.Text = "Scale-";
            ScaleMin2.UseVisualStyleBackColor = true;
            ScaleMin2.Click += ScaleMin2_Click;
            // 
            // Xminus2
            // 
            Xminus2.Location = new Point(62, 1171);
            Xminus2.Name = "Xminus2";
            Xminus2.Size = new Size(150, 46);
            Xminus2.TabIndex = 17;
            Xminus2.Text = "X-";
            Xminus2.UseVisualStyleBackColor = true;
            Xminus2.Click += Xminus2_Click;
            // 
            // Xplus2
            // 
            Xplus2.Location = new Point(439, 1171);
            Xplus2.Name = "Xplus2";
            Xplus2.Size = new Size(150, 46);
            Xplus2.TabIndex = 16;
            Xplus2.Text = "X+";
            Xplus2.UseVisualStyleBackColor = true;
            Xplus2.Click += Xplus2_Click;
            // 
            // Yminus2
            // 
            Yminus2.Location = new Point(252, 1213);
            Yminus2.Name = "Yminus2";
            Yminus2.Size = new Size(150, 46);
            Yminus2.TabIndex = 15;
            Yminus2.Text = "Y-";
            Yminus2.UseVisualStyleBackColor = true;
            Yminus2.Click += Yminus2_Click;
            // 
            // Yplus2
            // 
            Yplus2.Location = new Point(252, 1128);
            Yplus2.Name = "Yplus2";
            Yplus2.Size = new Size(150, 46);
            Yplus2.TabIndex = 14;
            Yplus2.Text = "Y+";
            Yplus2.UseVisualStyleBackColor = true;
            Yplus2.Click += Yplus2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(62, 783);
            label1.Name = "label1";
            label1.Size = new Size(146, 54);
            label1.TabIndex = 22;
            label1.Text = "Square";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(62, 1066);
            label2.Name = "label2";
            label2.Size = new Size(163, 54);
            label2.TabIndex = 23;
            label2.Text = "Triangle";
            // 
            // AngleTrig
            // 
            AngleTrig.AutoSize = true;
            AngleTrig.BackColor = SystemColors.ButtonHighlight;
            AngleTrig.Font = new Font("Segoe UI", 15F);
            AngleTrig.Location = new Point(499, 20);
            AngleTrig.Name = "AngleTrig";
            AngleTrig.Size = new Size(298, 54);
            AngleTrig.TabIndex = 24;
            AngleTrig.Text = "Angle Triangle: ";
            // 
            // AngleSqrTextBox
            // 
            AngleSqrTextBox.Location = new Point(224, 1008);
            AngleSqrTextBox.Name = "AngleSqrTextBox";
            AngleSqrTextBox.Size = new Size(200, 39);
            AngleSqrTextBox.TabIndex = 25;
            
            // 
            // AngleTrigTextBox
            // 
            AngleTrigTextBox.Location = new Point(224, 1297);
            AngleTrigTextBox.Name = "AngleTrigTextBox";
            AngleTrigTextBox.Size = new Size(200, 39);
            AngleTrigTextBox.TabIndex = 26;
            
            // 
            // InTriangAngle
            // 
            InTriangAngle.AutoSize = true;
            InTriangAngle.BackColor = SystemColors.ButtonHighlight;
            InTriangAngle.Font = new Font("Segoe UI", 12F);
            InTriangAngle.Location = new Point(31, 1290);
            InTriangAngle.Name = "InTriangAngle";
            InTriangAngle.Size = new Size(194, 45);
            InTriangAngle.TabIndex = 27;
            InTriangAngle.Text = "Input Angle:";
            InTriangAngle.Click += label3_Click;
            // 
            // InputAngleSqr
            // 
            InputAngleSqr.AutoSize = true;
            InputAngleSqr.BackColor = SystemColors.ButtonHighlight;
            InputAngleSqr.Font = new Font("Segoe UI", 12F);
            InputAngleSqr.Location = new Point(31, 1002);
            InputAngleSqr.Name = "InputAngleSqr";
            InputAngleSqr.Size = new Size(194, 45);
            InputAngleSqr.TabIndex = 28;
            InputAngleSqr.Text = "Input Angle:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1163, 1363);
            Controls.Add(InputAngleSqr);
            Controls.Add(InTriangAngle);
            Controls.Add(AngleTrigTextBox);
            Controls.Add(AngleSqrTextBox);
            Controls.Add(AngleTrig);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RotateRight2);
            Controls.Add(RotateLeft2);
            Controls.Add(ScaleUp2);
            Controls.Add(ScaleMin2);
            Controls.Add(Xminus2);
            Controls.Add(Xplus2);
            Controls.Add(Yminus2);
            Controls.Add(Yplus2);
            Controls.Add(RotateRight);
            Controls.Add(RotateLeft);
            Controls.Add(ScaleUp);
            Controls.Add(ScaleMin);
            Controls.Add(AngleSqr);
            Controls.Add(CenterButton);
            Controls.Add(ClearButton);
            Controls.Add(Xminus);
            Controls.Add(Xplus);
            Controls.Add(Yminus);
            Controls.Add(Yplus);
            Controls.Add(PTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PTB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PTB;
        private System.Windows.Forms.Timer TIMER;
        private Button Yplus;
        private Button Yminus;
        private Button Xplus;
        private Button Xminus;
        private Button ClearButton;
        private Button CenterButton;
        private Label AngleTag;
        private Button ScaleMin;
        private Button ScaleUp;
        private Button RotateLeft;
        private Button RotateRight;
        private Button RotateRight2;
        private Button RotateLeft2;
        private Button ScaleUp2;
        private Button ScaleMin2;
        private Button Xminus2;
        private Button Xplus2;
        private Button Yminus2;
        private Button Yplus2;
        private Label label1;
        private Label label2;
        private Label AngleTrig;
        private Label AngleSqr;
        private TextBox AngleSqrTextBox;
        private TextBox AngleTrigTextBox;
        private Label InTriangAngle;
        private Label InputAngleSqr;
    }
}
