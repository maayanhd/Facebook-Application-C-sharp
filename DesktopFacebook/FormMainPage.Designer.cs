using System.Drawing;
using System.Windows.Forms;

namespace DesktopFacebook
{
     partial class FormMainPage
     {
        // For fields section
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

          #region childForms

          private void openChildForm(Form ChildForm)// open(new customizedForm())
          {
               if (ChildForm != null) // Check whether the form exists 
               {
                    //m_CurrentChildForm.Visible = false;
                    m_CurrentChildForm.Close();
               }

               m_CurrentChildForm = ChildForm;
               ChildForm.TopLevel = false;
               ChildForm.FormBorderStyle = FormBorderStyle.None;
               ChildForm.Dock = DockStyle.Fill;
               PanelSelectedMenu.Controls.Add(ChildForm);
               PanelSelectedMenu.Tag = ChildForm;
               ChildForm.BringToFront();
               ChildForm.Show();
          }

          #endregion

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
               this.PanelLeftSided = new System.Windows.Forms.Panel();
               this.panelPosts = new System.Windows.Forms.Panel();
               this.buttonNewsFeed = new System.Windows.Forms.Button();
               this.ButtonMyPosts = new System.Windows.Forms.Button();
               this.buttonPosts = new System.Windows.Forms.Button();
               this.PanelNewFeatures = new System.Windows.Forms.Panel();
               this.buttonEventsByParam = new System.Windows.Forms.Button();
               this.buttonMatchMaker = new System.Windows.Forms.Button();
               this.buttonNewFeatures = new System.Windows.Forms.Button();
               this.PanelPhotos = new System.Windows.Forms.Panel();
               this.buttonMyAlbums = new System.Windows.Forms.Button();
               this.button_Photos = new System.Windows.Forms.Button();
               this.PanelFriends = new System.Windows.Forms.Panel();
               this.buttonMyFriendsList = new System.Windows.Forms.Button();
               this.buttonFriends = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.PanelSelectedMenu = new System.Windows.Forms.Panel();
               this.PanelShadow = new System.Windows.Forms.Panel();
               this.textboxWritePost = new System.Windows.Forms.TextBox();
               this.buttonPost = new System.Windows.Forms.Button();
               this.panelProfileDetails = new System.Windows.Forms.Panel();
               this.label_LoggedInUserFullName = new System.Windows.Forms.Label();
               this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
               this.ButtonChosenMenu = new System.Windows.Forms.Button();
               this.panel_TopMainForm = new System.Windows.Forms.Panel();
               this.buttonLogout = new System.Windows.Forms.Button();
               this.PanelLeftSided.SuspendLayout();
               this.panelPosts.SuspendLayout();
               this.PanelNewFeatures.SuspendLayout();
               this.PanelPhotos.SuspendLayout();
               this.PanelFriends.SuspendLayout();
               this.panel1.SuspendLayout();
               this.panelProfileDetails.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
               this.panel_TopMainForm.SuspendLayout();
               this.SuspendLayout();
               // 
               // PanelLeftSided
               // 
               this.PanelLeftSided.AutoScroll = true;
               this.PanelLeftSided.BackColor = System.Drawing.Color.Azure;
               this.PanelLeftSided.Controls.Add(this.panelPosts);
               this.PanelLeftSided.Controls.Add(this.buttonPosts);
               this.PanelLeftSided.Controls.Add(this.PanelNewFeatures);
               this.PanelLeftSided.Controls.Add(this.buttonNewFeatures);
               this.PanelLeftSided.Controls.Add(this.PanelPhotos);
               this.PanelLeftSided.Controls.Add(this.button_Photos);
               this.PanelLeftSided.Controls.Add(this.PanelFriends);
               this.PanelLeftSided.Controls.Add(this.buttonFriends);
               this.PanelLeftSided.Dock = System.Windows.Forms.DockStyle.Left;
               this.PanelLeftSided.Location = new System.Drawing.Point(0, 0);
               this.PanelLeftSided.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelLeftSided.Name = "PanelLeftSided";
               this.PanelLeftSided.Size = new System.Drawing.Size(207, 556);
               this.PanelLeftSided.TabIndex = 0;
               // 
               // panelPosts
               // 
               this.panelPosts.Controls.Add(this.buttonNewsFeed);
               this.panelPosts.Controls.Add(this.ButtonMyPosts);
               this.panelPosts.Dock = System.Windows.Forms.DockStyle.Top;
               this.panelPosts.Location = new System.Drawing.Point(0, 354);
               this.panelPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panelPosts.Name = "panelPosts";
               this.panelPosts.Size = new System.Drawing.Size(207, 81);
               this.panelPosts.TabIndex = 7;
               this.panelPosts.Visible = false;
               // 
               // buttonNewsFeed
               // 
               this.buttonNewsFeed.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonNewsFeed.FlatAppearance.BorderSize = 0;
               this.buttonNewsFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonNewsFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonNewsFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonNewsFeed.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonNewsFeed.Location = new System.Drawing.Point(0, 39);
               this.buttonNewsFeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonNewsFeed.Name = "buttonNewsFeed";
               this.buttonNewsFeed.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.buttonNewsFeed.Size = new System.Drawing.Size(207, 39);
               this.buttonNewsFeed.TabIndex = 2;
               this.buttonNewsFeed.Text = "My News Feed";
               this.buttonNewsFeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonNewsFeed.UseVisualStyleBackColor = true;
               this.buttonNewsFeed.Click += new System.EventHandler(this.buttonNewsFeed_Click);
               // 
               // ButtonMyPosts
               // 
               this.ButtonMyPosts.Dock = System.Windows.Forms.DockStyle.Top;
               this.ButtonMyPosts.FlatAppearance.BorderSize = 0;
               this.ButtonMyPosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.ButtonMyPosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.ButtonMyPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ButtonMyPosts.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ButtonMyPosts.Location = new System.Drawing.Point(0, 0);
               this.ButtonMyPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.ButtonMyPosts.Name = "ButtonMyPosts";
               this.ButtonMyPosts.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.ButtonMyPosts.Size = new System.Drawing.Size(207, 39);
               this.ButtonMyPosts.TabIndex = 1;
               this.ButtonMyPosts.Text = "My Posts";
               this.ButtonMyPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.ButtonMyPosts.UseVisualStyleBackColor = true;
               this.ButtonMyPosts.Click += new System.EventHandler(this.ButtonMyPosts_Click);
               // 
               // buttonPosts
               // 
               this.buttonPosts.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonPosts.FlatAppearance.BorderSize = 0;
               this.buttonPosts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonPosts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPosts.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPosts.Location = new System.Drawing.Point(0, 308);
               this.buttonPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonPosts.Name = "buttonPosts";
               this.buttonPosts.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.buttonPosts.Size = new System.Drawing.Size(207, 46);
               this.buttonPosts.TabIndex = 6;
               this.buttonPosts.Text = "News Feed";
               this.buttonPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.buttonPosts.UseVisualStyleBackColor = true;
               this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
               // 
               // PanelNewFeatures
               // 
               this.PanelNewFeatures.Controls.Add(this.buttonEventsByParam);
               this.PanelNewFeatures.Controls.Add(this.buttonMatchMaker);
               this.PanelNewFeatures.Dock = System.Windows.Forms.DockStyle.Top;
               this.PanelNewFeatures.Location = new System.Drawing.Point(0, 226);
               this.PanelNewFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelNewFeatures.Name = "PanelNewFeatures";
               this.PanelNewFeatures.Size = new System.Drawing.Size(207, 82);
               this.PanelNewFeatures.TabIndex = 5;
               this.PanelNewFeatures.Visible = false;
               // 
               // buttonEventsByParam
               // 
               this.buttonEventsByParam.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonEventsByParam.FlatAppearance.BorderSize = 0;
               this.buttonEventsByParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonEventsByParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonEventsByParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonEventsByParam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonEventsByParam.Location = new System.Drawing.Point(0, 39);
               this.buttonEventsByParam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonEventsByParam.Name = "buttonEventsByParam";
               this.buttonEventsByParam.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.buttonEventsByParam.Size = new System.Drawing.Size(207, 41);
               this.buttonEventsByParam.TabIndex = 2;
               this.buttonEventsByParam.Text = "Events Finder";
               this.buttonEventsByParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonEventsByParam.UseVisualStyleBackColor = true;
               this.buttonEventsByParam.Click += new System.EventHandler(this.buttonEventsByParam_Click);
               // 
               // buttonMatchMaker
               // 
               this.buttonMatchMaker.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonMatchMaker.FlatAppearance.BorderSize = 0;
               this.buttonMatchMaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonMatchMaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonMatchMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonMatchMaker.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonMatchMaker.Location = new System.Drawing.Point(0, 0);
               this.buttonMatchMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonMatchMaker.Name = "buttonMatchMaker";
               this.buttonMatchMaker.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.buttonMatchMaker.Size = new System.Drawing.Size(207, 39);
               this.buttonMatchMaker.TabIndex = 1;
               this.buttonMatchMaker.Text = "Match Maker";
               this.buttonMatchMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonMatchMaker.UseVisualStyleBackColor = true;
               this.buttonMatchMaker.Click += new System.EventHandler(this.buttonMatchMaker_Click);
               // 
               // buttonNewFeatures
               // 
               this.buttonNewFeatures.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonNewFeatures.FlatAppearance.BorderSize = 0;
               this.buttonNewFeatures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonNewFeatures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonNewFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonNewFeatures.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonNewFeatures.Location = new System.Drawing.Point(0, 180);
               this.buttonNewFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonNewFeatures.Name = "buttonNewFeatures";
               this.buttonNewFeatures.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.buttonNewFeatures.Size = new System.Drawing.Size(207, 46);
               this.buttonNewFeatures.TabIndex = 4;
               this.buttonNewFeatures.Text = "Special Features";
               this.buttonNewFeatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonNewFeatures.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.buttonNewFeatures.UseVisualStyleBackColor = true;
               this.buttonNewFeatures.Click += new System.EventHandler(this.buttonNewFeatures_Click);
               // 
               // PanelPhotos
               // 
               this.PanelPhotos.Controls.Add(this.buttonMyAlbums);
               this.PanelPhotos.Dock = System.Windows.Forms.DockStyle.Top;
               this.PanelPhotos.Location = new System.Drawing.Point(0, 134);
               this.PanelPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelPhotos.Name = "PanelPhotos";
               this.PanelPhotos.Size = new System.Drawing.Size(207, 46);
               this.PanelPhotos.TabIndex = 3;
               // 
               // buttonMyAlbums
               // 
               this.buttonMyAlbums.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonMyAlbums.FlatAppearance.BorderSize = 0;
               this.buttonMyAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonMyAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonMyAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonMyAlbums.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonMyAlbums.Location = new System.Drawing.Point(0, 0);
               this.buttonMyAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonMyAlbums.Name = "buttonMyAlbums";
               this.buttonMyAlbums.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.buttonMyAlbums.Size = new System.Drawing.Size(207, 39);
               this.buttonMyAlbums.TabIndex = 1;
               this.buttonMyAlbums.Text = "My Albums";
               this.buttonMyAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonMyAlbums.UseVisualStyleBackColor = true;
               this.buttonMyAlbums.Click += new System.EventHandler(this.buttonMyAlbums_Click);
               // 
               // button_Photos
               // 
               this.button_Photos.Dock = System.Windows.Forms.DockStyle.Top;
               this.button_Photos.FlatAppearance.BorderSize = 0;
               this.button_Photos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button_Photos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button_Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button_Photos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button_Photos.Location = new System.Drawing.Point(0, 88);
               this.button_Photos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button_Photos.Name = "button_Photos";
               this.button_Photos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.button_Photos.Size = new System.Drawing.Size(207, 46);
               this.button_Photos.TabIndex = 2;
               this.button_Photos.Text = "Photos";
               this.button_Photos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button_Photos.UseVisualStyleBackColor = true;
               this.button_Photos.Click += new System.EventHandler(this.button_Photos_Click);
               // 
               // PanelFriends
               // 
               this.PanelFriends.Controls.Add(this.buttonMyFriendsList);
               this.PanelFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.PanelFriends.Location = new System.Drawing.Point(0, 46);
               this.PanelFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelFriends.Name = "PanelFriends";
               this.PanelFriends.Size = new System.Drawing.Size(207, 42);
               this.PanelFriends.TabIndex = 1;
               // 
               // buttonMyFriendsList
               // 
               this.buttonMyFriendsList.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonMyFriendsList.FlatAppearance.BorderSize = 0;
               this.buttonMyFriendsList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonMyFriendsList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonMyFriendsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonMyFriendsList.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonMyFriendsList.Location = new System.Drawing.Point(0, 0);
               this.buttonMyFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonMyFriendsList.Name = "buttonMyFriendsList";
               this.buttonMyFriendsList.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
               this.buttonMyFriendsList.Size = new System.Drawing.Size(207, 39);
               this.buttonMyFriendsList.TabIndex = 1;
               this.buttonMyFriendsList.Text = "My Friends List";
               this.buttonMyFriendsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonMyFriendsList.UseVisualStyleBackColor = true;
               this.buttonMyFriendsList.Click += new System.EventHandler(this.buttonMyFriendsList_Click);
               // 
               // buttonFriends
               // 
               this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.buttonFriends.FlatAppearance.BorderSize = 0;
               this.buttonFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.buttonFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonFriends.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonFriends.Location = new System.Drawing.Point(0, 0);
               this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonFriends.Name = "buttonFriends";
               this.buttonFriends.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.buttonFriends.Size = new System.Drawing.Size(207, 46);
               this.buttonFriends.TabIndex = 0;
               this.buttonFriends.Text = "Friends";
               this.buttonFriends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.buttonFriends.UseVisualStyleBackColor = true;
               this.buttonFriends.Click += new System.EventHandler(this.ButtonFriends_Click);
               // 
               // panel1
               // 
               this.panel1.AutoScroll = true;
               this.panel1.BackColor = System.Drawing.Color.Transparent;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.PanelSelectedMenu);
               this.panel1.Controls.Add(this.PanelShadow);
               this.panel1.Controls.Add(this.PanelLeftSided);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 144);
               this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1183, 556);
               this.panel1.TabIndex = 1;
               // 
               // PanelSelectedMenu
               // 
               this.PanelSelectedMenu.AutoScroll = true;
               this.PanelSelectedMenu.Dock = System.Windows.Forms.DockStyle.Fill;
               this.PanelSelectedMenu.Location = new System.Drawing.Point(207, 10);
               this.PanelSelectedMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelSelectedMenu.Name = "PanelSelectedMenu";
               this.PanelSelectedMenu.Size = new System.Drawing.Size(976, 546);
               this.PanelSelectedMenu.TabIndex = 3;
               this.PanelSelectedMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSelectedMenu_Paint);
               // 
               // PanelShadow
               // 
               this.PanelShadow.Dock = System.Windows.Forms.DockStyle.Top;
               this.PanelShadow.Location = new System.Drawing.Point(207, 0);
               this.PanelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.PanelShadow.Name = "PanelShadow";
               this.PanelShadow.Size = new System.Drawing.Size(976, 10);
               this.PanelShadow.TabIndex = 2;
               // 
               // textboxWritePost
               // 
               this.textboxWritePost.ForeColor = System.Drawing.SystemColors.InfoText;
               this.textboxWritePost.Location = new System.Drawing.Point(477, 78);
               this.textboxWritePost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textboxWritePost.Name = "textboxWritePost";
               this.textboxWritePost.Size = new System.Drawing.Size(403, 22);
               this.textboxWritePost.TabIndex = 0;
               this.textboxWritePost.Text = "What\'s on your mind?";
               this.textboxWritePost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_TextBoxPost_MouseClick);
               this.textboxWritePost.TextChanged += new System.EventHandler(this.textboxWritePost_TextChanged);
               // 
               // buttonPost
               // 
               this.buttonPost.AutoSize = true;
               this.buttonPost.BackColor = System.Drawing.Color.Gray;
               this.buttonPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.buttonPost.FlatAppearance.BorderSize = 0;
               this.buttonPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
               this.buttonPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
               this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPost.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.buttonPost.Location = new System.Drawing.Point(395, 73);
               this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonPost.Name = "buttonPost";
               this.buttonPost.Size = new System.Drawing.Size(75, 36);
               this.buttonPost.TabIndex = 1;
               this.buttonPost.Text = "Post";
               this.buttonPost.UseVisualStyleBackColor = false;
               this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
               // 
               // panelProfileDetails
               // 
               this.panelProfileDetails.Controls.Add(this.label_LoggedInUserFullName);
               this.panelProfileDetails.Controls.Add(this.pictureBox_ProfilePicture);
               this.panelProfileDetails.Location = new System.Drawing.Point(3, 2);
               this.panelProfileDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panelProfileDetails.Name = "panelProfileDetails";
               this.panelProfileDetails.Size = new System.Drawing.Size(197, 142);
               this.panelProfileDetails.TabIndex = 2;
               // 
               // label_LoggedInUserFullName
               // 
               this.label_LoggedInUserFullName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label_LoggedInUserFullName.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.label_LoggedInUserFullName.Location = new System.Drawing.Point(16, 122);
               this.label_LoggedInUserFullName.MaximumSize = new System.Drawing.Size(180, 20);
               this.label_LoggedInUserFullName.Name = "label_LoggedInUserFullName";
               this.label_LoggedInUserFullName.Size = new System.Drawing.Size(120, 18);
               this.label_LoggedInUserFullName.TabIndex = 1;
               this.label_LoggedInUserFullName.Text = "User Full Name";
               this.label_LoggedInUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // pictureBox_ProfilePicture
               // 
               this.pictureBox_ProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_ProfilePicture.BackgroundImage")));
               this.pictureBox_ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(16, 7);
               this.pictureBox_ProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
               this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(120, 111);
               this.pictureBox_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox_ProfilePicture.TabIndex = 2;
               this.pictureBox_ProfilePicture.TabStop = false;
               // 
               // ButtonChosenMenu
               // 
               this.ButtonChosenMenu.AutoSize = true;
               this.ButtonChosenMenu.FlatAppearance.BorderSize = 0;
               this.ButtonChosenMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
               this.ButtonChosenMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
               this.ButtonChosenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.ButtonChosenMenu.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ButtonChosenMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.ButtonChosenMenu.Location = new System.Drawing.Point(216, 111);
               this.ButtonChosenMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.ButtonChosenMenu.Name = "ButtonChosenMenu";
               this.ButtonChosenMenu.Size = new System.Drawing.Size(155, 34);
               this.ButtonChosenMenu.TabIndex = 4;
               this.ButtonChosenMenu.Text = "ChosenMenu";
               this.ButtonChosenMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.ButtonChosenMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.ButtonChosenMenu.UseVisualStyleBackColor = true;
               // 
               // panel_TopMainForm
               // 
               this.panel_TopMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
               this.panel_TopMainForm.Controls.Add(this.buttonLogout);
               this.panel_TopMainForm.Controls.Add(this.ButtonChosenMenu);
               this.panel_TopMainForm.Controls.Add(this.panelProfileDetails);
               this.panel_TopMainForm.Controls.Add(this.buttonPost);
               this.panel_TopMainForm.Controls.Add(this.textboxWritePost);
               this.panel_TopMainForm.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel_TopMainForm.Location = new System.Drawing.Point(0, 0);
               this.panel_TopMainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panel_TopMainForm.Name = "panel_TopMainForm";
               this.panel_TopMainForm.Size = new System.Drawing.Size(1183, 144);
               this.panel_TopMainForm.TabIndex = 0;
               // 
               // buttonLogout
               // 
               this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.buttonLogout.AutoSize = true;
               this.buttonLogout.FlatAppearance.BorderSize = 0;
               this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
               this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
               this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.buttonLogout.Location = new System.Drawing.Point(1069, 105);
               this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.buttonLogout.Name = "buttonLogout";
               this.buttonLogout.Size = new System.Drawing.Size(116, 34);
               this.buttonLogout.TabIndex = 5;
               this.buttonLogout.Text = "Logout";
               this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.buttonLogout.UseVisualStyleBackColor = true;
               this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
               // 
               // FormMainPage
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1183, 700);
               this.ControlBox = false;
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.panel_TopMainForm);
               this.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.MaximizeBox = false;
               this.MinimumSize = new System.Drawing.Size(1198, 472);
               this.Name = "FormMainPage";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FacebookFormUi";
               this.Load += new System.EventHandler(this.FormMainPage_Load);
               this.PanelLeftSided.ResumeLayout(false);
               this.panelPosts.ResumeLayout(false);
               this.PanelNewFeatures.ResumeLayout(false);
               this.PanelPhotos.ResumeLayout(false);
               this.PanelFriends.ResumeLayout(false);
               this.panel1.ResumeLayout(false);
               this.panelProfileDetails.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
               this.panel_TopMainForm.ResumeLayout(false);
               this.panel_TopMainForm.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion
          private Panel PanelLeftSided;
          private Panel PanelNewFeatures;
          private Button buttonEventsByParam;
          private Button buttonMatchMaker;
          private Button buttonNewFeatures;
          private Panel PanelPhotos;
          private Button buttonMyAlbums;
          private Button button_Photos;
          private Panel PanelFriends;
          private Button buttonMyFriendsList;
          private Button buttonFriends;
          private Panel panel1;
          private Panel PanelSelectedMenu;
          private Panel PanelShadow;
          private Panel panelPosts;
          private Button ButtonMyPosts;
          private Button buttonPosts;
          private Button buttonNewsFeed;
          private TextBox textboxWritePost;
          private Button buttonPost;
          private Panel panelProfileDetails;
          private Label label_LoggedInUserFullName;
          private PictureBox pictureBox_ProfilePicture;
          private Button ButtonChosenMenu;
          private Panel panel_TopMainForm;
          private Button buttonLogout;
    }
}