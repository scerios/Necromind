
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
            this.labHealthC = new System.Windows.Forms.Label();
            this.labDefC = new System.Windows.Forms.Label();
            this.labDmgC = new System.Windows.Forms.Label();
            this.labGoldC = new System.Windows.Forms.Label();
            this.labLvlC = new System.Windows.Forms.Label();
            this.labNameC = new System.Windows.Forms.Label();
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
            this.labHealthM = new System.Windows.Forms.Label();
            this.labDefM = new System.Windows.Forms.Label();
            this.labDmgM = new System.Windows.Forms.Label();
            this.labGoldM = new System.Windows.Forms.Label();
            this.labLvlM = new System.Windows.Forms.Label();
            this.labNameM = new System.Windows.Forms.Label();
            this.lbEnemies = new System.Windows.Forms.ListBox();
            this.labHealthCError = new System.Windows.Forms.Label();
            this.labDefCError = new System.Windows.Forms.Label();
            this.labDmgCError = new System.Windows.Forms.Label();
            this.labGoldCError = new System.Windows.Forms.Label();
            this.labLvlCError = new System.Windows.Forms.Label();
            this.labNameCError = new System.Windows.Forms.Label();
            this.labNameMError = new System.Windows.Forms.Label();
            this.labHealthMError = new System.Windows.Forms.Label();
            this.labDefMError = new System.Windows.Forms.Label();
            this.labDmgMError = new System.Windows.Forms.Label();
            this.labGoldMError = new System.Windows.Forms.Label();
            this.labLvlMError = new System.Windows.Forms.Label();
            this.panCreate.SuspendLayout();
            this.panEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCreate
            // 
            this.panCreate.Controls.Add(this.labNameCError);
            this.panCreate.Controls.Add(this.labHealthCError);
            this.panCreate.Controls.Add(this.labDefCError);
            this.panCreate.Controls.Add(this.labDmgCError);
            this.panCreate.Controls.Add(this.labGoldCError);
            this.panCreate.Controls.Add(this.labLvlCError);
            this.panCreate.Controls.Add(this.labEnemyAdd);
            this.panCreate.Controls.Add(this.btnCreate);
            this.panCreate.Controls.Add(this.tbCreateDmgMax);
            this.panCreate.Controls.Add(this.tbCreateHealth);
            this.panCreate.Controls.Add(this.tbCreateDef);
            this.panCreate.Controls.Add(this.tbCreateDmgMin);
            this.panCreate.Controls.Add(this.tbCreateGold);
            this.panCreate.Controls.Add(this.tbCreateLvl);
            this.panCreate.Controls.Add(this.tbCreateName);
            this.panCreate.Controls.Add(this.labHealthC);
            this.panCreate.Controls.Add(this.labDefC);
            this.panCreate.Controls.Add(this.labDmgC);
            this.panCreate.Controls.Add(this.labGoldC);
            this.panCreate.Controls.Add(this.labLvlC);
            this.panCreate.Controls.Add(this.labNameC);
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
            // labHealthC
            // 
            this.labHealthC.AutoSize = true;
            this.labHealthC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthC.Location = new System.Drawing.Point(20, 170);
            this.labHealthC.Name = "labHealthC";
            this.labHealthC.Size = new System.Drawing.Size(64, 16);
            this.labHealthC.TabIndex = 24;
            this.labHealthC.Text = "Health:";
            // 
            // labDefC
            // 
            this.labDefC.AutoSize = true;
            this.labDefC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefC.Location = new System.Drawing.Point(20, 140);
            this.labDefC.Name = "labDefC";
            this.labDefC.Size = new System.Drawing.Size(72, 16);
            this.labDefC.TabIndex = 23;
            this.labDefC.Text = "Defense:";
            // 
            // labDmgC
            // 
            this.labDmgC.AutoSize = true;
            this.labDmgC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgC.Location = new System.Drawing.Point(20, 110);
            this.labDmgC.Name = "labDmgC";
            this.labDmgC.Size = new System.Drawing.Size(64, 16);
            this.labDmgC.TabIndex = 22;
            this.labDmgC.Text = "Damage:";
            // 
            // labGoldC
            // 
            this.labGoldC.AutoSize = true;
            this.labGoldC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldC.Location = new System.Drawing.Point(20, 80);
            this.labGoldC.Name = "labGoldC";
            this.labGoldC.Size = new System.Drawing.Size(48, 16);
            this.labGoldC.TabIndex = 21;
            this.labGoldC.Text = "Gold:";
            // 
            // labLvlC
            // 
            this.labLvlC.AutoSize = true;
            this.labLvlC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlC.Location = new System.Drawing.Point(20, 50);
            this.labLvlC.Name = "labLvlC";
            this.labLvlC.Size = new System.Drawing.Size(56, 16);
            this.labLvlC.TabIndex = 20;
            this.labLvlC.Text = "Level:";
            // 
            // labNameC
            // 
            this.labNameC.AutoSize = true;
            this.labNameC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameC.Location = new System.Drawing.Point(20, 20);
            this.labNameC.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameC.Name = "labNameC";
            this.labNameC.Size = new System.Drawing.Size(48, 20);
            this.labNameC.TabIndex = 19;
            this.labNameC.Text = "Name:";
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
            this.panEdit.Controls.Add(this.labNameMError);
            this.panEdit.Controls.Add(this.labHealthMError);
            this.panEdit.Controls.Add(this.labDefMError);
            this.panEdit.Controls.Add(this.labDmgMError);
            this.panEdit.Controls.Add(this.labGoldMError);
            this.panEdit.Controls.Add(this.labLvlMError);
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
            this.panEdit.Controls.Add(this.labHealthM);
            this.panEdit.Controls.Add(this.labDefM);
            this.panEdit.Controls.Add(this.labDmgM);
            this.panEdit.Controls.Add(this.labGoldM);
            this.panEdit.Controls.Add(this.labLvlM);
            this.panEdit.Controls.Add(this.labNameM);
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
            // labHealthM
            // 
            this.labHealthM.AutoSize = true;
            this.labHealthM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labHealthM.Location = new System.Drawing.Point(194, 173);
            this.labHealthM.Name = "labHealthM";
            this.labHealthM.Size = new System.Drawing.Size(64, 16);
            this.labHealthM.TabIndex = 25;
            this.labHealthM.Text = "Health:";
            // 
            // labDefM
            // 
            this.labDefM.AutoSize = true;
            this.labDefM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDefM.Location = new System.Drawing.Point(194, 143);
            this.labDefM.Name = "labDefM";
            this.labDefM.Size = new System.Drawing.Size(72, 16);
            this.labDefM.TabIndex = 24;
            this.labDefM.Text = "Defense:";
            // 
            // labDmgM
            // 
            this.labDmgM.AutoSize = true;
            this.labDmgM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDmgM.Location = new System.Drawing.Point(194, 113);
            this.labDmgM.Name = "labDmgM";
            this.labDmgM.Size = new System.Drawing.Size(64, 16);
            this.labDmgM.TabIndex = 23;
            this.labDmgM.Text = "Damage:";
            // 
            // labGoldM
            // 
            this.labGoldM.AutoSize = true;
            this.labGoldM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labGoldM.Location = new System.Drawing.Point(194, 83);
            this.labGoldM.Name = "labGoldM";
            this.labGoldM.Size = new System.Drawing.Size(48, 16);
            this.labGoldM.TabIndex = 22;
            this.labGoldM.Text = "Gold:";
            // 
            // labLvlM
            // 
            this.labLvlM.AutoSize = true;
            this.labLvlM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLvlM.Location = new System.Drawing.Point(194, 53);
            this.labLvlM.Name = "labLvlM";
            this.labLvlM.Size = new System.Drawing.Size(56, 16);
            this.labLvlM.TabIndex = 21;
            this.labLvlM.Text = "Level:";
            // 
            // labNameM
            // 
            this.labNameM.AutoSize = true;
            this.labNameM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameM.Location = new System.Drawing.Point(194, 23);
            this.labNameM.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameM.Name = "labNameM";
            this.labNameM.Size = new System.Drawing.Size(48, 20);
            this.labNameM.TabIndex = 20;
            this.labNameM.Text = "Name:";
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
            // labHealthCError
            // 
            this.labHealthCError.AutoSize = true;
            this.labHealthCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHealthCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labHealthCError.Location = new System.Drawing.Point(231, 170);
            this.labHealthCError.Name = "labHealthCError";
            this.labHealthCError.Size = new System.Drawing.Size(248, 16);
            this.labHealthCError.TabIndex = 38;
            this.labHealthCError.Text = "Health must be greater than 0!";
            this.labHealthCError.Visible = false;
            // 
            // labDefCError
            // 
            this.labDefCError.AutoSize = true;
            this.labDefCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDefCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labDefCError.Location = new System.Drawing.Point(231, 140);
            this.labDefCError.Name = "labDefCError";
            this.labDefCError.Size = new System.Drawing.Size(352, 16);
            this.labDefCError.TabIndex = 37;
            this.labDefCError.Text = "Defense must be greater than or equal to 0!";
            this.labDefCError.Visible = false;
            // 
            // labDmgCError
            // 
            this.labDmgCError.AutoSize = true;
            this.labDmgCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDmgCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labDmgCError.Location = new System.Drawing.Point(231, 110);
            this.labDmgCError.Name = "labDmgCError";
            this.labDmgCError.Size = new System.Drawing.Size(520, 16);
            this.labDmgCError.TabIndex = 36;
            this.labDmgCError.Text = "Damage min must be greater than 0, max must be greater than min!";
            this.labDmgCError.Visible = false;
            // 
            // labGoldCError
            // 
            this.labGoldCError.AutoSize = true;
            this.labGoldCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGoldCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labGoldCError.Location = new System.Drawing.Point(231, 80);
            this.labGoldCError.Name = "labGoldCError";
            this.labGoldCError.Size = new System.Drawing.Size(328, 16);
            this.labGoldCError.TabIndex = 35;
            this.labGoldCError.Text = "Gold must be greater than or equal to 0!";
            this.labGoldCError.Visible = false;
            // 
            // labLvlCError
            // 
            this.labLvlCError.AutoSize = true;
            this.labLvlCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labLvlCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labLvlCError.Location = new System.Drawing.Point(231, 50);
            this.labLvlCError.Name = "labLvlCError";
            this.labLvlCError.Size = new System.Drawing.Size(240, 16);
            this.labLvlCError.TabIndex = 34;
            this.labLvlCError.Text = "Level must be greater than 0!";
            this.labLvlCError.Visible = false;
            // 
            // labNameCError
            // 
            this.labNameCError.AutoSize = true;
            this.labNameCError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labNameCError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labNameCError.Location = new System.Drawing.Point(231, 20);
            this.labNameCError.Name = "labNameCError";
            this.labNameCError.Size = new System.Drawing.Size(568, 16);
            this.labNameCError.TabIndex = 39;
            this.labNameCError.Text = "Name must be between 3 to 16 characters. Must start with valid letter.";
            this.labNameCError.Visible = false;
            // 
            // labNameMError
            // 
            this.labNameMError.AutoSize = true;
            this.labNameMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labNameMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labNameMError.Location = new System.Drawing.Point(405, 23);
            this.labNameMError.Name = "labNameMError";
            this.labNameMError.Size = new System.Drawing.Size(568, 16);
            this.labNameMError.TabIndex = 45;
            this.labNameMError.Text = "Name must be between 3 to 16 characters. Must start with valid letter.";
            this.labNameMError.Visible = false;
            // 
            // labHealthMError
            // 
            this.labHealthMError.AutoSize = true;
            this.labHealthMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labHealthMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labHealthMError.Location = new System.Drawing.Point(405, 173);
            this.labHealthMError.Name = "labHealthMError";
            this.labHealthMError.Size = new System.Drawing.Size(248, 16);
            this.labHealthMError.TabIndex = 44;
            this.labHealthMError.Text = "Health must be greater than 0!";
            this.labHealthMError.Visible = false;
            // 
            // labDefMError
            // 
            this.labDefMError.AutoSize = true;
            this.labDefMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDefMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labDefMError.Location = new System.Drawing.Point(405, 143);
            this.labDefMError.Name = "labDefMError";
            this.labDefMError.Size = new System.Drawing.Size(352, 16);
            this.labDefMError.TabIndex = 43;
            this.labDefMError.Text = "Defense must be greater than or equal to 0!";
            this.labDefMError.Visible = false;
            // 
            // labDmgMError
            // 
            this.labDmgMError.AutoSize = true;
            this.labDmgMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDmgMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labDmgMError.Location = new System.Drawing.Point(405, 113);
            this.labDmgMError.Name = "labDmgMError";
            this.labDmgMError.Size = new System.Drawing.Size(520, 16);
            this.labDmgMError.TabIndex = 42;
            this.labDmgMError.Text = "Damage min must be greater than 0, max must be greater than min!";
            this.labDmgMError.Visible = false;
            // 
            // labGoldMError
            // 
            this.labGoldMError.AutoSize = true;
            this.labGoldMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labGoldMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labGoldMError.Location = new System.Drawing.Point(405, 83);
            this.labGoldMError.Name = "labGoldMError";
            this.labGoldMError.Size = new System.Drawing.Size(328, 16);
            this.labGoldMError.TabIndex = 41;
            this.labGoldMError.Text = "Gold must be greater than or equal to 0!";
            this.labGoldMError.Visible = false;
            // 
            // labLvlMError
            // 
            this.labLvlMError.AutoSize = true;
            this.labLvlMError.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labLvlMError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.labLvlMError.Location = new System.Drawing.Point(405, 53);
            this.labLvlMError.Name = "labLvlMError";
            this.labLvlMError.Size = new System.Drawing.Size(240, 16);
            this.labLvlMError.TabIndex = 40;
            this.labLvlMError.Text = "Level must be greater than 0!";
            this.labLvlMError.Visible = false;
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
        private System.Windows.Forms.Label labHealthC;
        private System.Windows.Forms.Label labDefC;
        private System.Windows.Forms.Label labDmgC;
        private System.Windows.Forms.Label labGoldC;
        private System.Windows.Forms.Label labLvlC;
        private System.Windows.Forms.Label labNameC;
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
        private System.Windows.Forms.Label labHealthM;
        private System.Windows.Forms.Label labDefM;
        private System.Windows.Forms.Label labDmgM;
        private System.Windows.Forms.Label labGoldM;
        private System.Windows.Forms.Label labLvlM;
        private System.Windows.Forms.Label labNameM;
        private System.Windows.Forms.ListBox lbEnemies;
        private System.Windows.Forms.Label labHealthCError;
        private System.Windows.Forms.Label labDefCError;
        private System.Windows.Forms.Label labDmgCError;
        private System.Windows.Forms.Label labGoldCError;
        private System.Windows.Forms.Label labLvlCError;
        private System.Windows.Forms.Label labNameCError;
        private System.Windows.Forms.Label labNameMError;
        private System.Windows.Forms.Label labHealthMError;
        private System.Windows.Forms.Label labDefMError;
        private System.Windows.Forms.Label labDmgMError;
        private System.Windows.Forms.Label labGoldMError;
        private System.Windows.Forms.Label labLvlMError;
    }
}
