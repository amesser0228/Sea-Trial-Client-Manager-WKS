namespace Sea_Trials_Script_Launcher
{
    partial class dataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataBaseForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cheklistSaveBtn = new System.Windows.Forms.Button();
            this.loadCKLBtn = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GettingUnderway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveRollOvers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Department,
            this.TeamLead,
            this.GettingUnderway,
            this.ActiveRollOvers,
            this.ClosedOut,
            this.Notes});
            this.dataGridView1.Location = new System.Drawing.Point(150, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Closeout Checklist";
            // 
            // cheklistSaveBtn
            // 
            this.cheklistSaveBtn.Location = new System.Drawing.Point(394, 490);
            this.cheklistSaveBtn.Name = "cheklistSaveBtn";
            this.cheklistSaveBtn.Size = new System.Drawing.Size(93, 36);
            this.cheklistSaveBtn.TabIndex = 2;
            this.cheklistSaveBtn.Text = "Save";
            this.cheklistSaveBtn.UseVisualStyleBackColor = true;
            this.cheklistSaveBtn.Click += new System.EventHandler(this.cheklistSaveBtn_Click);
            // 
            // loadCKLBtn
            // 
            this.loadCKLBtn.Location = new System.Drawing.Point(493, 490);
            this.loadCKLBtn.Name = "loadCKLBtn";
            this.loadCKLBtn.Size = new System.Drawing.Size(93, 36);
            this.loadCKLBtn.TabIndex = 3;
            this.loadCKLBtn.Text = "Load CKL";
            this.loadCKLBtn.UseVisualStyleBackColor = true;
            this.loadCKLBtn.Click += new System.EventHandler(this.loadCKLBtn_Click);
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // TeamLead
            // 
            this.TeamLead.HeaderText = "TeamLead";
            this.TeamLead.Name = "TeamLead";
            // 
            // GettingUnderway
            // 
            this.GettingUnderway.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GettingUnderway.HeaderText = "GettingUnderway";
            this.GettingUnderway.Name = "GettingUnderway";
            this.GettingUnderway.Width = 114;
            // 
            // ActiveRollOvers
            // 
            this.ActiveRollOvers.HeaderText = "ActiveRollOvers";
            this.ActiveRollOvers.Name = "ActiveRollOvers";
            // 
            // ClosedOut
            // 
            this.ClosedOut.HeaderText = "ClosedOut";
            this.ClosedOut.Name = "ClosedOut";
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sea_Trials_Script_Launcher.Properties.Resources.checkList_Ico;
            this.pictureBox1.Location = new System.Drawing.Point(870, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadCKLBtn);
            this.Controls.Add(this.cheklistSaveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dataBaseForm";
            this.Text = "Closeout Checklist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Checklist_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cheklistSaveBtn;
        private System.Windows.Forms.Button loadCKLBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn GettingUnderway;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveRollOvers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}