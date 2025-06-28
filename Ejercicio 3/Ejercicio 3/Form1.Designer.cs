namespace Ejercicio_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbDesde = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbPara = new ComboBox();
            btnConvertir = new Button();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // cbDesde
            // 
            cbDesde.FormattingEnabled = true;
            cbDesde.Items.AddRange(new object[] { "Metro", "Centimetro", "Pulgada" });
            cbDesde.Location = new Point(76, 72);
            cbDesde.Name = "cbDesde";
            cbDesde.Size = new Size(121, 23);
            cbDesde.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 128);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Para";
            // 
            // cbPara
            // 
            cbPara.FormattingEnabled = true;
            cbPara.Items.AddRange(new object[] { "Metro", "Centimetro", "Pulgada" });
            cbPara.Location = new Point(76, 146);
            cbPara.Name = "cbPara";
            cbPara.Size = new Size(121, 23);
            cbPara.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(282, 146);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(269, 105);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 251);
            Controls.Add(txtValor);
            Controls.Add(btnConvertir);
            Controls.Add(label2);
            Controls.Add(cbPara);
            Controls.Add(label1);
            Controls.Add(cbDesde);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDesde;
        private Label label1;
        private Label label2;
        private ComboBox cbPara;
        private Button btnConvertir;
        private TextBox txtValor;
    }
}
