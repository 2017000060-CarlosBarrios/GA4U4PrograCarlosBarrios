using System;
using System.Drawing;
using System.Windows.Forms;

namespace GA4PrograEje5
{
    public partial class Form1 : Form
    {
        private bool estaEncendida = false;
        private int canalActual = 1;
        private int volumenActual = 1;
        public Form1()
        {
            InitializeComponent();
            ActualizarPantalla();
        }
        private void ActualizarPantalla()
        {
            if (estaEncendida)
            {
                // Muestra el canal y volumen formateados a dos dígitos (ej: 01, 02...)
                lblPantalla.Text = $"CANAL: {canalActual:D2}  |  VOLUMEN: {volumenActual:D2}";
                lblPantalla.ForeColor = Color.Lime; // Texto en verde estilo LED
            }
            else
            {
                // Muestra TV APAGADA cuando la televisión está desactivada
                lblPantalla.Text = "TV APAGADA";
                lblPantalla.ForeColor = Color.Red; // Texto en rojo
            }
        }

        private void btnEncenderApagar_Click(object sender, EventArgs e)
        {
            estaEncendida = !estaEncendida;
            if (estaEncendida)
            {
                canalActual = 1;
                volumenActual = 1;
            }
            ActualizarPantalla();
        }
        private void btnSubirCanal_Click(object sender, EventArgs e)
        {
            if (!estaEncendida)
                return;
            if (canalActual < 75)
            {
                canalActual++;
            }
            else
            {
                canalActual = 1;
            }
            ActualizarPantalla();
        }

        private void btnBajarCanal_Click(object sender, EventArgs e)
        {
            if (!estaEncendida)
                return;
            if (canalActual > 1)
            {
                canalActual--;
            }
            else
            {
                canalActual = 75; // Vuelve al canal 75 al bajar del canal 1
            }
            ActualizarPantalla();
        }

        private void btnSubirVolumen_Click(object sender, EventArgs e)
        {
            if (!estaEncendida) 
            return;
            if (volumenActual < 30)
            {
                volumenActual++;
                ActualizarPantalla();
            }
        }

        private void btnBajarVolumen_Click(object sender, EventArgs e)
        {
            if (!estaEncendida) 
            return;
            if (volumenActual > 1)
            {
                volumenActual--;
                ActualizarPantalla();
            }
        }
    }
}
