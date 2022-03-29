using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroTemperatura
{
    public partial class Temperaturas : Form
    {
        public Temperaturas()
        {
            InitializeComponent();
            CentrarTitulo();

        }
        int ContadorDias;
        DateTime FDias;
        int NMayor;
        int RMayor;
        private void CentrarTitulo()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }


        private void btnAgregarTemperatura_Click(object sender, EventArgs e)
        {

            DateTime FechaSeleccionada = Convert.ToDateTime(dtfecha.Text);
            DateTime FechaActual = DateTime.Today;
            TimeSpan RestaFechas = FechaActual - FechaSeleccionada;

            if (Convert.ToDateTime(dtfecha.Text) < DateTime.Today && RestaFechas.TotalDays == 5)
            {
                txtGrados.Enabled = true;
                btnAgregarGrados.Enabled = true;
                dtfecha.Enabled = false;
                btnAgregarTemperatura.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor seleccionar 5 dias antes de la fecha actual", "Error!");
            }


        }

        private void btnAgregarGrados_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGrados.Text) != true)
            {
                FDias = Convert.ToDateTime(dtfecha.Text).AddDays(ContadorDias);

                int fila = dgTemperatura.Rows.Count - 1;
                dgTemperatura.Rows.Add(1);
                dgTemperatura.Rows[fila].Cells[0].Value = (ContadorDias + 1);
                dgTemperatura.Rows[fila].Cells[1].Value = FDias.Date.DayOfWeek + " " + FDias.Date.Day + "/" + FDias.Date.Month + "/" + FDias.Date.Year;
                dgTemperatura.Rows[fila].Cells[2].Value = txtGrados.Text;

                ContadorDias++;
                lblDiaIngresado.Text = "Se digito la temperatura del dia " + ContadorDias;
                lblDiaIngresado.Visible = true;
                txtGrados.Clear();

                if (ContadorDias <= 4)
                {
                    lblIngresar.Text = "Ingrese la temperatura del dia " + (ContadorDias + 1);
                }
                else
                {
                    lblIngresar.Visible = false;
                    btnAgregarGrados.Enabled = false;
                    txtGrados.Enabled = false;
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            NMayor = 0;
            RMayor = 0;
            foreach (DataGridViewRow Temp in dgTemperatura.Rows)
            {
                DataGridViewCell Columna = Temp.Cells[2];
                if (Convert.ToInt32(Columna.Value) != 0)
                {
                    if (Convert.ToInt32(Columna.Value) > NMayor)
                    {
                        NMayor = Convert.ToInt32(Columna.Value);
                    }
                }
            }
            foreach (DataGridViewRow Temp in dgTemperatura.Rows)
            {
                DataGridViewCell Columna = Temp.Cells[2];
                if (Convert.ToInt32(Columna.Value) == NMayor)
                {
                    RMayor++;
                }
            }
            lblMayorTemp.Visible =true;
            lblRepite.Visible = true;
            lblMayorTemp.Text = "La mayor Temperatura Fue " + NMayor;
            lblRepite.Text = "Se repitio " + RMayor + " en los ultimos 5 dias ";
        }

        private void btnDatoNuevo_Click(object sender, EventArgs e)
        {
            dgTemperatura.Rows.Clear();

            lblMayorTemp.Visible = false;
            lblRepite.Visible = false;
            dtfecha.Value = DateTime.Today;
            dtfecha.Enabled = true;
            btnAgregarTemperatura.Enabled = true;
            txtGrados.Enabled = false;
            btnAgregarGrados.Enabled = false;
            lblDiaIngresado.Visible = false;
            lblIngresar.Text= "Ingrese la temperatura ";
            ContadorDias = 0;
            NMayor = 0;
            RMayor = 0;
        }
    }
}
