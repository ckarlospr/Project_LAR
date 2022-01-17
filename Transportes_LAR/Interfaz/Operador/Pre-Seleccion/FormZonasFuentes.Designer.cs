/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 08/08/2017
 * Time: 11:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormZonasFuentes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZonasFuentes));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtZonas = new System.Windows.Forms.TextBox();
			this.btnAddZona = new System.Windows.Forms.Button();
			this.btnAddFuente = new System.Windows.Forms.Button();
			this.txtFuente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dgZonas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dgFuentes = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estatus2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E2 = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgZonas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFuentes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtZonas
			// 
			this.txtZonas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtZonas.Location = new System.Drawing.Point(7, 418);
			this.txtZonas.MaxLength = 25;
			this.txtZonas.Name = "txtZonas";
			this.txtZonas.Size = new System.Drawing.Size(155, 20);
			this.txtZonas.TabIndex = 4;
			// 
			// btnAddZona
			// 
			this.btnAddZona.Image = ((System.Drawing.Image)(resources.GetObject("btnAddZona.Image")));
			this.btnAddZona.Location = new System.Drawing.Point(164, 415);
			this.btnAddZona.Name = "btnAddZona";
			this.btnAddZona.Size = new System.Drawing.Size(25, 25);
			this.btnAddZona.TabIndex = 5;
			this.btnAddZona.UseVisualStyleBackColor = true;
			this.btnAddZona.Click += new System.EventHandler(this.BtnAddZonaClick);
			// 
			// btnAddFuente
			// 
			this.btnAddFuente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFuente.Image")));
			this.btnAddFuente.Location = new System.Drawing.Point(363, 416);
			this.btnAddFuente.Name = "btnAddFuente";
			this.btnAddFuente.Size = new System.Drawing.Size(25, 25);
			this.btnAddFuente.TabIndex = 10;
			this.btnAddFuente.UseVisualStyleBackColor = true;
			this.btnAddFuente.Click += new System.EventHandler(this.BtnAddFuenteClick);
			// 
			// txtFuente
			// 
			this.txtFuente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFuente.Location = new System.Drawing.Point(207, 419);
			this.txtFuente.MaxLength = 25;
			this.txtFuente.Name = "txtFuente";
			this.txtFuente.Size = new System.Drawing.Size(155, 20);
			this.txtFuente.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(194, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(5, 412);
			this.label4.TabIndex = 7;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 26);
			this.label1.TabIndex = 1;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Zonas";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(207, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fuentes";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 444);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(381, 5);
			this.label5.TabIndex = 12;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnGuardar
			// 
			this.btnGuardar.AutoSize = true;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(90, 453);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(77, 31);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "Aceptar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(227, 453);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(77, 31);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// dgZonas
			// 
			this.dgZonas.AllowUserToAddRows = false;
			this.dgZonas.AllowUserToDeleteRows = false;
			this.dgZonas.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgZonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgZonas.ColumnHeadersVisible = false;
			this.dgZonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Descripcion,
									this.Estatus,
									this.E1});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgZonas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgZonas.Location = new System.Drawing.Point(7, 34);
			this.dgZonas.Margin = new System.Windows.Forms.Padding(2);
			this.dgZonas.MultiSelect = false;
			this.dgZonas.Name = "dgZonas";
			this.dgZonas.ReadOnly = true;
			this.dgZonas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgZonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgZonas.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgZonas.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgZonas.RowTemplate.Height = 24;
			this.dgZonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgZonas.Size = new System.Drawing.Size(182, 379);
			this.dgZonas.TabIndex = 1;
			this.dgZonas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgZonasCellContentDoubleClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descripcion.HeaderText = "Nombre";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Estatus
			// 
			this.Estatus.HeaderText = "Column1";
			this.Estatus.Name = "Estatus";
			this.Estatus.ReadOnly = true;
			this.Estatus.Visible = false;
			// 
			// E1
			// 
			this.E1.HeaderText = "#";
			this.E1.Name = "E1";
			this.E1.ReadOnly = true;
			this.E1.Width = 25;
			// 
			// dgFuentes
			// 
			this.dgFuentes.AllowUserToAddRows = false;
			this.dgFuentes.AllowUserToDeleteRows = false;
			this.dgFuentes.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFuentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFuentes.ColumnHeadersVisible = false;
			this.dgFuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.Estatus2,
									this.E2});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgFuentes.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgFuentes.Location = new System.Drawing.Point(206, 34);
			this.dgFuentes.Margin = new System.Windows.Forms.Padding(2);
			this.dgFuentes.MultiSelect = false;
			this.dgFuentes.Name = "dgFuentes";
			this.dgFuentes.ReadOnly = true;
			this.dgFuentes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgFuentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgFuentes.RowHeadersVisible = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgFuentes.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgFuentes.RowTemplate.Height = 24;
			this.dgFuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgFuentes.Size = new System.Drawing.Size(182, 379);
			this.dgFuentes.TabIndex = 8;
			this.dgFuentes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgFuentesCellContentDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// Estatus2
			// 
			this.Estatus2.HeaderText = "Estatus";
			this.Estatus2.Name = "Estatus2";
			this.Estatus2.ReadOnly = true;
			this.Estatus2.Visible = false;
			// 
			// E2
			// 
			this.E2.HeaderText = "#";
			this.E2.Name = "E2";
			this.E2.ReadOnly = true;
			this.E2.Width = 25;
			// 
			// FormZonasFuentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 487);
			this.Controls.Add(this.dgFuentes);
			this.Controls.Add(this.dgZonas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAddFuente);
			this.Controls.Add(this.txtFuente);
			this.Controls.Add(this.btnAddZona);
			this.Controls.Add(this.txtZonas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormZonasFuentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zonas y Fuentes";
			this.Load += new System.EventHandler(this.FormZonasFuentesLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormZonasFuentesKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgZonas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFuentes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewImageColumn E2;
		private System.Windows.Forms.DataGridViewImageColumn E1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estatus2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		public System.Windows.Forms.DataGridView dgZonas;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dgFuentes;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFuente;
		private System.Windows.Forms.Button btnAddFuente;
		private System.Windows.Forms.Button btnAddZona;
		private System.Windows.Forms.TextBox txtZonas;
	}
}
