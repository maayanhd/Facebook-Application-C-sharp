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
               this.m_CheckBoxRememberMe = new System.Windows.Forms.CheckBox();
               this.customPictureBoxbutton = new DesktopFacebook.CustomPictureBoxButton();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxbutton)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = global::DesktopFacebook.Properties.Resources.appSignIn2;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.m_CheckBoxRememberMe);
               this.panel1.Controls.Add(this.customPictureBoxbutton);
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1147, 587);
               this.panel1.TabIndex = 2;
               // 
               // m_CheckBoxRememberMe
               // 
               this.m_CheckBoxRememberMe.AutoSize = true;
               this.m_CheckBoxRememberMe.BackColor = System.Drawing.Color.Transparent;
               this.m_CheckBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_CheckBoxRememberMe.ForeColor = System.Drawing.Color.Navy;
               this.m_CheckBoxRememberMe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.m_CheckBoxRememberMe.Location = new System.Drawing.Point(475, 501);
               this.m_CheckBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.m_CheckBoxRememberMe.Name = "m_CheckBoxRememberMe";
               this.m_CheckBoxRememberMe.Size = new System.Drawing.Size(168, 27);
               this.m_CheckBoxRememberMe.TabIndex = 0;
               this.m_CheckBoxRememberMe.Text = "Remember Me";
               this.m_CheckBoxRememberMe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
               this.m_CheckBoxRememberMe.UseVisualStyleBackColor = false;
               this.m_CheckBoxRememberMe.CheckedChanged += new System.EventHandler(this.m_CheckBoxRememberMe_CheckedChanged);
               // 
               // customPictureBoxbutton
               // 
               this.customPictureBoxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.customPictureBoxbutton.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.Image")));
               this.customPictureBoxbutton.Location = new System.Drawing.Point(443, 425);
               this.customPictureBoxbutton.m_HoverImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.m_HoverImage")));
               this.customPictureBoxbutton.m_NormalImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxbutton.m_NormalImage")));
               this.customPictureBoxbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.customPictureBoxbutton.Name = "customPictureBoxbutton";
               this.customPictureBoxbutton.Size = new System.Drawing.Size(240, 55);
               this.customPictureBoxbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.customPictureBoxbutton.TabIndex = 1;
               this.customPictureBoxbutton.TabStop = false;
               this.customPictureBoxbutton.Click += new System.EventHandler(this.customPictureBoxbutton_Click);
               this.customPictureBoxbutton.MouseLeave += new System.EventHandler(this.CustomPictureBoxbutton_MouseLeave);
               this.customPictureBoxbutton.MouseHover += new System.EventHandler(this.customPictureBoxbutton_MouseHover);
               // 
               // FormSignIn
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1145, 588);
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

        private System.Windows.Forms.CheckBox m_CheckBoxRememberMe;
        private CustomPictureBoxButton customPictureBoxbutton;
        private System.Windows.Forms.Panel panel1;

        public CustomPictureBoxButton CustomedPictureBoxbutton
          {
               get
               {
                    return customPictureBoxbutton;
               }

          }
     }
}