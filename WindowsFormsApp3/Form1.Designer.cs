namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cancella = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.Visualizza = new System.Windows.Forms.Button();
            this.Somma = new System.Windows.Forms.Button();
            this.Percentuale = new System.Windows.Forms.Button();
            this.maxs = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.Button();
            this.newn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newpr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezzo";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(35, 136);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Salva";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(567, 50);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(206, 285);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Cancella
            // 
            this.Cancella.Location = new System.Drawing.Point(154, 136);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(75, 23);
            this.Cancella.TabIndex = 6;
            this.Cancella.Text = "Cancella";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modifica
            // 
            this.Modifica.Location = new System.Drawing.Point(35, 280);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(75, 23);
            this.Modifica.TabIndex = 7;
            this.Modifica.Text = "Modifica";
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // Visualizza
            // 
            this.Visualizza.Location = new System.Drawing.Point(272, 136);
            this.Visualizza.Name = "Visualizza";
            this.Visualizza.Size = new System.Drawing.Size(75, 23);
            this.Visualizza.TabIndex = 8;
            this.Visualizza.Text = "Visualizza";
            this.Visualizza.UseVisualStyleBackColor = true;
            this.Visualizza.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Somma
            // 
            this.Somma.Location = new System.Drawing.Point(35, 204);
            this.Somma.Name = "Somma";
            this.Somma.Size = new System.Drawing.Size(75, 23);
            this.Somma.TabIndex = 9;
            this.Somma.Text = "Somma";
            this.Somma.UseVisualStyleBackColor = true;
            this.Somma.Click += new System.EventHandler(this.Somma_Click);
            // 
            // Percentuale
            // 
            this.Percentuale.Location = new System.Drawing.Point(154, 203);
            this.Percentuale.Name = "Percentuale";
            this.Percentuale.Size = new System.Drawing.Size(75, 23);
            this.Percentuale.TabIndex = 10;
            this.Percentuale.Text = "Prezzo Perc";
            this.Percentuale.UseVisualStyleBackColor = true;
            this.Percentuale.Click += new System.EventHandler(this.Percentuale_Click);
            // 
            // maxs
            // 
            this.maxs.Location = new System.Drawing.Point(272, 203);
            this.maxs.Name = "maxs";
            this.maxs.Size = new System.Drawing.Size(75, 23);
            this.maxs.TabIndex = 11;
            this.maxs.Text = "Massimo";
            this.maxs.UseVisualStyleBackColor = true;
            this.maxs.Click += new System.EventHandler(this.maxs_Click);
            // 
            // mini
            // 
            this.mini.Location = new System.Drawing.Point(390, 203);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(75, 23);
            this.mini.TabIndex = 12;
            this.mini.Text = "Minimo";
            this.mini.UseVisualStyleBackColor = true;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // newn
            // 
            this.newn.Location = new System.Drawing.Point(154, 282);
            this.newn.Name = "newn";
            this.newn.Size = new System.Drawing.Size(100, 20);
            this.newn.TabIndex = 13;
            this.newn.TextChanged += new System.EventHandler(this.newn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nuovo Nome";
            // 
            // newpr
            // 
            this.newpr.Location = new System.Drawing.Point(344, 283);
            this.newpr.Name = "newpr";
            this.newpr.Size = new System.Drawing.Size(100, 20);
            this.newpr.TabIndex = 15;
            this.newpr.TextChanged += new System.EventHandler(this.newpr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nuovo Prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newpr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newn);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.maxs);
            this.Controls.Add(this.Percentuale);
            this.Controls.Add(this.Somma);
            this.Controls.Add(this.Visualizza);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.Cancella);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Cancella;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Button Visualizza;
        private System.Windows.Forms.Button Somma;
        private System.Windows.Forms.Button Percentuale;
        private System.Windows.Forms.Button maxs;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.TextBox newn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpr;
        private System.Windows.Forms.Label label4;
    }
}

