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
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelFriendsName = new System.Windows.Forms.Label();
            this.labelFriendsBirthday = new System.Windows.Forms.Label();
            this.labelFriendsGender = new System.Windows.Forms.Label();
            this.labelFriendsLocation = new System.Windows.Forms.Label();
            this.labelFriendsHometown = new System.Windows.Forms.Label();
            this.labelFriendsRelationship = new System.Windows.Forms.Label();
            this.labelFriendsStatus = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
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
            this.pictureBoxFriend.Click += new System.EventHandler(this.pictureBoxFriend_Click);
            // 
            // labelFriendsName
            // 
            this.labelFriendsName.AutoSize = true;
            this.labelFriendsName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsName.Location = new System.Drawing.Point(374, 218);
            this.labelFriendsName.Name = "labelFriendsName";
            this.labelFriendsName.Size = new System.Drawing.Size(40, 15);
            this.labelFriendsName.TabIndex = 1;
            this.labelFriendsName.Text = "Name";
            // 
            // labelFriendsBirthday
            // 
            this.labelFriendsBirthday.AutoSize = true;
            this.labelFriendsBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsBirthday.Location = new System.Drawing.Point(374, 243);
            this.labelFriendsBirthday.Name = "labelFriendsBirthday";
            this.labelFriendsBirthday.Size = new System.Drawing.Size(53, 15);
            this.labelFriendsBirthday.TabIndex = 1;
            this.labelFriendsBirthday.Text = "Birthday";
            // 
            // labelFriendsGender
            // 
            this.labelFriendsGender.AutoSize = true;
            this.labelFriendsGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsGender.Location = new System.Drawing.Point(374, 268);
            this.labelFriendsGender.Name = "labelFriendsGender";
            this.labelFriendsGender.Size = new System.Drawing.Size(48, 15);
            this.labelFriendsGender.TabIndex = 1;
            this.labelFriendsGender.Text = "Gender";
            this.labelFriendsGender.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelFriendsLocation
            // 
            this.labelFriendsLocation.AutoSize = true;
            this.labelFriendsLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsLocation.Location = new System.Drawing.Point(374, 296);
            this.labelFriendsLocation.Name = "labelFriendsLocation";
            this.labelFriendsLocation.Size = new System.Drawing.Size(53, 15);
            this.labelFriendsLocation.TabIndex = 1;
            this.labelFriendsLocation.Text = "Location";
            // 
            // labelFriendsHometown
            // 
            this.labelFriendsHometown.AutoSize = true;
            this.labelFriendsHometown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsHometown.Location = new System.Drawing.Point(374, 323);
            this.labelFriendsHometown.Name = "labelFriendsHometown";
            this.labelFriendsHometown.Size = new System.Drawing.Size(69, 15);
            this.labelFriendsHometown.TabIndex = 1;
            this.labelFriendsHometown.Text = "Hometown";
            // 
            // labelFriendsRelationship
            // 
            this.labelFriendsRelationship.AutoSize = true;
            this.labelFriendsRelationship.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsRelationship.Location = new System.Drawing.Point(374, 354);
            this.labelFriendsRelationship.Name = "labelFriendsRelationship";
            this.labelFriendsRelationship.Size = new System.Drawing.Size(74, 15);
            this.labelFriendsRelationship.TabIndex = 1;
            this.labelFriendsRelationship.Text = "Relationship";
            // 
            // labelFriendsStatus
            // 
            this.labelFriendsStatus.AutoSize = true;
            this.labelFriendsStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsStatus.Location = new System.Drawing.Point(374, 383);
            this.labelFriendsStatus.Name = "labelFriendsStatus";
            this.labelFriendsStatus.Size = new System.Drawing.Size(87, 15);
            this.labelFriendsStatus.TabIndex = 1;
            this.labelFriendsStatus.Text = "Current Status";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(23, 17);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(258, 381);
            this.listBoxFriends.TabIndex = 2;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriendsStatus);
            this.Controls.Add(this.labelFriendsRelationship);
            this.Controls.Add(this.labelFriendsHometown);
            this.Controls.Add(this.labelFriendsLocation);
            this.Controls.Add(this.labelFriendsGender);
            this.Controls.Add(this.labelFriendsBirthday);
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
    }
}