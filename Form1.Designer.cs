namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBleu = new System.Windows.Forms.Button();
            this.buttonRouge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonrst = new System.Windows.Forms.Button();
            this.buttonRose = new System.Windows.Forms.Button();
            this.buttonVert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpsjeu = new System.Windows.Forms.Timer(this.components);
            this.intervallecouleur = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBleu
            // 
            this.buttonBleu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBleu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBleu.Location = new System.Drawing.Point(6, 19);
            this.buttonBleu.Name = "buttonBleu";
            this.buttonBleu.Size = new System.Drawing.Size(205, 105);
            this.buttonBleu.TabIndex = 0;
            this.buttonBleu.Text = "Bleu";
            this.buttonBleu.UseVisualStyleBackColor = false;
            this.buttonBleu.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRouge
            // 
            this.buttonRouge.BackColor = System.Drawing.Color.Red;
            this.buttonRouge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRouge.Location = new System.Drawing.Point(290, 19);
            this.buttonRouge.Name = "buttonRouge";
            this.buttonRouge.Size = new System.Drawing.Size(199, 105);
            this.buttonRouge.TabIndex = 2;
            this.buttonRouge.Text = "Rouge";
            this.buttonRouge.UseVisualStyleBackColor = false;
            this.buttonRouge.Click += new System.EventHandler(this.buttonRouge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonrst);
            this.groupBox1.Controls.Add(this.buttonRose);
            this.groupBox1.Controls.Add(this.buttonVert);
            this.groupBox1.Controls.Add(this.buttonRouge);
            this.groupBox1.Controls.Add(this.buttonBleu);
            this.groupBox1.Location = new System.Drawing.Point(30, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonrst
            // 
            this.buttonrst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonrst.Location = new System.Drawing.Point(191, 118);
            this.buttonrst.Name = "buttonrst";
            this.buttonrst.Size = new System.Drawing.Size(113, 43);
            this.buttonrst.TabIndex = 8;
            this.buttonrst.Text = "Ok!";
            this.buttonrst.UseVisualStyleBackColor = true;
            this.buttonrst.Click += new System.EventHandler(this.buttonrst_Click);
            // 
            // buttonRose
            // 
            this.buttonRose.BackColor = System.Drawing.Color.DeepPink;
            this.buttonRose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRose.Location = new System.Drawing.Point(6, 149);
            this.buttonRose.Name = "buttonRose";
            this.buttonRose.Size = new System.Drawing.Size(205, 103);
            this.buttonRose.TabIndex = 4;
            this.buttonRose.Text = "Rose";
            this.buttonRose.UseVisualStyleBackColor = false;
            this.buttonRose.Click += new System.EventHandler(this.buttonRose_Click);
            // 
            // buttonVert
            // 
            this.buttonVert.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonVert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVert.Location = new System.Drawing.Point(290, 149);
            this.buttonVert.Name = "buttonVert";
            this.buttonVert.Size = new System.Drawing.Size(199, 103);
            this.buttonVert.TabIndex = 3;
            this.buttonVert.Text = "Vert";
            this.buttonVert.UseVisualStyleBackColor = false;
            this.buttonVert.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Couleur";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "score";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(247, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fontDialog2
            // 
            this.fontDialog2.Apply += new System.EventHandler(this.fontDialog2_Apply);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tpsjeu
            // 
            this.tpsjeu.Enabled = true;
            this.tpsjeu.Tick += new System.EventHandler(this.tpsjeu_Tick);
            // 
            // intervallecouleur
            // 
            this.intervallecouleur.Enabled = true;
            this.intervallecouleur.Interval = 500;
            this.intervallecouleur.Tick += new System.EventHandler(this.intervallecouleur_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Super Jeu concours";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBleu;
        private System.Windows.Forms.Button buttonRouge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRose;
        private System.Windows.Forms.Button buttonVert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonrst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer tpsjeu;
        private System.Windows.Forms.Timer intervallecouleur;
    }
}

