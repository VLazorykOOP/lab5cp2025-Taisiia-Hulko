using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxA.Text, out int A) ||
                !int.TryParse(textBoxB.Text, out int B) ||
                !int.TryParse(textBoxK.Text, out int K))
            {
                MessageBox.Show("¬вед≥ть коректн≥ значенн€ дл€ A, B та K.");
                return;
            }

            Bitmap bmp = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            // ÷ентр малюванн€ Ч внизу посередин≥
            float x0 = pictureBoxCanvas.Width / 2;
            float y0 = pictureBoxCanvas.Height - 10;

            DrawFractal(g, x0, y0, -90, A, B, K);
            pictureBoxCanvas.Image = bmp;
        }

        private void DrawFractal(Graphics g, float x, float y, float angle, float width, float height, int order)
        {
            if (order == 0)
                return;

            float x1 = x + (float)(Math.Cos(angle * Math.PI / 180) * height);
            float y1 = y + (float)(Math.Sin(angle * Math.PI / 180) * height);

            // ќбмеженн€ кольор≥в у д≥апазон≥ [0..255]
            int red = Math.Min(100 + 30 * order, 255);
            int green = Math.Min(50 + 20 * order, 255);
            int blue = 100;

            Pen pen = new Pen(Color.FromArgb(red, green, blue), 1);
            g.DrawRectangle(pen, x1 - width / 2, y1 - height, width, height);

            // «меншенн€ розм≥ру пр€мокутник≥в
            float newWidth = width * 0.7f;
            float newHeight = height * 0.7f;

            // –екурсивн≥ "г≥лки" п≥д кутами
            DrawFractal(g, x1, y1 - height, angle - 30, newWidth, newHeight, order - 1);
            DrawFractal(g, x1, y1 - height, angle + 30, newWidth, newHeight, order - 1);
        }
    }
}
