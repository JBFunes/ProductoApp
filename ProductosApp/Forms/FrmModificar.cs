using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmModificar : Form
    {
        ProductoModel pm = new ProductoModel();
        DBProductos db = new DBProductos();
        Producto prod;
        public FrmModificar()
        {
            InitializeComponent();
            foreach (Producto p in db.GetProductos())
            {
                listBox.Items.Add(p.Id +" "+ p.Nombre);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
       
            string[] id = listBox.SelectedItem.ToString().Split(' ');
            int di = int.Parse(id[0]);
            

             prod = db.GetProductos().FirstOrDefault(_prod => _prod.Id == di);

            idTxt.Text = prod.Id.ToString();
            nombretxt.Text = prod.Nombre;
            descTxt.Text = prod.Descripcion;
            precioTxt.Value = prod.Precio;
            exisTxt.Value = prod.Existencia;
            cmbUnidades.Items.Clear();
            cmbUnidades.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
            cmbUnidades.SelectedItem = prod.UnidadMedida;



        }

        private void descTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTxt.Text))
            {
                MessageBox.Show(this, "Error al Guardar no hay datos xd", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Datos Editados Exitosamente", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prod.Nombre = nombretxt.Text;
                prod.Precio = precioTxt.Value;
                prod.Descripcion = descTxt.Text;
                prod.Existencia = (int)(exisTxt.Value);
                prod.FechaVencimiento = dateTimePicker1.Value;
                prod.UnidadMedida = (UnidadMedida)Enum.Parse(typeof(UnidadMedida) , cmbUnidades.Text);
                Console.WriteLine();

                db.Guardar();
                Dispose();





            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listBox_Click(object sender, EventArgs e)
        {

            string[] id = listBox.SelectedItem.ToString().Split(' ');
            int di = int.Parse(id[0]);


            prod = db.GetProductos().FirstOrDefault(_prod => _prod.Id == di);

            idTxt.Text = prod.Id.ToString();
            nombretxt.Text = prod.Nombre;
            descTxt.Text = prod.Descripcion;
            precioTxt.Value = prod.Precio;
            exisTxt.Value = prod.Existencia;
            cmbUnidades.Items.Clear();
            cmbUnidades.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
            cmbUnidades.SelectedItem = prod.UnidadMedida;


        }
    }
}
