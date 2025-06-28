namespace Ejercicio_2
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
            components = new System.ComponentModel.Container();
            Hora = new ComboBox();
            Minuto = new ComboBox();
            Segundo = new ComboBox();
            Temporizador = new Label();
            Iniciar = new Button();
            Detener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Hora
            // 
            Hora.FormattingEnabled = true;
            Hora.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            Hora.Location = new Point(171, 69);
            Hora.Name = "Hora";
            Hora.Size = new Size(121, 23);
            Hora.TabIndex = 0;
            // 
            // Minuto
            // 
            Minuto.FormattingEnabled = true;
            Minuto.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            Minuto.Location = new Point(298, 69);
            Minuto.Name = "Minuto";
            Minuto.Size = new Size(121, 23);
            Minuto.TabIndex = 1;
            // 
            // Segundo
            // 
            Segundo.FormattingEnabled = true;
            Segundo.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            Segundo.Location = new Point(425, 69);
            Segundo.Name = "Segundo";
            Segundo.Size = new Size(121, 23);
            Segundo.TabIndex = 2;
            // 
            // Temporizador
            // 
            Temporizador.AutoSize = true;
            Temporizador.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Temporizador.Location = new Point(283, 144);
            Temporizador.Name = "Temporizador";
            Temporizador.Size = new Size(158, 47);
            Temporizador.TabIndex = 3;
            Temporizador.Text = "00:00:00";
            // 
            // Iniciar
            // 
            Iniciar.Location = new Point(217, 228);
            Iniciar.Name = "Iniciar";
            Iniciar.Size = new Size(75, 23);
            Iniciar.TabIndex = 4;
            Iniciar.Text = "Iniciar";
            Iniciar.UseVisualStyleBackColor = true;
            Iniciar.Click += Iniciar_Click;
            // 
            // Detener
            // 
            Detener.Location = new Point(434, 228);
            Detener.Name = "Detener";
            Detener.Size = new Size(75, 23);
            Detener.TabIndex = 5;
            Detener.Text = "Detener";
            Detener.UseVisualStyleBackColor = true;
            Detener.Click += Detener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 451);
            Controls.Add(Detener);
            Controls.Add(Iniciar);
            Controls.Add(Temporizador);
            Controls.Add(Segundo);
            Controls.Add(Minuto);
            Controls.Add(Hora);
            Name = "Form1";
            Text = "Temporizar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Hora;
        private ComboBox Minuto;
        private ComboBox Segundo;
        private Label Temporizador;
        private Button Iniciar;
        private Button Detener;
        private System.Windows.Forms.Timer timer1;
    }
}
