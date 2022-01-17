/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 02/07/2013
 * Time: 02:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Incapacidad
{
	partial class FormValidaFact
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaFact));
			this.dgEspeciales = new System.Windows.Forms.DataGridView();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdFacturar = new System.Windows.Forms.Button();
			this.txtMsj = new System.Windows.Forms.TextBox();
			this.cmdGuardaMsj = new System.Windows.Forms.Button();
			this.txtMsjServicio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFactura = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).BeginInit();
			this.SuspendLayout();
			// 
			// dgEspeciales
			// 
			this.dgEspeciales.AllowUserToAddRows = false;
			this.dgEspeciales.AllowUserToResizeRows = false;
			this.dgEspeciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgEspeciales.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEspeciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RE,
									this.RAZON,
									this.DESTINO,
									this.FECHA,
									this.CLIENTE,
									this.RESPONSABLE,
									this.CANTIDAD,
									this.TIPO,
									this.FACTURADO});
			this.dgEspeciales.Location = new System.Drawing.Point(12, 12);
			this.dgEspeciales.MultiSelect = false;
			this.dgEspeciales.Name = "dgEspeciales";
			this.dgEspeciales.RowHeadersVisible = false;
			this.dgEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEspeciales.Size = new System.Drawing.Size(884, 323);
			this.dgEspeciales.TabIndex = 1;
			// 
			// ID_RE
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_RE.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID_RE.HeaderText = "ID";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Width = 40;
			// 
			// RAZON
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.RAZON.DefaultCellStyle = dataGridViewCellStyle3;
			this.RAZON.HeaderText = "RAZON SOCIAL";
			this.RAZON.Name = "RAZON";
			this.RAZON.ReadOnly = true;
			this.RAZON.Width = 150;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle4;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			this.DESTINO.Width = 150;
			// 
			// FECHA
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle5;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// CLIENTE
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle6;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			this.CLIENTE.Width = 120;
			// 
			// RESPONSABLE
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RESPONSABLE.DefaultCellStyle = dataGridViewCellStyle7;
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Width = 120;
			// 
			// CANTIDAD
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle8;
			this.CANTIDAD.HeaderText = "CANT.";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			this.CANTIDAD.Width = 60;
			// 
			// TIPO
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle9;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			this.TIPO.Width = 70;
			// 
			// FACTURADO
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FACTURADO.DefaultCellStyle = dataGridViewCellStyle10;
			this.FACTURADO.HeaderText = "FACT";
			this.FACTURADO.Name = "FACTURADO";
			this.FACTURADO.ReadOnly = true;
			this.FACTURADO.Width = 40;
			// 
			// cmdFacturar
			// 
			this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdFacturar.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.Image")));
			this.cmdFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdFacturar.Location = new System.Drawing.Point(781, 428);
			this.cmdFacturar.Name = "cmdFacturar";
			this.cmdFacturar.Size = new System.Drawing.Size(115, 44);
			this.cmdFacturar.TabIndex = 2;
			this.cmdFacturar.Text = "Facturar";
			this.cmdFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdFacturar.UseVisualStyleBackColor = true;
			this.cmdFacturar.Click += new System.EventHandler(this.CmdFacturarClick);
			// 
			// txtMsj
			// 
			this.txtMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtMsj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMsj.Location = new System.Drawing.Point(12, 370);
			this.txtMsj.Multiline = true;
			this.txtMsj.Name = "txtMsj";
			this.txtMsj.Size = new System.Drawing.Size(249, 102);
			this.txtMsj.TabIndex = 3;
			// 
			// cmdGuardaMsj
			// 
			this.cmdGuardaMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdGuardaMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardaMsj.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardaMsj.Image")));
			this.cmdGuardaMsj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardaMsj.Location = new System.Drawing.Point(267, 428);
			this.cmdGuardaMsj.Name = "cmdGuardaMsj";
			this.cmdGuardaMsj.Size = new System.Drawing.Size(115, 44);
			this.cmdGuardaMsj.TabIndex = 4;
			this.cmdGuardaMsj.Text = "Guardar Comentario";
			this.cmdGuardaMsj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardaMsj.UseVisualStyleBackColor = true;
			this.cmdGuardaMsj.Click += new System.EventHandler(this.CmdGuardaMsjClick);
			// 
			// txtMsjServicio
			// 
			this.txtMsjServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtMsjServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMsjServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMsjServicio.Location = new System.Drawing.Point(491, 399);
			this.txtMsjServicio.Multiline = true;
			this.txtMsjServicio.Name = "txtMsjServicio";
			this.txtMsjServicio.Size = new System.Drawing.Size(284, 73);
			this.txtMsjServicio.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 344);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mensaje general";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(491, 381);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mensaje por servicio";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(491, 338);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(298, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "En caso de cliente nuevo quien va facturado";
			// 
			// txtFactura
			// 
			this.txtFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFactura.Location = new System.Drawing.Point(491, 358);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(284, 20);
			this.txtFactura.TabIndex = 9;
			// 
			// FormValidaFact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 484);
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMsjServicio);
			this.Controls.Add(this.cmdGuardaMsj);
			this.Controls.Add(this.txtMsj);
			this.Controls.Add(this.cmdFacturar);
			this.Controls.Add(this.dgEspeciales);
			this.Name = "FormValidaFact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormValidaFact";
			this.Load += new System.EventHandler(this.FormValidaFactLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMsjServicio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMsj;
		private System.Windows.Forms.Button cmdGuardaMsj;
		private System.Windows.Forms.Button cmdFacturar;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridView dgEspeciales;
	}
}
