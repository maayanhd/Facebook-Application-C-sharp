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
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.m_ButtonPost = new System.Windows.Forms.Button();
               this.pictureBox_ProfilePicture = new System.Windows.Forms.PictureBox();
               this.m_Label_LoggedInUserFullName = new System.Windows.Forms.Label();
               this.panelProfileDetails = new System.Windows.Forms.Panel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.m_PanelLeftSided = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel_TopMainForm.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
               this.panelProfileDetails.SuspendLayout();
               this.panel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel_TopMainForm
               // 
               this.panel_TopMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
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
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(439, 90);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(403, 22);
               this.textBox1.TabIndex = 0;
               this.textBox1.Text = "What do you think";
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
               // panelProfileDetails
               // 
               this.panelProfileDetails.Controls.Add(this.m_Label_LoggedInUserFullName);
               this.panelProfileDetails.Controls.Add(this.pictureBox_ProfilePicture);
               this.panelProfileDetails.Location = new System.Drawing.Point(3, 3);
               this.panelProfileDetails.Name = "panelProfileDetails";
               this.panelProfileDetails.Size = new System.Drawing.Size(197, 141);
               this.panelProfileDetails.TabIndex = 2;
               // 
               // panel1
               // 
               this.panel1.AutoScroll = true;
               this.panel1.BackColor = System.Drawing.Color.Transparent;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.panel2);
               this.panel1.Controls.Add(this.m_PanelLeftSided);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 144);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1182, 513);
               this.panel1.TabIndex = 1;
               // 
               // m_PanelLeftSided
               // 
               this.m_PanelLeftSided.BackColor = System.Drawing.Color.Azure;
               this.m_PanelLeftSided.Dock = System.Windows.Forms.DockStyle.Left;
               this.m_PanelLeftSided.Location = new System.Drawing.Point(0, 0);
               this.m_PanelLeftSided.Name = "m_PanelLeftSided";
               this.m_PanelLeftSided.Size = new System.Drawing.Size(200, 513);
               this.m_PanelLeftSided.TabIndex = 0;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Azure;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel2.Location = new System.Drawing.Point(982, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(200, 513);
               this.panel2.TabIndex = 1;
               // 
               // FacebookFormUi
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1182, 657);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.panel_TopMainForm);
               this.Cursor = System.Windows.Forms.Cursors.Arrow;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.MinimumSize = new System.Drawing.Size(1200, 700);
               this.Name = "FacebookFormUi";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "FacebookFormUi";
               this.TopMost = true;
               this.panel_TopMainForm.ResumeLayout(false);
               this.panel_TopMainForm.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
               this.panelProfileDetails.ResumeLayout(false);
               this.panelProfileDetails.PerformLayout();
               this.panel1.ResumeLayout(false);
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
     }
}