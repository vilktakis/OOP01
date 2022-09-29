using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace GUI
{
    public partial class Form1 : Form
    {
        Controler controler;

        public Form1()
        {
            controler = new Controler();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controler.SetFirstName(textBox1.Text) && controler.SetLastName(textBox2.Text) && controler.SetDateOfBirth(monthCalendar1.SelectionStart))
            {
                getText();
            }
            else
            {
                warning();
            }
        }

        private void warning()
        {
            label5.Visible = true;
            label5.Text = "Please imput your First Name, Last Name\nand select your Date of Birth. Please,\ndo not break the code.";

            label8.Visible = false;

            label9.Visible = false;

            label13.Visible = false;

            label14.Visible = false;

            label15.Visible = false;
        }

        private void getText()
        {
            label5.Visible = false;

            label8.Text = controler.GetFirstName();
            label8.Visible = true;

            label9.Text = controler.GetLastName();
            label9.Visible = true;

            DateTime dateTime = controler.GetDateOfBirth();
            label13.Text = dateTime.Year + "/" + dateTime.Month + "/" + dateTime.Day;
            label13.Visible = true;

            label14.Text = controler.GetAge().ToString();
            label14.Visible = true;

            label15.Text = controler.GetDaysToBD().ToString();
            label15.Visible = true;
        }
    }
}
