namespace BFK_S_Projekt
{
    partial class update_spieler
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
            this.cb_sperre = new System.Windows.Forms.ComboBox();
            this.tb_spielerKarten = new System.Windows.Forms.Label();
            this.tb_spielerSperren = new System.Windows.Forms.Label();
            this.tb_spielerNachname = new System.Windows.Forms.Label();
            this.tb_spielerVorname = new System.Windows.Forms.Label();
            this.tb_karten = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.bt_bestaetigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_sperre
            // 
            this.cb_sperre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sperre.FormattingEnabled = true;
            this.cb_sperre.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cb_sperre.Location = new System.Drawing.Point(150, 96);
            this.cb_sperre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_sperre.Name = "cb_sperre";
            this.cb_sperre.Size = new System.Drawing.Size(110, 23);
            this.cb_sperre.TabIndex = 30;
            // 
            // tb_spielerKarten
            // 
            this.tb_spielerKarten.AutoSize = true;
            this.tb_spielerKarten.Location = new System.Drawing.Point(29, 128);
            this.tb_spielerKarten.Name = "tb_spielerKarten";
            this.tb_spielerKarten.Size = new System.Drawing.Size(82, 15);
            this.tb_spielerKarten.TabIndex = 29;
            this.tb_spielerKarten.Text = "Spieler Karten:";
            // 
            // tb_spielerSperren
            // 
            this.tb_spielerSperren.AutoSize = true;
            this.tb_spielerSperren.Location = new System.Drawing.Point(29, 98);
            this.tb_spielerSperren.Name = "tb_spielerSperren";
            this.tb_spielerSperren.Size = new System.Drawing.Size(88, 15);
            this.tb_spielerSperren.TabIndex = 28;
            this.tb_spielerSperren.Text = "Spieler Sperren:";
            // 
            // tb_spielerNachname
            // 
            this.tb_spielerNachname.AutoSize = true;
            this.tb_spielerNachname.Location = new System.Drawing.Point(26, 61);
            this.tb_spielerNachname.Name = "tb_spielerNachname";
            this.tb_spielerNachname.Size = new System.Drawing.Size(106, 15);
            this.tb_spielerNachname.TabIndex = 27;
            this.tb_spielerNachname.Text = "Spieler Nachname:";
            // 
            // tb_spielerVorname
            // 
            this.tb_spielerVorname.AutoSize = true;
            this.tb_spielerVorname.Location = new System.Drawing.Point(26, 26);
            this.tb_spielerVorname.Name = "tb_spielerVorname";
            this.tb_spielerVorname.Size = new System.Drawing.Size(95, 15);
            this.tb_spielerVorname.TabIndex = 26;
            this.tb_spielerVorname.Text = "Spieler Vorname:";
            // 
            // tb_karten
            // 
            this.tb_karten.Location = new System.Drawing.Point(150, 126);
            this.tb_karten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_karten.Name = "tb_karten";
            this.tb_karten.Size = new System.Drawing.Size(110, 23);
            this.tb_karten.TabIndex = 25;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(150, 58);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(110, 23);
            this.tb_nachname.TabIndex = 24;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(150, 24);
            this.tb_vorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(110, 23);
            this.tb_vorname.TabIndex = 23;
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Location = new System.Drawing.Point(98, 165);
            this.bt_bestaetigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(83, 22);
            this.bt_bestaetigen.TabIndex = 22;
            this.bt_bestaetigen.Text = "Update";
            this.bt_bestaetigen.UseVisualStyleBackColor = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
            // 
            // update_spieler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 207);
            this.Controls.Add(this.cb_sperre);
            this.Controls.Add(this.tb_spielerKarten);
            this.Controls.Add(this.tb_spielerSperren);
            this.Controls.Add(this.tb_spielerNachname);
            this.Controls.Add(this.tb_spielerVorname);
            this.Controls.Add(this.tb_karten);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.bt_bestaetigen);
            this.Name = "update_spieler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_spieler";
            this.Load += new System.EventHandler(this.update_spieler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_sperre;
        private Label tb_spielerKarten;
        private Label tb_spielerSperren;
        private Label tb_spielerNachname;
        private Label tb_spielerVorname;
        private TextBox tb_karten;
        private TextBox tb_nachname;
        private TextBox tb_vorname;
        private Button bt_bestaetigen;
    }
}