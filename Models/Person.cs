namespace ProjetBase_de_données.Models
{
    public class Person
    {
        public int id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public String? date_birth { get; set; }
        //String D = date_birth.ToString("MM/dd/yyyy");
        public String? image { get; set; }
        public string? country { get; set; }

        public Person(int id, string first_name, string last_name, string email, string image, string country)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.image = image;
            this.country = country;
        }
    }
}
