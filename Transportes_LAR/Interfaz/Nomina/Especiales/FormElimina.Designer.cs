/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 06/01/2014
 * Hora: 12:05 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormElimina
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
			this.rbPagado = new System.Windows.Forms.RadioButton();
			this.rbFact = new System.Windows.Forms.RadioButton();
			this.rbOtro = new System.Windows.Forms.RadioButton();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbPagado
			// 
			this.rbPagado.Checked = true;
			this.rbPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPagado.Location = new System.Drawing.Point(55, 19);
			this.rbPagado.Name = "rbPagado";
			this.rbPagado.Size = new System.Drawing.Size(82, 24);
			this.rbPagado.TabIndex = 0;
			this.rbPagado.TabStop = true;
			this.rbPagado.Text = "PAGADO";
			this.rbPagado.UseVisualStyleBackColor = true;
			// 
			// rbFact
			// 
			this.rbFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbFact.Location = new System.Drawing.Point(143, 19);
			this.rbFact.Name = "rbFact";
			this.rbFact.Size = new System.Drawing.Size(109, 24);
			this.rbFact.TabIndex = 1;
			this.rbFact.Text = "FACTURADO";
			this.rbFact.UseVisualStyleBackColor = true;
			// 
			// rbOtro
			// 
			this.rbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOtro.Location = new System.Drawing.Point(258, 19);
			this.rbOtro.Name = "rbOtro";
			this.rbOtro.Size = new System.Drawing.Size(64, 24);
			this.rbOtro.TabIndex = 2;
			this.rbOtro.Text = "OTRO";
			this.rbOtro.UseVisualStyleBackColor = true;
			// 
			// txtComentario
			// 
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(12, 84);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(384, 70);
			this.txtComentario.TabIndex = 3;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(314, 160);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(82, 23);
			this.cmdGuardar.TabIndex = 4;
			this.cmdGuardar.Text = "GUARDAR";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbOtro);
			this.groupBox1.Controls.Add(this.rbFact);
			this.groupBox1.Controls.Add(this.rbPagado);
			this.groupBox1.Location = new System.Drawing.Point(12, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 54);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Comentarios";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormElimina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 195);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtComentario);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(424, 233);
			this.Name = "FormElimina";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbFact;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.RadioButton rbOtro;
		private System.Windows.Forms.RadioButton rbPagado;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
