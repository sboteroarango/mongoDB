namespace SubsidiosNoSQL.Formularios
{
    partial class SubsidiosNoSQLActualizar
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
            label6 = new Label();
            listBoxSubsidiosNoSQL = new ListBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxValor = new TextBox();
            listBoxMeses = new ListBox();
            listBoxAños = new ListBox();
            listBoxProgramas = new ListBox();
            listBoxBeneficiarios = new ListBox();
            label4 = new Label();
            Actualizar = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 110);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 14;
            label6.Text = "SubsidiosNoSQL";
            // 
            // listBoxSubsidiosNoSQL
            // 
            listBoxSubsidiosNoSQL.FormattingEnabled = true;
            listBoxSubsidiosNoSQL.ItemHeight = 25;
            listBoxSubsidiosNoSQL.Location = new Point(81, 166);
            listBoxSubsidiosNoSQL.Name = "listBoxSubsidiosNoSQL";
            listBoxSubsidiosNoSQL.Size = new Size(102, 179);
            listBoxSubsidiosNoSQL.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 284);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 24;
            label5.Text = "valor total asignado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 199);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 22;
            label3.Text = "programa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 122);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 21;
            label2.Text = "año";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 44);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 20;
            label1.Text = "mes";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(247, 314);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(183, 31);
            textBoxValor.TabIndex = 19;
            // 
            // listBoxMeses
            // 
            listBoxMeses.FormattingEnabled = true;
            listBoxMeses.ItemHeight = 25;
            listBoxMeses.Location = new Point(247, 72);
            listBoxMeses.Name = "listBoxMeses";
            listBoxMeses.Size = new Size(183, 54);
            listBoxMeses.TabIndex = 25;
            // 
            // listBoxAños
            // 
            listBoxAños.FormattingEnabled = true;
            listBoxAños.ItemHeight = 25;
            listBoxAños.Location = new Point(247, 150);
            listBoxAños.Name = "listBoxAños";
            listBoxAños.Size = new Size(183, 54);
            listBoxAños.TabIndex = 26;
            // 
            // listBoxProgramas
            // 
            listBoxProgramas.FormattingEnabled = true;
            listBoxProgramas.ItemHeight = 25;
            listBoxProgramas.Location = new Point(247, 227);
            listBoxProgramas.Name = "listBoxProgramas";
            listBoxProgramas.Size = new Size(183, 54);
            listBoxProgramas.TabIndex = 27;
            // 
            // listBoxBeneficiarios
            // 
            listBoxBeneficiarios.FormattingEnabled = true;
            listBoxBeneficiarios.ItemHeight = 25;
            listBoxBeneficiarios.Location = new Point(247, 377);
            listBoxBeneficiarios.Name = "listBoxBeneficiarios";
            listBoxBeneficiarios.Size = new Size(183, 29);
            listBoxBeneficiarios.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 349);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 30;
            label4.Text = "beneficiario";
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(557, 323);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(125, 43);
            Actualizar.TabIndex = 32;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 9);
            label7.Name = "label7";
            label7.Size = new Size(173, 25);
            label7.TabIndex = 33;
            label7.Text = "variables a actualizar";
            // 
            // SubsidiosNoSQLActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(Actualizar);
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
            Controls.Add(label6);
            Controls.Add(listBoxSubsidiosNoSQL);
            Name = "SubsidiosNoSQLActualizar";
            Text = "SubsidiosNoSQLActualizar";
            Load += SubsidiosNoSQLActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ListBox listBoxSubsidiosNoSQL;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxValor;
        private ListBox listBoxMeses;
        private ListBox listBoxAños;
        private ListBox listBoxProgramas;
        private ListBox listBoxBeneficiarios;
        private Label label4;
        private Button button1;
        private Button Actualizar;
        private Label label7;
    }
}