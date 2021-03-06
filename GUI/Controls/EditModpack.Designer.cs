namespace CKAN
{
    partial class EditModpack
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(EditModpack));
            this.ToolTip = new System.Windows.Forms.ToolTip();
            this.TopEditPanel = new System.Windows.Forms.Panel();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.IdentifierTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AbstractLabel = new System.Windows.Forms.Label();
            this.AbstractTextBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.KspVersionLabel = new System.Windows.Forms.Label();
            this.KspVersionMinComboBox = new System.Windows.Forms.ComboBox();
            this.KspVersionMaxComboBox = new System.Windows.Forms.ComboBox();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.LicenseComboBox = new System.Windows.Forms.ComboBox();
            this.IncludeVersionsCheckbox = new System.Windows.Forms.CheckBox();
            this.RelationshipsListView = new ThemedListView();
            this.ModNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModVersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModAbstractColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DependsGroup = new System.Windows.Forms.ListViewGroup();
            this.RecommendationsGroup = new System.Windows.Forms.ListViewGroup();
            this.SuggestionsGroup = new System.Windows.Forms.ListViewGroup();
            this.IgnoredGroup = new System.Windows.Forms.ListViewGroup();
            this.BottomButtonPanel = new System.Windows.Forms.Panel();
            this.DependsRadioButton = new System.Windows.Forms.RadioButton();
            this.RecommendsRadioButton = new System.Windows.Forms.RadioButton();
            this.SuggestsRadioButton = new System.Windows.Forms.RadioButton();
            this.IgnoreRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelExportButton = new System.Windows.Forms.Button();
            this.ExportModpackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 10000;
            this.ToolTip.InitialDelay = 250;
            this.ToolTip.ReshowDelay = 250;
            this.ToolTip.ShowAlways = true;
            // 
            // TopEditPanel
            // 
            this.TopEditPanel.Controls.Add(this.IdentifierLabel);
            this.TopEditPanel.Controls.Add(this.IdentifierTextBox);
            this.TopEditPanel.Controls.Add(this.NameLabel);
            this.TopEditPanel.Controls.Add(this.NameTextBox);
            this.TopEditPanel.Controls.Add(this.AbstractLabel);
            this.TopEditPanel.Controls.Add(this.AbstractTextBox);
            this.TopEditPanel.Controls.Add(this.VersionLabel);
            this.TopEditPanel.Controls.Add(this.VersionTextBox);
            this.TopEditPanel.Controls.Add(this.KspVersionLabel);
            this.TopEditPanel.Controls.Add(this.KspVersionMinComboBox);
            this.TopEditPanel.Controls.Add(this.KspVersionMaxComboBox);
            this.TopEditPanel.Controls.Add(this.LicenseLabel);
            this.TopEditPanel.Controls.Add(this.LicenseComboBox);
            this.TopEditPanel.Controls.Add(this.IncludeVersionsCheckbox);
            this.TopEditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopEditPanel.Name = "TopEditPanel";
            this.TopEditPanel.Size = new System.Drawing.Size(500, 130);
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.IdentifierLabel.Location = new System.Drawing.Point(10, 10);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(75, 23);
            this.IdentifierLabel.TabIndex = 0;
            resources.ApplyResources(this.IdentifierLabel, "IdentifierLabel");
            // 
            // IdentifierTextBox
            // 
            this.IdentifierTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.IdentifierTextBox.Location = new System.Drawing.Point(125, 10);
            this.IdentifierTextBox.Name = "IdentifierTextBox";
            this.IdentifierTextBox.Size = new System.Drawing.Size(250, 23);
            this.IdentifierTextBox.TabIndex = 1;
            resources.ApplyResources(this.IdentifierTextBox, "IdentifierTextBox");
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.NameLabel.Location = new System.Drawing.Point(10, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 23);
            this.NameLabel.TabIndex = 2;
            resources.ApplyResources(this.NameLabel, "NameLabel");
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.NameTextBox.Location = new System.Drawing.Point(125, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 23);
            this.NameTextBox.TabIndex = 3;
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            // 
            // AbstractLabel
            // 
            this.AbstractLabel.AutoSize = true;
            this.AbstractLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.AbstractLabel.Location = new System.Drawing.Point(10, 70);
            this.AbstractLabel.Name = "AbstractLabel";
            this.AbstractLabel.Size = new System.Drawing.Size(75, 23);
            this.AbstractLabel.TabIndex = 4;
            resources.ApplyResources(this.AbstractLabel, "AbstractLabel");
            // 
            // AbstractTextBox
            // 
            this.AbstractTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.AbstractTextBox.Location = new System.Drawing.Point(125, 70);
            this.AbstractTextBox.Multiline = true;
            this.AbstractTextBox.Name = "AbstractTextBox";
            this.AbstractTextBox.Size = new System.Drawing.Size(250, 50);
            this.AbstractTextBox.TabIndex = 5;
            resources.ApplyResources(this.AbstractTextBox, "AbstractTextBox");
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.VersionLabel.Location = new System.Drawing.Point(400, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(75, 23);
            this.VersionLabel.TabIndex = 6;
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.VersionTextBox.Location = new System.Drawing.Point(515, 10);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(250, 23);
            this.VersionTextBox.TabIndex = 7;
            resources.ApplyResources(this.VersionTextBox, "VersionTextBox");
            // 
            // KspVersionLabel
            // 
            this.KspVersionLabel.AutoSize = true;
            this.KspVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.KspVersionLabel.Location = new System.Drawing.Point(400, 40);
            this.KspVersionLabel.Name = "KspVersionLabel";
            this.KspVersionLabel.Size = new System.Drawing.Size(75, 23);
            this.KspVersionLabel.TabIndex = 8;
            resources.ApplyResources(this.KspVersionLabel, "KspVersionLabel");
            // 
            // KspVersionMinComboBox
            // 
            this.KspVersionMinComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.KspVersionMinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KspVersionMinComboBox.Location = new System.Drawing.Point(515, 40);
            this.KspVersionMinComboBox.Name = "KspVersionMinComboBox";
            this.KspVersionMinComboBox.Size = new System.Drawing.Size(70, 23);
            this.KspVersionMinComboBox.TabIndex = 9;
            resources.ApplyResources(this.KspVersionMinComboBox, "KspVersionMinComboBox");
            // 
            // KspVersionMaxComboBox
            // 
            this.KspVersionMaxComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.KspVersionMaxComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KspVersionMaxComboBox.Location = new System.Drawing.Point(595, 40);
            this.KspVersionMaxComboBox.Name = "KspVersionMaxComboBox";
            this.KspVersionMaxComboBox.Size = new System.Drawing.Size(70, 23);
            this.KspVersionMaxComboBox.TabIndex = 10;
            resources.ApplyResources(this.KspVersionMaxComboBox, "KspVersionMaxComboBox");
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.LicenseLabel.Location = new System.Drawing.Point(400, 70);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(75, 23);
            this.LicenseLabel.TabIndex = 11;
            resources.ApplyResources(this.LicenseLabel, "LicenseLabel");
            // 
            // LicenseComboBox
            // 
            this.LicenseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.LicenseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LicenseComboBox.Location = new System.Drawing.Point(515, 70);
            this.LicenseComboBox.Name = "LicenseComboBox";
            this.LicenseComboBox.Size = new System.Drawing.Size(150, 23);
            this.LicenseComboBox.TabIndex = 12;
            resources.ApplyResources(this.LicenseComboBox, "LicenseComboBox");
            //
            // IncludeVersionsCheckbox
            //
            this.IncludeVersionsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.IncludeVersionsCheckbox.AutoSize = true;
            this.IncludeVersionsCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncludeVersionsCheckbox.Location = new System.Drawing.Point(515, 100);
            this.IncludeVersionsCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IncludeVersionsCheckbox.Name = "IncludeVersionsCheckbox";
            this.IncludeVersionsCheckbox.Size = new System.Drawing.Size(131, 24);
            this.IncludeVersionsCheckbox.TabIndex = 13;
            resources.ApplyResources(this.IncludeVersionsCheckbox, "IncludeVersionsCheckbox");
            //
            // RelationshipsListView
            //
            this.RelationshipsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RelationshipsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RelationshipsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ModNameColumn,
            this.ModVersionColumn,
            this.ModAbstractColumn});
            this.RelationshipsListView.FullRowSelect = true;
            this.RelationshipsListView.HideSelection = false;
            this.RelationshipsListView.Location = new System.Drawing.Point(9, 45);
            this.RelationshipsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RelationshipsListView.Name = "RelationshipsListView";
            this.RelationshipsListView.Size = new System.Drawing.Size(1510, 841);
            this.RelationshipsListView.TabIndex = 14;
            this.RelationshipsListView.UseCompatibleStateImageBehavior = false;
            this.RelationshipsListView.View = System.Windows.Forms.View.Details;
            this.RelationshipsListView.Groups.Add(this.DependsGroup);
            this.RelationshipsListView.Groups.Add(this.RecommendationsGroup);
            this.RelationshipsListView.Groups.Add(this.SuggestionsGroup);
            this.RelationshipsListView.Groups.Add(this.IgnoredGroup);
            this.RelationshipsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(RelationshipsListView_ItemSelectionChanged);
            // 
            // ModNameColumn
            // 
            this.ModNameColumn.Width = 332;
            resources.ApplyResources(this.ModNameColumn, "ModNameColumn");
            // 
            // ModVersionColumn
            // 
            this.ModVersionColumn.Width = 180;
            resources.ApplyResources(this.ModVersionColumn, "ModVersionColumn");
            // 
            // ModAbstractColumn
            // 
            this.ModAbstractColumn.Width = 500;
            resources.ApplyResources(this.ModAbstractColumn, "ModAbstractColumn");
            // 
            // DependsGroup
            // 
            this.DependsGroup.Name = "DependsGroup";
            this.DependsGroup.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            resources.ApplyResources(this.DependsGroup, "DependsGroup");
            // 
            // RecommendationsGroup
            // 
            this.RecommendationsGroup.Name = "RecommendationsGroup";
            this.RecommendationsGroup.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            resources.ApplyResources(this.RecommendationsGroup, "RecommendationsGroup");
            // 
            // SuggestionsGroup
            // 
            this.SuggestionsGroup.Name = "SuggestionsGroup";
            this.SuggestionsGroup.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            resources.ApplyResources(this.SuggestionsGroup, "SuggestionsGroup");
            // 
            // IgnoredGroup
            // 
            this.IgnoredGroup.Name = "IgnoredGroup";
            this.IgnoredGroup.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            resources.ApplyResources(this.IgnoredGroup, "IgnoredGroup");
            // 
            // BottomButtonPanel
            // 
            this.BottomButtonPanel.Controls.Add(this.DependsRadioButton);
            this.BottomButtonPanel.Controls.Add(this.RecommendsRadioButton);
            this.BottomButtonPanel.Controls.Add(this.SuggestsRadioButton);
            this.BottomButtonPanel.Controls.Add(this.IgnoreRadioButton);
            this.BottomButtonPanel.Controls.Add(this.CancelExportButton);
            this.BottomButtonPanel.Controls.Add(this.ExportModpackButton);
            this.BottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomButtonPanel.Name = "BottomButtonPanel";
            this.BottomButtonPanel.Size = new System.Drawing.Size(500, 40);
            // 
            // DependsRadioButton
            // 
            this.DependsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.DependsRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.DependsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DependsRadioButton.Location = new System.Drawing.Point(5, 5);
            this.DependsRadioButton.Name = "DependsRadioButton";
            this.DependsRadioButton.Size = new System.Drawing.Size(112, 30);
            this.DependsRadioButton.TabIndex = 16;
            this.DependsRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DependsRadioButton.Click += new System.EventHandler(this.DependsRadioButton_CheckedChanged);
            resources.ApplyResources(this.DependsRadioButton, "DependsRadioButton");
            // 
            // RecommendsRadioButton
            // 
            this.RecommendsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.RecommendsRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.RecommendsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecommendsRadioButton.Location = new System.Drawing.Point(116, 5);
            this.RecommendsRadioButton.Name = "RecommendsRadioButton";
            this.RecommendsRadioButton.Size = new System.Drawing.Size(112, 30);
            this.RecommendsRadioButton.TabIndex = 17;
            this.RecommendsRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecommendsRadioButton.Click += new System.EventHandler(this.RecommendsRadioButton_CheckedChanged);
            resources.ApplyResources(this.RecommendsRadioButton, "RecommendsRadioButton");
            // 
            // SuggestsRadioButton
            // 
            this.SuggestsRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.SuggestsRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SuggestsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuggestsRadioButton.Location = new System.Drawing.Point(227, 5);
            this.SuggestsRadioButton.Name = "SuggestsRadioButton";
            this.SuggestsRadioButton.Size = new System.Drawing.Size(112, 30);
            this.SuggestsRadioButton.TabIndex = 18;
            this.SuggestsRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuggestsRadioButton.Click += new System.EventHandler(this.SuggestsRadioButton_CheckedChanged);
            resources.ApplyResources(this.SuggestsRadioButton, "SuggestsRadioButton");
            // 
            // IgnoreRadioButton
            // 
            this.IgnoreRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Left));
            this.IgnoreRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.IgnoreRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IgnoreRadioButton.Location = new System.Drawing.Point(338, 5);
            this.IgnoreRadioButton.Name = "IgnoreRadioButton";
            this.IgnoreRadioButton.Size = new System.Drawing.Size(112, 30);
            this.IgnoreRadioButton.TabIndex = 19;
            this.IgnoreRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IgnoreRadioButton.Click += new System.EventHandler(this.IgnoreRadioButton_CheckedChanged);
            resources.ApplyResources(this.IgnoreRadioButton, "IgnoreRadioButton");
            // 
            // CancelExportButton
            // 
            this.CancelExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Right));
            this.CancelExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelExportButton.Location = new System.Drawing.Point(266, 5);
            this.CancelExportButton.Name = "CancelExportButton";
            this.CancelExportButton.Size = new System.Drawing.Size(112, 30);
            this.CancelExportButton.TabIndex = 20;
            this.CancelExportButton.UseVisualStyleBackColor = true;
            this.CancelExportButton.Click += new System.EventHandler(this.CancelExportButton_Click);
            resources.ApplyResources(this.CancelExportButton, "CancelExportButton");
            // 
            // ExportModpackButton
            // 
            this.ExportModpackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Right));
            this.ExportModpackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportModpackButton.Location = new System.Drawing.Point(383, 5);
            this.ExportModpackButton.Name = "ExportModpackButton";
            this.ExportModpackButton.Size = new System.Drawing.Size(112, 30);
            this.ExportModpackButton.TabIndex = 22;
            this.ExportModpackButton.UseVisualStyleBackColor = true;
            this.ExportModpackButton.Click += new System.EventHandler(this.ExportModpackButton_Click);
            resources.ApplyResources(this.ExportModpackButton, "ExportModpackButton");
            // 
            // EditModpack
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RelationshipsListView);
            this.Controls.Add(this.TopEditPanel);
            this.Controls.Add(this.BottomButtonPanel);
            this.Margin = new System.Windows.Forms.Padding(0,0,0,0);
            this.Padding = new System.Windows.Forms.Padding(0,0,0,0);
            this.Name = "EditModpack";
            this.Size = new System.Drawing.Size(500, 500);
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel TopEditPanel;
        private System.Windows.Forms.Label IdentifierLabel;
        private System.Windows.Forms.TextBox IdentifierTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AbstractLabel;
        private System.Windows.Forms.TextBox AbstractTextBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.Label KspVersionLabel;
        private System.Windows.Forms.ComboBox KspVersionMinComboBox;
        private System.Windows.Forms.ComboBox KspVersionMaxComboBox;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.ComboBox LicenseComboBox;
        private System.Windows.Forms.CheckBox IncludeVersionsCheckbox;
        private System.Windows.Forms.ListView RelationshipsListView;
        private System.Windows.Forms.ColumnHeader ModNameColumn;
        private System.Windows.Forms.ColumnHeader ModVersionColumn;
        private System.Windows.Forms.ColumnHeader ModAbstractColumn;
        private System.Windows.Forms.ListViewGroup DependsGroup;
        private System.Windows.Forms.ListViewGroup RecommendationsGroup;
        private System.Windows.Forms.ListViewGroup SuggestionsGroup;
        private System.Windows.Forms.ListViewGroup IgnoredGroup;
        private System.Windows.Forms.Panel BottomButtonPanel;
        private System.Windows.Forms.RadioButton DependsRadioButton;
        private System.Windows.Forms.RadioButton RecommendsRadioButton;
        private System.Windows.Forms.RadioButton SuggestsRadioButton;
        private System.Windows.Forms.RadioButton IgnoreRadioButton;
        private System.Windows.Forms.Button CancelExportButton;
        private System.Windows.Forms.Button ExportModpackButton;
    }
}
