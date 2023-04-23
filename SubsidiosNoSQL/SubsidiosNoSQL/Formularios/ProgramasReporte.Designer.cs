namespace SubsidiosNoSQLNoSQL.Formularios
{
    partial class ProgramasReporte
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
            listBoxDepartamentosProgramas = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBoxAñoProgramas = new ListBox();
            listBoxMesProgramas = new ListBox();
            textBoxCantidadBeneficiariosProgramas = new TextBox();
            textBoxValorProgramas = new TextBox();
            IrProgramas = new Button();
            label6 = new Label();
            listBoxProgramaProgramas = new ListBox();
            SuspendLayout();
            // 
            // listBoxDepartamentosProgramas
            // 
            listBoxDepartamentosProgramas.FormattingEnabled = true;
            listBoxDepartamentosProgramas.ItemHeight = 25;
            listBoxDepartamentosProgramas.Location = new Point(294, 171);
            listBoxDepartamentosProgramas.Name = "listBoxDepartamentosProgramas";
            listBoxDepartamentosProgramas.Size = new Size(108, 179);
            listBoxDepartamentosProgramas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 97);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 1;
            label1.Text = "mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 2;
            label2.Text = "año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 97);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 3;
            label3.Text = "departamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(541, 97);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 4;
            label4.Text = "cantidad de beneficiarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 274);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 5;
            label5.Text = "valor total asignado";
            // 
            // listBoxAñoProgramas
            // 
            listBoxAñoProgramas.FormattingEnabled = true;
            listBoxAñoProgramas.ItemHeight = 25;
            listBoxAñoProgramas.Location = new Point(148, 171);
            listBoxAñoProgramas.Name = "listBoxAñoProgramas";
            listBoxAñoProgramas.Size = new Size(93, 179);
            listBoxAñoProgramas.TabIndex = 6;
            listBoxAñoProgramas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxMesProgramas
            // 
            listBoxMesProgramas.FormattingEnabled = true;
            listBoxMesProgramas.ItemHeight = 25;
            listBoxMesProgramas.Location = new Point(21, 171);
            listBoxMesProgramas.Name = "listBoxMesProgramas";
            listBoxMesProgramas.Size = new Size(93, 179);
            listBoxMesProgramas.TabIndex = 7;
            // 
            // textBoxCantidadBeneficiariosProgramas
            // 
            textBoxCantidadBeneficiariosProgramas.Location = new Point(566, 165);
            textBoxCantidadBeneficiariosProgramas.Name = "textBoxCantidadBeneficiariosProgramas";
            textBoxCantidadBeneficiariosProgramas.Size = new Size(143, 31);
            textBoxCantidadBeneficiariosProgramas.TabIndex = 8;
            // 
            // textBoxValorProgramas
            // 
            textBoxValorProgramas.Location = new Point(566, 340);
            textBoxValorProgramas.Name = "textBoxValorProgramas";
            textBoxValorProgramas.Size = new Size(143, 31);
            textBoxValorProgramas.TabIndex = 9;
            // 
            // IrProgramas
            // 
            IrProgramas.Location = new Point(435, 237);
            IrProgramas.Name = "IrProgramas";
            IrProgramas.Size = new Size(64, 33);
            IrProgramas.TabIndex = 10;
            IrProgramas.Text = "Ir";
            IrProgramas.UseVisualStyleBackColor = true;
            IrProgramas.Click += IrProgramas_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 400);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 11;
            label6.Text = "programa";
            // 
            // listBoxProgramaProgramas
            // 
            listBoxProgramaProgramas.FormattingEnabled = true;
            listBoxProgramaProgramas.ItemHeight = 25;
            listBoxProgramaProgramas.Location = new Point(165, 372);
            listBoxProgramaProgramas.Name = "listBoxProgramaProgramas";
            listBoxProgramaProgramas.Size = new Size(204, 79);
            listBoxProgramaProgramas.TabIndex = 12;
            // 
            // ProgramasReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 474);
            Controls.Add(listBoxProgramaProgramas);
            Controls.Add(label6);
            Controls.Add(IrProgramas);
            Controls.Add(textBoxValorProgramas);
            Controls.Add(textBoxCantidadBeneficiariosProgramas);
            Controls.Add(listBoxMesProgramas);
            Controls.Add(listBoxAñoProgramas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxDepartamentosProgramas);
            Name = "ProgramasReporte";
            Text = "Reporte";
            Load += ProgramasReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDepartamentosProgramas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBoxAñoProgramas;
        private ListBox listBoxMesProgramas;
        private TextBox textBoxCantidadBeneficiariosProgramas;
        private TextBox textBoxValorProgramas;
        private Button IrProgramas;
        private Label label6;
        private ListBox listBoxProgramaProgramas;
    }
}