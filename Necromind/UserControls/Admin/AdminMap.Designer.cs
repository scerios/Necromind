
namespace NecromindUI.UserControls.Admin
{
    partial class AdminMap
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
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.panMovement = new System.Windows.Forms.Panel();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.labDescriptionValue = new System.Windows.Forms.Label();
            this.labNameValue = new System.Windows.Forms.Label();
            this.labJumpLocX = new System.Windows.Forms.Label();
            this.labJumpLocY = new System.Windows.Forms.Label();
            this.tbJumpX = new System.Windows.Forms.TextBox();
            this.tbJumpY = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnDetach = new System.Windows.Forms.Button();
            this.labCurrentLoc = new System.Windows.Forms.Label();
            this.labLocX = new System.Windows.Forms.Label();
            this.labLocXValue = new System.Windows.Forms.Label();
            this.labLocY = new System.Windows.Forms.Label();
            this.labLocYValue = new System.Windows.Forms.Label();
            this.panMovement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLocations
            // 
            this.lbLocations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.lbLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.ItemHeight = 16;
            this.lbLocations.Location = new System.Drawing.Point(20, 20);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(150, 228);
            this.lbLocations.TabIndex = 37;
            // 
            // panMovement
            // 
            this.panMovement.Controls.Add(this.btnSouth);
            this.panMovement.Controls.Add(this.btnEast);
            this.panMovement.Controls.Add(this.btnWest);
            this.panMovement.Controls.Add(this.btnNorth);
            this.panMovement.Location = new System.Drawing.Point(784, 0);
            this.panMovement.Name = "panMovement";
            this.panMovement.Size = new System.Drawing.Size(300, 250);
            this.panMovement.TabIndex = 38;
            // 
            // btnSouth
            // 
            this.btnSouth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnSouth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSouth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnSouth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnSouth.Location = new System.Drawing.Point(100, 185);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(100, 25);
            this.btnSouth.TabIndex = 8;
            this.btnSouth.TabStop = false;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = false;
            // 
            // btnEast
            // 
            this.btnEast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnEast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnEast.Location = new System.Drawing.Point(175, 110);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(100, 25);
            this.btnEast.TabIndex = 7;
            this.btnEast.TabStop = false;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = false;
            // 
            // btnWest
            // 
            this.btnWest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnWest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnWest.Location = new System.Drawing.Point(25, 110);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(100, 25);
            this.btnWest.TabIndex = 6;
            this.btnWest.TabStop = false;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = false;
            // 
            // btnNorth
            // 
            this.btnNorth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNorth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnNorth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNorth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(62)))));
            this.btnNorth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnNorth.Location = new System.Drawing.Point(100, 35);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(100, 25);
            this.btnNorth.TabIndex = 5;
            this.btnNorth.TabStop = false;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = false;
            // 
            // labName
            // 
            this.labName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labName.Location = new System.Drawing.Point(190, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(110, 20);
            this.labName.TabIndex = 39;
            this.labName.Text = "Name:";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDescription
            // 
            this.labDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDescription.Location = new System.Drawing.Point(190, 75);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(110, 20);
            this.labDescription.TabIndex = 40;
            this.labDescription.Text = "Description:";
            this.labDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labDescriptionValue
            // 
            this.labDescriptionValue.AutoSize = true;
            this.labDescriptionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labDescriptionValue.Location = new System.Drawing.Point(190, 100);
            this.labDescriptionValue.MinimumSize = new System.Drawing.Size(400, 100);
            this.labDescriptionValue.Name = "labDescriptionValue";
            this.labDescriptionValue.Size = new System.Drawing.Size(400, 100);
            this.labDescriptionValue.TabIndex = 41;
            this.labDescriptionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labNameValue
            // 
            this.labNameValue.AutoSize = true;
            this.labNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labNameValue.Location = new System.Drawing.Point(310, 50);
            this.labNameValue.MinimumSize = new System.Drawing.Size(280, 20);
            this.labNameValue.Name = "labNameValue";
            this.labNameValue.Size = new System.Drawing.Size(280, 20);
            this.labNameValue.TabIndex = 42;
            this.labNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labJumpLocX
            // 
            this.labJumpLocX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labJumpLocX.Location = new System.Drawing.Point(190, 227);
            this.labJumpLocX.Name = "labJumpLocX";
            this.labJumpLocX.Size = new System.Drawing.Size(75, 20);
            this.labJumpLocX.TabIndex = 43;
            this.labJumpLocX.Text = "X:";
            this.labJumpLocX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labJumpLocY
            // 
            this.labJumpLocY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labJumpLocY.Location = new System.Drawing.Point(390, 227);
            this.labJumpLocY.Name = "labJumpLocY";
            this.labJumpLocY.Size = new System.Drawing.Size(75, 20);
            this.labJumpLocY.TabIndex = 44;
            this.labJumpLocY.Text = "Y:";
            this.labJumpLocY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbJumpX
            // 
            this.tbJumpX.BackColor = System.Drawing.Color.White;
            this.tbJumpX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJumpX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbJumpX.Location = new System.Drawing.Point(275, 227);
            this.tbJumpX.Name = "tbJumpX";
            this.tbJumpX.Size = new System.Drawing.Size(50, 22);
            this.tbJumpX.TabIndex = 45;
            this.tbJumpX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbJumpY
            // 
            this.tbJumpY.BackColor = System.Drawing.Color.White;
            this.tbJumpY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJumpY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbJumpY.Location = new System.Drawing.Point(475, 227);
            this.tbJumpY.Name = "tbJumpY";
            this.tbJumpY.Size = new System.Drawing.Size(50, 22);
            this.tbJumpY.TabIndex = 46;
            this.tbJumpY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(964, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 51;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnJump
            // 
            this.btnJump.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.btnJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJump.FlatAppearance.BorderSize = 0;
            this.btnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJump.ForeColor = System.Drawing.Color.Black;
            this.btnJump.Location = new System.Drawing.Point(628, 225);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(100, 25);
            this.btnJump.TabIndex = 52;
            this.btnJump.TabStop = false;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = false;
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.ForeColor = System.Drawing.Color.Black;
            this.btnAttach.Location = new System.Drawing.Point(628, 70);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 25);
            this.btnAttach.TabIndex = 53;
            this.btnAttach.TabStop = false;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = false;
            // 
            // btnDetach
            // 
            this.btnDetach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDetach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnDetach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetach.FlatAppearance.BorderSize = 0;
            this.btnDetach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetach.ForeColor = System.Drawing.Color.Black;
            this.btnDetach.Location = new System.Drawing.Point(628, 120);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(100, 25);
            this.btnDetach.TabIndex = 54;
            this.btnDetach.TabStop = false;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = false;
            // 
            // labCurrentLoc
            // 
            this.labCurrentLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labCurrentLoc.Location = new System.Drawing.Point(190, 20);
            this.labCurrentLoc.Name = "labCurrentLoc";
            this.labCurrentLoc.Size = new System.Drawing.Size(170, 20);
            this.labCurrentLoc.TabIndex = 55;
            this.labCurrentLoc.Text = "Current location:";
            this.labCurrentLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labLocX
            // 
            this.labLocX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLocX.Location = new System.Drawing.Point(370, 20);
            this.labLocX.Name = "labLocX";
            this.labLocX.Size = new System.Drawing.Size(25, 20);
            this.labLocX.TabIndex = 56;
            this.labLocX.Text = "X:";
            this.labLocX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labLocXValue
            // 
            this.labLocXValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLocXValue.Location = new System.Drawing.Point(401, 20);
            this.labLocXValue.Name = "labLocXValue";
            this.labLocXValue.Size = new System.Drawing.Size(50, 20);
            this.labLocXValue.TabIndex = 57;
            this.labLocXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labLocY
            // 
            this.labLocY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLocY.Location = new System.Drawing.Point(457, 20);
            this.labLocY.Name = "labLocY";
            this.labLocY.Size = new System.Drawing.Size(25, 20);
            this.labLocY.TabIndex = 58;
            this.labLocY.Text = "Y:";
            this.labLocY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labLocYValue
            // 
            this.labLocYValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.labLocYValue.Location = new System.Drawing.Point(488, 20);
            this.labLocYValue.Name = "labLocYValue";
            this.labLocYValue.Size = new System.Drawing.Size(50, 20);
            this.labLocYValue.TabIndex = 59;
            this.labLocYValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.labLocYValue);
            this.Controls.Add(this.labLocY);
            this.Controls.Add(this.labLocXValue);
            this.Controls.Add(this.labLocX);
            this.Controls.Add(this.labCurrentLoc);
            this.Controls.Add(this.btnDetach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbJumpY);
            this.Controls.Add(this.tbJumpX);
            this.Controls.Add(this.labJumpLocY);
            this.Controls.Add(this.labJumpLocX);
            this.Controls.Add(this.labNameValue);
            this.Controls.Add(this.labDescriptionValue);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.panMovement);
            this.Controls.Add(this.lbLocations);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMap";
            this.Size = new System.Drawing.Size(1084, 525);
            this.panMovement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.Panel panMovement;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Label labDescriptionValue;
        private System.Windows.Forms.Label labNameValue;
        private System.Windows.Forms.Label labJumpLocX;
        private System.Windows.Forms.Label labJumpLocY;
        private System.Windows.Forms.TextBox tbJumpX;
        private System.Windows.Forms.TextBox tbJumpY;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.Label labCurrentLoc;
        private System.Windows.Forms.Label labLocX;
        private System.Windows.Forms.Label labLocXValue;
        private System.Windows.Forms.Label labLocY;
        private System.Windows.Forms.Label labLocYValue;
    }
}
