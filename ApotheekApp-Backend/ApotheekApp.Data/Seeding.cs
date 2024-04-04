using ApotheekApp.Domain.Models;

namespace ApotheekApp.Data
{
    public static class Seeding
    {
        public static List<Client> ListOfClients()
        {
            return new List<Client>()
            {
                new Client(){ FirstName = "Abel", LastName = "Anders", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(20000))},
                new Client(){ FirstName = "Bart", LastName = "Beergraaf", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(21000))},
                new Client(){ FirstName = "Carla", LastName = "Claarwakker", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(22000))},
                new Client(){ FirstName = "Dieter", LastName = "Doornbosch", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(23000))},
                new Client(){ FirstName = "Erika", LastName = "Eenhoorn", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(24000))},
                new Client(){ FirstName = "Francis", LastName = "Feenstra", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(25000))},
                new Client(){ FirstName = "Gerard", LastName = "Graafland", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(26000))},
                new Client(){ FirstName = "Hubert", LastName = "Houdoe", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(27000))},
                new Client(){ FirstName = "Ingrid", LastName = "Iersma", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(28000))},
                new Client(){ FirstName = "Jasmijn", LastName = "Jingle", DateOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(29000))},
            };
        }

        public static List<Employee> ListOfEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){FirstName = "Julia", LastName = "Admin", UserName = "Admin", Email = "julia.admin@email.com" },
                new Employee(){FirstName = "Max", LastName = "Apotheker", UserName = "Max", Email = "max.apotheker@email.com"},
            };
        }

        // https://www.zorgwijzer.nl/zorgverzekering-2021/deze-7-medicijnen-gebruiken-we-het-meest
        public static List<Medicine> ListOfMedicines()
        {
            return new List<Medicine>()
            {
                new Medicine(){Name = "Diclofenac",
                    Description = "Diclofenac staat op plek 1 als meest gebruikte geneesmiddel in Nederland. De medicatie wordt voorgeschreven als pijnstiller met een ontstekingsremmende werking. ",
                    Manual = "12 keer per dag ondersteboven innemen",
                    Type = "pijnstiller",
                    Stock = 11},
                new Medicine(){Name = "",
                    Description = "",
                    Manual = "", Type = "",
                    Stock =
                    11},
                new Medicine(){Name = "",
                    Description = "",
                    Manual = "", Type = "",
                    Stock = 11},
                new Medicine(){Name = "",
                    Description = "",
                    Manual = "", Type = "",
                    Stock = 11},
                new Medicine(){Name = "",
                    Description = "",
                    Manual = "", Type = "",
                    Stock = 11},
            };
        }

        // https://allesoverallergie.nl/pages/meest-voorkomende-allergieen
        public static List<Allergy> ListOfAllergies()
        {
            return new List<Allergy>()
            {
                new Allergy(){ Name = "Hooikoorts", Description = "Voor veel mensen een hele bekende allergie: hooikoorts. Hooikoorts staat ook wel bekend als graspollen- of boombollenallergie. Maar liefst 1 op de 8 mensen in Europa hebben last van hooikoorts. De klachten kunnen overeenkomen met die van een verkoudheid, maar het grootste verschil is dat de klachten van hooikoorts een langere periode duren. Waar een verkoudheid binnen enkele dagen weg is, kunnen de klachten van hooikoorts weken aanhouden."},
                new Allergy(){ Name = "Huisstofmijtallergie", Description = "Hierbij worden de klachten veroorzaakt door een reactie op de huisstofmijt. Dit zijn witte beestjes die tot de familie van de spinachtigen behoren. De klachten worden vooral veroorzaakt door de uitwerpselen van de beestjes. De meest voorkomende klachten zijn niesbuien, tranende en jeukende ogen en vermoeidheid."},
                new Allergy(){ Name = "Voedselallergie", Description = "Bij een voedselallergie worden de klachten veroorzaakt door een reactie van het afweersysteem op specifieke voedingsmiddelen. Het lichaam maakt hierbij antistoffen aan tegen bepaalde eiwitten in voedingsmiddelen, waardoor er een allergische reactie ontstaat. De meest voorkomende voedselallergieën zijn koemelkallergie en notenallergie."},
                new Allergy(){ Name = "Huisdierenallergie", Description = "Veel mensen denken dat een huisdierenallergie wordt veroorzaakt door de haren van dieren. Dit is echter een onjuiste aanname. Bij een allergie voor huisdieren worden de klachten namelijk veroorzaakt door een reactie op huidschilfers (epitheel) en veren van dieren. Hieruit ontstaan vervolgens de symptomen die bij deze allergie horen, zoals hoofdpijn, jeukende ogen en niesbuien. De allergenen van een kat zijn het sterkt, waardoor de klachten bij een kattenallergie het meest voorkomt in vergelijking met andere dieren."},
                new Allergy(){ Name = "", Description = ""},
            };
        }
    }
}