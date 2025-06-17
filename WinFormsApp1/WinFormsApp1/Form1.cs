using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form  // ������� ����� �� 'partial'
    {
        private Point[] controlPoints = new Point[4];
        private bool isDragging = false;
        private int selectedPoint = -1;

        public Form1()
        {
            // ��� ����� ���������� ����������� � Form1.Designer.cs
            InitializeComponent();

            // �������� ������������
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            this.Text = "����� �����";

            // ����������� �����
            controlPoints[0] = new Point(100, 400);
            controlPoints[1] = new Point(200, 100);
            controlPoints[2] = new Point(600, 100);
            controlPoints[3] = new Point(700, 400);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // ������� ����� �����
            g.DrawBezier(Pens.Red, controlPoints[0], controlPoints[1],
                         controlPoints[2], controlPoints[3]);

            // ������� ��������� �����
            for (int i = 0; i < 4; i++)
            {
                g.FillEllipse(Brushes.Blue, controlPoints[i].X - 5,
                             controlPoints[i].Y - 5, 10, 10);
                g.DrawString($"P{i + 1}", this.Font, Brushes.Black,
                            controlPoints[i].X + 10, controlPoints[i].Y - 10);
            }

            // ˳� �� �������
            g.DrawLines(Pens.LightGray, controlPoints);
        }

        // ��������� ���� ����...
        protected override void OnMouseDown(MouseEventArgs e) { /* ... */ }
        protected override void OnMouseMove(MouseEventArgs e) { /* ... */ }
        protected override void OnMouseUp(MouseEventArgs e) { /* ... */ }
    }
}