using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather.sop
{
    class City
    {
        static public ComboBox cit;
        static public void take()
        {
            if (cit.Text == "Набережные Челны")
                temperatures.Cities = "Naberezhnye Chelny";//1
            if(cit.Text == "Казань")
                temperatures.Cities = "Kazan";//2
            if (cit.Text == "Москва")
                temperatures.Cities = "Moscow";//3

            if (cit.Text == "Светогорск")
                temperatures.Cities = "Svetogorsk";//4
            if (cit.Text == "Норильск")
                temperatures.Cities = "Norilsk";//5
            if (cit.Text == "Ленск")
                temperatures.Cities = "Lensk";//6
            if (cit.Text == "Томск")
                temperatures.Cities = "Tomsk";//7
            if (cit.Text == "Новосибирск")
                temperatures.Cities = "Novosibirsk";//8
            if (cit.Text == "Новокузнецк")
                temperatures.Cities = "Novokuznetsk";//9
            if (cit.Text == "Красноярск")
                temperatures.Cities = "Krasnoyarsk";//10
            if (cit.Text == "Омск")
                temperatures.Cities = "Omsk";//11
            if (cit.Text == "Самара")
                temperatures.Cities = "Samara";//12
            if (cit.Text == "Нижний Новгород")
                temperatures.Cities = "Nizhniy Novgorod";//13
            if (cit.Text == "Иркутск")
                temperatures.Cities = "Irkutsk";//14
            if (cit.Text == "Воркута")
                temperatures.Cities = "Vorkuta";//15
            if (cit.Text == "Торонто")
                temperatures.Cities = "Toronto";//16
            if (cit.Text == "Нью Йорк")
                temperatures.Cities = "New York";//17
            if (cit.Text == "Детроит")
                temperatures.Cities = "Detroit";//18
            if (cit.Text == "Омаха")
                temperatures.Cities = "Omaha";//19
            if (cit.Text == "Лондон")
                temperatures.Cities = "London";//20

            //установка городов на английский язык для нормального запроса.
        }

    }
}
