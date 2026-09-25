namespace GA4PrograEje2
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
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            btnCalcular = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            label3 = new Label();
            txtSueldo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 63);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 0;
            label2.Text = "Cargo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(202, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(129, 66);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(202, 23);
            txtCargo.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(55, 137);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 33);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(177, 137);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 33);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(307, 137);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 219);
            label3.Name = "label3";
            label3.Size = new Size(227, 23);
            label3.TabIndex = 0;
            label3.Text = "Sueldo Correspondiente:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(245, 222);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(202, 23);
            txtSueldo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 303);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtSueldo);
            Controls.Add(txtCargo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private Button btnCalcular;
        private Button btnNuevo;
        private Button btnSalir;
        private Label label3;
        private TextBox txtSueldo;
    }
}
