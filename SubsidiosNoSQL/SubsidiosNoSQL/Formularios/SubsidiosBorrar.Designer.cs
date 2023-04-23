namespace SubsidiosNoSQL.Formularios
{
    partial class SubsidiosNoSQLBorrar
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
            label6 = new Label();
            listBoxSubsidiosNoSQL = new ListBox();
            Borrar = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 83);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 16;
            label6.Text = "SubsidiosNoSQL";
            // 
            // listBoxSubsidiosNoSQL
            // 
            listBoxSubsidiosNoSQL.FormattingEnabled = true;
            listBoxSubsidiosNoSQL.ItemHeight = 25;
            listBoxSubsidiosNoSQL.Location = new Point(323, 156);
            listBoxSubsidiosNoSQL.Name = "listBoxSubsidiosNoSQL";
            listBoxSubsidiosNoSQL.Size = new Size(148, 179);
            listBoxSubsidiosNoSQL.TabIndex = 15;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(553, 338);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(143, 49);
            Borrar.TabIndex = 17;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // SubsidiosNoSQLBorrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Borrar);
            Controls.Add(label6);
            Controls.Add(listBoxSubsidiosNoSQL);
            Name = "SubsidiosNoSQLBorrar";
            Text = "SubsidiosNoSQLBorrar";
            Load += SubsidiosNoSQLBorrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ListBox listBoxSubsidiosNoSQL;
        private Button Borrar;
    }
}