
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
            this.panCreate = new System.Windows.Forms.Panel();
            this.labEnemyAdd = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbCreateDmgMax = new System.Windows.Forms.TextBox();
            this.tbCreateHealth = new System.Windows.Forms.TextBox();
            this.tbCreateDef = new System.Windows.Forms.TextBox();
            this.tbCreateDmgMin = new System.Windows.Forms.TextBox();
            this.tbCreateGold = new System.Windows.Forms.TextBox();
            this.tbCreateLvl = new System.Windows.Forms.TextBox();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.labHealthL = new System.Windows.Forms.Label();
            this.labDefL = new System.Windows.Forms.Label();
            this.labDmgL = new System.Windows.Forms.Label();
            this.labGoldL = new System.Windows.Forms.Label();
            this.labLvlL = new System.Windows.Forms.Label();
            this.labNameL = new System.Windows.Forms.Label();
            this.timHideCreate = new System.Windows.Forms.Timer(this.components);
            this.timHideEdit = new System.Windows.Forms.Timer(this.components);
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
            this.panCreate.SuspendLayout();
            this.panEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCreate
            // 
            this.panCreate.Controls.Add(this.labEnemyAdd);
            this.panCreate.Controls.Add(this.btnCreate);
            this.panCreate.Controls.Add(this.tbCreateDmgMax);
            this.panCreate.Controls.Add(this.tbCreateHealth);
            this.panCreate.Controls.Add(this.tbCreateDef);
            this.panCreate.Controls.Add(this.tbCreateDmgMin);
            this.panCreate.Controls.Add(this.tbCreateGold);
            this.panCreate.Controls.Add(this.tbCreateLvl);
            this.panCreate.Controls.Add(this.tbCreateName);
            this.panCreate.Controls.Add(this.labHealthL);
            this.panCreate.Controls.Add(this.labDefL);
            this.panCreate.Controls.Add(this.labDmgL);
            this.panCreate.Controls.Add(this.labGoldL);
            this.panCreate.Controls.Add(this.labLvlL);
            this.panCreate.Controls.Add(this.labNameL);
            this.panCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCreate.Location = new System.Drawing.Point(0, 0);
            this.panCreate.Name = "panCreate";
            this.panCreate.Size = new System.Drawing.Size(1084, 260);
            this.panCreate.TabIndex = 0;
            // 
            // labEnemyAdd
            // 
            this.labEnemyAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labEnemyAdd.AutoSize = true;
            this.labEnemyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyAdd.Location = new System.Drawing.Point(700, 219);
            this.labEnemyAdd.Name = "labEnemyAdd";
            this.labEnemyAdd.Size = new System.Drawing.Size(0, 16);
            this.labEnemyAdd.TabIndex = 33;
            this.labEnemyAdd.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(964, 215);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 25);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tbCreateDmgMax
            // 
            this.tbCreateDmgMax.BackColor = System.Drawing.Color.White;
            this.tbCreateDmgMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateDmgMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateDmgMax.Location = new System.Drawing.Point(165, 107);
            this.tbCreateDmgMax.Name = "tbCreateDmgMax";
            this.tbCreateDmgMax.Size = new System.Drawing.Size(60, 22);
            this.tbCreateDmgMax.TabIndex = 31;
            this.tbCreateDmgMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateHealth
            // 
            this.tbCreateHealth.BackColor = System.Drawing.Color.White;
            this.tbCreateHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateHealth.Location = new System.Drawing.Point(100, 167);
            this.tbCreateHealth.Name = "tbCreateHealth";
            this.tbCreateHealth.Size = new System.Drawing.Size(125, 22);
            this.tbCreateHealth.TabIndex = 30;
            this.tbCreateHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateDef
            // 
            this.tbCreateDef.BackColor = System.Drawing.Color.White;
            this.tbCreateDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateDef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateDef.Location = new System.Drawing.Point(100, 137);
            this.tbCreateDef.Name = "tbCreateDef";
            this.tbCreateDef.Size = new System.Drawing.Size(125, 22);
            this.tbCreateDef.TabIndex = 29;
            this.tbCreateDef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateDmgMin
            // 
            this.tbCreateDmgMin.BackColor = System.Drawing.Color.White;
            this.tbCreateDmgMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateDmgMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateDmgMin.Location = new System.Drawing.Point(100, 107);
            this.tbCreateDmgMin.Name = "tbCreateDmgMin";
            this.tbCreateDmgMin.Size = new System.Drawing.Size(60, 22);
            this.tbCreateDmgMin.TabIndex = 28;
            this.tbCreateDmgMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateGold
            // 
            this.tbCreateGold.BackColor = System.Drawing.Color.White;
            this.tbCreateGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateGold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateGold.Location = new System.Drawing.Point(100, 77);
            this.tbCreateGold.Name = "tbCreateGold";
            this.tbCreateGold.Size = new System.Drawing.Size(125, 22);
            this.tbCreateGold.TabIndex = 27;
            this.tbCreateGold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateLvl
            // 
            this.tbCreateLvl.BackColor = System.Drawing.Color.White;
            this.tbCreateLvl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateLvl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateLvl.Location = new System.Drawing.Point(100, 47);
            this.tbCreateLvl.Name = "tbCreateLvl";
            this.tbCreateLvl.Size = new System.Drawing.Size(125, 22);
            this.tbCreateLvl.TabIndex = 26;
            this.tbCreateLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateName
            // 
            this.tbCreateName.BackColor = System.Drawing.Color.White;
            this.tbCreateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateName.Location = new System.Drawing.Point(100, 17);
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.Size = new System.Drawing.Size(125, 22);
            this.tbCreateName.TabIndex = 25;
            this.tbCreateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // timHideCreate
            // 
            this.timHideCreate.Interval = 3000;
            this.timHideCreate.Tick += new System.EventHandler(this.TimHideCreate_Tick);
            // 
            // timHideEdit
            // 
            this.timHideEdit.Interval = 3000;
            this.timHideEdit.Tick += new System.EventHandler(this.TimHideEdit_Tick);
            // 
            // panDivider
            // 
            this.panDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDivider.Location = new System.Drawing.Point(0, 260);
            this.panDivider.Name = "panDivider";
            this.panDivider.Size = new System.Drawing.Size(1084, 5);
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
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEdit.Location = new System.Drawing.Point(0, 265);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(1084, 260);
            this.panEdit.TabIndex = 4;
            // 
            // labEnemyEdit
            // 
            this.labEnemyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labEnemyEdit.AutoSize = true;
            this.labEnemyEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyEdit.Location = new System.Drawing.Point(684, 219);
            this.labEnemyEdit.Name = "labEnemyEdit";
            this.labEnemyEdit.Size = new System.Drawing.Size(0, 16);
            this.labEnemyEdit.TabIndex = 35;
            this.labEnemyEdit.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(564, 215);
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
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(964, 215);
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
            this.tbEditDmgMax.Location = new System.Drawing.Point(339, 110);
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
            this.tbEditHealth.Location = new System.Drawing.Point(274, 170);
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
            this.tbEditDef.Location = new System.Drawing.Point(274, 140);
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
            this.tbEditDmgMin.Location = new System.Drawing.Point(274, 110);
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
            this.tbEditGold.Location = new System.Drawing.Point(274, 80);
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
            this.tbEditLvl.Location = new System.Drawing.Point(274, 50);
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
            this.tbEditName.Location = new System.Drawing.Point(274, 20);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(125, 22);
            this.tbEditName.TabIndex = 26;
            this.tbEditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labHealthR
            // 
            this.labHealthR.AutoSize = true;
            this.labHealthR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthR.Location = new System.Drawing.Point(194, 173);
            this.labHealthR.Name = "labHealthR";
            this.labHealthR.Size = new System.Drawing.Size(64, 16);
            this.labHealthR.TabIndex = 25;
            this.labHealthR.Text = "Health:";
            // 
            // labDefR
            // 
            this.labDefR.AutoSize = true;
            this.labDefR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefR.Location = new System.Drawing.Point(194, 143);
            this.labDefR.Name = "labDefR";
            this.labDefR.Size = new System.Drawing.Size(72, 16);
            this.labDefR.TabIndex = 24;
            this.labDefR.Text = "Defense:";
            // 
            // labDmgR
            // 
            this.labDmgR.AutoSize = true;
            this.labDmgR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgR.Location = new System.Drawing.Point(194, 113);
            this.labDmgR.Name = "labDmgR";
            this.labDmgR.Size = new System.Drawing.Size(64, 16);
            this.labDmgR.TabIndex = 23;
            this.labDmgR.Text = "Damage:";
            // 
            // labGoldR
            // 
            this.labGoldR.AutoSize = true;
            this.labGoldR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldR.Location = new System.Drawing.Point(194, 83);
            this.labGoldR.Name = "labGoldR";
            this.labGoldR.Size = new System.Drawing.Size(48, 16);
            this.labGoldR.TabIndex = 22;
            this.labGoldR.Text = "Gold:";
            // 
            // labLvlR
            // 
            this.labLvlR.AutoSize = true;
            this.labLvlR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlR.Location = new System.Drawing.Point(194, 53);
            this.labLvlR.Name = "labLvlR";
            this.labLvlR.Size = new System.Drawing.Size(56, 16);
            this.labLvlR.TabIndex = 21;
            this.labLvlR.Text = "Level:";
            // 
            // labNameR
            // 
            this.labNameR.AutoSize = true;
            this.labNameR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameR.Location = new System.Drawing.Point(194, 23);
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
            this.lbEnemies.Location = new System.Drawing.Point(23, 20);
            this.lbEnemies.Name = "lbEnemies";
            this.lbEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbEnemies.TabIndex = 19;
            this.lbEnemies.SelectedIndexChanged += new System.EventHandler(this.LbEnemies_SelectedIndexChanged);
            // 
            // AdminEnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.panDivider);
            this.Controls.Add(this.panCreate);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminEnemies";
            this.Size = new System.Drawing.Size(1084, 525);
            this.panCreate.ResumeLayout(false);
            this.panCreate.PerformLayout();
            this.panEdit.ResumeLayout(false);
            this.panEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCreate;
        private System.Windows.Forms.TextBox tbCreateDmgMax;
        private System.Windows.Forms.TextBox tbCreateHealth;
        private System.Windows.Forms.TextBox tbCreateDef;
        private System.Windows.Forms.TextBox tbCreateDmgMin;
        private System.Windows.Forms.TextBox tbCreateGold;
        private System.Windows.Forms.TextBox tbCreateLvl;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.Label labHealthL;
        private System.Windows.Forms.Label labDefL;
        private System.Windows.Forms.Label labDmgL;
        private System.Windows.Forms.Label labGoldL;
        private System.Windows.Forms.Label labLvlL;
        private System.Windows.Forms.Label labNameL;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labEnemyAdd;
        private System.Windows.Forms.Timer timHideCreate;
        private System.Windows.Forms.Timer timHideEdit;
        private System.Windows.Forms.Panel panDivider;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.Label labEnemyEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
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
    }
}
