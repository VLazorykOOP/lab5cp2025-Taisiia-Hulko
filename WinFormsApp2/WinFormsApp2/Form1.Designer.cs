namespace WinFormsApp2
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBoxA = new TextBox();
            label1 = new Label();
            textBoxB = new TextBox();
            label3 = new Label();
            textBoxK = new TextBox();
            buttonDraw = new Button();
            pictureBoxCanvas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 78);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 1;
            label2.Text = "B:";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(122, 19);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 26);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "А:";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(122, 71);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 129);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "K (порядок):";
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(122, 122);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(125, 27);
            textBoxK.TabIndex = 6;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(122, 164);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(125, 29);
            buttonDraw.TabIndex = 7;
            buttonDraw.Text = "Намалювати";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.BackColor = Color.White;
            pictureBoxCanvas.Location = new Point(269, 19);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(507, 419);
            pictureBoxCanvas.TabIndex = 8;
            pictureBoxCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxCanvas);
            Controls.Add(buttonDraw);
            Controls.Add(textBoxK);
            Controls.Add(label3);
            Controls.Add(textBoxB);
            Controls.Add(label1);
            Controls.Add(textBoxA);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxA;
        private Label label1;
        private TextBox textBoxB;
        private Label label3;
        private TextBox textBoxK;
        private Button buttonDraw;
        private PictureBox pictureBoxCanvas;
    }
}
