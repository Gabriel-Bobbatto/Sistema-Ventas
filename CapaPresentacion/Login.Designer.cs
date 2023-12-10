namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btingresar = new FontAwesome.Sharp.IconButton();
            btcancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 184);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 134);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE VENTAS";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 109;
            iconPictureBox1.Location = new Point(34, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(109, 119);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 100);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 30);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 82);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña:";
            // 
            // btingresar
            // 
            btingresar.BackColor = Color.SteelBlue;
            btingresar.FlatAppearance.BorderColor = Color.Black;
            btingresar.FlatStyle = FlatStyle.Flat;
            btingresar.ForeColor = Color.White;
            btingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btingresar.IconColor = Color.White;
            btingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btingresar.IconSize = 30;
            btingresar.Location = new Point(184, 134);
            btingresar.Name = "btingresar";
            btingresar.Size = new Size(112, 40);
            btingresar.TabIndex = 7;
            btingresar.Text = "Ingresar";
            btingresar.TextAlign = ContentAlignment.MiddleRight;
            btingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btingresar.UseVisualStyleBackColor = false;
            // 
            // btcancelar
            // 
            btcancelar.BackColor = Color.Firebrick;
            btcancelar.FlatAppearance.BorderColor = Color.Black;
            btcancelar.FlatStyle = FlatStyle.Flat;
            btcancelar.ForeColor = Color.White;
            btcancelar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            btcancelar.IconColor = Color.White;
            btcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btcancelar.IconSize = 30;
            btcancelar.Location = new Point(302, 134);
            btcancelar.Name = "btcancelar";
            btcancelar.Size = new Size(112, 40);
            btcancelar.TabIndex = 8;
            btcancelar.Text = "Salir";
            btcancelar.TextAlign = ContentAlignment.MiddleRight;
            btcancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btcancelar.UseVisualStyleBackColor = false;
            btcancelar.Click += btcancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 184);
            Controls.Add(btcancelar);
            Controls.Add(btingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btingresar;
        private FontAwesome.Sharp.IconButton btcancelar;
    }
}