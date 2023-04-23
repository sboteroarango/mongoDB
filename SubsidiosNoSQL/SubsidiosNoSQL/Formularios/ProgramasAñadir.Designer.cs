namespace SubsidiosNoSQL.Formularios
{
    partial class ProgramasAñadir
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
            textBoxProgramasAñadir = new TextBox();
            IrAñadirProgramas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 139);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Programa a añadir";
            label1.Click += label1_Click;
            // 
            // textBoxProgramasAñadir
            // 
            textBoxProgramasAñadir.Location = new Point(262, 207);
            textBoxProgramasAñadir.Name = "textBoxProgramasAñadir";
            textBoxProgramasAñadir.Size = new Size(260, 31);
            textBoxProgramasAñadir.TabIndex = 1;
            textBoxProgramasAñadir.TextChanged += textBoxProgramasAñadir_TextChanged;
            // 
            // IrAñadirProgramas
            // 
            IrAñadirProgramas.Location = new Point(614, 367);
            IrAñadirProgramas.Name = "IrAñadirProgramas";
            IrAñadirProgramas.Size = new Size(112, 34);
            IrAñadirProgramas.TabIndex = 2;
            IrAñadirProgramas.Text = "Ir";
            IrAñadirProgramas.UseVisualStyleBackColor = true;
            IrAñadirProgramas.Click += IrAñadirProgramas_Click_1;
            // 
            // ProgramasAñadir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrAñadirProgramas);
            Controls.Add(textBoxProgramasAñadir);
            Controls.Add(label1);
            Name = "ProgramasAñadir";
            Text = "Añadir Programas";
            Load += ProgramasAñadir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxProgramasAñadir;
        private Button IrAñadirProgramas;
    }
}