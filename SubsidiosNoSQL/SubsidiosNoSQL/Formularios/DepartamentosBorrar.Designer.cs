namespace SubsidiosNoSQL.Formularios
{
    partial class DepartamentosBorrar
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
            IrDepartamentosBorrar = new Button();
            listBoxDepartamentos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // IrDepartamentosBorrar
            // 
            IrDepartamentosBorrar.Location = new Point(556, 322);
            IrDepartamentosBorrar.Name = "IrDepartamentosBorrar";
            IrDepartamentosBorrar.Size = new Size(112, 34);
            IrDepartamentosBorrar.TabIndex = 11;
            IrDepartamentosBorrar.Text = "Ir";
            IrDepartamentosBorrar.UseVisualStyleBackColor = true;
            IrDepartamentosBorrar.Click += IrDepartamentosBorrar_Click;
            // 
            // listBoxDepartamentos
            // 
            listBoxDepartamentos.FormattingEnabled = true;
            listBoxDepartamentos.ItemHeight = 25;
            listBoxDepartamentos.Location = new Point(277, 159);
            listBoxDepartamentos.Name = "listBoxDepartamentos";
            listBoxDepartamentos.Size = new Size(206, 154);
            listBoxDepartamentos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 110);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 9;
            label1.Text = "Departamento a borrar";
            // 
            // DepartamentosBorrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrDepartamentosBorrar);
            Controls.Add(listBoxDepartamentos);
            Controls.Add(label1);
            Name = "DepartamentosBorrar";
            Text = "DepartamentosBorrar";
            Load += DepartamentosBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IrDepartamentosBorrar;
        private ListBox listBoxDepartamentos;
        private Label label1;
    }
}