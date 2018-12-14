namespace aponet
{
    partial class ModifierEtSupprimer
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
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Album = new System.Windows.Forms.ListBox();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(204, 200);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(81, 23);
            this.BTN_Annuler.TabIndex = 8;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(12, 200);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(81, 23);
            this.BTN_Modifier.TabIndex = 7;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_Album);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélectionner un album";
            // 
            // LB_Album
            // 
            this.LB_Album.FormattingEnabled = true;
            this.LB_Album.Location = new System.Drawing.Point(12, 16);
            this.LB_Album.Name = "LB_Album";
            this.LB_Album.Size = new System.Drawing.Size(255, 160);
            this.LB_Album.TabIndex = 0;
            this.LB_Album.SelectedIndexChanged += new System.EventHandler(this.LB_Album_SelectedIndexChanged);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(108, 200);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(81, 23);
            this.BTN_Supprimer.TabIndex = 5;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // ModifierEtSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 236);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Supprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ModifierEtSupprimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierEtSupprimer";
            this.Load += new System.EventHandler(this.ModifierEtSupprimer_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox LB_Album;
        private System.Windows.Forms.Button BTN_Supprimer;
    }
}