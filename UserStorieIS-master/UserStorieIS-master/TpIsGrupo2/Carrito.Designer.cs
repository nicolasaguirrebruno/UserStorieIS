namespace TpIsGrupo2
{
    partial class Carrito
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            label1 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            process1 = new System.Diagnostics.Process();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            subtotal = new Label();
            label2 = new Label();
            cantProducto = new NumericUpDown();
            btnComprar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            total = new Label();
            groupBox2 = new GroupBox();
            pictureBox5 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 36, 34);
            label1.Location = new Point(111, 13);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 4;
            label1.Text = "Carrito de Compras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(120, 83, 101);
            label3.Location = new Point(135, 31);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 9;
            label3.Text = "Hamburguesa Simple";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth8Bit;
            imageList3.ImageSize = new Size(16, 16);
            imageList3.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 21);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 21);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(subtotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cantProducto);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 173);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.BackColor = Color.Transparent;
            subtotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subtotal.ForeColor = Color.Black;
            subtotal.Location = new Point(291, 139);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(19, 21);
            subtotal.TabIndex = 26;
            subtotal.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(120, 83, 101);
            label2.Location = new Point(22, 139);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 25;
            label2.Text = "Subtotal (sin envío) :";
            // 
            // cantProducto
            // 
            cantProducto.BorderStyle = BorderStyle.FixedSingle;
            cantProducto.Font = new Font("Cyntho Next", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cantProducto.Location = new Point(147, 72);
            cantProducto.Name = "cantProducto";
            cantProducto.ReadOnly = true;
            cantProducto.Size = new Size(69, 31);
            cantProducto.TabIndex = 24;
            cantProducto.TabStop = false;
            cantProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cantProducto.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(192, 133, 162);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(82, 330);
            btnComprar.Margin = new Padding(3, 2, 3, 2);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(245, 48);
            btnComprar.TabIndex = 25;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-110, 288);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(248, 382);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(304, 256);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(120, 83, 101);
            label5.Location = new Point(16, 14);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 28;
            label5.Text = "Total:";
            // 
            // total
            // 
            total.AutoSize = true;
            total.BackColor = Color.Transparent;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            total.ForeColor = Color.Black;
            total.Location = new Point(291, 19);
            total.Name = "total";
            total.Size = new Size(19, 21);
            total.TabIndex = 29;
            total.Text = "$";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(total);
            groupBox2.Location = new Point(12, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 47);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(303, -9);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(194, 178);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(23, 9);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(42, 40);
            button5.TabIndex = 20;
            button5.UseVisualStyleBackColor = false;
            // 
            // Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(390, 432);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnComprar);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carrito";
            Text = "Carrito";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Diagnostics.Process process1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NumericUpDown cantProducto;
        private Label label2;
        private Label subtotal;
        private Button btnComprar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label total;
        private Label label5;
        private GroupBox groupBox2;
        private PictureBox pictureBox5;
        private Button button5;
    }
}