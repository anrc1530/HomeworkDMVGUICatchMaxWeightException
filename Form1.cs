using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DMV_GUI
{
    public partial class Form1 : Form
    {

        List<MotorVehicle> vehicleList = new List<MotorVehicle> { }; //Define Array of MotorVehicle objects
        
        public static string textFile = "log-"+(DateTime.Now.ToString("dd-MM-yyyy"))+".txt"; //Define dynamic time-dependant name of textfile

        public static string backupFolder = @"C:backupFolder";

        public Form1()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            VehicleTypeChange(null, null); //Run function to check the default radio button 
            if (!File.Exists(textFile)) //Check if our textfile already exists 
            { 
                FileStream fileStream = new FileStream(textFile, FileMode.Create, FileAccess.Write); //Create a new texfile 
                fileStream.Close(); //Close the file, so that other methods can acces it 
            } 
            else 
            { 
                if (Directory.Exists(backupFolder)) 
                { 
                    File.Move(textFile, backupFolder + "/" + textFile + "-backup.txt"); 
                    FileStream fileStream = new FileStream(textFile, FileMode.Create, FileAccess.Write); //Create a new texfile 
                    fileStream.Close(); //Close the file, so that other methods can acces it 
                } 
                else 
                { 
                    DirectoryInfo dir = Directory.CreateDirectory(backupFolder); 
                    File.Move(textFile, backupFolder + "/" + textFile + "-backup.txt"); 
                    FileStream fileStream = new FileStream(backupFolder + "/" + textFile, FileMode.Create, FileAccess.Write); //Create a new texfile 
                    fileStream.Close(); //Close the file, so that other methods can acces it 
                } 
            } 
        }

        private void VehicleTypeChange(object sender, EventArgs e) //Method for radio button selector. Displays required fileds for diferent types of motor Vehicles
        {
            if (rbTruck.Checked)
            {
                customLabel01.Visible = customTb01.Visible = true;
                customLabel02.Visible = customTb02.Visible = customLabel03.Visible = rbYes.Visible = rbNo.Visible = false;
                customLabel01.Text = "maximum weight";
            }
            else if (rbBus.Checked)
            {
                customLabel01.Visible = customTb01.Visible = true;
                customLabel02.Visible = customTb02.Visible = customLabel03.Visible = rbYes.Visible = rbNo.Visible = false;
                customLabel01.Text = "Company name";
            }
            else if (rbCar.Checked)
            {
                customLabel01.Visible = customTb01.Visible = customLabel02.Visible = customLabel03.Visible = customTb02.Visible = rbYes.Visible = rbNo.Visible = true;
                customLabel01.Text = "Car Color";
                customLabel02.Text = "Number of airbags";
                customLabel03.Text = "Does the car have AC?";
            }
            else if (rbTaxi.Checked)
            {
                customLabel01.Visible = customTb01.Visible = customLabel02.Visible = customLabel03.Visible = customTb02.Visible = rbYes.Visible = rbNo.Visible = customLabel04.Visible = rbYes2.Visible = rbNo2.Visible = true;
                customLabel01.Text = "Car Color";
                customLabel02.Text = "Number of airbags";
                customLabel03.Text = "Cab has AC?";
                customLabel04.Text = "Driver has licence?";
            }
        }

        private void RegisterVehicleClick(object sender, EventArgs e) //Button Click method. Creates objects, puts them in our array, then displays them in log as well as stores them in out textfile
        {
            try
            {
                if (customTb01.TextLength < 1)
                {
                    throw new Exception();
                }


                MotorVehicle mv = null;
                if (rbTruck.Checked)
                {
                    mv = new Truck(tbVIN.Text, tbMake.Text, tbModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, datePicker.Value, Convert.ToDouble(customTb01.Text));
                }
                else if (rbBus.Checked)
                {
                    mv = new Bus(tbVIN.Text, tbMake.Text, tbModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, datePicker.Value, customTb01.Text);
                }
                else if (rbCar.Checked)
                {
                    mv = new Car(tbVIN.Text, tbMake.Text, tbModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, datePicker.Value, customTb01.Text, rbYes.Checked, Convert.ToInt32(customTb02.Text));
                }
                else if (rbTaxi.Checked)
                {
                    mv = new Taxi(tbVIN.Text, tbMake.Text, tbModel.Text, (int)NoOfWheels.Value, (int)NoOfSeats.Value, datePicker.Value, customTb01.Text, rbYes.Checked, Convert.ToInt32(customTb02.Text), rbYes2.Checked);
                }



                vehicleList.Add(mv); //Append newest object to array

                rtLog.Clear();

                foreach (MotorVehicle m in vehicleList) //Display and store in textfile
                {
                    if (m != null)
                    {
                        rtLog.AppendText(m.show() + "\n\n");
                        using (FileStream file = new FileStream(textFile, FileMode.Append, FileAccess.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(file))
                            {
                                writer.WriteLine(m.show());
                                writer.Close();
                            }
                            file.Close();
                        }

                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Please input MAX WEIGHT");                           
            }

        }
        
        private void ShowLastVehicleFromFile(object sender, EventArgs e) //Get from textfile and display in Richtextbox
        {
            var lines = File.ReadLines(textFile); 
            string line = lines.Last(); 
            rtLog.AppendText(line + "\n\n");
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            vehicleList.Sort();
            vehicleList.ForEach(vehicle => rtLog.AppendText(vehicle.show()+'\n'));
        }        
    }
}
