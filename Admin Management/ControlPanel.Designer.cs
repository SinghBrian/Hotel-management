namespace Admin_Management
{
    partial class ControlPanel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.textBoxChild = new System.Windows.Forms.TextBox();
            this.textBoxAdults = new System.Windows.Forms.TextBox();
            this.comboBoxChamber = new System.Windows.Forms.ComboBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.Cname = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.PostReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Services :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chamber :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adults :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Child :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hotel :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Check Out :";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Items.AddRange(new object[] {
            "Thevy",
            "Unana",
            "Devialet"});
            this.comboBoxHotel.Location = new System.Drawing.Point(156, 145);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(151, 31);
            this.comboBoxHotel.TabIndex = 8;
            // 
            // textBoxChild
            // 
            this.textBoxChild.Location = new System.Drawing.Point(156, 187);
            this.textBoxChild.Name = "textBoxChild";
            this.textBoxChild.Size = new System.Drawing.Size(125, 30);
            this.textBoxChild.TabIndex = 9;
            // 
            // textBoxAdults
            // 
            this.textBoxAdults.Location = new System.Drawing.Point(156, 228);
            this.textBoxAdults.Name = "textBoxAdults";
            this.textBoxAdults.Size = new System.Drawing.Size(125, 30);
            this.textBoxAdults.TabIndex = 10;
            // 
            // comboBoxChamber
            // 
            this.comboBoxChamber.FormattingEnabled = true;
            this.comboBoxChamber.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite",
            "Suite Presidential"});
            this.comboBoxChamber.Location = new System.Drawing.Point(184, 270);
            this.comboBoxChamber.Name = "comboBoxChamber";
            this.comboBoxChamber.Size = new System.Drawing.Size(151, 31);
            this.comboBoxChamber.TabIndex = 11;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Items.AddRange(new object[] {
            "Sauna",
            "Massage",
            "Breakfast",
            "Gym"});
            this.comboBoxServices.Location = new System.Drawing.Point(184, 310);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(151, 31);
            this.comboBoxServices.TabIndex = 12;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(193, 60);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(250, 30);
            this.dateTimePickerIn.TabIndex = 13;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(193, 102);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(250, 30);
            this.dateTimePickerOut.TabIndex = 14;
            // 
            // Cname
            // 
            this.Cname.AutoSize = true;
            this.Cname.Location = new System.Drawing.Point(77, 366);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(114, 23);
            this.Cname.TabIndex = 15;
            this.Cname.Text = "Client Name :";
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(210, 363);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(125, 30);
            this.clientName.TabIndex = 16;
            // 
            // PostReservation
            // 
            this.PostReservation.Location = new System.Drawing.Point(77, 427);
            this.PostReservation.Name = "PostReservation";
            this.PostReservation.Size = new System.Drawing.Size(94, 49);
            this.PostReservation.TabIndex = 17;
            this.PostReservation.Text = "Send";
            this.PostReservation.UseVisualStyleBackColor = true;
            this.PostReservation.Click += new System.EventHandler(this.PostReservation_ClickAsync);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 587);
            this.Controls.Add(this.PostReservation);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.comboBoxServices);
            this.Controls.Add(this.comboBoxChamber);
            this.Controls.Add(this.textBoxAdults);
            this.Controls.Add(this.textBoxChild);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxHotel;
        private TextBox textBoxChild;
        private TextBox textBoxAdults;
        private ComboBox comboBoxChamber;
        private ComboBox comboBoxServices;
        private DateTimePicker dateTimePickerIn;
        private DateTimePicker dateTimePickerOut;
        private Label Cname;
        private TextBox clientName;
        private Button PostReservation;
    }
}