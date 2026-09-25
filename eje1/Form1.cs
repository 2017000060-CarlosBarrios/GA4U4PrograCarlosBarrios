using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GA4PrograEje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDia.Text) ||
                string.IsNullOrWhiteSpace(txtMes.Text) ||
                string.IsNullOrWhiteSpace(txtAño.Text))
            {
                MessageBox.Show("Por favor, Llene todos los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.TryParse(txtDia.Text, out int dia) &&
                int.TryParse(txtMes.Text, out int mes) &&
                int.TryParse(txtAño.Text, out int año))
            {
                string[] meses = {
                    "Enero",
                    "Febrero",
                    "Marzo",
                    "Abril",
                    "Mayo",
                    "Junio",
                    "Julio",
                    "Agosto",
                    "Septiembre",
                    "Octubre",
                    "Noviembre",
                    "Diciembre"
                };
                if (mes >= 1 && mes <= 12)
                {
                    if (dia >= 1 && dia <= 31)
                    {
                        string nombreMes = meses[mes - 1];
                        // Formatear el resultado como: "16 de Abril de 1991"
                        txtResultado.Text = $"{dia} de {nombreMes} de {año}";
                    }
                }
                else
                {
                    MessageBox.Show("El día debe estar entre 1 y 31.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El mes debe ser un número entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDia.Clear();
            txtMes.Clear();
            txtAño.Clear();
            txtResultado.Clear();
            txtDia.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
