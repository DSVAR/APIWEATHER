using System;
using System.Data;
using System.Windows.Forms;
using xNet;
using Newtonsoft.Json.Linq;
using Npgsql;

namespace weather.sop
{
    class temperatures
    {
        static public Label speeds , temp, like_feels, min, max, status,lab4,lab5,pressures;
        static public string stating, Cities;
        // переменные для изменения лейбелов в программе
        static public string api = "0a03c34f64c86e7924406f389b77b9f3";
  // ключ  для работы с сервером.
  //строка подключеня к бд
  private const string ConnectionString = "Server=37.143.15.246;User Id=postgres;Password=125348220;Port=5432;Database=postgres;";

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
                AddDb(Cities,temps.ToString(),pressure.ToString(),speed.ToString());
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
        
        static private void AddDb(string city,string temp, string pressure, string speedWind)
        {
            try
            {
                using ( var coonection=new NpgsqlConnection(ConnectionString))
                {
                    coonection.Open();
                    string table = "SavedData";
                  //   NpgsqlCommand command = new NpgsqlCommand();
                  //   command.Connection = coonection;
                  //   command.CommandType = CommandType.Text;
                  //   command.CommandText = $"Select * from \"SavedData\"  ";
                  //   //command.ExecuteNonQuery();
                  //
                  // var t=  command.ExecuteReader();


                  NpgsqlCommand commandSecond = new NpgsqlCommand("Insert into \"Data\" " +
                                                                  "(\"Id\", \"City\",  \"Temp\", \"Pressure\", \"Date\", \"SpeedWind\")" +
                                                                  $"VALUES ('{Guid.NewGuid()}', '{city}',  '{temp}', '{pressure}', '{DateTime.Now.ToString()}','{speedWind}') ",coonection);
                  
                  commandSecond.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public DataTable GetDS()
        {
            try
            {
                using (var connection=new NpgsqlConnection(ConnectionString) )
                {
                    connection.Open();
                    var ds = new DataSet();
                    var dt = new DataTable();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Data\"", connection);
                    ds.Reset();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    return dt;
                }
            }
            catch (Exception ex)
            {
                var exr = ex.Message;
                return null;
            }
           

        }

    }
}
