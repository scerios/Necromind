
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
            this.panAdd = new System.Windows.Forms.Panel();
            this.cbCreateIsHostile = new System.Windows.Forms.CheckBox();
            this.labEnemyAdd = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbCreateDescription = new System.Windows.Forms.TextBox();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.labIsHostileL = new System.Windows.Forms.Label();
            this.labDescriptionL = new System.Windows.Forms.Label();
            this.labNameL = new System.Windows.Forms.Label();
            this.panDivider = new System.Windows.Forms.Panel();
            this.panEdit = new System.Windows.Forms.Panel();
            this.labEnemyEdit = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbEditDescription = new System.Windows.Forms.TextBox();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.labIsHostileR = new System.Windows.Forms.Label();
            this.labDescriptionR = new System.Windows.Forms.Label();
            this.labNameR = new System.Windows.Forms.Label();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.timHideAdd = new System.Windows.Forms.Timer(this.components);
            this.timHideEdit = new System.Windows.Forms.Timer(this.components);
            this.cbEditIsHostile = new System.Windows.Forms.CheckBox();
            this.lbCreateEnemies = new System.Windows.Forms.ListBox();
            this.lbCreateAddedEnemies = new System.Windows.Forms.ListBox();
            this.btnCreateAdd = new System.Windows.Forms.Button();
            this.btnCreateRemove = new System.Windows.Forms.Button();
            this.btnEditRemove = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.lbEditAddedEnemies = new System.Windows.Forms.ListBox();
            this.lbEditEnemies = new System.Windows.Forms.ListBox();
            this.panAdd.SuspendLayout();
            this.panEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panAdd
            // 
            this.panAdd.Controls.Add(this.btnCreateRemove);
            this.panAdd.Controls.Add(this.btnCreateAdd);
            this.panAdd.Controls.Add(this.lbCreateAddedEnemies);
            this.panAdd.Controls.Add(this.lbCreateEnemies);
            this.panAdd.Controls.Add(this.cbCreateIsHostile);
            this.panAdd.Controls.Add(this.labEnemyAdd);
            this.panAdd.Controls.Add(this.btnCreate);
            this.panAdd.Controls.Add(this.tbCreateDescription);
            this.panAdd.Controls.Add(this.tbCreateName);
            this.panAdd.Controls.Add(this.labIsHostileL);
            this.panAdd.Controls.Add(this.labDescriptionL);
            this.panAdd.Controls.Add(this.labNameL);
            this.panAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panAdd.Location = new System.Drawing.Point(0, 0);
            this.panAdd.Name = "panAdd";
            this.panAdd.Size = new System.Drawing.Size(540, 471);
            this.panAdd.TabIndex = 0;
            // 
            // cbCreateIsHostile
            // 
            this.cbCreateIsHostile.AutoSize = true;
            this.cbCreateIsHostile.Location = new System.Drawing.Point(185, 177);
            this.cbCreateIsHostile.Name = "cbCreateIsHostile";
            this.cbCreateIsHostile.Size = new System.Drawing.Size(15, 14);
            this.cbCreateIsHostile.TabIndex = 49;
            this.cbCreateIsHostile.UseVisualStyleBackColor = true;
            // 
            // labEnemyAdd
            // 
            this.labEnemyAdd.AutoSize = true;
            this.labEnemyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyAdd.Location = new System.Drawing.Point(140, 431);
            this.labEnemyAdd.MinimumSize = new System.Drawing.Size(260, 0);
            this.labEnemyAdd.Name = "labEnemyAdd";
            this.labEnemyAdd.Size = new System.Drawing.Size(260, 16);
            this.labEnemyAdd.TabIndex = 48;
            this.labEnemyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labEnemyAdd.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(420, 426);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 25);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
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
            this.labIsHostileL.Location = new System.Drawing.Point(20, 175);
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
            this.panDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panDivider.Location = new System.Drawing.Point(540, 0);
            this.panDivider.Name = "panDivider";
            this.panDivider.Size = new System.Drawing.Size(4, 471);
            this.panDivider.TabIndex = 1;
            // 
            // panEdit
            // 
            this.panEdit.Controls.Add(this.btnEditRemove);
            this.panEdit.Controls.Add(this.btnEditAdd);
            this.panEdit.Controls.Add(this.lbEditAddedEnemies);
            this.panEdit.Controls.Add(this.lbEditEnemies);
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
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panEdit.Location = new System.Drawing.Point(544, 0);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(540, 471);
            this.panEdit.TabIndex = 2;
            // 
            // labEnemyEdit
            // 
            this.labEnemyEdit.AutoSize = true;
            this.labEnemyEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labEnemyEdit.Location = new System.Drawing.Point(140, 430);
            this.labEnemyEdit.MinimumSize = new System.Drawing.Size(260, 0);
            this.labEnemyEdit.Name = "labEnemyEdit";
            this.labEnemyEdit.Size = new System.Drawing.Size(260, 16);
            this.labEnemyEdit.TabIndex = 52;
            this.labEnemyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnDel.TabIndex = 51;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
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
            this.btnEdit.TabIndex = 50;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
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
            this.labIsHostileR.Location = new System.Drawing.Point(176, 175);
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
            // 
            // timHideAdd
            // 
            this.timHideAdd.Interval = 3000;
            // 
            // timHideEdit
            // 
            this.timHideEdit.Interval = 3000;
            // 
            // cbEditIsHostile
            // 
            this.cbEditIsHostile.AutoSize = true;
            this.cbEditIsHostile.Location = new System.Drawing.Point(345, 177);
            this.cbEditIsHostile.Name = "cbEditIsHostile";
            this.cbEditIsHostile.Size = new System.Drawing.Size(15, 14);
            this.cbEditIsHostile.TabIndex = 53;
            this.cbEditIsHostile.UseVisualStyleBackColor = true;
            // 
            // lbCreateEnemies
            // 
            this.lbCreateEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbCreateEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbCreateEnemies.FormattingEnabled = true;
            this.lbCreateEnemies.ItemHeight = 16;
            this.lbCreateEnemies.Location = new System.Drawing.Point(20, 220);
            this.lbCreateEnemies.Name = "lbCreateEnemies";
            this.lbCreateEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbCreateEnemies.TabIndex = 50;
            this.lbCreateEnemies.Visible = false;
            // 
            // lbCreateAddedEnemies
            // 
            this.lbCreateAddedEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbCreateAddedEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbCreateAddedEnemies.FormattingEnabled = true;
            this.lbCreateAddedEnemies.ItemHeight = 16;
            this.lbCreateAddedEnemies.Location = new System.Drawing.Point(370, 220);
            this.lbCreateAddedEnemies.Name = "lbCreateAddedEnemies";
            this.lbCreateAddedEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbCreateAddedEnemies.TabIndex = 51;
            this.lbCreateAddedEnemies.Visible = false;
            // 
            // btnCreateAdd
            // 
            this.btnCreateAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnCreateAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAdd.FlatAppearance.BorderSize = 0;
            this.btnCreateAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAdd.Location = new System.Drawing.Point(222, 263);
            this.btnCreateAdd.Name = "btnCreateAdd";
            this.btnCreateAdd.Size = new System.Drawing.Size(100, 25);
            this.btnCreateAdd.TabIndex = 52;
            this.btnCreateAdd.TabStop = false;
            this.btnCreateAdd.Text = "Add";
            this.btnCreateAdd.UseVisualStyleBackColor = false;
            this.btnCreateAdd.Visible = false;
            // 
            // btnCreateRemove
            // 
            this.btnCreateRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnCreateRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRemove.FlatAppearance.BorderSize = 0;
            this.btnCreateRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRemove.ForeColor = System.Drawing.Color.Black;
            this.btnCreateRemove.Location = new System.Drawing.Point(222, 332);
            this.btnCreateRemove.Name = "btnCreateRemove";
            this.btnCreateRemove.Size = new System.Drawing.Size(100, 25);
            this.btnCreateRemove.TabIndex = 53;
            this.btnCreateRemove.TabStop = false;
            this.btnCreateRemove.Text = "Remove";
            this.btnCreateRemove.UseVisualStyleBackColor = false;
            this.btnCreateRemove.Visible = false;
            // 
            // btnEditRemove
            // 
            this.btnEditRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnEditRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRemove.FlatAppearance.BorderSize = 0;
            this.btnEditRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRemove.ForeColor = System.Drawing.Color.Black;
            this.btnEditRemove.Location = new System.Drawing.Point(222, 332);
            this.btnEditRemove.Name = "btnEditRemove";
            this.btnEditRemove.Size = new System.Drawing.Size(100, 25);
            this.btnEditRemove.TabIndex = 57;
            this.btnEditRemove.TabStop = false;
            this.btnEditRemove.Text = "Remove";
            this.btnEditRemove.UseVisualStyleBackColor = false;
            this.btnEditRemove.Visible = false;
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnEditAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAdd.FlatAppearance.BorderSize = 0;
            this.btnEditAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdd.ForeColor = System.Drawing.Color.Black;
            this.btnEditAdd.Location = new System.Drawing.Point(222, 263);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(100, 25);
            this.btnEditAdd.TabIndex = 56;
            this.btnEditAdd.TabStop = false;
            this.btnEditAdd.Text = "Add";
            this.btnEditAdd.UseVisualStyleBackColor = false;
            this.btnEditAdd.Visible = false;
            // 
            // lbEditAddedEnemies
            // 
            this.lbEditAddedEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbEditAddedEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbEditAddedEnemies.FormattingEnabled = true;
            this.lbEditAddedEnemies.ItemHeight = 16;
            this.lbEditAddedEnemies.Location = new System.Drawing.Point(370, 220);
            this.lbEditAddedEnemies.Name = "lbEditAddedEnemies";
            this.lbEditAddedEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbEditAddedEnemies.TabIndex = 55;
            this.lbEditAddedEnemies.Visible = false;
            // 
            // lbEditEnemies
            // 
            this.lbEditEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbEditEnemies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbEditEnemies.FormattingEnabled = true;
            this.lbEditEnemies.ItemHeight = 16;
            this.lbEditEnemies.Location = new System.Drawing.Point(20, 220);
            this.lbEditEnemies.Name = "lbEditEnemies";
            this.lbEditEnemies.Size = new System.Drawing.Size(150, 180);
            this.lbEditEnemies.TabIndex = 54;
            this.lbEditEnemies.Visible = false;
            // 
            // AdminLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.panDivider);
            this.Controls.Add(this.panAdd);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLocations";
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
        private System.Windows.Forms.Label labEnemyAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbCreateDescription;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.Label labIsHostileL;
        private System.Windows.Forms.Label labDescriptionL;
        private System.Windows.Forms.Label labNameL;
        private System.Windows.Forms.Timer timHideAdd;
        private System.Windows.Forms.Timer timHideEdit;
        private System.Windows.Forms.Label labEnemyEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbEditDescription;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label labIsHostileR;
        private System.Windows.Forms.Label labDescriptionR;
        private System.Windows.Forms.Label labNameR;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.CheckBox cbCreateIsHostile;
        private System.Windows.Forms.ListBox lbCreateEnemies;
        private System.Windows.Forms.CheckBox cbEditIsHostile;
        private System.Windows.Forms.Button btnCreateAdd;
        private System.Windows.Forms.ListBox lbCreateAddedEnemies;
        private System.Windows.Forms.Button btnCreateRemove;
        private System.Windows.Forms.Button btnEditRemove;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.ListBox lbEditAddedEnemies;
        private System.Windows.Forms.ListBox lbEditEnemies;
    }
}
