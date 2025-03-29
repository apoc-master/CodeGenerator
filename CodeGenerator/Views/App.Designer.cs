namespace CodeGenerator
{
    partial class App
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MainPanel = new TableLayoutPanel();
            PropertiesPane = new Panel();
            PropertiesGrid = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            PropertyType = new DataGridViewTextBoxColumn();
            PropertiesHeaderPane = new Panel();
            CleanButton = new Button();
            EntityNameText = new TextBox();
            PropertiesLabel = new Label();
            CodePane = new Panel();
            CodeText = new RichTextBox();
            CodeHeaderPane = new Panel();
            CopyButton = new Button();
            CodeLanguageComboBox = new ComboBox();
            CodeLabel = new Label();
            MainPanel.SuspendLayout();
            PropertiesPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PropertiesGrid).BeginInit();
            PropertiesHeaderPane.SuspendLayout();
            CodePane.SuspendLayout();
            CodeHeaderPane.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 2;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainPanel.Controls.Add(PropertiesPane, 0, 0);
            MainPanel.Controls.Add(CodePane, 1, 0);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(2, 3, 2, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 1;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MainPanel.Size = new Size(1030, 557);
            MainPanel.TabIndex = 0;
            // 
            // PropertiesPane
            // 
            PropertiesPane.Controls.Add(PropertiesGrid);
            PropertiesPane.Controls.Add(PropertiesHeaderPane);
            PropertiesPane.Dock = DockStyle.Fill;
            PropertiesPane.Location = new Point(2, 3);
            PropertiesPane.Margin = new Padding(2, 3, 2, 3);
            PropertiesPane.Name = "PropertiesPane";
            PropertiesPane.Size = new Size(511, 551);
            PropertiesPane.TabIndex = 0;
            // 
            // PropertiesGrid
            // 
            PropertiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PropertiesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PropertiesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PropertiesGrid.Columns.AddRange(new DataGridViewColumn[] { PropertyName, PropertyType });
            PropertiesGrid.Dock = DockStyle.Fill;
            PropertiesGrid.Location = new Point(0, 59);
            PropertiesGrid.Margin = new Padding(2, 3, 2, 3);
            PropertiesGrid.Name = "PropertiesGrid";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PropertiesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PropertiesGrid.RowHeadersWidth = 62;
            PropertiesGrid.Size = new Size(511, 492);
            PropertiesGrid.TabIndex = 1;
            // 
            // PropertyName
            // 
            PropertyName.DataPropertyName = "Name";
            PropertyName.HeaderText = "Name";
            PropertyName.MinimumWidth = 8;
            PropertyName.Name = "PropertyName";
            // 
            // PropertyType
            // 
            PropertyType.DataPropertyName = "Kind";
            PropertyType.HeaderText = "Kind";
            PropertyType.MinimumWidth = 8;
            PropertyType.Name = "PropertyType";
            // 
            // PropertiesHeaderPane
            // 
            PropertiesHeaderPane.BackColor = Color.LightSteelBlue;
            PropertiesHeaderPane.Controls.Add(CleanButton);
            PropertiesHeaderPane.Controls.Add(EntityNameText);
            PropertiesHeaderPane.Controls.Add(PropertiesLabel);
            PropertiesHeaderPane.Dock = DockStyle.Top;
            PropertiesHeaderPane.Location = new Point(0, 0);
            PropertiesHeaderPane.Margin = new Padding(2, 3, 2, 3);
            PropertiesHeaderPane.Name = "PropertiesHeaderPane";
            PropertiesHeaderPane.Size = new Size(511, 59);
            PropertiesHeaderPane.TabIndex = 0;
            // 
            // CleanButton
            // 
            CleanButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CleanButton.Font = new Font("Font Awesome 6 Free Regular", 10F);
            CleanButton.Location = new Point(451, 9);
            CleanButton.Margin = new Padding(2, 3, 2, 3);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(48, 33);
            CleanButton.TabIndex = 1;
            CleanButton.Text = "";
            CleanButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CleanButton.UseVisualStyleBackColor = true;
            CleanButton.Click += CleanButton_Click;
            // 
            // EntityNameText
            // 
            EntityNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EntityNameText.Location = new Point(136, 8);
            EntityNameText.Margin = new Padding(2, 3, 2, 3);
            EntityNameText.Name = "EntityNameText";
            EntityNameText.Size = new Size(303, 33);
            EntityNameText.TabIndex = 1;
            EntityNameText.TextChanged += EntityNameText_TextChanged;
            // 
            // PropertiesLabel
            // 
            PropertiesLabel.AutoSize = true;
            PropertiesLabel.Location = new Point(17, 11);
            PropertiesLabel.Margin = new Padding(2, 0, 2, 0);
            PropertiesLabel.Name = "PropertiesLabel";
            PropertiesLabel.Size = new Size(115, 28);
            PropertiesLabel.TabIndex = 0;
            PropertiesLabel.Text = "Entity name";
            // 
            // CodePane
            // 
            CodePane.Controls.Add(CodeText);
            CodePane.Controls.Add(CodeHeaderPane);
            CodePane.Dock = DockStyle.Fill;
            CodePane.Location = new Point(517, 3);
            CodePane.Margin = new Padding(2, 3, 2, 3);
            CodePane.Name = "CodePane";
            CodePane.Size = new Size(511, 551);
            CodePane.TabIndex = 1;
            // 
            // CodeText
            // 
            CodeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CodeText.BorderStyle = BorderStyle.None;
            CodeText.Font = new Font("Courier New", 11F);
            CodeText.Location = new Point(17, 74);
            CodeText.Margin = new Padding(2, 3, 2, 3);
            CodeText.Name = "CodeText";
            CodeText.ReadOnly = true;
            CodeText.Size = new Size(482, 462);
            CodeText.TabIndex = 1;
            CodeText.Text = "";
            // 
            // CodeHeaderPane
            // 
            CodeHeaderPane.BackColor = Color.LightSteelBlue;
            CodeHeaderPane.Controls.Add(CopyButton);
            CodeHeaderPane.Controls.Add(CodeLanguageComboBox);
            CodeHeaderPane.Controls.Add(CodeLabel);
            CodeHeaderPane.Dock = DockStyle.Top;
            CodeHeaderPane.Location = new Point(0, 0);
            CodeHeaderPane.Margin = new Padding(2, 3, 2, 3);
            CodeHeaderPane.Name = "CodeHeaderPane";
            CodeHeaderPane.Size = new Size(511, 59);
            CodeHeaderPane.TabIndex = 0;
            // 
            // CopyButton
            // 
            CopyButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CopyButton.Font = new Font("Font Awesome 6 Free Regular", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CopyButton.Location = new Point(451, 9);
            CopyButton.Margin = new Padding(2, 3, 2, 3);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(48, 36);
            CopyButton.TabIndex = 2;
            CopyButton.Text = "";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // CodeLanguageComboBox
            // 
            CodeLanguageComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CodeLanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CodeLanguageComboBox.FormattingEnabled = true;
            CodeLanguageComboBox.Items.AddRange(new object[] { "C#" });
            CodeLanguageComboBox.Location = new Point(173, 8);
            CodeLanguageComboBox.Margin = new Padding(2, 3, 2, 3);
            CodeLanguageComboBox.Name = "CodeLanguageComboBox";
            CodeLanguageComboBox.Size = new Size(269, 36);
            CodeLanguageComboBox.TabIndex = 1;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Location = new Point(17, 11);
            CodeLabel.Margin = new Padding(2, 0, 2, 0);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(152, 28);
            CodeLabel.TabIndex = 0;
            CodeLabel.Text = "Code generated";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 557);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 3, 2, 3);
            Name = "App";
            Text = "Code Generator";
            Load += App_Load;
            MainPanel.ResumeLayout(false);
            PropertiesPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PropertiesGrid).EndInit();
            PropertiesHeaderPane.ResumeLayout(false);
            PropertiesHeaderPane.PerformLayout();
            CodePane.ResumeLayout(false);
            CodeHeaderPane.ResumeLayout(false);
            CodeHeaderPane.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainPanel;
        private Panel PropertiesPane;
        private Panel CodePane;
        private Panel CodeHeaderPane;
        private ComboBox CodeLanguageComboBox;
        private Label CodeLabel;
        private Button CopyButton;
        private Panel PropertiesHeaderPane;
        private Label PropertiesLabel;
        private Button CleanButton;
        private TextBox EntityNameText;
        private DataGridView PropertiesGrid;
        private RichTextBox CodeText;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn PropertyType;
    }
}