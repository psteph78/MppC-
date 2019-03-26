namespace AgentieDeTurismMpp.view
{
    partial class SearchExcursions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.landmarkField = new System.Windows.Forms.TextBox();
            this.beginTimeInterval = new System.Windows.Forms.TextBox();
            this.endTimeInterval = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.telephoneNrField = new System.Windows.Forms.TextBox();
            this.nrTicketsField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.bookingNotifyBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Landmark:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure between:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "and:";
            // 
            // landmarkField
            // 
            this.landmarkField.Location = new System.Drawing.Point(93, 9);
            this.landmarkField.Name = "landmarkField";
            this.landmarkField.Size = new System.Drawing.Size(100, 22);
            this.landmarkField.TabIndex = 3;
            // 
            // beginTimeInterval
            // 
            this.beginTimeInterval.Location = new System.Drawing.Point(340, 6);
            this.beginTimeInterval.Name = "beginTimeInterval";
            this.beginTimeInterval.Size = new System.Drawing.Size(37, 22);
            this.beginTimeInterval.TabIndex = 4;
            // 
            // endTimeInterval
            // 
            this.endTimeInterval.Location = new System.Drawing.Point(425, 6);
            this.endTimeInterval.Name = "endTimeInterval";
            this.endTimeInterval.Size = new System.Drawing.Size(37, 22);
            this.endTimeInterval.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(499, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchExcursionOnClick);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(1, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(573, 302);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSelectedExcursion);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book excursion for client:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Infromation about client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telephone Number:";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(128, 413);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(100, 22);
            this.lastNameField.TabIndex = 13;
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(128, 435);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(100, 22);
            this.firstNameField.TabIndex = 14;
            // 
            // telephoneNrField
            // 
            this.telephoneNrField.Location = new System.Drawing.Point(128, 458);
            this.telephoneNrField.Name = "telephoneNrField";
            this.telephoneNrField.Size = new System.Drawing.Size(100, 22);
            this.telephoneNrField.TabIndex = 15;
            // 
            // nrTicketsField
            // 
            this.nrTicketsField.Location = new System.Drawing.Point(369, 410);
            this.nrTicketsField.Name = "nrTicketsField";
            this.nrTicketsField.Size = new System.Drawing.Size(50, 22);
            this.nrTicketsField.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nr of tickets:";
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(245, 475);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 18;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookExcursion);
            // 
            // bookingNotifyBox
            // 
            this.bookingNotifyBox.Location = new System.Drawing.Point(1, 504);
            this.bookingNotifyBox.Name = "bookingNotifyBox";
            this.bookingNotifyBox.Size = new System.Drawing.Size(581, 22);
            this.bookingNotifyBox.TabIndex = 19;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(507, 532);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 20;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOut);
            // 
            // SearchExcursions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.bookingNotifyBox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nrTicketsField);
            this.Controls.Add(this.telephoneNrField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endTimeInterval);
            this.Controls.Add(this.beginTimeInterval);
            this.Controls.Add(this.landmarkField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchExcursions";
            this.Text = "searchExcursions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox landmarkField;
        private System.Windows.Forms.TextBox beginTimeInterval;
        private System.Windows.Forms.TextBox endTimeInterval;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox telephoneNrField;
        private System.Windows.Forms.TextBox nrTicketsField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.TextBox bookingNotifyBox;
        private System.Windows.Forms.Button logOutButton;
    }
}