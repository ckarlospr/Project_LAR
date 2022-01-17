/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 25/07/2015
 * Hora: 01:18 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteRutas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteRutas));
			this.dgRutas = new System.Windows.Forms.DataGridView();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cbTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cbEmpresa = new System.Windows.Forms.ComboBox();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foranea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Velada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgRutas
			// 
			this.dgRutas.AllowUserToAddRows = false;
			this.dgRutas.AllowUserToResizeRows = false;
			this.dgRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRutas.BackgroundColor = System.Drawing.Color.White;
			this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Column8,
									this.Foranea,
									this.Velada});
			this.dgRutas.Location = new System.Drawing.Point(4, 47);
			this.dgRutas.Name = "dgRutas";
			this.dgRutas.RowHeadersVisible = false;
			this.dgRutas.Size = new System.Drawing.Size(868, 388);
			this.dgRutas.TabIndex = 0;
			this.dgRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasCellClick);
			this.dgRutas.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasCellLeave);
			this.dgRutas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgRutasEditingControlShowing);
			this.dgRutas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgRutasKeyPress);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Location = new System.Drawing.Point(803, 441);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(68, 37);
			this.cmdGuardar.TabIndex = 1;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cbTurno
			// 
			this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTurno.FormattingEnabled = true;
			this.cbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio Día",
									"Nocturno",
									"Vespertino"});
			this.cbTurno.Location = new System.Drawing.Point(257, 12);
			this.cbTurno.Name = "cbTurno";
			this.cbTurno.Size = new System.Drawing.Size(121, 21);
			this.cbTurno.TabIndex = 24;
			this.cbTurno.SelectedIndexChanged += new System.EventHandler(this.CbTurnoSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(214, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Turno";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(788, 0);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(77, 42);
			this.btnBuscar.TabIndex = 21;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// cbEmpresa
			// 
			this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmpresa.FormattingEnabled = true;
			this.cbEmpresa.Location = new System.Drawing.Point(76, 12);
			this.cbEmpresa.Name = "cbEmpresa";
			this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
			this.cbEmpresa.TabIndex = 20;
			this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbEmpresaSelectedIndexChanged);
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpresa.Location = new System.Drawing.Point(13, 13);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(100, 23);
			this.lblEmpresa.TabIndex = 19;
			this.lblEmpresa.Text = "Empresa";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 70;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Empresa";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Ruta";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Turno";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Sentido";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "km";
			this.Column6.Name = "Column6";
			this.Column6.Width = 80;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Hr. inicio ruta";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Hr. fin ruta";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Foranea
			// 
			this.Foranea.HeaderText = "Foranea";
			this.Foranea.Name = "Foranea";
			this.Foranea.Width = 70;
			// 
			// Velada
			// 
			this.Velada.HeaderText = "Velada";
			this.Velada.Name = "Velada";
			this.Velada.Width = 70;
			// 
			// FormReporteRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 482);
			this.Controls.Add(this.cbTurno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.cbEmpresa);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.dgRutas);
			this.Name = "FormReporteRutas";
			this.Text = "Horarios";
			this.Load += new System.EventHandler(this.FormReporteRutasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.ComboBox cbEmpresa;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTurno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Velada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Foranea;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgRutas;
	}
}
