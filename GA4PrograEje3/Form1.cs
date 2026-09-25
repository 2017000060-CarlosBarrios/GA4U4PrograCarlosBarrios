namespace GA4PrograEje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarToolTips();
        }
        private void ConfigurarToolTips()
        {
            toolTip1.SetToolTip(txtNombre, "Ingrese los nombres y apellidos completos (Obligatorio)");
            toolTip1.SetToolTip(txtEdad, "Ingrese la edad en números enteros (Obligatorio)");
            toolTip1.SetToolTip(txtSalario, "Ingrese el salario mensual en quetzales (Obligatorio)");
            toolTip1.SetToolTip(txtDescripcion, "Ingrese una descripción adicional (Opcional)");
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hayError = false;
            // Validación de Nombres (Campos obligatorios)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es un campo obligatorio.");
                hayError = true;
            }
            // Validación de Edad
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                errorProvider1.SetError(txtEdad, "La edad es un campo obligatorio.");
                hayError = true;
            }
            else if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                errorProvider1.SetError(txtEdad, "Ingrese una edad válida (número entero mayor a 0).");
                hayError = true;
            }
            // Validación de Salario
            if (string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                errorProvider1.SetError(txtSalario, "El salario es un campo obligatorio.");
                hayError = true;
            }
            else if (!double.TryParse(txtSalario.Text, out double salario) || salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Ingrese un valor de salario válido.");
                hayError = true;
            }
            // Mensaje de éxito si no hay errores
            if (!hayError)
            {
                MessageBox.Show("Datos ingresados y validados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtSalario.Clear();
            txtDescripcion.Clear();
            errorProvider1.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
