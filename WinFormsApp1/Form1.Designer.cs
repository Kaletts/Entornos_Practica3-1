namespace WinFormsApp1
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
            button1 = new Button();
            txtTelegrama = new TextBox();
            rbUrgente = new RadioButton();
            rbOrdinario = new RadioButton();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(229, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(33, 39);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(271, 68);
            txtTelegrama.TabIndex = 1;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(53, 113);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(73, 19);
            rbUrgente.TabIndex = 2;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Location = new Point(53, 138);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(73, 19);
            rbOrdinario.TabIndex = 3;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 149);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(109, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 152);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Coste:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 21);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Texto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 231);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(rbOrdinario);
            Controls.Add(rbUrgente);
            Controls.Add(txtTelegrama);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTelegrama;
        private RadioButton rbUrgente;
        private RadioButton rbOrdinario;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
    }
}