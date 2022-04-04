using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cmbprenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbprenda.SelectedIndex;
            nom = cmbprenda.SelectedItem.ToString();
            precio = cmbprenda.SelectedIndex;

            switch (cod)
            {
                case 0: lblcodigo.Text = "JXL0201";break;
                case 1: lblcodigo.Text = "GXL0201";break;
                default: lblcodigo.Text = "CXL0201";break;
            }

            switch (nom)
            {
                case "Pantalon": lblnombre.Text = "Pantalon";break;
                case "Gorro": lblnombre.Text = "Gorro";break;
                default: lblnombre.Text = "Calcetas";break;
            }

            switch (precio)
            {
                case 0: lblprecio.Text = "$80";break;
                case 1: lblprecio.Text = "$45";break;
                default: lblprecio.Text = "$12";break;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {   
            

            
                                      
        }

        public void obtenerTotal()
        {
            float costo = 0;
            int contador = 0;

            contador = dgvlista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costo += float.Parse(dgvlista.Rows[i].Cells[4].Value.ToString());
            }

            lblpagar.Text = costo.ToString();

        }

        private void lbl14_Click(object sender, EventArgs e)
        {

        }

        private void lblpagar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try {
                DialogResult rppta = MessageBox.Show("¿Eliminar prenda?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(rppta == DialogResult.Yes)
                {
                    dgvlista.Rows.Remove(dgvlista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
