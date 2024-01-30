namespace Centroide
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Canvas canvas;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            Init();
            AngleSqr.Text = "Angle Sqr: 0";
            AngleTrig.Text = "Angle Trig: 0";
            AngleSqrTextBox.KeyDown += AngleSqrTextBox_TextChanged;
            AngleTrigTextBox.KeyDown += AngleTrigTextBox_TextChanged;

        }

        private void Init()
        {
            bmp = new Bitmap(PTB.Width, PTB.Height);
            g = Graphics.FromImage(bmp);
            PTB.Image = bmp;
            canvas = new Canvas(bmp);
            canvas.RenderPlanes(g);
            canvas.Render(g);

            PTB.Invalidate();
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {

            UpdateAngles();
            PTB.Refresh();
        }
        private void UpdateAngles()
        {
            double normalAngleSqr = canvas.Cuadrado.GetTotalRotation();
            double normalAngleTrig = canvas.Triangulo.GetTotalRotation();

            AngleSqr.Text = $"Angle Sqr: {normalAngleSqr:F2}°";
            AngleTrig.Text = $"Angle Trig: {normalAngleTrig:F2}°";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(0, -5);
            canvas.Update(g);
        }

        private void Yminus_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(0, 5);
            canvas.Update(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(5, 0);
            canvas.Update(g);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.MoveFigure(-5, 0);
            canvas.Update(g);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void RotateLeft_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.RotateRight(-5);

            canvas.Update(g);
        }

        private void RotateRight_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.RotateRight(5);

            canvas.Update(g);
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.CenterFigure();
            canvas.Triangulo.CenterFigure();
            canvas.Update(g);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            canvas.Clean(g);
            Init();
            PTB.Invalidate();
        }

        private void ScaleUp_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.ScaleFigure((float)1.1);
            canvas.Update(g);
        }

        private void ScaleMin_Click(object sender, EventArgs e)
        {
            canvas.Cuadrado.ScaleFigure((float)-0.9);
            canvas.Update(g);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Xminus2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.MoveFigure(-5, 0);
            canvas.Update(g);
        }

        private void Yplus2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.MoveFigure(0, -5);
            canvas.Update(g);
        }

        private void Yminus2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.MoveFigure(0, 5);
            canvas.Update(g);
        }

        private void Xplus2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.MoveFigure(5, 0);
            canvas.Update(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ScaleUp2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.ScaleFigure((float)1.1);
            canvas.Update(g);
        }

        private void ScaleMin2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.ScaleFigure((float)-0.9);
            canvas.Triangulo.RotateRight(180);
            canvas.Update(g);
        }

        private void RotateLeft2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.RotateRight(-5);

            canvas.Update(g);
        }

        private void RotateRight2_Click(object sender, EventArgs e)
        {
            canvas.Triangulo.RotateRight(5);


            canvas.Update(g);
        }

        private void AngleTag_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AngleSqrTextBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(AngleSqrTextBox.Text, out float angle))
                {
                    canvas.Cuadrado.RotateRight(angle);
                    UpdateAngles();
                    canvas.Update(g);
                }
            }
        }

        private void AngleTrigTextBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(AngleTrigTextBox.Text, out float angle))
                {
                    canvas.Triangulo.RotateRight(angle);
                    UpdateAngles();
                    canvas.Update(g);
                }
            }
        }
    }
}
