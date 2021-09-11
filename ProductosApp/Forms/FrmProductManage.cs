using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmProductManage : Form
    {
        DBProductos db = new DBProductos();
        public FrmProductManage()
        {
            
            InitializeComponent();
            rtbProductView.Text = JsonConvert.SerializeObject(db.GetProductos(), Formatting.Indented);

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlId.Visible = true;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 1:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = true;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 2:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = true;
                    pnlCaducity.Visible = false;
                    break;
                case 3:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = true;
                    break;
            }
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();

            rtbProductView.Text = JsonConvert.SerializeObject(db.GetProductos(),Formatting.Indented);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmModificar fmr = new FrmModificar();
            fmr.ShowDialog();

            rtbProductView.Text = JsonConvert.SerializeObject(db.GetProductos(), Formatting.Indented);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEliminar frmEliminar = new FrmEliminar();
            frmEliminar.ShowDialog();
            rtbProductView.Text = JsonConvert.SerializeObject(db.GetProductos(), Formatting.Indented);
        }

        private void cmbMeasureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Producto> productosMedidas = new List<Producto>();
            UnidadMedida ud = (UnidadMedida)Enum.Parse(typeof(UnidadMedida), cmbMeasureUnit.Text);
            foreach (Producto p in db.GetProductos())
            {
                if(p.UnidadMedida.Equals(ud))
                {
                    productosMedidas.Add(p);
                }
            }
            rtbProductView.Text = JsonConvert.SerializeObject(productosMedidas, Formatting.Indented);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            List<Producto> productosId = new List<Producto>();
            int id;
            try
            {
                id = int.Parse(txtId.Text);
            } catch (Exception a)
            {
                return;
            }
           
            foreach (Producto p in db.GetProductos())
            {
                if (p.Id == id)
                {
                    productosId.Add(p);
                }
            }
            rtbProductView.Text = JsonConvert.SerializeObject(productosId, Formatting.Indented);
        }

        private void nudFromPrice_ValueChanged(object sender, EventArgs e)
        {
            List<Producto> productosPrecio = new List<Producto>();
            decimal from = nudFromPrice.Value;
            decimal to = nudToPrice.Value;
            foreach (Producto p in db.GetProductos())
            {
                if (p.Precio >= from && p.Precio <= to)
                {
                    productosPrecio.Add(p);
                }
            }

            rtbProductView.Text = JsonConvert.SerializeObject(productosPrecio, Formatting.Indented);
        }

        private void nudToPrice_ValueChanged(object sender, EventArgs e)
        {
            List<Producto> productosPrecio = new List<Producto>();
            decimal from = nudFromPrice.Value;
            decimal to = nudToPrice.Value;
            foreach (Producto p in db.GetProductos())
            {
                if (p.Precio >= from && p.Precio <= to)
                {
                    productosPrecio.Add(p);
                }
            }

            rtbProductView.Text = JsonConvert.SerializeObject(productosPrecio, Formatting.Indented);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbProductView.Text = JsonConvert.SerializeObject(db.GetProductos(), Formatting.Indented);
        }

        private void dtpCaducity_ValueChanged(object sender, EventArgs e)
        {
            List<Producto> productosFecha= new List<Producto>();
            
            foreach (Producto p in db.GetProductos())
            {
                if (p.FechaVencimiento.CompareTo(dtpCaducity.Value)<=0)
                {
                    productosFecha.Add(p);
                }
            }

            rtbProductView.Text = JsonConvert.SerializeObject(productosFecha, Formatting.Indented);
        }
    }
}
