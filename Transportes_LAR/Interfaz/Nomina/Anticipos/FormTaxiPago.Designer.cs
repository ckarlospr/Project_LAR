/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 31/10/2013
 * Time: 01:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	partial class FormTaxiPago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaxiPago));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantPago = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnDescontar = new System.Windows.Forms.Button();
			this.dataConteoDesc = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAnticipos = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCargoOperador = new System.Windows.Forms.TextBox();
			this.groupBox19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataConteoDesc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataAnticipos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox19
			// 
			this.groupBox19.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox19.BackColor = System.Drawing.Color.White;
			this.groupBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox19.Controls.Add(this.label2);
			this.groupBox19.Controls.Add(this.txtCantPago);
			this.groupBox19.Controls.Add(this.btnCancelar);
			this.groupBox19.Controls.Add(this.btnDescontar);
			this.groupBox19.Controls.Add(this.dataConteoDesc);
			this.groupBox19.Controls.Add(this.dataAnticipos);
			this.groupBox19.Controls.Add(this.label1);
			this.groupBox19.Controls.Add(this.txtCargoOperador);
			this.groupBox19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox19.Location = new System.Drawing.Point(12, 12);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(227, 194);
			this.groupBox19.TabIndex = 198;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Descuento";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 15);
			this.label2.TabIndex = 201;
			this.label2.Text = "Desc. Quincenal";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCantPago
			// 
			this.txtCantPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantPago.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantPago.Location = new System.Drawing.Point(112, 44);
			this.txtCantPago.Name = "txtCantPago";
			this.txtCantPago.Size = new System.Drawing.Size(108, 20);
			this.txtCantPago.TabIndex = 200;
			this.txtCantPago.Text = "0.00";
			this.txtCantPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantPago.TextChanged += new System.EventHandler(this.TxtCantPagoTextChanged);
			this.txtCantPago.Enter += new System.EventHandler(this.TxtCantPagoEnter);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(147, 129);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(73, 53);
			this.btnCancelar.TabIndex = 199;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnDescontar
			// 
			this.btnDescontar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDescontar.BackColor = System.Drawing.Color.Transparent;
			this.btnDescontar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDescontar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDescontar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDescontar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescontar.Image")));
			this.btnDescontar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDescontar.Location = new System.Drawing.Point(148, 70);
			this.btnDescontar.Name = "btnDescontar";
			this.btnDescontar.Size = new System.Drawing.Size(73, 53);
			this.btnDescontar.TabIndex = 12;
			this.btnDescontar.Text = "Descontar";
			this.btnDescontar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDescontar.UseVisualStyleBackColor = false;
			this.btnDescontar.Click += new System.EventHandler(this.BtnDescontarClick);
			// 
			// dataConteoDesc
			// 
			this.dataConteoDesc.AllowUserToAddRows = false;
			this.dataConteoDesc.AllowUserToResizeColumns = false;
			this.dataConteoDesc.AllowUserToResizeRows = false;
			this.dataConteoDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataConteoDesc.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataConteoDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataConteoDesc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataConteoDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataConteoDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn48,
									this.dataGridViewTextBoxColumn49});
			this.dataConteoDesc.Location = new System.Drawing.Point(6, 70);
			this.dataConteoDesc.Name = "dataConteoDesc";
			this.dataConteoDesc.RowHeadersVisible = false;
			this.dataConteoDesc.Size = new System.Drawing.Size(135, 112);
			this.dataConteoDesc.TabIndex = 188;
			// 
			// dataGridViewTextBoxColumn48
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn48.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn48.HeaderText = "No.";
			this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn48.ReadOnly = true;
			this.dataGridViewTextBoxColumn48.Width = 30;
			// 
			// dataGridViewTextBoxColumn49
			// 
			this.dataGridViewTextBoxColumn49.DataPropertyName = "Destino";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.dataGridViewTextBoxColumn49.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn49.HeaderText = "Descuento";
			this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn49.ReadOnly = true;
			this.dataGridViewTextBoxColumn49.Width = 80;
			// 
			// dataAnticipos
			// 
			this.dataAnticipos.AllowUserToAddRows = false;
			this.dataAnticipos.AllowUserToResizeColumns = false;
			this.dataAnticipos.AllowUserToResizeRows = false;
			this.dataAnticipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataAnticipos.BackgroundColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataAnticipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataAnticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataAnticipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn17,
									this.dataGridViewTextBoxColumn18,
									this.dataGridViewTextBoxColumn21,
									this.dataGridViewTextBoxColumn22,
									this.dataGridViewTextBoxColumn23});
			this.dataAnticipos.Location = new System.Drawing.Point(217, 0);
			this.dataAnticipos.Name = "dataAnticipos";
			this.dataAnticipos.RowHeadersVisible = false;
			this.dataAnticipos.Size = new System.Drawing.Size(10, 10);
			this.dataAnticipos.TabIndex = 198;
			this.dataAnticipos.Visible = false;
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "ID_RE";
			this.dataGridViewTextBoxColumn17.HeaderText = "ID";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			this.dataGridViewTextBoxColumn17.Visible = false;
			this.dataGridViewTextBoxColumn17.Width = 25;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "ID_descuento";
			this.dataGridViewTextBoxColumn18.HeaderText = "ID_Desc";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn18.Visible = false;
			this.dataGridViewTextBoxColumn18.Width = 25;
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.DataPropertyName = "Fecha";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn21.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			this.dataGridViewTextBoxColumn21.Width = 75;
			// 
			// dataGridViewTextBoxColumn22
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn22.HeaderText = "Nomclatura";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.DataPropertyName = "Destino";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = null;
			this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn23.HeaderText = "Descuento";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 20);
			this.label1.TabIndex = 192;
			this.label1.Text = "Cargo Operador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCargoOperador
			// 
			this.txtCargoOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCargoOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCargoOperador.Location = new System.Drawing.Point(112, 18);
			this.txtCargoOperador.Name = "txtCargoOperador";
			this.txtCargoOperador.Size = new System.Drawing.Size(108, 20);
			this.txtCargoOperador.TabIndex = 11;
			this.txtCargoOperador.Text = "0.00";
			this.txtCargoOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCargoOperador.TextChanged += new System.EventHandler(this.TxtCargoOperadorTextChanged);
			this.txtCargoOperador.Enter += new System.EventHandler(this.TxtCargoOperadorEnter);
			// 
			// FormTaxiPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(251, 216);
			this.Controls.Add(this.groupBox19);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTaxiPago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Desc. Taxi";
			this.Load += new System.EventHandler(this.FormTaxiPagoLoad);
			this.groupBox19.ResumeLayout(false);
			this.groupBox19.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataConteoDesc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataAnticipos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dataConteoDesc;
		private System.Windows.Forms.TextBox txtCantPago;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtCargoOperador;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridView dataAnticipos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
		private System.Windows.Forms.Button btnDescontar;
		private System.Windows.Forms.GroupBox groupBox19;
	}
}
