namespace BFK_S_Projekt
{
    partial class insert_spieler
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
            this.bt_bestaetigen = new System.Windows.Forms.Button();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_karten = new System.Windows.Forms.TextBox();
            this.tb_spielerVorname = new System.Windows.Forms.Label();
            this.tb_spielerNachname = new System.Windows.Forms.Label();
            this.tb_spielerSperren = new System.Windows.Forms.Label();
            this.tb_spielerKarten = new System.Windows.Forms.Label();
            this.cb_sperre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Location = new System.Drawing.Point(124, 250);
            this.bt_bestaetigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(118, 36);
            this.bt_bestaetigen.TabIndex = 0;
            this.bt_bestaetigen.Text = "Add";
            this.bt_bestaetigen.UseVisualStyleBackColor = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(199, 15);
            this.tb_vorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(155, 31);
            this.tb_vorname.TabIndex = 2;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(199, 72);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(155, 31);
            this.tb_nachname.TabIndex = 3;
            // 
            // tb_karten
            // 
            this.tb_karten.Location = new System.Drawing.Point(199, 185);
            this.tb_karten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_karten.Name = "tb_karten";
            this.tb_karten.Size = new System.Drawing.Size(155, 31);
            this.tb_karten.TabIndex = 5;
            // 
            // tb_spielerVorname
            // 
            this.tb_spielerVorname.AutoSize = true;
            this.tb_spielerVorname.Location = new System.Drawing.Point(22, 19);
            this.tb_spielerVorname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_spielerVorname.Name = "tb_spielerVorname";
            this.tb_spielerVorname.Size = new System.Drawing.Size(145, 25);
            this.tb_spielerVorname.TabIndex = 7;
            this.tb_spielerVorname.Text = "Spieler Vorname:";
            // 
            // tb_spielerNachname
            // 
            this.tb_spielerNachname.AutoSize = true;
            this.tb_spielerNachname.Location = new System.Drawing.Point(22, 76);
            this.tb_spielerNachname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_spielerNachname.Name = "tb_spielerNachname";
            this.tb_spielerNachname.Size = new System.Drawing.Size(158, 25);
            this.tb_spielerNachname.TabIndex = 8;
            this.tb_spielerNachname.Text = "Spieler Nachname:";
            // 
            // tb_spielerSperren
            // 
            this.tb_spielerSperren.AutoSize = true;
            this.tb_spielerSperren.Location = new System.Drawing.Point(25, 138);
            this.tb_spielerSperren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_spielerSperren.Name = "tb_spielerSperren";
            this.tb_spielerSperren.Size = new System.Drawing.Size(135, 25);
            this.tb_spielerSperren.TabIndex = 9;
            this.tb_spielerSperren.Text = "Spieler Sperren:";
            // 
            // tb_spielerKarten
            // 
            this.tb_spielerKarten.AutoSize = true;
            this.tb_spielerKarten.Location = new System.Drawing.Point(25, 189);
            this.tb_spielerKarten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tb_spielerKarten.Name = "tb_spielerKarten";
            this.tb_spielerKarten.Size = new System.Drawing.Size(124, 25);
            this.tb_spielerKarten.TabIndex = 10;
            this.tb_spielerKarten.Text = "Spieler Karten:";
            // 
            // cb_sperre
            // 
            this.cb_sperre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sperre.FormattingEnabled = true;
            this.cb_sperre.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cb_sperre.Location = new System.Drawing.Point(199, 135);
            this.cb_sperre.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sperre.Name = "cb_sperre";
            this.cb_sperre.Size = new System.Drawing.Size(155, 33);
            this.cb_sperre.TabIndex = 21;
            // 
            // insert_spieler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 301);
            this.Controls.Add(this.cb_sperre);
            this.Controls.Add(this.tb_spielerKarten);
            this.Controls.Add(this.tb_spielerSperren);
            this.Controls.Add(this.tb_spielerNachname);
            this.Controls.Add(this.tb_spielerVorname);
            this.Controls.Add(this.tb_karten);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.bt_bestaetigen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "insert_spieler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insert_spieler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_bestaetigen;
        private TextBox tb_vorname;
        private TextBox tb_nachname;
        private TextBox tb_karten;
        private Label tb_spielerVorname;
        private Label tb_spielerNachname;
        private Label tb_spielerSperren;
        private Label tb_spielerKarten;
        private ComboBox cb_sperre;
    }
}