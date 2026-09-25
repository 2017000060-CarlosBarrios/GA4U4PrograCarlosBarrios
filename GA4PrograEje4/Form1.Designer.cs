namespace GA4PrograEje4
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
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 116);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 0;
            label3.Text = "Nombre Materno:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(176, 77);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(217, 23);
            txtPaterno.TabIndex = 1;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(176, 119);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(217, 23);
            txtMaterno.TabIndex = 1;
            txtMaterno.TextChanged += txtMaterno_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 173);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 0;
            label4.Text = "Nombre Completo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(12, 209);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.ReadOnly = true;
            txtNombreCompleto.Size = new Size(335, 23);
            txtNombreCompleto.TabIndex = 1;
            txtNombreCompleto.TextChanged += txtMaterno_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 272);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 2;
            button1.Text = "Concatenar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(176, 272);
            button2.Name = "button2";
            button2.Size = new Size(136, 39);
            button2.TabIndex = 2;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(327, 272);
            button3.Name = "button3";
            button3.Size = new Size(136, 39);
            button3.TabIndex = 2;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 352);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private Label label4;
        private TextBox txtNombreCompleto;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
