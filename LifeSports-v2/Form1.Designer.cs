namespace LifeSports_v2
{
    partial class Form1
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
            this.lbxMembers = new System.Windows.Forms.ListBox();
            this.lblSwim = new System.Windows.Forms.Label();
            this.lblBilliard = new System.Windows.Forms.Label();
            this.lblGym = new System.Windows.Forms.Label();
            this.lblDance = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAccess = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxMembers
            // 
            this.lbxMembers.FormattingEnabled = true;
            this.lbxMembers.ItemHeight = 16;
            this.lbxMembers.Location = new System.Drawing.Point(13, 13);
            this.lbxMembers.Name = "lbxMembers";
            this.lbxMembers.Size = new System.Drawing.Size(189, 212);
            this.lbxMembers.TabIndex = 0;
            // 
            // lblSwim
            // 
            this.lblSwim.BackColor = System.Drawing.Color.DimGray;
            this.lblSwim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSwim.Location = new System.Drawing.Point(208, 13);
            this.lblSwim.Name = "lblSwim";
            this.lblSwim.Size = new System.Drawing.Size(135, 42);
            this.lblSwim.TabIndex = 1;
            this.lblSwim.Text = "SwimmingPool";
            this.lblSwim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBilliard
            // 
            this.lblBilliard.BackColor = System.Drawing.Color.DimGray;
            this.lblBilliard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBilliard.Location = new System.Drawing.Point(208, 71);
            this.lblBilliard.Name = "lblBilliard";
            this.lblBilliard.Size = new System.Drawing.Size(135, 42);
            this.lblBilliard.TabIndex = 2;
            this.lblBilliard.Text = "Billiard/ Snooker";
            this.lblBilliard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGym
            // 
            this.lblGym.BackColor = System.Drawing.Color.DimGray;
            this.lblGym.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGym.Location = new System.Drawing.Point(208, 126);
            this.lblGym.Name = "lblGym";
            this.lblGym.Size = new System.Drawing.Size(135, 42);
            this.lblGym.TabIndex = 3;
            this.lblGym.Text = "Gym";
            this.lblGym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDance
            // 
            this.lblDance.BackColor = System.Drawing.Color.DimGray;
            this.lblDance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDance.Location = new System.Drawing.Point(208, 183);
            this.lblDance.Name = "lblDance";
            this.lblDance.Size = new System.Drawing.Size(135, 42);
            this.lblDance.TabIndex = 4;
            this.lblDance.Text = "Dance/ Ballet";
            this.lblDance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(180, 231);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 33);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Member";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblAccess
            // 
            this.lblAccess.BackColor = System.Drawing.Color.DimGray;
            this.lblAccess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccess.Location = new System.Drawing.Point(363, 71);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(194, 141);
            this.lblAccess.TabIndex = 7;
            this.lblAccess.Text = "Scan";
            this.lblAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(406, 33);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(110, 22);
            this.tbCode.TabIndex = 8;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(436, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 17);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Code:";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(363, 226);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(194, 35);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 273);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lblAccess);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDance);
            this.Controls.Add(this.lblGym);
            this.Controls.Add(this.lblBilliard);
            this.Controls.Add(this.lblSwim);
            this.Controls.Add(this.lbxMembers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMembers;
        private System.Windows.Forms.Label lblSwim;
        private System.Windows.Forms.Label lblBilliard;
        private System.Windows.Forms.Label lblGym;
        private System.Windows.Forms.Label lblDance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnScan;
    }
}

