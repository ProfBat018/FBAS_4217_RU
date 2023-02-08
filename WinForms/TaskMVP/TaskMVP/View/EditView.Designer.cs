namespace TaskMVP.View
{
    partial class EditView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.name_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.isImportant_label = new System.Windows.Forms.Label();
            this.datetime_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.important_checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.desc_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.desc_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.isImportant_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.datetime_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Save_button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.name_textBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.important_checkBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(89, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 40);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name";
            // 
            // desc_label
            // 
            this.desc_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(71, 40);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(85, 40);
            this.desc_label.TabIndex = 1;
            this.desc_label.Text = "Description";
            // 
            // isImportant_label
            // 
            this.isImportant_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.isImportant_label.AutoSize = true;
            this.isImportant_label.Location = new System.Drawing.Point(72, 80);
            this.isImportant_label.Name = "isImportant_label";
            this.isImportant_label.Size = new System.Drawing.Size(83, 61);
            this.isImportant_label.TabIndex = 2;
            this.isImportant_label.Text = "Impoertant";
            // 
            // datetime_label
            // 
            this.datetime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.datetime_label.AutoSize = true;
            this.datetime_label.Location = new System.Drawing.Point(93, 141);
            this.datetime_label.Name = "datetime_label";
            this.datetime_label.Size = new System.Drawing.Size(41, 166);
            this.datetime_label.TabIndex = 3;
            this.datetime_label.Text = "Date";
            // 
            // Save_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Save_button, 2);
            this.Save_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_button.Location = new System.Drawing.Point(3, 323);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(449, 124);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(230, 3);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(125, 27);
            this.name_textBox.TabIndex = 5;
            // 
            // desc_textBox
            // 
            this.desc_textBox.Location = new System.Drawing.Point(230, 43);
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.Size = new System.Drawing.Size(125, 27);
            this.desc_textBox.TabIndex = 6;
            // 
            // important_checkBox
            // 
            this.important_checkBox.AutoSize = true;
            this.important_checkBox.Location = new System.Drawing.Point(230, 83);
            this.important_checkBox.Name = "important_checkBox";
            this.important_checkBox.Size = new System.Drawing.Size(101, 24);
            this.important_checkBox.TabIndex = 7;
            this.important_checkBox.Text = "checkBox1";
            this.important_checkBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(230, 144);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 27);
            this.dateTimePicker.TabIndex = 8;
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditView";
            this.Text = "EditView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox desc_textBox;
        private Label name_label;
        private Label desc_label;
        private Label isImportant_label;
        private Label datetime_label;
        private Button Save_button;
        private TextBox name_textBox;
        private CheckBox important_checkBox;
        private DateTimePicker dateTimePicker;
    }
}