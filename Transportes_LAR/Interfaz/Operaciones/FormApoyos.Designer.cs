/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 05/03/2013
 * Time: 10:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormApoyos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApoyos));
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.lblSuperv = new System.Windows.Forms.Label();
			this.lblRuta = new System.Windows.Forms.Label();
			this.lblOperador = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.txtApoyo = new System.Windows.Forms.TextBox();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.rbRuta = new System.Windows.Forms.RadioButton();
			this.rbCoordinacion = new System.Windows.Forms.RadioButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.rbOficinas = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtComentarios = new System.Windows.Forms.TextBox();
			this.gbRuta = new System.Windows.Forms.GroupBox();
			this.txtOpCo = new System.Windows.Forms.TextBox();
			this.gbCoor = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbOficinas = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOpOf = new System.Windows.Forms.TextBox();
			this.rbCompleto = new System.Windows.Forms.RadioButton();
			this.rbMedio = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbCorto = new System.Windows.Forms.RadioButton();
			this.gbRuta.SuspendLayout();
			this.gbCoor.SuspendLayout();
			this.gbOficinas.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAgregar.Location = new System.Drawing.Point(654, 210);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(83, 22);
			this.cmdAgregar.TabIndex = 16;
			this.cmdAgregar.Text = "Guardar";
			this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// lblSuperv
			// 
			this.lblSuperv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSuperv.Location = new System.Drawing.Point(169, 51);
			this.lblSuperv.Name = "lblSuperv";
			this.lblSuperv.Size = new System.Drawing.Size(145, 15);
			this.lblSuperv.TabIndex = 15;
			this.lblSuperv.Text = "Apoya";
			this.lblSuperv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblRuta
			// 
			this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuta.Location = new System.Drawing.Point(18, 73);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(41, 15);
			this.lblRuta.TabIndex = 14;
			this.lblRuta.Text = "Ruta";
			this.lblRuta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(18, 51);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(145, 15);
			this.lblOperador.TabIndex = 13;
			this.lblOperador.Text = "Operador en ruta";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtRuta
			// 
			this.txtRuta.Enabled = false;
			this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(57, 70);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(257, 22);
			this.txtRuta.TabIndex = 12;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtApoyo
			// 
			this.txtApoyo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApoyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApoyo.Location = new System.Drawing.Point(169, 28);
			this.txtApoyo.Name = "txtApoyo";
			this.txtApoyo.Size = new System.Drawing.Size(145, 22);
			this.txtApoyo.TabIndex = 11;
			this.txtApoyo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtOperador
			// 
			this.txtOperador.Enabled = false;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(18, 28);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(145, 22);
			this.txtOperador.TabIndex = 10;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rbRuta
			// 
			this.rbRuta.Checked = true;
			this.rbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRuta.Location = new System.Drawing.Point(142, 2);
			this.rbRuta.Name = "rbRuta";
			this.rbRuta.Size = new System.Drawing.Size(83, 24);
			this.rbRuta.TabIndex = 18;
			this.rbRuta.TabStop = true;
			this.rbRuta.Text = "En ruta";
			this.rbRuta.UseVisualStyleBackColor = true;
			this.rbRuta.CheckedChanged += new System.EventHandler(this.RbRutaCheckedChanged);
			// 
			// rbCoordinacion
			// 
			this.rbCoordinacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCoordinacion.Location = new System.Drawing.Point(377, 2);
			this.rbCoordinacion.Name = "rbCoordinacion";
			this.rbCoordinacion.Size = new System.Drawing.Size(129, 24);
			this.rbCoordinacion.TabIndex = 19;
			this.rbCoordinacion.Text = "Coordinación";
			this.rbCoordinacion.UseVisualStyleBackColor = true;
			this.rbCoordinacion.CheckedChanged += new System.EventHandler(this.RbCoordinacionCheckedChanged);
			// 
			// rbOficinas
			// 
			this.rbOficinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOficinas.Location = new System.Drawing.Point(596, 2);
			this.rbOficinas.Name = "rbOficinas";
			this.rbOficinas.Size = new System.Drawing.Size(96, 24);
			this.rbOficinas.TabIndex = 20;
			this.rbOficinas.Text = "A oficinas";
			this.rbOficinas.UseVisualStyleBackColor = true;
			this.rbOficinas.CheckedChanged += new System.EventHandler(this.RbOficinasCheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(363, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 23;
			this.label1.Text = "Comentarios:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtComentarios
			// 
			this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentarios.Location = new System.Drawing.Point(363, 153);
			this.txtComentarios.Multiline = true;
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(371, 49);
			this.txtComentarios.TabIndex = 22;
			// 
			// gbRuta
			// 
			this.gbRuta.Controls.Add(this.lblSuperv);
			this.gbRuta.Controls.Add(this.lblRuta);
			this.gbRuta.Controls.Add(this.lblOperador);
			this.gbRuta.Controls.Add(this.txtRuta);
			this.gbRuta.Controls.Add(this.txtApoyo);
			this.gbRuta.Controls.Add(this.txtOperador);
			this.gbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRuta.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbRuta.Location = new System.Drawing.Point(14, 32);
			this.gbRuta.Name = "gbRuta";
			this.gbRuta.Size = new System.Drawing.Size(333, 103);
			this.gbRuta.TabIndex = 25;
			this.gbRuta.TabStop = false;
			this.gbRuta.Text = "Datos por ruta";
			// 
			// txtOpCo
			// 
			this.txtOpCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOpCo.Location = new System.Drawing.Point(14, 48);
			this.txtOpCo.Name = "txtOpCo";
			this.txtOpCo.Size = new System.Drawing.Size(145, 22);
			this.txtOpCo.TabIndex = 25;
			this.txtOpCo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// gbCoor
			// 
			this.gbCoor.Controls.Add(this.label2);
			this.gbCoor.Controls.Add(this.txtOpCo);
			this.gbCoor.Enabled = false;
			this.gbCoor.Location = new System.Drawing.Point(363, 35);
			this.gbCoor.Name = "gbCoor";
			this.gbCoor.Size = new System.Drawing.Size(176, 100);
			this.gbCoor.TabIndex = 27;
			this.gbCoor.TabStop = false;
			this.gbCoor.Text = "Datos por coordinacion";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 15);
			this.label2.TabIndex = 16;
			this.label2.Text = "Operador";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// gbOficinas
			// 
			this.gbOficinas.Controls.Add(this.label3);
			this.gbOficinas.Controls.Add(this.txtOpOf);
			this.gbOficinas.Enabled = false;
			this.gbOficinas.Location = new System.Drawing.Point(558, 36);
			this.gbOficinas.Name = "gbOficinas";
			this.gbOficinas.Size = new System.Drawing.Size(176, 99);
			this.gbOficinas.TabIndex = 28;
			this.gbOficinas.TabStop = false;
			this.gbOficinas.Text = "Datos por oficinas";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 15);
			this.label3.TabIndex = 26;
			this.label3.Text = "Operador";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtOpOf
			// 
			this.txtOpOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOpOf.Location = new System.Drawing.Point(14, 47);
			this.txtOpOf.Name = "txtOpOf";
			this.txtOpOf.Size = new System.Drawing.Size(145, 22);
			this.txtOpOf.TabIndex = 25;
			this.txtOpOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rbCompleto
			// 
			this.rbCompleto.Location = new System.Drawing.Point(223, 19);
			this.rbCompleto.Name = "rbCompleto";
			this.rbCompleto.Size = new System.Drawing.Size(91, 24);
			this.rbCompleto.TabIndex = 16;
			this.rbCompleto.TabStop = true;
			this.rbCompleto.Text = "Completo";
			this.rbCompleto.UseVisualStyleBackColor = true;
			// 
			// rbMedio
			// 
			this.rbMedio.Location = new System.Drawing.Point(128, 19);
			this.rbMedio.Name = "rbMedio";
			this.rbMedio.Size = new System.Drawing.Size(68, 24);
			this.rbMedio.TabIndex = 17;
			this.rbMedio.TabStop = true;
			this.rbMedio.Text = "Medio";
			this.rbMedio.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbCorto);
			this.groupBox1.Controls.Add(this.rbMedio);
			this.groupBox1.Controls.Add(this.rbCompleto);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(14, 143);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 61);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recorrido";
			// 
			// rbCorto
			// 
			this.rbCorto.Location = new System.Drawing.Point(28, 19);
			this.rbCorto.Name = "rbCorto";
			this.rbCorto.Size = new System.Drawing.Size(68, 24);
			this.rbCorto.TabIndex = 18;
			this.rbCorto.TabStop = true;
			this.rbCorto.Text = "Corto";
			this.rbCorto.UseVisualStyleBackColor = true;
			// 
			// FormApoyos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(749, 244);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbOficinas);
			this.Controls.Add(this.gbCoor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtComentarios);
			this.Controls.Add(this.gbRuta);
			this.Controls.Add(this.rbOficinas);
			this.Controls.Add(this.rbCoordinacion);
			this.Controls.Add(this.rbRuta);
			this.Controls.Add(this.cmdAgregar);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormApoyos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormApoyos";
			this.Load += new System.EventHandler(this.FormApoyosLoad);
			this.gbRuta.ResumeLayout(false);
			this.gbRuta.PerformLayout();
			this.gbCoor.ResumeLayout(false);
			this.gbCoor.PerformLayout();
			this.gbOficinas.ResumeLayout(false);
			this.gbOficinas.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbCorto;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbMedio;
		private System.Windows.Forms.RadioButton rbCompleto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOpOf;
		private System.Windows.Forms.GroupBox gbOficinas;
		private System.Windows.Forms.GroupBox gbCoor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOpCo;
		private System.Windows.Forms.TextBox txtComentarios;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbOficinas;
		private System.Windows.Forms.GroupBox gbRuta;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RadioButton rbCoordinacion;
		private System.Windows.Forms.RadioButton rbRuta;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.TextBox txtApoyo;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.Label lblRuta;
		private System.Windows.Forms.Label lblSuperv;
		private System.Windows.Forms.Button cmdAgregar;
	}
}
