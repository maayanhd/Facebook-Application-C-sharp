using System.Drawing;
using System.Windows.Forms;

namespace DesktopFacebook
{
     partial class FormMainPage
     {
          // For fields section

          private Form m_CurrentChildForm;
          
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
                    m_CurrentChildForm.Close();
               }

               m_CurrentChildForm = ChildForm;
               ChildForm.TopLevel = false;
               ChildForm.FormBorderStyle = FormBorderStyle.None;
               ChildForm.Dock = DockStyle.Fill;
               m_PanelSelectedMenu.Controls.Add(ChildForm);
               m_PanelSelectedMenu.Tag = ChildForm;
               ChildForm.BringToFront();
               ChildForm.ShowDialog();
               m_ButtonChosenMenu.Text = ChildForm.Text;                        

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
               this.panel_TopMainForm = new System.Windows.Forms.Panel();
               this.m_ButtonChosenMenu = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.panelProfileDetails = new System.Windows.Forms.Panel();
               this.m_Label_LoggedInUserFullName = new System.Windows.Forms.Label();
               this.m_PictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
               this.m_ButtonPost = new System.Windows.Forms.Button();
               this.m_TextBoxPost = new System.Windows.Forms.TextBox();
               this.m_PanelLeftSided = new System.Windows.Forms.Panel();
               this.panel3 = new System.Windows.Forms.Panel();
               this.m_ButtonFetch = new System.Windows.Forms.Button();
               this.m_ButtonEvents = new System.Windows.Forms.Button();
               this.m_PanelNewFeatures = new System.Windows.Forms.Panel();
               this.m_ButtonEventsByParam = new System.Windows.Forms.Button();
               this.m_ButtonMatchMaker = new System.Windows.Forms.Button();
               this.m_ButtonNewFeatures = new System.Windows.Forms.Button();
               this.m_PanelPhotos = new System.Windows.Forms.Panel();
               this.m_ButtonMyAlbums = new System.Windows.Forms.Button();
               this.m_Button_Photos = new System.Windows.Forms.Button();
               this.m_PanelFriends = new System.Windows.Forms.Panel();
               this.m_ButtonMyFriends = new System.Windows.Forms.Button();
               this.m_ButtonFriends = new System.Windows.Forms.Button();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.m_PanelSelectedMenu = new System.Windows.Forms.Panel();
               this.m_PanelShadow = new System.Windows.Forms.Panel();
               this.panel_TopMainForm.SuspendLayout();
               this.panelProfileDetails.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox_ProfilePicture)).BeginInit();
               this.m_PanelLeftSided.SuspendLayout();
               this.panel3.SuspendLayout();
               this.m_PanelNewFeatures.SuspendLayout();
               this.m_PanelPhotos.SuspendLayout();
               this.m_PanelFriends.SuspendLayout();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel_TopMainForm
               // 
               this.panel_TopMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
               this.panel_TopMainForm.Controls.Add(this.m_ButtonChosenMenu);
               this.panel_TopMainForm.Controls.Add(this.button5);
               this.panel_TopMainForm.Controls.Add(this.panelProfileDetails);
               this.panel_TopMainForm.Controls.Add(this.m_ButtonPost);
               this.panel_TopMainForm.Controls.Add(this.m_TextBoxPost);
               this.panel_TopMainForm.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel_TopMainForm.Location = new System.Drawing.Point(0, 0);
               this.panel_TopMainForm.Name = "panel_TopMainForm";
               this.panel_TopMainForm.Size = new System.Drawing.Size(1194, 144);
               this.panel_TopMainForm.TabIndex = 0;
               // 
               // m_ButtonChosenMenu
               // 
               this.m_ButtonChosenMenu.AutoSize = true;
               this.m_ButtonChosenMenu.FlatAppearance.BorderSize = 0;
               this.m_ButtonChosenMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
               this.m_ButtonChosenMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
               this.m_ButtonChosenMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonChosenMenu.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonChosenMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
               this.m_ButtonChosenMenu.Location = new System.Drawing.Point(216, 111);
               this.m_ButtonChosenMenu.Name = "m_ButtonChosenMenu";
               this.m_ButtonChosenMenu.Size = new System.Drawing.Size(116, 30);
               this.m_ButtonChosenMenu.TabIndex = 4;
               this.m_ButtonChosenMenu.Text = "ChosenMenu";
               this.m_ButtonChosenMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_ButtonChosenMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.m_ButtonChosenMenu.UseVisualStyleBackColor = true;
               // 
               // button5
               // 
               this.button5.FlatAppearance.BorderSize = 0;
               this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
               this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.button5.Location = new System.Drawing.Point(1079, 111);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(90, 30);
               this.button5.TabIndex = 3;
               this.button5.Text = "Logout";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // panelProfileDetails
               // 
               this.panelProfileDetails.Controls.Add(this.m_Label_LoggedInUserFullName);
               this.panelProfileDetails.Controls.Add(this.m_PictureBox_ProfilePicture);
               this.panelProfileDetails.Location = new System.Drawing.Point(3, 3);
               this.panelProfileDetails.Name = "panelProfileDetails";
               this.panelProfileDetails.Size = new System.Drawing.Size(197, 141);
               this.panelProfileDetails.TabIndex = 2;
               // 
               // m_Label_LoggedInUserFullName
               // 
               this.m_Label_LoggedInUserFullName.AutoSize = true;
               this.m_Label_LoggedInUserFullName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_Label_LoggedInUserFullName.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.m_Label_LoggedInUserFullName.Location = new System.Drawing.Point(24, 119);
               this.m_Label_LoggedInUserFullName.MaximumSize = new System.Drawing.Size(180, 20);
               this.m_Label_LoggedInUserFullName.Name = "m_Label_LoggedInUserFullName";
               this.m_Label_LoggedInUserFullName.Size = new System.Drawing.Size(162, 17);
               this.m_Label_LoggedInUserFullName.TabIndex = 1;
               this.m_Label_LoggedInUserFullName.Text = "loggedInUserFullName";
               // 
               // m_PictureBox_ProfilePicture
               // 
               this.m_PictureBox_ProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_PictureBox_ProfilePicture.BackgroundImage")));
               this.m_PictureBox_ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.m_PictureBox_ProfilePicture.Location = new System.Drawing.Point(56, 16);
               this.m_PictureBox_ProfilePicture.Name = "m_PictureBox_ProfilePicture";
               this.m_PictureBox_ProfilePicture.Size = new System.Drawing.Size(82, 100);
               this.m_PictureBox_ProfilePicture.TabIndex = 2;
               this.m_PictureBox_ProfilePicture.TabStop = false;
               // 
               // m_ButtonPost
               // 
               this.m_ButtonPost.AutoSize = true;
               this.m_ButtonPost.BackColor = System.Drawing.Color.Gray;
               this.m_ButtonPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.m_ButtonPost.FlatAppearance.BorderSize = 0;
               this.m_ButtonPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
               this.m_ButtonPost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
               this.m_ButtonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonPost.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
               this.m_ButtonPost.Location = new System.Drawing.Point(358, 86);
               this.m_ButtonPost.Name = "m_ButtonPost";
               this.m_ButtonPost.Size = new System.Drawing.Size(75, 33);
               this.m_ButtonPost.TabIndex = 1;
               this.m_ButtonPost.Text = "Post";
               this.m_ButtonPost.UseVisualStyleBackColor = false;
               this.m_ButtonPost.Click += new System.EventHandler(this.m_ButtonPost_Click);
               // 
               // m_TextBoxPost
               // 
               this.m_TextBoxPost.ForeColor = System.Drawing.SystemColors.InfoText;
               this.m_TextBoxPost.Location = new System.Drawing.Point(439, 90);
               this.m_TextBoxPost.Name = "m_TextBoxPost";
               this.m_TextBoxPost.Size = new System.Drawing.Size(403, 22);
               this.m_TextBoxPost.TabIndex = 0;
               this.m_TextBoxPost.Text = "What\'s on your mind?";
               this.m_TextBoxPost.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // m_PanelLeftSided
               // 
               this.m_PanelLeftSided.AutoScroll = true;
               this.m_PanelLeftSided.BackColor = System.Drawing.Color.Azure;
               this.m_PanelLeftSided.Controls.Add(this.panel3);
               this.m_PanelLeftSided.Controls.Add(this.m_ButtonEvents);
               this.m_PanelLeftSided.Controls.Add(this.m_PanelNewFeatures);
               this.m_PanelLeftSided.Controls.Add(this.m_ButtonNewFeatures);
               this.m_PanelLeftSided.Controls.Add(this.m_PanelPhotos);
               this.m_PanelLeftSided.Controls.Add(this.m_Button_Photos);
               this.m_PanelLeftSided.Controls.Add(this.m_PanelFriends);
               this.m_PanelLeftSided.Controls.Add(this.m_ButtonFriends);
               this.m_PanelLeftSided.Dock = System.Windows.Forms.DockStyle.Left;
               this.m_PanelLeftSided.Location = new System.Drawing.Point(0, 0);
               this.m_PanelLeftSided.Name = "m_PanelLeftSided";
               this.m_PanelLeftSided.Size = new System.Drawing.Size(200, 319);
               this.m_PanelLeftSided.TabIndex = 0;
               // 
               // panel3
               // 
               this.panel3.Controls.Add(this.m_ButtonFetch);
               this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel3.Location = new System.Drawing.Point(0, 350);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(179, 41);
               this.panel3.TabIndex = 7;
               // 
               // m_ButtonFetch
               // 
               this.m_ButtonFetch.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonFetch.FlatAppearance.BorderSize = 0;
               this.m_ButtonFetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonFetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonFetch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonFetch.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonFetch.Name = "m_ButtonFetch";
               this.m_ButtonFetch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonFetch.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonFetch.TabIndex = 1;
               this.m_ButtonFetch.Text = "Fetch";
               this.m_ButtonFetch.UseVisualStyleBackColor = true;
               // 
               // m_ButtonEvents
               // 
               this.m_ButtonEvents.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonEvents.FlatAppearance.BorderSize = 0;
               this.m_ButtonEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonEvents.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonEvents.Location = new System.Drawing.Point(0, 305);
               this.m_ButtonEvents.Name = "m_ButtonEvents";
               this.m_ButtonEvents.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.m_ButtonEvents.Size = new System.Drawing.Size(179, 45);
               this.m_ButtonEvents.TabIndex = 6;
               this.m_ButtonEvents.Text = "Events";
               this.m_ButtonEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_ButtonEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.m_ButtonEvents.UseVisualStyleBackColor = true;
               // 
               // m_PanelNewFeatures
               // 
               this.m_PanelNewFeatures.Controls.Add(this.m_ButtonEventsByParam);
               this.m_PanelNewFeatures.Controls.Add(this.m_ButtonMatchMaker);
               this.m_PanelNewFeatures.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_PanelNewFeatures.Location = new System.Drawing.Point(0, 222);
               this.m_PanelNewFeatures.Name = "m_PanelNewFeatures";
               this.m_PanelNewFeatures.Size = new System.Drawing.Size(179, 83);
               this.m_PanelNewFeatures.TabIndex = 5;
               // 
               // m_ButtonEventsByParam
               // 
               this.m_ButtonEventsByParam.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonEventsByParam.FlatAppearance.BorderSize = 0;
               this.m_ButtonEventsByParam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonEventsByParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonEventsByParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonEventsByParam.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonEventsByParam.Location = new System.Drawing.Point(0, 39);
               this.m_ButtonEventsByParam.Name = "m_ButtonEventsByParam";
               this.m_ButtonEventsByParam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonEventsByParam.Size = new System.Drawing.Size(179, 44);
               this.m_ButtonEventsByParam.TabIndex = 2;
               this.m_ButtonEventsByParam.Text = "Event by Filter";
               this.m_ButtonEventsByParam.UseVisualStyleBackColor = true;
               // 
               // m_ButtonMatchMaker
               // 
               this.m_ButtonMatchMaker.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonMatchMaker.FlatAppearance.BorderSize = 0;
               this.m_ButtonMatchMaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonMatchMaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonMatchMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonMatchMaker.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonMatchMaker.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonMatchMaker.Name = "m_ButtonMatchMaker";
               this.m_ButtonMatchMaker.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonMatchMaker.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonMatchMaker.TabIndex = 1;
               this.m_ButtonMatchMaker.Text = "MatchMaker";
               this.m_ButtonMatchMaker.UseVisualStyleBackColor = true;
               // 
               // m_ButtonNewFeatures
               // 
               this.m_ButtonNewFeatures.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonNewFeatures.FlatAppearance.BorderSize = 0;
               this.m_ButtonNewFeatures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonNewFeatures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonNewFeatures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonNewFeatures.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonNewFeatures.Location = new System.Drawing.Point(0, 177);
               this.m_ButtonNewFeatures.Name = "m_ButtonNewFeatures";
               this.m_ButtonNewFeatures.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.m_ButtonNewFeatures.Size = new System.Drawing.Size(179, 45);
               this.m_ButtonNewFeatures.TabIndex = 4;
               this.m_ButtonNewFeatures.Text = "New Features";
               this.m_ButtonNewFeatures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_ButtonNewFeatures.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.m_ButtonNewFeatures.UseVisualStyleBackColor = true;
               // 
               // m_PanelPhotos
               // 
               this.m_PanelPhotos.Controls.Add(this.m_ButtonMyAlbums);
               this.m_PanelPhotos.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_PanelPhotos.Location = new System.Drawing.Point(0, 132);
               this.m_PanelPhotos.Name = "m_PanelPhotos";
               this.m_PanelPhotos.Size = new System.Drawing.Size(179, 45);
               this.m_PanelPhotos.TabIndex = 3;
               // 
               // m_ButtonMyAlbums
               // 
               this.m_ButtonMyAlbums.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonMyAlbums.FlatAppearance.BorderSize = 0;
               this.m_ButtonMyAlbums.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonMyAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonMyAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonMyAlbums.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonMyAlbums.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonMyAlbums.Name = "m_ButtonMyAlbums";
               this.m_ButtonMyAlbums.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonMyAlbums.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonMyAlbums.TabIndex = 1;
               this.m_ButtonMyAlbums.Text = "my Albums";
               this.m_ButtonMyAlbums.UseVisualStyleBackColor = true;
               // 
               // m_Button_Photos
               // 
               this.m_Button_Photos.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_Button_Photos.FlatAppearance.BorderSize = 0;
               this.m_Button_Photos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_Button_Photos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_Button_Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_Button_Photos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_Button_Photos.Location = new System.Drawing.Point(0, 87);
               this.m_Button_Photos.Name = "m_Button_Photos";
               this.m_Button_Photos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.m_Button_Photos.Size = new System.Drawing.Size(179, 45);
               this.m_Button_Photos.TabIndex = 2;
               this.m_Button_Photos.Text = "Photos";
               this.m_Button_Photos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_Button_Photos.UseVisualStyleBackColor = true;
               this.m_Button_Photos.Click += new System.EventHandler(this.m_Button_Photos_Click);
               // 
               // m_PanelFriends
               // 
               this.m_PanelFriends.Controls.Add(this.m_ButtonMyFriends);
               this.m_PanelFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_PanelFriends.Location = new System.Drawing.Point(0, 45);
               this.m_PanelFriends.Name = "m_PanelFriends";
               this.m_PanelFriends.Size = new System.Drawing.Size(179, 42);
               this.m_PanelFriends.TabIndex = 1;
               // 
               // m_ButtonMyFriends
               // 
               this.m_ButtonMyFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonMyFriends.FlatAppearance.BorderSize = 0;
               this.m_ButtonMyFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonMyFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonMyFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonMyFriends.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonMyFriends.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonMyFriends.Name = "m_ButtonMyFriends";
               this.m_ButtonMyFriends.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonMyFriends.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonMyFriends.TabIndex = 1;
               this.m_ButtonMyFriends.Text = "My Friends List";
               this.m_ButtonMyFriends.UseVisualStyleBackColor = true;
               // 
               // m_ButtonFriends
               // 
               this.m_ButtonFriends.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonFriends.FlatAppearance.BorderSize = 0;
               this.m_ButtonFriends.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonFriends.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonFriends.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonFriends.Name = "m_ButtonFriends";
               this.m_ButtonFriends.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.m_ButtonFriends.Size = new System.Drawing.Size(179, 45);
               this.m_ButtonFriends.TabIndex = 0;
               this.m_ButtonFriends.Text = "Friends";
               this.m_ButtonFriends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_ButtonFriends.UseVisualStyleBackColor = true;
               this.m_ButtonFriends.Click += new System.EventHandler(this.m_ButtonFriends_Click);
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Azure;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel2.Location = new System.Drawing.Point(994, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(200, 319);
               this.panel2.TabIndex = 1;
               // 
               // panel1
               // 
               this.panel1.AutoScroll = true;
               this.panel1.BackColor = System.Drawing.Color.Transparent;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.m_PanelSelectedMenu);
               this.panel1.Controls.Add(this.m_PanelShadow);
               this.panel1.Controls.Add(this.panel2);
               this.panel1.Controls.Add(this.m_PanelLeftSided);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 144);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1194, 319);
               this.panel1.TabIndex = 1;
               // 
               // m_PanelSelectedMenu
               // 
               this.m_PanelSelectedMenu.Dock = System.Windows.Forms.DockStyle.Fill;
               this.m_PanelSelectedMenu.Location = new System.Drawing.Point(200, 10);
               this.m_PanelSelectedMenu.Name = "m_PanelSelectedMenu";
               this.m_PanelSelectedMenu.Size = new System.Drawing.Size(794, 309);
               this.m_PanelSelectedMenu.TabIndex = 3;
               // 
               // m_PanelShadow
               // 
               this.m_PanelShadow.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_PanelShadow.Location = new System.Drawing.Point(200, 0);
               this.m_PanelShadow.Name = "m_PanelShadow";
               this.m_PanelShadow.Size = new System.Drawing.Size(794, 10);
               this.m_PanelShadow.TabIndex = 2;
               // 
               // FormMainPage
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1194, 463);
               this.ControlBox = false;
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.panel_TopMainForm);
               this.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.MinimumSize = new System.Drawing.Size(1200, 475);
               this.Name = "FormMainPage";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FacebookFormUi";
               this.TopMost = true;
               this.panel_TopMainForm.ResumeLayout(false);
               this.panel_TopMainForm.PerformLayout();
               this.panelProfileDetails.ResumeLayout(false);
               this.panelProfileDetails.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox_ProfilePicture)).EndInit();
               this.m_PanelLeftSided.ResumeLayout(false);
               this.panel3.ResumeLayout(false);
               this.m_PanelNewFeatures.ResumeLayout(false);
               this.m_PanelPhotos.ResumeLayout(false);
               this.m_PanelFriends.ResumeLayout(false);
               this.panel1.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel_TopMainForm;
          private System.Windows.Forms.TextBox m_TextBoxPost;
          private System.Windows.Forms.Button m_ButtonPost;
          private System.Windows.Forms.PictureBox m_PictureBox_ProfilePicture;
          private System.Windows.Forms.Label m_Label_LoggedInUserFullName;
          private System.Windows.Forms.Panel panelProfileDetails;
          private System.Windows.Forms.Button button5;
          private Panel m_PanelLeftSided;
          private Panel m_PanelNewFeatures;
          private Button m_ButtonEventsByParam;
          private Button m_ButtonMatchMaker;
          private Button m_ButtonNewFeatures;
          private Panel m_PanelPhotos;
          private Button m_ButtonMyAlbums;
          private Button m_Button_Photos;
          private Panel m_PanelFriends;
          private Button m_ButtonMyFriends;
          private Button m_ButtonFriends;
          private Panel panel2;
          private Panel panel1;
          private Panel m_PanelSelectedMenu;
          private Panel m_PanelShadow;
          private Button m_ButtonChosenMenu;
          private Panel panel3;
          private Button m_ButtonFetch;
          private Button m_ButtonEvents;
     }
}