namespace GA4PrograEje5
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
            btnSubirVolumen = new Button();
            btnBajarVolumen = new Button();
            btnSubirCanal = new Button();
            btnBajarCanal = new Button();
            lblPantalla = new Label();
            btnEncenderApagar = new Button();
            SuspendLayout();
            // 
            // btnSubirVolumen
            // 
            btnSubirVolumen.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirVolumen.Location = new Point(86, 221);
            btnSubirVolumen.Name = "btnSubirVolumen";
            btnSubirVolumen.Size = new Size(45, 55);
            btnSubirVolumen.TabIndex = 0;
            btnSubirVolumen.Text = "+";
            btnSubirVolumen.UseVisualStyleBackColor = true;
            btnSubirVolumen.Click += btnSubirVolumen_Click;
            // 
            // btnBajarVolumen
            // 
            btnBajarVolumen.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBajarVolumen.Location = new Point(86, 292);
            btnBajarVolumen.Name = "btnBajarVolumen";
            btnBajarVolumen.Size = new Size(45, 55);
            btnBajarVolumen.TabIndex = 0;
            btnBajarVolumen.Text = "-";
            btnBajarVolumen.UseVisualStyleBackColor = true;
            btnBajarVolumen.Click += btnBajarVolumen_Click;
            // 
            // btnSubirCanal
            // 
            btnSubirCanal.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirCanal.Location = new Point(225, 221);
            btnSubirCanal.Name = "btnSubirCanal";
            btnSubirCanal.Size = new Size(45, 55);
            btnSubirCanal.TabIndex = 0;
            btnSubirCanal.Text = "+";
            btnSubirCanal.UseVisualStyleBackColor = true;
            btnSubirCanal.Click += btnSubirCanal_Click;
            // 
            // btnBajarCanal
            // 
            btnBajarCanal.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBajarCanal.Location = new Point(225, 292);
            btnBajarCanal.Name = "btnBajarCanal";
            btnBajarCanal.Size = new Size(45, 55);
            btnBajarCanal.TabIndex = 0;
            btnBajarCanal.Text = "-";
            btnBajarCanal.UseVisualStyleBackColor = true;
            btnBajarCanal.Click += btnBajarCanal_Click;
            // 
            // lblPantalla
            // 
            lblPantalla.BackColor = Color.Black;
            lblPantalla.BorderStyle = BorderStyle.Fixed3D;
            lblPantalla.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPantalla.ForeColor = Color.Red;
            lblPantalla.Location = new Point(12, 26);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(340, 73);
            lblPantalla.TabIndex = 1;
            lblPantalla.Text = "TV APAGADA";
            lblPantalla.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEncenderApagar
            // 
            btnEncenderApagar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncenderApagar.Location = new Point(53, 149);
            btnEncenderApagar.Name = "btnEncenderApagar";
            btnEncenderApagar.Size = new Size(253, 40);
            btnEncenderApagar.TabIndex = 0;
            btnEncenderApagar.Text = "Encendido / Apagado";
            btnEncenderApagar.UseVisualStyleBackColor = true;
            btnEncenderApagar.Click += btnEncenderApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 455);
            Controls.Add(lblPantalla);
            Controls.Add(btnBajarCanal);
            Controls.Add(btnSubirCanal);
            Controls.Add(btnBajarVolumen);
            Controls.Add(btnEncenderApagar);
            Controls.Add(btnSubirVolumen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubirVolumen;
        private Button btnBajarVolumen;
        private Button btnSubirCanal;
        private Button btnBajarCanal;
        private Label lblPantalla;
        private Button btnEncenderApagar;
    }
}
