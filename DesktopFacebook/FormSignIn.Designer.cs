using System;

namespace DesktopFacebook
{
     partial class FormSignIn
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
               this.panel1 = new System.Windows.Forms.Panel();
               this.customPictureBoxbutton = new DesktopFacebook.CustomPictureBoxButton();
               this.m_CheckBoxRememberMe = new System.Windows.Forms.CheckBox();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxbutton)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.customPictureBoxbutton);
               this.panel1.Controls.Add(this.m_CheckBoxRememberMe);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1288, 319);
               this.panel1.TabIndex = 0;
               // 
               // customPictureBoxbutton
               // 
               this.customPictureBoxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.customPictureBoxbutton.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.Image")));
               this.customPictureBoxbutton.Location = new System.Drawing.Point(25, 174);
               this.customPictureBoxbutton.m_HoverImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.m_HoverImage")));
               this.customPictureBoxbutton.m_NormalImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.m_NormalImage")));
               this.customPictureBoxbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.customPictureBoxbutton.Name = "customPictureBoxbutton";
               this.customPictureBoxbutton.Size = new System.Drawing.Size(206, 50);
               this.customPictureBoxbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.customPictureBoxbutton.TabIndex = 1;
               this.customPictureBoxbutton.TabStop = false;
               this.customPictureBoxbutton.Click += new System.EventHandler(this.customPictureBoxbutton_Click);
               this.customPictureBoxbutton.MouseLeave += new System.EventHandler(this.CustomPictureBoxbutton_MouseLeave);
               this.customPictureBoxbutton.MouseHover += new System.EventHandler(this.customPictureBoxbutton_MouseHover);
               // 
               // m_CheckBoxRememberMe
               // 
               this.m_CheckBoxRememberMe.AutoSize = true;
               this.m_CheckBoxRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
               this.m_CheckBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_CheckBoxRememberMe.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.m_CheckBoxRememberMe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.m_CheckBoxRememberMe.Location = new System.Drawing.Point(40, 230);
               this.m_CheckBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.m_CheckBoxRememberMe.Name = "m_CheckBoxRememberMe";
               this.m_CheckBoxRememberMe.Size = new System.Drawing.Size(188, 29);
               this.m_CheckBoxRememberMe.TabIndex = 0;
               this.m_CheckBoxRememberMe.Text = "Remember Me";
               this.m_CheckBoxRememberMe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.m_CheckBoxRememberMe.UseVisualStyleBackColor = false;
               this.m_CheckBoxRememberMe.CheckedChanged += new System.EventHandler(this.m_CheckBoxRememberMe_CheckedChanged);
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
               this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
               this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel2.Location = new System.Drawing.Point(0, 267);
               this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1288, 469);
               this.panel2.TabIndex = 1;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // FormSignIn
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1288, 736);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.Name = "FormSignIn";
               this.Text = "signInForm";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxbutton)).EndInit();
               this.ResumeLayout(false);

          }

          private void CustomPictureBoxbutton_MouseLeave(object sender, EventArgs e)
          {
               CustomPictureBoxButton customPictureBox = sender as CustomPictureBoxButton;
               customPictureBox.Image = customPictureBox.m_NormalImage;
          }

          private void customPictureBoxbutton_MouseHover(object sender, EventArgs e)
          {
               CustomPictureBoxButton customPictureBox = sender as CustomPictureBoxButton;
               customPictureBox.Image = customPictureBox.m_HoverImage;
          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.CheckBox m_CheckBoxRememberMe;
          private CustomPictureBoxButton customPictureBoxbutton;

          public CustomPictureBoxButton CustomedPictureBoxbutton
          {
               get
               {
                    return customPictureBoxbutton;
               }

          }
     }
}