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
            if (textBox1.Text.Length != 0 && textBox2.Text.Length !=0)
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
            label8.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label5.Visible = true;
            label5.Text = "Please imput your First and Last Names correctly";
        }

        private void getText()
        {
            label8.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label13.Text = monthCalendar1.SelectionStart.ToString();
            label14.Visible = true;
            label15.Visible = true;
            label5.Visible = false;
        }
    }
}
