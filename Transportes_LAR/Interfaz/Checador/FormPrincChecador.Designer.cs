/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 22/07/2014
 * Hora: 12:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Checador
{
	partial class FormPrincChecador
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincChecador));
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.cmdSalida = new System.Windows.Forms.Button();
			this.cmdEntrada = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnChecar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(377, 40);
			this.dtpInicio.Margin = new System.Windows.Forms.Padding(4);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(118, 22);
			this.dtpInicio.TabIndex = 4;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(520, 39);
			this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(118, 22);
			this.dtpFin.TabIndex = 5;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(377, 12);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(312, 22);
			this.txtBusqueda.TabIndex = 3;
			this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusquedaKeyUp);
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.usuario,
									this.FECHA,
									this.TIPO,
									this.HORA});
			this.dgDatos.Location = new System.Drawing.Point(12, 106);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.Size = new System.Drawing.Size(677, 400);
			this.dgDatos.TabIndex = 6;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// usuario
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.usuario.DefaultCellStyle = dataGridViewCellStyle2;
			this.usuario.HeaderText = "NOMBRE";
			this.usuario.Name = "usuario";
			this.usuario.ReadOnly = true;
			this.usuario.Width = 350;
			// 
			// FECHA
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// TIPO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle4;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// HORA
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.HORA.DefaultCellStyle = dataGridViewCellStyle5;
			this.HORA.HeaderText = "HORA";
			this.HORA.Name = "HORA";
			this.HORA.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(299, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(299, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Fecha";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtContra
			// 
			this.txtContra.Location = new System.Drawing.Point(106, 40);
			this.txtContra.Name = "txtContra";
			this.txtContra.PasswordChar = '*';
			this.txtContra.Size = new System.Drawing.Size(187, 22);
			this.txtContra.TabIndex = 1;
			this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtContra.Enter += new System.EventHandler(this.TxtContraEnter);
			this.txtContra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtContraKeyUp);
			this.txtContra.Leave += new System.EventHandler(this.TxtContraLeave);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(106, 12);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(187, 22);
			this.txtUsuario.TabIndex = 0;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuarioEnter);
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuarioLeave);
			// 
			// cmdSalida
			// 
			this.cmdSalida.Enabled = false;
			this.cmdSalida.Image = ((System.Drawing.Image)(resources.GetObject("cmdSalida.Image")));
			this.cmdSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdSalida.Location = new System.Drawing.Point(208, 68);
			this.cmdSalida.Name = "cmdSalida";
			this.cmdSalida.Size = new System.Drawing.Size(85, 32);
			this.cmdSalida.TabIndex = 2;
			this.cmdSalida.Text = "Salida";
			this.cmdSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdSalida.UseVisualStyleBackColor = true;
			this.cmdSalida.Click += new System.EventHandler(this.CmdSalidaClick);
			// 
			// cmdEntrada
			// 
			this.cmdEntrada.Enabled = false;
			this.cmdEntrada.Image = ((System.Drawing.Image)(resources.GetObject("cmdEntrada.Image")));
			this.cmdEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdEntrada.Location = new System.Drawing.Point(106, 68);
			this.cmdEntrada.Name = "cmdEntrada";
			this.cmdEntrada.Size = new System.Drawing.Size(96, 32);
			this.cmdEntrada.TabIndex = 2;
			this.cmdEntrada.Text = "Entrada";
			this.cmdEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdEntrada.UseVisualStyleBackColor = true;
			this.cmdEntrada.Click += new System.EventHandler(this.CmdEntradaClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Contraseña";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Usuario";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(501, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "-";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnChecar
			// 
			this.btnChecar.Enabled = false;
			this.btnChecar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChecar.Location = new System.Drawing.Point(334, 69);
			this.btnChecar.Name = "btnChecar";
			this.btnChecar.Size = new System.Drawing.Size(63, 32);
			this.btnChecar.TabIndex = 10;
			this.btnChecar.Text = "Huella";
			this.btnChecar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnChecar.UseVisualStyleBackColor = true;
			this.btnChecar.Click += new System.EventHandler(this.BtnChecarClick);
			// 
			// FormPrincChecador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(700, 518);
			this.Controls.Add(this.btnChecar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.cmdSalida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmdEntrada);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dgDatos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormPrincChecador";
			this.Text = "Transportes LAR - Principal asistencias";
			this.Load += new System.EventHandler(this.FormPrincChecadorLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnChecar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdEntrada;
		private System.Windows.Forms.Button cmdSalida;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
	}
}
