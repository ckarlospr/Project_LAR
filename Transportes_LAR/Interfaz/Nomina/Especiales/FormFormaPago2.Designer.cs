/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 14/09/2015
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormFormaPago2
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
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.gbTipo = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.lblID = new System.Windows.Forms.Label();
			this.gbTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpFecha
			// 
			this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(12, 122);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(122, 21);
			this.dtpFecha.TabIndex = 9;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(161, 124);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
			this.cmdGuardar.TabIndex = 8;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// gbTipo
			// 
			this.gbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbTipo.Controls.Add(this.label1);
			this.gbTipo.Controls.Add(this.txtNumero);
			this.gbTipo.Controls.Add(this.rbDeposito);
			this.gbTipo.Controls.Add(this.rbEfectivo);
			this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTipo.Location = new System.Drawing.Point(12, 27);
			this.gbTipo.Name = "gbTipo";
			this.gbTipo.Size = new System.Drawing.Size(241, 83);
			this.gbTipo.TabIndex = 7;
			this.gbTipo.TabStop = false;
			this.gbTipo.Text = "Tipo";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Depositado a:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Location = new System.Drawing.Point(124, 49);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(100, 22);
			this.txtNumero.TabIndex = 2;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rbDeposito
			// 
			this.rbDeposito.Checked = true;
			this.rbDeposito.Location = new System.Drawing.Point(114, 18);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(104, 24);
			this.rbDeposito.TabIndex = 1;
			this.rbDeposito.TabStop = true;
			this.rbDeposito.Text = "DEPOSITO";
			this.rbDeposito.UseVisualStyleBackColor = true;
			this.rbDeposito.CheckedChanged += new System.EventHandler(this.RbDepositoCheckedChanged);
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Location = new System.Drawing.Point(6, 18);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(104, 24);
			this.rbEfectivo.TabIndex = 0;
			this.rbEfectivo.Text = "EFECTIVO";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// lblID
			// 
			this.lblID.Location = new System.Drawing.Point(13, 6);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(234, 23);
			this.lblID.TabIndex = 10;
			this.lblID.Text = "label2";
			// 
			// FormFormaPago2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 157);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.gbTipo);
			this.Name = "FormFormaPago2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pago";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFormaPago2FormClosing);
			this.Load += new System.EventHandler(this.FormFormaPago2Load);
			this.gbTipo.ResumeLayout(false);
			this.gbTipo.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbTipo;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
	}
}
