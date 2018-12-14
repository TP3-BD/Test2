namespace aponet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_ChoixCatégorie1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.TB_AnnéDisque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NomArtiste = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_TitreDisque = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBTN_ParCategorie = new System.Windows.Forms.RadioButton();
            this.RBTN_ParNom = new System.Windows.Forms.RadioButton();
            this.RBTN_TousLesAlbums = new System.Windows.Forms.RadioButton();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.CB_ChoixCatégorie = new System.Windows.Forms.ComboBox();
            this.TBX_ParNom = new System.Windows.Forms.TextBox();
            this.BTN_Modifiersupprimer = new System.Windows.Forms.Button();
            this.DGV_Album = new System.Windows.Forms.DataGridView();
            this.BTN_connection = new System.Windows.Forms.Button();
            this.BTN_quitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Album)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CB_ChoixCatégorie1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_Ajouter);
            this.groupBox1.Controls.Add(this.TB_AnnéDisque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_NomArtiste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_TitreDisque);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(4, -4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(381, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un disque";
            // 
            // CB_ChoixCatégorie1
            // 
            this.CB_ChoixCatégorie1.FormattingEnabled = true;
            this.CB_ChoixCatégorie1.Location = new System.Drawing.Point(159, 122);
            this.CB_ChoixCatégorie1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_ChoixCatégorie1.Name = "CB_ChoixCatégorie1";
            this.CB_ChoixCatégorie1.Size = new System.Drawing.Size(213, 26);
            this.CB_ChoixCatégorie1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nom du parcour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom de l\'artiste:";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(273, 155);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(100, 28);
            this.BTN_Ajouter.TabIndex = 6;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // TB_AnnéDisque
            // 
            this.TB_AnnéDisque.Location = new System.Drawing.Point(159, 89);
            this.TB_AnnéDisque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_AnnéDisque.MaxLength = 4;
            this.TB_AnnéDisque.Name = "TB_AnnéDisque";
            this.TB_AnnéDisque.Size = new System.Drawing.Size(213, 24);
            this.TB_AnnéDisque.TabIndex = 5;
            this.TB_AnnéDisque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_AnnéDisque_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Année du disque:";
            // 
            // TB_NomArtiste
            // 
            this.TB_NomArtiste.Location = new System.Drawing.Point(159, 55);
            this.TB_NomArtiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NomArtiste.Name = "TB_NomArtiste";
            this.TB_NomArtiste.Size = new System.Drawing.Size(213, 24);
            this.TB_NomArtiste.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code catégorie:";
            // 
            // TB_TitreDisque
            // 
            this.TB_TitreDisque.Location = new System.Drawing.Point(159, 22);
            this.TB_TitreDisque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_TitreDisque.Name = "TB_TitreDisque";
            this.TB_TitreDisque.Size = new System.Drawing.Size(213, 24);
            this.TB_TitreDisque.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RBTN_ParCategorie);
            this.groupBox2.Controls.Add(this.RBTN_ParNom);
            this.groupBox2.Controls.Add(this.RBTN_TousLesAlbums);
            this.groupBox2.Controls.Add(this.BTN_Search);
            this.groupBox2.Controls.Add(this.CB_ChoixCatégorie);
            this.groupBox2.Controls.Add(this.TBX_ParNom);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(381, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche d\'un disque";
            // 
            // RBTN_ParCategorie
            // 
            this.RBTN_ParCategorie.AutoSize = true;
            this.RBTN_ParCategorie.Location = new System.Drawing.Point(12, 100);
            this.RBTN_ParCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBTN_ParCategorie.Name = "RBTN_ParCategorie";
            this.RBTN_ParCategorie.Size = new System.Drawing.Size(130, 22);
            this.RBTN_ParCategorie.TabIndex = 10;
            this.RBTN_ParCategorie.Text = "Par catégorie";
            this.RBTN_ParCategorie.UseVisualStyleBackColor = true;
            // 
            // RBTN_ParNom
            // 
            this.RBTN_ParNom.AutoSize = true;
            this.RBTN_ParNom.Location = new System.Drawing.Point(12, 69);
            this.RBTN_ParNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBTN_ParNom.Name = "RBTN_ParNom";
            this.RBTN_ParNom.Size = new System.Drawing.Size(93, 22);
            this.RBTN_ParNom.TabIndex = 9;
            this.RBTN_ParNom.Text = "Par nom";
            this.RBTN_ParNom.UseVisualStyleBackColor = true;
            // 
            // RBTN_TousLesAlbums
            // 
            this.RBTN_TousLesAlbums.AutoSize = true;
            this.RBTN_TousLesAlbums.Checked = true;
            this.RBTN_TousLesAlbums.Location = new System.Drawing.Point(12, 36);
            this.RBTN_TousLesAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RBTN_TousLesAlbums.Name = "RBTN_TousLesAlbums";
            this.RBTN_TousLesAlbums.Size = new System.Drawing.Size(154, 22);
            this.RBTN_TousLesAlbums.TabIndex = 8;
            this.RBTN_TousLesAlbums.TabStop = true;
            this.RBTN_TousLesAlbums.Text = "Tous les Albums";
            this.RBTN_TousLesAlbums.UseVisualStyleBackColor = true;
            // 
            // BTN_Search
            // 
            this.BTN_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Search.Location = new System.Drawing.Point(268, 135);
            this.BTN_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(105, 28);
            this.BTN_Search.TabIndex = 7;
            this.BTN_Search.Text = "Rechercher";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // CB_ChoixCatégorie
            // 
            this.CB_ChoixCatégorie.FormattingEnabled = true;
            this.CB_ChoixCatégorie.Location = new System.Drawing.Point(168, 100);
            this.CB_ChoixCatégorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_ChoixCatégorie.Name = "CB_ChoixCatégorie";
            this.CB_ChoixCatégorie.Size = new System.Drawing.Size(204, 26);
            this.CB_ChoixCatégorie.TabIndex = 4;
            this.CB_ChoixCatégorie.SelectedIndexChanged += new System.EventHandler(this.CB_ChoixCatégorie_SelectedIndexChanged);
            // 
            // TBX_ParNom
            // 
            this.TBX_ParNom.Location = new System.Drawing.Point(127, 66);
            this.TBX_ParNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBX_ParNom.Name = "TBX_ParNom";
            this.TBX_ParNom.Size = new System.Drawing.Size(245, 24);
            this.TBX_ParNom.TabIndex = 3;
            this.TBX_ParNom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBX_ParNom_MouseClick);
            // 
            // BTN_Modifiersupprimer
            // 
            this.BTN_Modifiersupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modifiersupprimer.Location = new System.Drawing.Point(556, 336);
            this.BTN_Modifiersupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Modifiersupprimer.Name = "BTN_Modifiersupprimer";
            this.BTN_Modifiersupprimer.Size = new System.Drawing.Size(143, 52);
            this.BTN_Modifiersupprimer.TabIndex = 2;
            this.BTN_Modifiersupprimer.Text = "Modifier/Supprimer";
            this.BTN_Modifiersupprimer.UseVisualStyleBackColor = true;
            this.BTN_Modifiersupprimer.Click += new System.EventHandler(this.BTN_Modifiersupprimer_Click);
            // 
            // DGV_Album
            // 
            this.DGV_Album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Album.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Album.Location = new System.Drawing.Point(409, 15);
            this.DGV_Album.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Album.Name = "DGV_Album";
            this.DGV_Album.Size = new System.Drawing.Size(591, 278);
            this.DGV_Album.TabIndex = 4;
            // 
            // BTN_connection
            // 
            this.BTN_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_connection.Location = new System.Drawing.Point(707, 336);
            this.BTN_connection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_connection.Name = "BTN_connection";
            this.BTN_connection.Size = new System.Drawing.Size(143, 52);
            this.BTN_connection.TabIndex = 5;
            this.BTN_connection.Text = "Connection";
            this.BTN_connection.UseVisualStyleBackColor = true;
            this.BTN_connection.Click += new System.EventHandler(this.BTN_Connection_Click);
            // 
            // BTN_quitter
            // 
            this.BTN_quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_quitter.Location = new System.Drawing.Point(857, 336);
            this.BTN_quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_quitter.Name = "BTN_quitter";
            this.BTN_quitter.Size = new System.Drawing.Size(143, 52);
            this.BTN_quitter.TabIndex = 6;
            this.BTN_quitter.Text = "Quitter";
            this.BTN_quitter.UseVisualStyleBackColor = true;
            this.BTN_quitter.Click += new System.EventHandler(this.BTN_Deconnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 402);
            this.Controls.Add(this.BTN_quitter);
            this.Controls.Add(this.BTN_connection);
            this.Controls.Add(this.DGV_Album);
            this.Controls.Add(this.BTN_Modifiersupprimer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Album)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_TitreDisque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.TextBox TB_AnnéDisque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NomArtiste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Modifiersupprimer;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.ComboBox CB_ChoixCatégorie;
        private System.Windows.Forms.TextBox TBX_ParNom;
        private System.Windows.Forms.DataGridView DGV_Album;
        private System.Windows.Forms.Button BTN_connection;
        private System.Windows.Forms.Button BTN_quitter;
        private System.Windows.Forms.RadioButton RBTN_TousLesAlbums;
        private System.Windows.Forms.RadioButton RBTN_ParCategorie;
        private System.Windows.Forms.RadioButton RBTN_ParNom;
        private System.Windows.Forms.ComboBox CB_ChoixCatégorie1;
    }
}

