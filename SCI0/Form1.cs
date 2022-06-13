using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            
            this.inventarioTableAdapter.Fill(this.sCIDataSet.Inventario);

            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {                
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
                    this.BtnEditar.Enabled = true;
                    this.btnGuardar.Enabled =false;
                    this.btnCancelar.Enabled = false;        
                    this.cbxArea.Enabled = false;
                    this.tbxArticulo.Enabled = false;
                    this.tbxDescripcion.Enabled = false;
                    this.cbxMedida.Enabled = false;
                    this.numericoNormal.Enabled = false;
                    this.numericoCritico.Enabled = false;
                    this.btnCIS.Enabled = true;
                    this.btnITN.Enabled = true;
                    //this.button2.Show();


                    break;
                case "Modificar":
                    this.BtnEditar.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;
                    this.cbxArea.Enabled = true;
                    this.tbxArticulo.Enabled = true;
                    this.tbxDescripcion.Enabled = true;
                    this.cbxMedida.Enabled = true;
                    this.numericoNormal.Enabled = true;
                    this.numericoCritico.Enabled = true;
                    this.btnITN.Enabled = true;
                    this.btnCIS.Enabled = false;
                    //this.button2.Hide();

                    break;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("Modificar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void coordinacionToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.Coordinacion(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void intendenciaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.Intendencia(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void mNTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.MNT(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sGRToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.SGR(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lBCToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.LBC(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aMTToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventarioTableAdapter.AMT(this.sCIDataSet.Inventario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
