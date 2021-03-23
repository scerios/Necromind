
namespace NecromindUI.UserControls.Admin
{
    partial class AdminEnemies
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panAdd = new System.Windows.Forms.Panel();
            this.panDivider = new System.Windows.Forms.Panel();
            this.panEdit = new System.Windows.Forms.Panel();
            this.tbDmgMax = new System.Windows.Forms.TextBox();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.tbDef = new System.Windows.Forms.TextBox();
            this.tbDmgMin = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.tbLvl = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labHealth = new System.Windows.Forms.Label();
            this.labDef = new System.Windows.Forms.Label();
            this.labDmg = new System.Windows.Forms.Label();
            this.labGold = new System.Windows.Forms.Label();
            this.labLvl = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labEnemyAdded = new System.Windows.Forms.Label();
            this.timHide = new System.Windows.Forms.Timer(this.components);
            this.panAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panAdd
            // 
            this.panAdd.Controls.Add(this.labEnemyAdded);
            this.panAdd.Controls.Add(this.btnAdd);
            this.panAdd.Controls.Add(this.tbDmgMax);
            this.panAdd.Controls.Add(this.tbHealth);
            this.panAdd.Controls.Add(this.tbDef);
            this.panAdd.Controls.Add(this.tbDmgMin);
            this.panAdd.Controls.Add(this.tbGold);
            this.panAdd.Controls.Add(this.tbLvl);
            this.panAdd.Controls.Add(this.tbName);
            this.panAdd.Controls.Add(this.labHealth);
            this.panAdd.Controls.Add(this.labDef);
            this.panAdd.Controls.Add(this.labDmg);
            this.panAdd.Controls.Add(this.labGold);
            this.panAdd.Controls.Add(this.labLvl);
            this.panAdd.Controls.Add(this.labName);
            this.panAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAdd.Location = new System.Drawing.Point(0, 0);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(540, 471);
            this.panAdd.TabIndex = 0;
            // 
            // panDivider
            // 
            this.panDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panDivider.Location = new System.Drawing.Point(540, 0);
            this.panDivider.Name = "panDivider";
            this.panDivider.Size = new System.Drawing.Size(4, 471);
            this.panDivider.TabIndex = 2;
            // 
            // panEdit
            // 
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panEdit.Location = new System.Drawing.Point(544, 0);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(540, 471);
            this.panEdit.TabIndex = 3;
            // 
            // tbDmgMax
            // 
            this.tbDmgMax.BackColor = System.Drawing.Color.White;
            this.tbDmgMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDmgMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDmgMax.Location = new System.Drawing.Point(165, 107);
            this.tbDmgMax.Name = "tbDmgMax";
            this.tbDmgMax.Size = new System.Drawing.Size(60, 22);
            this.tbDmgMax.TabIndex = 31;
            this.tbDmgMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHealth
            // 
            this.tbHealth.BackColor = System.Drawing.Color.White;
            this.tbHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbHealth.Location = new System.Drawing.Point(100, 167);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.Size = new System.Drawing.Size(125, 22);
            this.tbHealth.TabIndex = 30;
            this.tbHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDef
            // 
            this.tbDef.BackColor = System.Drawing.Color.White;
            this.tbDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDef.Location = new System.Drawing.Point(100, 137);
            this.tbDef.Name = "tbDef";
            this.tbDef.Size = new System.Drawing.Size(125, 22);
            this.tbDef.TabIndex = 29;
            this.tbDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDmgMin
            // 
            this.tbDmgMin.BackColor = System.Drawing.Color.White;
            this.tbDmgMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDmgMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDmgMin.Location = new System.Drawing.Point(100, 107);
            this.tbDmgMin.Name = "tbDmgMin";
            this.tbDmgMin.Size = new System.Drawing.Size(60, 22);
            this.tbDmgMin.TabIndex = 28;
            this.tbDmgMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGold
            // 
            this.tbGold.BackColor = System.Drawing.Color.White;
            this.tbGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGold.Location = new System.Drawing.Point(100, 77);
            this.tbGold.Name = "tbGold";
            this.tbGold.Size = new System.Drawing.Size(125, 22);
            this.tbGold.TabIndex = 27;
            this.tbGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLvl
            // 
            this.tbLvl.BackColor = System.Drawing.Color.White;
            this.tbLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbLvl.Location = new System.Drawing.Point(100, 47);
            this.tbLvl.Name = "tbLvl";
            this.tbLvl.Size = new System.Drawing.Size(125, 22);
            this.tbLvl.TabIndex = 26;
            this.tbLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbName.Location = new System.Drawing.Point(100, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 22);
            this.tbName.TabIndex = 25;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHealth
            // 
            this.labHealth.AutoSize = true;
            this.labHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealth.Location = new System.Drawing.Point(20, 170);
            this.labHealth.Name = "labHealth";
            this.labHealth.Size = new System.Drawing.Size(64, 16);
            this.labHealth.TabIndex = 24;
            this.labHealth.Text = "Health:";
            // 
            // labDef
            // 
            this.labDef.AutoSize = true;
            this.labDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDef.Location = new System.Drawing.Point(20, 140);
            this.labDef.Name = "labDef";
            this.labDef.Size = new System.Drawing.Size(72, 16);
            this.labDef.TabIndex = 23;
            this.labDef.Text = "Defense:";
            // 
            // labDmg
            // 
            this.labDmg.AutoSize = true;
            this.labDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmg.Location = new System.Drawing.Point(20, 110);
            this.labDmg.Name = "labDmg";
            this.labDmg.Size = new System.Drawing.Size(64, 16);
            this.labDmg.TabIndex = 22;
            this.labDmg.Text = "Damage:";
            // 
            // labGold
            // 
            this.labGold.AutoSize = true;
            this.labGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGold.Location = new System.Drawing.Point(20, 80);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(48, 16);
            this.labGold.TabIndex = 21;
            this.labGold.Text = "Gold:";
            // 
            // labLvl
            // 
            this.labLvl.AutoSize = true;
            this.labLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvl.Location = new System.Drawing.Point(20, 50);
            this.labLvl.Name = "labLvl";
            this.labLvl.Size = new System.Drawing.Size(56, 16);
            this.labLvl.TabIndex = 20;
            this.labLvl.Text = "Level:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(20, 20);
            this.labName.MinimumSize = new System.Drawing.Size(0, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 20);
            this.labName.TabIndex = 19;
            this.labName.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(420, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // labEnemyAdded
            // 
            this.labEnemyAdded.AutoSize = true;
            this.labEnemyAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyAdded.Location = new System.Drawing.Point(200, 430);
            this.labEnemyAdded.Name = "labEnemyAdded";
            this.labEnemyAdded.Size = new System.Drawing.Size(0, 16);
            this.labEnemyAdded.TabIndex = 33;
            this.labEnemyAdded.Visible = false;
            // 
            // timHide
            // 
            this.timHide.Interval = 3000;
            // 
            // AdminEnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.panDivider);
            this.Controls.Add(this.panAdd);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminEnemies";
            this.Size = new System.Drawing.Size(1084, 471);
            this.panAdd.ResumeLayout(false);
            this.panAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panAdd;
        private System.Windows.Forms.Panel panDivider;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.TextBox tbDmgMax;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.TextBox tbDef;
        private System.Windows.Forms.TextBox tbDmgMin;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.TextBox tbLvl;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labHealth;
        private System.Windows.Forms.Label labDef;
        private System.Windows.Forms.Label labDmg;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Label labLvl;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labEnemyAdded;
        private System.Windows.Forms.Timer timHide;
    }
}
