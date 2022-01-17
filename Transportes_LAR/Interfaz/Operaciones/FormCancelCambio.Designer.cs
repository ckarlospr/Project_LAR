/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 25/10/2012
 * Time: 8:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormCancelCambio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelCambio));
			this.CmdCancelarViaje = new System.Windows.Forms.Button();
			this.cmdCancelProceso = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.lblDato = new System.Windows.Forms.Label();
			this.txtDato = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdCancelaEspecial = new System.Windows.Forms.Button();
			this.cmdPunto = new System.Windows.Forms.Button();
			this.cmdApoyos = new System.Windows.Forms.Button();
			this.cmdQuitarOperador = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdPruebas = new System.Windows.Forms.Button();
			this.cmdRec = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdCanc2 = new System.Windows.Forms.Button();
			this.btnUberTaxi = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// CmdCancelarViaje
			// 
			this.CmdCancelarViaje.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CmdCancelarViaje.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancelarViaje.Image")));
			this.CmdCancelarViaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CmdCancelarViaje.Location = new System.Drawing.Point(15, 128);
			this.CmdCancelarViaje.Name = "CmdCancelarViaje";
			this.CmdCancelarViaje.Size = new System.Drawing.Size(158, 30);
			this.CmdCancelarViaje.TabIndex = 0;
			this.CmdCancelarViaje.Text = "Cancelar viaje";
			this.CmdCancelarViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.CmdCancelarViaje, "Cancelar asignacion");
			this.CmdCancelarViaje.UseVisualStyleBackColor = true;
			this.CmdCancelarViaje.Click += new System.EventHandler(this.CmdCancelarViajeClick);
			// 
			// cmdCancelProceso
			// 
			this.cmdCancelProceso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelProceso.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelProceso.Image")));
			this.cmdCancelProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancelProceso.Location = new System.Drawing.Point(106, 564);
			this.cmdCancelProceso.Name = "cmdCancelProceso";
			this.cmdCancelProceso.Size = new System.Drawing.Size(95, 28);
			this.cmdCancelProceso.TabIndex = 3;
			this.cmdCancelProceso.Text = "Cancelar";
			this.cmdCancelProceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdCancelProceso, "Cancelar acción");
			this.cmdCancelProceso.UseVisualStyleBackColor = true;
			this.cmdCancelProceso.Click += new System.EventHandler(this.CmdCancelProcesoClick);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.Location = new System.Drawing.Point(15, 45);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(158, 26);
			this.cmdGuardar.TabIndex = 2;
			this.cmdGuardar.Text = "Guardar";
			this.toolTip1.SetToolTip(this.cmdGuardar, "Guardar cambio de hora");
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// lblDato
			// 
			this.lblDato.Location = new System.Drawing.Point(6, 16);
			this.lblDato.Name = "lblDato";
			this.lblDato.Size = new System.Drawing.Size(177, 41);
			this.lblDato.TabIndex = 4;
			this.lblDato.Text = "Operador-Ruta";
			this.lblDato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDato
			// 
			this.txtDato.Location = new System.Drawing.Point(32, 19);
			this.txtDato.MaxLength = 5;
			this.txtDato.Name = "txtDato";
			this.txtDato.Size = new System.Drawing.Size(121, 20);
			this.txtDato.TabIndex = 5;
			this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.cmdCancelaEspecial);
			this.groupBox1.Controls.Add(this.cmdPunto);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 383);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(189, 100);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Viajes especiales";
			// 
			// cmdCancelaEspecial
			// 
			this.cmdCancelaEspecial.Enabled = false;
			this.cmdCancelaEspecial.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelaEspecial.Image")));
			this.cmdCancelaEspecial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancelaEspecial.Location = new System.Drawing.Point(15, 58);
			this.cmdCancelaEspecial.Name = "cmdCancelaEspecial";
			this.cmdCancelaEspecial.Size = new System.Drawing.Size(158, 30);
			this.cmdCancelaEspecial.TabIndex = 8;
			this.cmdCancelaEspecial.Text = "Viaje Esp. Canc.";
			this.cmdCancelaEspecial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdCancelaEspecial, "Cuando el cliente cancela el viaje con tiempo");
			this.cmdCancelaEspecial.UseVisualStyleBackColor = true;
			this.cmdCancelaEspecial.Click += new System.EventHandler(this.CmdCancelaEspecialClick);
			// 
			// cmdPunto
			// 
			this.cmdPunto.Image = ((System.Drawing.Image)(resources.GetObject("cmdPunto.Image")));
			this.cmdPunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdPunto.Location = new System.Drawing.Point(15, 22);
			this.cmdPunto.Name = "cmdPunto";
			this.cmdPunto.Size = new System.Drawing.Size(158, 30);
			this.cmdPunto.TabIndex = 6;
			this.cmdPunto.Text = "Can. en el punto";
			this.cmdPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdPunto, "Cancelacion en el punto");
			this.cmdPunto.UseVisualStyleBackColor = true;
			this.cmdPunto.Click += new System.EventHandler(this.CmdPuntoClick);
			// 
			// cmdApoyos
			// 
			this.cmdApoyos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdApoyos.Image = ((System.Drawing.Image)(resources.GetObject("cmdApoyos.Image")));
			this.cmdApoyos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdApoyos.Location = new System.Drawing.Point(15, 19);
			this.cmdApoyos.Name = "cmdApoyos";
			this.cmdApoyos.Size = new System.Drawing.Size(158, 26);
			this.cmdApoyos.TabIndex = 7;
			this.cmdApoyos.Text = "Apoyos";
			this.cmdApoyos.UseVisualStyleBackColor = true;
			this.cmdApoyos.Click += new System.EventHandler(this.CmdApoyosClick);
			// 
			// cmdQuitarOperador
			// 
			this.cmdQuitarOperador.Image = ((System.Drawing.Image)(resources.GetObject("cmdQuitarOperador.Image")));
			this.cmdQuitarOperador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdQuitarOperador.Location = new System.Drawing.Point(15, 60);
			this.cmdQuitarOperador.Name = "cmdQuitarOperador";
			this.cmdQuitarOperador.Size = new System.Drawing.Size(158, 30);
			this.cmdQuitarOperador.TabIndex = 5;
			this.cmdQuitarOperador.Text = "Quitar operador";
			this.cmdQuitarOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdQuitarOperador, "Quitar el operador de la planación");
			this.cmdQuitarOperador.UseVisualStyleBackColor = true;
			this.cmdQuitarOperador.Click += new System.EventHandler(this.CmdQuitarOperadorClick);
			// 
			// groupBox2
			// 
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.txtDato);
			this.groupBox2.Controls.Add(this.cmdGuardar);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(189, 84);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cambio de hora";
			// 
			// cmdPruebas
			// 
			this.cmdPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdPruebas.Image = ((System.Drawing.Image)(resources.GetObject("cmdPruebas.Image")));
			this.cmdPruebas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdPruebas.Location = new System.Drawing.Point(15, 83);
			this.cmdPruebas.Name = "cmdPruebas";
			this.cmdPruebas.Size = new System.Drawing.Size(158, 26);
			this.cmdPruebas.TabIndex = 7;
			this.cmdPruebas.Text = "Pruebas de rendimiento";
			this.cmdPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdPruebas, "Pruebas de redimiento del vehículo");
			this.cmdPruebas.UseVisualStyleBackColor = true;
			this.cmdPruebas.Click += new System.EventHandler(this.CmdPruebasClick);
			// 
			// cmdRec
			// 
			this.cmdRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRec.Image = ((System.Drawing.Image)(resources.GetObject("cmdRec.Image")));
			this.cmdRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdRec.Location = new System.Drawing.Point(15, 51);
			this.cmdRec.Name = "cmdRec";
			this.cmdRec.Size = new System.Drawing.Size(158, 26);
			this.cmdRec.TabIndex = 6;
			this.cmdRec.Text = "Reconocimiento de rutas";
			this.cmdRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdRec, "Operador reconoce nuevas rutas");
			this.cmdRec.UseVisualStyleBackColor = true;
			this.cmdRec.Click += new System.EventHandler(this.CmdRecClick);
			// 
			// cmdCanc2
			// 
			this.cmdCanc2.Image = ((System.Drawing.Image)(resources.GetObject("cmdCanc2.Image")));
			this.cmdCanc2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCanc2.Location = new System.Drawing.Point(15, 94);
			this.cmdCanc2.Name = "cmdCanc2";
			this.cmdCanc2.Size = new System.Drawing.Size(158, 30);
			this.cmdCanc2.TabIndex = 9;
			this.cmdCanc2.Text = "Can. en el punto";
			this.cmdCanc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip1.SetToolTip(this.cmdCanc2, "Cancelacion en el punto");
			this.cmdCanc2.UseVisualStyleBackColor = true;
			this.cmdCanc2.Click += new System.EventHandler(this.CmdPuntoClick);
			// 
			// btnUberTaxi
			// 
			this.btnUberTaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnUberTaxi.Image")));
			this.btnUberTaxi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUberTaxi.Location = new System.Drawing.Point(15, 22);
			this.btnUberTaxi.Name = "btnUberTaxi";
			this.btnUberTaxi.Size = new System.Drawing.Size(158, 30);
			this.btnUberTaxi.TabIndex = 6;
			this.btnUberTaxi.Text = "Uber/taxi";
			this.toolTip1.SetToolTip(this.btnUberTaxi, "Cancelacion en el punto");
			this.btnUberTaxi.UseVisualStyleBackColor = true;
			this.btnUberTaxi.Click += new System.EventHandler(this.BtnUberTaxiClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmdCanc2);
			this.groupBox3.Controls.Add(this.cmdQuitarOperador);
			this.groupBox3.Controls.Add(this.lblDato);
			this.groupBox3.Controls.Add(this.CmdCancelarViaje);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(12, 91);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(189, 164);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Viajes empresariales";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cmdPruebas);
			this.groupBox4.Controls.Add(this.cmdApoyos);
			this.groupBox4.Controls.Add(this.cmdRec);
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(12, 259);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(189, 120);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Servicios adicionales";
			// 
			// groupBox5
			// 
			this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox5.Controls.Add(this.btnUberTaxi);
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(12, 487);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(189, 62);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Otros";
			// 
			// FormCancelCambio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(211, 597);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdCancelProceso);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCancelCambio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambios";
			this.Load += new System.EventHandler(this.FormCancelCambioLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnUberTaxi;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button cmdCanc2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button cmdCancelaEspecial;
		private System.Windows.Forms.Button cmdApoyos;
		private System.Windows.Forms.Button cmdRec;
		private System.Windows.Forms.Button cmdPruebas;
		private System.Windows.Forms.Button cmdPunto;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button cmdQuitarOperador;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDato;
		private System.Windows.Forms.Label lblDato;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Button cmdCancelProceso;
		private System.Windows.Forms.Button CmdCancelarViaje;
	}
}
