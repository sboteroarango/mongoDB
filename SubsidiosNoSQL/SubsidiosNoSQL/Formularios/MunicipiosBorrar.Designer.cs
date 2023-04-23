namespace SubsidiosNoSQL.Formularios
{
    partial class MunicipiosBorrar
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
            IrProgramasBorrar = new Button();
            listBoxMunicipios = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // IrProgramasBorrar
            // 
            IrProgramasBorrar.Location = new Point(554, 335);
            IrProgramasBorrar.Name = "IrProgramasBorrar";
            IrProgramasBorrar.Size = new Size(112, 34);
            IrProgramasBorrar.TabIndex = 8;
            IrProgramasBorrar.Text = "Ir";
            IrProgramasBorrar.UseVisualStyleBackColor = true;
            IrProgramasBorrar.Click += IrProgramasBorrar_Click;
            // 
            // listBoxMunicipios
            // 
            listBoxMunicipios.FormattingEnabled = true;
            listBoxMunicipios.ItemHeight = 25;
            listBoxMunicipios.Location = new Point(275, 172);
            listBoxMunicipios.Name = "listBoxMunicipios";
            listBoxMunicipios.Size = new Size(206, 154);
            listBoxMunicipios.TabIndex = 7;
            listBoxMunicipios.SelectedIndexChanged += listBoxProgramasBorrar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 123);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 6;
            label1.Text = "Municipio a borrar";
            // 
            // MunicipiosBorrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IrProgramasBorrar);
            Controls.Add(listBoxMunicipios);
            Controls.Add(label1);
            Name = "MunicipiosBorrar";
            Text = "MunicipiosBorrar";
            Load += MunicipiosBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IrProgramasBorrar;
        private ListBox listBoxMunicipios;
        private Label label1;
    }
}