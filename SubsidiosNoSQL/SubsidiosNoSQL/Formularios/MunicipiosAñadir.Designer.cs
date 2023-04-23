namespace SubsidiosNoSQL.Formularios
{
    partial class MunicipiosAñadir
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
            IrAñadirProgramas = new Button();
            textBoxMunicipiosAñadir = new TextBox();
            label1 = new Label();
            textBoxIdMunicipio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listBoxDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // IrAñadirProgramas
            // 
            IrAñadirProgramas.Location = new Point(617, 382);
            IrAñadirProgramas.Name = "IrAñadirProgramas";
            IrAñadirProgramas.Size = new Size(112, 34);
            IrAñadirProgramas.TabIndex = 5;
            IrAñadirProgramas.Text = "Ir";
            IrAñadirProgramas.UseVisualStyleBackColor = true;
            IrAñadirProgramas.Click += IrAñadirProgramas_Click;
            // 
            // textBoxMunicipiosAñadir
            // 
            textBoxMunicipiosAñadir.Location = new Point(50, 205);
            textBoxMunicipiosAñadir.Name = "textBoxMunicipiosAñadir";
            textBoxMunicipiosAñadir.Size = new Size(260, 31);
            textBoxMunicipiosAñadir.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 137);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 3;
            label1.Text = "Municipio a añadir";
            // 
            // textBoxIdMunicipio
            // 
            textBoxIdMunicipio.Location = new Point(50, 343);
            textBoxIdMunicipio.Name = "textBoxIdMunicipio";
            textBoxIdMunicipio.Size = new Size(260, 31);
            textBoxIdMunicipio.TabIndex = 7;
            textBoxIdMunicipio.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 276);
            label2.Name = "label2";
            label2.Size = new Size(227, 25);
            label2.TabIndex = 6;
            label2.Text = "Código dane del municipio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 52);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 8;
            label3.Text = "Departamento";
            // 
            // listBoxDepartamentos
            // 
            listBoxDepartamentos.FormattingEnabled = true;
            listBoxDepartamentos.ItemHeight = 25;
            listBoxDepartamentos.Location = new Point(435, 110);
            listBoxDepartamentos.Name = "listBoxDepartamentos";
            listBoxDepartamentos.Size = new Size(267, 229);
            listBoxDepartamentos.TabIndex = 9;
            // 
            // MunicipiosAñadir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDepartamentos);
            Controls.Add(label3);
            Controls.Add(textBoxIdMunicipio);
            Controls.Add(label2);
            Controls.Add(IrAñadirProgramas);
            Controls.Add(textBoxMunicipiosAñadir);
            Controls.Add(label1);
            Name = "MunicipiosAñadir";
            Text = "MunicipiosAñadir";
            Load += MunicipiosAñadir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IrAñadirProgramas;
        private TextBox textBoxMunicipiosAñadir;
        private Label label1;
        private TextBox textBoxIdMunicipio;
        private Label label2;
        private Label label3;
        private ListBox listBoxDepartamentos;
    }
}