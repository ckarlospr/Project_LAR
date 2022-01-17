/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 31/10/2012
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormDatosEspecial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosEspecial));
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.txtUnidades = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtPlanton = new System.Windows.Forms.TextBox();
			this.lblFechaViaje = new System.Windows.Forms.Label();
			this.txtFechaViaje = new System.Windows.Forms.TextBox();
			this.txtHraRegreso = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtTipoUnidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtCruces = new System.Windows.Forms.TextBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.txtAnticipo = new System.Windows.Forms.TextBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.txtUsuarios = new System.Windows.Forms.TextBox();
			this.txtdDestino = new System.Windows.Forms.TextBox();
			this.txtrefVisualS = new System.Windows.Forms.TextBox();
			this.txtrefVisualD = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtFechaRegreso = new System.Windows.Forms.TextBox();
			this.cmdInformacion = new System.Windows.Forms.Button();
			this.lblCobro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(732, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 14);
			this.label7.TabIndex = 1;
			this.label7.Text = "H/Planton";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(568, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 23);
			this.label13.TabIndex = 7;
			this.label13.Text = "Responsable:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(591, 98);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(52, 23);
			this.label18.TabIndex = 12;
			this.label18.Text = "Teléfono:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(5, 26);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(371, 20);
			this.txtDomicilio.TabIndex = 4;
			this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtDomicilio, "Domicilio del viaje especial");
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(5, 2);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(371, 22);
			this.txtDestino.TabIndex = 1;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtDestino, "Destino del viaje especial");
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservaciones.Location = new System.Drawing.Point(387, 123);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(460, 37);
			this.txtObservaciones.TabIndex = 13;
			this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtObservaciones, "Observaciones del viaje especial");
			// 
			// txtResponsable
			// 
			this.txtResponsable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResponsable.Location = new System.Drawing.Point(644, 49);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(237, 20);
			this.txtResponsable.TabIndex = 7;
			this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtUnidades
			// 
			this.txtUnidades.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidades.Location = new System.Drawing.Point(387, 4);
			this.txtUnidades.Name = "txtUnidades";
			this.txtUnidades.Size = new System.Drawing.Size(45, 20);
			this.txtUnidades.TabIndex = 3;
			this.txtUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtUnidades, "Cantidad de unidades");
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(644, 99);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(237, 20);
			this.txtTelefono.TabIndex = 9;
			this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPlanton
			// 
			this.txtPlanton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlanton.Location = new System.Drawing.Point(732, 4);
			this.txtPlanton.Name = "txtPlanton";
			this.txtPlanton.Size = new System.Drawing.Size(72, 20);
			this.txtPlanton.TabIndex = 2;
			this.txtPlanton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblFechaViaje
			// 
			this.lblFechaViaje.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaViaje.Location = new System.Drawing.Point(567, 25);
			this.lblFechaViaje.Name = "lblFechaViaje";
			this.lblFechaViaje.Size = new System.Drawing.Size(77, 14);
			this.lblFechaViaje.TabIndex = 16;
			this.lblFechaViaje.Text = "Salida";
			this.lblFechaViaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtFechaViaje
			// 
			this.txtFechaViaje.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFechaViaje.Location = new System.Drawing.Point(567, 4);
			this.txtFechaViaje.Name = "txtFechaViaje";
			this.txtFechaViaje.Size = new System.Drawing.Size(77, 20);
			this.txtFechaViaje.TabIndex = 17;
			this.txtFechaViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtHraRegreso
			// 
			this.txtHraRegreso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHraRegreso.Location = new System.Drawing.Point(809, 4);
			this.txtHraRegreso.Name = "txtHraRegreso";
			this.txtHraRegreso.Size = new System.Drawing.Size(72, 20);
			this.txtHraRegreso.TabIndex = 27;
			this.txtHraRegreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(809, 25);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(72, 14);
			this.label22.TabIndex = 26;
			this.label22.Text = "H/Regreso";
			this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(649, 25);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(77, 14);
			this.label23.TabIndex = 28;
			this.label23.Text = "Regreso";
			this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtTipoUnidad
			// 
			this.txtTipoUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoUnidad.Location = new System.Drawing.Point(435, 4);
			this.txtTipoUnidad.Name = "txtTipoUnidad";
			this.txtTipoUnidad.Size = new System.Drawing.Size(95, 20);
			this.txtTipoUnidad.TabIndex = 19;
			this.txtTipoUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtTipoUnidad, "Tipo de unidades");
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(387, 26);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(59, 20);
			this.txtPrecio.TabIndex = 8;
			this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtPrecio, "Precio del viaje");
			// 
			// txtCruces
			// 
			this.txtCruces.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCruces.Location = new System.Drawing.Point(330, 48);
			this.txtCruces.Name = "txtCruces";
			this.txtCruces.Size = new System.Drawing.Size(232, 20);
			this.txtCruces.TabIndex = 5;
			this.txtCruces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtCruces, "Cruces de calles");
			// 
			// txtColonia
			// 
			this.txtColonia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(68, 48);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(201, 20);
			this.txtColonia.TabIndex = 6;
			this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtColonia, "Colonia");
			// 
			// txtAnticipo
			// 
			this.txtAnticipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnticipo.Location = new System.Drawing.Point(449, 26);
			this.txtAnticipo.Name = "txtAnticipo";
			this.txtAnticipo.Size = new System.Drawing.Size(55, 20);
			this.txtAnticipo.TabIndex = 31;
			this.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtAnticipo, "Anticipo");
			// 
			// txtSaldo
			// 
			this.txtSaldo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.Location = new System.Drawing.Point(507, 26);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(55, 20);
			this.txtSaldo.TabIndex = 32;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtSaldo, "Saldo");
			// 
			// txtUsuarios
			// 
			this.txtUsuarios.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuarios.Location = new System.Drawing.Point(533, 4);
			this.txtUsuarios.Name = "txtUsuarios";
			this.txtUsuarios.Size = new System.Drawing.Size(29, 20);
			this.txtUsuarios.TabIndex = 33;
			this.txtUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtUsuarios, "Tipo de unidades");
			// 
			// txtdDestino
			// 
			this.txtdDestino.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdDestino.Location = new System.Drawing.Point(65, 95);
			this.txtdDestino.Multiline = true;
			this.txtdDestino.Name = "txtdDestino";
			this.txtdDestino.Size = new System.Drawing.Size(497, 20);
			this.txtdDestino.TabIndex = 35;
			this.txtdDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtdDestino, "Domicilio del viaje especial");
			// 
			// txtrefVisualS
			// 
			this.txtrefVisualS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtrefVisualS.Location = new System.Drawing.Point(109, 71);
			this.txtrefVisualS.Multiline = true;
			this.txtrefVisualS.Name = "txtrefVisualS";
			this.txtrefVisualS.Size = new System.Drawing.Size(453, 20);
			this.txtrefVisualS.TabIndex = 37;
			this.txtrefVisualS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtrefVisualS, "Domicilio del viaje especial");
			// 
			// txtrefVisualD
			// 
			this.txtrefVisualD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtrefVisualD.Location = new System.Drawing.Point(116, 123);
			this.txtrefVisualD.Multiline = true;
			this.txtrefVisualD.Name = "txtrefVisualD";
			this.txtrefVisualD.Size = new System.Drawing.Size(199, 37);
			this.txtrefVisualD.TabIndex = 39;
			this.txtrefVisualD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.txtrefVisualD, "Domicilio del viaje especial");
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(12, 51);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 16);
			this.label12.TabIndex = 6;
			this.label12.Text = "Col/Sec:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(273, 51);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 16);
			this.label11.TabIndex = 5;
			this.label11.Text = "Cruces:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(600, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Cliente:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCliente
			// 
			this.txtCliente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.Location = new System.Drawing.Point(644, 74);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(237, 20);
			this.txtCliente.TabIndex = 21;
			this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtFechaRegreso
			// 
			this.txtFechaRegreso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFechaRegreso.Location = new System.Drawing.Point(650, 4);
			this.txtFechaRegreso.Name = "txtFechaRegreso";
			this.txtFechaRegreso.Size = new System.Drawing.Size(77, 20);
			this.txtFechaRegreso.TabIndex = 29;
			this.txtFechaRegreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdInformacion
			// 
			this.cmdInformacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdInformacion.Image")));
			this.cmdInformacion.Location = new System.Drawing.Point(850, 123);
			this.cmdInformacion.Name = "cmdInformacion";
			this.cmdInformacion.Size = new System.Drawing.Size(31, 37);
			this.cmdInformacion.TabIndex = 30;
			this.cmdInformacion.UseVisualStyleBackColor = true;
			this.cmdInformacion.Click += new System.EventHandler(this.CmdInformacionClick);
			// 
			// lblCobro
			// 
			this.lblCobro.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.lblCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCobro.Location = new System.Drawing.Point(462, 26);
			this.lblCobro.Name = "lblCobro";
			this.lblCobro.Size = new System.Drawing.Size(100, 20);
			this.lblCobro.TabIndex = 34;
			this.lblCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.lblCobro.Visible = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 36;
			this.label1.Text = "Destino:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 16);
			this.label2.TabIndex = 38;
			this.label2.Text = "Ref. Visual Salida:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 16);
			this.label3.TabIndex = 40;
			this.label3.Text = "Ref. Visual Destino:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(318, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 16);
			this.label4.TabIndex = 41;
			this.label4.Text = "Comentarios:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(-2, 162);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(900, 3);
			this.label29.TabIndex = 109;
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormDatosEspecial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(887, 165);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.txtrefVisualD);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtrefVisualS);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtdDestino);
			this.Controls.Add(this.lblCobro);
			this.Controls.Add(this.txtUsuarios);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.txtAnticipo);
			this.Controls.Add(this.cmdInformacion);
			this.Controls.Add(this.txtFechaRegreso);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.txtTipoUnidad);
			this.Controls.Add(this.txtHraRegreso);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.txtUnidades);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.txtFechaViaje);
			this.Controls.Add(this.lblFechaViaje);
			this.Controls.Add(this.txtResponsable);
			this.Controls.Add(this.txtPlanton);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtColonia);
			this.Controls.Add(this.txtCruces);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatosEspecial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Datos viaje especial";
			this.Load += new System.EventHandler(this.FormDatosEspecialLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtrefVisualD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtrefVisualS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtdDestino;
		private System.Windows.Forms.TextBox lblCobro;
		private System.Windows.Forms.TextBox txtUsuarios;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.TextBox txtAnticipo;
		private System.Windows.Forms.Button cmdInformacion;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtTipoUnidad;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtFechaRegreso;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtHraRegreso;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFechaViaje;
		private System.Windows.Forms.Label lblFechaViaje;
		private System.Windows.Forms.TextBox txtPlanton;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtUnidades;
		private System.Windows.Forms.TextBox txtResponsable;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.TextBox txtCruces;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
	}
}
