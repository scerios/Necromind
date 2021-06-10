
namespace NecromindUI.UserControls.Admin
{
    partial class AdminLocations
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
            this.cbCreateIsAccessible = new System.Windows.Forms.CheckBox();
            this.labIsAccessibleL = new System.Windows.Forms.Label();
            this.panCreateEnemies = new System.Windows.Forms.Panel();
            this.btnCreateRemove = new System.Windows.Forms.Button();
            this.btnCreateAdd = new System.Windows.Forms.Button();
            this.lbCreateAddedEnemies = new System.Windows.Forms.ListBox();
            this.lbCreateEnemies = new System.Windows.Forms.ListBox();
            this.cbCreateIsHostile = new System.Windows.Forms.CheckBox();
            this.labEnemyAdd = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbCreateDescription = new System.Windows.Forms.TextBox();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.labIsHostileL = new System.Windows.Forms.Label();
            this.labDescriptionL = new System.Windows.Forms.Label();
            this.labNameL = new System.Windows.Forms.Label();
            this.panDivider = new System.Windows.Forms.Panel();
            this.timHideAdd = new System.Windows.Forms.Timer(this.components);
            this.timHideEdit = new System.Windows.Forms.Timer(this.components);
            this.panEdit = new System.Windows.Forms.Panel();
            this.cbEditIsAccessible = new System.Windows.Forms.CheckBox();
            this.labIsAccessibleR = new System.Windows.Forms.Label();
            this.panEditEnemies = new System.Windows.Forms.Panel();
            this.btnEditRemove = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.lbEditAddedEnemies = new System.Windows.Forms.ListBox();
            this.lbEditEnemies = new System.Windows.Forms.ListBox();
            this.cbEditIsHostile = new System.Windows.Forms.CheckBox();
            this.labEnemyEdit = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbEditDescription = new System.Windows.Forms.TextBox();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.labIsHostileR = new System.Windows.Forms.Label();
            this.labDescriptionR = new System.Windows.Forms.Label();
            this.labNameR = new System.Windows.Forms.Label();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.panCreate.SuspendLayout();
            this.panCreateEnemies.SuspendLayout();
            this.panEdit.SuspendLayout();
            this.panEditEnemies.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCreate
            // 
            this.panCreate.Controls.Add(this.cbCreateIsAccessible);
            this.panCreate.Controls.Add(this.labIsAccessibleL);
            this.panCreate.Controls.Add(this.panCreateEnemies);
            this.panCreate.Controls.Add(this.cbCreateIsHostile);
            this.panCreate.Controls.Add(this.labEnemyAdd);
            this.panCreate.Controls.Add(this.btnCreate);
            this.panCreate.Controls.Add(this.tbCreateDescription);
            this.panCreate.Controls.Add(this.tbCreateName);
            this.panCreate.Controls.Add(this.labIsHostileL);
            this.panCreate.Controls.Add(this.labDescriptionL);
            this.panCreate.Controls.Add(this.labNameL);
            this.panCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCreate.Location = new System.Drawing.Point(0, 0);
            this.panCreate.Name = "panCreate";
            this.panCreate.Size = new System.Drawing.Size(1084, 260);
            this.panCreate.TabIndex = 0;
            // 
            // cbCreateIsAccessible
            // 
            this.cbCreateIsAccessible.AutoSize = true;
            this.cbCreateIsAccessible.Location = new System.Drawing.Point(365, 182);
            this.cbCreateIsAccessible.Name = "cbCreateIsAccessible";
            this.cbCreateIsAccessible.Size = new System.Drawing.Size(15, 14);
            this.cbCreateIsAccessible.TabIndex = 52;
            this.cbCreateIsAccessible.UseVisualStyleBackColor = true;
            // 
            // labIsAccessibleL
            // 
            this.labIsAccessibleL.AutoSize = true;
            this.labIsAccessibleL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labIsAccessibleL.Location = new System.Drawing.Point(231, 180);
            this.labIsAccessibleL.Name = "labIsAccessibleL";
            this.labIsAccessibleL.Size = new System.Drawing.Size(96, 16);
            this.labIsAccessibleL.TabIndex = 51;
            this.labIsAccessibleL.Text = "Accessible?";
            // 
            // panCreateEnemies
            // 
            this.panCreateEnemies.Controls.Add(this.btnCreateRemove);
            this.panCreateEnemies.Controls.Add(this.btnCreateAdd);
            this.panCreateEnemies.Controls.Add(this.lbCreateAddedEnemies);
            this.panCreateEnemies.Controls.Add(this.lbCreateEnemies);
            this.panCreateEnemies.Location = new System.Drawing.Point(564, 17);
            this.panCreateEnemies.Name = "panCreateEnemies";
            this.panCreateEnemies.Size = new System.Drawing.Size(500, 180);
            this.panCreateEnemies.TabIndex = 50;
            // 
            // btnCreateRemove
            // 
            this.btnCreateRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnCreateRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRemove.Enabled = false;
            this.btnCreateRemove.FlatAppearance.BorderSize = 0;
            this.btnCreateRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRemove.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRemove.Location = new System.Drawing.Point(204, 112);
            this.btnCreateRemove.Name = "btnCreateRemove";
            this.btnCreateRemove.Size = new System.Drawing.Size(100, 25);
            this.btnCreateRemove.TabIndex = 57;
            this.btnCreateRemove.TabStop = false;
            this.btnCreateRemove.Text = "Remove";
            this.btnCreateRemove.UseVisualStyleBackColor = false;
            this.btnCreateRemove.Click += new System.EventHandler(this.BtnCreateRemove_Click);
            // 
            // btnCreateAdd
            // 
            this.btnCreateAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnCreateAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAdd.Enabled = false;
            this.btnCreateAdd.FlatAppearance.BorderSize = 0;
            this.btnCreateAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAdd.Location = new System.Drawing.Point(204, 43);
            this.btnCreateAdd.Name = "btnCreateAdd";
            this.btnCreateAdd.Size = new System.Drawing.Size(100, 25);
            this.btnCreateAdd.TabIndex = 56;
            this.btnCreateAdd.TabStop = false;
            this.btnCreateAdd.Text = "Add";
            this.btnCreateAdd.UseVisualStyleBackColor = false;
            this.btnCreateAdd.Click += new System.EventHandler(this.BtnCreateAdd_Click);
            // 
            // lbCreateAddedEnemies
            // 
            this.lbCreateAddedEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbCreateAddedEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbCreateAddedEnemies.FormattingEnabled = true;
            this.lbCreateAddedEnemies.ItemHeight = 16;
            this.lbCreateAddedEnemies.Location = new System.Drawing.Point(350, 0);
            this.lbCreateAddedEnemies.Name = "lbCreateAddedEnemies";
            this.lbCreateAddedEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbCreateAddedEnemies.TabIndex = 55;
            this.lbCreateAddedEnemies.SelectedIndexChanged += new System.EventHandler(this.LbCreateAddedEnemies_SelectedIndexChanged);
            // 
            // lbCreateEnemies
            // 
            this.lbCreateEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbCreateEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbCreateEnemies.FormattingEnabled = true;
            this.lbCreateEnemies.ItemHeight = 16;
            this.lbCreateEnemies.Location = new System.Drawing.Point(0, 0);
            this.lbCreateEnemies.Name = "lbCreateEnemies";
            this.lbCreateEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbCreateEnemies.TabIndex = 54;
            this.lbCreateEnemies.SelectedIndexChanged += new System.EventHandler(this.LbCreateEnemies_SelectedIndexChanged);
            // 
            // cbCreateIsHostile
            // 
            this.cbCreateIsHostile.AutoSize = true;
            this.cbCreateIsHostile.Location = new System.Drawing.Point(158, 182);
            this.cbCreateIsHostile.Name = "cbCreateIsHostile";
            this.cbCreateIsHostile.Size = new System.Drawing.Size(15, 14);
            this.cbCreateIsHostile.TabIndex = 49;
            this.cbCreateIsHostile.UseVisualStyleBackColor = true;
            this.cbCreateIsHostile.CheckedChanged += new System.EventHandler(this.CbCreateIsHostile_CheckedChanged);
            // 
            // labEnemyAdd
            // 
            this.labEnemyAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labEnemyAdd.AutoSize = true;
            this.labEnemyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyAdd.Location = new System.Drawing.Point(684, 219);
            this.labEnemyAdd.MinimumSize = new System.Drawing.Size(260, 0);
            this.labEnemyAdd.Name = "labEnemyAdd";
            this.labEnemyAdd.Size = new System.Drawing.Size(260, 16);
            this.labEnemyAdd.TabIndex = 48;
            this.labEnemyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labEnemyAdd.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(964, 215);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 25);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tbCreateDescription
            // 
            this.tbCreateDescription.BackColor = System.Drawing.Color.White;
            this.tbCreateDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateDescription.Location = new System.Drawing.Point(130, 47);
            this.tbCreateDescription.Multiline = true;
            this.tbCreateDescription.Name = "tbCreateDescription";
            this.tbCreateDescription.Size = new System.Drawing.Size(250, 122);
            this.tbCreateDescription.TabIndex = 41;
            this.tbCreateDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCreateName
            // 
            this.tbCreateName.BackColor = System.Drawing.Color.White;
            this.tbCreateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbCreateName.Location = new System.Drawing.Point(130, 17);
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.Size = new System.Drawing.Size(125, 22);
            this.tbCreateName.TabIndex = 40;
            this.tbCreateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labIsHostileL
            // 
            this.labIsHostileL.AutoSize = true;
            this.labIsHostileL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labIsHostileL.Location = new System.Drawing.Point(20, 180);
            this.labIsHostileL.Name = "labIsHostileL";
            this.labIsHostileL.Size = new System.Drawing.Size(72, 16);
            this.labIsHostileL.TabIndex = 36;
            this.labIsHostileL.Text = "Hostile?";
            // 
            // labDescriptionL
            // 
            this.labDescriptionL.AutoSize = true;
            this.labDescriptionL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDescriptionL.Location = new System.Drawing.Point(20, 50);
            this.labDescriptionL.Name = "labDescriptionL";
            this.labDescriptionL.Size = new System.Drawing.Size(104, 16);
            this.labDescriptionL.TabIndex = 35;
            this.labDescriptionL.Text = "Description:";
            // 
            // labNameL
            // 
            this.labNameL.AutoSize = true;
            this.labNameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameL.Location = new System.Drawing.Point(20, 20);
            this.labNameL.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameL.Name = "labNameL";
            this.labNameL.Size = new System.Drawing.Size(48, 20);
            this.labNameL.TabIndex = 34;
            this.labNameL.Text = "Name:";
            // 
            // panDivider
            // 
            this.panDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDivider.Location = new System.Drawing.Point(0, 260);
            this.panDivider.Name = "panDivider";
            this.panDivider.Size = new System.Drawing.Size(1084, 5);
            this.panDivider.TabIndex = 1;
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
            // panEdit
            // 
            this.panEdit.Controls.Add(this.cbEditIsAccessible);
            this.panEdit.Controls.Add(this.labIsAccessibleR);
            this.panEdit.Controls.Add(this.panEditEnemies);
            this.panEdit.Controls.Add(this.cbEditIsHostile);
            this.panEdit.Controls.Add(this.labEnemyEdit);
            this.panEdit.Controls.Add(this.btnDel);
            this.panEdit.Controls.Add(this.btnEdit);
            this.panEdit.Controls.Add(this.tbEditDescription);
            this.panEdit.Controls.Add(this.tbEditName);
            this.panEdit.Controls.Add(this.labIsHostileR);
            this.panEdit.Controls.Add(this.labDescriptionR);
            this.panEdit.Controls.Add(this.labNameR);
            this.panEdit.Controls.Add(this.lbLocations);
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEdit.Location = new System.Drawing.Point(0, 265);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(1084, 260);
            this.panEdit.TabIndex = 3;
            // 
            // cbEditIsAccessible
            // 
            this.cbEditIsAccessible.AutoSize = true;
            this.cbEditIsAccessible.Location = new System.Drawing.Point(505, 182);
            this.cbEditIsAccessible.Name = "cbEditIsAccessible";
            this.cbEditIsAccessible.Size = new System.Drawing.Size(15, 14);
            this.cbEditIsAccessible.TabIndex = 56;
            this.cbEditIsAccessible.UseVisualStyleBackColor = true;
            // 
            // labIsAccessibleR
            // 
            this.labIsAccessibleR.AutoSize = true;
            this.labIsAccessibleR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labIsAccessibleR.Location = new System.Drawing.Point(367, 180);
            this.labIsAccessibleR.Name = "labIsAccessibleR";
            this.labIsAccessibleR.Size = new System.Drawing.Size(96, 16);
            this.labIsAccessibleR.TabIndex = 55;
            this.labIsAccessibleR.Text = "Accessible?";
            // 
            // panEditEnemies
            // 
            this.panEditEnemies.Controls.Add(this.btnEditRemove);
            this.panEditEnemies.Controls.Add(this.btnEditAdd);
            this.panEditEnemies.Controls.Add(this.lbEditAddedEnemies);
            this.panEditEnemies.Controls.Add(this.lbEditEnemies);
            this.panEditEnemies.Location = new System.Drawing.Point(564, 17);
            this.panEditEnemies.Name = "panEditEnemies";
            this.panEditEnemies.Size = new System.Drawing.Size(500, 180);
            this.panEditEnemies.TabIndex = 54;
            // 
            // btnEditRemove
            // 
            this.btnEditRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnEditRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRemove.Enabled = false;
            this.btnEditRemove.FlatAppearance.BorderSize = 0;
            this.btnEditRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRemove.ForeColor = System.Drawing.Color.Black;
            this.btnEditRemove.Location = new System.Drawing.Point(202, 112);
            this.btnEditRemove.Name = "btnEditRemove";
            this.btnEditRemove.Size = new System.Drawing.Size(100, 25);
            this.btnEditRemove.TabIndex = 61;
            this.btnEditRemove.TabStop = false;
            this.btnEditRemove.Text = "Remove";
            this.btnEditRemove.UseVisualStyleBackColor = false;
            this.btnEditRemove.Click += new System.EventHandler(this.BtnEditRemove_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnEditAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAdd.Enabled = false;
            this.btnEditAdd.FlatAppearance.BorderSize = 0;
            this.btnEditAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEditAdd.Location = new System.Drawing.Point(202, 43);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(100, 25);
            this.btnEditAdd.TabIndex = 60;
            this.btnEditAdd.TabStop = false;
            this.btnEditAdd.Text = "Add";
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Click += new System.EventHandler(this.BtnEditAdd_Click);
            // 
            // lbEditAddedEnemies
            // 
            this.lbEditAddedEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbEditAddedEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbEditAddedEnemies.FormattingEnabled = true;
            this.lbEditAddedEnemies.ItemHeight = 16;
            this.lbEditAddedEnemies.Location = new System.Drawing.Point(350, 0);
            this.lbEditAddedEnemies.Name = "lbEditAddedEnemies";
            this.lbEditAddedEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbEditAddedEnemies.TabIndex = 59;
            this.lbEditAddedEnemies.SelectedIndexChanged += new System.EventHandler(this.LbEditAddedEnemies_SelectedIndexChanged);
            // 
            // lbEditEnemies
            // 
            this.lbEditEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbEditEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbEditEnemies.FormattingEnabled = true;
            this.lbEditEnemies.ItemHeight = 16;
            this.lbEditEnemies.Location = new System.Drawing.Point(0, 0);
            this.lbEditEnemies.Name = "lbEditEnemies";
            this.lbEditEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbEditEnemies.TabIndex = 58;
            this.lbEditEnemies.SelectedIndexChanged += new System.EventHandler(this.LbEditEnemies_SelectedIndexChanged);
            // 
            // cbEditIsHostile
            // 
            this.cbEditIsHostile.AutoSize = true;
            this.cbEditIsHostile.Location = new System.Drawing.Point(307, 182);
            this.cbEditIsHostile.Name = "cbEditIsHostile";
            this.cbEditIsHostile.Size = new System.Drawing.Size(15, 14);
            this.cbEditIsHostile.TabIndex = 53;
            this.cbEditIsHostile.UseVisualStyleBackColor = true;
            // 
            // labEnemyEdit
            // 
            this.labEnemyEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labEnemyEdit.AutoSize = true;
            this.labEnemyEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyEdit.Location = new System.Drawing.Point(684, 219);
            this.labEnemyEdit.MinimumSize = new System.Drawing.Size(260, 0);
            this.labEnemyEdit.Name = "labEnemyEdit";
            this.labEnemyEdit.Size = new System.Drawing.Size(260, 16);
            this.labEnemyEdit.TabIndex = 52;
            this.labEnemyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labEnemyEdit.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(564, 215);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 25);
            this.btnDel.TabIndex = 51;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(964, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbEditDescription
            // 
            this.tbEditDescription.BackColor = System.Drawing.Color.White;
            this.tbEditDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditDescription.Location = new System.Drawing.Point(285, 47);
            this.tbEditDescription.Multiline = true;
            this.tbEditDescription.Name = "tbEditDescription";
            this.tbEditDescription.Size = new System.Drawing.Size(235, 122);
            this.tbEditDescription.TabIndex = 44;
            this.tbEditDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEditName
            // 
            this.tbEditName.BackColor = System.Drawing.Color.White;
            this.tbEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbEditName.Location = new System.Drawing.Point(285, 17);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(125, 22);
            this.tbEditName.TabIndex = 43;
            this.tbEditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labIsHostileR
            // 
            this.labIsHostileR.AutoSize = true;
            this.labIsHostileR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labIsHostileR.Location = new System.Drawing.Point(176, 180);
            this.labIsHostileR.Name = "labIsHostileR";
            this.labIsHostileR.Size = new System.Drawing.Size(72, 16);
            this.labIsHostileR.TabIndex = 39;
            this.labIsHostileR.Text = "Hostile?";
            // 
            // labDescriptionR
            // 
            this.labDescriptionR.AutoSize = true;
            this.labDescriptionR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDescriptionR.Location = new System.Drawing.Point(176, 50);
            this.labDescriptionR.Name = "labDescriptionR";
            this.labDescriptionR.Size = new System.Drawing.Size(104, 16);
            this.labDescriptionR.TabIndex = 38;
            this.labDescriptionR.Text = "Description:";
            // 
            // labNameR
            // 
            this.labNameR.AutoSize = true;
            this.labNameR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameR.Location = new System.Drawing.Point(176, 20);
            this.labNameR.MinimumSize = new System.Drawing.Size(0, 20);
            this.labNameR.Name = "labNameR";
            this.labNameR.Size = new System.Drawing.Size(48, 20);
            this.labNameR.TabIndex = 37;
            this.labNameR.Text = "Name:";
            // 
            // lbLocations
            // 
            this.lbLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.ItemHeight = 16;
            this.lbLocations.Location = new System.Drawing.Point(20, 20);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(150, 180);
            this.lbLocations.TabIndex = 36;
            this.lbLocations.SelectedIndexChanged += new System.EventHandler(this.LbLocations_SelectedIndexChanged);
            // 
            // AdminLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.panDivider);
            this.Controls.Add(this.panCreate);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLocations";
            this.Size = new System.Drawing.Size(1084, 525);
            this.panCreate.ResumeLayout(false);
            this.panCreate.PerformLayout();
            this.panCreateEnemies.ResumeLayout(false);
            this.panEdit.ResumeLayout(false);
            this.panEdit.PerformLayout();
            this.panEditEnemies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCreate;
        private System.Windows.Forms.Panel panDivider;
        private System.Windows.Forms.Label labEnemyAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbCreateDescription;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.Label labIsHostileL;
        private System.Windows.Forms.Label labDescriptionL;
        private System.Windows.Forms.Label labNameL;
        private System.Windows.Forms.Timer timHideAdd;
        private System.Windows.Forms.Timer timHideEdit;
        private System.Windows.Forms.CheckBox cbCreateIsHostile;
        private System.Windows.Forms.Panel panCreateEnemies;
        private System.Windows.Forms.Button btnCreateRemove;
        private System.Windows.Forms.Button btnCreateAdd;
        private System.Windows.Forms.ListBox lbCreateAddedEnemies;
        private System.Windows.Forms.ListBox lbCreateEnemies;
        private System.Windows.Forms.CheckBox cbCreateIsAccessible;
        private System.Windows.Forms.Label labIsAccessibleL;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.CheckBox cbEditIsAccessible;
        private System.Windows.Forms.Label labIsAccessibleR;
        private System.Windows.Forms.Panel panEditEnemies;
        private System.Windows.Forms.Button btnEditRemove;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.ListBox lbEditAddedEnemies;
        private System.Windows.Forms.ListBox lbEditEnemies;
        private System.Windows.Forms.CheckBox cbEditIsHostile;
        private System.Windows.Forms.Label labEnemyEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbEditDescription;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label labIsHostileR;
        private System.Windows.Forms.Label labDescriptionR;
        private System.Windows.Forms.Label labNameR;
        private System.Windows.Forms.ListBox lbLocations;
    }
}
