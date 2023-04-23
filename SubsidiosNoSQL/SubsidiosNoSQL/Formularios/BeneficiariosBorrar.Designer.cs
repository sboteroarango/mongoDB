namespace SubsidiosNoSQL.Formularios
{
    partial class BeneficiariosBorrar
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
            listBoxBeneficiarios = new ListBox();
            Ir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 131);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "beneficiarios";
            // 
            // listBoxBeneficiarios
            // 
            listBoxBeneficiarios.FormattingEnabled = true;
            listBoxBeneficiarios.ItemHeight = 25;
            listBoxBeneficiarios.Location = new Point(222, 175);
            listBoxBeneficiarios.Name = "listBoxBeneficiarios";
            listBoxBeneficiarios.Size = new Size(149, 229);
            listBoxBeneficiarios.TabIndex = 1;
            // 
            // Ir
            // 
            Ir.Location = new Point(468, 233);
            Ir.Name = "Ir";
            Ir.Size = new Size(116, 51);
            Ir.TabIndex = 2;
            Ir.Text = "Borrar";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // BeneficiariosBorrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 512);
            Controls.Add(Ir);
            Controls.Add(listBoxBeneficiarios);
            Controls.Add(label1);
            Name = "BeneficiariosBorrar";
            Text = "BeneficiariosBorrar";
            Load += BeneficiariosBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxBeneficiarios;
        private Button Ir;
    }
}