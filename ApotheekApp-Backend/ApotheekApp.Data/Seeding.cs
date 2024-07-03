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
                new Employee(){FirstName = "Julia", LastName = "Admin", UserName = "Julia", Email = "julia.admin@email.com" },
                new Employee(){FirstName = "Max", LastName = "Apotheker", UserName = "Max", Email = "max.apotheker@email.com"},
            };
        }

        // https://www.zorgwijzer.nl/zorgverzekering-2021/deze-7-medicijnen-gebruiken-we-het-meest
        public static List<Medicine> ListOfMedicines()
        {
            return new List<Medicine>()
            {
                new Medicine(){ Id = 1,
                    Name = "Diclofenac",
                    Description = "Diclofenac staat op plek 1 als meest gebruikte geneesmiddel in Nederland. De medicatie wordt voorgeschreven als pijnstiller met een ontstekingsremmende werking. ",
                    Stock = 11},
                new Medicine(){Id = 2,
                    Name = "Amoxicilline",
                    Description = "Amoxicilline is het meest voorgeschreven antibioticum in Nederland en wordt gebruikt bij bepaalde infecties, zoals een blaasontsteking, oorontsteking of luchtweginfectie.\r\n\r\nHet medicijn kan worden voorgeschreven onder verschillende merken, zoals: Amoxicilline, Amoxypen, Bactimed, Clamoxyl en Docamoxici.\r\n\r\nDe kosten van één Amoxicilline tablet (Sandoz) met een dosering van 500 mg kost 0,42 euro, exclusief afleverkosten. ",
                    Stock = 61},
                new Medicine(){Id = 3,
                    Name = "Omeprazol",
                    Description = "Omeprazol is een veelgebruikt geneesmiddel dat wordt voorgeschreven bij maagklachten, zoals brandend maagzuur of maagzweren. Het zorgt ervoor dat de maag minder zuur aanmaakt.\r\n\r\nDe maagzuurremmer wordt meestal voorgeschreven onder de merknaam Losec, Losecosan of Losec-mups.\r\n\r\nEen Losec mups tablet msr 10 mg van Astrazeneca kost 0,74 euro. Dit is exclusief de kosten voor het afleveren. ",
                    Stock = 14},
                new Medicine(){Id = 4,
                    Name = "Doxycycline",
                    Description = "Doxycycline is een antibiotica dat net als Amoxicilline wordt voorgeschreven bij allerlei infecties, zoals een huidinfectie, longinfectie, maar ook bij acne of de ziekte van Lyme.\r\n\r\nDe medicatie is ontwikkeld door Pfizer en wordt verkocht onder de namen Monodox, Microdox, Doxy en Doxylin. Het middel wordt uitgegeven door verschillende farmaceuten, zoals Mylan, Teva, Aurobindo en Pfizer.\r\n\r\nEen tablet Doxycycline van het merk Teva kost 0,45 euro, exclusief aflevering, bij een dosering van 100 mg. ",
                    Stock = 1 },
                new Medicine(){Id = 5,
                    Name = "Ibuprofen",
                    Description = "Ibuprofen (brufen) is een veelgebruikt ontstekingsremmend medicijn (NSAID) dat wordt voorgeschreven bij pijn of koorts en om bepaalde ontstekingen te verlichten. Met name bij gewrichtspijn, kiespijn en menstruatiemiddel wordt het geslikt.\r\n\r\nDe pijnstiller is tot 400 mg per tablet vrij verkrijgbaar bij de drogist onder de merken:\r\n\r\n    Advil\r\n    Brufen\r\n    Dolofin\r\n    Nurofen\r\n    Nuprin\r\n\r\nTwee strips Ibuprofen van 20 pillen kosten circa 2 euro bij de drogist, al kunnen de kosten sterk varieren, afhankelijk van het gekozen merk en de dosering. ",
                    Stock = 78},
            };
        }

        // https://allesoverallergie.nl/pages/meest-voorkomende-allergieen
        public static List<Allergy> ListOfAllergies()
        {
            return new List<Allergy>()
            {
                new Allergy(){ Id = 1,
                    Name = "Hooikoorts",
                    Description = "Voor veel mensen een hele bekende allergie: hooikoorts. Hooikoorts staat ook wel bekend als graspollen- of boombollenallergie. Maar liefst 1 op de 8 mensen in Europa hebben last van hooikoorts. De klachten kunnen overeenkomen met die van een verkoudheid, maar het grootste verschil is dat de klachten van hooikoorts een langere periode duren. Waar een verkoudheid binnen enkele dagen weg is, kunnen de klachten van hooikoorts weken aanhouden."},
                new Allergy(){ Id = 2,
                    Name = "Huisstofmijtallergie",
                    Description = "Hierbij worden de klachten veroorzaakt door een reactie op de huisstofmijt. Dit zijn witte beestjes die tot de familie van de spinachtigen behoren. De klachten worden vooral veroorzaakt door de uitwerpselen van de beestjes. De meest voorkomende klachten zijn niesbuien, tranende en jeukende ogen en vermoeidheid."},
                new Allergy(){ Id = 3,
                    Name = "Voedselallergie",
                    Description = "Bij een voedselallergie worden de klachten veroorzaakt door een reactie van het afweersysteem op specifieke voedingsmiddelen. Het lichaam maakt hierbij antistoffen aan tegen bepaalde eiwitten in voedingsmiddelen, waardoor er een allergische reactie ontstaat. De meest voorkomende voedselallergieën zijn koemelkallergie en notenallergie."},
                new Allergy(){ Id = 4,
                    Name = "Huisdierenallergie",
                    Description = "Veel mensen denken dat een huisdierenallergie wordt veroorzaakt door de haren van dieren. Dit is echter een onjuiste aanname. Bij een allergie voor huisdieren worden de klachten namelijk veroorzaakt door een reactie op huidschilfers (epitheel) en veren van dieren. Hieruit ontstaan vervolgens de symptomen die bij deze allergie horen, zoals hoofdpijn, jeukende ogen en niesbuien. De allergenen van een kat zijn het sterkt, waardoor de klachten bij een kattenallergie het meest voorkomt in vergelijking met andere dieren."},
                new Allergy(){ Id = 5,
                    Name = "Contactallergie",
                    Description = "Wanneer je huiduitslag krijgt van rechtstreeks contact met iets in je omgeving zou dit een allergische reactie kunnen zijn. Dan is je immuunsysteem hierbij betrokken. Je zou ook last kunnen hebben van een niet-allergische reactie als gevolg van prikkelende stoffen. Dan spreken we officieel niet van een allergie, maar van een overgevoeligheid. Vaak is het een combinatie van beide. De bekendste aandoening als gevolg van contactreacties zijn netelroos en eczeem. De medische naam voor eczeem is dermatitis. Wanneer een specifiek allergeen de oorzaak is van het eczeem dan heet dat allergische contactdermatitis."},
            };
        }
    }
}