/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 06/09/2013
 * Time: 02:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	partial class FormPrincOperadores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincOperadores));
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.dgMsjes = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcOperadores = new System.Windows.Forms.TabControl();
			this.tpTurnoA = new System.Windows.Forms.TabPage();
			this.dgOperadores = new System.Windows.Forms.DataGridView();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpTurnoB = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.dgMsjes)).BeginInit();
			this.tcOperadores.SuspendLayout();
			this.tpTurnoA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdModificar
			// 
			this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdModificar.Image = ((System.Drawing.Image)(resources.GetObject("cmdModificar.Image")));
			this.cmdModificar.Location = new System.Drawing.Point(456, 553);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(37, 40);
			this.cmdModificar.TabIndex = 10;
			this.cmdModificar.UseVisualStyleBackColor = true;
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
			this.cmdEliminar.Location = new System.Drawing.Point(456, 609);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(37, 40);
			this.cmdEliminar.TabIndex = 9;
			this.cmdEliminar.UseVisualStyleBackColor = true;
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.Location = new System.Drawing.Point(456, 499);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(37, 40);
			this.cmdAgregar.TabIndex = 8;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			// 
			// dgMsjes
			// 
			this.dgMsjes.AllowUserToAddRows = false;
			this.dgMsjes.AllowUserToResizeRows = false;
			this.dgMsjes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgMsjes.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMsjes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgMsjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMsjes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.HORA,
									this.MSJ});
			this.dgMsjes.Location = new System.Drawing.Point(12, 499);
			this.dgMsjes.Name = "dgMsjes";
			this.dgMsjes.RowHeadersVisible = false;
			this.dgMsjes.Size = new System.Drawing.Size(438, 150);
			this.dgMsjes.TabIndex = 7;
			// 
			// ID
			// 
			this.ID.HeaderText = "USUARIO";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 120;
			// 
			// HORA
			// 
			this.HORA.HeaderText = "HORA";
			this.HORA.Name = "HORA";
			this.HORA.ReadOnly = true;
			this.HORA.Width = 60;
			// 
			// MSJ
			// 
			this.MSJ.HeaderText = "MENSAJE";
			this.MSJ.Name = "MSJ";
			this.MSJ.ReadOnly = true;
			this.MSJ.Width = 250;
			// 
			// tcOperadores
			// 
			this.tcOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tcOperadores.Controls.Add(this.tpTurnoA);
			this.tcOperadores.Controls.Add(this.tpTurnoB);
			this.tcOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcOperadores.Location = new System.Drawing.Point(12, 12);
			this.tcOperadores.Name = "tcOperadores";
			this.tcOperadores.SelectedIndex = 0;
			this.tcOperadores.Size = new System.Drawing.Size(481, 481);
			this.tcOperadores.TabIndex = 6;
			// 
			// tpTurnoA
			// 
			this.tpTurnoA.Controls.Add(this.dgOperadores);
			this.tpTurnoA.Location = new System.Drawing.Point(4, 22);
			this.tpTurnoA.Name = "tpTurnoA";
			this.tpTurnoA.Padding = new System.Windows.Forms.Padding(3);
			this.tpTurnoA.Size = new System.Drawing.Size(473, 455);
			this.tpTurnoA.TabIndex = 0;
			this.tpTurnoA.Text = "Turno 1";
			this.tpTurnoA.UseVisualStyleBackColor = true;
			// 
			// dgOperadores
			// 
			this.dgOperadores.AllowUserToAddRows = false;
			this.dgOperadores.AllowUserToResizeColumns = false;
			this.dgOperadores.AllowUserToResizeRows = false;
			this.dgOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOperadores.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.TIPO,
									this.ID_OP,
									this.Operador,
									this.ID_U,
									this.unidad,
									this.a,
									this.b,
									this.Cantidad,
									this.E,
									this.D,
									this.P,
									this.T,
									this.OTRO});
			this.dgOperadores.Location = new System.Drawing.Point(6, 6);
			this.dgOperadores.Name = "dgOperadores";
			this.dgOperadores.RowHeadersVisible = false;
			this.dgOperadores.Size = new System.Drawing.Size(461, 443);
			this.dgOperadores.TabIndex = 0;
			// 
			// TIPO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			this.TIPO.Width = 60;
			// 
			// ID_OP
			// 
			this.ID_OP.HeaderText = "ID_OP";
			this.ID_OP.Name = "ID_OP";
			this.ID_OP.ReadOnly = true;
			this.ID_OP.Visible = false;
			// 
			// Operador
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operador.DefaultCellStyle = dataGridViewCellStyle4;
			this.Operador.HeaderText = "OPERADOR";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			this.Operador.Width = 130;
			// 
			// ID_U
			// 
			this.ID_U.HeaderText = "ID_U";
			this.ID_U.Name = "ID_U";
			this.ID_U.ReadOnly = true;
			this.ID_U.Visible = false;
			// 
			// unidad
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unidad.DefaultCellStyle = dataGridViewCellStyle5;
			this.unidad.HeaderText = "UNIDAD";
			this.unidad.Name = "unidad";
			this.unidad.ReadOnly = true;
			this.unidad.Width = 60;
			// 
			// a
			// 
			this.a.HeaderText = "a";
			this.a.Name = "a";
			this.a.ReadOnly = true;
			this.a.Visible = false;
			// 
			// b
			// 
			this.b.HeaderText = "b";
			this.b.Name = "b";
			this.b.ReadOnly = true;
			this.b.Visible = false;
			// 
			// Cantidad
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
			this.Cantidad.HeaderText = "V";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 30;
			// 
			// E
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.E.DefaultCellStyle = dataGridViewCellStyle7;
			this.E.HeaderText = "E";
			this.E.Name = "E";
			this.E.ReadOnly = true;
			this.E.Width = 30;
			// 
			// D
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.D.DefaultCellStyle = dataGridViewCellStyle8;
			this.D.HeaderText = "D";
			this.D.Name = "D";
			this.D.ReadOnly = true;
			this.D.Width = 30;
			// 
			// P
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.P.DefaultCellStyle = dataGridViewCellStyle9;
			this.P.HeaderText = "P";
			this.P.Name = "P";
			this.P.ReadOnly = true;
			this.P.Width = 30;
			// 
			// T
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T.DefaultCellStyle = dataGridViewCellStyle10;
			this.T.HeaderText = "T";
			this.T.Name = "T";
			this.T.ReadOnly = true;
			this.T.Width = 30;
			// 
			// OTRO
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OTRO.DefaultCellStyle = dataGridViewCellStyle11;
			this.OTRO.HeaderText = "O";
			this.OTRO.Name = "OTRO";
			this.OTRO.ReadOnly = true;
			this.OTRO.Width = 30;
			// 
			// tpTurnoB
			// 
			this.tpTurnoB.Location = new System.Drawing.Point(4, 22);
			this.tpTurnoB.Name = "tpTurnoB";
			this.tpTurnoB.Padding = new System.Windows.Forms.Padding(3);
			this.tpTurnoB.Size = new System.Drawing.Size(473, 455);
			this.tpTurnoB.TabIndex = 1;
			this.tpTurnoB.Text = "Turno 2";
			this.tpTurnoB.UseVisualStyleBackColor = true;
			// 
			// FormPrincOperadores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 661);
			this.ControlBox = false;
			this.Controls.Add(this.cmdModificar);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.dgMsjes);
			this.Controls.Add(this.tcOperadores);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPrincOperadores";
			this.Text = "Operadores";
			this.Load += new System.EventHandler(this.FormPrincOperadoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgMsjes)).EndInit();
			this.tcOperadores.ResumeLayout(false);
			this.tpTurnoA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TabPage tpTurnoB;
		private System.Windows.Forms.DataGridViewTextBoxColumn OTRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn T;
		private System.Windows.Forms.DataGridViewTextBoxColumn P;
		private System.Windows.Forms.DataGridViewTextBoxColumn D;
		private System.Windows.Forms.DataGridViewTextBoxColumn E;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn b;
		private System.Windows.Forms.DataGridViewTextBoxColumn a;
		private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_U;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		public System.Windows.Forms.DataGridView dgOperadores;
		private System.Windows.Forms.TabPage tpTurnoA;
		private System.Windows.Forms.TabControl tcOperadores;
		private System.Windows.Forms.DataGridViewTextBoxColumn MSJ;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgMsjes;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdModificar;
	}
}
