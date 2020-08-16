namespace DesktopFacebook
{
     partial class signInForm
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInForm));
               this.panel1 = new System.Windows.Forms.Panel();
               this.customPictureBoxButton1 = new DesktopFacebook.CustomPictureBoxButton();
               this.m_CheckBoxRememberMe = new System.Windows.Forms.CheckBox();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButton1)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Controls.Add(this.customPictureBoxButton1);
               this.panel1.Controls.Add(this.m_CheckBoxRememberMe);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1145, 255);
               this.panel1.TabIndex = 0;
               // 
               // customPictureBoxButton1
               // 
               this.customPictureBoxButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButton1.BackgroundImage")));
               this.customPictureBoxButton1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButton1.Image")));
               this.customPictureBoxButton1.Location = new System.Drawing.Point(22, 139);
               this.customPictureBoxButton1.Name = "customPictureBoxButton1";
               this.customPictureBoxButton1.Size = new System.Drawing.Size(183, 40);
               this.customPictureBoxButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.customPictureBoxButton1.TabIndex = 1;
               this.customPictureBoxButton1.TabStop = false;
               this.customPictureBoxButton1.Click += new System.EventHandler(this.customPictureBoxButton1_Click);
               this.customPictureBoxButton1.MouseHover += new System.EventHandler(this.customPictureBoxButton1_MouseHover);
               // 
               // m_CheckBoxRememberMe
               // 
               this.m_CheckBoxRememberMe.AutoSize = true;
               this.m_CheckBoxRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
               this.m_CheckBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.m_CheckBoxRememberMe.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.m_CheckBoxRememberMe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
               this.m_CheckBoxRememberMe.Location = new System.Drawing.Point(36, 184);
               this.m_CheckBoxRememberMe.Name = "m_CheckBoxRememberMe";
               this.m_CheckBoxRememberMe.Size = new System.Drawing.Size(153, 23);
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
               this.panel2.Location = new System.Drawing.Point(0, 214);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1145, 375);
               this.panel2.TabIndex = 1;
               // 
               // signInForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1145, 589);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Name = "signInForm";
               this.Text = "signInForm";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButton1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.CheckBox m_CheckBoxRememberMe;
          private CustomPictureBoxButton customPictureBoxButton1;
     }
}