namespace DMV_GUI
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
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.dateOfProdLabel = new System.Windows.Forms.Label();
            this.noOfWheelsLabel = new System.Windows.Forms.Label();
            this.noOfSeatsLabel = new System.Windows.Forms.Label();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customLabel04 = new System.Windows.Forms.Label();
            this.rbNo2 = new System.Windows.Forms.RadioButton();
            this.rbYes2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customLabel03 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.NoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.NoOfWheels = new System.Windows.Forms.NumericUpDown();
            this.customTb02 = new System.Windows.Forms.TextBox();
            this.customLabel02 = new System.Windows.Forms.Label();
            this.customLabel01 = new System.Windows.Forms.Label();
            this.customTb01 = new System.Windows.Forms.TextBox();
            this.vehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonMotorcycle = new System.Windows.Forms.RadioButton();
            this.rbTaxi = new System.Windows.Forms.RadioButton();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbBus = new System.Windows.Forms.RadioButton();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.buttonRegVeh = new System.Windows.Forms.Button();
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.propertiesGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).BeginInit();
            this.vehicleTypeGroupBox.SuspendLayout();
            this.groupBoxVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(6, 38);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(208, 20);
            this.tbVIN.TabIndex = 0;
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(6, 77);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(208, 20);
            this.tbMake.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(6, 116);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(208, 20);
            this.tbModel.TabIndex = 2;
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(6, 22);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(145, 13);
            this.VINLabel.TabIndex = 6;
            this.VINLabel.Text = "Vehicle Identification Number";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(6, 61);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(108, 13);
            this.MakeLabel.TabIndex = 7;
            this.MakeLabel.Text = "Vehicle Manufacturer";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(6, 100);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 8;
            this.ModelLabel.Text = "Model";
            // 
            // dateOfProdLabel
            // 
            this.dateOfProdLabel.AutoSize = true;
            this.dateOfProdLabel.Location = new System.Drawing.Point(6, 139);
            this.dateOfProdLabel.Name = "dateOfProdLabel";
            this.dateOfProdLabel.Size = new System.Drawing.Size(96, 13);
            this.dateOfProdLabel.TabIndex = 9;
            this.dateOfProdLabel.Text = "Date of Production";
            // 
            // noOfWheelsLabel
            // 
            this.noOfWheelsLabel.AutoSize = true;
            this.noOfWheelsLabel.Location = new System.Drawing.Point(6, 178);
            this.noOfWheelsLabel.Name = "noOfWheelsLabel";
            this.noOfWheelsLabel.Size = new System.Drawing.Size(95, 13);
            this.noOfWheelsLabel.TabIndex = 10;
            this.noOfWheelsLabel.Text = "Number of Wheels";
            // 
            // noOfSeatsLabel
            // 
            this.noOfSeatsLabel.AutoSize = true;
            this.noOfSeatsLabel.Location = new System.Drawing.Point(6, 217);
            this.noOfSeatsLabel.Name = "noOfSeatsLabel";
            this.noOfSeatsLabel.Size = new System.Drawing.Size(86, 13);
            this.noOfSeatsLabel.TabIndex = 11;
            this.noOfSeatsLabel.Text = "Number of Seats";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.groupBox2);
            this.propertiesGroupBox.Controls.Add(this.groupBox1);
            this.propertiesGroupBox.Controls.Add(this.NoOfSeats);
            this.propertiesGroupBox.Controls.Add(this.tbVIN);
            this.propertiesGroupBox.Controls.Add(this.MakeLabel);
            this.propertiesGroupBox.Controls.Add(this.datePicker);
            this.propertiesGroupBox.Controls.Add(this.NoOfWheels);
            this.propertiesGroupBox.Controls.Add(this.tbMake);
            this.propertiesGroupBox.Controls.Add(this.VINLabel);
            this.propertiesGroupBox.Controls.Add(this.customTb02);
            this.propertiesGroupBox.Controls.Add(this.customLabel02);
            this.propertiesGroupBox.Controls.Add(this.ModelLabel);
            this.propertiesGroupBox.Controls.Add(this.customLabel01);
            this.propertiesGroupBox.Controls.Add(this.customTb01);
            this.propertiesGroupBox.Controls.Add(this.tbModel);
            this.propertiesGroupBox.Controls.Add(this.dateOfProdLabel);
            this.propertiesGroupBox.Controls.Add(this.noOfWheelsLabel);
            this.propertiesGroupBox.Controls.Add(this.noOfSeatsLabel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(12, 155);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(220, 399);
            this.propertiesGroupBox.TabIndex = 0;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Vehicle Properties";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customLabel04);
            this.groupBox2.Controls.Add(this.rbNo2);
            this.groupBox2.Controls.Add(this.rbYes2);
            this.groupBox2.Location = new System.Drawing.Point(106, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 62);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // customLabel04
            // 
            this.customLabel04.AutoSize = true;
            this.customLabel04.Location = new System.Drawing.Point(6, 0);
            this.customLabel04.Name = "customLabel04";
            this.customLabel04.Size = new System.Drawing.Size(35, 13);
            this.customLabel04.TabIndex = 25;
            this.customLabel04.Text = "label4";
            this.customLabel04.Visible = false;
            // 
            // rbNo2
            // 
            this.rbNo2.AutoSize = true;
            this.rbNo2.Location = new System.Drawing.Point(9, 42);
            this.rbNo2.Name = "rbNo2";
            this.rbNo2.Size = new System.Drawing.Size(41, 17);
            this.rbNo2.TabIndex = 27;
            this.rbNo2.TabStop = true;
            this.rbNo2.Text = "NO";
            this.rbNo2.UseVisualStyleBackColor = true;
            this.rbNo2.Visible = false;
            // 
            // rbYes2
            // 
            this.rbYes2.AutoSize = true;
            this.rbYes2.Location = new System.Drawing.Point(9, 19);
            this.rbYes2.Name = "rbYes2";
            this.rbYes2.Size = new System.Drawing.Size(46, 17);
            this.rbYes2.TabIndex = 26;
            this.rbYes2.TabStop = true;
            this.rbYes2.Text = "YES";
            this.rbYes2.UseVisualStyleBackColor = true;
            this.rbYes2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customLabel03);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Location = new System.Drawing.Point(0, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // customLabel03
            // 
            this.customLabel03.AutoSize = true;
            this.customLabel03.Location = new System.Drawing.Point(6, 0);
            this.customLabel03.Name = "customLabel03";
            this.customLabel03.Size = new System.Drawing.Size(35, 13);
            this.customLabel03.TabIndex = 22;
            this.customLabel03.Text = "label3";
            this.customLabel03.Visible = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(9, 16);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(46, 17);
            this.rbYes.TabIndex = 23;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "YES";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.Visible = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(9, 39);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 17);
            this.rbNo.TabIndex = 24;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.Visible = false;
            // 
            // NoOfSeats
            // 
            this.NoOfSeats.Location = new System.Drawing.Point(6, 233);
            this.NoOfSeats.Name = "NoOfSeats";
            this.NoOfSeats.Size = new System.Drawing.Size(208, 20);
            this.NoOfSeats.TabIndex = 18;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 155);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(208, 20);
            this.datePicker.TabIndex = 17;
            // 
            // NoOfWheels
            // 
            this.NoOfWheels.Location = new System.Drawing.Point(6, 194);
            this.NoOfWheels.Name = "NoOfWheels";
            this.NoOfWheels.Size = new System.Drawing.Size(208, 20);
            this.NoOfWheels.TabIndex = 17;
            // 
            // customTb02
            // 
            this.customTb02.Location = new System.Drawing.Point(6, 311);
            this.customTb02.Name = "customTb02";
            this.customTb02.Size = new System.Drawing.Size(208, 20);
            this.customTb02.TabIndex = 18;
            this.customTb02.Visible = false;
            // 
            // customLabel02
            // 
            this.customLabel02.AutoSize = true;
            this.customLabel02.Location = new System.Drawing.Point(6, 295);
            this.customLabel02.Name = "customLabel02";
            this.customLabel02.Size = new System.Drawing.Size(35, 13);
            this.customLabel02.TabIndex = 21;
            this.customLabel02.Text = "label2";
            this.customLabel02.Visible = false;
            // 
            // customLabel01
            // 
            this.customLabel01.AutoSize = true;
            this.customLabel01.Location = new System.Drawing.Point(6, 256);
            this.customLabel01.Name = "customLabel01";
            this.customLabel01.Size = new System.Drawing.Size(35, 13);
            this.customLabel01.TabIndex = 20;
            this.customLabel01.Text = "label1";
            this.customLabel01.Visible = false;
            // 
            // customTb01
            // 
            this.customTb01.Location = new System.Drawing.Point(6, 272);
            this.customTb01.Name = "customTb01";
            this.customTb01.Size = new System.Drawing.Size(208, 20);
            this.customTb01.TabIndex = 17;
            this.customTb01.Visible = false;
            // 
            // vehicleTypeGroupBox
            // 
            this.vehicleTypeGroupBox.Controls.Add(this.radioButtonMotorcycle);
            this.vehicleTypeGroupBox.Controls.Add(this.rbTaxi);
            this.vehicleTypeGroupBox.Controls.Add(this.rbCar);
            this.vehicleTypeGroupBox.Controls.Add(this.rbBus);
            this.vehicleTypeGroupBox.Controls.Add(this.rbTruck);
            this.vehicleTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.vehicleTypeGroupBox.Name = "vehicleTypeGroupBox";
            this.vehicleTypeGroupBox.Size = new System.Drawing.Size(220, 137);
            this.vehicleTypeGroupBox.TabIndex = 13;
            this.vehicleTypeGroupBox.TabStop = false;
            this.vehicleTypeGroupBox.Text = "Vehicle Type";
            // 
            // radioButtonMotorcycle
            // 
            this.radioButtonMotorcycle.AutoSize = true;
            this.radioButtonMotorcycle.Location = new System.Drawing.Point(6, 111);
            this.radioButtonMotorcycle.Name = "radioButtonMotorcycle";
            this.radioButtonMotorcycle.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMotorcycle.TabIndex = 4;
            this.radioButtonMotorcycle.TabStop = true;
            this.radioButtonMotorcycle.Text = "Motorcycle";
            this.radioButtonMotorcycle.UseVisualStyleBackColor = true;
            // 
            // rbTaxi
            // 
            this.rbTaxi.AutoSize = true;
            this.rbTaxi.Location = new System.Drawing.Point(6, 88);
            this.rbTaxi.Name = "rbTaxi";
            this.rbTaxi.Size = new System.Drawing.Size(45, 17);
            this.rbTaxi.TabIndex = 3;
            this.rbTaxi.TabStop = true;
            this.rbTaxi.Text = "Taxi";
            this.rbTaxi.UseVisualStyleBackColor = true;
            this.rbTaxi.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(6, 65);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(41, 17);
            this.rbCar.TabIndex = 2;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            this.rbCar.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbBus
            // 
            this.rbBus.AutoSize = true;
            this.rbBus.Location = new System.Drawing.Point(6, 42);
            this.rbBus.Name = "rbBus";
            this.rbBus.Size = new System.Drawing.Size(43, 17);
            this.rbBus.TabIndex = 1;
            this.rbBus.TabStop = true;
            this.rbBus.Text = "Bus";
            this.rbBus.UseVisualStyleBackColor = true;
            this.rbBus.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Checked = true;
            this.rbTruck.Location = new System.Drawing.Point(6, 19);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(53, 17);
            this.rbTruck.TabIndex = 0;
            this.rbTruck.TabStop = true;
            this.rbTruck.Text = "Truck";
            this.rbTruck.UseVisualStyleBackColor = true;
            this.rbTruck.CheckedChanged += new System.EventHandler(this.VehicleTypeChange);
            // 
            // buttonRegVeh
            // 
            this.buttonRegVeh.Location = new System.Drawing.Point(12, 560);
            this.buttonRegVeh.Name = "buttonRegVeh";
            this.buttonRegVeh.Size = new System.Drawing.Size(107, 35);
            this.buttonRegVeh.TabIndex = 14;
            this.buttonRegVeh.Text = "Register Vehicle";
            this.buttonRegVeh.UseVisualStyleBackColor = true;
            this.buttonRegVeh.Click += new System.EventHandler(this.RegisterVehicleClick);
            // 
            // groupBoxVehicleInfo
            // 
            this.groupBoxVehicleInfo.Controls.Add(this.rtLog);
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(244, 12);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(440, 627);
            this.groupBoxVehicleInfo.TabIndex = 16;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "Vehicle Information";
            // 
            // rtLog
            // 
            this.rtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtLog.Location = new System.Drawing.Point(6, 19);
            this.rtLog.Name = "rtLog";
            this.rtLog.ReadOnly = true;
            this.rtLog.Size = new System.Drawing.Size(428, 602);
            this.rtLog.TabIndex = 0;
            this.rtLog.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show last entry from File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowLastVehicleFromFile);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(125, 560);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(107, 35);
            this.SortButton.TabIndex = 18;
            this.SortButton.Text = "Sort Vehicles";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 651);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Controls.Add(this.buttonRegVeh);
            this.Controls.Add(this.vehicleTypeGroupBox);
            this.Controls.Add(this.propertiesGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.onLoad);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfWheels)).EndInit();
            this.vehicleTypeGroupBox.ResumeLayout(false);
            this.vehicleTypeGroupBox.PerformLayout();
            this.groupBoxVehicleInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label dateOfProdLabel;
        private System.Windows.Forms.Label noOfWheelsLabel;
        private System.Windows.Forms.Label noOfSeatsLabel;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.GroupBox vehicleTypeGroupBox;
        private System.Windows.Forms.RadioButton rbTaxi;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbBus;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.RadioButton radioButtonMotorcycle;
        private System.Windows.Forms.Button buttonRegVeh;
        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.TextBox customTb02;
        private System.Windows.Forms.TextBox customTb01;
        private System.Windows.Forms.Label customLabel03;
        private System.Windows.Forms.Label customLabel02;
        private System.Windows.Forms.Label customLabel01;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown NoOfSeats;
        private System.Windows.Forms.NumericUpDown NoOfWheels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbNo2;
        private System.Windows.Forms.RadioButton rbYes2;
        private System.Windows.Forms.Label customLabel04;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SortButton;
    }
}

