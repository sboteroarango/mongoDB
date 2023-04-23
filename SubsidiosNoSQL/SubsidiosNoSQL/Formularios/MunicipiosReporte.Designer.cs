namespace SubsidiosNoSQL.Formularios
{
    partial class MunicipiosReporte
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
            listBoxProgramaProgramas = new ListBox();
            label6 = new Label();
            IrProgramas = new Button();
            listBoxMesProgramas = new ListBox();
            listBoxAñoProgramas = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxMunicipios = new ListBox();
            textBoxValorProgramas = new TextBox();
            textBoxCantidadBeneficiariosProgramas = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBoxProgramaProgramas
            // 
            listBoxProgramaProgramas.FormattingEnabled = true;
            listBoxProgramaProgramas.ItemHeight = 25;
            listBoxProgramaProgramas.Location = new Point(199, 350);
            listBoxProgramaProgramas.Name = "listBoxProgramaProgramas";
            listBoxProgramaProgramas.Size = new Size(204, 79);
            listBoxProgramaProgramas.TabIndex = 21;
            listBoxProgramaProgramas.SelectedIndexChanged += listBoxProgramaProgramas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 378);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 20;
            label6.Text = "programa";
            label6.Click += label6_Click;
            // 
            // IrProgramas
            // 
            IrProgramas.Location = new Point(469, 215);
            IrProgramas.Name = "IrProgramas";
            IrProgramas.Size = new Size(64, 33);
            IrProgramas.TabIndex = 19;
            IrProgramas.Text = "Ir";
            IrProgramas.UseVisualStyleBackColor = true;
            IrProgramas.Click += IrProgramas_Click;
            // 
            // listBoxMesProgramas
            // 
            listBoxMesProgramas.FormattingEnabled = true;
            listBoxMesProgramas.ItemHeight = 25;
            listBoxMesProgramas.Location = new Point(55, 149);
            listBoxMesProgramas.Name = "listBoxMesProgramas";
            listBoxMesProgramas.Size = new Size(93, 179);
            listBoxMesProgramas.TabIndex = 18;
            listBoxMesProgramas.SelectedIndexChanged += listBoxMesProgramas_SelectedIndexChanged;
            // 
            // listBoxAñoProgramas
            // 
            listBoxAñoProgramas.FormattingEnabled = true;
            listBoxAñoProgramas.ItemHeight = 25;
            listBoxAñoProgramas.Location = new Point(182, 149);
            listBoxAñoProgramas.Name = "listBoxAñoProgramas";
            listBoxAñoProgramas.Size = new Size(93, 179);
            listBoxAñoProgramas.TabIndex = 17;
            listBoxAñoProgramas.SelectedIndexChanged += listBoxAñoProgramas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 75);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 16;
            label3.Text = "municipio";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 75);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 15;
            label2.Text = "año";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 75);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 14;
            label1.Text = "mes";
            label1.Click += label1_Click;
            // 
            // listBoxMunicipios
            // 
            listBoxMunicipios.FormattingEnabled = true;
            listBoxMunicipios.ItemHeight = 25;
            listBoxMunicipios.Location = new Point(328, 149);
            listBoxMunicipios.Name = "listBoxMunicipios";
            listBoxMunicipios.Size = new Size(108, 179);
            listBoxMunicipios.TabIndex = 13;
            listBoxMunicipios.SelectedIndexChanged += listBoxDepartamentosProgramas_SelectedIndexChanged;
            // 
            // textBoxValorProgramas
            // 
            textBoxValorProgramas.Location = new Point(579, 318);
            textBoxValorProgramas.Name = "textBoxValorProgramas";
            textBoxValorProgramas.Size = new Size(143, 31);
            textBoxValorProgramas.TabIndex = 25;
            // 
            // textBoxCantidadBeneficiariosProgramas
            // 
            textBoxCantidadBeneficiariosProgramas.Location = new Point(579, 143);
            textBoxCantidadBeneficiariosProgramas.Name = "textBoxCantidadBeneficiariosProgramas";
            textBoxCantidadBeneficiariosProgramas.Size = new Size(143, 31);
            textBoxCantidadBeneficiariosProgramas.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 252);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 23;
            label5.Text = "valor total asignado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 75);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 22;
            label4.Text = "cantidad de beneficiarios";
            // 
            // MunicipiosReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxValorProgramas);
            Controls.Add(textBoxCantidadBeneficiariosProgramas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBoxProgramaProgramas);
            Controls.Add(label6);
            Controls.Add(IrProgramas);
            Controls.Add(listBoxMesProgramas);
            Controls.Add(listBoxAñoProgramas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxMunicipios);
            Name = "MunicipiosReporte";
            Text = "MunicipiosReporte";
            Load += MunicipiosReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProgramaProgramas;
        private Label label6;
        private Button IrProgramas;
        private ListBox listBoxMesProgramas;
        private ListBox listBoxAñoProgramas;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBoxMunicipios;
        private TextBox textBoxValorProgramas;
        private TextBox textBoxCantidadBeneficiariosProgramas;
        private Label label5;
        private Label label4;
    }
}