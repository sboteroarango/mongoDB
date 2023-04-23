namespace SubsidiosNoSQLNoSQL.Formularios
{
    partial class Principal
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
            listBoxIdentidades = new ListBox();
            listBoxAcciones = new ListBox();
            label1 = new Label();
            Ir = new Button();
            SuspendLayout();
            // 
            // listBoxIdentidades
            // 
            listBoxIdentidades.FormattingEnabled = true;
            listBoxIdentidades.ItemHeight = 25;
            listBoxIdentidades.Items.AddRange(new object[] { "Programas", "SubsidiosNoSQL", "Beneficiarios", "Municipios", "Departamentos" });
            listBoxIdentidades.Location = new Point(212, 231);
            listBoxIdentidades.Name = "listBoxIdentidades";
            listBoxIdentidades.Size = new Size(143, 154);
            listBoxIdentidades.TabIndex = 0;
            listBoxIdentidades.SelectedIndexChanged += listBoxIdentidades_SelectedIndexChanged;
            // 
            // listBoxAcciones
            // 
            listBoxAcciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxAcciones.FormattingEnabled = true;
            listBoxAcciones.ItemHeight = 25;
            listBoxAcciones.Items.AddRange(new object[] { "Reporte", "Actualizar", "Borrar", "Añadir" });
            listBoxAcciones.Location = new Point(534, 231);
            listBoxAcciones.Name = "listBoxAcciones";
            listBoxAcciones.Size = new Size(147, 154);
            listBoxAcciones.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(311, 113);
            label1.Name = "label1";
            label1.Size = new Size(317, 38);
            label1.TabIndex = 2;
            label1.Text = "Programas De SubsidiosNoSQL";
            label1.Click += label1_Click;
            // 
            // Ir
            // 
            Ir.Location = new Point(720, 478);
            Ir.Name = "Ir";
            Ir.Size = new Size(112, 34);
            Ir.TabIndex = 3;
            Ir.Text = "Ir";
            Ir.UseVisualStyleBackColor = true;
            Ir.Click += Ir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 595);
            Controls.Add(Ir);
            Controls.Add(label1);
            Controls.Add(listBoxAcciones);
            Controls.Add(listBoxIdentidades);
            Name = "Principal";
            Text = "SubsidiosNoSQLNoSQL";
            Load += Principal_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxIdentidades;
        private ListBox listBoxAcciones;
        private Label label1;
        private Button Ir;
    }
}