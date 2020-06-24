using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather.sop
{
    class Ocon
    {
        static public PictureBox gif = new PictureBox();
        static public PictureBox MAKEPICYCH = new PictureBox();
        static public void ico()
        {
            MAKEPICYCH.Image = null;
            gif.Image = null;
            //для выявления новой погоды и ошибок в программе.

            if (temperatures.stating == "ясно") { 
            MAKEPICYCH.Invoke((MethodInvoker)(() =>MAKEPICYCH.Image= Properties.Resources.d));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.clear));
                //делегат для изменение picture box из разных потоков
            }

            if (temperatures.stating == "небольшая облачность") { 
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.d_c1));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.fyCe));
            }

            if (temperatures.stating == "облачно с прояснениями") {
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.d_c2));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.fyCe));
            }

            if (temperatures.stating == "переменная облачность"){
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.d_c2));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.fyCe));
            }

            if (temperatures.stating == "облачно") { 
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.c3));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.totoro));
            }

            if (temperatures.stating == "пасмурно")
            {
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.c3));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.CZk));
            }
            if (temperatures.stating == "гроза")
            {
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.c3_st));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources._7STV));
            }
            if (temperatures.stating == "плотный туман")
            {
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.mist));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.GXHc));
            }
            if (temperatures.stating == "небольшой дождь")
            {
                MAKEPICYCH.Invoke((MethodInvoker)(() => MAKEPICYCH.Image = Properties.Resources.c3));
                gif.Invoke((MethodInvoker)(() => gif.Image = Properties.Resources.CZk));
            }
        }
    }
}
