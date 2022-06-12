using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SCI0
{
    public partial class Form1 : Form
    {
        string Modo = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet2.UnidadMedida' Puede moverla o quitarla según sea necesario.
            this.unidadMedidaTableAdapter.Fill(this.sCIDataSet2.UnidadMedida);
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet2.Areas' Puede moverla o quitarla según sea necesario.
            this.areasTableAdapter.Fill(this.sCIDataSet2.Areas);
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);

            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                //this.vInventarioAMTTableAdapter.Fill(this.sCIDataSet1.vInventarioAMT);
                this.vInventarioLBCTableAdapter.Fill(this.sCIDataSet1.vInventarioLBC);
                this.vInventarioSGRTableAdapter.Fill(this.sCIDataSet1.vInventarioSGR);
                this.vInventarioMTNTableAdapter.Fill(this.sCIDataSet1.vInventarioMTN);
                this.vInventarioITNTableAdapter.Fill(this.sCIDataSet1.vInventarioITN);
                this.vInventarioCISTableAdapter.Fill(this.sCIDataSet.vInventarioCIS);
                this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);
                this.ModoEdicion("Lectura");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error al cargar los datos: " + ex.Message.ToString());
            }
        }
        private void ModoEdicion(string modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "Lectura":
                    this.btnModificarAMT.Enabled = true;
                    this.btnGuardarAMT.Enabled =false;
                    this.btnCancelarAMT.Enabled = false;        this.cbxArea.Enabled = false;
                    this.tbxArticulo.Enabled = false;
                    this.tbxDescripcion.Enabled = false;
                    this.cbxMedida.Enabled = false;
                    this.numericoNormal.Enabled = false;
                    this.numericoCritico.Enabled = false;
                    //this.dataGridViewAMT.Enabled =false;
                    
                    break;
                case "Modificar":
                    this.btnModificarAMT.Enabled = false;
                    this.btnGuardarAMT.Enabled = true;
                    this.btnCancelarAMT.Enabled = true;
                    this.cbxArea.Enabled = true;
                    this.tbxArticulo.Enabled = true;
                    this.tbxDescripcion.Enabled = true;
                    this.cbxMedida.Enabled = true;
                    this.numericoNormal.Enabled = true;
                    this.numericoCritico.Enabled = true;

                    break;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    int id = int.Parse(this.tbxId.Text);
                    this.inventarioTableAdapter.Update(this.cbxArea.Text,
                   this.tbxArticulo.Text, this.tbxDescripcion.Text,
                   Convert.ToInt32(this.cbxMedida.Text),
                   Convert.ToInt32(this.numericoNormal.Value),
                   Convert.ToInt32(this.numericoCritico.Value),
                   id);
                    MessageBox.Show("Los datos fueron actualizados correctamente", "Operación exitosa");
                    this.CargaDatos();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar los campos: " + ex.Message.ToString());
                
            }
        }

        private void btnModificarAMT_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Modificar");
            
        }

        private void btnCancelarAMT_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.tbxDescripcion.Text.Trim() == "" || this.tbxArticulo.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.tbxArticulo, "¡Campo requerido!");
                this.errorProvider1.SetError(this.tbxDescripcion, "¡Campo requerido!");
            }
            return validado;
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.FillBy1(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cantidadCriticaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
