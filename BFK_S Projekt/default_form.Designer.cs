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
            this.bt_delete_spieler = new System.Windows.Forms.Button();
            this.dgv_spieler = new System.Windows.Forms.DataGridView();
            this.bt_insert_spieler = new System.Windows.Forms.Button();
            this.bt_update_spieler = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_insert_club = new System.Windows.Forms.Button();
            this.bt_update_club = new System.Windows.Forms.Button();
            this.dgv_club = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_delete_trainer = new System.Windows.Forms.Button();
            this.bt_insert_trainer = new System.Windows.Forms.Button();
            this.bt_update_trainer = new System.Windows.Forms.Button();
            this.dgv_trainer = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_delete_club = new System.Windows.Forms.Button();
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
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_delete_spieler);
            this.tabPage1.Controls.Add(this.dgv_spieler);
            this.tabPage1.Controls.Add(this.bt_insert_spieler);
            this.tabPage1.Controls.Add(this.bt_update_spieler);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spieler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_delete_spieler
            // 
            this.bt_delete_spieler.Location = new System.Drawing.Point(573, 327);
            this.bt_delete_spieler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_delete_spieler.Name = "bt_delete_spieler";
            this.bt_delete_spieler.Size = new System.Drawing.Size(182, 60);
            this.bt_delete_spieler.TabIndex = 7;
            this.bt_delete_spieler.Text = "delete";
            this.bt_delete_spieler.UseVisualStyleBackColor = true;
            this.bt_delete_spieler.Click += new System.EventHandler(this.bt_delete_spieler_Click);
            // 
            // dgv_spieler
            // 
            this.dgv_spieler.AllowUserToAddRows = false;
            this.dgv_spieler.AllowUserToDeleteRows = false;
            this.dgv_spieler.AllowUserToOrderColumns = true;
            this.dgv_spieler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_spieler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_spieler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_spieler.Location = new System.Drawing.Point(8, 6);
            this.dgv_spieler.Name = "dgv_spieler";
            this.dgv_spieler.ReadOnly = true;
            this.dgv_spieler.RowHeadersWidth = 51;
            this.dgv_spieler.RowTemplate.Height = 29;
            this.dgv_spieler.Size = new System.Drawing.Size(776, 304);
            this.dgv_spieler.TabIndex = 6;
            // 
            // bt_insert_spieler
            // 
            this.bt_insert_spieler.Location = new System.Drawing.Point(312, 327);
            this.bt_insert_spieler.Name = "bt_insert_spieler";
            this.bt_insert_spieler.Size = new System.Drawing.Size(191, 58);
            this.bt_insert_spieler.TabIndex = 2;
            this.bt_insert_spieler.Text = "insert";
            this.bt_insert_spieler.UseVisualStyleBackColor = true;
            this.bt_insert_spieler.Click += new System.EventHandler(this.bt_insert_spieler_Click);
            // 
            // bt_update_spieler
            // 
            this.bt_update_spieler.Location = new System.Drawing.Point(44, 327);
            this.bt_update_spieler.Name = "bt_update_spieler";
            this.bt_update_spieler.Size = new System.Drawing.Size(191, 58);
            this.bt_update_spieler.TabIndex = 1;
            this.bt_update_spieler.Text = "update";
            this.bt_update_spieler.UseVisualStyleBackColor = true;
            this.bt_update_spieler.Click += new System.EventHandler(this.bt_update_spieler_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_delete_club);
            this.tabPage2.Controls.Add(this.bt_insert_club);
            this.tabPage2.Controls.Add(this.bt_update_club);
            this.tabPage2.Controls.Add(this.dgv_club);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Club";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_insert_club
            // 
            this.bt_insert_club.Location = new System.Drawing.Point(312, 327);
            this.bt_insert_club.Name = "bt_insert_club";
            this.bt_insert_club.Size = new System.Drawing.Size(191, 58);
            this.bt_insert_club.TabIndex = 7;
            this.bt_insert_club.Text = "insert";
            this.bt_insert_club.UseVisualStyleBackColor = true;
            this.bt_insert_club.Click += new System.EventHandler(this.bt_insert_club_Click);
            // 
            // bt_update_club
            // 
            this.bt_update_club.Location = new System.Drawing.Point(44, 327);
            this.bt_update_club.Name = "bt_update_club";
            this.bt_update_club.Size = new System.Drawing.Size(191, 58);
            this.bt_update_club.TabIndex = 6;
            this.bt_update_club.Text = "update";
            this.bt_update_club.UseVisualStyleBackColor = true;
            // 
            // dgv_club
            // 
            this.dgv_club.AllowUserToAddRows = false;
            this.dgv_club.AllowUserToDeleteRows = false;
            this.dgv_club.AllowUserToOrderColumns = true;
            this.dgv_club.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_club.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_club.Location = new System.Drawing.Point(8, 6);
            this.dgv_club.Name = "dgv_club";
            this.dgv_club.ReadOnly = true;
            this.dgv_club.RowHeadersWidth = 51;
            this.dgv_club.RowTemplate.Height = 29;
            this.dgv_club.Size = new System.Drawing.Size(776, 304);
            this.dgv_club.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bt_delete_trainer);
            this.tabPage3.Controls.Add(this.bt_insert_trainer);
            this.tabPage3.Controls.Add(this.bt_update_trainer);
            this.tabPage3.Controls.Add(this.dgv_trainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trainer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_delete_trainer
            // 
            this.bt_delete_trainer.Location = new System.Drawing.Point(573, 327);
            this.bt_delete_trainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_delete_trainer.Name = "bt_delete_trainer";
            this.bt_delete_trainer.Size = new System.Drawing.Size(191, 58);
            this.bt_delete_trainer.TabIndex = 10;
            this.bt_delete_trainer.Text = "delete";
            this.bt_delete_trainer.UseVisualStyleBackColor = true;
            this.bt_delete_trainer.Click += new System.EventHandler(this.bt_delete_trainer_Click);
            // 
            // bt_insert_trainer
            // 
            this.bt_insert_trainer.Location = new System.Drawing.Point(312, 327);
            this.bt_insert_trainer.Name = "bt_insert_trainer";
            this.bt_insert_trainer.Size = new System.Drawing.Size(191, 58);
            this.bt_insert_trainer.TabIndex = 7;
            this.bt_insert_trainer.Text = "insert";
            this.bt_insert_trainer.UseVisualStyleBackColor = true;
            this.bt_insert_trainer.Click += new System.EventHandler(this.bt_insert_trainer_Click);
            // 
            // bt_update_trainer
            // 
            this.bt_update_trainer.Location = new System.Drawing.Point(44, 327);
            this.bt_update_trainer.Name = "bt_update_trainer";
            this.bt_update_trainer.Size = new System.Drawing.Size(191, 58);
            this.bt_update_trainer.TabIndex = 6;
            this.bt_update_trainer.Text = "update";
            this.bt_update_trainer.UseVisualStyleBackColor = true;
            this.bt_update_trainer.Click += new System.EventHandler(this.bt_update_trainer_Click);
            // 
            // dgv_trainer
            // 
            this.dgv_trainer.AllowUserToAddRows = false;
            this.dgv_trainer.AllowUserToDeleteRows = false;
            this.dgv_trainer.AllowUserToOrderColumns = true;
            this.dgv_trainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_trainer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_trainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trainer.Location = new System.Drawing.Point(8, 6);
            this.dgv_trainer.Name = "dgv_trainer";
            this.dgv_trainer.ReadOnly = true;
            this.dgv_trainer.RowHeadersWidth = 51;
            this.dgv_trainer.RowTemplate.Height = 29;
            this.dgv_trainer.Size = new System.Drawing.Size(776, 304);
            this.dgv_trainer.TabIndex = 5;
            // 
            // bt_delete_club
            // 
            this.bt_delete_club.Location = new System.Drawing.Point(573, 327);
            this.bt_delete_club.Name = "bt_delete_club";
            this.bt_delete_club.Size = new System.Drawing.Size(191, 58);
            this.bt_delete_club.TabIndex = 8;
            this.bt_delete_club.Text = "delete";
            this.bt_delete_club.UseVisualStyleBackColor = true;
            // 
            // default_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "default_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChampionsLeague Database";
            this.Activated += new System.EventHandler(this.default_form_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_spieler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_club)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button bt_insert_spieler;
        private Button bt_update_spieler;
        private TabPage tabPage2;
        private Button bt_insert_club;
        private Button bt_update_club;
        private DataGridView dgv_club;
        private TabPage tabPage3;
        private Button bt_insert_trainer;
        private Button bt_update_trainer;
        private DataGridView dgv_trainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgv_spieler;
        private Button bt_delete_spieler;
        private Button bt_delete_trainer;
        private Button bt_delete_club;
    }
}