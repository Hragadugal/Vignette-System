using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vignette.Data.Model;

namespace View
{
    public partial class Buy : Form
    {

        
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)

        {
            Car car = new Car();
            User user = new User();
            BoughtVignette boughtVignette = new BoughtVignette();
            Vignettes vignettes = new Vignettes();
            car.CarRegistration = textBox3.Text.ToString();
            user.FirstName = textBox1.Text.ToString();
            user.LastName = textBox2.Text.ToString();
            user.PersonalCode = textBox5.Text.ToString();
            var date = dateTimePickerActivateDate.Value;
            switch (comboBox1.SelectedItem.ToString())
            {
                
                case "Уикенд - 10лв.":
                    {
                        boughtVignette.VignettesId = 1;
                        date = date.AddDays(2);
                        
                    }break;
                case "Седмична - 15лв.":
                    {
                        boughtVignette.VignettesId = 2;
                        date = date.AddDays(7);
                        
                    }break;
                case "Месечна -  30лв.":
                    {
                        boughtVignette.VignettesId = 3;
                        date = date.AddMonths(1); 
                        
                    }break;

                case "Тримесечна - 54лв.":
                    {
                        boughtVignette.VignettesId = 4;
                        date = date.AddMonths(3);
                        
                    }break;
                case "Годишна - 97лв.":
                    {
                        boughtVignette.VignettesId = 5;
                        date = date.AddYears(1);
                        
                    }break;
                default:
                    break;
            }
            boughtVignette.DateTime = date;

            var vinneteSurvices = new VinetteSurvices();
            vinneteSurvices.takeData(boughtVignette,user,car);
            
            this.Close();
            MessageBox.Show("Вие успешно закупихте винетка!", "BG TOL SISTEM", MessageBoxButtons.OK);

            Form1 form1 = new Form1();
            form1.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerActivateDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
