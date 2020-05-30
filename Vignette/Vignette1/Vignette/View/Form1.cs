using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Add information in db
        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            switch (selected)
            {
                case "Закопуване на винетка":
                    {
                        Buy buy = new Buy();
                        buy.Show();
                        this.Hide();
                        
                    }break;
                case "Проверка на винетка":
                    {
                        Check check = new Check();
                        check.Show();
                        this.Hide();
                    }break;
                case "Премахване на винетка":
                    {
                        VinetteRemove vinetteRemove = new VinetteRemove();
                        vinetteRemove.Show();
                        this.Hide();
                    }break;

                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
