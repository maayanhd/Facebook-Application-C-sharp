namespace DesktopFacebook.Forms
{
     partial class FormFriends
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
            this.labelFriendsName = new System.Windows.Forms.Label();
            this.labelFriendsBirthday = new System.Windows.Forms.Label();
            this.labelFriendsGender = new System.Windows.Forms.Label();
            this.labelFriendsLocation = new System.Windows.Forms.Label();
            this.labelFriendsHometown = new System.Windows.Forms.Label();
            this.labelFriendsRelationship = new System.Windows.Forms.Label();
            this.labelFriendsStatus = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelFriendsNameData = new System.Windows.Forms.Label();
            this.labelFriendsBirthdayData = new System.Windows.Forms.Label();
            this.labelFriendsGenderData = new System.Windows.Forms.Label();
            this.labelFriendsLocationData = new System.Windows.Forms.Label();
            this.labelFriendsHometownData = new System.Windows.Forms.Label();
            this.labelFriendsRelationshipData = new System.Windows.Forms.Label();
            this.labelFriendsStatusData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFriendsName
            // 
            this.labelFriendsName.AutoSize = true;
            this.labelFriendsName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsName.Location = new System.Drawing.Point(374, 218);
            this.labelFriendsName.Name = "labelFriendsName";
            this.labelFriendsName.Size = new System.Drawing.Size(44, 15);
            this.labelFriendsName.TabIndex = 1;
            this.labelFriendsName.Text = "Name:";
            // 
            // labelFriendsBirthday
            // 
            this.labelFriendsBirthday.AutoSize = true;
            this.labelFriendsBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsBirthday.Location = new System.Drawing.Point(374, 243);
            this.labelFriendsBirthday.Name = "labelFriendsBirthday";
            this.labelFriendsBirthday.Size = new System.Drawing.Size(57, 15);
            this.labelFriendsBirthday.TabIndex = 1;
            this.labelFriendsBirthday.Text = "Birthday:";
            // 
            // labelFriendsGender
            // 
            this.labelFriendsGender.AutoSize = true;
            this.labelFriendsGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsGender.Location = new System.Drawing.Point(374, 268);
            this.labelFriendsGender.Name = "labelFriendsGender";
            this.labelFriendsGender.Size = new System.Drawing.Size(52, 15);
            this.labelFriendsGender.TabIndex = 1;
            this.labelFriendsGender.Text = "Gender:";
            // 
            // labelFriendsLocation
            // 
            this.labelFriendsLocation.AutoSize = true;
            this.labelFriendsLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsLocation.Location = new System.Drawing.Point(374, 296);
            this.labelFriendsLocation.Name = "labelFriendsLocation";
            this.labelFriendsLocation.Size = new System.Drawing.Size(57, 15);
            this.labelFriendsLocation.TabIndex = 1;
            this.labelFriendsLocation.Text = "Location:";
            // 
            // labelFriendsHometown
            // 
            this.labelFriendsHometown.AutoSize = true;
            this.labelFriendsHometown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsHometown.Location = new System.Drawing.Point(374, 323);
            this.labelFriendsHometown.Name = "labelFriendsHometown";
            this.labelFriendsHometown.Size = new System.Drawing.Size(73, 15);
            this.labelFriendsHometown.TabIndex = 1;
            this.labelFriendsHometown.Text = "Hometown:";
            // 
            // labelFriendsRelationship
            // 
            this.labelFriendsRelationship.AutoSize = true;
            this.labelFriendsRelationship.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsRelationship.Location = new System.Drawing.Point(374, 354);
            this.labelFriendsRelationship.Name = "labelFriendsRelationship";
            this.labelFriendsRelationship.Size = new System.Drawing.Size(78, 15);
            this.labelFriendsRelationship.TabIndex = 1;
            this.labelFriendsRelationship.Text = "Relationship:";
            // 
            // labelFriendsStatus
            // 
            this.labelFriendsStatus.AutoSize = true;
            this.labelFriendsStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsStatus.Location = new System.Drawing.Point(374, 383);
            this.labelFriendsStatus.Name = "labelFriendsStatus";
            this.labelFriendsStatus.Size = new System.Drawing.Size(91, 15);
            this.labelFriendsStatus.TabIndex = 1;
            this.labelFriendsStatus.Text = "Current Status:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(23, 17);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(258, 381);
            this.listBoxFriends.TabIndex = 2;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFriend.Image = global::DesktopFacebook.Properties.Resources.annonymousProfile;
            this.pictureBoxFriend.Location = new System.Drawing.Point(377, 17);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 0;
            this.pictureBoxFriend.TabStop = false;
            // 
            // labelFriendsNameData
            // 
            this.labelFriendsNameData.AutoSize = true;
            this.labelFriendsNameData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsNameData.Location = new System.Drawing.Point(487, 218);
            this.labelFriendsNameData.Name = "labelFriendsNameData";
            this.labelFriendsNameData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsNameData.TabIndex = 1;
            this.labelFriendsNameData.Text = "N/A";
            // 
            // labelFriendsBirthdayData
            // 
            this.labelFriendsBirthdayData.AutoSize = true;
            this.labelFriendsBirthdayData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsBirthdayData.Location = new System.Drawing.Point(487, 243);
            this.labelFriendsBirthdayData.Name = "labelFriendsBirthdayData";
            this.labelFriendsBirthdayData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsBirthdayData.TabIndex = 1;
            this.labelFriendsBirthdayData.Text = "N/A";
            // 
            // labelFriendsGenderData
            // 
            this.labelFriendsGenderData.AutoSize = true;
            this.labelFriendsGenderData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsGenderData.Location = new System.Drawing.Point(487, 268);
            this.labelFriendsGenderData.Name = "labelFriendsGenderData";
            this.labelFriendsGenderData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsGenderData.TabIndex = 1;
            this.labelFriendsGenderData.Text = "N/A";
            // 
            // labelFriendsLocationData
            // 
            this.labelFriendsLocationData.AutoSize = true;
            this.labelFriendsLocationData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsLocationData.Location = new System.Drawing.Point(487, 296);
            this.labelFriendsLocationData.Name = "labelFriendsLocationData";
            this.labelFriendsLocationData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsLocationData.TabIndex = 1;
            this.labelFriendsLocationData.Text = "N/A";
            // 
            // labelFriendsHometownData
            // 
            this.labelFriendsHometownData.AutoSize = true;
            this.labelFriendsHometownData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsHometownData.Location = new System.Drawing.Point(487, 323);
            this.labelFriendsHometownData.Name = "labelFriendsHometownData";
            this.labelFriendsHometownData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsHometownData.TabIndex = 1;
            this.labelFriendsHometownData.Text = "N/A";
            // 
            // labelFriendsRelationshipData
            // 
            this.labelFriendsRelationshipData.AutoSize = true;
            this.labelFriendsRelationshipData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsRelationshipData.Location = new System.Drawing.Point(487, 354);
            this.labelFriendsRelationshipData.Name = "labelFriendsRelationshipData";
            this.labelFriendsRelationshipData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsRelationshipData.TabIndex = 1;
            this.labelFriendsRelationshipData.Text = "N/A";
            // 
            // labelFriendsStatusData
            // 
            this.labelFriendsStatusData.AutoSize = true;
            this.labelFriendsStatusData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsStatusData.Location = new System.Drawing.Point(487, 383);
            this.labelFriendsStatusData.Name = "labelFriendsStatusData";
            this.labelFriendsStatusData.Size = new System.Drawing.Size(29, 15);
            this.labelFriendsStatusData.TabIndex = 1;
            this.labelFriendsStatusData.Text = "N/A";
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriendsStatusData);
            this.Controls.Add(this.labelFriendsStatus);
            this.Controls.Add(this.labelFriendsRelationshipData);
            this.Controls.Add(this.labelFriendsRelationship);
            this.Controls.Add(this.labelFriendsHometownData);
            this.Controls.Add(this.labelFriendsHometown);
            this.Controls.Add(this.labelFriendsLocationData);
            this.Controls.Add(this.labelFriendsLocation);
            this.Controls.Add(this.labelFriendsGenderData);
            this.Controls.Add(this.labelFriendsGender);
            this.Controls.Add(this.labelFriendsBirthdayData);
            this.Controls.Add(this.labelFriendsBirthday);
            this.Controls.Add(this.labelFriendsNameData);
            this.Controls.Add(this.labelFriendsName);
            this.Controls.Add(this.pictureBoxFriend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBoxFriend;
        internal System.Windows.Forms.Label labelFriendsName;
        internal System.Windows.Forms.Label labelFriendsBirthday;
        internal System.Windows.Forms.Label labelFriendsGender;
        internal System.Windows.Forms.Label labelFriendsLocation;
        internal System.Windows.Forms.Label labelFriendsHometown;
        internal System.Windows.Forms.Label labelFriendsRelationship;
        internal System.Windows.Forms.Label labelFriendsStatus;
        internal System.Windows.Forms.ListBox listBoxFriends;
        internal System.Windows.Forms.Label labelFriendsNameData;
        internal System.Windows.Forms.Label labelFriendsBirthdayData;
        internal System.Windows.Forms.Label labelFriendsGenderData;
        internal System.Windows.Forms.Label labelFriendsLocationData;
        internal System.Windows.Forms.Label labelFriendsHometownData;
        internal System.Windows.Forms.Label labelFriendsRelationshipData;
        internal System.Windows.Forms.Label labelFriendsStatusData;
    }
}