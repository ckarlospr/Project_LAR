/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 29/09/2012
 * Time: 9:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormAddRutas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRutas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblNomEmpresa = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgRutas = new System.Windows.Forms.DataGridView();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNomEmpresa
			// 
			this.lblNomEmpresa.BackColor = System.Drawing.Color.White;
			this.lblNomEmpresa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("lblNomEmpresa.Image")));
			this.lblNomEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNomEmpresa.Location = new System.Drawing.Point(0, 0);
			this.lblNomEmpresa.Name = "lblNomEmpresa";
			this.lblNomEmpresa.Size = new System.Drawing.Size(512, 46);
			this.lblNomEmpresa.TabIndex = 0;
			this.lblNomEmpresa.Text = "Empresa";
			this.lblNomEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.dtgRutas);
			this.panel1.Location = new System.Drawing.Point(11, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(639, 139);
			this.panel1.TabIndex = 1;
			// 
			// dtgRutas
			// 
			this.dtgRutas.AllowUserToAddRows = false;
			this.dtgRutas.AllowUserToResizeColumns = false;
			this.dtgRutas.AllowUserToResizeRows = false;
			this.dtgRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtgRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgRutas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dtgRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Ruta,
									this.Sentido,
									this.turno});
			this.dtgRutas.Location = new System.Drawing.Point(3, 3);
			this.dtgRutas.Name = "dtgRutas";
			this.dtgRutas.RowHeadersVisible = false;
			this.dtgRutas.Size = new System.Drawing.Size(632, 128);
			this.dtgRutas.TabIndex = 0;
			this.dtgRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgRutasCellClick);
			this.dtgRutas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgRutasCellMouseClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAgregar.Location = new System.Drawing.Point(568, 196);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(82, 25);
			this.cmdAgregar.TabIndex = 2;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(668, 46);
			this.label1.TabIndex = 3;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Ruta
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			this.Ruta.DefaultCellStyle = dataGridViewCellStyle2;
			this.Ruta.HeaderText = "Ruta Eliminadas temporlamente";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			// 
			// Sentido
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle3;
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			// 
			// turno
			// 
			this.turno.HeaderText = "Horario";
			this.turno.Name = "turno";
			// 
			// FormAddRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(668, 235);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblNomEmpresa);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAddRutas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddRutas";
			this.Load += new System.EventHandler(this.FormAddRutasLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn turno;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridView dtgRutas;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNomEmpresa;
	}
}
