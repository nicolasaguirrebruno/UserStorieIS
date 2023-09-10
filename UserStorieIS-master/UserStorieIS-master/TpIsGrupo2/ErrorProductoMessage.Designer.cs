namespace TpIsGrupo2
{
    partial class ErrorProductoMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorProductoMessage));
            gradientPanel1 = new GradientPanel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.Transparent;
            gradientPanel1.ColorBottom = Color.FromArgb(240, 230, 239);
            gradientPanel1.ColorTop = Color.FromArgb(224, 224, 224);
            gradientPanel1.Controls.Add(pictureBox2);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(390, 301);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(167, 245);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(157, 236);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(221, 50);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 164);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 82);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(337, 63);
            label2.TabIndex = 2;
            label2.Text = "Debes haber incluido por lo menos un producto en tu carrito para realizar la compra";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 25);
            label1.Name = "label1";
            label1.Size = new Size(242, 35);
            label1.TabIndex = 1;
            label1.Text = "Error al procesar la compra";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ErrorProductoMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 301);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorProductoMessage";
            Text = "ErrorProductoMessage";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}