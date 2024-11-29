namespace AutoUpdaterDotNET
{
    partial class RemindLaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemindLaterForm));
            labelTitle = new System.Windows.Forms.Label();
            pictureBoxIcon = new System.Windows.Forms.PictureBox();
            labelDescription = new System.Windows.Forms.Label();
            radioButtonYes = new System.Windows.Forms.RadioButton();
            radioButtonNo = new System.Windows.Forms.RadioButton();
            comboBoxRemindLater = new System.Windows.Forms.ComboBox();
            buttonOK = new System.Windows.Forms.Button();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            resources.ApplyResources(labelTitle, "labelTitle");
            tableLayoutPanel.SetColumnSpan(labelTitle, 2);
            labelTitle.Name = "labelTitle";
            // 
            // pictureBoxIcon
            // 
            resources.ApplyResources(pictureBoxIcon, "pictureBoxIcon");
            pictureBoxIcon.Image = Properties.Resources.clock_go_32;
            pictureBoxIcon.Name = "pictureBoxIcon";
            tableLayoutPanel.SetRowSpan(pictureBoxIcon, 2);
            pictureBoxIcon.TabStop = false;
            // 
            // labelDescription
            // 
            resources.ApplyResources(labelDescription, "labelDescription");
            tableLayoutPanel.SetColumnSpan(labelDescription, 2);
            labelDescription.Name = "labelDescription";
            // 
            // radioButtonYes
            // 
            resources.ApplyResources(radioButtonYes, "radioButtonYes");
            radioButtonYes.Checked = true;
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.TabStop = true;
            radioButtonYes.UseVisualStyleBackColor = true;
            radioButtonYes.CheckedChanged += RadioButtonYesCheckedChanged;
            // 
            // radioButtonNo
            // 
            resources.ApplyResources(radioButtonNo, "radioButtonNo");
            tableLayoutPanel.SetColumnSpan(radioButtonNo, 2);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // comboBoxRemindLater
            // 
            resources.ApplyResources(comboBoxRemindLater, "comboBoxRemindLater");
            comboBoxRemindLater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxRemindLater.FormattingEnabled = true;
            comboBoxRemindLater.Items.AddRange(new object[] { resources.GetString("comboBoxRemindLater.Items"), resources.GetString("comboBoxRemindLater.Items1"), resources.GetString("comboBoxRemindLater.Items2"), resources.GetString("comboBoxRemindLater.Items3"), resources.GetString("comboBoxRemindLater.Items4"), resources.GetString("comboBoxRemindLater.Items5"), resources.GetString("comboBoxRemindLater.Items6") });
            comboBoxRemindLater.Name = "comboBoxRemindLater";
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(buttonOK, "buttonOK");
            buttonOK.Image = Properties.Resources.clock_play;
            buttonOK.Name = "buttonOK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += ButtonOkClick;
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(tableLayoutPanel, "tableLayoutPanel");
            tableLayoutPanel.Controls.Add(pictureBoxIcon, 0, 0);
            tableLayoutPanel.Controls.Add(labelTitle, 1, 0);
            tableLayoutPanel.Controls.Add(radioButtonNo, 1, 3);
            tableLayoutPanel.Controls.Add(comboBoxRemindLater, 2, 2);
            tableLayoutPanel.Controls.Add(radioButtonYes, 1, 2);
            tableLayoutPanel.Controls.Add(labelDescription, 1, 1);
            tableLayoutPanel.Controls.Add(buttonOK, 2, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // RemindLaterForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemindLaterForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += RemindLaterFormLoad;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ComboBox comboBoxRemindLater;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}