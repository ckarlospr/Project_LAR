/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 04/07/2013
 * Time: 03:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormTerminoFact
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerminoFact));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdGuardr = new System.Windows.Forms.Button();
			this.txtDato = new System.Windows.Forms.TextBox();
			this.dgFacturas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO_FACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbVarias = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdGuardr
			// 
			this.cmdGuardr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardr.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardr.Image")));
			this.cmdGuardr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardr.Location = new System.Drawing.Point(246, 8);
			this.cmdGuardr.Name = "cmdGuardr";
			this.cmdGuardr.Size = new System.Drawing.Size(86, 27);
			this.cmdGuardr.TabIndex = 0;
			this.cmdGuardr.Text = "Guardar";
			this.cmdGuardr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardr.UseVisualStyleBackColor = true;
			this.cmdGuardr.Click += new System.EventHandler(this.CmdGuardrClick);
			// 
			// txtDato
			// 
			this.txtDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDato.Location = new System.Drawing.Point(132, 9);
			this.txtDato.Name = "txtDato";
			this.txtDato.Size = new System.Drawing.Size(108, 26);
			this.txtDato.TabIndex = 1;
			this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgFacturas
			// 
			this.dgFacturas.AllowUserToAddRows = false;
			this.dgFacturas.AllowUserToResizeRows = false;
			this.dgFacturas.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.OPERADOR,
									this.NUMERO,
									this.NUMERO_FACT});
			this.dgFacturas.Location = new System.Drawing.Point(12, 86);
			this.dgFacturas.Name = "dgFacturas";
			this.dgFacturas.RowHeadersVisible = false;
			this.dgFacturas.Size = new System.Drawing.Size(320, 140);
			this.dgFacturas.TabIndex = 3;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle2;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 140;
			// 
			// NUMERO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUMERO.DefaultCellStyle = dataGridViewCellStyle3;
			this.NUMERO.HeaderText = "NUMERO";
			this.NUMERO.Name = "NUMERO";
			this.NUMERO.ReadOnly = true;
			this.NUMERO.Width = 80;
			// 
			// NUMERO_FACT
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NUMERO_FACT.DefaultCellStyle = dataGridViewCellStyle4;
			this.NUMERO_FACT.HeaderText = "DATO";
			this.NUMERO_FACT.Name = "NUMERO_FACT";
			this.NUMERO_FACT.Width = 70;
			// 
			// cbVarias
			// 
			this.cbVarias.Enabled = false;
			this.cbVarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbVarias.Location = new System.Drawing.Point(98, 8);
			this.cbVarias.Name = "cbVarias";
			this.cbVarias.Size = new System.Drawing.Size(129, 19);
			this.cbVarias.TabIndex = 4;
			this.cbVarias.Text = "Distintas facturas";
			this.cbVarias.UseVisualStyleBackColor = true;
			this.cbVarias.CheckedChanged += new System.EventHandler(this.CbVariasCheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Dato de factura:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbVarias);
			this.groupBox1.Location = new System.Drawing.Point(12, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(320, 30);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// FormTerminoFact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 79);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgFacturas);
			this.Controls.Add(this.txtDato);
			this.Controls.Add(this.cmdGuardr);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(359, 117);
			this.Name = "FormTerminoFact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos";
			this.Load += new System.EventHandler(this.FormTerminoFactLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox cbVarias;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridView dgFacturas;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_FACT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.TextBox txtDato;
		private System.Windows.Forms.Button cmdGuardr;
	}
}
