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
    public partial class FrmProducto : Form
    {
        ProductoModel ProductoModel = new ProductoModel();
        DBProductos db = new DBProductos();
       
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = db.GetProductos().Last().Id + 1,
                Nombre = txtName.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExist.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida) cmbMeasureUnit.SelectedIndex
            };

            db.Insertar(p);

            // Real ata la muelte oite kbron 

            

            Dispose();
        }

        private void cmbMeasureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
