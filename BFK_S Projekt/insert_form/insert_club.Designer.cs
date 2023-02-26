namespace BFK_S_Projekt
{
    partial class insert_club
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_trainer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_bestaetigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Club Name:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(121, 18);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(125, 27);
            this.tb_name.TabIndex = 18;
            // 
            // cb_trainer
            // 
            this.cb_trainer.Location = new System.Drawing.Point(121, 54);
            this.cb_trainer.Margin = new System.Windows.Forms.Padding(2);
            this.cb_trainer.Name = "cb_trainer";
            this.cb_trainer.Size = new System.Drawing.Size(125, 28);
            this.cb_trainer.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Trainer:";
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Location = new System.Drawing.Point(82, 104);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(94, 29);
            this.bt_bestaetigen.TabIndex = 24;
            this.bt_bestaetigen.Text = "Add";
            this.bt_bestaetigen.UseVisualStyleBackColor = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
            // 
            // insert_club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 143);
            this.Controls.Add(this.bt_bestaetigen);
            this.Controls.Add(this.cb_trainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "insert_club";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insert_club";
            this.Load += new System.EventHandler(this.insert_club_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox tb_name;
        private ComboBox cb_trainer;
        private Label label3;
        private Button bt_bestaetigen;
    }
}