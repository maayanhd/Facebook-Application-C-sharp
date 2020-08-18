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
               this.testerlabel = new System.Windows.Forms.Label();
               flowLayoutPanelCutomedEvents = new System.Windows.Forms.FlowLayoutPanel();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButtonFilterEvent)).BeginInit();
               this.SuspendLayout();
               // 
               // flowLayoutPanelCutomedEvents
               // 
               flowLayoutPanelCutomedEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
               flowLayoutPanelCutomedEvents.AutoScroll = true;
               flowLayoutPanelCutomedEvents.AutoSize = true;
               flowLayoutPanelCutomedEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               flowLayoutPanelCutomedEvents.Location = new System.Drawing.Point(1, 260);
               flowLayoutPanelCutomedEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               flowLayoutPanelCutomedEvents.MinimumSize = new System.Drawing.Size(800, 190);
               flowLayoutPanelCutomedEvents.Name = "flowLayoutPanelCutomedEvents";
               flowLayoutPanelCutomedEvents.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
               flowLayoutPanelCutomedEvents.Size = new System.Drawing.Size(800, 190);
               flowLayoutPanelCutomedEvents.TabIndex = 0;
               // 
               // labelAgeRange
               // 
               this.labelAgeRange.AutoSize = true;
               this.labelAgeRange.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelAgeRange.Location = new System.Drawing.Point(21, 34);
               this.labelAgeRange.Name = "labelAgeRange";
               this.labelAgeRange.Size = new System.Drawing.Size(120, 17);
               this.labelAgeRange.TabIndex = 1;
               this.labelAgeRange.Text = "Pick Age Range:";
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
               this.comboBoxAgeRange.Location = new System.Drawing.Point(176, 34);
               this.comboBoxAgeRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboBoxAgeRange.Name = "comboBoxAgeRange";
               this.comboBoxAgeRange.Size = new System.Drawing.Size(121, 24);
               this.comboBoxAgeRange.TabIndex = 2;
               this.comboBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgeRange_SelectedIndexChanged);
               // 
               // labelTimeFrame
               // 
               this.labelTimeFrame.AutoSize = true;
               this.labelTimeFrame.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelTimeFrame.Location = new System.Drawing.Point(21, 76);
               this.labelTimeFrame.Name = "labelTimeFrame";
               this.labelTimeFrame.Size = new System.Drawing.Size(125, 17);
               this.labelTimeFrame.TabIndex = 4;
               this.labelTimeFrame.Text = "Pick Time Frame:";
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
               this.comboBoxTimeFrame.Location = new System.Drawing.Point(176, 76);
               this.comboBoxTimeFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboBoxTimeFrame.Name = "comboBoxTimeFrame";
               this.comboBoxTimeFrame.Size = new System.Drawing.Size(121, 24);
               this.comboBoxTimeFrame.TabIndex = 5;
               this.comboBoxTimeFrame.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeFrame_SelectedIndexChanged);
               // 
               // comboBoxSexPreference
               // 
               this.comboBoxSexPreference.FormattingEnabled = true;
               this.comboBoxSexPreference.Items.AddRange(new object[] {
            "male",
            "female"});
               this.comboBoxSexPreference.Location = new System.Drawing.Point(177, 114);
               this.comboBoxSexPreference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboBoxSexPreference.Name = "comboBoxSexPreference";
               this.comboBoxSexPreference.Size = new System.Drawing.Size(121, 24);
               this.comboBoxSexPreference.TabIndex = 6;
               this.comboBoxSexPreference.SelectedIndexChanged += new System.EventHandler(this.comboBoxSexPreference_SelectedIndexChanged);
               // 
               // labelSAexPreference
               // 
               this.labelSAexPreference.AutoSize = true;
               this.labelSAexPreference.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelSAexPreference.Location = new System.Drawing.Point(17, 116);
               this.labelSAexPreference.Name = "labelSAexPreference";
               this.labelSAexPreference.Size = new System.Drawing.Size(146, 17);
               this.labelSAexPreference.TabIndex = 7;
               this.labelSAexPreference.Text = "Pick Sex Preference:";
               // 
               // labelParticipentsReligion
               // 
               this.labelParticipentsReligion.AutoSize = true;
               this.labelParticipentsReligion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelParticipentsReligion.Location = new System.Drawing.Point(21, 161);
               this.labelParticipentsReligion.Name = "labelParticipentsReligion";
               this.labelParticipentsReligion.Size = new System.Drawing.Size(154, 17);
               this.labelParticipentsReligion.TabIndex = 8;
               this.labelParticipentsReligion.Text = "Pick Friend\'s Religion:";
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
               this.comboBoxReligion.Location = new System.Drawing.Point(177, 154);
               this.comboBoxReligion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.comboBoxReligion.Name = "comboBoxReligion";
               this.comboBoxReligion.Size = new System.Drawing.Size(121, 24);
               this.comboBoxReligion.TabIndex = 9;
               this.comboBoxReligion.SelectedIndexChanged += new System.EventHandler(this.comboBoxReligion_SelectedIndexChanged);
               // 
               // labelRequirementsNotice
               // 
               this.labelRequirementsNotice.Anchor = System.Windows.Forms.AnchorStyles.Left;
               this.labelRequirementsNotice.AutoSize = true;
               this.labelRequirementsNotice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelRequirementsNotice.Location = new System.Drawing.Point(12, 229);
               this.labelRequirementsNotice.Name = "labelRequirementsNotice";
               this.labelRequirementsNotice.Size = new System.Drawing.Size(136, 17);
               this.labelRequirementsNotice.TabIndex = 10;
               this.labelRequirementsNotice.Text = "Event Filter Results: ";
               // 
               // labelEventDescription
               // 
               this.labelEventDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelEventDescription.AutoSize = true;
               this.labelEventDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelEventDescription.Location = new System.Drawing.Point(323, 161);
               this.labelEventDescription.Name = "labelEventDescription";
               this.labelEventDescription.Size = new System.Drawing.Size(127, 17);
               this.labelEventDescription.TabIndex = 11;
               this.labelEventDescription.Text = "Event Description:";
               // 
               // labelDescriptionContent
               // 
               this.labelDescriptionContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelDescriptionContent.AutoSize = true;
               this.labelDescriptionContent.Font = new System.Drawing.Font("Century Gothic", 8.25F);
               this.labelDescriptionContent.Location = new System.Drawing.Point(205, 181);
               this.labelDescriptionContent.MaximumSize = new System.Drawing.Size(490, 20);
               this.labelDescriptionContent.Name = "labelDescriptionContent";
               this.labelDescriptionContent.Size = new System.Drawing.Size(357, 19);
               this.labelDescriptionContent.TabIndex = 13;
               this.labelDescriptionContent.Text = "Event Description: Content Will be desplayed here";
               this.labelDescriptionContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // customPictureBoxButtonFilterEvent
               // 
               this.customPictureBoxButtonFilterEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.customPictureBoxButtonFilterEvent.BackColor = System.Drawing.Color.Transparent;
               this.customPictureBoxButtonFilterEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.customPictureBoxButtonFilterEvent.ImageLocation = "";
               this.customPictureBoxButtonFilterEvent.Location = new System.Drawing.Point(363, 89);
               this.customPictureBoxButtonFilterEvent.m_HoverImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_HoverImage")));
               this.customPictureBoxButtonFilterEvent.m_NormalImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_NormalImage")));
               this.customPictureBoxButtonFilterEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.customPictureBoxButtonFilterEvent.Name = "customPictureBoxButtonFilterEvent";
               this.customPictureBoxButtonFilterEvent.Size = new System.Drawing.Size(51, 46);
               this.customPictureBoxButtonFilterEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.customPictureBoxButtonFilterEvent.TabIndex = 14;
               this.customPictureBoxButtonFilterEvent.TabStop = false;
               this.customPictureBoxButtonFilterEvent.Click += new System.EventHandler(this.customPictureBoxButtonFilterEvent_Click);
               this.customPictureBoxButtonFilterEvent.MouseLeave += new System.EventHandler(this.customPictureBoxButtonFilterEvent_MouseLeave);
               this.customPictureBoxButtonFilterEvent.MouseHover += new System.EventHandler(this.customPictureBoxButtonFilterEvent_MouseHover);
               // 
               // labelGenerate
               // 
               this.labelGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.labelGenerate.AutoSize = true;
               this.labelGenerate.BackColor = System.Drawing.Color.Transparent;
               this.labelGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.labelGenerate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
               this.labelGenerate.ForeColor = System.Drawing.Color.DarkCyan;
               this.labelGenerate.Location = new System.Drawing.Point(303, 58);
               this.labelGenerate.Name = "labelGenerate";
               this.labelGenerate.Size = new System.Drawing.Size(164, 19);
               this.labelGenerate.TabIndex = 15;
               this.labelGenerate.Text = "press down to Filter";
               // 
               // testerlabel
               // 
               this.testerlabel.AutoSize = true;
               this.testerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.testerlabel.Location = new System.Drawing.Point(297, 208);
               this.testerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.testerlabel.Name = "testerlabel";
               this.testerlabel.Size = new System.Drawing.Size(182, 36);
               this.testerlabel.TabIndex = 16;
               this.testerlabel.Text = "TesterLabel";
               // 
               // FormEventByParameters
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(800, 453);
               this.Controls.Add(flowLayoutPanelCutomedEvents);
               this.Controls.Add(this.testerlabel);
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
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.MinimumSize = new System.Drawing.Size(250, 500);
               this.Name = "FormEventByParameters";
               this.Text = "FormEventByParameters";
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
          private System.Windows.Forms.Label testerlabel;
     }
}