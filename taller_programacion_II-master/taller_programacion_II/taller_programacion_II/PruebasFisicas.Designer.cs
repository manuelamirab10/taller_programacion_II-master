namespace taller_programacion_II
{
    partial class PruebasFisicas
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 32);
            label1.TabIndex = 0;
            label1.Text = "TOMA DE PRESIÓN ARTERIAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 1;
            label2.Text = "PRESIÓN SISTÓLICA (mmHg):";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 115);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 4;
            label4.Text = "PRESIÓN DIASTÓLICA:";
            // 
            // button1
            // 
            button1.Location = new Point(589, 179);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 6;
            button1.Text = "SIGUIENTE FORMULARIO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(33, 179);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 7;
            button2.Text = "ATRÁS";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(313, 179);
            button3.Name = "button3";
            button3.Size = new Size(165, 23);
            button3.TabIndex = 8;
            button3.Text = "MENÚ";
            button3.UseVisualStyleBackColor = true;
            // 
            // PruebasFisicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 229);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PruebasFisicas";
            Text = "Presión Arterial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}