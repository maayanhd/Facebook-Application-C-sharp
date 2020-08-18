namespace DesktopFacebook.Forms
{
     partial class FormMyAlbums
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
               this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
               this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.pictureBoxSelectedPhoto = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPhoto)).BeginInit();
               this.SuspendLayout();
               // 
               // flowLayoutPanelAlbums
               // 
               this.flowLayoutPanelAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.flowLayoutPanelAlbums.AutoScroll = true;
               this.flowLayoutPanelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(16, 54);
               this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
               this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(232, 479);
               this.flowLayoutPanelAlbums.TabIndex = 0;
               // 
               // flowLayoutPanelPhotos
               // 
               this.flowLayoutPanelPhotos.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.flowLayoutPanelPhotos.AutoScroll = true;
               this.flowLayoutPanelPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(335, 54);
               this.flowLayoutPanelPhotos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
               this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(345, 479);
               this.flowLayoutPanelPhotos.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(31, 11);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(143, 23);
               this.label1.TabIndex = 3;
               this.label1.Text = "User\'s Albums";
               // 
               // label2
               // 
               this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(344, 11);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(153, 23);
               this.label2.TabIndex = 3;
               this.label2.Text = "Albums Photos";
               // 
               // label3
               // 
               this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(764, 11);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(157, 23);
               this.label3.TabIndex = 3;
               this.label3.Text = "Selected Photo";
               // 
               // pictureBoxSelectedPhoto
               // 
               this.pictureBoxSelectedPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.pictureBoxSelectedPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.pictureBoxSelectedPhoto.Location = new System.Drawing.Point(753, 54);
               this.pictureBoxSelectedPhoto.Margin = new System.Windows.Forms.Padding(4);
               this.pictureBoxSelectedPhoto.Name = "pictureBoxSelectedPhoto";
               this.pictureBoxSelectedPhoto.Size = new System.Drawing.Size(493, 480);
               this.pictureBoxSelectedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxSelectedPhoto.TabIndex = 2;
               this.pictureBoxSelectedPhoto.TabStop = false;
               // 
               // FormMyAlbums
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoScroll = true;
               this.ClientSize = new System.Drawing.Size(1269, 549);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.pictureBoxSelectedPhoto);
               this.Controls.Add(this.flowLayoutPanelPhotos);
               this.Controls.Add(this.flowLayoutPanelAlbums);
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FormMyAlbums";
               this.Text = "FormPhotos";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPhoto)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        internal System.Windows.Forms.PictureBox pictureBoxSelectedPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}