using System;

namespace _04._10._2021_Singleton_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Database db = Database.Getİnstance();
            Database db1 = Database.Getİnstance();
            Database db2 = Database.Getİnstance();
            //Database db3 = new Database();//newleyemez.
            db1.ConnectionString = "galatasaray";
          



        }
    }

    class Database
    {
        Database()//private yaparsak dısardan newleme işleminin onune gerçeriz.
        {

        }
        public string ConnectionString { get; set; }

        static Database database; //referansın stackte tutulmasını saglamak ıcın yaptık.
        static public Database Getİnstance()
        {

            return database;


        }
        static Database()//bir kere newleyebilir
        {
            database = new Database();

        }
    }


}
