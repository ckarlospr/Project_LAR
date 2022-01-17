/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 29/07/2014
 * Hora: 11:13 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormCardexCoordinador
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
			this.txtCoordinador = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAnomalia = new System.Windows.Forms.TextBox();
			this.cmbAnomalia = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtCoordinador
			// 
			this.txtCoordinador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCoordinador.Location = new System.Drawing.Point(12, 116);
			this.txtCoordinador.Name = "txtCoordinador";
			this.txtCoordinador.Size = new System.Drawing.Size(175, 22);
			this.txtCoordinador.TabIndex = 0;
			this.txtCoordinador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCoordinador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCoordinadorKeyUp);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(492, 63);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cardex coordinador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Coordinador";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtAnomalia
			// 
			this.txtAnomalia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAnomalia.Enabled = false;
			this.txtAnomalia.Location = new System.Drawing.Point(213, 146);
			this.txtAnomalia.Name = "txtAnomalia";
			this.txtAnomalia.Size = new System.Drawing.Size(288, 22);
			this.txtAnomalia.TabIndex = 3;
			this.txtAnomalia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbAnomalia
			// 
			this.cmbAnomalia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAnomalia.FormattingEnabled = true;
			this.cmbAnomalia.Items.AddRange(new object[] {
									"NO ENVIO RUTA",
									"CRUZO OPERADORES",
									"NO LLENO DATOS EN DESPACHO",
									"MAL CAPTURA DE INFOMACION",
									"OTRO"});
			this.cmbAnomalia.Location = new System.Drawing.Point(213, 116);
			this.cmbAnomalia.Name = "cmbAnomalia";
			this.cmbAnomalia.Size = new System.Drawing.Size(288, 24);
			this.cmbAnomalia.TabIndex = 1;
			this.cmbAnomalia.SelectedIndexChanged += new System.EventHandler(this.CmbAnomaliaSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(213, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(288, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Anomalias";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(12, 199);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(489, 68);
			this.txtComentario.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Comentarios";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdGuardar.Location = new System.Drawing.Point(397, 297);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(104, 30);
			this.cmdGuardar.TabIndex = 8;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(41, 144);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(115, 22);
			this.dtpFecha.TabIndex = 2;
			// 
			// FormCardexCoordinador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 339);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbAnomalia);
			this.Controls.Add(this.txtAnomalia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCoordinador);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCardexCoordinador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cardex Coordinador";
			this.Load += new System.EventHandler(this.FormCardexCoordinadorLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbAnomalia;
		private System.Windows.Forms.TextBox txtAnomalia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCoordinador;
	}
}
