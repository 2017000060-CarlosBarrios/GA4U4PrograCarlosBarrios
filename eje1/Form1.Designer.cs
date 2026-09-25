namespace GA4PrograEje1
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
            btnAceptar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            txtResultado = new TextBox();
            grpResultado = new GroupBox();
            grpResultado.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(299, 59);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 31);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(299, 122);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 31);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(299, 181);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 31);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 1;
            label1.Text = "Dia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 126);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 1;
            label2.Text = "Mes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 189);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 1;
            label3.Text = "Año:";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(79, 67);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(138, 23);
            txtDia.TabIndex = 2;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(79, 129);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(138, 23);
            txtMes.TabIndex = 2;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(79, 188);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(138, 23);
            txtAño.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(24, 22);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(250, 23);
            txtResultado.TabIndex = 4;
            // 
            // grpResultado
            // 
            grpResultado.Controls.Add(txtResultado);
            grpResultado.Location = new Point(55, 256);
            grpResultado.Name = "grpResultado";
            grpResultado.Size = new Size(341, 69);
            grpResultado.TabIndex = 5;
            grpResultado.TabStop = false;
            grpResultado.Text = "En letras:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(grpResultado);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Name = "Form1";
            Text = "Form1";
            grpResultado.ResumeLayout(false);
            grpResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private TextBox txtResultado;
        private GroupBox grpResultado;
    }
}
