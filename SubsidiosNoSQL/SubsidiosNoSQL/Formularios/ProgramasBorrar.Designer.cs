namespace SubsidiosNoSQL.Formularios
{
    partial class ProgramasBorrar
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
            listBoxProgramasBorrar = new ListBox();
            label1 = new Label();
            IrProgramasBorrar = new Button();
            SuspendLayout();
            // 
            // listBoxProgramasBorrar
            // 
            listBoxProgramasBorrar.FormattingEnabled = true;
            listBoxProgramasBorrar.ItemHeight = 25;
            listBoxProgramasBorrar.Location = new Point(322, 169);
            listBoxProgramasBorrar.Name = "listBoxProgramasBorrar";
            listBoxProgramasBorrar.Size = new Size(145, 129);
            listBoxProgramasBorrar.TabIndex = 4;
            listBoxProgramasBorrar.SelectedIndexChanged += listBoxProgramasBorrar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 114);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 3;
            label1.Text = "Programa a borrar";
            label1.Click += label1_Click;
            // 
            // IrProgramasBorrar
            // 
            IrProgramasBorrar.Location = new Point(576, 326);
            IrProgramasBorrar.Name = "IrProgramasBorrar";
            IrProgramasBorrar.Size = new Size(112, 34);
            IrProgramasBorrar.TabIndex = 5;
            IrProgramasBorrar.Text = "Ir";
            IrProgramasBorrar.UseVisualStyleBackColor = true;
            IrProgramasBorrar.Click += IrProgramasBorrar_Click;
            // 
            // ProgramasBorrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrProgramasBorrar);
            Controls.Add(listBoxProgramasBorrar);
            Controls.Add(label1);
            Name = "ProgramasBorrar";
            Text = "ProgramasBorrar";
            Load += ProgramasBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProgramasBorrar;
        private Label label1;
        private Button IrProgramasBorrar;
    }
}