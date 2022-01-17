/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 15/11/2012
 * Time: 8:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormNuevaRuta
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
			this.cmdApoyo = new System.Windows.Forms.Button();
			this.cmdNueva = new System.Windows.Forms.Button();
			this.lblPregunta = new System.Windows.Forms.Label();
			this.cmdTemp = new System.Windows.Forms.Button();
			this.cmdExtraExt = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdApoyo
			// 
			this.cmdApoyo.Location = new System.Drawing.Point(51, 26);
			this.cmdApoyo.Name = "cmdApoyo";
			this.cmdApoyo.Size = new System.Drawing.Size(115, 42);
			this.cmdApoyo.TabIndex = 0;
			this.cmdApoyo.Text = "Extra ó Domiciliada";
			this.toolTip1.SetToolTip(this.cmdApoyo, "Ruta sin ruta fija");
			this.cmdApoyo.UseVisualStyleBackColor = true;
			this.cmdApoyo.Click += new System.EventHandler(this.CmdApoyoClick);
			// 
			// cmdNueva
			// 
			this.cmdNueva.Location = new System.Drawing.Point(51, 77);
			this.cmdNueva.Name = "cmdNueva";
			this.cmdNueva.Size = new System.Drawing.Size(115, 42);
			this.cmdNueva.TabIndex = 1;
			this.cmdNueva.Text = "Ruta nueva";
			this.toolTip1.SetToolTip(this.cmdNueva, "Ruta que se realiza a diario");
			this.cmdNueva.UseVisualStyleBackColor = true;
			this.cmdNueva.Visible = false;
			this.cmdNueva.Click += new System.EventHandler(this.CmdNuevaClick);
			// 
			// lblPregunta
			// 
			this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregunta.Location = new System.Drawing.Point(33, 9);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(445, 23);
			this.lblPregunta.TabIndex = 2;
			this.lblPregunta.Text = "¿Qué tipo de ruta desea agregar?";
			this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdTemp
			// 
			this.cmdTemp.Location = new System.Drawing.Point(52, 26);
			this.cmdTemp.Name = "cmdTemp";
			this.cmdTemp.Size = new System.Drawing.Size(115, 42);
			this.cmdTemp.TabIndex = 3;
			this.cmdTemp.Text = "Apoyos Extra";
			this.toolTip1.SetToolTip(this.cmdTemp, "Rutas de apoyo similares a las ya establecidas");
			this.cmdTemp.UseVisualStyleBackColor = true;
			this.cmdTemp.Click += new System.EventHandler(this.CmdTempClick);
			// 
			// cmdExtraExt
			// 
			this.cmdExtraExt.Location = new System.Drawing.Point(52, 77);
			this.cmdExtraExt.Name = "cmdExtraExt";
			this.cmdExtraExt.Size = new System.Drawing.Size(115, 42);
			this.cmdExtraExt.TabIndex = 4;
			this.cmdExtraExt.Text = "Extra existentes extendida";
			this.cmdExtraExt.UseVisualStyleBackColor = true;
			this.cmdExtraExt.Visible = false;
			this.cmdExtraExt.Click += new System.EventHandler(this.CmdExtraExtClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdNueva);
			this.groupBox1.Controls.Add(this.cmdApoyo);
			this.groupBox1.Location = new System.Drawing.Point(33, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 86);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdExtraExt);
			this.groupBox2.Controls.Add(this.cmdTemp);
			this.groupBox2.Location = new System.Drawing.Point(259, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(219, 86);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// FormNuevaRuta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(512, 135);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblPregunta);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormNuevaRuta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nueva ruta";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdExtraExt;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdTemp;
		private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.Button cmdNueva;
		private System.Windows.Forms.Button cmdApoyo;
	}
}
