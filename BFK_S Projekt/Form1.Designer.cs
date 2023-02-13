namespace BFK_S_Projekt
{
    partial class default_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_spieler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_spieler = new System.Windows.Forms.ComboBox();
            this.bt_insert_spieler = new System.Windows.Forms.Button();
            this.bt_update_spieler = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_club = new System.Windows.Forms.ComboBox();
            this.bt_insert_club = new System.Windows.Forms.Button();
            this.bt_update_club = new System.Windows.Forms.Button();
            this.dgv_club = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_trainer = new System.Windows.Forms.ComboBox();
            this.bt_insert_trainer = new System.Windows.Forms.Button();
            this.bt_update_trainer = new System.Windows.Forms.Button();
            this.dgv_trainer = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spieler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_club)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_spieler);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb_spieler);
            this.tabPage1.Controls.Add(this.bt_insert_spieler);
            this.tabPage1.Controls.Add(this.bt_update_spieler);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spieler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_spieler
            // 
            this.dgv_spieler.AllowUserToAddRows = false;
            this.dgv_spieler.AllowUserToDeleteRows = false;
            this.dgv_spieler.AllowUserToOrderColumns = true;
            this.dgv_spieler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spieler.Location = new System.Drawing.Point(130, 70);
            this.dgv_spieler.Name = "dgv_spieler";
            this.dgv_spieler.RowHeadersWidth = 51;
            this.dgv_spieler.RowTemplate.Height = 29;
            this.dgv_spieler.Size = new System.Drawing.Size(532, 208);
            this.dgv_spieler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter:";
            // 
            // cb_spieler
            // 
            this.cb_spieler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_spieler.FormattingEnabled = true;
            this.cb_spieler.Location = new System.Drawing.Point(511, 323);
            this.cb_spieler.Name = "cb_spieler";
            this.cb_spieler.Size = new System.Drawing.Size(151, 28);
            this.cb_spieler.TabIndex = 3;
            // 
            // bt_insert_spieler
            // 
            this.bt_insert_spieler.Location = new System.Drawing.Point(300, 322);
            this.bt_insert_spieler.Name = "bt_insert_spieler";
            this.bt_insert_spieler.Size = new System.Drawing.Size(94, 29);
            this.bt_insert_spieler.TabIndex = 2;
            this.bt_insert_spieler.Text = "insert";
            this.bt_insert_spieler.UseVisualStyleBackColor = true;
            this.bt_insert_spieler.Click += new System.EventHandler(this.bt_insert_spieler_Click);
            // 
            // bt_update_spieler
            // 
            this.bt_update_spieler.Location = new System.Drawing.Point(130, 319);
            this.bt_update_spieler.Name = "bt_update_spieler";
            this.bt_update_spieler.Size = new System.Drawing.Size(94, 29);
            this.bt_update_spieler.TabIndex = 1;
            this.bt_update_spieler.Text = "update";
            this.bt_update_spieler.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cb_club);
            this.tabPage2.Controls.Add(this.bt_insert_club);
            this.tabPage2.Controls.Add(this.bt_update_club);
            this.tabPage2.Controls.Add(this.dgv_club);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Club";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter:";
            // 
            // cb_club
            // 
            this.cb_club.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_club.FormattingEnabled = true;
            this.cb_club.Location = new System.Drawing.Point(511, 323);
            this.cb_club.Name = "cb_club";
            this.cb_club.Size = new System.Drawing.Size(151, 28);
            this.cb_club.TabIndex = 8;
            // 
            // bt_insert_club
            // 
            this.bt_insert_club.Location = new System.Drawing.Point(300, 322);
            this.bt_insert_club.Name = "bt_insert_club";
            this.bt_insert_club.Size = new System.Drawing.Size(94, 29);
            this.bt_insert_club.TabIndex = 7;
            this.bt_insert_club.Text = "insert";
            this.bt_insert_club.UseVisualStyleBackColor = true;
            this.bt_insert_club.Click += new System.EventHandler(this.bt_insert_club_Click);
            // 
            // bt_update_club
            // 
            this.bt_update_club.Location = new System.Drawing.Point(130, 319);
            this.bt_update_club.Name = "bt_update_club";
            this.bt_update_club.Size = new System.Drawing.Size(94, 29);
            this.bt_update_club.TabIndex = 6;
            this.bt_update_club.Text = "update";
            this.bt_update_club.UseVisualStyleBackColor = true;
            // 
            // dgv_club
            // 
            this.dgv_club.AllowUserToAddRows = false;
            this.dgv_club.AllowUserToDeleteRows = false;
            this.dgv_club.AllowUserToOrderColumns = true;
            this.dgv_club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_club.Location = new System.Drawing.Point(130, 70);
            this.dgv_club.Name = "dgv_club";
            this.dgv_club.RowHeadersWidth = 51;
            this.dgv_club.RowTemplate.Height = 29;
            this.dgv_club.Size = new System.Drawing.Size(532, 208);
            this.dgv_club.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cb_trainer);
            this.tabPage3.Controls.Add(this.bt_insert_trainer);
            this.tabPage3.Controls.Add(this.bt_update_trainer);
            this.tabPage3.Controls.Add(this.dgv_trainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(792, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trainer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter:";
            // 
            // cb_trainer
            // 
            this.cb_trainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trainer.FormattingEnabled = true;
            this.cb_trainer.Location = new System.Drawing.Point(511, 323);
            this.cb_trainer.Name = "cb_trainer";
            this.cb_trainer.Size = new System.Drawing.Size(151, 28);
            this.cb_trainer.TabIndex = 8;
            // 
            // bt_insert_trainer
            // 
            this.bt_insert_trainer.Location = new System.Drawing.Point(300, 322);
            this.bt_insert_trainer.Name = "bt_insert_trainer";
            this.bt_insert_trainer.Size = new System.Drawing.Size(94, 29);
            this.bt_insert_trainer.TabIndex = 7;
            this.bt_insert_trainer.Text = "insert";
            this.bt_insert_trainer.UseVisualStyleBackColor = true;
            this.bt_insert_trainer.Click += new System.EventHandler(this.bt_insert_trainer_Click);
            // 
            // bt_update_trainer
            // 
            this.bt_update_trainer.Location = new System.Drawing.Point(130, 319);
            this.bt_update_trainer.Name = "bt_update_trainer";
            this.bt_update_trainer.Size = new System.Drawing.Size(94, 29);
            this.bt_update_trainer.TabIndex = 6;
            this.bt_update_trainer.Text = "update";
            this.bt_update_trainer.UseVisualStyleBackColor = true;
            // 
            // dgv_trainer
            // 
            this.dgv_trainer.AllowUserToAddRows = false;
            this.dgv_trainer.AllowUserToDeleteRows = false;
            this.dgv_trainer.AllowUserToOrderColumns = true;
            this.dgv_trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trainer.Location = new System.Drawing.Point(130, 70);
            this.dgv_trainer.Name = "dgv_trainer";
            this.dgv_trainer.RowHeadersWidth = 51;
            this.dgv_trainer.RowTemplate.Height = 29;
            this.dgv_trainer.Size = new System.Drawing.Size(532, 208);
            this.dgv_trainer.TabIndex = 5;
            // 
            // default_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "default_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChampionsLeague Database";
            this.Activated += new System.EventHandler(this.default_form_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spieler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_club)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private ComboBox cb_spieler;
        private Button bt_insert_spieler;
        private Button bt_update_spieler;
        private TabPage tabPage2;
        private Label label2;
        private ComboBox cb_club;
        private Button bt_insert_club;
        private Button bt_update_club;
        private DataGridView dgv_club;
        private TabPage tabPage3;
        private Label label3;
        private ComboBox cb_trainer;
        private Button bt_insert_trainer;
        private Button bt_update_trainer;
        private DataGridView dgv_trainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgv_spieler;
    }
}