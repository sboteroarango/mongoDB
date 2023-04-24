namespace SubsidiosNoSQL.Formularios
{
    partial class SubsidiosReporte
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
            listBoxSubsidios = new ListBox();
            textBoxMes = new TextBox();
            Ir = new Button();
            textBoxAño = new TextBox();
            textBoxPrograma = new TextBox();
            textBoxCantidadBeneficiarios = new TextBox();
            textBoxValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // listBoxSubsidios
            // 
            listBoxSubsidios.FormattingEnabled = true;
            listBoxSubsidios.ItemHeight = 25;
            listBoxSubsidios.Location = new Point(63, 176);
            listBoxSubsidios.Name = "listBoxSubsidios";
            listBoxSubsidios.Size = new Size(102, 179);
            listBoxSubsidios.TabIndex = 0;
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(459, 70);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(136, 31);
            textBoxMes.TabIndex = 1;
            // 
            // Ir
            // 
            Ir.Location = new Point(201, 225);
            Ir.Name = "Ir";
            Ir.Size = new Size(87, 56);
            Ir.TabIndex = 2;
            Ir.Text = "Ir";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // textBoxAño
            // 
            textBoxAño.Location = new Point(459, 148);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new Size(136, 31);
            textBoxAño.TabIndex = 3;
            // 
            // textBoxPrograma
            // 
            textBoxPrograma.Location = new Point(459, 225);
            textBoxPrograma.Name = "textBoxPrograma";
            textBoxPrograma.Size = new Size(136, 31);
            textBoxPrograma.TabIndex = 4;
            // 
            // textBoxCantidadBeneficiarios
            // 
            textBoxCantidadBeneficiarios.Location = new Point(459, 302);
            textBoxCantidadBeneficiarios.Name = "textBoxCantidadBeneficiarios";
            textBoxCantidadBeneficiarios.Size = new Size(136, 31);
            textBoxCantidadBeneficiarios.TabIndex = 5;
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(459, 375);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(136, 31);
            textBoxValor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 42);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 7;
            label1.Text = "mes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 120);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 8;
            label2.Text = "año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 197);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 9;
            label3.Text = "programa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 274);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 10;
            label4.Text = "cantidad de beneficiarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 347);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 11;
            label5.Text = "valor total asignado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 120);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 12;
            label6.Text = "Subsidios";
            // 
            // SubsidiosReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxValor);
            Controls.Add(textBoxCantidadBeneficiarios);
            Controls.Add(textBoxPrograma);
            Controls.Add(textBoxAño);
            Controls.Add(Ir);
            Controls.Add(textBoxMes);
            Controls.Add(listBoxSubsidios);
            Name = "SubsidiosReporte";
            Text = "Reporte de Subsidios";
            Load += SubsidiosReporte_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSubsidios;
        private TextBox textBoxMes;
        private Button Ir;
        private TextBox textBoxAño;
        private TextBox textBoxPrograma;
        private TextBox textBoxCantidadBeneficiarios;
        private TextBox textBoxValor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}