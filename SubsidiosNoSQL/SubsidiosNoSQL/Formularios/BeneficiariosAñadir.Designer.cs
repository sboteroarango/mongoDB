namespace SubsidiosNoSQL.Formularios
{
    partial class BeneficiariosAñadir
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
            textBoxBeneficiario = new TextBox();
            municipio = new Label();
            listBoxMunicipios = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 80);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Id del beneficiario";
            // 
            // textBoxBeneficiario
            // 
            textBoxBeneficiario.Location = new Point(98, 140);
            textBoxBeneficiario.Name = "textBoxBeneficiario";
            textBoxBeneficiario.Size = new Size(274, 31);
            textBoxBeneficiario.TabIndex = 1;
            // 
            // municipio
            // 
            municipio.AutoSize = true;
            municipio.Location = new Point(182, 195);
            municipio.Name = "municipio";
            municipio.Size = new Size(90, 25);
            municipio.TabIndex = 2;
            municipio.Text = "municipio";
            // 
            // listBoxMunicipios
            // 
            listBoxMunicipios.FormattingEnabled = true;
            listBoxMunicipios.ItemHeight = 25;
            listBoxMunicipios.Location = new Point(98, 246);
            listBoxMunicipios.Name = "listBoxMunicipios";
            listBoxMunicipios.Size = new Size(274, 129);
            listBoxMunicipios.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(467, 209);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 4;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // BeneficiariosAñadir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBoxMunicipios);
            Controls.Add(municipio);
            Controls.Add(textBoxBeneficiario);
            Controls.Add(label1);
            Name = "BeneficiariosAñadir";
            Text = "BeneficiariosAñadir";
            Load += BeneficiariosAñadir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxBeneficiario;
        private Label municipio;
        private ListBox listBoxMunicipios;
        private Button button1;
    }
}