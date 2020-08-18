namespace DesktopFacebook.Forms
{
     partial class FormEventByParameters
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCutomedEvents;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventByParameters));
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.comboBoxAgeRange = new System.Windows.Forms.ComboBox();
            this.labelTimeFrame = new System.Windows.Forms.Label();
            this.comboBoxTimeFrame = new System.Windows.Forms.ComboBox();
            this.comboBoxSexPreference = new System.Windows.Forms.ComboBox();
            this.labelSAexPreference = new System.Windows.Forms.Label();
            this.labelParticipentsReligion = new System.Windows.Forms.Label();
            this.comboBoxReligion = new System.Windows.Forms.ComboBox();
            this.labelRequirementsNotice = new System.Windows.Forms.Label();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelDescriptionContent = new System.Windows.Forms.Label();
            this.customPictureBoxButtonFilterEvent = new DesktopFacebook.CustomPictureBoxButton();
            this.labelGenerate = new System.Windows.Forms.Label();
            flowLayoutPanelCutomedEvents = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButtonFilterEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCutomedEvents
            // 
            flowLayoutPanelCutomedEvents.AutoScroll = true;
            flowLayoutPanelCutomedEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flowLayoutPanelCutomedEvents.Location = new System.Drawing.Point(21, 211);
            flowLayoutPanelCutomedEvents.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanelCutomedEvents.MinimumSize = new System.Drawing.Size(601, 155);
            flowLayoutPanelCutomedEvents.Name = "flowLayoutPanelCutomedEvents";
            flowLayoutPanelCutomedEvents.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            flowLayoutPanelCutomedEvents.Size = new System.Drawing.Size(601, 155);
            flowLayoutPanelCutomedEvents.TabIndex = 0;
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.AutoSize = true;
            this.labelAgeRange.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelAgeRange.Location = new System.Drawing.Point(18, 60);
            this.labelAgeRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(111, 15);
            this.labelAgeRange.TabIndex = 1;
            this.labelAgeRange.Text = "Friend\'s Age Range";
            this.labelAgeRange.Click += new System.EventHandler(this.labelAgeRange_Click);
            // 
            // comboBoxAgeRange
            // 
            this.comboBoxAgeRange.FormattingEnabled = true;
            this.comboBoxAgeRange.Items.AddRange(new object[] {
            "under 18",
            "18 - 24",
            "24 - 30",
            "30 - 40",
            "40 - 50",
            "50 - 60 ",
            "over 60"});
            this.comboBoxAgeRange.Location = new System.Drawing.Point(146, 60);
            this.comboBoxAgeRange.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAgeRange.Name = "comboBoxAgeRange";
            this.comboBoxAgeRange.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAgeRange.TabIndex = 2;
            this.comboBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgeRange_SelectedIndexChanged);
            // 
            // labelTimeFrame
            // 
            this.labelTimeFrame.AutoSize = true;
            this.labelTimeFrame.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelTimeFrame.Location = new System.Drawing.Point(18, 24);
            this.labelTimeFrame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeFrame.Name = "labelTimeFrame";
            this.labelTimeFrame.Size = new System.Drawing.Size(66, 15);
            this.labelTimeFrame.TabIndex = 4;
            this.labelTimeFrame.Text = "Event Time:";
            // 
            // comboBoxTimeFrame
            // 
            this.comboBoxTimeFrame.FormattingEnabled = true;
            this.comboBoxTimeFrame.Items.AddRange(new object[] {
            "Early Morning ",
            "Morning",
            "Midday",
            "Afternoon",
            "Evening",
            "Night",
            "Midnight",
            "Midnight to Dawn"});
            this.comboBoxTimeFrame.Location = new System.Drawing.Point(146, 24);
            this.comboBoxTimeFrame.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTimeFrame.Name = "comboBoxTimeFrame";
            this.comboBoxTimeFrame.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTimeFrame.TabIndex = 5;
            this.comboBoxTimeFrame.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeFrame_SelectedIndexChanged);
            // 
            // comboBoxSexPreference
            // 
            this.comboBoxSexPreference.FormattingEnabled = true;
            this.comboBoxSexPreference.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxSexPreference.Location = new System.Drawing.Point(146, 98);
            this.comboBoxSexPreference.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSexPreference.Name = "comboBoxSexPreference";
            this.comboBoxSexPreference.Size = new System.Drawing.Size(92, 21);
            this.comboBoxSexPreference.TabIndex = 6;
            this.comboBoxSexPreference.SelectedIndexChanged += new System.EventHandler(this.comboBoxSexPreference_SelectedIndexChanged);
            // 
            // labelSAexPreference
            // 
            this.labelSAexPreference.AutoSize = true;
            this.labelSAexPreference.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelSAexPreference.Location = new System.Drawing.Point(18, 100);
            this.labelSAexPreference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSAexPreference.Name = "labelSAexPreference";
            this.labelSAexPreference.Size = new System.Drawing.Size(92, 15);
            this.labelSAexPreference.TabIndex = 7;
            this.labelSAexPreference.Text = "Sex Preference:";
            // 
            // labelParticipentsReligion
            // 
            this.labelParticipentsReligion.AutoSize = true;
            this.labelParticipentsReligion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelParticipentsReligion.Location = new System.Drawing.Point(18, 132);
            this.labelParticipentsReligion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelParticipentsReligion.Name = "labelParticipentsReligion";
            this.labelParticipentsReligion.Size = new System.Drawing.Size(98, 15);
            this.labelParticipentsReligion.TabIndex = 8;
            this.labelParticipentsReligion.Text = "Friend\'s Religion:";
            // 
            // comboBoxReligion
            // 
            this.comboBoxReligion.FormattingEnabled = true;
            this.comboBoxReligion.Items.AddRange(new object[] {
            "Chrisitianity",
            "Islam",
            "Hinduism",
            "Judaism",
            "Buddhism"});
            this.comboBoxReligion.Location = new System.Drawing.Point(146, 130);
            this.comboBoxReligion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxReligion.Name = "comboBoxReligion";
            this.comboBoxReligion.Size = new System.Drawing.Size(92, 21);
            this.comboBoxReligion.TabIndex = 9;
            this.comboBoxReligion.SelectedIndexChanged += new System.EventHandler(this.comboBoxReligion_SelectedIndexChanged);
            // 
            // labelRequirementsNotice
            // 
            this.labelRequirementsNotice.AutoSize = true;
            this.labelRequirementsNotice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelRequirementsNotice.Location = new System.Drawing.Point(18, 180);
            this.labelRequirementsNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequirementsNotice.Name = "labelRequirementsNotice";
            this.labelRequirementsNotice.Size = new System.Drawing.Size(111, 15);
            this.labelRequirementsNotice.TabIndex = 10;
            this.labelRequirementsNotice.Text = "Event Filter Results: ";
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelEventDescription.Location = new System.Drawing.Point(278, 151);
            this.labelEventDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(103, 15);
            this.labelEventDescription.TabIndex = 11;
            this.labelEventDescription.Text = "Event Description:";
            this.labelEventDescription.Visible = false;
            // 
            // labelDescriptionContent
            // 
            this.labelDescriptionContent.AutoSize = true;
            this.labelDescriptionContent.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.labelDescriptionContent.Location = new System.Drawing.Point(197, 166);
            this.labelDescriptionContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionContent.MaximumSize = new System.Drawing.Size(368, 16);
            this.labelDescriptionContent.Name = "labelDescriptionContent";
            this.labelDescriptionContent.Size = new System.Drawing.Size(279, 16);
            this.labelDescriptionContent.TabIndex = 13;
            this.labelDescriptionContent.Text = "Event Description: Content Will be desplayed here";
            this.labelDescriptionContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescriptionContent.Visible = false;
            // 
            // customPictureBoxButtonFilterEvent
            // 
            this.customPictureBoxButtonFilterEvent.BackColor = System.Drawing.Color.White;
            this.customPictureBoxButtonFilterEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPictureBoxButtonFilterEvent.ImageLocation = "";
            this.customPictureBoxButtonFilterEvent.Location = new System.Drawing.Point(424, 78);
            this.customPictureBoxButtonFilterEvent.m_HoverImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_HoverImage")));
            this.customPictureBoxButtonFilterEvent.m_NormalImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_NormalImage")));
            this.customPictureBoxButtonFilterEvent.Margin = new System.Windows.Forms.Padding(2);
            this.customPictureBoxButtonFilterEvent.Name = "customPictureBoxButtonFilterEvent";
            this.customPictureBoxButtonFilterEvent.Size = new System.Drawing.Size(38, 37);
            this.customPictureBoxButtonFilterEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBoxButtonFilterEvent.TabIndex = 14;
            this.customPictureBoxButtonFilterEvent.TabStop = false;
            this.customPictureBoxButtonFilterEvent.Click += new System.EventHandler(this.customPictureBoxButtonFilterEvent_Click);
            this.customPictureBoxButtonFilterEvent.MouseLeave += new System.EventHandler(this.customPictureBoxButtonFilterEvent_MouseLeave);
            this.customPictureBoxButtonFilterEvent.MouseHover += new System.EventHandler(this.customPictureBoxButtonFilterEvent_MouseHover);
            // 
            // labelGenerate
            // 
            this.labelGenerate.AutoSize = true;
            this.labelGenerate.BackColor = System.Drawing.Color.Transparent;
            this.labelGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGenerate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelGenerate.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelGenerate.Location = new System.Drawing.Point(375, 48);
            this.labelGenerate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerate.Name = "labelGenerate";
            this.labelGenerate.Size = new System.Drawing.Size(142, 17);
            this.labelGenerate.TabIndex = 15;
            this.labelGenerate.Text = "Click to Find Events!";
            // 
            // FormEventByParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 459);
            this.Controls.Add(flowLayoutPanelCutomedEvents);
            this.Controls.Add(this.labelGenerate);
            this.Controls.Add(this.customPictureBoxButtonFilterEvent);
            this.Controls.Add(this.labelDescriptionContent);
            this.Controls.Add(this.labelEventDescription);
            this.Controls.Add(this.labelRequirementsNotice);
            this.Controls.Add(this.comboBoxReligion);
            this.Controls.Add(this.labelParticipentsReligion);
            this.Controls.Add(this.labelSAexPreference);
            this.Controls.Add(this.comboBoxSexPreference);
            this.Controls.Add(this.comboBoxTimeFrame);
            this.Controls.Add(this.labelTimeFrame);
            this.Controls.Add(this.comboBoxAgeRange);
            this.Controls.Add(this.labelAgeRange);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(192, 414);
            this.Name = "FormEventByParameters";
            this.Text = "FormEventByParameters";
            this.Load += new System.EventHandler(this.FormEventByParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButtonFilterEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label labelAgeRange;
          private System.Windows.Forms.ComboBox comboBoxAgeRange;
          private System.Windows.Forms.Label labelTimeFrame;
          private System.Windows.Forms.ComboBox comboBoxTimeFrame;
          private System.Windows.Forms.ComboBox comboBoxSexPreference;
          private System.Windows.Forms.Label labelSAexPreference;
          private System.Windows.Forms.Label labelParticipentsReligion;
          private System.Windows.Forms.ComboBox comboBoxReligion;
          private System.Windows.Forms.Label labelRequirementsNotice;
          private System.Windows.Forms.Label labelEventDescription;
          private System.Windows.Forms.Label labelDescriptionContent;
          private CustomPictureBoxButton customPictureBoxButtonFilterEvent;
          private System.Windows.Forms.Label labelGenerate;
     }
}