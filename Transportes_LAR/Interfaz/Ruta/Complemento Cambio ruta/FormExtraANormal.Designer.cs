/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 14/08/2015
 * Hora: 12:48 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Ruta.Complemento_Cambio_ruta
{
	partial class FormExtraANormal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExtraANormal));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRuta = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.cbLunes = new System.Windows.Forms.CheckBox();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.cbMartes = new System.Windows.Forms.CheckBox();
			this.cbDomingo = new System.Windows.Forms.CheckBox();
			this.cbSábado = new System.Windows.Forms.CheckBox();
			this.cbViernes = new System.Windows.Forms.CheckBox();
			this.cbJueves = new System.Windows.Forms.CheckBox();
			this.cbMiercoles = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblIdRuta = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTipoVehicuo = new System.Windows.Forms.Label();
			this.lblPruba = new System.Windows.Forms.Label();
			this.timeHoraInicio = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.timeHoraFin = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "kilómetros";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dias";
			// 
			// lblRuta
			// 
			this.lblRuta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuta.Location = new System.Drawing.Point(152, 9);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(252, 23);
			this.lblRuta.TabIndex = 2;
			this.lblRuta.Text = "Ruta";
			// 
			// lblTurno
			// 
			this.lblTurno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.Location = new System.Drawing.Point(12, 55);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(199, 23);
			this.lblTurno.TabIndex = 3;
			this.lblTurno.Text = "Turno";
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpresa.Location = new System.Drawing.Point(12, 32);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(393, 23);
			this.lblEmpresa.TabIndex = 4;
			this.lblEmpresa.Text = "Empresa";
			// 
			// cbLunes
			// 
			this.cbLunes.Location = new System.Drawing.Point(6, 19);
			this.cbLunes.Name = "cbLunes";
			this.cbLunes.Size = new System.Drawing.Size(58, 24);
			this.cbLunes.TabIndex = 5;
			this.cbLunes.Text = "Lunes";
			this.cbLunes.UseVisualStyleBackColor = true;
			// 
			// txtKilometros
			// 
			this.txtKilometros.Location = new System.Drawing.Point(129, 110);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(123, 20);
			this.txtKilometros.TabIndex = 6;
			// 
			// cbMartes
			// 
			this.cbMartes.Location = new System.Drawing.Point(64, 20);
			this.cbMartes.Name = "cbMartes";
			this.cbMartes.Size = new System.Drawing.Size(63, 24);
			this.cbMartes.TabIndex = 7;
			this.cbMartes.Text = "Martes";
			this.cbMartes.UseVisualStyleBackColor = true;
			// 
			// cbDomingo
			// 
			this.cbDomingo.Location = new System.Drawing.Point(173, 48);
			this.cbDomingo.Name = "cbDomingo";
			this.cbDomingo.Size = new System.Drawing.Size(76, 24);
			this.cbDomingo.TabIndex = 8;
			this.cbDomingo.Text = "Domingo";
			this.cbDomingo.UseVisualStyleBackColor = true;
			// 
			// cbSábado
			// 
			this.cbSábado.Location = new System.Drawing.Point(98, 47);
			this.cbSábado.Name = "cbSábado";
			this.cbSábado.Size = new System.Drawing.Size(63, 24);
			this.cbSábado.TabIndex = 9;
			this.cbSábado.Text = "Sabado";
			this.cbSábado.UseVisualStyleBackColor = true;
			// 
			// cbViernes
			// 
			this.cbViernes.Location = new System.Drawing.Point(256, 20);
			this.cbViernes.Name = "cbViernes";
			this.cbViernes.Size = new System.Drawing.Size(63, 24);
			this.cbViernes.TabIndex = 10;
			this.cbViernes.Text = "Viernes";
			this.cbViernes.UseVisualStyleBackColor = true;
			// 
			// cbJueves
			// 
			this.cbJueves.Location = new System.Drawing.Point(197, 20);
			this.cbJueves.Name = "cbJueves";
			this.cbJueves.Size = new System.Drawing.Size(63, 24);
			this.cbJueves.TabIndex = 11;
			this.cbJueves.Text = "Jueves";
			this.cbJueves.UseVisualStyleBackColor = true;
			// 
			// cbMiercoles
			// 
			this.cbMiercoles.Location = new System.Drawing.Point(123, 20);
			this.cbMiercoles.Name = "cbMiercoles";
			this.cbMiercoles.Size = new System.Drawing.Size(73, 24);
			this.cbMiercoles.TabIndex = 12;
			this.cbMiercoles.Text = "Miércoles";
			this.cbMiercoles.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbLunes);
			this.groupBox1.Controls.Add(this.cbDomingo);
			this.groupBox1.Controls.Add(this.cbSábado);
			this.groupBox1.Controls.Add(this.cbViernes);
			this.groupBox1.Controls.Add(this.cbJueves);
			this.groupBox1.Controls.Add(this.cbMiercoles);
			this.groupBox1.Controls.Add(this.cbMartes);
			this.groupBox1.Location = new System.Drawing.Point(60, 186);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(322, 80);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(60, 285);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(89, 34);
			this.btnAceptar.TabIndex = 14;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(221, 285);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(99, 34);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// lblIdRuta
			// 
			this.lblIdRuta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdRuta.Location = new System.Drawing.Point(12, 9);
			this.lblIdRuta.Name = "lblIdRuta";
			this.lblIdRuta.Size = new System.Drawing.Size(100, 23);
			this.lblIdRuta.TabIndex = 16;
			this.lblIdRuta.Text = "ID";
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(129, 135);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(123, 20);
			this.txtEmpresa.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Empresa";
			// 
			// lblTipoVehicuo
			// 
			this.lblTipoVehicuo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoVehicuo.Location = new System.Drawing.Point(152, 55);
			this.lblTipoVehicuo.Name = "lblTipoVehicuo";
			this.lblTipoVehicuo.Size = new System.Drawing.Size(261, 23);
			this.lblTipoVehicuo.TabIndex = 19;
			this.lblTipoVehicuo.Text = "Vehiculo";
			// 
			// lblPruba
			// 
			this.lblPruba.Location = new System.Drawing.Point(258, 138);
			this.lblPruba.Name = "lblPruba";
			this.lblPruba.Size = new System.Drawing.Size(100, 23);
			this.lblPruba.TabIndex = 20;
			this.lblPruba.Text = "label4";
			// 
			// timeHoraInicio
			// 
			this.timeHoraInicio.CustomFormat = "HH:mm";
			this.timeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraInicio.Location = new System.Drawing.Point(93, 164);
			this.timeHoraInicio.Name = "timeHoraInicio";
			this.timeHoraInicio.ShowUpDown = true;
			this.timeHoraInicio.Size = new System.Drawing.Size(83, 20);
			this.timeHoraInicio.TabIndex = 21;
			this.timeHoraInicio.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "Inicio:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(195, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 23);
			this.label5.TabIndex = 23;
			this.label5.Text = "Fin:";
			// 
			// timeHoraFin
			// 
			this.timeHoraFin.CustomFormat = "HH:mm";
			this.timeHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraFin.Location = new System.Drawing.Point(247, 164);
			this.timeHoraFin.Name = "timeHoraFin";
			this.timeHoraFin.ShowUpDown = true;
			this.timeHoraFin.Size = new System.Drawing.Size(83, 20);
			this.timeHoraFin.TabIndex = 24;
			this.timeHoraFin.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// FormExtraANormal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 329);
			this.Controls.Add(this.timeHoraFin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.timeHoraInicio);
			this.Controls.Add(this.lblPruba);
			this.Controls.Add(this.lblTipoVehicuo);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblIdRuta);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtKilometros);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.lblRuta);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormExtraANormal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambiar de Extra a Normal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExtraANormalFormClosing);
			this.Load += new System.EventHandler(this.FormExtraANormalLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker timeHoraFin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker timeHoraInicio;
		private System.Windows.Forms.Label lblPruba;
		private System.Windows.Forms.Label lblTipoVehicuo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label lblIdRuta;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbMiercoles;
		private System.Windows.Forms.CheckBox cbJueves;
		private System.Windows.Forms.CheckBox cbViernes;
		private System.Windows.Forms.CheckBox cbSábado;
		private System.Windows.Forms.CheckBox cbDomingo;
		private System.Windows.Forms.CheckBox cbMartes;
		private System.Windows.Forms.TextBox txtKilometros;
		private System.Windows.Forms.CheckBox cbLunes;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.Label lblRuta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
