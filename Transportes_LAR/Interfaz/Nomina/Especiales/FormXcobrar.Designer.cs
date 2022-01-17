/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 05/08/2013
 * Time: 01:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormXcobrar
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
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.id_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_re,
									this.Numero,
									this.FECHA,
									this.ID,
									this.COBRO,
									this.TELEFONO,
									this.SALDO,
									this.ALIAS,
									this.Unidad,
									this.DESTINO});
			this.dgDatos.Location = new System.Drawing.Point(12, 45);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.Size = new System.Drawing.Size(829, 346);
			this.dgDatos.TabIndex = 0;
			// 
			// id_re
			// 
			this.id_re.HeaderText = "ID";
			this.id_re.Name = "id_re";
			this.id_re.ReadOnly = true;
			this.id_re.Visible = false;
			this.id_re.Width = 80;
			// 
			// Numero
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Numero.DefaultCellStyle = dataGridViewCellStyle2;
			this.Numero.HeaderText = "#";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			this.Numero.Width = 30;
			// 
			// FECHA
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// ID
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.DefaultCellStyle = dataGridViewCellStyle4;
			this.ID.HeaderText = "IDENT.";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 70;
			// 
			// COBRO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COBRO.DefaultCellStyle = dataGridViewCellStyle5;
			this.COBRO.HeaderText = "COBRÓ";
			this.COBRO.Name = "COBRO";
			this.COBRO.ReadOnly = true;
			// 
			// TELEFONO
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle6;
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			// 
			// SALDO
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle7;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			this.SALDO.Width = 80;
			// 
			// ALIAS
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ALIAS.DefaultCellStyle = dataGridViewCellStyle8;
			this.ALIAS.HeaderText = "REALIZÓ";
			this.ALIAS.Name = "ALIAS";
			this.ALIAS.ReadOnly = true;
			// 
			// Unidad
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Unidad.DefaultCellStyle = dataGridViewCellStyle9;
			this.Unidad.HeaderText = "UNIDAD";
			this.Unidad.Name = "Unidad";
			this.Unidad.ReadOnly = true;
			this.Unidad.Width = 70;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle10;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			this.DESTINO.Width = 150;
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(683, 12);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 1;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(577, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "TOTAL:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormXcobrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 403);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.dgDatos);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormXcobrar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Servicios por cobrar";
			this.Load += new System.EventHandler(this.FormXcobrarLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ALIAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn COBRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_re;
		private System.Windows.Forms.DataGridView dgDatos;
	}
}
