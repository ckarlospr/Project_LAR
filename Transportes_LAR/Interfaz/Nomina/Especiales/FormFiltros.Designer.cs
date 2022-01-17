/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 26/04/2013
 * Time: 02:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormFiltros
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.tvFiltro = new System.Windows.Forms.TreeView();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdCerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(209, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Titulo";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tvFiltro
			// 
			this.tvFiltro.CheckBoxes = true;
			this.tvFiltro.Location = new System.Drawing.Point(25, 35);
			this.tvFiltro.Name = "tvFiltro";
			this.tvFiltro.Size = new System.Drawing.Size(183, 188);
			this.tvFiltro.TabIndex = 1;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(25, 229);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(83, 30);
			this.cmdGuardar.TabIndex = 2;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			// 
			// cmdCerrar
			// 
			this.cmdCerrar.Location = new System.Drawing.Point(125, 229);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.Size = new System.Drawing.Size(83, 30);
			this.cmdCerrar.TabIndex = 3;
			this.cmdCerrar.Text = "Cerrar";
			this.cmdCerrar.UseVisualStyleBackColor = true;
			this.cmdCerrar.Click += new System.EventHandler(this.CmdCerrarClick);
			// 
			// FormFiltros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 262);
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.tvFiltro);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFiltros";
			this.Text = "Filtros";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TreeView tvFiltro;
		private System.Windows.Forms.Label lblTitulo;
	}
}
