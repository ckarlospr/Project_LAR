namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	partial class FormPerdida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerdida));
			this.txtNota = new System.Windows.Forms.TextBox();
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbltfecha = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblRealizado = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.gbCausa = new System.Windows.Forms.GroupBox();
			this.ckChoque = new System.Windows.Forms.CheckBox();
			this.ckEspeciales = new System.Windows.Forms.CheckBox();
			this.ckMalaActitud = new System.Windows.Forms.CheckBox();
			this.ckExceso = new System.Windows.Forms.CheckBox();
			this.ckTaxi = new System.Windows.Forms.CheckBox();
			this.ckUniforme = new System.Windows.Forms.CheckBox();
			this.ckCombustible = new System.Windows.Forms.CheckBox();
			this.ckDormida = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataPerdidas = new System.Windows.Forms.DataGridView();
			this.ID_perdida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id_historial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbCausa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPerdidas)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNota
			// 
			this.txtNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNota.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota.Location = new System.Drawing.Point(9, 260);
			this.txtNota.Multiline = true;
			this.txtNota.Name = "txtNota";
			this.txtNota.Size = new System.Drawing.Size(262, 94);
			this.txtNota.TabIndex = 0;
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.BackgroundImage")));
			this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdNuevo.Location = new System.Drawing.Point(237, 363);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(35, 34);
			this.cmdNuevo.TabIndex = 3;
			this.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Justificación Perdida Bono";
			// 
			// lbltfecha
			// 
			this.lbltfecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltfecha.Location = new System.Drawing.Point(10, 363);
			this.lbltfecha.Name = "lbltfecha";
			this.lbltfecha.Size = new System.Drawing.Size(47, 16);
			this.lbltfecha.TabIndex = 5;
			this.lbltfecha.Text = "Fecha:";
			// 
			// lblFecha
			// 
			this.lblFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(107, 363);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(70, 16);
			this.lblFecha.TabIndex = 6;
			this.lblFecha.Text = "Fecha";
			// 
			// lblRealizado
			// 
			this.lblRealizado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRealizado.Location = new System.Drawing.Point(107, 379);
			this.lblRealizado.Name = "lblRealizado";
			this.lblRealizado.Size = new System.Drawing.Size(115, 18);
			this.lblRealizado.TabIndex = 7;
			this.lblRealizado.Text = "Usuario";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(9, 379);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(92, 18);
			this.lblUsuario.TabIndex = 8;
			this.lblUsuario.Text = "Guardado por:";
			// 
			// gbCausa
			// 
			this.gbCausa.Controls.Add(this.ckChoque);
			this.gbCausa.Controls.Add(this.ckEspeciales);
			this.gbCausa.Controls.Add(this.ckMalaActitud);
			this.gbCausa.Controls.Add(this.ckExceso);
			this.gbCausa.Controls.Add(this.ckTaxi);
			this.gbCausa.Controls.Add(this.ckUniforme);
			this.gbCausa.Controls.Add(this.ckCombustible);
			this.gbCausa.Controls.Add(this.ckDormida);
			this.gbCausa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCausa.Location = new System.Drawing.Point(10, 30);
			this.gbCausa.Name = "gbCausa";
			this.gbCausa.Size = new System.Drawing.Size(143, 205);
			this.gbCausa.TabIndex = 10;
			this.gbCausa.TabStop = false;
			this.gbCausa.Text = "Causa";
			// 
			// ckChoque
			// 
			this.ckChoque.Location = new System.Drawing.Point(6, 159);
			this.ckChoque.Name = "ckChoque";
			this.ckChoque.Size = new System.Drawing.Size(117, 24);
			this.ckChoque.TabIndex = 16;
			this.ckChoque.Text = "Choque";
			this.ckChoque.UseVisualStyleBackColor = true;
			this.ckChoque.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckEspeciales
			// 
			this.ckEspeciales.Location = new System.Drawing.Point(6, 78);
			this.ckEspeciales.Name = "ckEspeciales";
			this.ckEspeciales.Size = new System.Drawing.Size(143, 24);
			this.ckEspeciales.TabIndex = 15;
			this.ckEspeciales.Text = "$ Serv. Especiales";
			this.ckEspeciales.UseVisualStyleBackColor = true;
			this.ckEspeciales.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckMalaActitud
			// 
			this.ckMalaActitud.Location = new System.Drawing.Point(6, 139);
			this.ckMalaActitud.Name = "ckMalaActitud";
			this.ckMalaActitud.Size = new System.Drawing.Size(117, 24);
			this.ckMalaActitud.TabIndex = 14;
			this.ckMalaActitud.Text = "Mala Actitud";
			this.ckMalaActitud.UseVisualStyleBackColor = true;
			this.ckMalaActitud.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckExceso
			// 
			this.ckExceso.Location = new System.Drawing.Point(6, 58);
			this.ckExceso.Name = "ckExceso";
			this.ckExceso.Size = new System.Drawing.Size(143, 24);
			this.ckExceso.TabIndex = 13;
			this.ckExceso.Text = "Exceso de Velocidad";
			this.ckExceso.UseVisualStyleBackColor = true;
			this.ckExceso.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckTaxi
			// 
			this.ckTaxi.Location = new System.Drawing.Point(6, 119);
			this.ckTaxi.Name = "ckTaxi";
			this.ckTaxi.Size = new System.Drawing.Size(117, 24);
			this.ckTaxi.TabIndex = 12;
			this.ckTaxi.Text = "Taxi";
			this.ckTaxi.UseVisualStyleBackColor = true;
			this.ckTaxi.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckUniforme
			// 
			this.ckUniforme.Location = new System.Drawing.Point(6, 38);
			this.ckUniforme.Name = "ckUniforme";
			this.ckUniforme.Size = new System.Drawing.Size(117, 24);
			this.ckUniforme.TabIndex = 11;
			this.ckUniforme.Text = "Unifome";
			this.ckUniforme.UseVisualStyleBackColor = true;
			this.ckUniforme.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckCombustible
			// 
			this.ckCombustible.Location = new System.Drawing.Point(6, 99);
			this.ckCombustible.Name = "ckCombustible";
			this.ckCombustible.Size = new System.Drawing.Size(117, 24);
			this.ckCombustible.TabIndex = 10;
			this.ckCombustible.Text = "Combustible";
			this.ckCombustible.UseVisualStyleBackColor = true;
			this.ckCombustible.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// ckDormida
			// 
			this.ckDormida.Location = new System.Drawing.Point(6, 18);
			this.ckDormida.Name = "ckDormida";
			this.ckDormida.Size = new System.Drawing.Size(117, 24);
			this.ckDormida.TabIndex = 9;
			this.ckDormida.Text = "Dormida";
			this.ckDormida.UseVisualStyleBackColor = true;
			this.ckDormida.CheckedChanged += new System.EventHandler(this.CkOtroCheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Comentarios:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataPerdidas
			// 
			this.dataPerdidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPerdidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_perdida,
									this.Id_historial,
									this.Tipo});
			this.dataPerdidas.Location = new System.Drawing.Point(159, 39);
			this.dataPerdidas.Name = "dataPerdidas";
			this.dataPerdidas.RowHeadersVisible = false;
			this.dataPerdidas.Size = new System.Drawing.Size(112, 196);
			this.dataPerdidas.TabIndex = 12;
			// 
			// ID_perdida
			// 
			this.ID_perdida.HeaderText = "ID";
			this.ID_perdida.Name = "ID_perdida";
			this.ID_perdida.ReadOnly = true;
			this.ID_perdida.Visible = false;
			// 
			// Id_historial
			// 
			this.Id_historial.HeaderText = "ID_Historial";
			this.Id_historial.Name = "Id_historial";
			this.Id_historial.ReadOnly = true;
			this.Id_historial.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// FormPerdida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(283, 404);
			this.ControlBox = false;
			this.Controls.Add(this.dataPerdidas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbCausa);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblRealizado);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lbltfecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdNuevo);
			this.Controls.Add(this.txtNota);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(293, 436);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(293, 436);
			this.Name = "FormPerdida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Comentarios";
			this.Load += new System.EventHandler(this.FormComentariosLoad);
			this.gbCausa.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataPerdidas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_historial;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_perdida;
		private System.Windows.Forms.CheckBox ckDormida;
		private System.Windows.Forms.CheckBox ckCombustible;
		private System.Windows.Forms.CheckBox ckUniforme;
		private System.Windows.Forms.CheckBox ckTaxi;
		private System.Windows.Forms.CheckBox ckExceso;
		private System.Windows.Forms.CheckBox ckMalaActitud;
		private System.Windows.Forms.CheckBox ckEspeciales;
		private System.Windows.Forms.CheckBox ckChoque;
		private System.Windows.Forms.DataGridView dataPerdidas;
		private System.Windows.Forms.GroupBox gbCausa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblRealizado;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lbltfecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.TextBox txtNota;
	}
}