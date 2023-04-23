namespace SubsidiosNoSQL.Formularios
{
    partial class MunicipiosActualizar
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
            IrActualizarProgramas = new Button();
            textBoxActualizarMunicipios = new TextBox();
            listBoxMunicipios = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // IrActualizarProgramas
            // 
            IrActualizarProgramas.Location = new Point(559, 220);
            IrActualizarProgramas.Name = "IrActualizarProgramas";
            IrActualizarProgramas.Size = new Size(79, 37);
            IrActualizarProgramas.TabIndex = 9;
            IrActualizarProgramas.Text = "Ir";
            IrActualizarProgramas.UseVisualStyleBackColor = true;
            IrActualizarProgramas.Click += IrActualizarProgramas_Click;
            // 
            // textBoxActualizarMunicipios
            // 
            textBoxActualizarMunicipios.Location = new Point(369, 223);
            textBoxActualizarMunicipios.Name = "textBoxActualizarMunicipios";
            textBoxActualizarMunicipios.Size = new Size(139, 31);
            textBoxActualizarMunicipios.TabIndex = 8;
            textBoxActualizarMunicipios.TextChanged += textBoxActualizarMunicipios_TextChanged;
            // 
            // listBoxMunicipios
            // 
            listBoxMunicipios.FormattingEnabled = true;
            listBoxMunicipios.ItemHeight = 25;
            listBoxMunicipios.Location = new Point(194, 190);
            listBoxMunicipios.Name = "listBoxMunicipios";
            listBoxMunicipios.Size = new Size(117, 129);
            listBoxMunicipios.TabIndex = 7;
            listBoxMunicipios.SelectedIndexChanged += listBoxMunicipios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 132);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 6;
            label2.Text = "Actualización";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 132);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 5;
            label1.Text = "Municipio a actualizar";
            label1.Click += label1_Click;
            // 
            // MunicipiosActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrActualizarProgramas);
            Controls.Add(textBoxActualizarMunicipios);
            Controls.Add(listBoxMunicipios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MunicipiosActualizar";
            Text = "MunicipiosActualizar";
            Load += MunicipiosActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IrActualizarProgramas;
        private TextBox textBoxActualizarMunicipios;
        private ListBox listBoxMunicipios;
        private Label label2;
        private Label label1;
    }
}