namespace WinFormsApp3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            x1Box = new TextBox();
            y1Box = new TextBox();
            z1Box = new TextBox();
            x2Box = new TextBox();
            y2Box = new TextBox();
            z2Box = new TextBox();
            button_add = new Button();
            button_subract = new Button();
            button_scalar = new Button();
            button_vector = new Button();
            button_size = new Button();
            rez1 = new TextBox();
            label4 = new Label();
            rez2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "Введите координаты (x, y, z):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Вектор 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 63);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Вектор 1";
            // 
            // x1Box
            // 
            x1Box.Location = new Point(103, 50);
            x1Box.Margin = new Padding(4, 5, 4, 5);
            x1Box.Name = "x1Box";
            x1Box.Size = new Size(53, 31);
            x1Box.TabIndex = 3;
            // 
            // y1Box
            // 
            y1Box.Location = new Point(166, 50);
            y1Box.Margin = new Padding(4, 5, 4, 5);
            y1Box.Name = "y1Box";
            y1Box.Size = new Size(53, 31);
            y1Box.TabIndex = 4;
            // 
            // z1Box
            // 
            z1Box.Location = new Point(229, 50);
            z1Box.Margin = new Padding(4, 5, 4, 5);
            z1Box.Name = "z1Box";
            z1Box.Size = new Size(53, 31);
            z1Box.TabIndex = 5;
            // 
            // x2Box
            // 
            x2Box.Location = new Point(103, 98);
            x2Box.Margin = new Padding(4, 5, 4, 5);
            x2Box.Name = "x2Box";
            x2Box.Size = new Size(53, 31);
            x2Box.TabIndex = 6;
            // 
            // y2Box
            // 
            y2Box.Location = new Point(166, 98);
            y2Box.Margin = new Padding(4, 5, 4, 5);
            y2Box.Name = "y2Box";
            y2Box.Size = new Size(53, 31);
            y2Box.TabIndex = 7;
            // 
            // z2Box
            // 
            z2Box.Location = new Point(229, 98);
            z2Box.Margin = new Padding(4, 5, 4, 5);
            z2Box.Name = "z2Box";
            z2Box.Size = new Size(53, 31);
            z2Box.TabIndex = 8;
            // 
            // button_add
            // 
            button_add.Location = new Point(17, 147);
            button_add.Margin = new Padding(4, 5, 4, 5);
            button_add.Name = "button_add";
            button_add.Size = new Size(140, 38);
            button_add.TabIndex = 9;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_subract
            // 
            button_subract.Location = new Point(166, 147);
            button_subract.Margin = new Padding(4, 5, 4, 5);
            button_subract.Name = "button_subract";
            button_subract.Size = new Size(117, 38);
            button_subract.TabIndex = 10;
            button_subract.Text = "-";
            button_subract.UseVisualStyleBackColor = true;
            button_subract.Click += button_subract_Click;
            // 
            // button_scalar
            // 
            button_scalar.Location = new Point(17, 195);
            button_scalar.Margin = new Padding(4, 5, 4, 5);
            button_scalar.Name = "button_scalar";
            button_scalar.Size = new Size(266, 38);
            button_scalar.TabIndex = 11;
            button_scalar.Text = "Скалярное произведение";
            button_scalar.UseVisualStyleBackColor = true;
            button_scalar.Click += button_scalar_Click;
            // 
            // button_vector
            // 
            button_vector.Location = new Point(17, 243);
            button_vector.Margin = new Padding(4, 5, 4, 5);
            button_vector.Name = "button_vector";
            button_vector.Size = new Size(266, 38);
            button_vector.TabIndex = 12;
            button_vector.Text = "Векторное произведение";
            button_vector.UseVisualStyleBackColor = true;
            button_vector.Click += button_vector_Click;
            // 
            // button_size
            // 
            button_size.Location = new Point(17, 292);
            button_size.Margin = new Padding(4, 5, 4, 5);
            button_size.Name = "button_size";
            button_size.Size = new Size(266, 38);
            button_size.TabIndex = 13;
            button_size.Text = "Длины векторов";
            button_size.UseVisualStyleBackColor = true;
            button_size.Click += button_size_Click;
            // 
            // rez1
            // 
            rez1.Location = new Point(324, 154);
            rez1.Name = "rez1";
            rez1.Size = new Size(245, 31);
            rez1.TabIndex = 14;
            rez1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 126);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 15;
            label4.Text = "Результат:";
            label4.Click += label4_Click;
            // 
            // rez2
            // 
            rez2.Location = new Point(324, 195);
            rez2.Name = "rez2";
            rez2.Size = new Size(245, 31);
            rez2.TabIndex = 16;
            rez2.TextAlign = HorizontalAlignment.Center;
            rez2.TextChanged += rez2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 347);
            Controls.Add(rez2);
            Controls.Add(label4);
            Controls.Add(rez1);
            Controls.Add(button_size);
            Controls.Add(button_vector);
            Controls.Add(button_scalar);
            Controls.Add(button_subract);
            Controls.Add(button_add);
            Controls.Add(z2Box);
            Controls.Add(y2Box);
            Controls.Add(x2Box);
            Controls.Add(z1Box);
            Controls.Add(y1Box);
            Controls.Add(x1Box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox x1Box;
        private TextBox y1Box;
        private TextBox z1Box;
        private TextBox x2Box;
        private TextBox y2Box;
        private TextBox z2Box;
        private Button button_add;
        private Button button_subract;
        private Button button_scalar;
        private Button button_vector;
        private Button button_size;
        private TextBox rez1;
        private Label label4;
        private TextBox rez2;
    }
}