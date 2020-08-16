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
               this.panel3 = new System.Windows.Forms.Panel();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.panel_TopMainForm.SuspendLayout();
               this.panelProfileDetails.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).BeginInit();
               this.panel1.SuspendLayout();
               this.m_PanelLeftSided.SuspendLayout();
               this.panel3.SuspendLayout();
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
               this.panel1.Controls.Add(this.panel2);
               this.panel1.Controls.Add(this.m_PanelLeftSided);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panel1.Location = new System.Drawing.Point(0, 144);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1182, 651);
               this.panel1.TabIndex = 1;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Azure;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel2.Location = new System.Drawing.Point(982, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(200, 651);
               this.panel2.TabIndex = 1;
               // 
               // m_PanelLeftSided
               // 
               this.m_PanelLeftSided.BackColor = System.Drawing.Color.Azure;
               this.m_PanelLeftSided.Controls.Add(this.panel3);
               this.m_PanelLeftSided.Controls.Add(this.button1);
               this.m_PanelLeftSided.Dock = System.Windows.Forms.DockStyle.Left;
               this.m_PanelLeftSided.Location = new System.Drawing.Point(0, 0);
               this.m_PanelLeftSided.Name = "m_PanelLeftSided";
               this.m_PanelLeftSided.Size = new System.Drawing.Size(200, 651);
               this.m_PanelLeftSided.TabIndex = 0;
               // 
               // button1
               // 
               this.button1.Dock = System.Windows.Forms.DockStyle.Top;
               this.button1.FlatAppearance.BorderSize = 0;
               this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
               this.button1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(0, 0);
               this.button1.Name = "button1";
               this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
               this.button1.Size = new System.Drawing.Size(200, 45);
               this.button1.TabIndex = 0;
               this.button1.Text = "button1";
               this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               this.button1.UseVisualStyleBackColor = true;
               // 
               // panel3
               // 
               this.panel3.Controls.Add(this.button4);
               this.panel3.Controls.Add(this.button3);
               this.panel3.Controls.Add(this.button2);
               this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel3.Location = new System.Drawing.Point(0, 45);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(200, 121);
               this.panel3.TabIndex = 1;
               // 
               // button2
               // 
               this.button2.Dock = System.Windows.Forms.DockStyle.Top;
               this.button2.FlatAppearance.BorderSize = 0;
               this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
               this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(0, 0);
               this.button2.Name = "button2";
               this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button2.Size = new System.Drawing.Size(200, 39);
               this.button2.TabIndex = 1;
               this.button2.Text = "button2";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Dock = System.Windows.Forms.DockStyle.Top;
               this.button3.FlatAppearance.BorderSize = 0;
               this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
               this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(0, 39);
               this.button3.Name = "button3";
               this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button3.Size = new System.Drawing.Size(200, 39);
               this.button3.TabIndex = 2;
               this.button3.Text = "button3";
               this.button3.UseVisualStyleBackColor = true;
               // 
               // button4
               // 
               this.button4.Dock = System.Windows.Forms.DockStyle.Top;
               this.button4.FlatAppearance.BorderSize = 0;
               this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
               this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
               this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(0, 78);
               this.button4.Name = "button4";
               this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
               this.button4.Size = new System.Drawing.Size(200, 40);
               this.button4.TabIndex = 3;
               this.button4.Text = "button4";
               this.button4.UseVisualStyleBackColor = true;
               // 
               // FacebookFormUi
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1182, 795);
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
               this.panelProfileDetails.ResumeLayout(false);
               this.panelProfileDetails.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfilePicture)).EndInit();
               this.panel1.ResumeLayout(false);
               this.m_PanelLeftSided.ResumeLayout(false);
               this.panel3.ResumeLayout(false);
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
          private System.Windows.Forms.Panel panel3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button2;
     }
}