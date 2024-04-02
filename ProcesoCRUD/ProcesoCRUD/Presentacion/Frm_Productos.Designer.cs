using System;

namespace ProcesoCRUD.Presentacion
{
	partial class Frm_Productos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btSalir = new System.Windows.Forms.Button();
			this.btEliminar = new System.Windows.Forms.Button();
			this.btActualizar = new System.Windows.Forms.Button();
			this.btNuevo = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDcPr = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbMedida = new System.Windows.Forms.ComboBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btBuscar = new System.Windows.Forms.Button();
			this.btCancelar = new System.Windows.Forms.Button();
			this.btGuardar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
			this.panel1.Controls.Add(this.btSalir);
			this.panel1.Controls.Add(this.btEliminar);
			this.panel1.Controls.Add(this.btActualizar);
			this.panel1.Controls.Add(this.btNuevo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(600, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 450);
			this.panel1.TabIndex = 0;
			// 
			// btSalir
			// 
			this.btSalir.Location = new System.Drawing.Point(51, 372);
			this.btSalir.Name = "btSalir";
			this.btSalir.Size = new System.Drawing.Size(112, 42);
			this.btSalir.TabIndex = 21;
			this.btSalir.Text = "Salir";
			this.btSalir.UseVisualStyleBackColor = true;
			this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
			// 
			// btEliminar
			// 
			this.btEliminar.Location = new System.Drawing.Point(51, 185);
			this.btEliminar.Name = "btEliminar";
			this.btEliminar.Size = new System.Drawing.Size(112, 42);
			this.btEliminar.TabIndex = 19;
			this.btEliminar.Text = "Eliminar";
			this.btEliminar.UseVisualStyleBackColor = true;
			this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
			// 
			// btActualizar
			// 
			this.btActualizar.Location = new System.Drawing.Point(51, 110);
			this.btActualizar.Name = "btActualizar";
			this.btActualizar.Size = new System.Drawing.Size(112, 42);
			this.btActualizar.TabIndex = 18;
			this.btActualizar.Text = "Actualizar";
			this.btActualizar.UseVisualStyleBackColor = true;
			this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
			// 
			// btNuevo
			// 
			this.btNuevo.Location = new System.Drawing.Point(51, 36);
			this.btNuevo.Name = "btNuevo";
			this.btNuevo.Size = new System.Drawing.Size(112, 42);
			this.btNuevo.TabIndex = 17;
			this.btNuevo.Text = "Nuevo";
			this.btNuevo.UseVisualStyleBackColor = true;
			this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 100);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(120, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(470, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "MANTENIMIENTO DE PRODUCTOS";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(137, 122);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Productos";
			// 
			// txtDcPr
			// 
			this.txtDcPr.Location = new System.Drawing.Point(106, 125);
			this.txtDcPr.MaxLength = 80;
			this.txtDcPr.Name = "txtDcPr";
			this.txtDcPr.Size = new System.Drawing.Size(168, 20);
			this.txtDcPr.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Marca";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtMc
			// 
			this.txtMc.Location = new System.Drawing.Point(106, 169);
			this.txtMc.MaxLength = 30;
			this.txtMc.Name = "txtMc";
			this.txtMc.Size = new System.Drawing.Size(119, 20);
			this.txtMc.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Medida";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// cmbMedida
			// 
			this.cmbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMedida.FormattingEnabled = true;
			this.cmbMedida.Location = new System.Drawing.Point(106, 206);
			this.cmbMedida.Name = "cmbMedida";
			this.cmbMedida.Size = new System.Drawing.Size(168, 21);
			this.cmbMedida.TabIndex = 7;
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(390, 206);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(168, 21);
			this.cmbCategoria.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(307, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Categoria";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(106, 245);
			this.txtStock.MaxLength = 30;
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(119, 20);
			this.txtStock.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 245);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Stock";
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToOrderColumns = true;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(35, 311);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.Size = new System.Drawing.Size(523, 119);
			this.dgv.TabIndex = 12;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(106, 286);
			this.txtBuscar.MaxLength = 30;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(119, 20);
			this.txtBuscar.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 286);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Buscar";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btBuscar
			// 
			this.btBuscar.Location = new System.Drawing.Point(232, 286);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(75, 23);
			this.btBuscar.TabIndex = 15;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = true;
			this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
			// 
			// btCancelar
			// 
			this.btCancelar.Location = new System.Drawing.Point(367, 125);
			this.btCancelar.Name = "btCancelar";
			this.btCancelar.Size = new System.Drawing.Size(75, 23);
			this.btCancelar.TabIndex = 16;
			this.btCancelar.Text = "Cancelar";
			this.btCancelar.UseVisualStyleBackColor = true;
			this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
			// 
			// btGuardar
			// 
			this.btGuardar.Location = new System.Drawing.Point(448, 125);
			this.btGuardar.Name = "btGuardar";
			this.btGuardar.Size = new System.Drawing.Size(75, 23);
			this.btGuardar.TabIndex = 17;
			this.btGuardar.Text = "Guardar";
			this.btGuardar.UseVisualStyleBackColor = true;
			this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
			// 
			// Frm_Productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btGuardar);
			this.Controls.Add(this.btCancelar);
			this.Controls.Add(this.btBuscar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbMedida);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDcPr);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Frm_Productos";
			this.Text = "Frm_Productos";
			this.Load += new System.EventHandler(this.Frm_Productos_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Frm_Productos_Load(object sender, EventArgs e)
		{
			this.Cargar_medidas();
			this.Cargar_categorias();
			this.Listado_pr("%");
		}

		private void label7_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDcPr;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbMedida;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btBuscar;
		private System.Windows.Forms.Button btCancelar;
		private System.Windows.Forms.Button btSalir;
		private System.Windows.Forms.Button btEliminar;
		private System.Windows.Forms.Button btActualizar;
		private System.Windows.Forms.Button btNuevo;
		private System.Windows.Forms.Button btGuardar;
	}
}