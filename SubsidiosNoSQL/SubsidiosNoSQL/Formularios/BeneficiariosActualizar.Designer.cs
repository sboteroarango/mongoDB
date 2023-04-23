namespace SubsidiosNoSQL.Formularios
{
    partial class BeneficiariosActualizar
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
            listBoxBeneficiarios = new ListBox();
            beneficiarios = new Label();
            IrActualizarProgramas = new Button();
            textBoxActualizar = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxBeneficiarios
            // 
            listBoxBeneficiarios.FormattingEnabled = true;
            listBoxBeneficiarios.ItemHeight = 25;
            listBoxBeneficiarios.Location = new Point(105, 162);
            listBoxBeneficiarios.Name = "listBoxBeneficiarios";
            listBoxBeneficiarios.Size = new Size(202, 204);
            listBoxBeneficiarios.TabIndex = 0;
            // 
            // beneficiarios
            // 
            beneficiarios.AutoSize = true;
            beneficiarios.Location = new Point(141, 109);
            beneficiarios.Name = "beneficiarios";
            beneficiarios.Size = new Size(111, 25);
            beneficiarios.TabIndex = 1;
            beneficiarios.Text = "beneficiarios";
            // 
            // IrActualizarProgramas
            // 
            IrActualizarProgramas.Location = new Point(533, 197);
            IrActualizarProgramas.Name = "IrActualizarProgramas";
            IrActualizarProgramas.Size = new Size(79, 37);
            IrActualizarProgramas.TabIndex = 7;
            IrActualizarProgramas.Text = "Ir";
            IrActualizarProgramas.UseVisualStyleBackColor = true;
            IrActualizarProgramas.Click += IrActualizarProgramas_Click;
            // 
            // textBoxActualizar
            // 
            textBoxActualizar.Location = new Point(343, 200);
            textBoxActualizar.Name = "textBoxActualizar";
            textBoxActualizar.Size = new Size(139, 31);
            textBoxActualizar.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 109);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 5;
            label2.Text = "Actualización";
            // 
            // BeneficiariosActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrActualizarProgramas);
            Controls.Add(textBoxActualizar);
            Controls.Add(label2);
            Controls.Add(beneficiarios);
            Controls.Add(listBoxBeneficiarios);
            Name = "BeneficiariosActualizar";
            Text = "BeneficiariosActualizar";
            Load += BeneficiariosActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBeneficiarios;
        private Label beneficiarios;
        private Button IrActualizarProgramas;
        private TextBox textBoxActualizar;
        private Label label2;
    }
}