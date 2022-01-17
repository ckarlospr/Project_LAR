/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 08/01/2016
 * Hora: 13:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormViajesOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViajesOperador));
			this.dgOperadores = new System.Windows.Forms.DataGridView();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.dtpInactivos = new System.Windows.Forms.DateTimePicker();
			this.cbInactivos = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOperadores
			// 
			this.dgOperadores.AllowUserToAddRows = false;
			this.dgOperadores.AllowUserToResizeRows = false;
			this.dgOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOperadores.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperadores.Location = new System.Drawing.Point(14, 62);
			this.dgOperadores.Name = "dgOperadores";
			this.dgOperadores.RowHeadersVisible = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dgOperadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgOperadores.Size = new System.Drawing.Size(531, 585);
			this.dgOperadores.TabIndex = 1;
			// 
			// bntBuscar
			// 
			this.bntBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(266, 10);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(92, 41);
			this.bntBuscar.TabIndex = 65;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(154, 10);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 62;
			// 
			// dtpIncio
			// 
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(32, 10);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(100, 20);
			this.dtpIncio.TabIndex = 61;
			this.dtpIncio.ValueChanged += new System.EventHandler(this.DtpIncioValueChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(129, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 64;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 18);
			this.label6.TabIndex = 63;
			this.label6.Text = "Del";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.BackColor = System.Drawing.Color.Transparent;
			this.cmdImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.BackgroundImage")));
			this.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Location = new System.Drawing.Point(372, 9);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(85, 45);
			this.cmdImprimir.TabIndex = 66;
			this.cmdImprimir.Text = "Horizontal";
			this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdImprimir.UseVisualStyleBackColor = false;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// dtpInactivos
			// 
			this.dtpInactivos.Enabled = false;
			this.dtpInactivos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInactivos.Location = new System.Drawing.Point(154, 36);
			this.dtpInactivos.Name = "dtpInactivos";
			this.dtpInactivos.Size = new System.Drawing.Size(100, 20);
			this.dtpInactivos.TabIndex = 67;
			// 
			// cbInactivos
			// 
			this.cbInactivos.Location = new System.Drawing.Point(43, 34);
			this.cbInactivos.Name = "cbInactivos";
			this.cbInactivos.Size = new System.Drawing.Size(79, 24);
			this.cbInactivos.TabIndex = 68;
			this.cbInactivos.Text = "Inactivos";
			this.cbInactivos.UseVisualStyleBackColor = true;
			this.cbInactivos.CheckedChanged += new System.EventHandler(this.CbInactivosCheckedChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(464, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 45);
			this.button1.TabIndex = 69;
			this.button1.Text = "Vertical";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormViajesOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 659);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbInactivos);
			this.Controls.Add(this.dtpInactivos);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpIncio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dgOperadores);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(440, 698);
			this.Name = "FormViajesOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Viajes por Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViajesOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormViajesOperadorLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox cbInactivos;
		private System.Windows.Forms.DateTimePicker dtpInactivos;
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.DataGridView dgOperadores;
	}
}
