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
            gbxCargaderepuestos.SuspendLayout();
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
            // Gestion_de_Repuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxCargaderepuestos);
            Name = "Gestion_de_Repuestos";
            Text = "Gestion de Repuestos";
            gbxCargaderepuestos.ResumeLayout(false);
            gbxCargaderepuestos.PerformLayout();
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
    }
}