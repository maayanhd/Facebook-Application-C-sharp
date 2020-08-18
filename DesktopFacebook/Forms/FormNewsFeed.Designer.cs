namespace DesktopFacebook.Forms
{
     partial class FormNewsFeed
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
               this.flowLayoutPanelNewsFeed = new System.Windows.Forms.FlowLayoutPanel();
               this.SuspendLayout();
               // 
               // flowLayoutPanelNewsFeed
               // 
               this.flowLayoutPanelNewsFeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.flowLayoutPanelNewsFeed.AutoScroll = true;
               this.flowLayoutPanelNewsFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.flowLayoutPanelNewsFeed.Location = new System.Drawing.Point(1, 1);
               this.flowLayoutPanelNewsFeed.Margin = new System.Windows.Forms.Padding(4);
               this.flowLayoutPanelNewsFeed.Name = "flowLayoutPanelNewsFeed";
               this.flowLayoutPanelNewsFeed.Size = new System.Drawing.Size(853, 578);
               this.flowLayoutPanelNewsFeed.TabIndex = 0;
               // 
               // FormNewsFeed
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoScroll = true;
               this.ClientSize = new System.Drawing.Size(857, 583);
               this.Controls.Add(this.flowLayoutPanelNewsFeed);
               this.Margin = new System.Windows.Forms.Padding(4);
               this.Name = "FormNewsFeed";
               this.Text = "FormNewsFeed";
               this.ResumeLayout(false);

          }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNewsFeed;
    }
}