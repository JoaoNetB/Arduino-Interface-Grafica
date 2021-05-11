
namespace ProgramaLEDs
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btLED1 = new System.Windows.Forms.Button();
            this.btLED2 = new System.Windows.Forms.Button();
            this.btLED3 = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acender e apagar LED";
            // 
            // btLED1
            // 
            this.btLED1.Location = new System.Drawing.Point(224, 140);
            this.btLED1.Name = "btLED1";
            this.btLED1.Size = new System.Drawing.Size(137, 65);
            this.btLED1.TabIndex = 1;
            this.btLED1.Text = "LED1";
            this.btLED1.UseVisualStyleBackColor = true;
            this.btLED1.Click += new System.EventHandler(this.LED1_Click);
            // 
            // btLED2
            // 
            this.btLED2.Location = new System.Drawing.Point(367, 140);
            this.btLED2.Name = "btLED2";
            this.btLED2.Size = new System.Drawing.Size(137, 65);
            this.btLED2.TabIndex = 2;
            this.btLED2.Text = "LED2";
            this.btLED2.UseVisualStyleBackColor = true;
            this.btLED2.Click += new System.EventHandler(this.LED2_Click);
            // 
            // btLED3
            // 
            this.btLED3.Location = new System.Drawing.Point(290, 211);
            this.btLED3.Name = "btLED3";
            this.btLED3.Size = new System.Drawing.Size(137, 65);
            this.btLED3.TabIndex = 3;
            this.btLED3.Text = "LED3";
            this.btLED3.UseVisualStyleBackColor = true;
            this.btLED3.Click += new System.EventHandler(this.LED3_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(290, 357);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(137, 65);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Apagar LEDs";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 414);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btLED3);
            this.Controls.Add(this.btLED2);
            this.Controls.Add(this.btLED1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LEDArduino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLED1;
        private System.Windows.Forms.Button btLED2;
        private System.Windows.Forms.Button btLED3;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

