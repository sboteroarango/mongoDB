namespace SubsidiosNoSQL.Formularios
{
    partial class ProgramasActualizar
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
            listBoxProgramasActualizar = new ListBox();
            textBoxActualizarProgramas = new TextBox();
            IrActualizarProgramas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 124);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Programa a actualizar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 124);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "Actualización";
            label2.Click += label2_Click;
            // 
            // listBoxProgramasActualizar
            // 
            listBoxProgramasActualizar.FormattingEnabled = true;
            listBoxProgramasActualizar.ItemHeight = 25;
            listBoxProgramasActualizar.Location = new Point(132, 182);
            listBoxProgramasActualizar.Name = "listBoxProgramasActualizar";
            listBoxProgramasActualizar.Size = new Size(117, 129);
            listBoxProgramasActualizar.TabIndex = 2;
            listBoxProgramasActualizar.SelectedIndexChanged += listBoxProgramasActualizar_SelectedIndexChanged;
            // 
            // textBoxActualizarProgramas
            // 
            textBoxActualizarProgramas.Location = new Point(307, 215);
            textBoxActualizarProgramas.Name = "textBoxActualizarProgramas";
            textBoxActualizarProgramas.Size = new Size(139, 31);
            textBoxActualizarProgramas.TabIndex = 3;
            textBoxActualizarProgramas.TextChanged += textBoxActualizarProgramas_TextChanged;
            // 
            // IrActualizarProgramas
            // 
            IrActualizarProgramas.Location = new Point(497, 212);
            IrActualizarProgramas.Name = "IrActualizarProgramas";
            IrActualizarProgramas.Size = new Size(79, 37);
            IrActualizarProgramas.TabIndex = 4;
            IrActualizarProgramas.Text = "Ir";
            IrActualizarProgramas.UseVisualStyleBackColor = true;
            IrActualizarProgramas.Click += IrActualizarProgramas_Click;
            // 
            // ProgramasActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrActualizarProgramas);
            Controls.Add(textBoxActualizarProgramas);
            Controls.Add(listBoxProgramasActualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProgramasActualizar";
            Text = "ProgramasActualizar";
            Load += ProgramasActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBoxProgramasActualizar;
        private TextBox textBoxActualizarProgramas;
        private Button IrActualizarProgramas;
    }
}