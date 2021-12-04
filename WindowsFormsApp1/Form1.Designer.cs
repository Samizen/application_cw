
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkboxIsGroup = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelNoOfPeople = new System.Windows.Forms.Label();
            this.labelEntryTime = new System.Windows.Forms.Label();
            this.dateTimePickerEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelExitTime = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelUnder12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelAbove12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelsearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 1;
            // 
            // checkboxIsGroup
            // 
            this.checkboxIsGroup.AutoSize = true;
            this.checkboxIsGroup.Location = new System.Drawing.Point(345, 106);
            this.checkboxIsGroup.Name = "checkboxIsGroup";
            this.checkboxIsGroup.Size = new System.Drawing.Size(92, 21);
            this.checkboxIsGroup.TabIndex = 2;
            this.checkboxIsGroup.Text = "Is Group?";
            this.checkboxIsGroup.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 22);
            this.textBox2.TabIndex = 4;
            // 
            // labelNoOfPeople
            // 
            this.labelNoOfPeople.AutoSize = true;
            this.labelNoOfPeople.Location = new System.Drawing.Point(287, 143);
            this.labelNoOfPeople.Name = "labelNoOfPeople";
            this.labelNoOfPeople.Size = new System.Drawing.Size(92, 17);
            this.labelNoOfPeople.TabIndex = 3;
            this.labelNoOfPeople.Text = "Total People:";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 8;
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
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBox4);
            this.groupBox.Controls.Add(this.labelAbove12);
            this.groupBox.Controls.Add(this.textBox3);
            this.groupBox.Controls.Add(this.labelUnder12);
            this.groupBox.Location = new System.Drawing.Point(60, 271);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(392, 78);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "For Group";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 11;
            // 
            // labelUnder12
            // 
            this.labelUnder12.AutoSize = true;
            this.labelUnder12.Location = new System.Drawing.Point(14, 35);
            this.labelUnder12.Name = "labelUnder12";
            this.labelUnder12.Size = new System.Drawing.Size(115, 17);
            this.labelUnder12.TabIndex = 10;
            this.labelUnder12.Text = "People Under 12";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(319, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 13;
            // 
            // labelAbove12
            // 
            this.labelAbove12.AutoSize = true;
            this.labelAbove12.Location = new System.Drawing.Point(198, 35);
            this.labelAbove12.Name = "labelAbove12";
            this.labelAbove12.Size = new System.Drawing.Size(116, 17);
            this.labelAbove12.TabIndex = 12;
            this.labelAbove12.Text = "People Above 12";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 22);
            this.textBox5.TabIndex = 11;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 152);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(365, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(261, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Location = new System.Drawing.Point(306, 30);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(53, 17);
            this.labelsearch.TabIndex = 16;
            this.labelsearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(156, 380);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(221, 377);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 657);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelExitTime);
            this.Controls.Add(this.dateTimePickerEntryTime);
            this.Controls.Add(this.labelEntryTime);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelNoOfPeople);
            this.Controls.Add(this.checkboxIsGroup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTicketId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTicketId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkboxIsGroup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelNoOfPeople;
        private System.Windows.Forms.Label labelEntryTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelExitTime;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAbove12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelUnder12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}

