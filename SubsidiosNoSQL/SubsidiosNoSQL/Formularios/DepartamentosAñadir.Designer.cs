namespace SubsidiosNoSQL.Formularios
{
    partial class DepartamentosAñadir
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
            textBoxDepartamento = new TextBox();
            Ir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 142);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Departamento a añadir";
            // 
            // textBoxDepartamento
            // 
            textBoxDepartamento.Location = new Point(234, 224);
            textBoxDepartamento.Name = "textBoxDepartamento";
            textBoxDepartamento.Size = new Size(295, 31);
            textBoxDepartamento.TabIndex = 1;
            // 
            // Ir
            // 
            Ir.Location = new Point(558, 326);
            Ir.Name = "Ir";
            Ir.Size = new Size(112, 34);
            Ir.TabIndex = 2;
            Ir.Text = "Ir";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // DepartamentosAñadir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ir);
            Controls.Add(textBoxDepartamento);
            Controls.Add(label1);
            Name = "DepartamentosAñadir";
            Text = "DepartamentosAñadir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDepartamento;
        private Button Ir;
    }
}