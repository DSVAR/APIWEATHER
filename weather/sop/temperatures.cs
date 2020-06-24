using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace weather.sop
{
    class temperatures
    {
        static public Label speeds , temp, like_feels, min, max, status,lab4,lab5,pressures;
        static public string stating, Cities;
        // переменные для изменения лейбелов в программе
        static public string api = "0a03c34f64c86e7924406f389b77b9f3";
  // ключ  для работы с сервером.

        static public void tempura()
        {
            
                string url = "api.openweathermap.org/data/2.5/weather?q=" + Cities + "&appid=" + api + "&lang=ru&units=metric";
            // строка для отправки запроса
            try { 
                var oi = new HttpRequest();
                //сам запрос
                string op = oi.Post(url).ToString();
                //конвертация запроса
         


                var objects = JObject.Parse(op);
                //парсинг запроса  для выделения объектов
            

            JToken dol = objects["coord"]["lon"];
                JToken sh = objects["coord"]["lat"];
                //выделения специальных объектов долготы и широты
                dolg(lab4, lab5, dol.ToString(), sh.ToString());
                // функция для изменения Label'ов

                JToken speed = objects["wind"]["speed"];
                JToken temps = objects["main"]["temp"];
                JToken feels = objects["main"]["feels_like"];
                JToken min = objects["main"]["temp_min"];
                JToken max = objects["main"]["temp_max"];
                JToken pressure = objects["main"]["pressure"];
                JToken status = objects["weather"][0]["description"];
                //выделения специальных объектов скорости, температуры, как чувствуется
                // минимум, максимум, давление, и статус(погода)
                stating = status.ToString();
                //установка переменной для выведения и изменения картинки и gif.
                olk(speed.ToString(), temps.ToString(), feels.ToString(), min.ToString(), max.ToString(), pressure.ToString(), status.ToString());
                //Функция для  изменения большого количество Label
            }
            catch
            {
                MessageBox.Show("перезагрузить роутер");
            }
        }

        static public void dolg(Label lab1, Label lab2, string dolg, string shir)
        {
            lab1.Invoke((MethodInvoker)(() => lab1.Text = dolg));
            //делегат для изменения label
            lab2.Invoke((MethodInvoker)(() => lab2.Text = shir));
        }

        static public void olk(string speeding, string tempo, string feld, string minks, string maks, string pres, string stat )
        {
            speeds.Invoke((MethodInvoker)(() => speeds.Text = speeding));
            temp.Invoke((MethodInvoker)(() => temp.Text = tempo));
            like_feels.Invoke((MethodInvoker)(() => like_feels.Text = feld));
            min.Invoke((MethodInvoker)(() => min.Text = minks));
            max.Invoke((MethodInvoker)(() => max.Text = maks));
            pressures.Invoke((MethodInvoker)(() => pressures.Text = pres));
            status.Invoke((MethodInvoker)(() => status.Text = stat));

        }

    }
}
