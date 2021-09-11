using Domain.Entities;
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
    public partial class FrmEliminar : Form
    {
        DBProductos db = new DBProductos();
        Producto prod;
        public FrmEliminar()
        {
            InitializeComponent();
            foreach (Producto p in db.GetProductos())
            {
                listBox1.Items.Add(p.Id + " " + p.Nombre);
            }
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               string[] id = listBox1.SelectedItem.ToString().Split(' ');
               int di = int.Parse(id[0]);
               prod = db.GetProductos().FirstOrDefault(_prod => _prod.Id == di);
            }
            catch(Exception a)
            {
                return;
            }
            
            


            

            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] id = listBox1.SelectedItem.ToString().Split(' ');
                int di = int.Parse(id[0]);
                prod = db.GetProductos().FirstOrDefault(_prod => _prod.Id == di);
            }
            catch (Exception a)
            {
                return;
            }

            var result = MessageBox.Show(this, "¿Seguro que desea Borrar el registro?", "Borrar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                db.Eliminar(prod);
                db.Guardar();
                Dispose();
            }
            else
            {
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
