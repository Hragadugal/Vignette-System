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
    public partial class VinetteRemove : Form
    {
        public Car car = new Car();
        public User user = new User();
        public BoughtVignette boughtVignette = new BoughtVignette();
        public VinetteRemove()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }
        //Remove information
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            VinetteSurvices vinetteSurvices = new VinetteSurvices();
            vinetteSurvices.DeleteData(boughtVignette, user, car);
            MessageBox.Show("Успешно премахнат!", "", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        //Show information
        private void buttonFInd_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0 && IsValidCarReg())
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBoxDateOfValid.Visible = true;
                buttonDelete.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                string carRegistration = textBox3.Text;
                car = new Business.CarSurvices().GetByCarRegistration(carRegistration);
                user = new UserSurvices().GetByCar(car);
                boughtVignette = new VinetteSurvices().GetByCar(car);
                textBox1.Text = user.FirstName.ToString();
                textBox2.Text = user.LastName.ToString();
                textBox5.Text = user.PersonalCode.ToString();
                user.FirstName = user.FirstName.ToString();
                user.LastName = user.LastName.ToString();
                user.PersonalCode = user.PersonalCode.ToString();
                textBoxDateOfValid.Text = boughtVignette.DateTime.ToString();
                switch (boughtVignette.VignettesId)
                {
                    case 1:
                        {
                            textBox4.Text = "Уикенд (2 дни)";
                            boughtVignette.VignettesId = boughtVignette.VignettesId;
                            break;
                        }
                    case 2:
                        {
                            textBox4.Text = "Седмична (7 дни)";
                            boughtVignette.VignettesId = boughtVignette.VignettesId;
                            break;
                        }
                    case 3:
                        {
                            textBox4.Text = "Месечна (1 месец)";
                            boughtVignette.VignettesId = boughtVignette.VignettesId;
                            break;
                        }
                    case 4:
                        {
                            textBox4.Text = "Тримесечна (3 месеца)";
                            boughtVignette.VignettesId = boughtVignette.VignettesId;
                            break;
                        }
                    case 5:
                        {
                            textBox4.Text = "Годишна (1 година)";
                            boughtVignette.VignettesId = boughtVignette.VignettesId;
                            break;
                        }
                    default:
                          break;
                }
            }
            else
            {
                MessageBox.Show("Въвели сте несъществуващ регистрационнен номер!", "Внимание!", MessageBoxButtons.OK);
            }
            
            
        }
        //Chek
        private Boolean IsValidCarReg()
        {
            var cars = new Business.CarSurvices().GetAll();
            foreach (var c in cars)
            {
                if (c.CarRegistration.Equals(textBox1.Text.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
