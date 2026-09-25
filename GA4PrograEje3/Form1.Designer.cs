namespace GA4PrograEje3
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnEnviar = new Button();
            btnSalir = new Button();
            btnNuevo = new Button();
            txtSalario = new TextBox();
            txtEdad = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnviar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos:";
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(188, 303);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(111, 42);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(317, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 42);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(58, 303);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(111, 42);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(121, 113);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(120, 23);
            txtSalario.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(121, 75);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(120, 23);
            txtEdad.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(121, 155);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(241, 117);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 0;
            label4.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 113);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 0;
            label3.Text = "Salario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 75);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 0;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEnviar;
        private Button btnSalir;
        private Button btnNuevo;
        private TextBox txtSalario;
        private TextBox txtEdad;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ToolTip toolTip1;
    }
}
