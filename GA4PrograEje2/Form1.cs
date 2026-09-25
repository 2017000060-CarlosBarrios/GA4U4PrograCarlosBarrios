namespace GA4PrograEje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Por favor, ingrese un cargo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cargo = txtCargo.Text.Trim().ToLower();
            double sueldo = 0;
            switch (cargo)
            {
                case "gerente":
                    sueldo = 5000.00;
                    break;
                case "administrado":
                case "administrador":
                    sueldo = 4500.00;
                    break;
                case "secretaria":
                case "secretario":
                    sueldo = 3500.00;
                    break;
                case "contador":
                case "contadora":
                    sueldo = 4000.00;
                    break;
                default:
                    MessageBox.Show("El cargo ingresado no es válido.\nCargos disponibles: Gerente, Administrado, Secretaria, Contador.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSueldo.Clear();
                    return;
            }
            txtSueldo.Text = $"Q. {sueldo:F2}";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
