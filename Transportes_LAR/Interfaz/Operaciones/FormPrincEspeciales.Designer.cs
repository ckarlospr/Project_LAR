/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 19/03/2013
 * Time: 9:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormPrincEspeciales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincEspeciales));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblSinAsignar = new System.Windows.Forms.Label();
			this.lblVistaRap = new System.Windows.Forms.Label();
			this.pDatos = new System.Windows.Forms.Panel();
			this.pVistaRapida = new System.Windows.Forms.Panel();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdMostrar = new System.Windows.Forms.Button();
			this.cmdCerrar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cmdTodo = new System.Windows.Forms.Button();
			this.cmdAgregaEsp = new System.Windows.Forms.Button();
			this.btnRefresca = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Totales:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sin asignar:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1244, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Vista rapida:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Visible = false;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(104, 15);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(61, 18);
			this.lblTotal.TabIndex = 4;
			this.lblTotal.Text = "0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSinAsignar
			// 
			this.lblSinAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSinAsignar.Location = new System.Drawing.Point(104, 39);
			this.lblSinAsignar.Name = "lblSinAsignar";
			this.lblSinAsignar.Size = new System.Drawing.Size(61, 18);
			this.lblSinAsignar.TabIndex = 5;
			this.lblSinAsignar.Text = "0";
			this.lblSinAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVistaRap
			// 
			this.lblVistaRap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVistaRap.Location = new System.Drawing.Point(1244, 39);
			this.lblVistaRap.Name = "lblVistaRap";
			this.lblVistaRap.Size = new System.Drawing.Size(43, 18);
			this.lblVistaRap.TabIndex = 6;
			this.lblVistaRap.Text = "0";
			this.lblVistaRap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblVistaRap.Visible = false;
			// 
			// pDatos
			// 
			this.pDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pDatos.AutoScroll = true;
			this.pDatos.Location = new System.Drawing.Point(383, 71);
			this.pDatos.Name = "pDatos";
			this.pDatos.Size = new System.Drawing.Size(904, 485);
			this.pDatos.TabIndex = 8;
			// 
			// pVistaRapida
			// 
			this.pVistaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pVistaRapida.AutoScroll = true;
			this.pVistaRapida.Location = new System.Drawing.Point(6, 71);
			this.pVistaRapida.Name = "pVistaRapida";
			this.pVistaRapida.Size = new System.Drawing.Size(374, 485);
			this.pVistaRapida.TabIndex = 9;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(54, 17);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(100, 20);
			this.dtpInicio.TabIndex = 10;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(54, 39);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 11;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 18);
			this.label2.TabIndex = 12;
			this.label2.Text = "DE:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "AL:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpFin);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dtpInicio);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(203, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 64);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rango de fecha:";
			this.groupBox1.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblSinAsignar);
			this.groupBox2.Controls.Add(this.lblTotal);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(6, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 64);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			// 
			// cmdMostrar
			// 
			this.cmdMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdMostrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMostrar.Image")));
			this.cmdMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdMostrar.Location = new System.Drawing.Point(1129, 6);
			this.cmdMostrar.Name = "cmdMostrar";
			this.cmdMostrar.Size = new System.Drawing.Size(90, 23);
			this.cmdMostrar.TabIndex = 16;
			this.cmdMostrar.Text = "Extraer";
			this.cmdMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdMostrar.UseVisualStyleBackColor = true;
			this.cmdMostrar.Visible = false;
			this.cmdMostrar.Click += new System.EventHandler(this.CmdMostrarClick);
			// 
			// cmdCerrar
			// 
			this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
			this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCerrar.Location = new System.Drawing.Point(1129, 39);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.Size = new System.Drawing.Size(90, 23);
			this.cmdCerrar.TabIndex = 17;
			this.cmdCerrar.Text = "Contraer";
			this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCerrar.UseVisualStyleBackColor = true;
			this.cmdCerrar.Visible = false;
			this.cmdCerrar.Click += new System.EventHandler(this.CmdCerrarClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(575, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(548, 53);
			this.label6.TabIndex = 18;
			this.label6.Text = "ESPECIALES";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdTodo
			// 
			this.cmdTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdTodo.Image = ((System.Drawing.Image)(resources.GetObject("cmdTodo.Image")));
			this.cmdTodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdTodo.Location = new System.Drawing.Point(383, 2);
			this.cmdTodo.Name = "cmdTodo";
			this.cmdTodo.Size = new System.Drawing.Size(90, 60);
			this.cmdTodo.TabIndex = 19;
			this.cmdTodo.Text = "Vista completa";
			this.cmdTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdTodo.UseVisualStyleBackColor = true;
			this.cmdTodo.Click += new System.EventHandler(this.CmdTodoClick);
			// 
			// cmdAgregaEsp
			// 
			this.cmdAgregaEsp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAgregaEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregaEsp.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregaEsp.Image")));
			this.cmdAgregaEsp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdAgregaEsp.Location = new System.Drawing.Point(479, 2);
			this.cmdAgregaEsp.Name = "cmdAgregaEsp";
			this.cmdAgregaEsp.Size = new System.Drawing.Size(90, 60);
			this.cmdAgregaEsp.TabIndex = 20;
			this.cmdAgregaEsp.Text = "Agregar\r\nEspecial";
			this.cmdAgregaEsp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdAgregaEsp.UseVisualStyleBackColor = true;
			this.cmdAgregaEsp.Visible = false;
			this.cmdAgregaEsp.Click += new System.EventHandler(this.CmdAgregaEspClick);
			// 
			// btnRefresca
			// 
			this.btnRefresca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresca.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresca.Image")));
			this.btnRefresca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRefresca.Location = new System.Drawing.Point(585, 6);
			this.btnRefresca.Name = "btnRefresca";
			this.btnRefresca.Size = new System.Drawing.Size(80, 56);
			this.btnRefresca.TabIndex = 21;
			this.btnRefresca.Text = "REFRESCA";
			this.btnRefresca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRefresca.UseVisualStyleBackColor = true;
			this.btnRefresca.Click += new System.EventHandler(this.BtnRefrescaClick);
			// 
			// FormPrincEspeciales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1291, 561);
			this.Controls.Add(this.btnRefresca);
			this.Controls.Add(this.cmdAgregaEsp);
			this.Controls.Add(this.cmdTodo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.cmdMostrar);
			this.Controls.Add(this.lblVistaRap);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pVistaRapida);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pDatos);
			this.MinimumSize = new System.Drawing.Size(1307, 599);
			this.Name = "FormPrincEspeciales";
			this.Text = "Servicios Especiales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincEspecialesFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincEspecialesFormClosed);
			this.Load += new System.EventHandler(this.FormPrincEspecialesLoad);
			this.VisibleChanged += new System.EventHandler(this.FormPrincEspecialesVisibleChanged);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRefresca;
		private System.Windows.Forms.Button cmdAgregaEsp;
		private System.Windows.Forms.Button cmdTodo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Button cmdMostrar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.DateTimePicker dtpFin;
		public System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Panel pVistaRapida;
		private System.Windows.Forms.Panel pDatos;
		private System.Windows.Forms.Label lblVistaRap;
		private System.Windows.Forms.Label lblSinAsignar;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
