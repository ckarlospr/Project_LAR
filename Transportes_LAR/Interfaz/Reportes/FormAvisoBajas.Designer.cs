/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 15/05/2013
 * Time: 11:14 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormAvisoBajas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvisoBajas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgOperador = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCardex = new System.Windows.Forms.DataGridView();
			this.ID_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tc = new System.Windows.Forms.TabControl();
			this.tpDoc = new System.Windows.Forms.TabPage();
			this.cmdBaja = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgEvalua = new System.Windows.Forms.DataGridView();
			this.ID_OPEV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOM_EV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.E3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgDocument = new System.Windows.Forms.DataGridView();
			this.ID_OPDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dgCardex2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCardex)).BeginInit();
			this.tc.SuspendLayout();
			this.tpDoc.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEvalua)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDocument)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCardex2)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOperador
			// 
			this.dgOperador.AllowUserToAddRows = false;
			this.dgOperador.AllowUserToResizeRows = false;
			this.dgOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgOperador.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Operador,
									this.curp});
			this.dgOperador.Location = new System.Drawing.Point(6, 42);
			this.dgOperador.Name = "dgOperador";
			this.dgOperador.RowHeadersVisible = false;
			this.dgOperador.Size = new System.Drawing.Size(123, 388);
			this.dgOperador.TabIndex = 0;
			this.dgOperador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOperadorCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Operador
			// 
			this.Operador.HeaderText = "Operador";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			// 
			// curp
			// 
			this.curp.HeaderText = "curp";
			this.curp.Name = "curp";
			this.curp.ReadOnly = true;
			this.curp.Visible = false;
			// 
			// dgCardex
			// 
			this.dgCardex.AllowUserToAddRows = false;
			this.dgCardex.AllowUserToResizeRows = false;
			this.dgCardex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgCardex.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgCardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_H,
									this.Column1,
									this.Column8,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Regreso});
			this.dgCardex.Location = new System.Drawing.Point(134, 42);
			this.dgCardex.Name = "dgCardex";
			this.dgCardex.RowHeadersVisible = false;
			this.dgCardex.Size = new System.Drawing.Size(370, 418);
			this.dgCardex.TabIndex = 4;
			// 
			// ID_H
			// 
			this.ID_H.HeaderText = "ID";
			this.ID_H.Name = "ID_H";
			this.ID_H.ReadOnly = true;
			this.ID_H.Visible = false;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Alias";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Vehículo";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Visible = false;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Fecha";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Hora";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Turno";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Estatus";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Descripción";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Usuario";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Regreso
			// 
			this.Regreso.HeaderText = "Regreso";
			this.Regreso.Name = "Regreso";
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 35);
			this.label1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 32);
			this.label2.TabIndex = 6;
			this.label2.Text = "Operadores \r\nsin laborar";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tc
			// 
			this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tc.Controls.Add(this.tpDoc);
			this.tc.Controls.Add(this.tabPage2);
			this.tc.Controls.Add(this.tabPage1);
			this.tc.Location = new System.Drawing.Point(12, 12);
			this.tc.Name = "tc";
			this.tc.SelectedIndex = 0;
			this.tc.Size = new System.Drawing.Size(520, 494);
			this.tc.TabIndex = 7;
			// 
			// tpDoc
			// 
			this.tpDoc.Controls.Add(this.cmdBaja);
			this.tpDoc.Controls.Add(this.label2);
			this.tpDoc.Controls.Add(this.dgOperador);
			this.tpDoc.Controls.Add(this.label1);
			this.tpDoc.Controls.Add(this.dgCardex);
			this.tpDoc.Location = new System.Drawing.Point(4, 22);
			this.tpDoc.Name = "tpDoc";
			this.tpDoc.Padding = new System.Windows.Forms.Padding(3);
			this.tpDoc.Size = new System.Drawing.Size(512, 468);
			this.tpDoc.TabIndex = 0;
			this.tpDoc.Text = "Sin laborar";
			this.tpDoc.UseVisualStyleBackColor = true;
			// 
			// cmdBaja
			// 
			this.cmdBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBaja.Location = new System.Drawing.Point(6, 436);
			this.cmdBaja.Name = "cmdBaja";
			this.cmdBaja.Size = new System.Drawing.Size(123, 24);
			this.cmdBaja.TabIndex = 7;
			this.cmdBaja.Text = "BAJA";
			this.cmdBaja.UseVisualStyleBackColor = true;
			this.cmdBaja.Click += new System.EventHandler(this.CmdBajaClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.dgEvalua);
			this.tabPage2.Controls.Add(this.dgDocument);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(512, 468);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Faltantes";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(252, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(7, 448);
			this.label5.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(266, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 47);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bajas sin evaluación";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(240, 47);
			this.label3.TabIndex = 2;
			this.label3.Text = "Operadores con documentos faltantes";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgEvalua
			// 
			this.dgEvalua.AllowUserToAddRows = false;
			this.dgEvalua.AllowUserToResizeRows = false;
			this.dgEvalua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgEvalua.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEvalua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgEvalua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEvalua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_OPEV,
									this.NOM_EV,
									this.E1,
									this.E2,
									this.E3});
			this.dgEvalua.Location = new System.Drawing.Point(266, 64);
			this.dgEvalua.Name = "dgEvalua";
			this.dgEvalua.RowHeadersVisible = false;
			this.dgEvalua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEvalua.Size = new System.Drawing.Size(240, 398);
			this.dgEvalua.TabIndex = 1;
			this.dgEvalua.DoubleClick += new System.EventHandler(this.DgEvaluaDoubleClick);
			// 
			// ID_OPEV
			// 
			this.ID_OPEV.HeaderText = "ID";
			this.ID_OPEV.Name = "ID_OPEV";
			this.ID_OPEV.ReadOnly = true;
			this.ID_OPEV.Visible = false;
			// 
			// NOM_EV
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NOM_EV.DefaultCellStyle = dataGridViewCellStyle4;
			this.NOM_EV.HeaderText = "ALIAS";
			this.NOM_EV.Name = "NOM_EV";
			this.NOM_EV.ReadOnly = true;
			this.NOM_EV.Width = 200;
			// 
			// E1
			// 
			this.E1.HeaderText = "E1";
			this.E1.Name = "E1";
			this.E1.ReadOnly = true;
			this.E1.Visible = false;
			// 
			// E2
			// 
			this.E2.HeaderText = "E2";
			this.E2.Name = "E2";
			this.E2.ReadOnly = true;
			this.E2.Visible = false;
			// 
			// E3
			// 
			this.E3.HeaderText = "E3";
			this.E3.Name = "E3";
			this.E3.ReadOnly = true;
			this.E3.Visible = false;
			// 
			// dgDocument
			// 
			this.dgDocument.AllowUserToAddRows = false;
			this.dgDocument.AllowUserToResizeRows = false;
			this.dgDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgDocument.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_OPDOC,
									this.NOMBRE_OP,
									this.D1,
									this.D2,
									this.D3});
			this.dgDocument.Location = new System.Drawing.Point(6, 64);
			this.dgDocument.Name = "dgDocument";
			this.dgDocument.RowHeadersVisible = false;
			this.dgDocument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDocument.Size = new System.Drawing.Size(240, 398);
			this.dgDocument.TabIndex = 0;
			this.dgDocument.DoubleClick += new System.EventHandler(this.DgDocumentDoubleClick);
			// 
			// ID_OPDOC
			// 
			this.ID_OPDOC.HeaderText = "ID_OP";
			this.ID_OPDOC.Name = "ID_OPDOC";
			this.ID_OPDOC.ReadOnly = true;
			this.ID_OPDOC.Visible = false;
			// 
			// NOMBRE_OP
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NOMBRE_OP.DefaultCellStyle = dataGridViewCellStyle6;
			this.NOMBRE_OP.HeaderText = "ALIAS";
			this.NOMBRE_OP.Name = "NOMBRE_OP";
			this.NOMBRE_OP.ReadOnly = true;
			this.NOMBRE_OP.Width = 200;
			// 
			// D1
			// 
			this.D1.HeaderText = "D1";
			this.D1.Name = "D1";
			this.D1.ReadOnly = true;
			this.D1.Visible = false;
			// 
			// D2
			// 
			this.D2.HeaderText = "D2";
			this.D2.Name = "D2";
			this.D2.ReadOnly = true;
			this.D2.Visible = false;
			// 
			// D3
			// 
			this.D3.HeaderText = "D3";
			this.D3.Name = "D3";
			this.D3.ReadOnly = true;
			this.D3.Visible = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgCardex2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(512, 468);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Dormidas";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dgCardex2
			// 
			this.dgCardex2.AllowUserToAddRows = false;
			this.dgCardex2.AllowUserToResizeColumns = false;
			this.dgCardex2.AllowUserToResizeRows = false;
			this.dgCardex2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgCardex2.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCardex2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgCardex2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCardex2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.dataGridViewTextBoxColumn6,
									this.dataGridViewTextBoxColumn7,
									this.dataGridViewTextBoxColumn8});
			this.dgCardex2.Location = new System.Drawing.Point(6, 6);
			this.dgCardex2.Name = "dgCardex2";
			this.dgCardex2.RowHeadersVisible = false;
			this.dgCardex2.Size = new System.Drawing.Size(500, 456);
			this.dgCardex2.TabIndex = 6;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Alias";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Vehículo";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Hora";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Turno";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Estatus";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Descripcion";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Usuario";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// FormAvisoBajas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(544, 515);
			this.Controls.Add(this.tc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(560, 553);
			this.Name = "FormAvisoBajas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Aviso Bajas";
			this.Load += new System.EventHandler(this.FormAvisoBajasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCardex)).EndInit();
			this.tc.ResumeLayout(false);
			this.tpDoc.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgEvalua)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgDocument)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgCardex2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dgCardex2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button cmdBaja;
		private System.Windows.Forms.DataGridViewTextBoxColumn curp;
		private System.Windows.Forms.DataGridViewTextBoxColumn D3;
		private System.Windows.Forms.DataGridViewTextBoxColumn D2;
		private System.Windows.Forms.DataGridViewTextBoxColumn D1;
		private System.Windows.Forms.DataGridViewTextBoxColumn E3;
		private System.Windows.Forms.DataGridViewTextBoxColumn E2;
		private System.Windows.Forms.DataGridViewTextBoxColumn E1;
		private System.Windows.Forms.DataGridView dgEvalua;
		private System.Windows.Forms.DataGridView dgDocument;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_OP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPDOC;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOM_EV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPEV;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tpDoc;
		private System.Windows.Forms.TabControl tc;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_H;
		private System.Windows.Forms.DataGridViewTextBoxColumn Regreso;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgCardex;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgOperador;
	}
}
