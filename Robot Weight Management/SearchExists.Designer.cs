namespace FirstFRCParts
{
    partial class SearchExists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchExists));
            this.panel = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Controls.Add(this.imageLabel);
            this.panel.Controls.Add(this.textLabel);
            this.panel.Location = new System.Drawing.Point(-1, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(358, 56);
            this.panel.TabIndex = 7;
            // 
            // textLabel
            // 
            this.textLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textLabel.Location = new System.Drawing.Point(78, 6);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(277, 44);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "The part you are searching for already exists. Would you like to edit the existin" +
    "g part or create a new one?";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(189, 70);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Location = new System.Drawing.Point(270, 70);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // imageLabel
            // 
            this.imageLabel.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel.Image")));
            this.imageLabel.Location = new System.Drawing.Point(10, 6);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(63, 48);
            this.imageLabel.TabIndex = 4;
            // 
            // SearchExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.newButton;
            this.ClientSize = new System.Drawing.Size(357, 99);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchExists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Part or Edit?";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
    }
}