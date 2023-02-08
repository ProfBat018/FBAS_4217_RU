namespace TaskMVP
{
    partial class TodoView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.isImportant_checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.task_listBox = new System.Windows.Forms.ListBox();
            this.leftPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.tableLayoutPanel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(533, 639);
            this.leftPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.09381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.90619F));
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.desc_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.isImportant_checkBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.add_button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.name_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.desc_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.delete_button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.edit_button, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 639);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.SystemColors.Control;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(61, 66);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(145, 37);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Task name:";
            // 
            // desc_label
            // 
            this.desc_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc_label.Location = new System.Drawing.Point(54, 240);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(158, 37);
            this.desc_label.TabIndex = 1;
            this.desc_label.Text = "Description:";
            // 
            // isImportant_checkBox
            // 
            this.isImportant_checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isImportant_checkBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isImportant_checkBox, 2);
            this.isImportant_checkBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isImportant_checkBox.Location = new System.Drawing.Point(188, 359);
            this.isImportant_checkBox.Name = "isImportant_checkBox";
            this.isImportant_checkBox.Size = new System.Drawing.Size(157, 41);
            this.isImportant_checkBox.TabIndex = 2;
            this.isImportant_checkBox.Text = "Important";
            this.isImportant_checkBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker1, 2);
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 414);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 10, 5, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(527, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(3, 510);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(261, 57);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_textBox.Location = new System.Drawing.Point(270, 71);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(260, 27);
            this.name_textBox.TabIndex = 5;
            // 
            // desc_textBox
            // 
            this.desc_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.desc_textBox.Location = new System.Drawing.Point(270, 245);
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(260, 27);
            this.desc_textBox.TabIndex = 6;
            // 
            // delete_button
            // 
            this.delete_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_button.Location = new System.Drawing.Point(270, 510);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(260, 57);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.edit_button, 2);
            this.edit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_button.Location = new System.Drawing.Point(3, 581);
            this.edit_button.Name = "edit_button";
            this.edit_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edit_button.Size = new System.Drawing.Size(527, 55);
            this.edit_button.TabIndex = 8;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.task_listBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(533, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(587, 639);
            this.rightPanel.TabIndex = 1;
            // 
            // task_listBox
            // 
            this.task_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task_listBox.FormattingEnabled = true;
            this.task_listBox.ItemHeight = 20;
            this.task_listBox.Location = new System.Drawing.Point(0, 0);
            this.task_listBox.Name = "task_listBox";
            this.task_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.task_listBox.Size = new System.Drawing.Size(587, 639);
            this.task_listBox.TabIndex = 0;
            // 
            // TodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 639);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "TodoView";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel rightPanel;
        private Label name_label;
        private Label desc_label;
        private CheckBox isImportant_checkBox;
        private DateTimePicker dateTimePicker1;
        private Button add_button;
        private TextBox name_textBox;
        private TextBox desc_textBox;
        private ListBox task_listBox;
        private Button delete_button;
        private Button edit_button;
    }
}