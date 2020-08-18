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
               this.labelSelectGender.Location = new System.Drawing.Point(27, 31);
               this.labelSelectGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelSelectGender.Name = "labelSelectGender";
               this.labelSelectGender.Size = new System.Drawing.Size(210, 24);
               this.labelSelectGender.TabIndex = 0;
               this.labelSelectGender.Text = "Select Preferred Gender";
               // 
               // radioButtonMale
               // 
               this.radioButtonMale.AutoSize = true;
               this.radioButtonMale.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.radioButtonMale.Location = new System.Drawing.Point(157, 23);
               this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.radioButtonMale.Name = "radioButtonMale";
               this.radioButtonMale.Size = new System.Drawing.Size(61, 22);
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
               this.radioButtonFemale.Location = new System.Drawing.Point(8, 23);
               this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.radioButtonFemale.Name = "radioButtonFemale";
               this.radioButtonFemale.Size = new System.Drawing.Size(75, 22);
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
               this.groupBoxGenderSelection.Location = new System.Drawing.Point(25, 58);
               this.groupBoxGenderSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBoxGenderSelection.Name = "groupBoxGenderSelection";
               this.groupBoxGenderSelection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBoxGenderSelection.Size = new System.Drawing.Size(232, 60);
               this.groupBoxGenderSelection.TabIndex = 3;
               this.groupBoxGenderSelection.TabStop = false;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(27, 169);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(220, 24);
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
               this.comboBoxAgeRangeSelection.Location = new System.Drawing.Point(25, 208);
               this.comboBoxAgeRangeSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.comboBoxAgeRangeSelection.Name = "comboBoxAgeRangeSelection";
               this.comboBoxAgeRangeSelection.Size = new System.Drawing.Size(253, 24);
               this.comboBoxAgeRangeSelection.TabIndex = 4;
               this.comboBoxAgeRangeSelection.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgeRangeSelection_SelectedIndexChanged);
               // 
               // buttonFindMatch
               // 
               this.buttonFindMatch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonFindMatch.Location = new System.Drawing.Point(33, 309);
               this.buttonFindMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.buttonFindMatch.Name = "buttonFindMatch";
               this.buttonFindMatch.Size = new System.Drawing.Size(235, 39);
               this.buttonFindMatch.TabIndex = 5;
               this.buttonFindMatch.Text = "Find Match!";
               this.buttonFindMatch.UseVisualStyleBackColor = true;
               this.buttonFindMatch.Click += new System.EventHandler(this.button1_Click);
               // 
               // labelMatchResult
               // 
               this.labelMatchResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelMatchResult.Location = new System.Drawing.Point(499, 4);
               this.labelMatchResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelMatchResult.Name = "labelMatchResult";
               this.labelMatchResult.Size = new System.Drawing.Size(240, 23);
               this.labelMatchResult.TabIndex = 0;
               this.labelMatchResult.Text = "Match Found!";
               this.labelMatchResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               this.labelMatchResult.Visible = false;
               // 
               // labelFriendsStatus
               // 
               this.labelFriendsStatus.AutoSize = true;
               this.labelFriendsStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsStatus.Location = new System.Drawing.Point(495, 481);
               this.labelFriendsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsStatus.Name = "labelFriendsStatus";
               this.labelFriendsStatus.Size = new System.Drawing.Size(112, 21);
               this.labelFriendsStatus.TabIndex = 7;
               this.labelFriendsStatus.Text = "Current Status";
               // 
               // labelFriendsRelationship
               // 
               this.labelFriendsRelationship.AutoSize = true;
               this.labelFriendsRelationship.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsRelationship.Location = new System.Drawing.Point(495, 446);
               this.labelFriendsRelationship.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsRelationship.Name = "labelFriendsRelationship";
               this.labelFriendsRelationship.Size = new System.Drawing.Size(98, 21);
               this.labelFriendsRelationship.TabIndex = 8;
               this.labelFriendsRelationship.Text = "Relationship";
               // 
               // labelFriendsHometown
               // 
               this.labelFriendsHometown.AutoSize = true;
               this.labelFriendsHometown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsHometown.Location = new System.Drawing.Point(495, 407);
               this.labelFriendsHometown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsHometown.Name = "labelFriendsHometown";
               this.labelFriendsHometown.Size = new System.Drawing.Size(90, 21);
               this.labelFriendsHometown.TabIndex = 9;
               this.labelFriendsHometown.Text = "Hometown";
               // 
               // labelFriendsLocation
               // 
               this.labelFriendsLocation.AutoSize = true;
               this.labelFriendsLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsLocation.Location = new System.Drawing.Point(495, 374);
               this.labelFriendsLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsLocation.Name = "labelFriendsLocation";
               this.labelFriendsLocation.Size = new System.Drawing.Size(69, 21);
               this.labelFriendsLocation.TabIndex = 10;
               this.labelFriendsLocation.Text = "Location";
               // 
               // labelFriendsGender
               // 
               this.labelFriendsGender.AutoSize = true;
               this.labelFriendsGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsGender.Location = new System.Drawing.Point(495, 340);
               this.labelFriendsGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsGender.Name = "labelFriendsGender";
               this.labelFriendsGender.Size = new System.Drawing.Size(63, 21);
               this.labelFriendsGender.TabIndex = 11;
               this.labelFriendsGender.Text = "Gender";
               // 
               // labelFriendsBirthday
               // 
               this.labelFriendsBirthday.AutoSize = true;
               this.labelFriendsBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsBirthday.Location = new System.Drawing.Point(495, 309);
               this.labelFriendsBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsBirthday.Name = "labelFriendsBirthday";
               this.labelFriendsBirthday.Size = new System.Drawing.Size(70, 21);
               this.labelFriendsBirthday.TabIndex = 12;
               this.labelFriendsBirthday.Text = "Birthday";
               // 
               // labelFriendsName
               // 
               this.labelFriendsName.AutoSize = true;
               this.labelFriendsName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelFriendsName.Location = new System.Drawing.Point(495, 278);
               this.labelFriendsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.labelFriendsName.Name = "labelFriendsName";
               this.labelFriendsName.Size = new System.Drawing.Size(52, 21);
               this.labelFriendsName.TabIndex = 13;
               this.labelFriendsName.Text = "Name";
               // 
               // pictureBoxFriend
               // 
               this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.pictureBoxFriend.Image = global::DesktopFacebook.Properties.Resources.annonymousProfile;
               this.pictureBoxFriend.Location = new System.Drawing.Point(499, 31);
               this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(4);
               this.pictureBoxFriend.Name = "pictureBoxFriend";
               this.pictureBoxFriend.Size = new System.Drawing.Size(239, 221);
               this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxFriend.TabIndex = 6;
               this.pictureBoxFriend.TabStop = false;
               // 
               // FormMatchMakerByParameters
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1067, 554);
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
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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