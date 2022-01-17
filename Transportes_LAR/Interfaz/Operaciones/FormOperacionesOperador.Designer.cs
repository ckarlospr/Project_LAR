/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 25/09/2012
 * Time: 12:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormOperacionesOperador
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
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtNumeroV = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtAlias
			// 
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Location = new System.Drawing.Point(3, 5);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(44, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtAliasMouseClick);
			this.txtAlias.DoubleClick += new System.EventHandler(this.TxtAliasDoubleClick);
			this.txtAlias.Enter += new System.EventHandler(this.TxtAliasEnter);
			this.txtAlias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAliasKeyPress);
			this.txtAlias.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TxtAliasMouseDown);
			this.txtAlias.MouseLeave += new System.EventHandler(this.TxtAliasMouseLeave);
			this.txtAlias.MouseHover += new System.EventHandler(this.TxtAliasMouseHover);
			// 
			// txtEstado
			// 
			this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstado.Location = new System.Drawing.Point(49, 27);
			this.txtEstado.MaxLength = 1;
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(20, 20);
			this.txtEstado.TabIndex = 1;
			this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEstado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtEstadoMouseClick);
			this.txtEstado.TextChanged += new System.EventHandler(this.TxtEstadoTextChanged);
			this.txtEstado.DoubleClick += new System.EventHandler(this.TxtEstadoDoubleClick);
			this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstadoKeyPress);
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(49, 5);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(20, 20);
			this.txtNum.TabIndex = 2;
			this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNum.DoubleClick += new System.EventHandler(this.TxtNumDoubleClick);
			// 
			// txtNumeroV
			// 
			this.txtNumeroV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumeroV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroV.Location = new System.Drawing.Point(3, 27);
			this.txtNumeroV.Multiline = true;
			this.txtNumeroV.Name = "txtNumeroV";
			this.txtNumeroV.Size = new System.Drawing.Size(44, 20);
			this.txtNumeroV.TabIndex = 3;
			this.txtNumeroV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormOperacionesOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(70, 51);
			this.Controls.Add(this.txtNumeroV);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtAlias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormOperacionesOperador";
			this.Text = "FormOperacionesOperador";
			this.Load += new System.EventHandler(this.FormOperacionesOperadorLoad);
			this.MouseEnter += new System.EventHandler(this.FormOperacionesOperadorMouseEnter);
			this.MouseLeave += new System.EventHandler(this.FormOperacionesOperadorMouseLeave);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.TextBox txtNumeroV;
		public System.Windows.Forms.TextBox txtAlias;
		public System.Windows.Forms.TextBox txtEstado;
		public System.Windows.Forms.TextBox txtNum;
		
	}
}
