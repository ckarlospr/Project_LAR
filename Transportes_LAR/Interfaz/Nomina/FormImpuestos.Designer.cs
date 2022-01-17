/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 11/12/2012
 * Time: 07:55 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina
{
	partial class FormImpuestos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpuestos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataImpuestos = new System.Windows.Forms.DataGridView();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).BeginInit();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataImpuestos
			// 
			this.dataImpuestos.AllowUserToAddRows = false;
			this.dataImpuestos.AllowUserToResizeRows = false;
			this.dataImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataImpuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataImpuestos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Alias});
			this.dataImpuestos.Location = new System.Drawing.Point(12, 71);
			this.dataImpuestos.Name = "dataImpuestos";
			this.dataImpuestos.RowHeadersVisible = false;
			this.dataImpuestos.Size = new System.Drawing.Size(1016, 498);
			this.dataImpuestos.TabIndex = 4;
			this.dataImpuestos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataImpuestosColumnHeaderMouseClick);
			this.dataImpuestos.Enter += new System.EventHandler(this.DataImpuestosEnter);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
			this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdGuardar.Location = new System.Drawing.Point(974, 12);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(54, 48);
			this.cmdGuardar.TabIndex = 5;
			this.toolTip.SetToolTip(this.cmdGuardar, "Guardar");
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.txtAlias);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(12, 12);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(253, 45);
			this.groupBox18.TabIndex = 151;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Busqueda del Operador por Nick";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.Location = new System.Drawing.Point(6, 16);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(237, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias.DefaultCellStyle = dataGridViewCellStyle2;
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			this.Alias.Width = 59;
			// 
			// FormImpuestos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1040, 581);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.dataImpuestos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormImpuestos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Historial Quincenal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImpuestosFormClosing);
			this.Load += new System.EventHandler(this.FormImpuestosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.ToolTip toolTip;
		public System.Windows.Forms.DataGridView dataImpuestos;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
	}
}
