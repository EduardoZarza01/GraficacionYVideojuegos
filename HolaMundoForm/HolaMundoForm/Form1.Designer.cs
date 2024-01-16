namespace HolaMundoForm
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
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 16F);
            ID.Location = new Point(616, 311);
            ID.Name = "ID";
            ID.Size = new Size(213, 59);
            ID.TabIndex = 0;
            ID.Text = "ID:176220";
            ID.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(472, 406);
            label2.Name = "label2";
            label2.Size = new Size(529, 59);
            label2.TabIndex = 1;
            label2.Text = "Jose Eduardo Zarza Pineda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(472, 488);
            label3.Name = "label3";
            label3.Size = new Size(514, 59);
            label3.TabIndex = 2;
            label3.Text = "Graficacion y Videojuegos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 905);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Name = "Form1";
            Text = "Hola Mundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label label2;
        private Label label3;
    }
}
