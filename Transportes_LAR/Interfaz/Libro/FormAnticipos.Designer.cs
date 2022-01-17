/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 12/07/2013
 * Time: 09:01 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormAnticipos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnticipos));
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtRecibo = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.Location = new System.Drawing.Point(202, 171);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(40, 33);
			this.cmdGuardar.TabIndex = 0;
			this.toolTip1.SetToolTip(this.cmdGuardar, "Guardar");
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(146, 12);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(83, 21);
			this.txtCantidad.TabIndex = 1;
			this.txtCantidad.Text = "0";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			this.txtCantidad.Leave += new System.EventHandler(this.TxtCantidadLeave);
			// 
			// txtRecibo
			// 
			this.txtRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecibo.Location = new System.Drawing.Point(89, 44);
			this.txtRecibo.Name = "txtRecibo";
			this.txtRecibo.Size = new System.Drawing.Size(128, 21);
			this.txtRecibo.TabIndex = 2;
			this.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecha.Location = new System.Drawing.Point(22, 13);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(96, 20);
			this.dtpFecha.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(129, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "$";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.label1, "Cantidad del anticipo");
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Checked = true;
			this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEfectivo.Location = new System.Drawing.Point(75, 17);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(73, 21);
			this.rbEfectivo.TabIndex = 5;
			this.rbEfectivo.TabStop = true;
			this.rbEfectivo.Text = "Efectivo";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// rbDeposito
			// 
			this.rbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDeposito.Location = new System.Drawing.Point(75, 71);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(81, 21);
			this.rbDeposito.TabIndex = 6;
			this.rbDeposito.Text = "Deposito";
			this.rbDeposito.UseVisualStyleBackColor = true;
			this.rbDeposito.CheckedChanged += new System.EventHandler(this.RbDepositoCheckedChanged);
			// 
			// txtReferencia
			// 
			this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferencia.Enabled = false;
			this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia.Location = new System.Drawing.Point(89, 98);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(128, 21);
			this.txtReferencia.TabIndex = 7;
			this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Referencia:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "# Recibo:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtReferencia);
			this.groupBox1.Controls.Add(this.rbDeposito);
			this.groupBox1.Controls.Add(this.rbEfectivo);
			this.groupBox1.Controls.Add(this.txtRecibo);
			this.groupBox1.Location = new System.Drawing.Point(12, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 131);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// FormAnticipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 216);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.cmdGuardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAnticipos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Anticipos";
			this.Load += new System.EventHandler(this.FormAnticiposLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtReferencia;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtRecibo;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdGuardar;
	}
}
