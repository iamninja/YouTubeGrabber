namespace YouTubeGrabber
{
    partial class MainForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.downloadUrlButton = new System.Windows.Forms.Button();
            this.infoContainer = new System.Windows.Forms.SplitContainer();
            this.thumbnailBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.progressBarInfo = new System.Windows.Forms.ProgressBar();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoContainer)).BeginInit();
            this.infoContainer.Panel1.SuspendLayout();
            this.infoContainer.Panel2.SuspendLayout();
            this.infoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.Controls.Add(this.urlTextBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.downloadUrlButton, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.infoContainer, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(590, 288);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlTextBox.Location = new System.Drawing.Point(3, 3);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(407, 20);
            this.urlTextBox.TabIndex = 0;
            // 
            // downloadUrlButton
            // 
            this.downloadUrlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadUrlButton.Location = new System.Drawing.Point(416, 3);
            this.downloadUrlButton.Name = "downloadUrlButton";
            this.downloadUrlButton.Size = new System.Drawing.Size(171, 22);
            this.downloadUrlButton.TabIndex = 1;
            this.downloadUrlButton.Text = "Download";
            this.downloadUrlButton.UseVisualStyleBackColor = true;
            this.downloadUrlButton.Click += new System.EventHandler(this.downloadUrlButton_ClickAsync);
            // 
            // infoContainer
            // 
            this.infoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoContainer.Location = new System.Drawing.Point(3, 203);
            this.infoContainer.Name = "infoContainer";
            // 
            // infoContainer.Panel1
            // 
            this.infoContainer.Panel1.Controls.Add(this.thumbnailBox);
            // 
            // infoContainer.Panel2
            // 
            this.infoContainer.Panel2.Controls.Add(this.progressBarInfo);
            this.infoContainer.Panel2.Controls.Add(this.durationLabel);
            this.infoContainer.Panel2.Controls.Add(this.nameLabel);
            this.infoContainer.Size = new System.Drawing.Size(407, 82);
            this.infoContainer.SplitterDistance = 135;
            this.infoContainer.TabIndex = 2;
            // 
            // thumbnailBox
            // 
            this.thumbnailBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thumbnailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailBox.Location = new System.Drawing.Point(0, 0);
            this.thumbnailBox.Name = "thumbnailBox";
            this.thumbnailBox.Size = new System.Drawing.Size(135, 82);
            this.thumbnailBox.TabIndex = 0;
            this.thumbnailBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 0;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(4, 26);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 13);
            this.durationLabel.TabIndex = 1;
            // 
            // progressBarInfo
            // 
            this.progressBarInfo.Location = new System.Drawing.Point(2, 56);
            this.progressBarInfo.Name = "progressBarInfo";
            this.progressBarInfo.Size = new System.Drawing.Size(263, 23);
            this.progressBarInfo.TabIndex = 2;
            this.progressBarInfo.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 288);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "YouTube Grabber";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.infoContainer.Panel1.ResumeLayout(false);
            this.infoContainer.Panel2.ResumeLayout(false);
            this.infoContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoContainer)).EndInit();
            this.infoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button downloadUrlButton;
        private System.Windows.Forms.SplitContainer infoContainer;
        private System.Windows.Forms.PictureBox thumbnailBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ProgressBar progressBarInfo;
    }
}

