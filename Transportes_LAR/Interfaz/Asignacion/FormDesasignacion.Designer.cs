/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 23/08/2012
 * Time: 9:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Asignacion
{
	partial class FormDesasignacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesasignacion));
			this.btnContinuar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.gpTipo = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rbI = new System.Windows.Forms.RadioButton();
			this.rbX = new System.Windows.Forms.RadioButton();
			this.rbP = new System.Windows.Forms.RadioButton();
			this.rbE = new System.Windows.Forms.RadioButton();
			this.rbT = new System.Windows.Forms.RadioButton();
			this.rbD = new System.Windows.Forms.RadioButton();
			this.rbA = new System.Windows.Forms.RadioButton();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.gbOtro = new System.Windows.Forms.GroupBox();
			this.rbActividad = new System.Windows.Forms.RadioButton();
			this.rbDisponibilidad = new System.Windows.Forms.RadioButton();
			this.rbUniforme = new System.Windows.Forms.RadioButton();
			this.gbInsistencia = new System.Windows.Forms.GroupBox();
			this.dgInsistencia = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpTiempo = new System.Windows.Forms.DateTimePicker();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.dtpDia = new System.Windows.Forms.DateTimePicker();
			this.gbInicio = new System.Windows.Forms.GroupBox();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.gpTipo.SuspendLayout();
			this.gbDatos.SuspendLayout();
			this.gbOtro.SuspendLayout();
			this.gbInsistencia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgInsistencia)).BeginInit();
			this.gbInicio.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnContinuar
			// 
			this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
			this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnContinuar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
			this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnContinuar.Location = new System.Drawing.Point(688, 250);
			this.btnContinuar.Name = "btnContinuar";
			this.btnContinuar.Size = new System.Drawing.Size(84, 29);
			this.btnContinuar.TabIndex = 5;
			this.btnContinuar.Text = "Guardar";
			this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnContinuar.UseVisualStyleBackColor = false;
			this.btnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(587, 250);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 29);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, -5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(786, 32);
			this.panel1.TabIndex = 208;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "CARDEX";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescripcion.Location = new System.Drawing.Point(13, 16);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(391, 105);
			this.txtDescripcion.TabIndex = 4;
			// 
			// gpTipo
			// 
			this.gpTipo.Controls.Add(this.label3);
			this.gpTipo.Controls.Add(this.rbI);
			this.gpTipo.Controls.Add(this.rbX);
			this.gpTipo.Controls.Add(this.rbP);
			this.gpTipo.Controls.Add(this.rbE);
			this.gpTipo.Controls.Add(this.rbT);
			this.gpTipo.Controls.Add(this.rbD);
			this.gpTipo.Controls.Add(this.rbA);
			this.gpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpTipo.Location = new System.Drawing.Point(12, 33);
			this.gpTipo.Name = "gpTipo";
			this.gpTipo.Size = new System.Drawing.Size(415, 80);
			this.gpTipo.TabIndex = 216;
			this.gpTipo.TabStop = false;
			this.gpTipo.Text = "Estatus";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SeaShell;
			this.label3.Location = new System.Drawing.Point(319, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(7, 68);
			this.label3.TabIndex = 7;
			// 
			// rbI
			// 
			this.rbI.Location = new System.Drawing.Point(202, 46);
			this.rbI.Name = "rbI";
			this.rbI.Size = new System.Drawing.Size(106, 18);
			this.rbI.TabIndex = 6;
			this.rbI.Text = "I incapacidad";
			this.rbI.UseVisualStyleBackColor = true;
			this.rbI.CheckedChanged += new System.EventHandler(this.RbICheckedChanged);
			// 
			// rbX
			// 
			this.rbX.Location = new System.Drawing.Point(336, 35);
			this.rbX.Name = "rbX";
			this.rbX.Size = new System.Drawing.Size(68, 18);
			this.rbX.TabIndex = 5;
			this.rbX.Text = "O otro";
			this.rbX.UseVisualStyleBackColor = true;
			this.rbX.CheckedChanged += new System.EventHandler(this.RbXCheckedChanged);
			// 
			// rbP
			// 
			this.rbP.Location = new System.Drawing.Point(202, 21);
			this.rbP.Name = "rbP";
			this.rbP.Size = new System.Drawing.Size(85, 19);
			this.rbP.TabIndex = 4;
			this.rbP.Text = "P permiso";
			this.rbP.UseVisualStyleBackColor = true;
			this.rbP.CheckedChanged += new System.EventHandler(this.RbPCheckedChanged);
			// 
			// rbE
			// 
			this.rbE.Location = new System.Drawing.Point(112, 45);
			this.rbE.Name = "rbE";
			this.rbE.Size = new System.Drawing.Size(94, 18);
			this.rbE.TabIndex = 3;
			this.rbE.Text = "E especial";
			this.rbE.UseVisualStyleBackColor = true;
			this.rbE.CheckedChanged += new System.EventHandler(this.RbECheckedChanged);
			// 
			// rbT
			// 
			this.rbT.Location = new System.Drawing.Point(112, 20);
			this.rbT.Name = "rbT";
			this.rbT.Size = new System.Drawing.Size(94, 20);
			this.rbT.TabIndex = 2;
			this.rbT.Text = "T taller";
			this.rbT.UseVisualStyleBackColor = true;
			this.rbT.CheckedChanged += new System.EventHandler(this.RbTCheckedChanged);
			// 
			// rbD
			// 
			this.rbD.Checked = true;
			this.rbD.Location = new System.Drawing.Point(18, 44);
			this.rbD.Name = "rbD";
			this.rbD.Size = new System.Drawing.Size(88, 20);
			this.rbD.TabIndex = 1;
			this.rbD.TabStop = true;
			this.rbD.Text = "D dormido";
			this.rbD.UseVisualStyleBackColor = true;
			this.rbD.CheckedChanged += new System.EventHandler(this.RbDCheckedChanged);
			// 
			// rbA
			// 
			this.rbA.Location = new System.Drawing.Point(18, 23);
			this.rbA.Name = "rbA";
			this.rbA.Size = new System.Drawing.Size(88, 15);
			this.rbA.TabIndex = 0;
			this.rbA.Text = "A activo";
			this.rbA.UseVisualStyleBackColor = true;
			this.rbA.CheckedChanged += new System.EventHandler(this.RbACheckedChanged);
			// 
			// gbDatos
			// 
			this.gbDatos.Controls.Add(this.txtDescripcion);
			this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDatos.Location = new System.Drawing.Point(12, 119);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Size = new System.Drawing.Size(415, 127);
			this.gbDatos.TabIndex = 217;
			this.gbDatos.TabStop = false;
			this.gbDatos.Text = "Cometarios";
			// 
			// gbOtro
			// 
			this.gbOtro.Controls.Add(this.rbActividad);
			this.gbOtro.Controls.Add(this.rbDisponibilidad);
			this.gbOtro.Controls.Add(this.rbUniforme);
			this.gbOtro.Enabled = false;
			this.gbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbOtro.Location = new System.Drawing.Point(444, 75);
			this.gbOtro.Name = "gbOtro";
			this.gbOtro.Size = new System.Drawing.Size(326, 38);
			this.gbOtro.TabIndex = 218;
			this.gbOtro.TabStop = false;
			this.gbOtro.Text = "Otro";
			// 
			// rbActividad
			// 
			this.rbActividad.Checked = true;
			this.rbActividad.Location = new System.Drawing.Point(19, 12);
			this.rbActividad.Name = "rbActividad";
			this.rbActividad.Size = new System.Drawing.Size(67, 24);
			this.rbActividad.TabIndex = 2;
			this.rbActividad.TabStop = true;
			this.rbActividad.Text = "Actitud";
			this.rbActividad.UseVisualStyleBackColor = true;
			this.rbActividad.CheckedChanged += new System.EventHandler(this.RbActividadCheckedChanged);
			// 
			// rbDisponibilidad
			// 
			this.rbDisponibilidad.Location = new System.Drawing.Point(213, 12);
			this.rbDisponibilidad.Name = "rbDisponibilidad";
			this.rbDisponibilidad.Size = new System.Drawing.Size(104, 24);
			this.rbDisponibilidad.TabIndex = 1;
			this.rbDisponibilidad.Text = "Disponibilidad";
			this.rbDisponibilidad.UseVisualStyleBackColor = true;
			this.rbDisponibilidad.CheckedChanged += new System.EventHandler(this.RbDisponibilidadCheckedChanged);
			// 
			// rbUniforme
			// 
			this.rbUniforme.Location = new System.Drawing.Point(109, 12);
			this.rbUniforme.Name = "rbUniforme";
			this.rbUniforme.Size = new System.Drawing.Size(81, 24);
			this.rbUniforme.TabIndex = 0;
			this.rbUniforme.Text = "Uniforme";
			this.rbUniforme.UseVisualStyleBackColor = true;
			this.rbUniforme.CheckedChanged += new System.EventHandler(this.RbUniformeCheckedChanged);
			// 
			// gbInsistencia
			// 
			this.gbInsistencia.Controls.Add(this.dgInsistencia);
			this.gbInsistencia.Controls.Add(this.label5);
			this.gbInsistencia.Controls.Add(this.dtpTiempo);
			this.gbInsistencia.Controls.Add(this.txtUsuario);
			this.gbInsistencia.Enabled = false;
			this.gbInsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbInsistencia.Location = new System.Drawing.Point(444, 115);
			this.gbInsistencia.Name = "gbInsistencia";
			this.gbInsistencia.Size = new System.Drawing.Size(326, 131);
			this.gbInsistencia.TabIndex = 219;
			this.gbInsistencia.TabStop = false;
			this.gbInsistencia.Text = "Insistencia";
			// 
			// dgInsistencia
			// 
			this.dgInsistencia.AllowUserToAddRows = false;
			this.dgInsistencia.BackgroundColor = System.Drawing.Color.White;
			this.dgInsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.HORA,
									this.USUARIO});
			this.dgInsistencia.Location = new System.Drawing.Point(6, 40);
			this.dgInsistencia.Name = "dgInsistencia";
			this.dgInsistencia.RowHeadersVisible = false;
			this.dgInsistencia.Size = new System.Drawing.Size(314, 86);
			this.dgInsistencia.TabIndex = 4;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 180;
			// 
			// HORA
			// 
			this.HORA.HeaderText = "HORA";
			this.HORA.Name = "HORA";
			this.HORA.ReadOnly = true;
			// 
			// USUARIO
			// 
			this.USUARIO.HeaderText = "RESPONSABLE";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			this.USUARIO.Width = 170;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(122, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 23);
			this.label5.TabIndex = 223;
			this.label5.Text = "Responsable:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpTiempo
			// 
			this.dtpTiempo.Enabled = false;
			this.dtpTiempo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTiempo.Location = new System.Drawing.Point(6, 15);
			this.dtpTiempo.Name = "dtpTiempo";
			this.dtpTiempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpTiempo.ShowUpDown = true;
			this.dtpTiempo.Size = new System.Drawing.Size(100, 20);
			this.dtpTiempo.TabIndex = 3;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(222, 15);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(98, 21);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			// 
			// dtpDia
			// 
			this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDia.Location = new System.Drawing.Point(65, 15);
			this.dtpDia.Name = "dtpDia";
			this.dtpDia.Size = new System.Drawing.Size(91, 20);
			this.dtpDia.TabIndex = 221;
			// 
			// gbInicio
			// 
			this.gbInicio.Controls.Add(this.cmbTurno);
			this.gbInicio.Controls.Add(this.label6);
			this.gbInicio.Controls.Add(this.label4);
			this.gbInicio.Controls.Add(this.dtpDia);
			this.gbInicio.Enabled = false;
			this.gbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbInicio.ForeColor = System.Drawing.Color.Black;
			this.gbInicio.Location = new System.Drawing.Point(444, 33);
			this.gbInicio.Name = "gbInicio";
			this.gbInicio.Size = new System.Drawing.Size(326, 40);
			this.gbInicio.TabIndex = 220;
			this.gbInicio.TabStop = false;
			this.gbInicio.Text = "Inicio de labores";
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(221, 15);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(96, 21);
			this.cmbTurno.TabIndex = 225;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(176, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 23);
			this.label6.TabIndex = 224;
			this.label6.Text = "Turno:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 23);
			this.label4.TabIndex = 223;
			this.label4.Text = "Hasta:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormDesasignacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(784, 284);
			this.Controls.Add(this.gbInicio);
			this.Controls.Add(this.gbInsistencia);
			this.Controls.Add(this.gbOtro);
			this.Controls.Add(this.gbDatos);
			this.Controls.Add(this.gpTipo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnContinuar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDesasignacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Desasignacion";
			this.Load += new System.EventHandler(this.FormDesasignacionLoad);
			this.panel1.ResumeLayout(false);
			this.gpTipo.ResumeLayout(false);
			this.gbDatos.ResumeLayout(false);
			this.gbDatos.PerformLayout();
			this.gbOtro.ResumeLayout(false);
			this.gbInsistencia.ResumeLayout(false);
			this.gbInsistencia.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgInsistencia)).EndInit();
			this.gbInicio.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.GroupBox gbInicio;
		private System.Windows.Forms.DateTimePicker dtpDia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgInsistencia;
		private System.Windows.Forms.RadioButton rbI;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpTiempo;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.GroupBox gbInsistencia;
		private System.Windows.Forms.RadioButton rbUniforme;
		private System.Windows.Forms.RadioButton rbDisponibilidad;
		private System.Windows.Forms.RadioButton rbActividad;
		private System.Windows.Forms.GroupBox gbOtro;
		private System.Windows.Forms.RadioButton rbA;
		private System.Windows.Forms.RadioButton rbD;
		private System.Windows.Forms.RadioButton rbT;
		private System.Windows.Forms.RadioButton rbE;
		private System.Windows.Forms.RadioButton rbP;
		private System.Windows.Forms.RadioButton rbX;
		private System.Windows.Forms.GroupBox gbDatos;
		private System.Windows.Forms.GroupBox gpTipo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.Button btnContinuar;
	}
}
