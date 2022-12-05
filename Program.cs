using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.VisualBasic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Data Source = (LocalDataStoreSlot)\SQLEXPRESS;Initial
//Catalogue Northwind;Integrated Ssecurity = SSPI;

//SqlLiteConnection con = new SqlConnection(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database;Integrated Security=true");


//travail tp -----------------------------------------------------------
/*SQLiteConnection con = new(@"Data Source= C:\Users\hamad\Downloads\2022 GL3 .NET Framework TP3 - SQLite database.db");
con.Open();
using (con)
{
    SQLiteCommand command = new ("SELECT * FROM personal_info", con);
    SQLiteDataReader reader = command.ExecuteReader();
    using (reader) 
    {while (reader.Read())
        {
            int id = (int)reader["id"];
            string first_name = (string)reader["first_name"];
            string last_name = (string)reader["last_name"];
            string email = (string)reader["email"];
            //String date_birth = (String)reader["date_birth"];
            //String D = date_birth.ToString("MM/dd/yyyy");
            String image = (String)reader["image"];
            string country = (string)reader["country"];

             Debug.WriteLine("- {0} {1} {2} {3} {4} {5} ", id, first_name, last_name, email, image, country);
             //Console.WriteLine(date_birth + ".");

        }
    }
}*/
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
