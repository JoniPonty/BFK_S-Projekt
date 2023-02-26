namespace BFK_S_Projekt
{
    partial class update_trainer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_alter = new System.Windows.Forms.TextBox();
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
            this.cb_sperre.Location = new System.Drawing.Point(146, 88);
            this.cb_sperre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_sperre.Name = "cb_sperre";
            this.cb_sperre.Size = new System.Drawing.Size(110, 23);
            this.cb_sperre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Trainer Alter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trainer Sperren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Trainer Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Trainer Vorname:";
            // 
            // tb_alter
            // 
            this.tb_alter.Location = new System.Drawing.Point(146, 119);
            this.tb_alter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_alter.Name = "tb_alter";
            this.tb_alter.Size = new System.Drawing.Size(110, 23);
            this.tb_alter.TabIndex = 24;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(146, 51);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(110, 23);
            this.tb_nachname.TabIndex = 23;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(146, 17);
            this.tb_vorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(110, 23);
            this.tb_vorname.TabIndex = 22;
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Location = new System.Drawing.Point(94, 158);
            this.bt_bestaetigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(82, 22);
            this.bt_bestaetigen.TabIndex = 21;
            this.bt_bestaetigen.Text = "Update";
            this.bt_bestaetigen.UseVisualStyleBackColor = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
            // 
            // update_trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 189);
            this.Controls.Add(this.cb_sperre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_alter);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.bt_bestaetigen);
            this.Name = "update_trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update_trainer";
            this.Load += new System.EventHandler(this.update_trainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_sperre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_alter;
        private TextBox tb_nachname;
        private TextBox tb_vorname;
        private Button bt_bestaetigen;
    }
}