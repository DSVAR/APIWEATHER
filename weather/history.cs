using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using weather.sop;

namespace weather
{
    public partial class history : Form
    {

        Thread changeCITY;

        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {
            changeCITY = new Thread(change);
            changeCITY.Start();

            
        }



        void change()
        {
            string cite;
            string cute=null;
            while(true)
            {
                cite = temperatures.Cities;
                Thread.Sleep(500);
                if(cite!=cute)
                if(temperatures.Cities== "Naberezhnye Chelny")
                {
                   pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                    pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.nab));
                    label1.Invoke((MethodInvoker)(() => label1.Text = "Набережные Челны"));
                    string SHORTHISTORY = Properties.Resources.Chelny;
                    textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                }//1
                if (cite != cute)
                    if (temperatures.Cities== "Kazan")
                    {
                   
                       pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                       pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.kaz));
                      label1.Invoke((MethodInvoker)(() => label1.Text = "Казань"));
                        string SHORTHISTORY = Properties.Resources.KZ;
                       textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;

                    }//2
                if (cite != cute)
                    if ( temperatures.Cities== "Moscow")
                    {
                 
                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Москва"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.MSK));
            
                        string SHORTHISTORY = Properties.Resources.MS;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//3

                if (cite != cute)
                    if (temperatures.Cities == "Svetogorsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Светогорск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.svetogorsk));

                        string SHORTHISTORY = Properties.Resources.Svet1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//4

                if (cite != cute)
                    if (temperatures.Cities == "Norilsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Норильск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.norilsk));

                        string SHORTHISTORY = Properties.Resources.Noril1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//5
                if (cite != cute)
                    if (temperatures.Cities == "Lensk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Ленск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.lensk));

                        string SHORTHISTORY = Properties.Resources.Len1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//6
                if (cite != cute)
                    if (temperatures.Cities == "Tomsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Томск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Tomsk));

                        string SHORTHISTORY = Properties.Resources.tomsk1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//7
                if (cite != cute)
                    if (temperatures.Cities == "Novosibirsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Новосибирск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Novosibirsk));

                        string SHORTHISTORY = Properties.Resources.NOVOR1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//8
                if (cite != cute)
                    if (temperatures.Cities == "Novokuznetsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Новокузнецк"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Novokyz));

                        string SHORTHISTORY = Properties.Resources.NovKyz1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//9
                if (cite != cute)
                    if (temperatures.Cities == "Krasnoyarsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Красноярск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.krasnoyarsk));

                        string SHORTHISTORY = Properties.Resources.Krasn1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//10
                if (cite != cute)
                    if (temperatures.Cities == "Omsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Омск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.omsk));

                        string SHORTHISTORY = Properties.Resources.Omsk1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//11
                if (cite != cute)
                    if (temperatures.Cities == "Samara")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Самара"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Samara));

                        string SHORTHISTORY = Properties.Resources.Samara1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//12
                if (cite != cute)
                    if (temperatures.Cities == "Nizhniy Novgorod")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Нижний Новгород"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.Nijnii));

                        string SHORTHISTORY = Properties.Resources.nizhnyy1;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//13
                if (cite != cute)
                    if (temperatures.Cities == "Irkutsk")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Иркутск"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.irkut));

                        string SHORTHISTORY = Properties.Resources.Irkutsk;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//14
                if (cite != cute)
                    if (temperatures.Cities == "Vorkuta")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Воркута"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.vorkuta1));

                        string SHORTHISTORY = Properties.Resources.Vorkuta;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//15
                if (cite != cute)
                    if (temperatures.Cities == "Toronto")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Торонто"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.toronto1));

                        string SHORTHISTORY = Properties.Resources.Toronto;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//16
                if (cite != cute)
                    if (temperatures.Cities == "New York")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Нью-Йорк"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.new_york));

                        string SHORTHISTORY = Properties.Resources.New_Yourt;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }//17
                if (cite != cute)
                    if (temperatures.Cities == "Detroit")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Детроит"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.D1));

                        string SHORTHISTORY = Properties.Resources.Detroit;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }
                //18
                if (cite != cute)
                    if (temperatures.Cities == "Omaha")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Омаха"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.omaha1));

                        string SHORTHISTORY = Properties.Resources.omaha;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }
                //19
                if (cite != cute)
                    if (temperatures.Cities == "London")
                    {

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Focus()));

                        label1.Invoke((MethodInvoker)(() => label1.Text = "Лондон"));

                        pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Image = Properties.Resources.London1));

                        string SHORTHISTORY = Properties.Resources.London;
                        textBox1.Invoke((MethodInvoker)(() => textBox1.Text = SHORTHISTORY));
                        cute = temperatures.Cities;
                    }
                //20













            }
        }

        private void history_FormClosing(object sender, FormClosingEventArgs e)
        {
            changeCITY.Abort();
        }
    }
}
