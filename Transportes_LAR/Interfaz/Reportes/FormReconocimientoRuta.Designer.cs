/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 07/01/2013
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormReconocimientoRuta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgOperador = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgEmpresas = new System.Windows.Forms.DataGridView();
			this.ID_Emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgRutas = new System.Windows.Forms.DataGridView();
			this.ID_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgRutasReconocidas = new System.Windows.Forms.DataGridView();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RutaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtRutas = new System.Windows.Forms.TextBox();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEmpresas)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRutasReconocidas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtOperador
			// 
			this.txtOperador.Location = new System.Drawing.Point(12, 40);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(151, 20);
			this.txtOperador.TabIndex = 0;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Operador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.dgOperador);
			this.panel1.Location = new System.Drawing.Point(12, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(151, 380);
			this.panel1.TabIndex = 2;
			// 
			// dgOperador
			// 
			this.dgOperador.AllowUserToAddRows = false;
			this.dgOperador.AllowUserToResizeColumns = false;
			this.dgOperador.AllowUserToResizeRows = false;
			this.dgOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOperador.BackgroundColor = System.Drawing.Color.White;
			this.dgOperador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Alias});
			this.dgOperador.Location = new System.Drawing.Point(3, 3);
			this.dgOperador.Name = "dgOperador";
			this.dgOperador.RowHeadersVisible = false;
			this.dgOperador.Size = new System.Drawing.Size(145, 374);
			this.dgOperador.TabIndex = 0;
			this.dgOperador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOperadorCellClick);
			this.dgOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgOperadorKeyUp);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Alias
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Alias.DefaultCellStyle = dataGridViewCellStyle2;
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			this.Alias.Width = 110;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgEmpresas);
			this.panel2.Location = new System.Drawing.Point(18, 60);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(286, 161);
			this.panel2.TabIndex = 3;
			// 
			// dgEmpresas
			// 
			this.dgEmpresas.AllowUserToAddRows = false;
			this.dgEmpresas.AllowUserToResizeColumns = false;
			this.dgEmpresas.AllowUserToResizeRows = false;
			this.dgEmpresas.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Emp,
									this.Empresa});
			this.dgEmpresas.Location = new System.Drawing.Point(3, 3);
			this.dgEmpresas.Name = "dgEmpresas";
			this.dgEmpresas.RowHeadersVisible = false;
			this.dgEmpresas.Size = new System.Drawing.Size(280, 154);
			this.dgEmpresas.TabIndex = 0;
			this.dgEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEmpresasCellClick);
			this.dgEmpresas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgEmpresasKeyUp);
			// 
			// ID_Emp
			// 
			this.ID_Emp.HeaderText = "ID";
			this.ID_Emp.Name = "ID_Emp";
			this.ID_Emp.ReadOnly = true;
			this.ID_Emp.Visible = false;
			// 
			// Empresa
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Empresa.DefaultCellStyle = dataGridViewCellStyle4;
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			this.Empresa.Width = 250;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.panel3.Controls.Add(this.dgRutas);
			this.panel3.Location = new System.Drawing.Point(18, 277);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(286, 156);
			this.panel3.TabIndex = 4;
			// 
			// dgRutas
			// 
			this.dgRutas.AllowUserToAddRows = false;
			this.dgRutas.AllowUserToResizeColumns = false;
			this.dgRutas.AllowUserToResizeRows = false;
			this.dgRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dgRutas.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Ruta,
									this.Ruta,
									this.IDEMP});
			this.dgRutas.Location = new System.Drawing.Point(3, 3);
			this.dgRutas.Name = "dgRutas";
			this.dgRutas.RowHeadersVisible = false;
			this.dgRutas.Size = new System.Drawing.Size(280, 150);
			this.dgRutas.TabIndex = 0;
			this.dgRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasCellClick);
			this.dgRutas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgRutasKeyUp);
			// 
			// ID_Ruta
			// 
			this.ID_Ruta.HeaderText = "ID_ruta";
			this.ID_Ruta.Name = "ID_Ruta";
			this.ID_Ruta.ReadOnly = true;
			this.ID_Ruta.Visible = false;
			// 
			// Ruta
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Ruta.DefaultCellStyle = dataGridViewCellStyle6;
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			this.Ruta.Width = 250;
			// 
			// IDEMP
			// 
			this.IDEMP.HeaderText = "ID_Empresa";
			this.IDEMP.Name = "IDEMP";
			this.IDEMP.ReadOnly = true;
			this.IDEMP.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(286, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Empresa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(286, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Rutas";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.dgRutasReconocidas);
			this.panel4.Location = new System.Drawing.Point(580, 40);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 411);
			this.panel4.TabIndex = 7;
			// 
			// dgRutasReconocidas
			// 
			this.dgRutasReconocidas.AllowUserToAddRows = false;
			this.dgRutasReconocidas.AllowUserToResizeColumns = false;
			this.dgRutasReconocidas.AllowUserToResizeRows = false;
			this.dgRutasReconocidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRutasReconocidas.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRutasReconocidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgRutasReconocidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRutasReconocidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_R,
									this.RutaR});
			this.dgRutasReconocidas.Location = new System.Drawing.Point(3, 3);
			this.dgRutasReconocidas.Name = "dgRutasReconocidas";
			this.dgRutasReconocidas.RowHeadersVisible = false;
			this.dgRutasReconocidas.Size = new System.Drawing.Size(226, 405);
			this.dgRutasReconocidas.TabIndex = 1;
			this.dgRutasReconocidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasReconocidasCellClick);
			this.dgRutasReconocidas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgRutasReconocidasKeyUp);
			// 
			// ID_R
			// 
			this.ID_R.HeaderText = "ID";
			this.ID_R.Name = "ID_R";
			this.ID_R.ReadOnly = true;
			this.ID_R.Visible = false;
			this.ID_R.Width = 200;
			// 
			// RutaR
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.RutaR.DefaultCellStyle = dataGridViewCellStyle8;
			this.RutaR.HeaderText = "Ruta";
			this.RutaR.Name = "RutaR";
			this.RutaR.ReadOnly = true;
			this.RutaR.Width = 200;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.txtEmpresa);
			this.groupBox1.Controls.Add(this.txtRutas);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Location = new System.Drawing.Point(185, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(322, 445);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(85, 34);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(151, 20);
			this.txtEmpresa.TabIndex = 10;
			this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmpresaKeyUp);
			// 
			// txtRutas
			// 
			this.txtRutas.Location = new System.Drawing.Point(85, 251);
			this.txtRutas.Name = "txtRutas";
			this.txtRutas.Size = new System.Drawing.Size(151, 20);
			this.txtRutas.TabIndex = 9;
			this.txtRutas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRutas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtRutasKeyUp);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Location = new System.Drawing.Point(523, 191);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(41, 101);
			this.cmdAgregar.TabIndex = 11;
			this.cmdAgregar.Text = "ADD";
			this.toolTip1.SetToolTip(this.cmdAgregar, "Agregar");
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdEliminar.Location = new System.Drawing.Point(523, 404);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(41, 47);
			this.cmdEliminar.TabIndex = 12;
			this.cmdEliminar.Text = "X";
			this.toolTip1.SetToolTip(this.cmdEliminar, "Eliminar");
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(580, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(229, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Rutas reconocidas";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormReconocimientoRuta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 457);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOperador);
			this.MinimumSize = new System.Drawing.Size(837, 495);
			this.Name = "FormReconocimientoRuta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reconocimiento de Rutas";
			this.Load += new System.EventHandler(this.FormReconocimientoRutaLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgEmpresas)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgRutasReconocidas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn IDEMP;
		private System.Windows.Forms.DataGridViewTextBoxColumn RutaR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Emp;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.TextBox txtRutas;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgRutasReconocidas;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgRutas;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgEmpresas;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgOperador;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOperador;
	}
}
