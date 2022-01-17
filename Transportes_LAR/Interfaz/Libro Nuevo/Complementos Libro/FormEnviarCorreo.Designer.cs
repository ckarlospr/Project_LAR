/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 20/10/2015
 * Time: 09:17 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormEnviarCorreo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnviarCorreo));
			this.lblPara = new System.Windows.Forms.Label();
			this.txtPara = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCuerpo = new System.Windows.Forms.TextBox();
			this.txtAsunto = new System.Windows.Forms.TextBox();
			this.btnExaminar = new System.Windows.Forms.Button();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtDe = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.lblDestinio = new System.Windows.Forms.Label();
			this.dgAdjuntos = new System.Windows.Forms.DataGridView();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X = new System.Windows.Forms.DataGridViewImageColumn();
			this.lblEnviado = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgAdjuntos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPara
			// 
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPara.Location = new System.Drawing.Point(16, 73);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(49, 23);
			this.lblPara.TabIndex = 0;
			this.lblPara.Text = "Para:";
			// 
			// txtPara
			// 
			this.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPara.Location = new System.Drawing.Point(87, 73);
			this.txtPara.Name = "txtPara";
			this.txtPara.Size = new System.Drawing.Size(441, 20);
			this.txtPara.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Asunto:";
			// 
			// txtCuerpo
			// 
			this.txtCuerpo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCuerpo.Location = new System.Drawing.Point(14, 133);
			this.txtCuerpo.Multiline = true;
			this.txtCuerpo.Name = "txtCuerpo";
			this.txtCuerpo.Size = new System.Drawing.Size(338, 152);
			this.txtCuerpo.TabIndex = 5;
			// 
			// txtAsunto
			// 
			this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAsunto.Location = new System.Drawing.Point(87, 99);
			this.txtAsunto.Name = "txtAsunto";
			this.txtAsunto.Size = new System.Drawing.Size(441, 20);
			this.txtAsunto.TabIndex = 4;
			// 
			// btnExaminar
			// 
			this.btnExaminar.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExaminar.Location = new System.Drawing.Point(452, 289);
			this.btnExaminar.Name = "btnExaminar";
			this.btnExaminar.Size = new System.Drawing.Size(75, 23);
			this.btnExaminar.TabIndex = 6;
			this.btnExaminar.Text = "Examinar";
			this.btnExaminar.UseVisualStyleBackColor = false;
			this.btnExaminar.Click += new System.EventHandler(this.BtnExaminarClick);
			// 
			// btnEnviar
			// 
			this.btnEnviar.BackColor = System.Drawing.Color.LightGray;
			this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
			this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEnviar.Location = new System.Drawing.Point(131, 302);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(80, 50);
			this.btnEnviar.TabIndex = 8;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.BtnEnviarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(318, 302);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 50);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Salir";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// txtDe
			// 
			this.txtDe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDe.Enabled = false;
			this.txtDe.Location = new System.Drawing.Point(86, 47);
			this.txtDe.Name = "txtDe";
			this.txtDe.Size = new System.Drawing.Size(441, 20);
			this.txtDe.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "De:";
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(351, 9);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(176, 20);
			this.txtDestino.TabIndex = 1;
			// 
			// lblDestinio
			// 
			this.lblDestinio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestinio.Location = new System.Drawing.Point(285, 8);
			this.lblDestinio.Name = "lblDestinio";
			this.lblDestinio.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDestinio.Size = new System.Drawing.Size(69, 21);
			this.lblDestinio.TabIndex = 102;
			this.lblDestinio.Text = "Destino:";
			this.lblDestinio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgAdjuntos
			// 
			this.dgAdjuntos.AllowUserToAddRows = false;
			this.dgAdjuntos.AllowUserToDeleteRows = false;
			this.dgAdjuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAdjuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Ruta,
									this.Nombre,
									this.X});
			this.dgAdjuntos.Location = new System.Drawing.Point(358, 133);
			this.dgAdjuntos.MultiSelect = false;
			this.dgAdjuntos.Name = "dgAdjuntos";
			this.dgAdjuntos.ReadOnly = true;
			this.dgAdjuntos.RowHeadersVisible = false;
			this.dgAdjuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAdjuntos.Size = new System.Drawing.Size(170, 150);
			this.dgAdjuntos.TabIndex = 10;
			this.dgAdjuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAdjuntosCellContentClick);
			// 
			// Ruta
			// 
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			this.Ruta.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.FillWeight = 113.5025F;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// X
			// 
			this.X.FillWeight = 16.49746F;
			this.X.HeaderText = "X";
			this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
			this.X.Name = "X";
			this.X.ReadOnly = true;
			// 
			// lblEnviado
			// 
			this.lblEnviado.BackColor = System.Drawing.SystemColors.Control;
			this.lblEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnviado.ForeColor = System.Drawing.Color.Black;
			this.lblEnviado.Location = new System.Drawing.Point(12, 8);
			this.lblEnviado.Name = "lblEnviado";
			this.lblEnviado.Size = new System.Drawing.Size(98, 18);
			this.lblEnviado.TabIndex = 104;
			this.lblEnviado.Text = "Enviando.........";
			this.lblEnviado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblEnviado.Visible = false;
			// 
			// FormEnviarCorreo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 361);
			this.Controls.Add(this.lblEnviado);
			this.Controls.Add(this.dgAdjuntos);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.lblDestinio);
			this.Controls.Add(this.txtDe);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.btnExaminar);
			this.Controls.Add(this.txtAsunto);
			this.Controls.Add(this.txtCuerpo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPara);
			this.Controls.Add(this.lblPara);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(555, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(555, 400);
			this.Name = "FormEnviarCorreo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enviar Correo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEnviarCorreoFormClosing);
			this.Load += new System.EventHandler(this.FormEnviarCorreoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgAdjuntos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblEnviado;
		private System.Windows.Forms.DataGridViewImageColumn X;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridView dgAdjuntos;
		private System.Windows.Forms.Label lblDestinio;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDe;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Button btnExaminar;
		private System.Windows.Forms.TextBox txtAsunto;
		private System.Windows.Forms.TextBox txtCuerpo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPara;
		private System.Windows.Forms.Label lblPara;
	}
}
