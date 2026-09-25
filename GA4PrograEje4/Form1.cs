namespace GA4PrograEje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtMaterno.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de concatenar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Concatenación de cadenas con espacios intermedios
            string nombre = txtNombre.Text.Trim();
            string apellidoPaterno = txtPaterno.Text.Trim();
            string apellidoMaterno = txtMaterno.Text.Trim();
            // Asignar el resultado al TextBox de Nombre Completo
            txtNombreCompleto.Text = $"{nombre} {apellidoPaterno} {apellidoMaterno}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombreCompleto.Clear();
            txtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
