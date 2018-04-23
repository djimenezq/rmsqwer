namespace Dijkstra
{
    partial class MenuGrafo
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
            this.lvertice = new System.Windows.Forms.Label();
            this.vbox = new System.Windows.Forms.TextBox();
            this.bvertice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.Destino = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bdijsktra = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvertice
            // 
            this.lvertice.AutoSize = true;
            this.lvertice.Location = new System.Drawing.Point(22, 37);
            this.lvertice.Name = "lvertice";
            this.lvertice.Size = new System.Drawing.Size(40, 13);
            this.lvertice.TabIndex = 0;
            this.lvertice.Text = "Vertice";
            // 
            // vbox
            // 
            this.vbox.Location = new System.Drawing.Point(25, 53);
            this.vbox.Name = "vbox";
            this.vbox.Size = new System.Drawing.Size(196, 20);
            this.vbox.TabIndex = 1;
            // 
            // bvertice
            // 
            this.bvertice.Location = new System.Drawing.Point(227, 50);
            this.bvertice.Name = "bvertice";
            this.bvertice.Size = new System.Drawing.Size(75, 23);
            this.bvertice.TabIndex = 2;
            this.bvertice.Text = "Agregar";
            this.bvertice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origen";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(23, 43);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(196, 21);
            this.cbOrigen.TabIndex = 4;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // Destino
            // 
            this.Destino.AutoSize = true;
            this.Destino.Location = new System.Drawing.Point(20, 89);
            this.Destino.Name = "Destino";
            this.Destino.Size = new System.Drawing.Size(43, 13);
            this.Destino.TabIndex = 5;
            this.Destino.Text = "Destino";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Distancia";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // barco
            // 
            this.barco.Location = new System.Drawing.Point(144, 164);
            this.barco.Name = "barco";
            this.barco.Size = new System.Drawing.Size(75, 23);
            this.barco.TabIndex = 9;
            this.barco.Text = "Agregar";
            this.barco.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bdijsktra);
            this.groupBox1.Controls.Add(this.cbOrigen);
            this.groupBox1.Controls.Add(this.barco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Destino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 239);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arcos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bdijsktra
            // 
            this.bdijsktra.Location = new System.Drawing.Point(23, 204);
            this.bdijsktra.Name = "bdijsktra";
            this.bdijsktra.Size = new System.Drawing.Size(196, 23);
            this.bdijsktra.TabIndex = 10;
            this.bdijsktra.Text = "Encontrar camino más corto";
            this.bdijsktra.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 376);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(277, 141);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bvertice);
            this.Controls.Add(this.vbox);
            this.Controls.Add(this.lvertice);
            this.Name = "MenuGrafo";
            this.Text = "MenuGrafo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvertice;
        private System.Windows.Forms.TextBox vbox;
        private System.Windows.Forms.Button bvertice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label Destino;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button barco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bdijsktra;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}