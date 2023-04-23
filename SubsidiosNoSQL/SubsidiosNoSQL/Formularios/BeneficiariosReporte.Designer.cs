namespace SubsidiosNoSQL.Formularios
{
    partial class BeneficiariosReporte
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBoxBeneficiarios = new ListBox();
            listBoxMeses = new ListBox();
            listBoxAños = new ListBox();
            listBoxProgramas = new ListBox();
            textBoxValor = new TextBox();
            Ir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 140);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "beneficiario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 146);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 146);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "año";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 146);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "programa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(614, 146);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 4;
            label5.Text = "valor total asignado";
            // 
            // listBoxBeneficiarios
            // 
            listBoxBeneficiarios.FormattingEnabled = true;
            listBoxBeneficiarios.ItemHeight = 25;
            listBoxBeneficiarios.Location = new Point(12, 195);
            listBoxBeneficiarios.Name = "listBoxBeneficiarios";
            listBoxBeneficiarios.Size = new Size(144, 154);
            listBoxBeneficiarios.TabIndex = 5;
            // 
            // listBoxMeses
            // 
            listBoxMeses.FormattingEnabled = true;
            listBoxMeses.ItemHeight = 25;
            listBoxMeses.Location = new Point(270, 211);
            listBoxMeses.Name = "listBoxMeses";
            listBoxMeses.Size = new Size(81, 129);
            listBoxMeses.TabIndex = 6;
            // 
            // listBoxAños
            // 
            listBoxAños.FormattingEnabled = true;
            listBoxAños.ItemHeight = 25;
            listBoxAños.Location = new Point(387, 211);
            listBoxAños.Name = "listBoxAños";
            listBoxAños.Size = new Size(81, 129);
            listBoxAños.TabIndex = 7;
            // 
            // listBoxProgramas
            // 
            listBoxProgramas.FormattingEnabled = true;
            listBoxProgramas.ItemHeight = 25;
            listBoxProgramas.Location = new Point(509, 211);
            listBoxProgramas.Name = "listBoxProgramas";
            listBoxProgramas.Size = new Size(81, 129);
            listBoxProgramas.TabIndex = 8;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(625, 211);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(140, 31);
            textBoxValor.TabIndex = 9;
            // 
            // Ir
            // 
            Ir.Location = new Point(165, 249);
            Ir.Name = "Ir";
            Ir.Size = new Size(86, 29);
            Ir.TabIndex = 10;
            Ir.Text = "Ir";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // BeneficiariosReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ir);
            Controls.Add(textBoxValor);
            Controls.Add(listBoxProgramas);
            Controls.Add(listBoxAños);
            Controls.Add(listBoxMeses);
            Controls.Add(listBoxBeneficiarios);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BeneficiariosReporte";
            Text = "BeneficiariosReporte";
            Load += BeneficiariosReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBoxBeneficiarios;
        private ListBox listBoxMeses;
        private ListBox listBoxAños;
        private ListBox listBoxProgramas;
        private TextBox textBoxValor;
        private Button Ir;
    }
}