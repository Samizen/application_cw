
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelTicketId = new System.Windows.Forms.Label();
            this.textBoxTicketId = new System.Windows.Forms.TextBox();
            this.checkboxIsGroup = new System.Windows.Forms.CheckBox();
            this.labelEntryTime = new System.Windows.Forms.Label();
            this.dateTimePickerEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExitTime = new System.Windows.Forms.DateTimePicker();
            this.labelExitTime = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.visitorDetailTable = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroupOf = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.visitorDetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTicketId
            // 
            this.labelTicketId.AutoSize = true;
            this.labelTicketId.Location = new System.Drawing.Point(68, 108);
            this.labelTicketId.Name = "labelTicketId";
            this.labelTicketId.Size = new System.Drawing.Size(67, 17);
            this.labelTicketId.TabIndex = 0;
            this.labelTicketId.Text = "Ticket ID:";
            // 
            // textBoxTicketId
            // 
            this.textBoxTicketId.Location = new System.Drawing.Point(141, 105);
            this.textBoxTicketId.Name = "textBoxTicketId";
            this.textBoxTicketId.Size = new System.Drawing.Size(162, 22);
            this.textBoxTicketId.TabIndex = 1;
            // 
            // checkboxIsGroup
            // 
            this.checkboxIsGroup.AutoSize = true;
            this.checkboxIsGroup.Location = new System.Drawing.Point(509, 108);
            this.checkboxIsGroup.Name = "checkboxIsGroup";
            this.checkboxIsGroup.Size = new System.Drawing.Size(92, 21);
            this.checkboxIsGroup.TabIndex = 2;
            this.checkboxIsGroup.Text = "Is Group?";
            this.checkboxIsGroup.UseVisualStyleBackColor = true;
            // 
            // labelEntryTime
            // 
            this.labelEntryTime.AutoSize = true;
            this.labelEntryTime.Location = new System.Drawing.Point(69, 187);
            this.labelEntryTime.Name = "labelEntryTime";
            this.labelEntryTime.Size = new System.Drawing.Size(76, 17);
            this.labelEntryTime.TabIndex = 5;
            this.labelEntryTime.Text = "Entry Time";
            // 
            // dateTimePickerEntryTime
            // 
            this.dateTimePickerEntryTime.Location = new System.Drawing.Point(174, 181);
            this.dateTimePickerEntryTime.Name = "dateTimePickerEntryTime";
            this.dateTimePickerEntryTime.Size = new System.Drawing.Size(256, 22);
            this.dateTimePickerEntryTime.TabIndex = 6;
            // 
            // dateTimePickerExitTime
            // 
            this.dateTimePickerExitTime.Location = new System.Drawing.Point(174, 221);
            this.dateTimePickerExitTime.Name = "dateTimePickerExitTime";
            this.dateTimePickerExitTime.Size = new System.Drawing.Size(256, 22);
            this.dateTimePickerExitTime.TabIndex = 8;
            // 
            // labelExitTime
            // 
            this.labelExitTime.AutoSize = true;
            this.labelExitTime.Location = new System.Drawing.Point(71, 226);
            this.labelExitTime.Name = "labelExitTime";
            this.labelExitTime.Size = new System.Drawing.Size(65, 17);
            this.labelExitTime.TabIndex = 7;
            this.labelExitTime.Text = "Exit Time";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 141);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 22);
            this.textBoxName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(69, 144);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name:";
            // 
            // visitorDetailTable
            // 
            this.visitorDetailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorDetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.visitorDetailTable.Location = new System.Drawing.Point(74, 358);
            this.visitorDetailTable.Name = "visitorDetailTable";
            this.visitorDetailTable.RowHeadersWidth = 51;
            this.visitorDetailTable.RowTemplate.Height = 24;
            this.visitorDetailTable.Size = new System.Drawing.Size(806, 152);
            this.visitorDetailTable.TabIndex = 12;
            this.visitorDetailTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(780, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(477, 536);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(721, 34);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(53, 17);
            this.labelsearch.TabIndex = 16;
            this.labelsearch.Text = "Search";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(299, 316);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(355, 313);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 19;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(509, 306);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(121, 36);
            this.btnShowData.TabIndex = 20;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ticket ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "No. of Person";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = ">12";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "<12";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxGroup.Location = new System.Drawing.Point(786, 106);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGroup.TabIndex = 21;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // labelGroupOf
            // 
            this.labelGroupOf.AutoSize = true;
            this.labelGroupOf.Location = new System.Drawing.Point(709, 110);
            this.labelGroupOf.Name = "labelGroupOf";
            this.labelGroupOf.Size = new System.Drawing.Size(71, 17);
            this.labelGroupOf.TabIndex = 22;
            this.labelGroupOf.Text = "Group Of:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(509, 158);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(561, 155);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(83, 22);
            this.textBoxAge.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 590);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelGroupOf);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.visitorDetailTable);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePickerExitTime);
            this.Controls.Add(this.labelExitTime);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Controls.Add(this.labelEntryTime);
            this.Controls.Add(this.checkboxIsGroup);
            this.Controls.Add(this.textBoxTicketId);
            this.Controls.Add(this.labelTicketId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.visitorDetailTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicketId;
        private System.Windows.Forms.TextBox textBoxTicketId;
        private System.Windows.Forms.CheckBox checkboxIsGroup;
        private System.Windows.Forms.Label labelEntryTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerExitTime;
        private System.Windows.Forms.Label labelExitTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView visitorDetailTable;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelGroupOf;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}

