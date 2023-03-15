using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace FourLab
{
    public static class Methods
    {
        public static bool Bigger(float a, float b) //· Метод для нахождения наибольшего из 2 чисел, возвращает bool значение
        {
            bool result = true;
            if (a > b)
                result = true;
            if (a < b)
                result = false;
            if (a == b)
            {
                Console.WriteLine("equal");
            }
            return result;
        }

        public static float Metric(float m)
        {
            float cm = m * 100;
            return cm;
        }

        public static bool Datetime(string date)
        {
            DateTime dateTime;
            return DateTime.TryParse(date, out dateTime);
        }

        public static bool Registration(string username, string pwd, string email, string birthday)
        {
            SqliteConnection sqliteConn = new("Data Source = C:\\Users\\creat\\source\\repos\\FourLab\\appDb.db"); 
            sqliteConn.Open(); //открытие соединения
            SqliteCommand command = new() //инициализация экземпляра SqliteCommand
            {
                //command.CommandText = "INSERT INTO Users (Name, Age) VALUES ('Tom', 36)";
                Connection = sqliteConn, //соединение для выполнения запроса
                CommandText = $"INSERT INTO Users (login, pwd, email, birthday) VALUES ('{username}', '{pwd}', '{email}', '{birthday}')"
            };
            int isInserted = command.ExecuteNonQuery(); //выполнение запроса и возврат количества измененных строк
            sqliteConn.Close(); //закрытие соединения
            
            if (isInserted > 0) { return true; }
            else { return false; }
        }

        public static bool Authorization(string username, string pwd)
        {
            SqliteConnection sqliteConn = new("Data Source = C:\\Users\\creat\\source\\repos\\FourLab\\appDb.db");
            sqliteConn.Open(); //открытие соединения
            SqliteCommand command = new() //инициализация экземпляра SqliteCommand
            {
                //command.CommandText = "INSERT INTO Users (Name, Age) VALUES ('Tom', 36)";
                Connection = sqliteConn, //соединение для выполнения запроса
                CommandText = $"SELECT * FROM Users WHERE login = '{username}' AND pwd = '{pwd}'"
            };

            using SqliteDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {
                return true;
            }
            else { return false; }
        }

        public static bool Authorization()
        {

            return true;
        }
    }
}