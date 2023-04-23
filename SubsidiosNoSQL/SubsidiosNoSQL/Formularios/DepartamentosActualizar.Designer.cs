namespace SubsidiosNoSQL.Formularios
{
    partial class DepartamentosActualizar
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
            IrActualizarDepartamentos = new Button();
            textBoxActualizarDepartamentos = new TextBox();
            listBoxDepartamentos = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // IrActualizarDepartamentos
            // 
            IrActualizarDepartamentos.Location = new Point(559, 220);
            IrActualizarDepartamentos.Name = "IrActualizarDepartamentos";
            IrActualizarDepartamentos.Size = new Size(79, 37);
            IrActualizarDepartamentos.TabIndex = 14;
            IrActualizarDepartamentos.Text = "Ir";
            IrActualizarDepartamentos.UseVisualStyleBackColor = true;
            IrActualizarDepartamentos.Click += IrActualizarDepartamentos_Click;
            // 
            // textBoxActualizarDepartamentos
            // 
            textBoxActualizarDepartamentos.Location = new Point(369, 223);
            textBoxActualizarDepartamentos.Name = "textBoxActualizarDepartamentos";
            textBoxActualizarDepartamentos.Size = new Size(139, 31);
            textBoxActualizarDepartamentos.TabIndex = 13;
            // 
            // listBoxDepartamentos
            // 
            listBoxDepartamentos.FormattingEnabled = true;
            listBoxDepartamentos.ItemHeight = 25;
            listBoxDepartamentos.Location = new Point(180, 186);
            listBoxDepartamentos.Name = "listBoxDepartamentos";
            listBoxDepartamentos.Size = new Size(159, 179);
            listBoxDepartamentos.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 132);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 11;
            label2.Text = "Actualización";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 132);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 10;
            label1.Text = "Departamento";
            // 
            // DepartamentosActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrActualizarDepartamentos);
            Controls.Add(textBoxActualizarDepartamentos);
            Controls.Add(listBoxDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartamentosActualizar";
            Text = "DepartamentosActualizar";
            Load += DepartamentosActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IrActualizarDepartamentos;
        private TextBox textBoxActualizarDepartamentos;
        private ListBox listBoxDepartamentos;
        private Label label2;
        private Label label1;
    }
}