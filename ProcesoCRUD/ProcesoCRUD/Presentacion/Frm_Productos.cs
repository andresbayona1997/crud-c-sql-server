using ProcesoCRUD.Datos;
using ProcesoCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoCRUD.Presentacion
{
	public partial class Frm_Productos : Form
	{
		public Frm_Productos()
		{
			InitializeComponent();
		}
		#region "Variables"
		int nEstadoGuarda = 0;
		int vCodigo = 0;
		#endregion


		#region "Metodos"
		private void Limpiar_txt()
		{
			this.vCodigo = 0;
			txtBuscar.Text = "";
			txtDcPr.Text = "";
			txtMc.Text = "";
			txtStock.Text = "";
			cmbCategoria.Text = "";
			cmbMedida.Text = "";
		}

		

		private void Cargar_medidas()
		{
			D_Productos datos = new D_Productos();
			cmbMedida.DataSource = datos.Listado_me();
			cmbMedida.ValueMember = "codigo_me";
			cmbMedida.DisplayMember = "descripcion_me";
		}
		private void Cargar_categorias()
		{
			D_Productos datos = new D_Productos();
			cmbCategoria.DataSource = datos.Listado_ca();
			cmbCategoria.ValueMember = "codigo_ca";
			cmbCategoria.DisplayMember = "descripcion_ca";
		}

		private void Formato_pr()
		{
			dgv.Columns[0].Width = 100;
			dgv.Columns[0].HeaderText = "CODIGO PR";
			dgv.Columns[1].Width = 150;
			dgv.Columns[1].HeaderText = "Producto PR";
			dgv.Columns[2].Width = 150;
			dgv.Columns[2].HeaderText = "Marca PR";
			dgv.Columns[3].Width = 150;
			dgv.Columns[3].HeaderText = "Medida PR";
			dgv.Columns[4].Width = 150;
			dgv.Columns[4].HeaderText = "Categoria PR";
			dgv.Columns[5].Width = 100;
			dgv.Columns[5].HeaderText = "Stock PR";
			dgv.Columns[6].Visible = false;
			dgv.Columns[7].Visible = false;

		}

		private void Listado_pr(string cTexto)
		{
			D_Productos Datos = new D_Productos();
			dgv.DataSource = Datos.Listado_pr(cTexto);
			this.Formato_pr();
			}

		private void Selecciona_item_pr()
		{
			if (string.IsNullOrEmpty(Convert.ToString(dgv.CurrentRow.Cells["codigo_pr"].Value))) {
				MessageBox.Show("No se tiene información para visualizar", "Aviso sistema", MessageBoxButtons.OK);

			}
			else {
				this.vCodigo = Convert.ToInt32(dgv.CurrentRow.Cells["codigo_pr"].Value);
				txtDcPr.Text = Convert.ToString(dgv.CurrentRow.Cells["descripcion_pr"].Value);
				txtMc.Text = Convert.ToString(dgv.CurrentRow.Cells["marca_pr"].Value);
				cmbMedida.Text = Convert.ToString(dgv.CurrentRow.Cells["descripcion_me"].Value);
				cmbCategoria.Text = Convert.ToString(dgv.CurrentRow.Cells["descripcion_ca"].Value);
				txtStock.Text = Convert.ToString(dgv.CurrentRow.Cells["stoc_actual"].Value);
			}
		}

		#endregion


		private void btNuevo_Click(object sender, EventArgs e)
		{
			this.Limpiar_txt();
			this.nEstadoGuarda = 1;
			txtDcPr.Select();
		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			this.Limpiar_txt();
		}

		private void btGuardar_Click(object sender, EventArgs e)
		{
			string rpta = "";
			E_Productos oPro = new E_Productos();
			oPro.Codigo_pr = 0;
			oPro.Descripcion_pr = txtDcPr.Text;
			oPro.Marca_pr = txtMc.Text;
			oPro.Codigo_me = Convert.ToInt32(cmbMedida.SelectedValue);
			oPro.Codigo_ca = Convert.ToInt32(cmbCategoria.SelectedValue);
			oPro.Stock_actual = Convert.ToDecimal(txtStock.Text);
			D_Productos Datos = new D_Productos();
			rpta = Datos.Guardar_pr(nEstadoGuarda,oPro);
			if (rpta == "OK")
			{
				this.nEstadoGuarda = 0;
				this.Listado_pr("%");
				MessageBox.Show("Datos añadidos","Aviso sistema",MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("ERROR", "Aviso sistema", MessageBoxButtons.OK);
			}
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.Selecciona_item_pr();
		}

		private void btActualizar_Click(object sender, EventArgs e)
		{
			this.nEstadoGuarda = 2;
		}

		private void btEliminar_Click(object sender, EventArgs e)
		{
			string rpta = "";
			D_Productos datos = new D_Productos();
			rpta = datos.Activar_pr(vCodigo, false);
			if (rpta == "OK")
			{
				this.Listado_pr("%");
				MessageBox.Show("Datos elimiados", "Aviso sistema", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("ERROR", "Aviso sistema", MessageBoxButtons.OK);
			}
		}

		private void btBuscar_Click(object sender, EventArgs e)
		{
			this.Listado_pr(txtBuscar.Text);
		}

		private void btSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
