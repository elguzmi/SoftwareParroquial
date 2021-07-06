namespace Parroquia_Windows
{
    partial class BuscarBautismoA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarBautismoA));
            this.DgvBautismos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtPartida = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.GbNovia = new System.Windows.Forms.GroupBox();
            this.TxtBuscarporPadres = new System.Windows.Forms.TextBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.GbNovio = new System.Windows.Forms.GroupBox();
            this.TxtBuscarporNombre = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.GbCodigo = new System.Windows.Forms.GroupBox();
            this.TxtBuscarPartida = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBautismos)).BeginInit();
            this.panel1.SuspendLayout();
            this.GbNovia.SuspendLayout();
            this.GbNovio.SuspendLayout();
            this.GbCodigo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBautismos
            // 
            this.DgvBautismos.BackgroundColor = System.Drawing.Color.White;
            this.DgvBautismos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBautismos.Location = new System.Drawing.Point(12, 178);
            this.DgvBautismos.Name = "DgvBautismos";
            this.DgvBautismos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBautismos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBautismos.Size = new System.Drawing.Size(1115, 433);
            this.DgvBautismos.TabIndex = 0;
            this.DgvBautismos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBautismos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 77);
            this.panel1.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(432, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(281, 64);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Bautismos";
            // 
            // TxtPartida
            // 
            this.TxtPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPartida.Location = new System.Drawing.Point(138, 40);
            this.TxtPartida.Name = "TxtPartida";
            this.TxtPartida.Size = new System.Drawing.Size(172, 26);
            this.TxtPartida.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(335, 40);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(564, 26);
            this.TxtNombre.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(34)))), ((int)(((byte)(209)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(970, 619);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(148, 51);
            this.BtnEliminar.TabIndex = 48;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(34)))), ((int)(((byte)(209)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(422, 704);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(175, 46);
            this.BtnEditar.TabIndex = 49;
            this.BtnEditar.Text = "Cerrar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // GbNovia
            // 
            this.GbNovia.Controls.Add(this.TxtBuscarporPadres);
            this.GbNovia.Controls.Add(this.shapeContainer3);
            this.GbNovia.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNovia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GbNovia.Location = new System.Drawing.Point(620, 82);
            this.GbNovia.Name = "GbNovia";
            this.GbNovia.Size = new System.Drawing.Size(507, 90);
            this.GbNovia.TabIndex = 74;
            this.GbNovia.TabStop = false;
            this.GbNovia.Text = "Buscar por Padres";
            // 
            // TxtBuscarporPadres
            // 
            this.TxtBuscarporPadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarporPadres.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarporPadres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtBuscarporPadres.Location = new System.Drawing.Point(15, 39);
            this.TxtBuscarporPadres.Multiline = true;
            this.TxtBuscarporPadres.Name = "TxtBuscarporPadres";
            this.TxtBuscarporPadres.Size = new System.Drawing.Size(474, 28);
            this.TxtBuscarporPadres.TabIndex = 67;
            this.TxtBuscarporPadres.TextChanged += new System.EventHandler(this.TxtBuscarporPadres_TextChanged);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(501, 65);
            this.shapeContainer3.TabIndex = 67;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape2.Name = "lineShape24";
            this.lineShape2.X1 = 12;
            this.lineShape2.X2 = 485;
            this.lineShape2.Y1 = 45;
            this.lineShape2.Y2 = 45;
            // 
            // GbNovio
            // 
            this.GbNovio.Controls.Add(this.TxtBuscarporNombre);
            this.GbNovio.Controls.Add(this.shapeContainer1);
            this.GbNovio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNovio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GbNovio.Location = new System.Drawing.Point(171, 82);
            this.GbNovio.Name = "GbNovio";
            this.GbNovio.Size = new System.Drawing.Size(443, 90);
            this.GbNovio.TabIndex = 73;
            this.GbNovio.TabStop = false;
            this.GbNovio.Text = "Buscar por Nombre";
            // 
            // TxtBuscarporNombre
            // 
            this.TxtBuscarporNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarporNombre.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarporNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtBuscarporNombre.Location = new System.Drawing.Point(15, 39);
            this.TxtBuscarporNombre.Multiline = true;
            this.TxtBuscarporNombre.Name = "TxtBuscarporNombre";
            this.TxtBuscarporNombre.Size = new System.Drawing.Size(411, 28);
            this.TxtBuscarporNombre.TabIndex = 67;
            this.TxtBuscarporNombre.TextChanged += new System.EventHandler(this.TxtBuscarporNombre_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(437, 65);
            this.shapeContainer1.TabIndex = 67;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Name = "lineShape24";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 424;
            this.lineShape1.Y1 = 47;
            this.lineShape1.Y2 = 47;
            // 
            // GbCodigo
            // 
            this.GbCodigo.Controls.Add(this.TxtBuscarPartida);
            this.GbCodigo.Controls.Add(this.shapeContainer2);
            this.GbCodigo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCodigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GbCodigo.Location = new System.Drawing.Point(12, 82);
            this.GbCodigo.Name = "GbCodigo";
            this.GbCodigo.Size = new System.Drawing.Size(153, 90);
            this.GbCodigo.TabIndex = 72;
            this.GbCodigo.TabStop = false;
            this.GbCodigo.Text = "Buscar por codigo";
            // 
            // TxtBuscarPartida
            // 
            this.TxtBuscarPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarPartida.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPartida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtBuscarPartida.Location = new System.Drawing.Point(6, 39);
            this.TxtBuscarPartida.Multiline = true;
            this.TxtBuscarPartida.Name = "TxtBuscarPartida";
            this.TxtBuscarPartida.Size = new System.Drawing.Size(113, 28);
            this.TxtBuscarPartida.TabIndex = 67;
            this.TxtBuscarPartida.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape24});
            this.shapeContainer2.Size = new System.Drawing.Size(147, 65);
            this.shapeContainer2.TabIndex = 67;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape24
            // 
            this.lineShape24.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = 3;
            this.lineShape24.X2 = 115;
            this.lineShape24.Y1 = 45;
            this.lineShape24.Y2 = 45;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(970, 676);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(148, 49);
            this.BtnImprimir.TabIndex = 75;
            this.BtnImprimir.Text = "    Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtPartida);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 617);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 81);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // BuscarBautismoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.GbNovia);
            this.Controls.Add(this.GbNovio);
            this.Controls.Add(this.GbCodigo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvBautismos);
            this.Name = "BuscarBautismoA";
            this.Text = "Buscar Bautismo";
            this.Load += new System.EventHandler(this.BuscarBautismo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBautismos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbNovia.ResumeLayout(false);
            this.GbNovia.PerformLayout();
            this.GbNovio.ResumeLayout(false);
            this.GbNovio.PerformLayout();
            this.GbCodigo.ResumeLayout(false);
            this.GbCodigo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBautismos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitulo;
        public System.Windows.Forms.TextBox TxtPartida;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.GroupBox GbNovia;
        private System.Windows.Forms.TextBox TxtBuscarporPadres;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.GroupBox GbNovio;
        private System.Windows.Forms.TextBox TxtBuscarporNombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox GbCodigo;
        private System.Windows.Forms.TextBox TxtBuscarPartida;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape24;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}