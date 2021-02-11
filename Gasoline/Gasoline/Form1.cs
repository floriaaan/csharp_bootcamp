using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Gasoline
{
    public partial class Form1 : Form
    {
        public String password = "";
        public String fuelType = "";
        public String ticketChoice = "";
        public Form1()
        {
            InitializeComponent();
            numPad1.Hide();
            passwordLabelHelp.Hide();
            fuelChoice1.Hide();
            serviceDone.Hide();
            ticketChoice1.Hide();
            terminate.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardInsert1.Hide();
            button1.Hide();
            Thread.Sleep(1000);
            numPad1.Show();
            passwordLabelHelp.Show();
        }

        private void cardInsert1_Load(object sender, EventArgs e)
        {

        }

        private void numPad1_Load(object sender, EventArgs e)
        {

            numPad1.onClick += NumPad1_onClick;
        
        }

        private void NumPad1_onClick(string txt)
        {
            if(passwordLabel.Text == "Code faux")
            {
                passwordLabel.Text = "";
            }

            if(txt == "C")
            {
                password = "";
                passwordLabel.Text = "";
            } else if(txt == "V")
            {
                if(password == "1234")
                {
                    passwordLabel.Text = "Code bon";
                    password = "";
                    Thread.Sleep(1000);

                    numPad1.Hide();
                    passwordLabel.Hide();
                    passwordLabelHelp.Hide();
                    fuelChoice1.Show();
                    return;
                } else
                {
                    passwordLabel.Text = "Code faux";
                    password = "";
                    return;
                }
            } else
            {
                password += txt;
            passwordLabel.Text += "*";
            }
        }

        private void fuelChoice1_Load(object sender, EventArgs e)
        {
            fuelChoice1.onClick += FuelChoice1_onClick;
        }

        private void FuelChoice1_onClick(string txt)
        {
            fuelType = txt;
            fuelChoice1.Hide();
            Thread.Sleep(1000);
            fuelService.Text = "Allez vous servir en : \n" + fuelType;
            serviceDone.Show();
        }

        private void serviceDone_Click(object sender, EventArgs e)
        {
            fuelService.Hide();
            serviceDone.Hide();
            Thread.Sleep(1000);
            ticketChoice1.Show();
        }

        private void ticketChoice1_Load(object sender, EventArgs e)
        {
            ticketChoice1.onClick += TicketChoice1_onClick;
        }

        private void TicketChoice1_onClick(string txt)
        {
            ticketChoice = txt;
            ticketChoice1.Hide();
            terminate.Show();
            Thread.Sleep(3000);
            this.ReInit();
            
        }

        private void ReInit()
        {
            numPad1.Hide();
            passwordLabelHelp.Hide();
            fuelChoice1.Hide();
            serviceDone.Hide();
            ticketChoice1.Hide();
            terminate.Hide();
            
            cardInsert1.Show();
            button1.Show();
        }
    }
}
