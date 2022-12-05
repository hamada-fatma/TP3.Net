using System.Data.SQLite;
using System.Diagnostics;

namespace ProjetBase_de_données.Models
{
    public class Personal_info
    {
        // SQLiteConnection con1 = new(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database.db");

     
        
            //SQLiteConnection con1 = new(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database.db");
            //  con1.Open();
            //using (con1)
            //{
            //  SQLiteCommand command1 = new("SELECT * FROM personal_info", con1);
            //SQLiteDataReader reader1 = command1.ExecuteReader();
            //using (reader1)
            //{
       
            public List<Person> GetAllPerson()
            {
                List<Person> list = new List<Person>();
                SQLiteConnection dbCon = new(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database.db");
                dbCon.Open();

                using (dbCon)
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info", dbCon);
                    SQLiteDataReader reader1 = cmd.ExecuteReader();
                    using (reader1)
                    {
                        while (reader1.Read())
                            while (reader1.Read())
                            {
                                int id = (int)reader1["id"];
                                string first_name = (string)reader1["first_name"];
                                string last_name = (string)reader1["last_name"];
                                string email = (string)reader1["email"];
                                //String date_birth = (String)reader["date_birth"];
                                //String D = date_birth.ToString("MM/dd/yyyy");
                                String image = (String)reader1["image"];
                                string country = (string)reader1["country"];

                                //Debug.WriteLine("- {0} {1} {2} {3} {4} {5} ", id, first_name, last_name, email, image, country);
                                //Console.WriteLine(date_birth + ".");
                                list.Add(new Person(id, first_name, last_name, email, image, country));
                            }
                    }
                }
                return list;
            }

            public Person GetPerson(int id)
            {
                List<Person> list = GetAllPerson();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].id == id)
                    {
                        return list[i];
                    }
                }
                return null;

            }
        }
    }
