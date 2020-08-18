namespace DesktopFacebook.Forms
{
     partial class FormPosts
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
               this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
               this.SuspendLayout();
               // 
               // flowLayoutPanelPosts
               // 
               this.flowLayoutPanelPosts.AutoScroll = true;
               this.flowLayoutPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.flowLayoutPanelPosts.Location = new System.Drawing.Point(1, 1);
               this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
               this.flowLayoutPanelPosts.Size = new System.Drawing.Size(1063, 551);
               this.flowLayoutPanelPosts.TabIndex = 0;
               // 
               // FormPosts
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1067, 554);
               this.Controls.Add(this.flowLayoutPanelPosts);
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FormPosts";
               this.Text = "FormPosts";
               this.ResumeLayout(false);

          }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
    }
}