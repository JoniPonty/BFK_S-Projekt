namespace BFK_S_Projekt
{
    partial class insert_trainer
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_alter = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.bt_bestaetigen = new System.Windows.Forms.Button();
            this.cb_sperre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trainer Alter:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trainer Sperren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Trainer Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Trainer Vorname:";
            // 
            // tb_alter
            // 
            this.tb_alter.Location = new System.Drawing.Point(151, 157);
            this.tb_alter.Name = "tb_alter";
            this.tb_alter.Size = new System.Drawing.Size(125, 27);
            this.tb_alter.TabIndex = 15;
            // 
            // tb_nachname
            // 
            this.tb_nachname.Location = new System.Drawing.Point(151, 67);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(125, 27);
            this.tb_nachname.TabIndex = 13;
            // 
            // tb_vorname
            // 
            this.tb_vorname.Location = new System.Drawing.Point(151, 21);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(125, 27);
            this.tb_vorname.TabIndex = 12;
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Location = new System.Drawing.Point(91, 209);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(94, 29);
            this.bt_bestaetigen.TabIndex = 11;
            this.bt_bestaetigen.Text = "Add";
            this.bt_bestaetigen.UseVisualStyleBackColor = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
            // 
            // cb_sperre
            // 
            this.cb_sperre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sperre.FormattingEnabled = true;
            this.cb_sperre.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cb_sperre.Location = new System.Drawing.Point(151, 116);
            this.cb_sperre.Name = "cb_sperre";
            this.cb_sperre.Size = new System.Drawing.Size(125, 28);
            this.cb_sperre.TabIndex = 20;
            // 
            // insert_trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 264);
            this.Controls.Add(this.cb_sperre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_alter);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.bt_bestaetigen);
            this.Name = "insert_trainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insert_trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_alter;
        private TextBox tb_nachname;
        private TextBox tb_vorname;
        private Button bt_bestaetigen;
        private ComboBox cb_sperre;
    }
}