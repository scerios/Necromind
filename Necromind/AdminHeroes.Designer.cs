
namespace Necromind
{
    partial class AdminHeroes
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
            this.lbHeroes = new System.Windows.Forms.ListBox();
            this.labName = new System.Windows.Forms.Label();
            this.labLvl = new System.Windows.Forms.Label();
            this.labGold = new System.Windows.Forms.Label();
            this.labDmg = new System.Windows.Forms.Label();
            this.labDef = new System.Windows.Forms.Label();
            this.labHealth = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLvl = new System.Windows.Forms.TextBox();
            this.tbGold = new System.Windows.Forms.TextBox();
            this.tbDmgMin = new System.Windows.Forms.TextBox();
            this.tbDef = new System.Windows.Forms.TextBox();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbDmgMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbHeroes
            // 
            this.lbHeroes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbHeroes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbHeroes.FormattingEnabled = true;
            this.lbHeroes.ItemHeight = 16;
            this.lbHeroes.Location = new System.Drawing.Point(20, 20);
            this.lbHeroes.Name = "lbHeroes";
            this.lbHeroes.Size = new System.Drawing.Size(150, 196);
            this.lbHeroes.TabIndex = 0;
            this.lbHeroes.SelectedIndexChanged += new System.EventHandler(this.LbHeroes_SelectedIndexChanged);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(220, 20);
            this.labName.MinimumSize = new System.Drawing.Size(0, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 20);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name:";
            // 
            // labLvl
            // 
            this.labLvl.AutoSize = true;
            this.labLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvl.Location = new System.Drawing.Point(220, 50);
            this.labLvl.Name = "labLvl";
            this.labLvl.Size = new System.Drawing.Size(56, 16);
            this.labLvl.TabIndex = 2;
            this.labLvl.Text = "Level:";
            // 
            // labGold
            // 
            this.labGold.AutoSize = true;
            this.labGold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGold.Location = new System.Drawing.Point(220, 80);
            this.labGold.Name = "labGold";
            this.labGold.Size = new System.Drawing.Size(48, 16);
            this.labGold.TabIndex = 3;
            this.labGold.Text = "Gold:";
            // 
            // labDmg
            // 
            this.labDmg.AutoSize = true;
            this.labDmg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmg.Location = new System.Drawing.Point(220, 110);
            this.labDmg.Name = "labDmg";
            this.labDmg.Size = new System.Drawing.Size(64, 16);
            this.labDmg.TabIndex = 4;
            this.labDmg.Text = "Damage:";
            // 
            // labDef
            // 
            this.labDef.AutoSize = true;
            this.labDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDef.Location = new System.Drawing.Point(220, 140);
            this.labDef.Name = "labDef";
            this.labDef.Size = new System.Drawing.Size(72, 16);
            this.labDef.TabIndex = 5;
            this.labDef.Text = "Defense:";
            // 
            // labHealth
            // 
            this.labHealth.AutoSize = true;
            this.labHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealth.Location = new System.Drawing.Point(220, 172);
            this.labHealth.Name = "labHealth";
            this.labHealth.Size = new System.Drawing.Size(64, 16);
            this.labHealth.TabIndex = 6;
            this.labHealth.Text = "Health:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbName.Location = new System.Drawing.Point(300, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 22);
            this.tbName.TabIndex = 7;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLvl
            // 
            this.tbLvl.BackColor = System.Drawing.Color.White;
            this.tbLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbLvl.Location = new System.Drawing.Point(300, 47);
            this.tbLvl.Name = "tbLvl";
            this.tbLvl.Size = new System.Drawing.Size(125, 22);
            this.tbLvl.TabIndex = 8;
            this.tbLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGold
            // 
            this.tbGold.BackColor = System.Drawing.Color.White;
            this.tbGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbGold.Location = new System.Drawing.Point(300, 77);
            this.tbGold.Name = "tbGold";
            this.tbGold.Size = new System.Drawing.Size(125, 22);
            this.tbGold.TabIndex = 9;
            this.tbGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDmgMin
            // 
            this.tbDmgMin.BackColor = System.Drawing.Color.White;
            this.tbDmgMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDmgMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDmgMin.Location = new System.Drawing.Point(300, 105);
            this.tbDmgMin.Name = "tbDmgMin";
            this.tbDmgMin.Size = new System.Drawing.Size(60, 22);
            this.tbDmgMin.TabIndex = 10;
            this.tbDmgMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDef
            // 
            this.tbDef.BackColor = System.Drawing.Color.White;
            this.tbDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDef.Location = new System.Drawing.Point(300, 137);
            this.tbDef.Name = "tbDef";
            this.tbDef.Size = new System.Drawing.Size(125, 22);
            this.tbDef.TabIndex = 11;
            this.tbDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHealth
            // 
            this.tbHealth.BackColor = System.Drawing.Color.White;
            this.tbHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbHealth.Location = new System.Drawing.Point(300, 169);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.Size = new System.Drawing.Size(125, 22);
            this.tbHealth.TabIndex = 12;
            this.tbHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(964, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbDmgMax
            // 
            this.tbDmgMax.BackColor = System.Drawing.Color.White;
            this.tbDmgMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDmgMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDmgMax.Location = new System.Drawing.Point(365, 105);
            this.tbDmgMax.Name = "tbDmgMax";
            this.tbDmgMax.Size = new System.Drawing.Size(60, 22);
            this.tbDmgMax.TabIndex = 18;
            this.tbDmgMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.tbDmgMax);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbHealth);
            this.Controls.Add(this.tbDef);
            this.Controls.Add(this.tbDmgMin);
            this.Controls.Add(this.tbGold);
            this.Controls.Add(this.tbLvl);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labHealth);
            this.Controls.Add(this.labDef);
            this.Controls.Add(this.labDmg);
            this.Controls.Add(this.labGold);
            this.Controls.Add(this.labLvl);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.lbHeroes);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHeroes";
            this.Size = new System.Drawing.Size(1084, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHeroes;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labLvl;
        private System.Windows.Forms.Label labGold;
        private System.Windows.Forms.Label labDmg;
        private System.Windows.Forms.Label labDef;
        private System.Windows.Forms.Label labHealth;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLvl;
        private System.Windows.Forms.TextBox tbGold;
        private System.Windows.Forms.TextBox tbDmgMin;
        private System.Windows.Forms.TextBox tbDef;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDmgMax;
    }
}
