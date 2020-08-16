using System.Drawing;

namespace DesktopFacebook
{
     partial class FacebookFormUi
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookFormUi));
               this.panel_TopMainForm = new System.Windows.Forms.Panel();
               this.panelProfileDetails = new System.Windows.Forms.Panel();
               this.m_Label_LoggedInUserFullName = new System.Windows.Forms.Label();
               this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
               this.m_ButtonPost = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.m_PanelLeftSided = new System.Windows.Forms.Panel();
               this.button1 = new System.Windows.Forms.Button();
               this.panel_Friends = new System.Windows.Forms.Panel();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.m_Button_Photos = new System.Windows.Forms.Button();
               this.m_PanelPhotos = new System.Windows.Forms.Panel();
               this.button6 = new System.Windows.Forms.Button();
               this.m_ButtonProfilePictures = new System.Windows.Forms.Button();
               this.m_ButtonMyAlbums = new System.Windows.Forms.Button();
               this.button9 = new System.Windows.Forms.Button();
               this.panel4 = new System.Windows.Forms.Panel();
               this.m_ButtonFeature2 = new System.Windows.Forms.Button();
               this.m_ButtonFeature1 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
               this.panel_TopMainForm.SuspendLayout();
               this.panelProfileDetails.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
               this.panel1.SuspendLayout();
               this.m_PanelLeftSided.SuspendLayout();
               this.panel_Friends.SuspendLayout();
               this.m_PanelPhotos.SuspendLayout();
               this.panel4.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel_TopMainForm
               // 
               this.panel_TopMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
               this.panel_TopMainForm.Controls.Add(this.button5);
               this.panel_TopMainForm.Controls.Add(this.panelProfileDetails);
               this.panel_TopMainForm.Controls.Add(this.m_ButtonPost);
               this.panel_TopMainForm.Controls.Add(this.textBox1);
               this.panel_TopMainForm.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel_TopMainForm.Location = new System.Drawing.Point(0, 0);
               this.panel_TopMainForm.Name = "panel_TopMainForm";
               this.panel_TopMainForm.Size = new System.Drawing.Size(1182, 144);
               this.panel_TopMainForm.TabIndex = 0;
               this.panel_TopMainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // panelProfileDetails
               // 
               this.panelProfileDetails.Controls.Add(this.m_Label_LoggedInUserFullName);
               this.panelProfileDetails.Controls.Add(this.pictureBox_ProfilePicture);
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
               this.m_Label_LoggedInUserFullName.Click += new System.EventHandler(this.label2_Click_1);
               // 
               // pictureBox_ProfilePicture
               // 
               this.pictureBox_ProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_ProfilePicture.BackgroundImage")));
               this.pictureBox_ProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.pictureBox_ProfilePicture.Location = new System.Drawing.Point(56, 16);
               this.pictureBox_ProfilePicture.Name = "pictureBox_ProfilePicture";
               this.pictureBox_ProfilePicture.Size = new System.Drawing.Size(82, 100);
               this.pictureBox_ProfilePicture.TabIndex = 2;
               this.pictureBox_ProfilePicture.TabStop = false;
               this.pictureBox_ProfilePicture.Click += new System.EventHandler(this.pictureBox_ProfilePicture_Click);
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
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(439, 90);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(403, 22);
               this.textBox1.TabIndex = 0;
               this.textBox1.Text = "What do you think";
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // panel1
               // 
               this.panel1.AutoScroll = true;
               this.panel1.BackColor = System.Drawing.Color.Transparent;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.flowLayoutPanelPosts);
               this.panel1.Controls.Add(this.panel2);
               this.panel1.Controls.Add(this.m_PanelLeftSided);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 144);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1182, 285);
               this.panel1.TabIndex = 1;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Azure;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel2.Location = new System.Drawing.Point(982, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(200, 285);
               this.panel2.TabIndex = 1;
               // 
               // m_PanelLeftSided
               // 
               this.m_PanelLeftSided.AutoScroll = true;
               this.m_PanelLeftSided.BackColor = System.Drawing.Color.Azure;
               this.m_PanelLeftSided.Controls.Add(this.panel4);
               this.m_PanelLeftSided.Controls.Add(this.button9);
               this.m_PanelLeftSided.Controls.Add(this.m_PanelPhotos);
               this.m_PanelLeftSided.Controls.Add(this.m_Button_Photos);
               this.m_PanelLeftSided.Controls.Add(this.panel_Friends);
               this.m_PanelLeftSided.Controls.Add(this.button1);
               this.m_PanelLeftSided.Dock = System.Windows.Forms.DockStyle.Left;
               this.m_PanelLeftSided.Location = new System.Drawing.Point(0, 0);
               this.m_PanelLeftSided.Name = "m_PanelLeftSided";
               this.m_PanelLeftSided.Size = new System.Drawing.Size(200, 285);
               this.m_PanelLeftSided.TabIndex = 0;
               // 
               // button1
               // 
               this.button1.Dock = System.Windows.Forms.DockStyle.Top;
               this.button1.FlatAppearance.BorderSize = 0;
               this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(0, 0);
               this.button1.Name = "button1";
               this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.button1.Size = new System.Drawing.Size(179, 45);
               this.button1.TabIndex = 0;
               this.button1.Text = "Friends";
               this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // panel_Friends
               // 
               this.panel_Friends.Controls.Add(this.button4);
               this.panel_Friends.Controls.Add(this.button3);
               this.panel_Friends.Controls.Add(this.button2);
               this.panel_Friends.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel_Friends.Location = new System.Drawing.Point(0, 45);
               this.panel_Friends.Name = "panel_Friends";
               this.panel_Friends.Size = new System.Drawing.Size(179, 121);
               this.panel_Friends.TabIndex = 1;
               this.panel_Friends.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Friends_Paint);
               // 
               // button2
               // 
               this.button2.Dock = System.Windows.Forms.DockStyle.Top;
               this.button2.FlatAppearance.BorderSize = 0;
               this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(0, 0);
               this.button2.Name = "button2";
               this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button2.Size = new System.Drawing.Size(179, 39);
               this.button2.TabIndex = 1;
               this.button2.Text = "by name";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Dock = System.Windows.Forms.DockStyle.Top;
               this.button3.FlatAppearance.BorderSize = 0;
               this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(0, 39);
               this.button3.Name = "button3";
               this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button3.Size = new System.Drawing.Size(179, 39);
               this.button3.TabIndex = 2;
               this.button3.Text = "by address";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.Dock = System.Windows.Forms.DockStyle.Top;
               this.button4.FlatAppearance.BorderSize = 0;
               this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(0, 78);
               this.button4.Name = "button4";
               this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button4.Size = new System.Drawing.Size(179, 43);
               this.button4.TabIndex = 3;
               this.button4.Text = "by picture";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // m_Button_Photos
               // 
               this.m_Button_Photos.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_Button_Photos.FlatAppearance.BorderSize = 0;
               this.m_Button_Photos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_Button_Photos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_Button_Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_Button_Photos.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_Button_Photos.Location = new System.Drawing.Point(0, 166);
               this.m_Button_Photos.Name = "m_Button_Photos";
               this.m_Button_Photos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.m_Button_Photos.Size = new System.Drawing.Size(179, 45);
               this.m_Button_Photos.TabIndex = 2;
               this.m_Button_Photos.Text = "Photos";
               this.m_Button_Photos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.m_Button_Photos.UseVisualStyleBackColor = true;
               // 
               // m_PanelPhotos
               // 
               this.m_PanelPhotos.Controls.Add(this.button6);
               this.m_PanelPhotos.Controls.Add(this.m_ButtonProfilePictures);
               this.m_PanelPhotos.Controls.Add(this.m_ButtonMyAlbums);
               this.m_PanelPhotos.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_PanelPhotos.Location = new System.Drawing.Point(0, 211);
               this.m_PanelPhotos.Name = "m_PanelPhotos";
               this.m_PanelPhotos.Size = new System.Drawing.Size(179, 121);
               this.m_PanelPhotos.TabIndex = 3;
               // 
               // button6
               // 
               this.button6.Dock = System.Windows.Forms.DockStyle.Top;
               this.button6.FlatAppearance.BorderSize = 0;
               this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button6.Location = new System.Drawing.Point(0, 78);
               this.button6.Name = "button6";
               this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button6.Size = new System.Drawing.Size(179, 40);
               this.button6.TabIndex = 3;
               this.button6.Text = "button6";
               this.button6.UseVisualStyleBackColor = true;
               // 
               // m_ButtonProfilePictures
               // 
               this.m_ButtonProfilePictures.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonProfilePictures.FlatAppearance.BorderSize = 0;
               this.m_ButtonProfilePictures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonProfilePictures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonProfilePictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonProfilePictures.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonProfilePictures.Location = new System.Drawing.Point(0, 39);
               this.m_ButtonProfilePictures.Name = "m_ButtonProfilePictures";
               this.m_ButtonProfilePictures.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonProfilePictures.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonProfilePictures.TabIndex = 2;
               this.m_ButtonProfilePictures.Text = "profile pictures";
               this.m_ButtonProfilePictures.UseVisualStyleBackColor = true;
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
               // button9
               // 
               this.button9.Dock = System.Windows.Forms.DockStyle.Top;
               this.button9.FlatAppearance.BorderSize = 0;
               this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button9.Location = new System.Drawing.Point(0, 332);
               this.button9.Name = "button9";
               this.button9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.button9.Size = new System.Drawing.Size(179, 45);
               this.button9.TabIndex = 4;
               this.button9.Text = "New Features";
               this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button9.UseVisualStyleBackColor = true;
               // 
               // panel4
               // 
               this.panel4.Controls.Add(this.m_ButtonFeature2);
               this.panel4.Controls.Add(this.m_ButtonFeature1);
               this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel4.Location = new System.Drawing.Point(0, 377);
               this.panel4.Name = "panel4";
               this.panel4.Size = new System.Drawing.Size(179, 83);
               this.panel4.TabIndex = 5;
               // 
               // m_ButtonFeature2
               // 
               this.m_ButtonFeature2.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonFeature2.FlatAppearance.BorderSize = 0;
               this.m_ButtonFeature2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonFeature2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonFeature2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonFeature2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonFeature2.Location = new System.Drawing.Point(0, 39);
               this.m_ButtonFeature2.Name = "m_ButtonFeature2";
               this.m_ButtonFeature2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonFeature2.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonFeature2.TabIndex = 2;
               this.m_ButtonFeature2.Text = "Feature2";
               this.m_ButtonFeature2.UseVisualStyleBackColor = true;
               // 
               // m_ButtonFeature1
               // 
               this.m_ButtonFeature1.Dock = System.Windows.Forms.DockStyle.Top;
               this.m_ButtonFeature1.FlatAppearance.BorderSize = 0;
               this.m_ButtonFeature1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
               this.m_ButtonFeature1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
               this.m_ButtonFeature1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.m_ButtonFeature1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_ButtonFeature1.Location = new System.Drawing.Point(0, 0);
               this.m_ButtonFeature1.Name = "m_ButtonFeature1";
               this.m_ButtonFeature1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.m_ButtonFeature1.Size = new System.Drawing.Size(179, 39);
               this.m_ButtonFeature1.TabIndex = 1;
               this.m_ButtonFeature1.Text = "Feature1";
               this.m_ButtonFeature1.UseVisualStyleBackColor = true;
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
               // 
               // flowLayoutPanelPosts
               // 
               this.flowLayoutPanelPosts.AutoScroll = true;
               this.flowLayoutPanelPosts.Dock = System.Windows.Forms.DockStyle.Fill;
               this.flowLayoutPanelPosts.Location = new System.Drawing.Point(200, 0);
               this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
               this.flowLayoutPanelPosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
               this.flowLayoutPanelPosts.Size = new System.Drawing.Size(782, 285);
               this.flowLayoutPanelPosts.TabIndex = 2;
               // 
               // FacebookFormUi
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1182, 429);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.panel_TopMainForm);
               this.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.MinimumSize = new System.Drawing.Size(1200, 475);
               this.Name = "FacebookFormUi";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FacebookFormUi";
               this.TopMost = true;
               this.panel_TopMainForm.ResumeLayout(false);
               this.panel_TopMainForm.PerformLayout();
               this.panelProfileDetails.ResumeLayout(false);
               this.panelProfileDetails.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
               this.panel1.ResumeLayout(false);
               this.m_PanelLeftSided.ResumeLayout(false);
               this.panel_Friends.ResumeLayout(false);
               this.m_PanelPhotos.ResumeLayout(false);
               this.panel4.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel_TopMainForm;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button m_ButtonPost;
          private System.Windows.Forms.PictureBox pictureBox_ProfilePicture;
          private System.Windows.Forms.Label m_Label_LoggedInUserFullName;
          private System.Windows.Forms.Panel panelProfileDetails;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.Panel m_PanelLeftSided;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Panel panel_Friends;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
          private System.Windows.Forms.Panel panel4;
          private System.Windows.Forms.Button m_ButtonFeature2;
          private System.Windows.Forms.Button m_ButtonFeature1;
          private System.Windows.Forms.Button button9;
          private System.Windows.Forms.Panel m_PanelPhotos;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button m_ButtonProfilePictures;
          private System.Windows.Forms.Button m_ButtonMyAlbums;
          private System.Windows.Forms.Button m_Button_Photos;
     }
}