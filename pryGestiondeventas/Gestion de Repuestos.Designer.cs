namespace pryGestiondeventas
{
    partial class Gestion_de_Repuestos
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
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNºderepuesto = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            gbxCargaderepuestos = new GroupBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkNacional = new CheckBox();
            chkImportado = new CheckBox();
            btnConsultar = new Button();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            colRepuesto = new DataGridViewTextBoxColumn();
            colOrigen = new DataGridViewTextBoxColumn();
            colDescrpcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            gbConsulta = new GroupBox();
            gbxCargaderepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(6, 14);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(168, 14);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(46, 15);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen:";
            // 
            // lblNºderepuesto
            // 
            lblNºderepuesto.AutoSize = true;
            lblNºderepuesto.Location = new Point(312, 14);
            lblNºderepuesto.Name = "lblNºderepuesto";
            lblNºderepuesto.Size = new Size(89, 15);
            lblNºderepuesto.TabIndex = 2;
            lblNºderepuesto.Text = "Nº de repuesto:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(437, 14);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(657, 14);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            lblPrecio.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(437, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(657, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Nacional", "Importado" });
            checkedListBox1.Location = new Point(168, 46);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 40);
            checkedListBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "P-Peugeot", "F-Fiat", "R-Renault" });
            comboBox1.Location = new Point(6, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // gbxCargaderepuestos
            // 
            gbxCargaderepuestos.Controls.Add(btnLimpiar);
            gbxCargaderepuestos.Controls.Add(btnIngresar);
            gbxCargaderepuestos.Controls.Add(comboBox1);
            gbxCargaderepuestos.Controls.Add(checkedListBox1);
            gbxCargaderepuestos.Controls.Add(textBox3);
            gbxCargaderepuestos.Controls.Add(textBox2);
            gbxCargaderepuestos.Controls.Add(textBox1);
            gbxCargaderepuestos.Controls.Add(lblPrecio);
            gbxCargaderepuestos.Controls.Add(lblDescripcion);
            gbxCargaderepuestos.Controls.Add(lblNºderepuesto);
            gbxCargaderepuestos.Controls.Add(lblOrigen);
            gbxCargaderepuestos.Controls.Add(lblMarca);
            gbxCargaderepuestos.Location = new Point(12, 21);
            gbxCargaderepuestos.Name = "gbxCargaderepuestos";
            gbxCargaderepuestos.Size = new Size(779, 121);
            gbxCargaderepuestos.TabIndex = 10;
            gbxCargaderepuestos.TabStop = false;
            gbxCargaderepuestos.Text = "Carga de repuestos";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "P-Peugeot", "F-Fiat", "R-Renault" });
            comboBox2.Location = new Point(3, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 20);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 57);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 15;
            // 
            // chkNacional
            // 
            chkNacional.AutoSize = true;
            chkNacional.Location = new Point(203, 42);
            chkNacional.Name = "chkNacional";
            chkNacional.Size = new Size(73, 19);
            chkNacional.TabIndex = 16;
            chkNacional.Text = "Nacional";
            chkNacional.UseVisualStyleBackColor = true;
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Location = new Point(306, 42);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(82, 19);
            chkImportado.TabIndex = 17;
            chkImportado.Text = "Importado";
            chkImportado.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(424, 37);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(489, 92);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(130, 23);
            btnIngresar.TabIndex = 19;
            btnIngresar.Text = "Ingresar Repuesto";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(625, 92);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 95);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 19;
            label5.Text = "Cargados:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMarca, colRepuesto, colOrigen, colDescrpcion, colPrecio });
            dataGridView1.Location = new Point(3, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 131);
            dataGridView1.TabIndex = 20;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            // 
            // colRepuesto
            // 
            colRepuesto.HeaderText = "Nº de Repuesto";
            colRepuesto.Name = "colRepuesto";
            // 
            // colOrigen
            // 
            colOrigen.HeaderText = "Origen";
            colOrigen.Name = "colOrigen";
            // 
            // colDescrpcion
            // 
            colDescrpcion.HeaderText = "Descripción ";
            colDescrpcion.Name = "colDescrpcion";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            // 
            // gbConsulta
            // 
            gbConsulta.Controls.Add(dataGridView1);
            gbConsulta.Controls.Add(label5);
            gbConsulta.Controls.Add(btnConsultar);
            gbConsulta.Controls.Add(chkImportado);
            gbConsulta.Controls.Add(chkNacional);
            gbConsulta.Controls.Add(label4);
            gbConsulta.Controls.Add(label3);
            gbConsulta.Controls.Add(label2);
            gbConsulta.Controls.Add(label1);
            gbConsulta.Controls.Add(comboBox2);
            gbConsulta.Location = new Point(12, 158);
            gbConsulta.Name = "gbConsulta";
            gbConsulta.Size = new Size(573, 271);
            gbConsulta.TabIndex = 21;
            gbConsulta.TabStop = false;
            gbConsulta.Text = "Consulta de Repuestos";
            // 
            // Gestion_de_Repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(gbConsulta);
            Controls.Add(gbxCargaderepuestos);
            Name = "Gestion_de_Repuestos";
            Text = "Gestion de Repuestos";
            Load += Gestion_de_Repuestos_Load;
            gbxCargaderepuestos.ResumeLayout(false);
            gbxCargaderepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbConsulta.ResumeLayout(false);
            gbConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNºderepuesto;
        private Label lblDescripcion;
        private Label lblPrecio;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private GroupBox gbxCargaderepuestos;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLimpiar;
        private Button btnIngresar;
        private CheckBox chkNacional;
        private CheckBox chkImportado;
        private Button btnConsultar;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colRepuesto;
        private DataGridViewTextBoxColumn colOrigen;
        private DataGridViewTextBoxColumn colDescrpcion;
        private DataGridViewTextBoxColumn colPrecio;
        private GroupBox gbConsulta;
    }
}