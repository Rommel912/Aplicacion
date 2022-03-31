using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=HECTOR-ALFARO\\SQLEXPRESS";;Initial Catalog=Tiendaropa;Integrated Security=true")


        private void Form2_Load(object sender, EventArgs e)
        {
            String Select = "Select * from Cliente";
            SqlDataAdapter adapter = new SqlDataAdapter(Select, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void btnagg_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvlista);

            file.Cells[0].Value = lblcodigo.Text;
            file.Cells[1].Value = lblnombre.Text;
            file.Cells[2].Value = lblprecio.Text;
            file.Cells[3].Value = txtcantidad.Text;
            file.Cells[4].Value = (float.Parse(lblprecio.Text)*float.Parse(txtcantidad.Text)).ToString();

            dgvlista.Rows.Add(file);

            lblcodigo.Text = lblnombre.Text = lblprecio.Text = txtcantidad.Text = "";

            obtenerTotal();
                                      
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
