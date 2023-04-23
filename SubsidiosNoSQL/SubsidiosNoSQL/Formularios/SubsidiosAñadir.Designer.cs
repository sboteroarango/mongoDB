namespace SubsidiosNoSQL.Formularios
{
    partial class SubsidiosNoSQLAñadir
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
            label4 = new Label();
            listBoxBeneficiarios = new ListBox();
            listBoxProgramas = new ListBox();
            listBoxAños = new ListBox();
            listBoxMeses = new ListBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxValor = new TextBox();
            Añadir = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 275);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 40;
            label4.Text = "beneficiario";
            // 
            // listBoxBeneficiarios
            // 
            listBoxBeneficiarios.FormattingEnabled = true;
            listBoxBeneficiarios.ItemHeight = 25;
            listBoxBeneficiarios.Location = new Point(262, 317);
            listBoxBeneficiarios.Name = "listBoxBeneficiarios";
            listBoxBeneficiarios.Size = new Size(197, 104);
            listBoxBeneficiarios.TabIndex = 39;
            // 
            // listBoxProgramas
            // 
            listBoxProgramas.FormattingEnabled = true;
            listBoxProgramas.ItemHeight = 25;
            listBoxProgramas.Location = new Point(262, 84);
            listBoxProgramas.Name = "listBoxProgramas";
            listBoxProgramas.Size = new Size(201, 79);
            listBoxProgramas.TabIndex = 38;
            // 
            // listBoxAños
            // 
            listBoxAños.FormattingEnabled = true;
            listBoxAños.ItemHeight = 25;
            listBoxAños.Location = new Point(12, 255);
            listBoxAños.Name = "listBoxAños";
            listBoxAños.Size = new Size(194, 104);
            listBoxAños.TabIndex = 37;
            // 
            // listBoxMeses
            // 
            listBoxMeses.FormattingEnabled = true;
            listBoxMeses.ItemHeight = 25;
            listBoxMeses.Location = new Point(12, 84);
            listBoxMeses.Name = "listBoxMeses";
            listBoxMeses.Size = new Size(194, 104);
            listBoxMeses.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 180);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 35;
            label5.Text = "valor total asignado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 39);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 34;
            label3.Text = "programa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 214);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 33;
            label2.Text = "año";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 32;
            label1.Text = "mes";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(276, 224);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(183, 31);
            textBoxValor.TabIndex = 31;
            // 
            // Añadir
            // 
            Añadir.Location = new Point(539, 214);
            Añadir.Name = "Añadir";
            Añadir.Size = new Size(92, 48);
            Añadir.TabIndex = 41;
            Añadir.Text = "Añadir";
            Añadir.UseVisualStyleBackColor = true;
            Añadir.Click += Añadir_Click;
            // 
            // SubsidiosNoSQLAñadir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Añadir);
            Controls.Add(label4);
            Controls.Add(listBoxBeneficiarios);
            Controls.Add(listBoxProgramas);
            Controls.Add(listBoxAños);
            Controls.Add(listBoxMeses);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxValor);
            Name = "SubsidiosNoSQLAñadir";
            Text = "SubsidiosNoSQLAñadir";
            Load += SubsidiosNoSQLAñadir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ListBox listBoxBeneficiarios;
        private ListBox listBoxProgramas;
        private ListBox listBoxAños;
        private ListBox listBoxMeses;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxValor;
        private Button Añadir;
    }
}