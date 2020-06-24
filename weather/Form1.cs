using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using weather.sop;
using xNet;

namespace weather
{
    public partial class Form1 : Form
    {

        static public Thread update;
        



        public Form1()
        {
            InitializeComponent();

            temperatures.like_feels = Feels_like;
            temperatures.max = Max;
            temperatures.min = Min;
            temperatures.speeds = speed;
            temperatures.status = Status;
            temperatures.temp = Temp;
            temperatures.lab4 = label4;
            temperatures.lab5 = label5;
            temperatures.pressures = Pressure;

            Ocon.MAKEPICYCH = pictureBox1;
            Ocon.gif = pictureBox2;

            City.cit = comboBox1;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temperatures.Cities = "Naberezhnye Chelny";
            comboBox1.Text= comboBox1.Items[0].ToString();
            pictureBox1.Focus();
            button1.Focus();
            try {
                update = new Thread(()=>{
                    while (true) { 
                    temperatures.tempura();
                        Ocon.ico();
                        time.Invoke((MethodInvoker)(() => time.Text = DateTime.Now.ToString()));
                        Thread.Sleep(30000);
                    }
                });
                update.Start();
            }
            catch
            {
                MessageBox.Show("Сервер отказал, попробуйте включить ВПН или раздать интернет с мобильного устройства");
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                temperatures.tempura();

                Ocon.ico();
                time.Invoke((MethodInvoker)(() => time.Text = DateTime.Now.ToString()));

            }
            catch
            {
                MessageBox.Show("Сервер отказал, попробуйте включить ВПН или раздать интернет с мобильного устройства");
                Application.Exit();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            City.take();// класс который меняет города при изменении combobox


            try
            {
                temperatures.tempura();

                Ocon.ico();
                time.Invoke((MethodInvoker)(() => time.Text = DateTime.Now.ToString()));

            }
            catch
            {
                MessageBox.Show("Сервер отказал, попробуйте включить ВПН или раздать интернет с мобильного устройства");
                Application.Exit();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            update.Abort();
        }

        private void историяГородаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form historik = new history();
            historik.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Pressure_Click(object sender, EventArgs e)
        {

        }
    }
}
