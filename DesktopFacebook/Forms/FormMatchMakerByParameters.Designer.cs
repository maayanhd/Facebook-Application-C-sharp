namespace DesktopFacebook.Forms
{
     partial class FormMatchMakerByParameters
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
            this.labelSelectGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxGenderSelection = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAgeRangeSelection = new System.Windows.Forms.ComboBox();
            this.buttonFindMatch = new System.Windows.Forms.Button();
            this.labelMatchResult = new System.Windows.Forms.Label();
            this.labelFriendsStatus = new System.Windows.Forms.Label();
            this.labelFriendsRelationship = new System.Windows.Forms.Label();
            this.labelFriendsHometown = new System.Windows.Forms.Label();
            this.labelFriendsLocation = new System.Windows.Forms.Label();
            this.labelFriendsGender = new System.Windows.Forms.Label();
            this.labelFriendsBirthday = new System.Windows.Forms.Label();
            this.labelFriendsName = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.groupBoxGenderSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectGender
            // 
            this.labelSelectGender.AutoSize = true;
            this.labelSelectGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGender.Location = new System.Drawing.Point(20, 25);
            this.labelSelectGender.Name = "labelSelectGender";
            this.labelSelectGender.Size = new System.Drawing.Size(173, 19);
            this.labelSelectGender.TabIndex = 0;
            this.labelSelectGender.Text = "Select Preferred Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(118, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(50, 18);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.Tag = "Male";
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Checked = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(6, 19);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(62, 18);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Tag = "Female";
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxGenderSelection
            // 
            this.groupBoxGenderSelection.Controls.Add(this.radioButtonMale);
            this.groupBoxGenderSelection.Controls.Add(this.radioButtonFemale);
            this.groupBoxGenderSelection.Location = new System.Drawing.Point(19, 47);
            this.groupBoxGenderSelection.Name = "groupBoxGenderSelection";
            this.groupBoxGenderSelection.Size = new System.Drawing.Size(174, 49);
            this.groupBoxGenderSelection.TabIndex = 3;
            this.groupBoxGenderSelection.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Desired Age Range";
            // 
            // comboBoxAgeRangeSelection
            // 
            this.comboBoxAgeRangeSelection.FormattingEnabled = true;
            this.comboBoxAgeRangeSelection.Items.AddRange(new object[] {
            "18-21",
            "22-25",
            "26-29",
            "30-35",
            "36-39",
            "40-49",
            "50-59",
            "60+"});
            this.comboBoxAgeRangeSelection.Location = new System.Drawing.Point(19, 169);
            this.comboBoxAgeRangeSelection.Name = "comboBoxAgeRangeSelection";
            this.comboBoxAgeRangeSelection.Size = new System.Drawing.Size(191, 21);
            this.comboBoxAgeRangeSelection.TabIndex = 4;
            this.comboBoxAgeRangeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgeRangeSelection_SelectedIndexChanged);
            // 
            // buttonFindMatch
            // 
            this.buttonFindMatch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindMatch.Location = new System.Drawing.Point(25, 251);
            this.buttonFindMatch.Name = "buttonFindMatch";
            this.buttonFindMatch.Size = new System.Drawing.Size(176, 32);
            this.buttonFindMatch.TabIndex = 5;
            this.buttonFindMatch.Text = "Find Match!";
            this.buttonFindMatch.UseVisualStyleBackColor = true;
            this.buttonFindMatch.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMatchResult
            // 
            this.labelMatchResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchResult.Location = new System.Drawing.Point(374, 3);
            this.labelMatchResult.Name = "labelMatchResult";
            this.labelMatchResult.Size = new System.Drawing.Size(180, 19);
            this.labelMatchResult.TabIndex = 0;
            this.labelMatchResult.Text = "Match Found!";
            this.labelMatchResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMatchResult.Visible = false;
            // 
            // labelFriendsStatus
            // 
            this.labelFriendsStatus.AutoSize = true;
            this.labelFriendsStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsStatus.Location = new System.Drawing.Point(371, 391);
            this.labelFriendsStatus.Name = "labelFriendsStatus";
            this.labelFriendsStatus.Size = new System.Drawing.Size(87, 15);
            this.labelFriendsStatus.TabIndex = 7;
            this.labelFriendsStatus.Text = "Current Status";
            // 
            // labelFriendsRelationship
            // 
            this.labelFriendsRelationship.AutoSize = true;
            this.labelFriendsRelationship.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsRelationship.Location = new System.Drawing.Point(371, 362);
            this.labelFriendsRelationship.Name = "labelFriendsRelationship";
            this.labelFriendsRelationship.Size = new System.Drawing.Size(74, 15);
            this.labelFriendsRelationship.TabIndex = 8;
            this.labelFriendsRelationship.Text = "Relationship";
            // 
            // labelFriendsHometown
            // 
            this.labelFriendsHometown.AutoSize = true;
            this.labelFriendsHometown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsHometown.Location = new System.Drawing.Point(371, 331);
            this.labelFriendsHometown.Name = "labelFriendsHometown";
            this.labelFriendsHometown.Size = new System.Drawing.Size(69, 15);
            this.labelFriendsHometown.TabIndex = 9;
            this.labelFriendsHometown.Text = "Hometown";
            // 
            // labelFriendsLocation
            // 
            this.labelFriendsLocation.AutoSize = true;
            this.labelFriendsLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsLocation.Location = new System.Drawing.Point(371, 304);
            this.labelFriendsLocation.Name = "labelFriendsLocation";
            this.labelFriendsLocation.Size = new System.Drawing.Size(53, 15);
            this.labelFriendsLocation.TabIndex = 10;
            this.labelFriendsLocation.Text = "Location";
            // 
            // labelFriendsGender
            // 
            this.labelFriendsGender.AutoSize = true;
            this.labelFriendsGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsGender.Location = new System.Drawing.Point(371, 276);
            this.labelFriendsGender.Name = "labelFriendsGender";
            this.labelFriendsGender.Size = new System.Drawing.Size(48, 15);
            this.labelFriendsGender.TabIndex = 11;
            this.labelFriendsGender.Text = "Gender";
            // 
            // labelFriendsBirthday
            // 
            this.labelFriendsBirthday.AutoSize = true;
            this.labelFriendsBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsBirthday.Location = new System.Drawing.Point(371, 251);
            this.labelFriendsBirthday.Name = "labelFriendsBirthday";
            this.labelFriendsBirthday.Size = new System.Drawing.Size(53, 15);
            this.labelFriendsBirthday.TabIndex = 12;
            this.labelFriendsBirthday.Text = "Birthday";
            // 
            // labelFriendsName
            // 
            this.labelFriendsName.AutoSize = true;
            this.labelFriendsName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsName.Location = new System.Drawing.Point(371, 226);
            this.labelFriendsName.Name = "labelFriendsName";
            this.labelFriendsName.Size = new System.Drawing.Size(40, 15);
            this.labelFriendsName.TabIndex = 13;
            this.labelFriendsName.Text = "Name";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFriend.Image = global::DesktopFacebook.Properties.Resources.annonymousProfile;
            this.pictureBoxFriend.Location = new System.Drawing.Point(374, 25);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 6;
            this.pictureBoxFriend.TabStop = false;
            // 
            // FormMatchMakerByParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFriendsStatus);
            this.Controls.Add(this.labelFriendsRelationship);
            this.Controls.Add(this.labelFriendsHometown);
            this.Controls.Add(this.labelFriendsLocation);
            this.Controls.Add(this.labelFriendsGender);
            this.Controls.Add(this.labelFriendsBirthday);
            this.Controls.Add(this.labelFriendsName);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.buttonFindMatch);
            this.Controls.Add(this.comboBoxAgeRangeSelection);
            this.Controls.Add(this.groupBoxGenderSelection);
            this.Controls.Add(this.labelMatchResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSelectGender);
            this.Name = "FormMatchMakerByParameters";
            this.Text = "FormMatchMakerByParameters";
            this.groupBoxGenderSelection.ResumeLayout(false);
            this.groupBoxGenderSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        #endregion

        internal System.Windows.Forms.Label labelSelectGender;
        internal System.Windows.Forms.RadioButton radioButtonMale;
        internal System.Windows.Forms.RadioButton radioButtonFemale;
        internal System.Windows.Forms.GroupBox groupBoxGenderSelection;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox comboBoxAgeRangeSelection;
        internal System.Windows.Forms.Button buttonFindMatch;
        internal System.Windows.Forms.Label labelMatchResult;
        internal System.Windows.Forms.Label labelFriendsStatus;
        internal System.Windows.Forms.Label labelFriendsRelationship;
        internal System.Windows.Forms.Label labelFriendsHometown;
        internal System.Windows.Forms.Label labelFriendsLocation;
        internal System.Windows.Forms.Label labelFriendsGender;
        internal System.Windows.Forms.Label labelFriendsBirthday;
        internal System.Windows.Forms.Label labelFriendsName;
        internal System.Windows.Forms.PictureBox pictureBoxFriend;
    }
}