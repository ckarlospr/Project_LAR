/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 08/07/2013
 * Time: 02:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Cliente
{
	partial class FormOrdenEmpresas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbMa = new System.Windows.Forms.CheckBox();
			this.cbMe = new System.Windows.Forms.CheckBox();
			this.cbVe = new System.Windows.Forms.CheckBox();
			this.cbNo = new System.Windows.Forms.CheckBox();
			this.cbLunes = new System.Windows.Forms.CheckBox();
			this.cbMartes = new System.Windows.Forms.CheckBox();
			this.cbJueves = new System.Windows.Forms.CheckBox();
			this.cbMiercoles = new System.Windows.Forms.CheckBox();
			this.cbSabado = new System.Windows.Forms.CheckBox();
			this.cbViernes = new System.Windows.Forms.CheckBox();
			this.cbDomingo = new System.Windows.Forms.CheckBox();
			this.gbDias = new System.Windows.Forms.GroupBox();
			this.gbTurnos = new System.Windows.Forms.GroupBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.gbDias.SuspendLayout();
			this.gbTurnos.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.EMPRESA});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgDatos.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgDatos.Location = new System.Drawing.Point(12, 12);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.Size = new System.Drawing.Size(380, 264);
			this.dgDatos.TabIndex = 0;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			this.dgDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgDatosKeyUp);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// EMPRESA
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EMPRESA.DefaultCellStyle = dataGridViewCellStyle2;
			this.EMPRESA.HeaderText = "EMPRESA";
			this.EMPRESA.Name = "EMPRESA";
			this.EMPRESA.ReadOnly = true;
			this.EMPRESA.Width = 350;
			// 
			// cbMa
			// 
			this.cbMa.Location = new System.Drawing.Point(24, 28);
			this.cbMa.Name = "cbMa";
			this.cbMa.Size = new System.Drawing.Size(114, 24);
			this.cbMa.TabIndex = 1;
			this.cbMa.Text = "Mañana";
			this.cbMa.UseVisualStyleBackColor = true;
			// 
			// cbMe
			// 
			this.cbMe.Location = new System.Drawing.Point(24, 58);
			this.cbMe.Name = "cbMe";
			this.cbMe.Size = new System.Drawing.Size(114, 24);
			this.cbMe.TabIndex = 2;
			this.cbMe.Text = "Medio día";
			this.cbMe.UseVisualStyleBackColor = true;
			// 
			// cbVe
			// 
			this.cbVe.Location = new System.Drawing.Point(24, 88);
			this.cbVe.Name = "cbVe";
			this.cbVe.Size = new System.Drawing.Size(114, 24);
			this.cbVe.TabIndex = 3;
			this.cbVe.Text = "Vespertino";
			this.cbVe.UseVisualStyleBackColor = true;
			// 
			// cbNo
			// 
			this.cbNo.Location = new System.Drawing.Point(24, 118);
			this.cbNo.Name = "cbNo";
			this.cbNo.Size = new System.Drawing.Size(114, 24);
			this.cbNo.TabIndex = 4;
			this.cbNo.Text = "Nocturno";
			this.cbNo.UseVisualStyleBackColor = true;
			// 
			// cbLunes
			// 
			this.cbLunes.Location = new System.Drawing.Point(23, 30);
			this.cbLunes.Name = "cbLunes";
			this.cbLunes.Size = new System.Drawing.Size(99, 24);
			this.cbLunes.TabIndex = 5;
			this.cbLunes.Text = "Lunes";
			this.cbLunes.UseVisualStyleBackColor = true;
			// 
			// cbMartes
			// 
			this.cbMartes.Location = new System.Drawing.Point(23, 60);
			this.cbMartes.Name = "cbMartes";
			this.cbMartes.Size = new System.Drawing.Size(99, 24);
			this.cbMartes.TabIndex = 6;
			this.cbMartes.Text = "Martes";
			this.cbMartes.UseVisualStyleBackColor = true;
			// 
			// cbJueves
			// 
			this.cbJueves.Location = new System.Drawing.Point(23, 120);
			this.cbJueves.Name = "cbJueves";
			this.cbJueves.Size = new System.Drawing.Size(99, 24);
			this.cbJueves.TabIndex = 8;
			this.cbJueves.Text = "Jueves";
			this.cbJueves.UseVisualStyleBackColor = true;
			// 
			// cbMiercoles
			// 
			this.cbMiercoles.Location = new System.Drawing.Point(23, 90);
			this.cbMiercoles.Name = "cbMiercoles";
			this.cbMiercoles.Size = new System.Drawing.Size(99, 24);
			this.cbMiercoles.TabIndex = 7;
			this.cbMiercoles.Text = "Miercoles";
			this.cbMiercoles.UseVisualStyleBackColor = true;
			// 
			// cbSabado
			// 
			this.cbSabado.Location = new System.Drawing.Point(23, 180);
			this.cbSabado.Name = "cbSabado";
			this.cbSabado.Size = new System.Drawing.Size(99, 24);
			this.cbSabado.TabIndex = 10;
			this.cbSabado.Text = "Sabado";
			this.cbSabado.UseVisualStyleBackColor = true;
			// 
			// cbViernes
			// 
			this.cbViernes.Location = new System.Drawing.Point(23, 150);
			this.cbViernes.Name = "cbViernes";
			this.cbViernes.Size = new System.Drawing.Size(99, 24);
			this.cbViernes.TabIndex = 9;
			this.cbViernes.Text = "Viernes";
			this.cbViernes.UseVisualStyleBackColor = true;
			// 
			// cbDomingo
			// 
			this.cbDomingo.Location = new System.Drawing.Point(23, 210);
			this.cbDomingo.Name = "cbDomingo";
			this.cbDomingo.Size = new System.Drawing.Size(99, 24);
			this.cbDomingo.TabIndex = 11;
			this.cbDomingo.Text = "Domingo";
			this.cbDomingo.UseVisualStyleBackColor = true;
			// 
			// gbDias
			// 
			this.gbDias.Controls.Add(this.cbDomingo);
			this.gbDias.Controls.Add(this.cbSabado);
			this.gbDias.Controls.Add(this.cbViernes);
			this.gbDias.Controls.Add(this.cbJueves);
			this.gbDias.Controls.Add(this.cbMiercoles);
			this.gbDias.Controls.Add(this.cbMartes);
			this.gbDias.Controls.Add(this.cbLunes);
			this.gbDias.Enabled = false;
			this.gbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDias.Location = new System.Drawing.Point(410, 25);
			this.gbDias.Name = "gbDias";
			this.gbDias.Size = new System.Drawing.Size(136, 251);
			this.gbDias.TabIndex = 12;
			this.gbDias.TabStop = false;
			this.gbDias.Text = "Dias";
			// 
			// gbTurnos
			// 
			this.gbTurnos.Controls.Add(this.cbNo);
			this.gbTurnos.Controls.Add(this.cbVe);
			this.gbTurnos.Controls.Add(this.cbMe);
			this.gbTurnos.Controls.Add(this.cbMa);
			this.gbTurnos.Enabled = false;
			this.gbTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTurnos.Location = new System.Drawing.Point(562, 25);
			this.gbTurnos.Name = "gbTurnos";
			this.gbTurnos.Size = new System.Drawing.Size(144, 159);
			this.gbTurnos.TabIndex = 13;
			this.gbTurnos.TabStop = false;
			this.gbTurnos.Text = "Turnos";
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Enabled = false;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(608, 227);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(98, 49);
			this.cmdGuardar.TabIndex = 14;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// FormOrdenEmpresas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 293);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.gbTurnos);
			this.Controls.Add(this.gbDias);
			this.Controls.Add(this.dgDatos);
			this.MinimumSize = new System.Drawing.Size(740, 331);
			this.Name = "FormOrdenEmpresas";
			this.Text = "Organización";
			this.Load += new System.EventHandler(this.FormOrdenEmpresasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.gbDias.ResumeLayout(false);
			this.gbTurnos.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.GroupBox gbTurnos;
		private System.Windows.Forms.GroupBox gbDias;
		private System.Windows.Forms.CheckBox cbDomingo;
		private System.Windows.Forms.CheckBox cbViernes;
		private System.Windows.Forms.CheckBox cbSabado;
		private System.Windows.Forms.CheckBox cbMiercoles;
		private System.Windows.Forms.CheckBox cbJueves;
		private System.Windows.Forms.CheckBox cbMartes;
		private System.Windows.Forms.CheckBox cbLunes;
		private System.Windows.Forms.CheckBox cbNo;
		private System.Windows.Forms.CheckBox cbVe;
		private System.Windows.Forms.CheckBox cbMe;
		private System.Windows.Forms.CheckBox cbMa;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgDatos;
	}
}
