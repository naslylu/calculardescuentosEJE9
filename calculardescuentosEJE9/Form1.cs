using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculardescuentosEJE9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_montototal.Text, out decimal montoTotal))
            {
                
                decimal descuento = 0;
                decimal itbis = 0.18m; 

                if (montoTotal >= 5001 && montoTotal <= 10000)
                {
                    descuento = montoTotal * 0.03m;
                }
                else if (montoTotal >= 10001 && montoTotal <= 15000)
                {
                    descuento = montoTotal * 0.05m;
                }
                else if (montoTotal >= 15001 && montoTotal <= 20000)
                {
                    descuento = montoTotal * 0.08m;
                }
                else if (montoTotal > 20000)
                {
                    descuento = montoTotal * 0.10m;
                }

                
                decimal montoNeto = montoTotal - descuento - (montoTotal * itbis);

                
                txt_descuento.Text = descuento.ToString("C");
                txt_itbis.Text = (montoTotal * itbis).ToString("C");
                txt_montototal.Text = montoTotal.ToString("C");
                txt_montoneto.Text = montoNeto.ToString("C");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto total válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_descuento.Clear();
            txt_itbis.Clear();
            txt_montototal.Clear();
            txt_montoneto.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

