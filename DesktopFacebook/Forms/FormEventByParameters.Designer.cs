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
               System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
               this.customPictureBoxButton1 = new DesktopFacebook.CustomPictureBoxButton();
               this.labelDescriptionContent = new System.Windows.Forms.Label();
               this.customPictureBoxButtonFilterEvent = new DesktopFacebook.CustomPictureBoxButton();
               this.labelGenerate = new System.Windows.Forms.Label();
               flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButton1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButtonFilterEvent)).BeginInit();
               this.SuspendLayout();
               // 
               // flowLayoutPanel1
               // 
               flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
               flowLayoutPanel1.Location = new System.Drawing.Point(0, 247);
               flowLayoutPanel1.Name = "flowLayoutPanel1";
               flowLayoutPanel1.Size = new System.Drawing.Size(800, 203);
               flowLayoutPanel1.TabIndex = 0;
               // 
               // labelAgeRange
               // 
               this.labelAgeRange.AutoSize = true;
               this.labelAgeRange.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelAgeRange.Location = new System.Drawing.Point(22, 34);
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
               this.comboBoxAgeRange.Name = "comboBoxAgeRange";
               this.comboBoxAgeRange.Size = new System.Drawing.Size(121, 24);
               this.comboBoxAgeRange.TabIndex = 2;
               this.comboBoxAgeRange.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgeRange_SelectedIndexChanged);
               // 
               // labelTimeFrame
               // 
               this.labelTimeFrame.AutoSize = true;
               this.labelTimeFrame.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelTimeFrame.Location = new System.Drawing.Point(22, 76);
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
               this.comboBoxTimeFrame.Name = "comboBoxTimeFrame";
               this.comboBoxTimeFrame.Size = new System.Drawing.Size(121, 24);
               this.comboBoxTimeFrame.TabIndex = 5;
               // 
               // comboBoxSexPreference
               // 
               this.comboBoxSexPreference.FormattingEnabled = true;
               this.comboBoxSexPreference.Items.AddRange(new object[] {
            "male",
            "female"});
               this.comboBoxSexPreference.Location = new System.Drawing.Point(177, 114);
               this.comboBoxSexPreference.Name = "comboBoxSexPreference";
               this.comboBoxSexPreference.Size = new System.Drawing.Size(121, 24);
               this.comboBoxSexPreference.TabIndex = 6;
               this.comboBoxSexPreference.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
               this.labelParticipentsReligion.Location = new System.Drawing.Point(22, 161);
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
               this.comboBoxReligion.Name = "comboBoxReligion";
               this.comboBoxReligion.Size = new System.Drawing.Size(121, 24);
               this.comboBoxReligion.TabIndex = 9;
               // 
               // labelRequirementsNotice
               // 
               this.labelRequirementsNotice.AutoSize = true;
               this.labelRequirementsNotice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelRequirementsNotice.Location = new System.Drawing.Point(12, 227);
               this.labelRequirementsNotice.Name = "labelRequirementsNotice";
               this.labelRequirementsNotice.Size = new System.Drawing.Size(136, 17);
               this.labelRequirementsNotice.TabIndex = 10;
               this.labelRequirementsNotice.Text = "Event Filter Results: ";
               // 
               // labelEventDescription
               // 
               this.labelEventDescription.AutoSize = true;
               this.labelEventDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
               this.labelEventDescription.Location = new System.Drawing.Point(323, 161);
               this.labelEventDescription.Name = "labelEventDescription";
               this.labelEventDescription.Size = new System.Drawing.Size(127, 17);
               this.labelEventDescription.TabIndex = 11;
               this.labelEventDescription.Text = "Event Description:";
               // 
               // customPictureBoxButton1
               // 
               this.customPictureBoxButton1.Location = new System.Drawing.Point(480, 34);
               this.customPictureBoxButton1.m_HoverImage = null;
               this.customPictureBoxButton1.m_NormalImage = null;
               this.customPictureBoxButton1.Name = "customPictureBoxButton1";
               this.customPictureBoxButton1.Size = new System.Drawing.Size(167, 122);
               this.customPictureBoxButton1.TabIndex = 12;
               this.customPictureBoxButton1.TabStop = false;
               this.customPictureBoxButton1.Click += new System.EventHandler(this.customPictureBoxButton1_Click);
               // 
               // labelDescriptionContent
               // 
               this.labelDescriptionContent.AutoSize = true;
               this.labelDescriptionContent.Font = new System.Drawing.Font("Century Gothic", 8.25F);
               this.labelDescriptionContent.Location = new System.Drawing.Point(205, 181);
               this.labelDescriptionContent.Name = "labelDescriptionContent";
               this.labelDescriptionContent.Size = new System.Drawing.Size(357, 19);
               this.labelDescriptionContent.TabIndex = 13;
               this.labelDescriptionContent.Text = "Event Description: Content Will be desplayed here";
               this.labelDescriptionContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // customPictureBoxButtonFilterEvent
               // 
               this.customPictureBoxButtonFilterEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.BackgroundImage")));
               this.customPictureBoxButtonFilterEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.customPictureBoxButtonFilterEvent.Location = new System.Drawing.Point(362, 88);
               this.customPictureBoxButtonFilterEvent.m_HoverImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_HoverImage")));
               this.customPictureBoxButtonFilterEvent.m_NormalImage = ((System.Drawing.Image)(resources.GetObject("customPictureBoxButtonFilterEvent.m_NormalImage")));
               this.customPictureBoxButtonFilterEvent.Name = "customPictureBoxButtonFilterEvent";
               this.customPictureBoxButtonFilterEvent.Size = new System.Drawing.Size(50, 45);
               this.customPictureBoxButtonFilterEvent.TabIndex = 14;
               this.customPictureBoxButtonFilterEvent.TabStop = false;
               this.customPictureBoxButtonFilterEvent.Click += new System.EventHandler(this.customPictureBoxButtonFilterEvent_Click);
               // 
               // labelGenerate
               // 
               this.labelGenerate.AutoSize = true;
               this.labelGenerate.BackColor = System.Drawing.Color.Transparent;
               this.labelGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.labelGenerate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
               this.labelGenerate.ForeColor = System.Drawing.Color.DarkCyan;
               this.labelGenerate.Location = new System.Drawing.Point(343, 65);
               this.labelGenerate.Name = "labelGenerate";
               this.labelGenerate.Size = new System.Drawing.Size(94, 19);
               this.labelGenerate.TabIndex = 15;
               this.labelGenerate.Text = "press here";
               // 
               // FormEventByParameters
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.labelGenerate);
               this.Controls.Add(this.customPictureBoxButtonFilterEvent);
               this.Controls.Add(this.labelDescriptionContent);
               this.Controls.Add(this.customPictureBoxButton1);
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
               this.Controls.Add(flowLayoutPanel1);
               this.Name = "FormEventByParameters";
               this.Text = "FormEventByParameters";
               ((System.ComponentModel.ISupportInitialize)(this.customPictureBoxButton1)).EndInit();
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
          private CustomPictureBoxButton customPictureBoxButton1;
          private System.Windows.Forms.Label labelDescriptionContent;
          private CustomPictureBoxButton customPictureBoxButtonFilterEvent;
          private System.Windows.Forms.Label labelGenerate;
     }
}