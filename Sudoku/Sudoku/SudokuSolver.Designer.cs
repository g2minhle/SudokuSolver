namespace Sudoku
{
    partial class frm_Sukudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sukudo));
            this.pn_Table = new System.Windows.Forms.Panel();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.cmd_Slove = new System.Windows.Forms.Button();
            this.cmd_New = new System.Windows.Forms.Button();
            this.cmd_EnabledAll = new System.Windows.Forms.Button();
            this.cmd_EmptyTheAnswers = new System.Windows.Forms.Button();
            this.gb_Group = new System.Windows.Forms.GroupBox();
            this.gb_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Table
            // 
            this.pn_Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_Table.Location = new System.Drawing.Point(6, 12);
            this.pn_Table.Name = "pn_Table";
            this.pn_Table.Size = new System.Drawing.Size(378, 338);
            this.pn_Table.TabIndex = 0;
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Exit.Location = new System.Drawing.Point(305, 391);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(75, 23);
            this.cmd_Exit.TabIndex = 12;
            this.cmd_Exit.Text = "Exit";
            this.cmd_Exit.UseVisualStyleBackColor = true;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // cmd_Slove
            // 
            this.cmd_Slove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_Slove.Location = new System.Drawing.Point(224, 391);
            this.cmd_Slove.Name = "cmd_Slove";
            this.cmd_Slove.Size = new System.Drawing.Size(75, 23);
            this.cmd_Slove.TabIndex = 11;
            this.cmd_Slove.Text = "Solve";
            this.cmd_Slove.UseVisualStyleBackColor = true;
            this.cmd_Slove.Click += new System.EventHandler(this.cmd_Slove_Click);
            // 
            // cmd_New
            // 
            this.cmd_New.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_New.Location = new System.Drawing.Point(305, 362);
            this.cmd_New.Name = "cmd_New";
            this.cmd_New.Size = new System.Drawing.Size(75, 23);
            this.cmd_New.TabIndex = 10;
            this.cmd_New.Text = "NewTable";
            this.cmd_New.UseVisualStyleBackColor = true;
            this.cmd_New.Click += new System.EventHandler(this.cmd_New_Click);
            // 
            // cmd_EnabledAll
            // 
            this.cmd_EnabledAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_EnabledAll.Location = new System.Drawing.Point(224, 362);
            this.cmd_EnabledAll.Name = "cmd_EnabledAll";
            this.cmd_EnabledAll.Size = new System.Drawing.Size(75, 23);
            this.cmd_EnabledAll.TabIndex = 9;
            this.cmd_EnabledAll.Text = "Enabled All";
            this.cmd_EnabledAll.UseVisualStyleBackColor = true;
            this.cmd_EnabledAll.Click += new System.EventHandler(this.EnableAll_Click);
            // 
            // cmd_EmptyTheAnswers
            // 
            this.cmd_EmptyTheAnswers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmd_EmptyTheAnswers.Location = new System.Drawing.Point(87, 391);
            this.cmd_EmptyTheAnswers.Name = "cmd_EmptyTheAnswers";
            this.cmd_EmptyTheAnswers.Size = new System.Drawing.Size(131, 23);
            this.cmd_EmptyTheAnswers.TabIndex = 13;
            this.cmd_EmptyTheAnswers.Text = "Empty The Answers";
            this.cmd_EmptyTheAnswers.UseVisualStyleBackColor = true;
            this.cmd_EmptyTheAnswers.Click += new System.EventHandler(this.cmd_EmptyTheAnswers_Click);
            // 
            // gb_Group
            // 
            this.gb_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_Group.Controls.Add(this.pn_Table);
            this.gb_Group.Location = new System.Drawing.Point(0, 0);
            this.gb_Group.Name = "gb_Group";
            this.gb_Group.Size = new System.Drawing.Size(390, 356);
            this.gb_Group.TabIndex = 14;
            this.gb_Group.TabStop = false;
            // 
            // frm_Sukudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 426);
            this.Controls.Add(this.gb_Group);
            this.Controls.Add(this.cmd_EmptyTheAnswers);
            this.Controls.Add(this.cmd_EnabledAll);
            this.Controls.Add(this.cmd_New);
            this.Controls.Add(this.cmd_Slove);
            this.Controls.Add(this.cmd_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Sukudo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frm_Sukudo_Shown);
            this.gb_Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Table;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Button cmd_Slove;
        private System.Windows.Forms.Button cmd_New;
        private System.Windows.Forms.Button cmd_EnabledAll;
        private System.Windows.Forms.Button cmd_EmptyTheAnswers;
        private System.Windows.Forms.GroupBox gb_Group;
    }
}

