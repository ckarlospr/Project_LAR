namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	partial class FormBonificacion
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBonificacion));
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDinero = new System.Windows.Forms.TextBox();
			this.txtTotalBono = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ckDinero = new System.Windows.Forms.CheckBox();
			this.ckPorcentaje = new System.Windows.Forms.CheckBox();
			this.txtPorcentaje = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
			this.cmdNuevo.Location = new System.Drawing.Point(234, 155);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(35, 34);
			this.cmdNuevo.TabIndex = 3;
			this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 27);
			this.label1.TabIndex = 4;
			this.label1.Text = "Bonificación Bono";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDinero
			// 
			this.txtDinero.Enabled = false;
			this.txtDinero.Location = new System.Drawing.Point(159, 63);
			this.txtDinero.Name = "txtDinero";
			this.txtDinero.Size = new System.Drawing.Size(92, 20);
			this.txtDinero.TabIndex = 13;
			this.txtDinero.Text = "0.00";
			this.txtDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDinero.TextChanged += new System.EventHandler(this.TxtDineroTextChanged);
			// 
			// txtTotalBono
			// 
			this.txtTotalBono.Enabled = false;
			this.txtTotalBono.Location = new System.Drawing.Point(159, 12);
			this.txtTotalBono.Name = "txtTotalBono";
			this.txtTotalBono.Size = new System.Drawing.Size(92, 20);
			this.txtTotalBono.TabIndex = 14;
			this.txtTotalBono.Text = "0";
			this.txtTotalBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtResultado);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.ckDinero);
			this.groupBox1.Controls.Add(this.txtDinero);
			this.groupBox1.Controls.Add(this.ckPorcentaje);
			this.groupBox1.Controls.Add(this.txtPorcentaje);
			this.groupBox1.Controls.Add(this.txtTotalBono);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 117);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// txtResultado
			// 
			this.txtResultado.Enabled = false;
			this.txtResultado.Location = new System.Drawing.Point(159, 90);
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(92, 20);
			this.txtResultado.TabIndex = 20;
			this.txtResultado.Text = "0.00";
			this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(102, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Resultado";
			// 
			// ckDinero
			// 
			this.ckDinero.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckDinero.Location = new System.Drawing.Point(73, 63);
			this.ckDinero.Name = "ckDinero";
			this.ckDinero.Size = new System.Drawing.Size(86, 20);
			this.ckDinero.TabIndex = 16;
			this.ckDinero.Text = "Dinero $";
			this.ckDinero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ckDinero.UseVisualStyleBackColor = true;
			this.ckDinero.CheckedChanged += new System.EventHandler(this.CkDineroCheckedChanged);
			// 
			// ckPorcentaje
			// 
			this.ckPorcentaje.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckPorcentaje.Location = new System.Drawing.Point(73, 37);
			this.ckPorcentaje.Name = "ckPorcentaje";
			this.ckPorcentaje.Size = new System.Drawing.Size(86, 22);
			this.ckPorcentaje.TabIndex = 17;
			this.ckPorcentaje.Text = "Porcentaje %";
			this.ckPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ckPorcentaje.UseVisualStyleBackColor = true;
			this.ckPorcentaje.CheckedChanged += new System.EventHandler(this.CkPorcentajeCheckedChanged);
			// 
			// txtPorcentaje
			// 
			this.txtPorcentaje.Enabled = false;
			this.txtPorcentaje.Location = new System.Drawing.Point(159, 37);
			this.txtPorcentaje.Name = "txtPorcentaje";
			this.txtPorcentaje.Size = new System.Drawing.Size(92, 20);
			this.txtPorcentaje.TabIndex = 19;
			this.txtPorcentaje.Text = "100";
			this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPorcentaje.TextChanged += new System.EventHandler(this.TxtPorcentajeTextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 40);
			this.label3.TabIndex = 18;
			this.label3.Text = "Total Acumulado por el Bono Completo $";
			// 
			// FormBonificacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(281, 193);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdNuevo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(291, 225);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(150, 225);
			this.Name = "FormBonificacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Bonificación";
			this.Load += new System.EventHandler(this.FormBonificacionLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtResultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPorcentaje;
		private System.Windows.Forms.CheckBox ckPorcentaje;
		private System.Windows.Forms.CheckBox ckDinero;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTotalBono;
		private System.Windows.Forms.TextBox txtDinero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdNuevo;
	}
}