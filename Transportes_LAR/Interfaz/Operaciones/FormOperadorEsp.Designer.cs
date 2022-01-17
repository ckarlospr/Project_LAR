/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 20/03/2013
 * Time: 9:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormOperadorEsp
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
			this.cmdMuestra = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.dtDatos = new System.Windows.Forms.DataGridView();
			this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONFIRMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERACION_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERADOR_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_VE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERACION_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERADOR_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_VS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_VS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.cmdSeleccionar = new System.Windows.Forms.Button();
			this.lblRestEnt = new System.Windows.Forms.Label();
			this.lblRestRegresos = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dtDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdMuestra
			// 
			this.cmdMuestra.Location = new System.Drawing.Point(1, 2);
			this.cmdMuestra.Name = "cmdMuestra";
			this.cmdMuestra.Size = new System.Drawing.Size(27, 24);
			this.cmdMuestra.TabIndex = 1;
			this.cmdMuestra.Text = "+";
			this.toolTip1.SetToolTip(this.cmdMuestra, "Mostrar u ocultar asignacion de operadores");
			this.cmdMuestra.UseVisualStyleBackColor = true;
			this.cmdMuestra.Click += new System.EventHandler(this.CmdMuestraClick);
			// 
			// lblNombre
			// 
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.Location = new System.Drawing.Point(30, 4);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(224, 20);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Viaje";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.lblNombre, "Nombre del destino o viaje especial");
			// 
			// dtDatos
			// 
			this.dtDatos.AllowUserToAddRows = false;
			this.dtDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dtDatos.BackgroundColor = System.Drawing.Color.White;
			this.dtDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.C1,
									this.Unidad,
									this.Operador,
									this.CONFIRMACION,
									this.ID_RE,
									this.ID_OPERACION_E,
									this.ID_OPERADOR_E,
									this.ID_VE,
									this.TIPO_VE,
									this.ID_RS,
									this.ID_OPERACION_S,
									this.ID_OPERADOR_S,
									this.ID_VS,
									this.TIPO_VS,
									this.C2,
									this.Column2,
									this.Column1,
									this.Column3});
			this.dtDatos.Location = new System.Drawing.Point(2, 30);
			this.dtDatos.Name = "dtDatos";
			this.dtDatos.RowHeadersVisible = false;
			this.dtDatos.Size = new System.Drawing.Size(352, 22);
			this.dtDatos.TabIndex = 3;
			this.dtDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtDatosCellClick);
			this.dtDatos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DtDatosEditingControlShowing);
			this.dtDatos.DoubleClick += new System.EventHandler(this.DtDatosDoubleClick);
			this.dtDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtDatosKeyUp);
			// 
			// C1
			// 
			this.C1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.C1.DefaultCellStyle = dataGridViewCellStyle1;
			this.C1.HeaderText = "C";
			this.C1.Name = "C1";
			this.C1.ReadOnly = true;
			// 
			// Unidad
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Unidad.DefaultCellStyle = dataGridViewCellStyle2;
			this.Unidad.FillWeight = 68.67001F;
			this.Unidad.HeaderText = "Unidad";
			this.Unidad.Name = "Unidad";
			this.Unidad.ReadOnly = true;
			this.Unidad.Width = 66;
			// 
			// Operador
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operador.DefaultCellStyle = dataGridViewCellStyle3;
			this.Operador.FillWeight = 95.29353F;
			this.Operador.HeaderText = "OP. Salida";
			this.Operador.Name = "Operador";
			this.Operador.Width = 82;
			// 
			// CONFIRMACION
			// 
			this.CONFIRMACION.HeaderText = "CONFIRMACION";
			this.CONFIRMACION.Name = "CONFIRMACION";
			this.CONFIRMACION.ReadOnly = true;
			this.CONFIRMACION.Visible = false;
			this.CONFIRMACION.Width = 114;
			// 
			// ID_RE
			// 
			this.ID_RE.HeaderText = "ID_RE";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Visible = false;
			this.ID_RE.Width = 64;
			// 
			// ID_OPERACION_E
			// 
			this.ID_OPERACION_E.HeaderText = "ID_OPERACION_E";
			this.ID_OPERACION_E.Name = "ID_OPERACION_E";
			this.ID_OPERACION_E.ReadOnly = true;
			this.ID_OPERACION_E.Visible = false;
			this.ID_OPERACION_E.Width = 125;
			// 
			// ID_OPERADOR_E
			// 
			this.ID_OPERADOR_E.HeaderText = "ID_OPERADOR_E";
			this.ID_OPERADOR_E.Name = "ID_OPERADOR_E";
			this.ID_OPERADOR_E.ReadOnly = true;
			this.ID_OPERADOR_E.Visible = false;
			this.ID_OPERADOR_E.Width = 123;
			// 
			// ID_VE
			// 
			this.ID_VE.HeaderText = "ID_VE";
			this.ID_VE.Name = "ID_VE";
			this.ID_VE.ReadOnly = true;
			this.ID_VE.Visible = false;
			this.ID_VE.Width = 63;
			// 
			// TIPO_VE
			// 
			this.TIPO_VE.HeaderText = "TIPO_VE";
			this.TIPO_VE.Name = "TIPO_VE";
			this.TIPO_VE.ReadOnly = true;
			this.TIPO_VE.Visible = false;
			this.TIPO_VE.Width = 77;
			// 
			// ID_RS
			// 
			this.ID_RS.HeaderText = "ID_RS";
			this.ID_RS.Name = "ID_RS";
			this.ID_RS.ReadOnly = true;
			this.ID_RS.Visible = false;
			this.ID_RS.Width = 64;
			// 
			// ID_OPERACION_S
			// 
			this.ID_OPERACION_S.HeaderText = "ID_OPERACION_S";
			this.ID_OPERACION_S.Name = "ID_OPERACION_S";
			this.ID_OPERACION_S.ReadOnly = true;
			this.ID_OPERACION_S.Visible = false;
			this.ID_OPERACION_S.Width = 125;
			// 
			// ID_OPERADOR_S
			// 
			this.ID_OPERADOR_S.HeaderText = "ID_OPERADOR_S";
			this.ID_OPERADOR_S.Name = "ID_OPERADOR_S";
			this.ID_OPERADOR_S.ReadOnly = true;
			this.ID_OPERADOR_S.Visible = false;
			this.ID_OPERADOR_S.Width = 123;
			// 
			// ID_VS
			// 
			this.ID_VS.HeaderText = "ID_VS";
			this.ID_VS.Name = "ID_VS";
			this.ID_VS.ReadOnly = true;
			this.ID_VS.Visible = false;
			this.ID_VS.Width = 63;
			// 
			// TIPO_VS
			// 
			this.TIPO_VS.HeaderText = "TIPO_VS";
			this.TIPO_VS.Name = "TIPO_VS";
			this.TIPO_VS.ReadOnly = true;
			this.TIPO_VS.Visible = false;
			this.TIPO_VS.Width = 77;
			// 
			// C2
			// 
			this.C2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			this.C2.DefaultCellStyle = dataGridViewCellStyle4;
			this.C2.HeaderText = "C";
			this.C2.Name = "C2";
			this.C2.ReadOnly = true;
			// 
			// Column2
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column2.FillWeight = 73.59991F;
			this.Column2.HeaderText = "Unidad";
			this.Column2.Name = "Column2";
			this.Column2.Width = 66;
			// 
			// Column1
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
			this.Column1.FillWeight = 162.4366F;
			this.Column1.HeaderText = "OP. Regreso";
			this.Column1.Name = "Column1";
			this.Column1.Width = 93;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "CONF2";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Visible = false;
			this.Column3.Width = 67;
			// 
			// lblCantidad
			// 
			this.lblCantidad.BackColor = System.Drawing.Color.White;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(255, 2);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(21, 23);
			this.lblCantidad.TabIndex = 4;
			this.lblCantidad.Text = "10";
			this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.lblCantidad, "Cantidad de unidades totales");
			// 
			// cmdSeleccionar
			// 
			this.cmdSeleccionar.Location = new System.Drawing.Point(327, 2);
			this.cmdSeleccionar.Name = "cmdSeleccionar";
			this.cmdSeleccionar.Size = new System.Drawing.Size(27, 24);
			this.cmdSeleccionar.TabIndex = 5;
			this.cmdSeleccionar.Text = ">";
			this.toolTip1.SetToolTip(this.cmdSeleccionar, "Mostrar datos completos del viaje");
			this.cmdSeleccionar.UseVisualStyleBackColor = true;
			this.cmdSeleccionar.Click += new System.EventHandler(this.CmdSeleccionarClick);
			// 
			// lblRestEnt
			// 
			this.lblRestEnt.BackColor = System.Drawing.Color.Silver;
			this.lblRestEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestEnt.ForeColor = System.Drawing.Color.Black;
			this.lblRestEnt.Location = new System.Drawing.Point(280, 2);
			this.lblRestEnt.Name = "lblRestEnt";
			this.lblRestEnt.Size = new System.Drawing.Size(21, 23);
			this.lblRestEnt.TabIndex = 6;
			this.lblRestEnt.Text = "10";
			this.lblRestEnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.lblRestEnt, "Faltantes de entrada por asignar");
			// 
			// lblRestRegresos
			// 
			this.lblRestRegresos.BackColor = System.Drawing.Color.Silver;
			this.lblRestRegresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRestRegresos.ForeColor = System.Drawing.Color.Black;
			this.lblRestRegresos.Location = new System.Drawing.Point(305, 2);
			this.lblRestRegresos.Name = "lblRestRegresos";
			this.lblRestRegresos.Size = new System.Drawing.Size(21, 23);
			this.lblRestRegresos.TabIndex = 7;
			this.lblRestRegresos.Text = "10";
			this.lblRestRegresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.lblRestRegresos, "Faltantes de regresos por asignar");
			// 
			// FormOperadorEsp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(357, 29);
			this.Controls.Add(this.lblRestRegresos);
			this.Controls.Add(this.lblRestEnt);
			this.Controls.Add(this.cmdSeleccionar);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.dtDatos);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.cmdMuestra);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormOperadorEsp";
			this.Text = "FormOperadorEsp";
			this.Load += new System.EventHandler(this.FormOperadorEspLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtDatos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.Label lblRestRegresos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn C2;
		private System.Windows.Forms.DataGridViewTextBoxColumn C1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		public System.Windows.Forms.Label lblRestEnt;
		public System.Windows.Forms.Button cmdSeleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_VS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_VS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERADOR_S;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERACION_S;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_VE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_VE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERADOR_E;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERACION_E;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONFIRMACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		public System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
		public System.Windows.Forms.DataGridView dtDatos;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button cmdMuestra;
	}
}
