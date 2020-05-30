using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Vignette.Data.Model;

namespace View
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Check_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        //Chek and show information
        private void button2_Click(object sender, EventArgs e)
        {

            var cars = new CarSurvices().GetAll();
            var users = new UserSurvices().GetAll();
            var vinettes = new VinetteSurvices().GetAll();
            
            foreach(var car in cars)
            {
                if (car.CarRegistration.Equals(textBox1.Text.ToString()))
                {
                    foreach (var user in users)
                    {
                        if (car.Id_User == user.Id)
                        {
                            textBox2.Text = user.FirstName.ToString();
                            textBox3.Text = user.LastName.ToString();

                            break;
                        }
                    }
                    foreach (var v in vinettes)
                    {
                        if(v.Id_Car == car.Id)
                        {
                            textBoxDateOfValid.Text = v.DateTime.ToString();
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
