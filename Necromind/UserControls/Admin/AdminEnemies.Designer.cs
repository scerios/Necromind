
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
            this.labEnemyAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbAddDmgMax = new System.Windows.Forms.TextBox();
            this.tbAddHealth = new System.Windows.Forms.TextBox();
            this.tbAddDef = new System.Windows.Forms.TextBox();
            this.tbAddDmgMin = new System.Windows.Forms.TextBox();
            this.tbAddGold = new System.Windows.Forms.TextBox();
            this.tbAddLvl = new System.Windows.Forms.TextBox();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.labHealthL = new System.Windows.Forms.Label();
            this.labDefL = new System.Windows.Forms.Label();
            this.labDmgL = new System.Windows.Forms.Label();
            this.labGoldL = new System.Windows.Forms.Label();
            this.labLvlL = new System.Windows.Forms.Label();
            this.labNameL = new System.Windows.Forms.Label();
            this.panDivider = new System.Windows.Forms.Panel();
            this.panEdit = new System.Windows.Forms.Panel();
            this.labEnemyEdit = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbEditDmgMax = new System.Windows.Forms.TextBox();
            this.tbEditHealth = new System.Windows.Forms.TextBox();
            this.tbEditDef = new System.Windows.Forms.TextBox();
            this.tbEditDmgMin = new System.Windows.Forms.TextBox();
            this.tbEditGold = new System.Windows.Forms.TextBox();
            this.tbEditLvl = new System.Windows.Forms.TextBox();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.labHealthR = new System.Windows.Forms.Label();
            this.labDefR = new System.Windows.Forms.Label();
            this.labDmgR = new System.Windows.Forms.Label();
            this.labGoldR = new System.Windows.Forms.Label();
            this.labLvlR = new System.Windows.Forms.Label();
            this.labNameR = new System.Windows.Forms.Label();
            this.lbEnemies = new System.Windows.Forms.ListBox();
            this.timHideAdd = new System.Windows.Forms.Timer(this.components);
            this.timHideEdit = new System.Windows.Forms.Timer(this.components);
            this.panAdd.SuspendLayout();
            this.panEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panAdd
            // 
            this.panAdd.Controls.Add(this.labEnemyAdd);
            this.panAdd.Controls.Add(this.btnAdd);
            this.panAdd.Controls.Add(this.tbAddDmgMax);
            this.panAdd.Controls.Add(this.tbAddHealth);
            this.panAdd.Controls.Add(this.tbAddDef);
            this.panAdd.Controls.Add(this.tbAddDmgMin);
            this.panAdd.Controls.Add(this.tbAddGold);
            this.panAdd.Controls.Add(this.tbAddLvl);
            this.panAdd.Controls.Add(this.tbAddName);
            this.panAdd.Controls.Add(this.labHealthL);
            this.panAdd.Controls.Add(this.labDefL);
            this.panAdd.Controls.Add(this.labDmgL);
            this.panAdd.Controls.Add(this.labGoldL);
            this.panAdd.Controls.Add(this.labLvlL);
            this.panAdd.Controls.Add(this.labNameL);
            this.panAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAdd.Location = new System.Drawing.Point(0, 0);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(540, 471);
            this.panAdd.TabIndex = 0;
            // 
            // labEnemyAdd
            // 
            this.labEnemyAdd.AutoSize = true;
            this.labEnemyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyAdd.Location = new System.Drawing.Point(150, 430);
            this.labEnemyAdd.Name = "labEnemyAdd";
            this.labEnemyAdd.Size = new System.Drawing.Size(0, 16);
            this.labEnemyAdd.TabIndex = 33;
            this.labEnemyAdd.Visible = false;
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
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbAddDmgMax
            // 
            this.tbAddDmgMax.BackColor = System.Drawing.Color.White;
            this.tbAddDmgMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddDmgMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddDmgMax.Location = new System.Drawing.Point(165, 107);
            this.tbAddDmgMax.Name = "tbAddDmgMax";
            this.tbAddDmgMax.Size = new System.Drawing.Size(60, 22);
            this.tbAddDmgMax.TabIndex = 31;
            this.tbAddDmgMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddHealth
            // 
            this.tbAddHealth.BackColor = System.Drawing.Color.White;
            this.tbAddHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddHealth.Location = new System.Drawing.Point(100, 167);
            this.tbAddHealth.Name = "tbAddHealth";
            this.tbAddHealth.Size = new System.Drawing.Size(125, 22);
            this.tbAddHealth.TabIndex = 30;
            this.tbAddHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddDef
            // 
            this.tbAddDef.BackColor = System.Drawing.Color.White;
            this.tbAddDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddDef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddDef.Location = new System.Drawing.Point(100, 137);
            this.tbAddDef.Name = "tbAddDef";
            this.tbAddDef.Size = new System.Drawing.Size(125, 22);
            this.tbAddDef.TabIndex = 29;
            this.tbAddDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddDmgMin
            // 
            this.tbAddDmgMin.BackColor = System.Drawing.Color.White;
            this.tbAddDmgMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddDmgMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddDmgMin.Location = new System.Drawing.Point(100, 107);
            this.tbAddDmgMin.Name = "tbAddDmgMin";
            this.tbAddDmgMin.Size = new System.Drawing.Size(60, 22);
            this.tbAddDmgMin.TabIndex = 28;
            this.tbAddDmgMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddGold
            // 
            this.tbAddGold.BackColor = System.Drawing.Color.White;
            this.tbAddGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddGold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddGold.Location = new System.Drawing.Point(100, 77);
            this.tbAddGold.Name = "tbAddGold";
            this.tbAddGold.Size = new System.Drawing.Size(125, 22);
            this.tbAddGold.TabIndex = 27;
            this.tbAddGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddLvl
            // 
            this.tbAddLvl.BackColor = System.Drawing.Color.White;
            this.tbAddLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddLvl.Location = new System.Drawing.Point(100, 47);
            this.tbAddLvl.Name = "tbAddLvl";
            this.tbAddLvl.Size = new System.Drawing.Size(125, 22);
            this.tbAddLvl.TabIndex = 26;
            this.tbAddLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAddName
            // 
            this.tbAddName.BackColor = System.Drawing.Color.White;
            this.tbAddName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbAddName.Location = new System.Drawing.Point(100, 17);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(125, 22);
            this.tbAddName.TabIndex = 25;
            this.tbAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHealthL
            // 
            this.labHealthL.AutoSize = true;
            this.labHealthL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthL.Location = new System.Drawing.Point(20, 170);
            this.labHealthL.Name = "labHealthL";
            this.labHealthL.Size = new System.Drawing.Size(64, 16);
            this.labHealthL.TabIndex = 24;
            this.labHealthL.Text = "Health:";
            // 
            // labDefL
            // 
            this.labDefL.AutoSize = true;
            this.labDefL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefL.Location = new System.Drawing.Point(20, 140);
            this.labDefL.Name = "labDefL";
            this.labDefL.Size = new System.Drawing.Size(72, 16);
            this.labDefL.TabIndex = 23;
            this.labDefL.Text = "Defense:";
            // 
            // labDmgL
            // 
            this.labDmgL.AutoSize = true;
            this.labDmgL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgL.Location = new System.Drawing.Point(20, 110);
            this.labDmgL.Name = "labDmgL";
            this.labDmgL.Size = new System.Drawing.Size(64, 16);
            this.labDmgL.TabIndex = 22;
            this.labDmgL.Text = "Damage:";
            // 
            // labGoldL
            // 
            this.labGoldL.AutoSize = true;
            this.labGoldL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldL.Location = new System.Drawing.Point(20, 80);
            this.labGoldL.Name = "labGoldL";
            this.labGoldL.Size = new System.Drawing.Size(48, 16);
            this.labGoldL.TabIndex = 21;
            this.labGoldL.Text = "Gold:";
            // 
            // labLvlL
            // 
            this.labLvlL.AutoSize = true;
            this.labLvlL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlL.Location = new System.Drawing.Point(20, 50);
            this.labLvlL.Name = "labLvlL";
            this.labLvlL.Size = new System.Drawing.Size(56, 16);
            this.labLvlL.TabIndex = 20;
            this.labLvlL.Text = "Level:";
            // 
            // labNameL
            // 
            this.labNameL.AutoSize = true;
            this.labNameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameL.Location = new System.Drawing.Point(20, 20);
            this.labNameL.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameL.Name = "labNameL";
            this.labNameL.Size = new System.Drawing.Size(48, 20);
            this.labNameL.TabIndex = 19;
            this.labNameL.Text = "Name:";
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
            this.panEdit.Controls.Add(this.labEnemyEdit);
            this.panEdit.Controls.Add(this.btnDel);
            this.panEdit.Controls.Add(this.btnEdit);
            this.panEdit.Controls.Add(this.tbEditDmgMax);
            this.panEdit.Controls.Add(this.tbEditHealth);
            this.panEdit.Controls.Add(this.tbEditDef);
            this.panEdit.Controls.Add(this.tbEditDmgMin);
            this.panEdit.Controls.Add(this.tbEditGold);
            this.panEdit.Controls.Add(this.tbEditLvl);
            this.panEdit.Controls.Add(this.tbEditName);
            this.panEdit.Controls.Add(this.labHealthR);
            this.panEdit.Controls.Add(this.labDefR);
            this.panEdit.Controls.Add(this.labDmgR);
            this.panEdit.Controls.Add(this.labGoldR);
            this.panEdit.Controls.Add(this.labLvlR);
            this.panEdit.Controls.Add(this.labNameR);
            this.panEdit.Controls.Add(this.lbEnemies);
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panEdit.Location = new System.Drawing.Point(544, 0);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(540, 471);
            this.panEdit.TabIndex = 3;
            // 
            // labEnemyEdit
            // 
            this.labEnemyEdit.AutoSize = true;
            this.labEnemyEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyEdit.Location = new System.Drawing.Point(140, 430);
            this.labEnemyEdit.Name = "labEnemyEdit";
            this.labEnemyEdit.Size = new System.Drawing.Size(0, 16);
            this.labEnemyEdit.TabIndex = 35;
            this.labEnemyEdit.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(20, 426);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 25);
            this.btnDel.TabIndex = 34;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(420, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbEditDmgMax
            // 
            this.tbEditDmgMax.BackColor = System.Drawing.Color.White;
            this.tbEditDmgMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditDmgMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditDmgMax.Location = new System.Drawing.Point(345, 122);
            this.tbEditDmgMax.Name = "tbEditDmgMax";
            this.tbEditDmgMax.Size = new System.Drawing.Size(60, 22);
            this.tbEditDmgMax.TabIndex = 32;
            this.tbEditDmgMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditHealth
            // 
            this.tbEditHealth.BackColor = System.Drawing.Color.White;
            this.tbEditHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditHealth.Location = new System.Drawing.Point(280, 182);
            this.tbEditHealth.Name = "tbEditHealth";
            this.tbEditHealth.Size = new System.Drawing.Size(125, 22);
            this.tbEditHealth.TabIndex = 31;
            this.tbEditHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditDef
            // 
            this.tbEditDef.BackColor = System.Drawing.Color.White;
            this.tbEditDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditDef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditDef.Location = new System.Drawing.Point(280, 152);
            this.tbEditDef.Name = "tbEditDef";
            this.tbEditDef.Size = new System.Drawing.Size(125, 22);
            this.tbEditDef.TabIndex = 30;
            this.tbEditDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditDmgMin
            // 
            this.tbEditDmgMin.BackColor = System.Drawing.Color.White;
            this.tbEditDmgMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditDmgMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditDmgMin.Location = new System.Drawing.Point(280, 122);
            this.tbEditDmgMin.Name = "tbEditDmgMin";
            this.tbEditDmgMin.Size = new System.Drawing.Size(60, 22);
            this.tbEditDmgMin.TabIndex = 29;
            this.tbEditDmgMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditGold
            // 
            this.tbEditGold.BackColor = System.Drawing.Color.White;
            this.tbEditGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditGold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditGold.Location = new System.Drawing.Point(280, 92);
            this.tbEditGold.Name = "tbEditGold";
            this.tbEditGold.Size = new System.Drawing.Size(125, 22);
            this.tbEditGold.TabIndex = 28;
            this.tbEditGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditLvl
            // 
            this.tbEditLvl.BackColor = System.Drawing.Color.White;
            this.tbEditLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditLvl.Location = new System.Drawing.Point(280, 62);
            this.tbEditLvl.Name = "tbEditLvl";
            this.tbEditLvl.Size = new System.Drawing.Size(125, 22);
            this.tbEditLvl.TabIndex = 27;
            this.tbEditLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditName
            // 
            this.tbEditName.BackColor = System.Drawing.Color.White;
            this.tbEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditName.Location = new System.Drawing.Point(280, 32);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(125, 22);
            this.tbEditName.TabIndex = 26;
            this.tbEditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHealthR
            // 
            this.labHealthR.AutoSize = true;
            this.labHealthR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthR.Location = new System.Drawing.Point(200, 185);
            this.labHealthR.Name = "labHealthR";
            this.labHealthR.Size = new System.Drawing.Size(64, 16);
            this.labHealthR.TabIndex = 25;
            this.labHealthR.Text = "Health:";
            // 
            // labDefR
            // 
            this.labDefR.AutoSize = true;
            this.labDefR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefR.Location = new System.Drawing.Point(200, 155);
            this.labDefR.Name = "labDefR";
            this.labDefR.Size = new System.Drawing.Size(72, 16);
            this.labDefR.TabIndex = 24;
            this.labDefR.Text = "Defense:";
            // 
            // labDmgR
            // 
            this.labDmgR.AutoSize = true;
            this.labDmgR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgR.Location = new System.Drawing.Point(200, 125);
            this.labDmgR.Name = "labDmgR";
            this.labDmgR.Size = new System.Drawing.Size(64, 16);
            this.labDmgR.TabIndex = 23;
            this.labDmgR.Text = "Damage:";
            // 
            // labGoldR
            // 
            this.labGoldR.AutoSize = true;
            this.labGoldR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldR.Location = new System.Drawing.Point(200, 95);
            this.labGoldR.Name = "labGoldR";
            this.labGoldR.Size = new System.Drawing.Size(48, 16);
            this.labGoldR.TabIndex = 22;
            this.labGoldR.Text = "Gold:";
            // 
            // labLvlR
            // 
            this.labLvlR.AutoSize = true;
            this.labLvlR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlR.Location = new System.Drawing.Point(200, 65);
            this.labLvlR.Name = "labLvlR";
            this.labLvlR.Size = new System.Drawing.Size(56, 16);
            this.labLvlR.TabIndex = 21;
            this.labLvlR.Text = "Level:";
            // 
            // labNameR
            // 
            this.labNameR.AutoSize = true;
            this.labNameR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameR.Location = new System.Drawing.Point(200, 35);
            this.labNameR.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameR.Name = "labNameR";
            this.labNameR.Size = new System.Drawing.Size(48, 20);
            this.labNameR.TabIndex = 20;
            this.labNameR.Text = "Name:";
            // 
            // lbEnemies
            // 
            this.lbEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbEnemies.FormattingEnabled = true;
            this.lbEnemies.ItemHeight = 16;
            this.lbEnemies.Location = new System.Drawing.Point(20, 20);
            this.lbEnemies.Name = "lbEnemies";
            this.lbEnemies.Size = new System.Drawing.Size(150, 196);
            this.lbEnemies.TabIndex = 19;
            this.lbEnemies.SelectedIndexChanged += new System.EventHandler(this.LbEnemies_SelectedIndexChanged);
            // 
            // timHideAdd
            // 
            this.timHideAdd.Interval = 3000;
            this.timHideAdd.Tick += new System.EventHandler(this.TimHideAdd_Tick);
            // 
            // timHideEdit
            // 
            this.timHideEdit.Interval = 3000;
            this.timHideEdit.Tick += new System.EventHandler(this.TimHideEdit_Tick);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminEnemies";
            this.Size = new System.Drawing.Size(1084, 471);
            this.panAdd.ResumeLayout(false);
            this.panAdd.PerformLayout();
            this.panEdit.ResumeLayout(false);
            this.panEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panAdd;
        private System.Windows.Forms.Panel panDivider;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.TextBox tbAddDmgMax;
        private System.Windows.Forms.TextBox tbAddHealth;
        private System.Windows.Forms.TextBox tbAddDef;
        private System.Windows.Forms.TextBox tbAddDmgMin;
        private System.Windows.Forms.TextBox tbAddGold;
        private System.Windows.Forms.TextBox tbAddLvl;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label labHealthL;
        private System.Windows.Forms.Label labDefL;
        private System.Windows.Forms.Label labDmgL;
        private System.Windows.Forms.Label labGoldL;
        private System.Windows.Forms.Label labLvlL;
        private System.Windows.Forms.Label labNameL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labEnemyAdd;
        private System.Windows.Forms.Timer timHideAdd;
        private System.Windows.Forms.TextBox tbEditDmgMax;
        private System.Windows.Forms.TextBox tbEditHealth;
        private System.Windows.Forms.TextBox tbEditDef;
        private System.Windows.Forms.TextBox tbEditDmgMin;
        private System.Windows.Forms.TextBox tbEditGold;
        private System.Windows.Forms.TextBox tbEditLvl;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label labHealthR;
        private System.Windows.Forms.Label labDefR;
        private System.Windows.Forms.Label labDmgR;
        private System.Windows.Forms.Label labGoldR;
        private System.Windows.Forms.Label labLvlR;
        private System.Windows.Forms.Label labNameR;
        private System.Windows.Forms.ListBox lbEnemies;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label labEnemyEdit;
        private System.Windows.Forms.Timer timHideEdit;
    }
}
