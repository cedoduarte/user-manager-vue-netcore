using UserManager.Utils;

namespace UserManager.Models
{
    public static class DbSeeder
    {
        public static void DoSeeding(AppDbContext dbContext)
        {
            SeedUsers(dbContext);
        }

        private static void SeedUsers(AppDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var users = new User[]
                {
                    new User()
                    {
                        FirstName = "Carlos Enrique",
                        LastName = "Duarte Ortiz",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 2, 5),
                        PhoneNumber = "+526622769242",
                        Email = "carlosduarte.1@hotmail.com",
                        Username = "cedo",
                        PasswordHash = Util.GetSha256("Um4$kdgd"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/cedoduarte"
                    },
                    new User()
                    {
                        FirstName = "Rafaél Alexander",
                        LastName = "Trujillo López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 11, 20),
                        PhoneNumber = "+528713747464",
                        Email = "rafaelalexandertrujillolopez224@hotmail.com",
                        Username = "rafaelalexander257",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelalexandertrujillolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Rafaél",
                        LastName = "Nevárez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 12, 22),
                        PhoneNumber = "+526972817805",
                        Email = "arturorafaelnevarezjimenez438@hotmail.com",
                        Username = "arturorafael949",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturorafaelnevarezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Juan",
                        LastName = "Ramones Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 3, 8),
                        PhoneNumber = "+523658696114",
                        Email = "carlosjuanramonesdominguez541@hotmail.com",
                        Username = "carlosjuan293",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosjuanramonesdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Ángel",
                        LastName = "Carrillo Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 2, 17),
                        PhoneNumber = "+527305380462",
                        Email = "aaronangelcarrillojuarez890@hotmail.com",
                        Username = "aaronangel898",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronangelcarrillojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Fabrizio",
                        LastName = "Domínguez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 2, 18),
                        PhoneNumber = "+522686545407",
                        Email = "carlosfabriziodominguezenriquez997@hotmail.com",
                        Username = "carlosfabrizio882",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosfabriziodominguezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Christian",
                        LastName = "Ramones Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 7, 22),
                        PhoneNumber = "+526324165077",
                        Email = "estebanchristianramonesquintero356@hotmail.com",
                        Username = "estebanchristian172",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanchristianramonesquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Moisés",
                        LastName = "Enríquez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 12, 18),
                        PhoneNumber = "+529348661163",
                        Email = "gabrielmoisesenriquezcastrejon218@hotmail.com",
                        Username = "gabrielmoises465",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielmoisesenriquezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Carrillo Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 6, 14),
                        PhoneNumber = "+523326306380",
                        Email = "javierluiscarrilloarce766@hotmail.com",
                        Username = "javierluis36",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierluiscarrilloarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Daniel",
                        LastName = "Álvarez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 1, 4),
                        PhoneNumber = "+526471154964",
                        Email = "estebandanielalvarezgamez3@hotmail.com",
                        Username = "estebandaniel138",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebandanielalvarezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Fernando",
                        LastName = "León Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 9, 19),
                        PhoneNumber = "+520286429209",
                        Email = "miguelfernandoleonarce124@hotmail.com",
                        Username = "miguelfernando304",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelfernandoleonarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Christian",
                        LastName = "Higuera Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 7, 17),
                        PhoneNumber = "+521041709344",
                        Email = "juanchristianhigueragamez243@hotmail.com",
                        Username = "juanchristian523",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanchristianhigueragamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Joaquin",
                        LastName = "Castrejón Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 5, 12),
                        PhoneNumber = "+529643223553",
                        Email = "federicojoaquincastrejongonzali883@hotmail.com",
                        Username = "federicojoaquin405",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicojoaquincastrejongonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Gerardo",
                        LastName = "Enríquez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 2, 2),
                        PhoneNumber = "+524130557227",
                        Email = "gerardogerardoenriquezalvarez256@hotmail.com",
                        Username = "gerardogerardo110",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardogerardoenriquezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Ángel",
                        LastName = "Juárez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 3, 16),
                        PhoneNumber = "+522738260499",
                        Email = "manuelangeljuarezalvarez10@hotmail.com",
                        Username = "manuelangel327",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelangeljuarezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Gabriel",
                        LastName = "Higareda Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 2, 10),
                        PhoneNumber = "+523107314857",
                        Email = "fitzgeraldgabrielhigaredaconriquez487@hotmail.com",
                        Username = "fitzgeraldgabriel194",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldgabrielhigaredaconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Felipe",
                        LastName = "Gámez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 7, 11),
                        PhoneNumber = "+524185807447",
                        Email = "nicolasfelipegameznevarez695@hotmail.com",
                        Username = "nicolasfelipe572",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasfelipegameznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Sebastián",
                        LastName = "Conriquez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 6, 20),
                        PhoneNumber = "+523243857481",
                        Email = "fernandosebastianconriquezgamez802@hotmail.com",
                        Username = "fernandosebastian850",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandosebastianconriquezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Joaquin",
                        LastName = "Gómez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 10, 4),
                        PhoneNumber = "+520343708086",
                        Email = "danieljoaquingomezrodriguez128@hotmail.com",
                        Username = "danieljoaquin322",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieljoaquingomezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés José",
                        LastName = "Domínguez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 3, 12),
                        PhoneNumber = "+523005333702",
                        Email = "moisesjosedominguezgonzali364@hotmail.com",
                        Username = "moisesjose432",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesjosedominguezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Felipe",
                        LastName = "Juárez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 12, 26),
                        PhoneNumber = "+521328557442",
                        Email = "gerardofelipejuareznevarez893@hotmail.com",
                        Username = "gerardofelipe66",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofelipejuareznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Estéban",
                        LastName = "Bustamante Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 8, 11),
                        PhoneNumber = "+528907785452",
                        Email = "fabrizioestebanbustamantebustamante38@hotmail.com",
                        Username = "fabrizioesteban601",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioestebanbustamantebustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Luis",
                        LastName = "Jiménez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 9, 14),
                        PhoneNumber = "+521455648371",
                        Email = "juanluisjimenezmartinez209@hotmail.com",
                        Username = "juanluis221",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanluisjimenezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Leonel",
                        LastName = "Gonzalí Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 4, 23),
                        PhoneNumber = "+521205529307",
                        Email = "javierleonelgonzaliprado380@hotmail.com",
                        Username = "javierleonel62",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierleonelgonzaliprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Luis",
                        LastName = "Aguirre Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 4, 8),
                        PhoneNumber = "+528536186001",
                        Email = "leonelluisaguirremiranda980@hotmail.com",
                        Username = "leonelluis298",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelluisaguirremiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Rafaél",
                        LastName = "Prado Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 11, 23),
                        PhoneNumber = "+522708975014",
                        Email = "miguelrafaelpradogomez767@hotmail.com",
                        Username = "miguelrafael329",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelrafaelpradogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Carlos",
                        LastName = "Enríquez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 4, 2),
                        PhoneNumber = "+527992970259",
                        Email = "gabrielcarlosenriquezgomez610@hotmail.com",
                        Username = "gabrielcarlos552",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielcarlosenriquezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Carlos",
                        LastName = "Gonzalí Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 4, 10),
                        PhoneNumber = "+526820169124",
                        Email = "rafaelcarlosgonzalidominguez632@hotmail.com",
                        Username = "rafaelcarlos704",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelcarlosgonzalidominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Jhonatan",
                        LastName = "Prado Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 7, 15),
                        PhoneNumber = "+524848522991",
                        Email = "migueljhonatanpradoconriquez752@hotmail.com",
                        Username = "migueljhonatan331",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljhonatanpradoconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Amadeus",
                        LastName = "Trujillo Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 12, 21),
                        PhoneNumber = "+526142857180",
                        Email = "juanamadeustrujillojuarez369@hotmail.com",
                        Username = "juanamadeus579",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanamadeustrujillojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Arturo",
                        LastName = "Miranda Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 6, 7),
                        PhoneNumber = "+522243933662",
                        Email = "felipearturomirandafernandez446@hotmail.com",
                        Username = "felipearturo442",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipearturomirandafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier António",
                        LastName = "Higareda López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 11, 8),
                        PhoneNumber = "+520733168615",
                        Email = "javierantoniohigaredalopez787@hotmail.com",
                        Username = "javierantonio353",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierantoniohigaredalopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Sebastián",
                        LastName = "Aguirre Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 12, 18),
                        PhoneNumber = "+522987481493",
                        Email = "miguelsebastianaguirremartinez932@hotmail.com",
                        Username = "miguelsebastian556",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelsebastianaguirremartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Gabriel",
                        LastName = "González Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 1, 3),
                        PhoneNumber = "+529311622248",
                        Email = "josegabrielgonzalezfernandez213@hotmail.com",
                        Username = "josegabriel681",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josegabrielgonzalezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Felipe",
                        LastName = "Zavala Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 5, 22),
                        PhoneNumber = "+528625974620",
                        Email = "josefelipezavalagonzali117@hotmail.com",
                        Username = "josefelipe467",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefelipezavalagonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Gerardo",
                        LastName = "Prado Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 9, 17),
                        PhoneNumber = "+525388885634",
                        Email = "aarongerardopradocontreras516@hotmail.com",
                        Username = "aarongerardo578",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aarongerardopradocontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Alejandro",
                        LastName = "Conriquez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 5, 14),
                        PhoneNumber = "+528817122565",
                        Email = "fabrizioalejandroconriquezconriquez700@hotmail.com",
                        Username = "fabrizioalejandro986",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioalejandroconriquezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Daniel",
                        LastName = "Quintero Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 8, 23),
                        PhoneNumber = "+520898436317",
                        Email = "gerardodanielquinterocarrillo480@hotmail.com",
                        Username = "gerardodaniel837",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardodanielquinterocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Fitzgerald",
                        LastName = "Lastra Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 2, 17),
                        PhoneNumber = "+525203685473",
                        Email = "federicofitzgeraldlastrahigareda429@hotmail.com",
                        Username = "federicofitzgerald40",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofitzgeraldlastrahigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Alexander",
                        LastName = "Castrejón Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 5, 20),
                        PhoneNumber = "+520020246849",
                        Email = "rafaelalexandercastrejonmartinez589@hotmail.com",
                        Username = "rafaelalexander61",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelalexandercastrejonmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Óscar",
                        LastName = "López Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 8, 15),
                        PhoneNumber = "+522209666119",
                        Email = "jhonatanoscarlopezlastra686@hotmail.com",
                        Username = "jhonatanoscar890",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanoscarlopezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Rafaél",
                        LastName = "Miranda Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 8, 12),
                        PhoneNumber = "+524465710555",
                        Email = "joaquinrafaelmirandaarce240@hotmail.com",
                        Username = "joaquinrafael138",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinrafaelmirandaarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Moisés",
                        LastName = "Prado Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 1, 17),
                        PhoneNumber = "+528097930580",
                        Email = "gabrielmoisespradotrujillo186@hotmail.com",
                        Username = "gabrielmoises159",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielmoisespradotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "González Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 8, 1),
                        PhoneNumber = "+528216178841",
                        Email = "alejandronicolasgonzalezquintero748@hotmail.com",
                        Username = "alejandronicolas402",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolasgonzalezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Moisés",
                        LastName = "Gámez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 12, 20),
                        PhoneNumber = "+524334159550",
                        Email = "aaronmoisesgamezhiguera554@hotmail.com",
                        Username = "aaronmoises661",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmoisesgamezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Nicolás",
                        LastName = "Gámez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 11, 11),
                        PhoneNumber = "+520090198965",
                        Email = "danielnicolasgamezquintero108@hotmail.com",
                        Username = "danielnicolas386",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielnicolasgamezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Federico",
                        LastName = "Fernández Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 10, 24),
                        PhoneNumber = "+525099083351",
                        Email = "fabriziofedericofernandezfernandez456@hotmail.com",
                        Username = "fabriziofederico524",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziofedericofernandezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Miguel",
                        LastName = "Trujillo Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 3, 7),
                        PhoneNumber = "+523047562836",
                        Email = "leonelmigueltrujilloclaro101@hotmail.com",
                        Username = "leonelmiguel260",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelmigueltrujilloclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Amadeus",
                        LastName = "Higareda León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 11, 13),
                        PhoneNumber = "+521360936565",
                        Email = "gabrielamadeushigaredaleon814@hotmail.com",
                        Username = "gabrielamadeus268",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielamadeushigaredaleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Fabrizio",
                        LastName = "León Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 6, 13),
                        PhoneNumber = "+528054354023",
                        Email = "fernandofabrizioleongonzali516@hotmail.com",
                        Username = "fernandofabrizio563",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandofabrizioleongonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Ángel",
                        LastName = "Rodríguez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 6, 18),
                        PhoneNumber = "+528868789982",
                        Email = "danielangelrodriguezhiguera0@hotmail.com",
                        Username = "danielangel0",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielangelrodriguezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Trujillo Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 11, 14),
                        PhoneNumber = "+528874768507",
                        Email = "moisesestebantrujillobustamante832@hotmail.com",
                        Username = "moisesesteban94",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebantrujillobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás José",
                        LastName = "Claro Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 10, 6),
                        PhoneNumber = "+522773180075",
                        Email = "nicolasjoseclarobustamante243@hotmail.com",
                        Username = "nicolasjose61",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasjoseclarobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Sebastián",
                        LastName = "Higuera Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 12, 23),
                        PhoneNumber = "+526375045707",
                        Email = "juansebastianhigueraquintero769@hotmail.com",
                        Username = "juansebastian970",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juansebastianhigueraquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro António",
                        LastName = "Rodríguez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 9, 26),
                        PhoneNumber = "+529591060298",
                        Email = "alejandroantoniorodriguezdominguez752@hotmail.com",
                        Username = "alejandroantonio32",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroantoniorodriguezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Aarón",
                        LastName = "Contreras González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 6, 22),
                        PhoneNumber = "+525177990183",
                        Email = "antonioaaroncontrerasgonzalez632@hotmail.com",
                        Username = "antonioaaron654",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioaaroncontrerasgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Amadeus",
                        LastName = "Quintero Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 2, 13),
                        PhoneNumber = "+527549942467",
                        Email = "leonelamadeusquinteroprado587@hotmail.com",
                        Username = "leonelamadeus315",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelamadeusquinteroprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando António",
                        LastName = "Gonzalí Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 3),
                        PhoneNumber = "+529932714841",
                        Email = "fernandoantoniogonzalijuarez253@hotmail.com",
                        Username = "fernandoantonio596",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoantoniogonzalijuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Alejandro",
                        LastName = "Claro Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 10, 22),
                        PhoneNumber = "+526700766398",
                        Email = "jhonatanalejandroclarorodriguez471@hotmail.com",
                        Username = "jhonatanalejandro150",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanalejandroclarorodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Javier",
                        LastName = "Juárez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 10, 9),
                        PhoneNumber = "+521061608643",
                        Email = "oscarjavierjuarezgomez742@hotmail.com",
                        Username = "oscarjavier186",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarjavierjuarezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Gerardo",
                        LastName = "Zavala Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 9, 4),
                        PhoneNumber = "+520737208767",
                        Email = "fabriziogerardozavalatrujillo433@hotmail.com",
                        Username = "fabriziogerardo824",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziogerardozavalatrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Aarón",
                        LastName = "Nevárez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 10, 19),
                        PhoneNumber = "+522152040391",
                        Email = "sebastianaaronnevarezbustamante329@hotmail.com",
                        Username = "sebastianaaron455",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianaaronnevarezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Estéban",
                        LastName = "Aguirre López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 4, 12),
                        PhoneNumber = "+523710136020",
                        Email = "joaquinestebanaguirrelopez633@hotmail.com",
                        Username = "joaquinesteban708",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinestebanaguirrelopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Sebastián",
                        LastName = "Fernández Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 6, 3),
                        PhoneNumber = "+520077097947",
                        Email = "carlossebastianfernandezbustamante421@hotmail.com",
                        Username = "carlossebastian828",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlossebastianfernandezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Ángel",
                        LastName = "Zavala Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 12, 24),
                        PhoneNumber = "+523502717021",
                        Email = "fabrizioangelzavalaperez998@hotmail.com",
                        Username = "fabrizioangel268",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioangelzavalaperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Felipe",
                        LastName = "Aguirre Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 7, 22),
                        PhoneNumber = "+522026105653",
                        Email = "alejandrofelipeaguirreclaro36@hotmail.com",
                        Username = "alejandrofelipe392",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofelipeaguirreclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Manuel",
                        LastName = "Gonzalí Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 7, 25),
                        PhoneNumber = "+526261991130",
                        Email = "felipemanuelgonzalijuarez334@hotmail.com",
                        Username = "felipemanuel731",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipemanuelgonzalijuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Gerardo",
                        LastName = "Álvarez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 6, 18),
                        PhoneNumber = "+526386674826",
                        Email = "amadeusgerardoalvarezdominguez505@hotmail.com",
                        Username = "amadeusgerardo40",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusgerardoalvarezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Aarón",
                        LastName = "Domínguez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 10, 11),
                        PhoneNumber = "+525624318245",
                        Email = "fabrizioaarondominguezcastrejon587@hotmail.com",
                        Username = "fabrizioaaron256",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioaarondominguezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Juan",
                        LastName = "Castrejón López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 7, 5),
                        PhoneNumber = "+523329735989",
                        Email = "amadeusjuancastrejonlopez719@hotmail.com",
                        Username = "amadeusjuan715",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusjuancastrejonlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Nicolás",
                        LastName = "Gonzalí Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 5, 10),
                        PhoneNumber = "+521223274682",
                        Email = "rafaelnicolasgonzalicarrillo661@hotmail.com",
                        Username = "rafaelnicolas213",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelnicolasgonzalicarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Arturo",
                        LastName = "Nevárez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 11, 18),
                        PhoneNumber = "+524813490751",
                        Email = "eliazararturonevareztrujillo364@hotmail.com",
                        Username = "eliazararturo763",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazararturonevareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Leonel",
                        LastName = "Quintero Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 12, 14),
                        PhoneNumber = "+525423376310",
                        Email = "oscarleonelquinteroarce451@hotmail.com",
                        Username = "oscarleonel659",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarleonelquinteroarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Eliazar",
                        LastName = "González Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 2, 4),
                        PhoneNumber = "+521493750522",
                        Email = "fitzgeraldeliazargonzalezprado744@hotmail.com",
                        Username = "fitzgeraldeliazar582",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldeliazargonzalezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Óscar",
                        LastName = "Fernández Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 8, 7),
                        PhoneNumber = "+527483936590",
                        Email = "sebastianoscarfernandezgonzali690@hotmail.com",
                        Username = "sebastianoscar671",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianoscarfernandezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Aarón",
                        LastName = "Higareda Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 12, 7),
                        PhoneNumber = "+521934437157",
                        Email = "javieraaronhigaredacontreras551@hotmail.com",
                        Username = "javieraaron317",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieraaronhigaredacontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Carlos",
                        LastName = "Aguirre Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 7, 20),
                        PhoneNumber = "+526199619499",
                        Email = "rafaelcarlosaguirremiranda233@hotmail.com",
                        Username = "rafaelcarlos133",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelcarlosaguirremiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Federico",
                        LastName = "Ramones Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 10, 11),
                        PhoneNumber = "+529675004456",
                        Email = "christianfedericoramoneslastra375@hotmail.com",
                        Username = "christianfederico336",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfedericoramoneslastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Jhonatan",
                        LastName = "Árce Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 2, 2),
                        PhoneNumber = "+523514636640",
                        Email = "oscarjhonatanarcelastra563@hotmail.com",
                        Username = "oscarjhonatan581",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarjhonatanarcelastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Arturo",
                        LastName = "González Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 11, 20),
                        PhoneNumber = "+522849617035",
                        Email = "rafaelarturogonzalezdominguez656@hotmail.com",
                        Username = "rafaelarturo242",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelarturogonzalezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Javier",
                        LastName = "Juárez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 9, 18),
                        PhoneNumber = "+524201487799",
                        Email = "estebanjavierjuarezgomez78@hotmail.com",
                        Username = "estebanjavier893",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanjavierjuarezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Joaquin",
                        LastName = "Enríquez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 1, 18),
                        PhoneNumber = "+523016586976",
                        Email = "luisjoaquinenriquezjuarez504@hotmail.com",
                        Username = "luisjoaquin634",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjoaquinenriquezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Federico",
                        LastName = "Higuera Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 7, 11),
                        PhoneNumber = "+527847167387",
                        Email = "josefedericohiguerahigareda596@hotmail.com",
                        Username = "josefederico792",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefedericohiguerahigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Aarón",
                        LastName = "Trujillo Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 24),
                        PhoneNumber = "+527007871898",
                        Email = "luisaarontrujillobustamante453@hotmail.com",
                        Username = "luisaaron223",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisaarontrujillobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Jhonatan",
                        LastName = "Prado Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 2, 23),
                        PhoneNumber = "+521305113294",
                        Email = "rafaeljhonatanpradoenriquez454@hotmail.com",
                        Username = "rafaeljhonatan169",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljhonatanpradoenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Fernando",
                        LastName = "Fernández Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 8, 7),
                        PhoneNumber = "+522413443926",
                        Email = "nicolasfernandofernandezramones433@hotmail.com",
                        Username = "nicolasfernando26",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasfernandofernandezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Nicolás",
                        LastName = "Conriquez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 9, 17),
                        PhoneNumber = "+520374710042",
                        Email = "juannicolasconriquezjimenez911@hotmail.com",
                        Username = "juannicolas205",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juannicolasconriquezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Rafaél",
                        LastName = "Martínez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 9, 17),
                        PhoneNumber = "+523191383481",
                        Email = "oscarrafaelmartinezaguirre655@hotmail.com",
                        Username = "oscarrafael254",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarrafaelmartinezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Juan",
                        LastName = "Conriquez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 4, 1),
                        PhoneNumber = "+525913734744",
                        Email = "estebanjuanconriquezenriquez386@hotmail.com",
                        Username = "estebanjuan578",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanjuanconriquezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Moisés",
                        LastName = "Ramones Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 10, 18),
                        PhoneNumber = "+529765857124",
                        Email = "joaquinmoisesramonesgonzali954@hotmail.com",
                        Username = "joaquinmoises487",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinmoisesramonesgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Leonel",
                        LastName = "Claro León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 6, 22),
                        PhoneNumber = "+521577478389",
                        Email = "manuelleonelclaroleon62@hotmail.com",
                        Username = "manuelleonel103",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelleonelclaroleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Christian",
                        LastName = "León Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 6, 15),
                        PhoneNumber = "+526279563633",
                        Email = "oscarchristianleongamez163@hotmail.com",
                        Username = "oscarchristian78",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarchristianleongamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Ángel",
                        LastName = "Ramones Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 11, 20),
                        PhoneNumber = "+528482799056",
                        Email = "arturoangelramonescontreras522@hotmail.com",
                        Username = "arturoangel250",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoangelramonescontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Eliazar",
                        LastName = "Gonzalí Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 12, 23),
                        PhoneNumber = "+529824205143",
                        Email = "javiereliazargonzalidominguez5@hotmail.com",
                        Username = "javiereliazar791",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiereliazargonzalidominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Fernando",
                        LastName = "Quintero Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 10, 25),
                        PhoneNumber = "+523893524155",
                        Email = "rafaelfernandoquinterojuarez969@hotmail.com",
                        Username = "rafaelfernando322",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfernandoquinterojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Rafaél",
                        LastName = "Gonzalí Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 2, 26),
                        PhoneNumber = "+522374556585",
                        Email = "miguelrafaelgonzaliclaro450@hotmail.com",
                        Username = "miguelrafael180",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelrafaelgonzaliclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Joaquin",
                        LastName = "Enríquez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 11, 24),
                        PhoneNumber = "+529420093034",
                        Email = "alexanderjoaquinenriquezalvarez898@hotmail.com",
                        Username = "alexanderjoaquin102",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjoaquinenriquezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Javier",
                        LastName = "Claro Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 2, 2),
                        PhoneNumber = "+520306850064",
                        Email = "fabriziojavierclaromiranda586@hotmail.com",
                        Username = "fabriziojavier595",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziojavierclaromiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Fitzgerald",
                        LastName = "Gonzalí Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 12, 1),
                        PhoneNumber = "+520159868613",
                        Email = "javierfitzgeraldgonzalilastra723@hotmail.com",
                        Username = "javierfitzgerald978",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierfitzgeraldgonzalilastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Fabrizio",
                        LastName = "Jiménez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 1, 12),
                        PhoneNumber = "+525710528299",
                        Email = "eliazarfabriziojimenezleon218@hotmail.com",
                        Username = "eliazarfabrizio552",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfabriziojimenezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Sebastián",
                        LastName = "Quintero Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 9, 12),
                        PhoneNumber = "+527350222226",
                        Email = "nicolassebastianquinteroramones55@hotmail.com",
                        Username = "nicolassebastian430",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolassebastianquinteroramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Amadeus",
                        LastName = "Higareda Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 5, 17),
                        PhoneNumber = "+521195600915",
                        Email = "eliazaramadeushigaredalastra649@hotmail.com",
                        Username = "eliazaramadeus928",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazaramadeushigaredalastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Manuel",
                        LastName = "Aguirre Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 4, 11),
                        PhoneNumber = "+522250035932",
                        Email = "fabriziomanuelaguirrefernandez561@hotmail.com",
                        Username = "fabriziomanuel119",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziomanuelaguirrefernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Gabriel",
                        LastName = "López Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 2, 23),
                        PhoneNumber = "+520585746131",
                        Email = "antoniogabriellopezdominguez577@hotmail.com",
                        Username = "antoniogabriel663",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniogabriellopezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Carlos",
                        LastName = "Bustamante Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 2, 13),
                        PhoneNumber = "+524500344138",
                        Email = "fabriziocarlosbustamanteaguirre451@hotmail.com",
                        Username = "fabriziocarlos225",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziocarlosbustamanteaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Eliazar",
                        LastName = "Álvarez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 4, 18),
                        PhoneNumber = "+521462577836",
                        Email = "fitzgeraldeliazaralvarezmartinez598@hotmail.com",
                        Username = "fitzgeraldeliazar141",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldeliazaralvarezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Amadeus",
                        LastName = "Higareda Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 12, 14),
                        PhoneNumber = "+524703190562",
                        Email = "aaronamadeushigaredatrujillo312@hotmail.com",
                        Username = "aaronamadeus274",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronamadeushigaredatrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Rafaél",
                        LastName = "Miranda Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 5, 7),
                        PhoneNumber = "+527344996013",
                        Email = "federicorafaelmirandaaguirre311@hotmail.com",
                        Username = "federicorafael636",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicorafaelmirandaaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Sebastián",
                        LastName = "Higareda Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 4, 26),
                        PhoneNumber = "+524177584998",
                        Email = "juansebastianhigaredarodriguez661@hotmail.com",
                        Username = "juansebastian468",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juansebastianhigaredarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Arturo",
                        LastName = "Conriquez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 4, 17),
                        PhoneNumber = "+527881304946",
                        Email = "gerardoarturoconriquezquintero140@hotmail.com",
                        Username = "gerardoarturo577",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardoarturoconriquezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Óscar",
                        LastName = "Aguirre Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 2, 7),
                        PhoneNumber = "+524517144457",
                        Email = "carlososcaraguirreenriquez960@hotmail.com",
                        Username = "carlososcar863",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlososcaraguirreenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Christian",
                        LastName = "Árce Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 9, 23),
                        PhoneNumber = "+523830671461",
                        Email = "amadeuschristianarceaguirre570@hotmail.com",
                        Username = "amadeuschristian385",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeuschristianarceaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Javier",
                        LastName = "Rodríguez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 1, 24),
                        PhoneNumber = "+527770140901",
                        Email = "alejandrojavierrodriguezenriquez2@hotmail.com",
                        Username = "alejandrojavier41",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrojavierrodriguezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Óscar",
                        LastName = "Higuera Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 7, 19),
                        PhoneNumber = "+523340434043",
                        Email = "rafaeloscarhigueraconriquez624@hotmail.com",
                        Username = "rafaeloscar387",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeloscarhigueraconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Carlos",
                        LastName = "González Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 5, 21),
                        PhoneNumber = "+527906621497",
                        Email = "gerardocarlosgonzalezalvarez302@hotmail.com",
                        Username = "gerardocarlos160",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardocarlosgonzalezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Leonel",
                        LastName = "Enríquez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 12, 5),
                        PhoneNumber = "+523959209370",
                        Email = "jhonatanleonelenriquezleon769@hotmail.com",
                        Username = "jhonatanleonel26",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanleonelenriquezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Manuel",
                        LastName = "Carrillo Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 1, 20),
                        PhoneNumber = "+525179912440",
                        Email = "alexandermanuelcarrillolastra861@hotmail.com",
                        Username = "alexandermanuel103",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandermanuelcarrillolastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Juan",
                        LastName = "Lastra Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 10, 19),
                        PhoneNumber = "+526688761363",
                        Email = "federicojuanlastrahiguera165@hotmail.com",
                        Username = "federicojuan403",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicojuanlastrahiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Nicolás",
                        LastName = "Gámez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 8, 27),
                        PhoneNumber = "+528147377371",
                        Email = "josenicolasgamezprado164@hotmail.com",
                        Username = "josenicolas29",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josenicolasgamezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Christian",
                        LastName = "Claro Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 6, 23),
                        PhoneNumber = "+525891206023",
                        Email = "christianchristianclaroquintero468@hotmail.com",
                        Username = "christianchristian909",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianchristianclaroquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Carlos",
                        LastName = "Conriquez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 7, 22),
                        PhoneNumber = "+526046513727",
                        Email = "aaroncarlosconriquezcastrejon866@hotmail.com",
                        Username = "aaroncarlos54",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaroncarlosconriquezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Rafaél",
                        LastName = "Pérez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 11, 20),
                        PhoneNumber = "+526858815472",
                        Email = "federicorafaelperezarce702@hotmail.com",
                        Username = "federicorafael521",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicorafaelperezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Manuel",
                        LastName = "Álvarez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 6, 23),
                        PhoneNumber = "+526187479337",
                        Email = "oscarmanuelalvarezcarrillo569@hotmail.com",
                        Username = "oscarmanuel291",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarmanuelalvarezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Arturo",
                        LastName = "Higareda Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 12, 27),
                        PhoneNumber = "+523356110409",
                        Email = "carlosarturohigaredaclaro42@hotmail.com",
                        Username = "carlosarturo904",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosarturohigaredaclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Eliazar",
                        LastName = "Lastra Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 9, 18),
                        PhoneNumber = "+527291155473",
                        Email = "luiseliazarlastrafernandez351@hotmail.com",
                        Username = "luiseliazar614",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luiseliazarlastrafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Rafaél",
                        LastName = "Conriquez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 8, 2),
                        PhoneNumber = "+527475516191",
                        Email = "gabrielrafaelconriquezlopez553@hotmail.com",
                        Username = "gabrielrafael829",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielrafaelconriquezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Gabriel",
                        LastName = "Quintero Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 12, 6),
                        PhoneNumber = "+529390612233",
                        Email = "alexandergabrielquinterorodriguez740@hotmail.com",
                        Username = "alexandergabriel323",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandergabrielquinterorodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Gerardo",
                        LastName = "Zavala Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 4, 11),
                        PhoneNumber = "+529127663263",
                        Email = "fernandogerardozavalamartinez397@hotmail.com",
                        Username = "fernandogerardo383",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandogerardozavalamartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Sebastián",
                        LastName = "Juárez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 3, 9),
                        PhoneNumber = "+521857625743",
                        Email = "oscarsebastianjuarezalvarez588@hotmail.com",
                        Username = "oscarsebastian169",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarsebastianjuarezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Luis",
                        LastName = "Castrejón Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 9, 7),
                        PhoneNumber = "+525099119657",
                        Email = "gabrielluiscastrejoncastrejon629@hotmail.com",
                        Username = "gabrielluis937",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielluiscastrejoncastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Sebastián",
                        LastName = "Enríquez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 8, 7),
                        PhoneNumber = "+520855329238",
                        Email = "fernandosebastianenriquezlastra358@hotmail.com",
                        Username = "fernandosebastian353",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandosebastianenriquezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Aarón",
                        LastName = "Pérez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 12, 27),
                        PhoneNumber = "+527435740168",
                        Email = "alexanderaaronperezgonzali488@hotmail.com",
                        Username = "alexanderaaron798",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderaaronperezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Nicolás",
                        LastName = "Enríquez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 9, 18),
                        PhoneNumber = "+523801697107",
                        Email = "carlosnicolasenriquezdominguez95@hotmail.com",
                        Username = "carlosnicolas234",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosnicolasenriquezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Leonel",
                        LastName = "Enríquez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 10, 23),
                        PhoneNumber = "+524873790355",
                        Email = "angelleonelenriquezarce627@hotmail.com",
                        Username = "angelleonel187",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelleonelenriquezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél José",
                        LastName = "Fernández Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 7, 25),
                        PhoneNumber = "+523530003773",
                        Email = "rafaeljosefernandeznevarez579@hotmail.com",
                        Username = "rafaeljose940",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljosefernandeznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander António",
                        LastName = "Lastra Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 4, 12),
                        PhoneNumber = "+527130088899",
                        Email = "alexanderantoniolastraquintero410@hotmail.com",
                        Username = "alexanderantonio854",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderantoniolastraquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Eliazar",
                        LastName = "Pérez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 10, 24),
                        PhoneNumber = "+521504885151",
                        Email = "nicolaseliazarperezjimenez606@hotmail.com",
                        Username = "nicolaseliazar254",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolaseliazarperezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés António",
                        LastName = "Lastra Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 2, 26),
                        PhoneNumber = "+520451894141",
                        Email = "moisesantoniolastraenriquez205@hotmail.com",
                        Username = "moisesantonio358",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesantoniolastraenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Eliazar",
                        LastName = "Carrillo Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 6, 1),
                        PhoneNumber = "+523835834006",
                        Email = "carloseliazarcarrillojimenez401@hotmail.com",
                        Username = "carloseliazar499",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carloseliazarcarrillojimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Arturo",
                        LastName = "Aguirre López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 9, 16),
                        PhoneNumber = "+521334489802",
                        Email = "miguelarturoaguirrelopez682@hotmail.com",
                        Username = "miguelarturo402",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelarturoaguirrelopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Aarón",
                        LastName = "Carrillo Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 3, 18),
                        PhoneNumber = "+523819068699",
                        Email = "alejandroaaroncarrillobustamante256@hotmail.com",
                        Username = "alejandroaaron239",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroaaroncarrillobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald António",
                        LastName = "Trujillo Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 7, 16),
                        PhoneNumber = "+521349570463",
                        Email = "fitzgeraldantoniotrujilloquintero462@hotmail.com",
                        Username = "fitzgeraldantonio454",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldantoniotrujilloquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Óscar",
                        LastName = "Quintero Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 1, 4),
                        PhoneNumber = "+526163185717",
                        Email = "estebanoscarquinterojimenez142@hotmail.com",
                        Username = "estebanoscar122",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanoscarquinterojimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald António",
                        LastName = "Quintero Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 1, 5),
                        PhoneNumber = "+525843369077",
                        Email = "fitzgeraldantonioquinterohigareda678@hotmail.com",
                        Username = "fitzgeraldantonio515",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldantonioquinterohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Javier",
                        LastName = "Árce Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 5, 19),
                        PhoneNumber = "+521027675377",
                        Email = "felipejavierarceperez158@hotmail.com",
                        Username = "felipejavier513",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipejavierarceperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Alejandro",
                        LastName = "Lastra Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 7, 26),
                        PhoneNumber = "+523307615948",
                        Email = "carlosalejandrolastracontreras234@hotmail.com",
                        Username = "carlosalejandro891",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosalejandrolastracontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Aarón",
                        LastName = "Enríquez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 2, 7),
                        PhoneNumber = "+525050973323",
                        Email = "manuelaaronenriquezhiguera347@hotmail.com",
                        Username = "manuelaaron572",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelaaronenriquezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Gerardo",
                        LastName = "Fernández Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 2, 12),
                        PhoneNumber = "+524353460598",
                        Email = "christiangerardofernandezprado342@hotmail.com",
                        Username = "christiangerardo54",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiangerardofernandezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Joaquin",
                        LastName = "Juárez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 11, 15),
                        PhoneNumber = "+520850625573",
                        Email = "gabrieljoaquinjuarezprado379@hotmail.com",
                        Username = "gabrieljoaquin100",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrieljoaquinjuarezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Aarón",
                        LastName = "Higuera Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 12, 4),
                        PhoneNumber = "+523243382880",
                        Email = "carlosaaronhigueragonzali539@hotmail.com",
                        Username = "carlosaaron712",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosaaronhigueragonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Daniel",
                        LastName = "Álvarez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 1, 22),
                        PhoneNumber = "+524428771860",
                        Email = "amadeusdanielalvarezarce75@hotmail.com",
                        Username = "amadeusdaniel920",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusdanielalvarezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Federico",
                        LastName = "León Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 1),
                        PhoneNumber = "+528805770986",
                        Email = "federicofedericoleongamez363@hotmail.com",
                        Username = "federicofederico648",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofedericoleongamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Estéban",
                        LastName = "Claro Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 4, 11),
                        PhoneNumber = "+527826274078",
                        Email = "felipeestebanclarogamez983@hotmail.com",
                        Username = "felipeesteban621",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeestebanclarogamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Óscar",
                        LastName = "Nevárez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 12, 2),
                        PhoneNumber = "+525098980302",
                        Email = "migueloscarnevarezzavala235@hotmail.com",
                        Username = "migueloscar999",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueloscarnevarezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Javier",
                        LastName = "Álvarez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 9, 11),
                        PhoneNumber = "+529380503549",
                        Email = "manueljavieralvarezcarrillo829@hotmail.com",
                        Username = "manueljavier503",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueljavieralvarezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Gabriel",
                        LastName = "Domínguez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 9, 8),
                        PhoneNumber = "+527865154304",
                        Email = "fabriziogabrieldominguezgonzali965@hotmail.com",
                        Username = "fabriziogabriel591",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziogabrieldominguezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Juan",
                        LastName = "Nevárez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 7, 10),
                        PhoneNumber = "+525965931653",
                        Email = "eliazarjuannevarezperez460@hotmail.com",
                        Username = "eliazarjuan528",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarjuannevarezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Joaquin",
                        LastName = "Conriquez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 4),
                        PhoneNumber = "+525742646788",
                        Email = "amadeusjoaquinconriquezaguirre886@hotmail.com",
                        Username = "amadeusjoaquin277",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusjoaquinconriquezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Jhonatan",
                        LastName = "Martínez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 2, 20),
                        PhoneNumber = "+523348911216",
                        Email = "arturojhonatanmartinezrodriguez579@hotmail.com",
                        Username = "arturojhonatan745",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturojhonatanmartinezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Christian",
                        LastName = "Jiménez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 8, 10),
                        PhoneNumber = "+527744417772",
                        Email = "estebanchristianjimenezgamez483@hotmail.com",
                        Username = "estebanchristian420",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanchristianjimenezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Amadeus",
                        LastName = "Contreras López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 5, 13),
                        PhoneNumber = "+523741475450",
                        Email = "alexanderamadeuscontreraslopez138@hotmail.com",
                        Username = "alexanderamadeus2",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderamadeuscontreraslopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Manuel",
                        LastName = "Miranda Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 3, 19),
                        PhoneNumber = "+525051750136",
                        Email = "sebastianmanuelmirandazavala958@hotmail.com",
                        Username = "sebastianmanuel674",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianmanuelmirandazavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Rafaél",
                        LastName = "González Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 1, 18),
                        PhoneNumber = "+520170578623",
                        Email = "angelrafaelgonzalezcarrillo458@hotmail.com",
                        Username = "angelrafael28",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelrafaelgonzalezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Joaquin",
                        LastName = "Bustamante Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 8, 21),
                        PhoneNumber = "+528667692887",
                        Email = "jhonatanjoaquinbustamantearce466@hotmail.com",
                        Username = "jhonatanjoaquin707",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanjoaquinbustamantearce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Estéban",
                        LastName = "Árce Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 1, 4),
                        PhoneNumber = "+520592091503",
                        Email = "rafaelestebanarceperez125@hotmail.com",
                        Username = "rafaelesteban633",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelestebanarceperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Gerardo",
                        LastName = "Lastra Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 1, 23),
                        PhoneNumber = "+521144859089",
                        Email = "christiangerardolastracastrejon172@hotmail.com",
                        Username = "christiangerardo490",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiangerardolastracastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Eliazar",
                        LastName = "Gonzalí Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 11, 26),
                        PhoneNumber = "+524725049601",
                        Email = "migueleliazargonzaliarce954@hotmail.com",
                        Username = "migueleliazar360",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueleliazargonzaliarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Miguel",
                        LastName = "Juárez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 11, 2),
                        PhoneNumber = "+521893152683",
                        Email = "estebanmigueljuarezcontreras111@hotmail.com",
                        Username = "estebanmiguel107",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanmigueljuarezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Joaquin",
                        LastName = "López Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 2, 21),
                        PhoneNumber = "+524608344512",
                        Email = "fabriziojoaquinlopezmiranda622@hotmail.com",
                        Username = "fabriziojoaquin688",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziojoaquinlopezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Joaquin",
                        LastName = "Ramones Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 11, 9),
                        PhoneNumber = "+527020446110",
                        Email = "eliazarjoaquinramonesjimenez639@hotmail.com",
                        Username = "eliazarjoaquin237",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarjoaquinramonesjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Christian",
                        LastName = "Árce Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 8, 3),
                        PhoneNumber = "+529850266556",
                        Email = "christianchristianarceperez825@hotmail.com",
                        Username = "christianchristian507",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianchristianarceperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "Contreras Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 6, 18),
                        PhoneNumber = "+529553428449",
                        Email = "alejandronicolascontrerasgonzali328@hotmail.com",
                        Username = "alejandronicolas498",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolascontrerasgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Alexander",
                        LastName = "Quintero Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 7, 19),
                        PhoneNumber = "+528087815831",
                        Email = "christianalexanderquinterocarrillo874@hotmail.com",
                        Username = "christianalexander425",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianalexanderquinterocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Aarón",
                        LastName = "Ramones Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 8, 12),
                        PhoneNumber = "+522519725581",
                        Email = "sebastianaaronramonesrodriguez912@hotmail.com",
                        Username = "sebastianaaron671",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianaaronramonesrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Amadeus",
                        LastName = "Castrejón Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 9, 11),
                        PhoneNumber = "+526447195926",
                        Email = "angelamadeuscastrejonjuarez531@hotmail.com",
                        Username = "angelamadeus683",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelamadeuscastrejonjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel José",
                        LastName = "Juárez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 3, 15),
                        PhoneNumber = "+522276799232",
                        Email = "danieljosejuarezprado74@hotmail.com",
                        Username = "danieljose7",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieljosejuarezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Leonel",
                        LastName = "González Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 3, 22),
                        PhoneNumber = "+525325803324",
                        Email = "alejandroleonelgonzalezhigareda785@hotmail.com",
                        Username = "alejandroleonel841",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroleonelgonzalezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Moisés",
                        LastName = "Gámez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 6, 13),
                        PhoneNumber = "+527498280783",
                        Email = "sebastianmoisesgamezdominguez793@hotmail.com",
                        Username = "sebastianmoises22",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianmoisesgamezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Fabrizio",
                        LastName = "Zavala Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 10, 20),
                        PhoneNumber = "+525723416782",
                        Email = "javierfabriziozavalafernandez770@hotmail.com",
                        Username = "javierfabrizio837",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierfabriziozavalafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Luis",
                        LastName = "Pérez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 3, 6),
                        PhoneNumber = "+523379839961",
                        Email = "nicolasluisperezrodriguez700@hotmail.com",
                        Username = "nicolasluis522",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasluisperezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Christian",
                        LastName = "Miranda Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 2, 10),
                        PhoneNumber = "+528950572275",
                        Email = "alexanderchristianmirandaconriquez278@hotmail.com",
                        Username = "alexanderchristian295",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderchristianmirandaconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian António",
                        LastName = "Claro Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 6, 24),
                        PhoneNumber = "+527310133239",
                        Email = "christianantonioclarocastrejon106@hotmail.com",
                        Username = "christianantonio822",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianantonioclarocastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Manuel",
                        LastName = "López Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 6, 17),
                        PhoneNumber = "+522120872396",
                        Email = "felipemanuellopezgomez372@hotmail.com",
                        Username = "felipemanuel968",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipemanuellopezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Nicolás",
                        LastName = "Quintero Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 10, 7),
                        PhoneNumber = "+523532239577",
                        Email = "carlosnicolasquinterojimenez186@hotmail.com",
                        Username = "carlosnicolas718",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosnicolasquinterojimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Óscar",
                        LastName = "González Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 7, 19),
                        PhoneNumber = "+525108221941",
                        Email = "joseoscargonzaleznevarez58@hotmail.com",
                        Username = "joseoscar874",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joseoscargonzaleznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Alejandro",
                        LastName = "Quintero Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 2, 3),
                        PhoneNumber = "+525619068628",
                        Email = "miguelalejandroquinterojuarez451@hotmail.com",
                        Username = "miguelalejandro477",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelalejandroquinterojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Eliazar",
                        LastName = "Árce López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 5, 10),
                        PhoneNumber = "+521009831504",
                        Email = "gabrieleliazararcelopez257@hotmail.com",
                        Username = "gabrieleliazar22",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrieleliazararcelopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando António",
                        LastName = "Gonzalí Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 5, 26),
                        PhoneNumber = "+526170407053",
                        Email = "fernandoantoniogonzaliaguirre720@hotmail.com",
                        Username = "fernandoantonio742",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoantoniogonzaliaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Fitzgerald",
                        LastName = "Pérez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 11, 6),
                        PhoneNumber = "+526637605857",
                        Email = "fabriziofitzgeraldperezhiguera344@hotmail.com",
                        Username = "fabriziofitzgerald768",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziofitzgeraldperezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Fernando",
                        LastName = "Quintero Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 12, 16),
                        PhoneNumber = "+527719443046",
                        Email = "sebastianfernandoquinteromartinez928@hotmail.com",
                        Username = "sebastianfernando17",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianfernandoquinteromartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Miguel",
                        LastName = "Pérez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 9, 15),
                        PhoneNumber = "+523100654831",
                        Email = "javiermiguelperezenriquez602@hotmail.com",
                        Username = "javiermiguel942",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiermiguelperezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fernando",
                        LastName = "Domínguez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 9, 17),
                        PhoneNumber = "+526337769465",
                        Email = "danielfernandodomingueznevarez277@hotmail.com",
                        Username = "danielfernando436",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfernandodomingueznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Fernando",
                        LastName = "Jiménez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 2, 8),
                        PhoneNumber = "+523331221459",
                        Email = "christianfernandojimenezrodriguez62@hotmail.com",
                        Username = "christianfernando68",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfernandojimenezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Alejandro",
                        LastName = "Jiménez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 12, 26),
                        PhoneNumber = "+529837533548",
                        Email = "fitzgeraldalejandrojimenezdominguez642@hotmail.com",
                        Username = "fitzgeraldalejandro563",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldalejandrojimenezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Rafaél",
                        LastName = "González Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 3, 22),
                        PhoneNumber = "+525020972191",
                        Email = "fabriziorafaelgonzalezgonzali370@hotmail.com",
                        Username = "fabriziorafael339",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziorafaelgonzalezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Daniel",
                        LastName = "Castrejón Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 2, 9),
                        PhoneNumber = "+521716599907",
                        Email = "migueldanielcastrejonjuarez352@hotmail.com",
                        Username = "migueldaniel103",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueldanielcastrejonjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Luis",
                        LastName = "López Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 2, 27),
                        PhoneNumber = "+525562398328",
                        Email = "gabrielluislopezhigareda630@hotmail.com",
                        Username = "gabrielluis597",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielluislopezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Daniel",
                        LastName = "Higuera Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 6, 26),
                        PhoneNumber = "+524772868446",
                        Email = "javierdanielhigueramartinez177@hotmail.com",
                        Username = "javierdaniel595",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierdanielhigueramartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Leonel",
                        LastName = "Pérez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 4, 12),
                        PhoneNumber = "+522013523402",
                        Email = "arturoleonelperezbustamante221@hotmail.com",
                        Username = "arturoleonel491",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoleonelperezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Estéban",
                        LastName = "Conriquez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 12, 19),
                        PhoneNumber = "+526749963223",
                        Email = "christianestebanconriquezalvarez582@hotmail.com",
                        Username = "christianesteban678",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianestebanconriquezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Estéban",
                        LastName = "Zavala Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 1, 26),
                        PhoneNumber = "+526996644080",
                        Email = "alexanderestebanzavalacarrillo612@hotmail.com",
                        Username = "alexanderesteban190",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderestebanzavalacarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Estéban",
                        LastName = "Quintero Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 7, 5),
                        PhoneNumber = "+527882619413",
                        Email = "federicoestebanquinterocarrillo247@hotmail.com",
                        Username = "federicoesteban933",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoestebanquinterocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Ángel",
                        LastName = "Enríquez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 6, 5),
                        PhoneNumber = "+520262162221",
                        Email = "joseangelenriquezgamez106@hotmail.com",
                        Username = "joseangel508",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joseangelenriquezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Arturo",
                        LastName = "Bustamante López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 11, 4),
                        PhoneNumber = "+529152560312",
                        Email = "nicolasarturobustamantelopez620@hotmail.com",
                        Username = "nicolasarturo498",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasarturobustamantelopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Gabriel",
                        LastName = "Higareda Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 12, 25),
                        PhoneNumber = "+527500055624",
                        Email = "leonelgabrielhigaredalastra927@hotmail.com",
                        Username = "leonelgabriel150",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelgabrielhigaredalastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Amadeus",
                        LastName = "Conriquez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 10, 5),
                        PhoneNumber = "+526196102159",
                        Email = "alexanderamadeusconriquezlopez691@hotmail.com",
                        Username = "alexanderamadeus484",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderamadeusconriquezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José António",
                        LastName = "López Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 8, 8),
                        PhoneNumber = "+524219027035",
                        Email = "joseantoniolopezramones112@hotmail.com",
                        Username = "joseantonio334",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joseantoniolopezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Sebastián",
                        LastName = "Árce Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 5, 1),
                        PhoneNumber = "+524164413077",
                        Email = "juansebastianarcefernandez735@hotmail.com",
                        Username = "juansebastian868",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juansebastianarcefernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Nicolás",
                        LastName = "Rodríguez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 9, 27),
                        PhoneNumber = "+528040305496",
                        Email = "fernandonicolasrodriguezgamez491@hotmail.com",
                        Username = "fernandonicolas516",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandonicolasrodriguezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fitzgerald",
                        LastName = "Fernández Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 2, 20),
                        PhoneNumber = "+524833343806",
                        Email = "danielfitzgeraldfernandezmartinez120@hotmail.com",
                        Username = "danielfitzgerald999",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfitzgeraldfernandezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Federico",
                        LastName = "Prado Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 12, 19),
                        PhoneNumber = "+522760756126",
                        Email = "federicofedericopradotrujillo897@hotmail.com",
                        Username = "federicofederico901",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofedericopradotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Arturo",
                        LastName = "Conriquez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 12, 18),
                        PhoneNumber = "+523533556750",
                        Email = "christianarturoconriquezgomez714@hotmail.com",
                        Username = "christianarturo470",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianarturoconriquezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Aarón",
                        LastName = "Contreras Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 2, 11),
                        PhoneNumber = "+523571600669",
                        Email = "alexanderaaroncontrerashigareda324@hotmail.com",
                        Username = "alexanderaaron852",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderaaroncontrerashigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Miguel",
                        LastName = "Martínez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 10, 24),
                        PhoneNumber = "+525772908926",
                        Email = "carlosmiguelmartinezgomez636@hotmail.com",
                        Username = "carlosmiguel649",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosmiguelmartinezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel António",
                        LastName = "Carrillo González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 9, 6),
                        PhoneNumber = "+529178800560",
                        Email = "leonelantoniocarrillogonzalez624@hotmail.com",
                        Username = "leonelantonio520",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelantoniocarrillogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Gerardo",
                        LastName = "Castrejón Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 4, 13),
                        PhoneNumber = "+523271829905",
                        Email = "federicogerardocastrejonfernandez172@hotmail.com",
                        Username = "federicogerardo950",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicogerardocastrejonfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Nicolás",
                        LastName = "Aguirre Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 11, 7),
                        PhoneNumber = "+526595923480",
                        Email = "fernandonicolasaguirredominguez310@hotmail.com",
                        Username = "fernandonicolas961",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandonicolasaguirredominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Estéban",
                        LastName = "Fernández Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 10, 20),
                        PhoneNumber = "+524965462366",
                        Email = "nicolasestebanfernandezquintero384@hotmail.com",
                        Username = "nicolasesteban256",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasestebanfernandezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Estéban",
                        LastName = "Conriquez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 11, 24),
                        PhoneNumber = "+529945767036",
                        Email = "antonioestebanconriquezmiranda823@hotmail.com",
                        Username = "antonioesteban638",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioestebanconriquezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Javier",
                        LastName = "Bustamante González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 8, 19),
                        PhoneNumber = "+525270757083",
                        Email = "rafaeljavierbustamantegonzalez559@hotmail.com",
                        Username = "rafaeljavier845",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljavierbustamantegonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Moisés",
                        LastName = "Gonzalí Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 12, 2),
                        PhoneNumber = "+528582711978",
                        Email = "juanmoisesgonzalihigareda595@hotmail.com",
                        Username = "juanmoises536",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanmoisesgonzalihigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Carlos",
                        LastName = "Zavala Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 2, 5),
                        PhoneNumber = "+522164752867",
                        Email = "arturocarloszavalagamez938@hotmail.com",
                        Username = "arturocarlos748",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturocarloszavalagamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Federico",
                        LastName = "Gámez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 6, 17),
                        PhoneNumber = "+523030696466",
                        Email = "nicolasfedericogamezarce41@hotmail.com",
                        Username = "nicolasfederico844",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasfedericogamezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Juan",
                        LastName = "Gonzalí Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 3, 14),
                        PhoneNumber = "+524735041425",
                        Email = "juanjuangonzalicastrejon103@hotmail.com",
                        Username = "juanjuan709",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanjuangonzalicastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Arturo",
                        LastName = "Rodríguez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 19),
                        PhoneNumber = "+529230471831",
                        Email = "federicoarturorodriguezgomez183@hotmail.com",
                        Username = "federicoarturo30",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoarturorodriguezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Fitzgerald",
                        LastName = "Quintero Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 8, 20),
                        PhoneNumber = "+525188916290",
                        Email = "amadeusfitzgeraldquinteroaguirre801@hotmail.com",
                        Username = "amadeusfitzgerald639",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusfitzgeraldquinteroaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Carlos",
                        LastName = "Miranda Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 12, 15),
                        PhoneNumber = "+528049092492",
                        Email = "estebancarlosmirandafernandez731@hotmail.com",
                        Username = "estebancarlos870",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebancarlosmirandafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Christian",
                        LastName = "Gómez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 2, 13),
                        PhoneNumber = "+527268776655",
                        Email = "oscarchristiangomezcastrejon214@hotmail.com",
                        Username = "oscarchristian741",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarchristiangomezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Juan",
                        LastName = "Gámez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 10, 19),
                        PhoneNumber = "+524053841765",
                        Email = "migueljuangamezmiranda757@hotmail.com",
                        Username = "migueljuan963",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljuangamezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Fitzgerald",
                        LastName = "González Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 2, 20),
                        PhoneNumber = "+528746739213",
                        Email = "manuelfitzgeraldgonzalezzavala247@hotmail.com",
                        Username = "manuelfitzgerald623",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelfitzgeraldgonzalezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Gabriel",
                        LastName = "Nevárez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 3, 17),
                        PhoneNumber = "+521430793631",
                        Email = "federicogabrielnevarezmartinez773@hotmail.com",
                        Username = "federicogabriel906",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicogabrielnevarezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Manuel",
                        LastName = "Miranda Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 6, 14),
                        PhoneNumber = "+522097063416",
                        Email = "felipemanuelmirandaclaro569@hotmail.com",
                        Username = "felipemanuel252",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipemanuelmirandaclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Rafaél",
                        LastName = "González Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 4, 8),
                        PhoneNumber = "+523563274321",
                        Email = "fernandorafaelgonzalezaguirre158@hotmail.com",
                        Username = "fernandorafael118",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandorafaelgonzalezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Carlos",
                        LastName = "Martínez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 9, 10),
                        PhoneNumber = "+528160630704",
                        Email = "aaroncarlosmartinezleon100@hotmail.com",
                        Username = "aaroncarlos6",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaroncarlosmartinezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Luis",
                        LastName = "Bustamante Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 5, 10),
                        PhoneNumber = "+527528234370",
                        Email = "estebanluisbustamantefernandez615@hotmail.com",
                        Username = "estebanluis760",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanluisbustamantefernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Carlos",
                        LastName = "Higuera Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 10, 19),
                        PhoneNumber = "+520559333202",
                        Email = "juancarloshigueranevarez95@hotmail.com",
                        Username = "juancarlos328",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juancarloshigueranevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel José",
                        LastName = "León Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 2, 1),
                        PhoneNumber = "+524065637784",
                        Email = "danieljoseleongomez184@hotmail.com",
                        Username = "danieljose993",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieljoseleongomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Fabrizio",
                        LastName = "Aguirre Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 6, 24),
                        PhoneNumber = "+523056391546",
                        Email = "angelfabrizioaguirreperez856@hotmail.com",
                        Username = "angelfabrizio981",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelfabrizioaguirreperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Joaquin",
                        LastName = "Fernández Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 10, 16),
                        PhoneNumber = "+528022760374",
                        Email = "alexanderjoaquinfernandezquintero148@hotmail.com",
                        Username = "alexanderjoaquin37",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjoaquinfernandezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Óscar",
                        LastName = "Claro Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 10, 24),
                        PhoneNumber = "+524161253766",
                        Email = "fitzgeraldoscarclarohiguera673@hotmail.com",
                        Username = "fitzgeraldoscar386",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldoscarclarohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Javier",
                        LastName = "León Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 7, 23),
                        PhoneNumber = "+521243665483",
                        Email = "gerardojavierleonlastra248@hotmail.com",
                        Username = "gerardojavier525",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardojavierleonlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Moisés",
                        LastName = "Enríquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 9, 21),
                        PhoneNumber = "+527500301991",
                        Email = "alejandromoisesenriquezrodriguez395@hotmail.com",
                        Username = "alejandromoises919",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandromoisesenriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Christian",
                        LastName = "Jiménez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 3, 5),
                        PhoneNumber = "+523612336070",
                        Email = "miguelchristianjimenezmartinez674@hotmail.com",
                        Username = "miguelchristian308",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelchristianjimenezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Luis",
                        LastName = "Contreras Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 10, 6),
                        PhoneNumber = "+525665758160",
                        Email = "leonelluiscontrerasfernandez655@hotmail.com",
                        Username = "leonelluis268",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelluiscontrerasfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Aarón",
                        LastName = "Álvarez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 10, 10),
                        PhoneNumber = "+526160215927",
                        Email = "alejandroaaronalvarezjuarez840@hotmail.com",
                        Username = "alejandroaaron311",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroaaronalvarezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Javier",
                        LastName = "Álvarez González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 5, 20),
                        PhoneNumber = "+529989018671",
                        Email = "javierjavieralvarezgonzalez278@hotmail.com",
                        Username = "javierjavier554",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierjavieralvarezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Manuel",
                        LastName = "Fernández Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 10, 22),
                        PhoneNumber = "+526207473628",
                        Email = "nicolasmanuelfernandezquintero830@hotmail.com",
                        Username = "nicolasmanuel748",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasmanuelfernandezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Amadeus",
                        LastName = "López Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 10, 18),
                        PhoneNumber = "+523575836614",
                        Email = "fitzgeraldamadeuslopezzavala846@hotmail.com",
                        Username = "fitzgeraldamadeus719",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldamadeuslopezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Alejandro",
                        LastName = "Rodríguez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 6, 7),
                        PhoneNumber = "+523222590953",
                        Email = "federicoalejandrorodriguezcastrejon635@hotmail.com",
                        Username = "federicoalejandro125",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoalejandrorodriguezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Fabrizio",
                        LastName = "Fernández Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 6, 12),
                        PhoneNumber = "+528885377965",
                        Email = "joaquinfabriziofernandezmartinez685@hotmail.com",
                        Username = "joaquinfabrizio985",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinfabriziofernandezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Gabriel",
                        LastName = "Álvarez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 3, 19),
                        PhoneNumber = "+526205381909",
                        Email = "fabriziogabrielalvarezzavala285@hotmail.com",
                        Username = "fabriziogabriel924",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziogabrielalvarezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Fernando",
                        LastName = "Prado Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 8, 23),
                        PhoneNumber = "+522606609110",
                        Email = "gerardofernandopradoprado211@hotmail.com",
                        Username = "gerardofernando392",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofernandopradoprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Gabriel",
                        LastName = "Miranda Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 12, 25),
                        PhoneNumber = "+521020909137",
                        Email = "luisgabrielmirandalastra586@hotmail.com",
                        Username = "luisgabriel770",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisgabrielmirandalastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Christian",
                        LastName = "Pérez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 2, 4),
                        PhoneNumber = "+520372712626",
                        Email = "felipechristianperezjuarez125@hotmail.com",
                        Username = "felipechristian940",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipechristianperezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Manuel",
                        LastName = "Conriquez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 1, 18),
                        PhoneNumber = "+520702023635",
                        Email = "antoniomanuelconriquezperez559@hotmail.com",
                        Username = "antoniomanuel307",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniomanuelconriquezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Federico",
                        LastName = "Árce Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 5, 22),
                        PhoneNumber = "+528320145173",
                        Email = "miguelfedericoarcearce31@hotmail.com",
                        Username = "miguelfederico699",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelfedericoarcearce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Alexander",
                        LastName = "Martínez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 12, 7),
                        PhoneNumber = "+521492672472",
                        Email = "fabrizioalexandermartinezmartinez462@hotmail.com",
                        Username = "fabrizioalexander482",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioalexandermartinezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Amadeus",
                        LastName = "González Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 8, 23),
                        PhoneNumber = "+529894762836",
                        Email = "amadeusamadeusgonzalezlastra48@hotmail.com",
                        Username = "amadeusamadeus65",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusamadeusgonzalezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Gerardo",
                        LastName = "Juárez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 7, 11),
                        PhoneNumber = "+525675980539",
                        Email = "josegerardojuarezquintero90@hotmail.com",
                        Username = "josegerardo606",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josegerardojuarezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Carlos",
                        LastName = "León Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 12, 25),
                        PhoneNumber = "+525951708148",
                        Email = "angelcarlosleonjimenez860@hotmail.com",
                        Username = "angelcarlos493",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelcarlosleonjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Gabriel",
                        LastName = "Carrillo Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 12, 20),
                        PhoneNumber = "+522263667919",
                        Email = "joaquingabrielcarrillobustamante796@hotmail.com",
                        Username = "joaquingabriel964",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquingabrielcarrillobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Alejandro",
                        LastName = "Gonzalí Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 9, 26),
                        PhoneNumber = "+521275515732",
                        Email = "fitzgeraldalejandrogonzaliarce230@hotmail.com",
                        Username = "fitzgeraldalejandro548",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldalejandrogonzaliarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Arturo",
                        LastName = "Pérez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 9, 12),
                        PhoneNumber = "+523626821018",
                        Email = "christianarturoperezhigareda245@hotmail.com",
                        Username = "christianarturo415",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianarturoperezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Fitzgerald",
                        LastName = "Castrejón Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 9, 7),
                        PhoneNumber = "+526243779873",
                        Email = "leonelfitzgeraldcastrejonnevarez568@hotmail.com",
                        Username = "leonelfitzgerald433",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelfitzgeraldcastrejonnevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Joaquin",
                        LastName = "Higareda Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 3, 26),
                        PhoneNumber = "+521888489397",
                        Email = "alexanderjoaquinhigaredacontreras534@hotmail.com",
                        Username = "alexanderjoaquin266",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjoaquinhigaredacontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Federico",
                        LastName = "Trujillo Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 7, 3),
                        PhoneNumber = "+526418669650",
                        Email = "gabrielfedericotrujillohigareda157@hotmail.com",
                        Username = "gabrielfederico581",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielfedericotrujillohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Gabriel",
                        LastName = "Enríquez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 9, 19),
                        PhoneNumber = "+521817087429",
                        Email = "leonelgabrielenriquezcarrillo363@hotmail.com",
                        Username = "leonelgabriel723",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelgabrielenriquezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Nicolás",
                        LastName = "Zavala Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 8, 24),
                        PhoneNumber = "+523575188016",
                        Email = "gabrielnicolaszavalaaguirre82@hotmail.com",
                        Username = "gabrielnicolas478",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielnicolaszavalaaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Estéban",
                        LastName = "Pérez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 1, 23),
                        PhoneNumber = "+522536317225",
                        Email = "leonelestebanperezlastra998@hotmail.com",
                        Username = "leonelesteban484",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelestebanperezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Felipe",
                        LastName = "Fernández Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 6, 27),
                        PhoneNumber = "+527328865171",
                        Email = "christianfelipefernandezgomez868@hotmail.com",
                        Username = "christianfelipe655",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfelipefernandezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Leonel",
                        LastName = "Zavala Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 12, 10),
                        PhoneNumber = "+521597602104",
                        Email = "sebastianleonelzavalanevarez658@hotmail.com",
                        Username = "sebastianleonel974",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianleonelzavalanevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Arturo",
                        LastName = "Trujillo Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 26),
                        PhoneNumber = "+526456778440",
                        Email = "gabrielarturotrujilloenriquez269@hotmail.com",
                        Username = "gabrielarturo291",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielarturotrujilloenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico António",
                        LastName = "Claro Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 10, 9),
                        PhoneNumber = "+524080862542",
                        Email = "federicoantonioclarodominguez72@hotmail.com",
                        Username = "federicoantonio571",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoantonioclarodominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Carlos",
                        LastName = "Gámez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 9, 27),
                        PhoneNumber = "+520500167199",
                        Email = "miguelcarlosgamezramones695@hotmail.com",
                        Username = "miguelcarlos977",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelcarlosgamezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Gabriel",
                        LastName = "Lastra Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 4, 14),
                        PhoneNumber = "+528151392705",
                        Email = "fitzgeraldgabriellastracarrillo405@hotmail.com",
                        Username = "fitzgeraldgabriel691",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldgabriellastracarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Carlos",
                        LastName = "Quintero Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 9, 13),
                        PhoneNumber = "+522124514486",
                        Email = "antoniocarlosquinterogomez207@hotmail.com",
                        Username = "antoniocarlos226",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniocarlosquinterogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Leonel",
                        LastName = "Lastra González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 2, 5),
                        PhoneNumber = "+523832958826",
                        Email = "fabrizioleonellastragonzalez614@hotmail.com",
                        Username = "fabrizioleonel691",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioleonellastragonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Alejandro",
                        LastName = "Trujillo Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 9, 5),
                        PhoneNumber = "+523224465744",
                        Email = "danielalejandrotrujillotrujillo414@hotmail.com",
                        Username = "danielalejandro89",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielalejandrotrujillotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Jhonatan",
                        LastName = "Carrillo Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 5, 16),
                        PhoneNumber = "+528077870411",
                        Email = "antoniojhonatancarrilloalvarez709@hotmail.com",
                        Username = "antoniojhonatan554",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniojhonatancarrilloalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Fernando",
                        LastName = "Nevárez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 8, 19),
                        PhoneNumber = "+524699959279",
                        Email = "antoniofernandonevarezenriquez396@hotmail.com",
                        Username = "antoniofernando132",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniofernandonevarezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Fitzgerald",
                        LastName = "Aguirre Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 3, 19),
                        PhoneNumber = "+521082965302",
                        Email = "felipefitzgeraldaguirredominguez469@hotmail.com",
                        Username = "felipefitzgerald236",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipefitzgeraldaguirredominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Gerardo",
                        LastName = "González Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 3, 20),
                        PhoneNumber = "+528411775344",
                        Email = "javiergerardogonzalezrodriguez740@hotmail.com",
                        Username = "javiergerardo664",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiergerardogonzalezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Manuel",
                        LastName = "Rodríguez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 10, 10),
                        PhoneNumber = "+529930261170",
                        Email = "christianmanuelrodriguezgonzali82@hotmail.com",
                        Username = "christianmanuel735",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianmanuelrodriguezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "Quintero Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 9, 6),
                        PhoneNumber = "+528351183436",
                        Email = "alejandronicolasquinterozavala167@hotmail.com",
                        Username = "alejandronicolas405",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolasquinterozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Nicolás",
                        LastName = "León Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 10, 26),
                        PhoneNumber = "+529817044041",
                        Email = "amadeusnicolasleonmartinez933@hotmail.com",
                        Username = "amadeusnicolas443",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusnicolasleonmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Fabrizio",
                        LastName = "Ramones González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 5, 2),
                        PhoneNumber = "+529153761593",
                        Email = "eliazarfabrizioramonesgonzalez290@hotmail.com",
                        Username = "eliazarfabrizio634",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfabrizioramonesgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Federico",
                        LastName = "Aguirre Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 4, 6),
                        PhoneNumber = "+528730704990",
                        Email = "estebanfedericoaguirrehigareda411@hotmail.com",
                        Username = "estebanfederico437",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanfedericoaguirrehigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Carlos",
                        LastName = "Higuera Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 11, 27),
                        PhoneNumber = "+521491263529",
                        Email = "eliazarcarloshiguerajimenez784@hotmail.com",
                        Username = "eliazarcarlos716",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarcarloshiguerajimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Amadeus",
                        LastName = "Miranda Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 5, 3),
                        PhoneNumber = "+528643566076",
                        Email = "alejandroamadeusmirandacastrejon609@hotmail.com",
                        Username = "alejandroamadeus353",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroamadeusmirandacastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Daniel",
                        LastName = "Higareda Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 12, 4),
                        PhoneNumber = "+529746265125",
                        Email = "luisdanielhigaredaarce730@hotmail.com",
                        Username = "luisdaniel783",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisdanielhigaredaarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Daniel",
                        LastName = "Higareda Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 12, 23),
                        PhoneNumber = "+522325337130",
                        Email = "alexanderdanielhigaredaenriquez359@hotmail.com",
                        Username = "alexanderdaniel16",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderdanielhigaredaenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Juan",
                        LastName = "González Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 8, 21),
                        PhoneNumber = "+522371242334",
                        Email = "alexanderjuangonzalezhigareda809@hotmail.com",
                        Username = "alexanderjuan603",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjuangonzalezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Luis",
                        LastName = "Zavala Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 5, 26),
                        PhoneNumber = "+526273469052",
                        Email = "sebastianluiszavalamartinez172@hotmail.com",
                        Username = "sebastianluis600",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianluiszavalamartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Juan",
                        LastName = "Árce Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 5, 8),
                        PhoneNumber = "+528084803702",
                        Email = "eliazarjuanarcegamez908@hotmail.com",
                        Username = "eliazarjuan959",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarjuanarcegamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Luis",
                        LastName = "Ramones López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 12, 5),
                        PhoneNumber = "+525121278705",
                        Email = "jhonatanluisramoneslopez948@hotmail.com",
                        Username = "jhonatanluis222",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanluisramoneslopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Federico",
                        LastName = "Trujillo Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 5, 25),
                        PhoneNumber = "+525386120805",
                        Email = "gabrielfedericotrujillogonzali175@hotmail.com",
                        Username = "gabrielfederico986",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielfedericotrujillogonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Leonel",
                        LastName = "Pérez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 4, 17),
                        PhoneNumber = "+523008957101",
                        Email = "moisesleonelperezjuarez291@hotmail.com",
                        Username = "moisesleonel382",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesleonelperezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Gerardo",
                        LastName = "Conriquez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 8, 8),
                        PhoneNumber = "+523859012802",
                        Email = "joaquingerardoconriquezaguirre143@hotmail.com",
                        Username = "joaquingerardo397",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquingerardoconriquezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Leonel",
                        LastName = "Ramones Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 11, 21),
                        PhoneNumber = "+523410234147",
                        Email = "juanleonelramonesgamez619@hotmail.com",
                        Username = "juanleonel846",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanleonelramonesgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Alejandro",
                        LastName = "Claro Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 5, 21),
                        PhoneNumber = "+529057324434",
                        Email = "arturoalejandroclarobustamante826@hotmail.com",
                        Username = "arturoalejandro153",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoalejandroclarobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Miguel",
                        LastName = "González Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 8, 22),
                        PhoneNumber = "+522843460465",
                        Email = "jhonatanmiguelgonzalezramones44@hotmail.com",
                        Username = "jhonatanmiguel699",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanmiguelgonzalezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Gabriel",
                        LastName = "Nevárez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 12, 6),
                        PhoneNumber = "+528463926410",
                        Email = "christiangabrielnevarezclaro758@hotmail.com",
                        Username = "christiangabriel163",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiangabrielnevarezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Federico",
                        LastName = "Castrejón Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 12, 25),
                        PhoneNumber = "+522022653088",
                        Email = "christianfedericocastrejonbustamante483@hotmail.com",
                        Username = "christianfederico669",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfedericocastrejonbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Luis",
                        LastName = "Claro Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 10, 5),
                        PhoneNumber = "+529663038929",
                        Email = "danielluisclarogomez10@hotmail.com",
                        Username = "danielluis914",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielluisclarogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Nicolás",
                        LastName = "Prado González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 2, 14),
                        PhoneNumber = "+524616053067",
                        Email = "christiannicolaspradogonzalez199@hotmail.com",
                        Username = "christiannicolas167",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiannicolaspradogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Christian",
                        LastName = "Conriquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 11, 24),
                        PhoneNumber = "+521208216714",
                        Email = "juanchristianconriquezrodriguez913@hotmail.com",
                        Username = "juanchristian180",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanchristianconriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Manuel",
                        LastName = "Ramones Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 8, 20),
                        PhoneNumber = "+524470004951",
                        Email = "nicolasmanuelramonesgonzali176@hotmail.com",
                        Username = "nicolasmanuel85",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasmanuelramonesgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Manuel",
                        LastName = "López Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 7, 17),
                        PhoneNumber = "+521978061636",
                        Email = "joaquinmanuellopezprado216@hotmail.com",
                        Username = "joaquinmanuel165",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinmanuellopezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Manuel",
                        LastName = "Higareda Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 8, 2),
                        PhoneNumber = "+527209348977",
                        Email = "rafaelmanuelhigaredacontreras449@hotmail.com",
                        Username = "rafaelmanuel683",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelmanuelhigaredacontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Estéban",
                        LastName = "Castrejón Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 4, 18),
                        PhoneNumber = "+523390603365",
                        Email = "antonioestebancastrejonalvarez506@hotmail.com",
                        Username = "antonioesteban899",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioestebancastrejonalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Nicolás",
                        LastName = "Lastra Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 3, 1),
                        PhoneNumber = "+529818740427",
                        Email = "fitzgeraldnicolaslastragomez546@hotmail.com",
                        Username = "fitzgeraldnicolas892",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldnicolaslastragomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Felipe",
                        LastName = "López Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 5, 13),
                        PhoneNumber = "+522542905030",
                        Email = "juanfelipelopezfernandez533@hotmail.com",
                        Username = "juanfelipe195",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanfelipelopezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Christian",
                        LastName = "Gómez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 7, 8),
                        PhoneNumber = "+521029212780",
                        Email = "luischristiangomezgamez354@hotmail.com",
                        Username = "luischristian220",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luischristiangomezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Ángel",
                        LastName = "Lastra Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 4, 6),
                        PhoneNumber = "+527010669247",
                        Email = "nicolasangellastrazavala620@hotmail.com",
                        Username = "nicolasangel77",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasangellastrazavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Federico",
                        LastName = "Jiménez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 8, 3),
                        PhoneNumber = "+521735518290",
                        Email = "fernandofedericojimenezdominguez274@hotmail.com",
                        Username = "fernandofederico401",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandofedericojimenezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Fitzgerald",
                        LastName = "Bustamante León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 7, 11),
                        PhoneNumber = "+523518515155",
                        Email = "gerardofitzgeraldbustamanteleon660@hotmail.com",
                        Username = "gerardofitzgerald856",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofitzgeraldbustamanteleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Fabrizio",
                        LastName = "Miranda Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 11),
                        PhoneNumber = "+526677592373",
                        Email = "alejandrofabriziomirandajimenez888@hotmail.com",
                        Username = "alejandrofabrizio643",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofabriziomirandajimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Federico",
                        LastName = "Gámez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 5, 14),
                        PhoneNumber = "+522360749107",
                        Email = "danielfedericogamezalvarez82@hotmail.com",
                        Username = "danielfederico782",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfedericogamezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Joaquin",
                        LastName = "Bustamante Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 4, 8),
                        PhoneNumber = "+520293281760",
                        Email = "moisesjoaquinbustamanteperez271@hotmail.com",
                        Username = "moisesjoaquin879",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesjoaquinbustamanteperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Nicolás",
                        LastName = "González Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 12, 10),
                        PhoneNumber = "+528568073773",
                        Email = "arturonicolasgonzalezconriquez953@hotmail.com",
                        Username = "arturonicolas725",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturonicolasgonzalezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Gabriel",
                        LastName = "Enríquez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 8, 25),
                        PhoneNumber = "+527104636438",
                        Email = "javiergabrielenriquezgamez346@hotmail.com",
                        Username = "javiergabriel263",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiergabrielenriquezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Federico",
                        LastName = "Árce Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 3, 7),
                        PhoneNumber = "+526830986335",
                        Email = "luisfedericoarcefernandez812@hotmail.com",
                        Username = "luisfederico161",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisfedericoarcefernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Nicolás",
                        LastName = "Pérez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 2, 9),
                        PhoneNumber = "+525639974426",
                        Email = "josenicolasperezrodriguez661@hotmail.com",
                        Username = "josenicolas991",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josenicolasperezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Javier",
                        LastName = "Trujillo Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 20),
                        PhoneNumber = "+529321851131",
                        Email = "manueljaviertrujilloalvarez731@hotmail.com",
                        Username = "manueljavier671",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueljaviertrujilloalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Luis",
                        LastName = "Pérez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 12, 20),
                        PhoneNumber = "+521045563999",
                        Email = "moisesluisperezjimenez948@hotmail.com",
                        Username = "moisesluis698",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesluisperezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico José",
                        LastName = "Zavala Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 7, 1),
                        PhoneNumber = "+521587264167",
                        Email = "federicojosezavalaconriquez423@hotmail.com",
                        Username = "federicojose974",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicojosezavalaconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Amadeus",
                        LastName = "Juárez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 1, 5),
                        PhoneNumber = "+528666746940",
                        Email = "juanamadeusjuarezzavala823@hotmail.com",
                        Username = "juanamadeus41",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanamadeusjuarezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Miguel",
                        LastName = "Contreras Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 1, 15),
                        PhoneNumber = "+523886097485",
                        Email = "gerardomiguelcontrerasarce364@hotmail.com",
                        Username = "gerardomiguel44",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardomiguelcontrerasarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Aarón",
                        LastName = "Gonzalí Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 9, 3),
                        PhoneNumber = "+525078682145",
                        Email = "estebanaarongonzaliquintero185@hotmail.com",
                        Username = "estebanaaron960",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanaarongonzaliquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo José",
                        LastName = "Aguirre Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 6, 22),
                        PhoneNumber = "+523739180125",
                        Email = "gerardojoseaguirregomez485@hotmail.com",
                        Username = "gerardojose536",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardojoseaguirregomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Eliazar",
                        LastName = "Conriquez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 6, 22),
                        PhoneNumber = "+526717262868",
                        Email = "federicoeliazarconriquezleon861@hotmail.com",
                        Username = "federicoeliazar680",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoeliazarconriquezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Fernando",
                        LastName = "Pérez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 7, 3),
                        PhoneNumber = "+524887047227",
                        Email = "rafaelfernandoperezdominguez568@hotmail.com",
                        Username = "rafaelfernando819",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfernandoperezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Sebastián",
                        LastName = "Gámez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 12, 3),
                        PhoneNumber = "+529503285800",
                        Email = "gerardosebastiangamezzavala231@hotmail.com",
                        Username = "gerardosebastian485",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardosebastiangamezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Sebastián",
                        LastName = "Lastra Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 11, 11),
                        PhoneNumber = "+520713181163",
                        Email = "sebastiansebastianlastrahiguera156@hotmail.com",
                        Username = "sebastiansebastian504",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastiansebastianlastrahiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Sebastián",
                        LastName = "Carrillo Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 6, 18),
                        PhoneNumber = "+525654672299",
                        Email = "danielsebastiancarrilloarce629@hotmail.com",
                        Username = "danielsebastian660",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielsebastiancarrilloarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Joaquin",
                        LastName = "Gámez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 2, 9),
                        PhoneNumber = "+527384049252",
                        Email = "moisesjoaquingamezcastrejon121@hotmail.com",
                        Username = "moisesjoaquin110",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesjoaquingamezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Arturo",
                        LastName = "Contreras Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 10, 22),
                        PhoneNumber = "+528901850887",
                        Email = "fitzgeraldarturocontrerasfernandez514@hotmail.com",
                        Username = "fitzgeraldarturo402",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldarturocontrerasfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Eliazar",
                        LastName = "Claro Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 8, 14),
                        PhoneNumber = "+523759603541",
                        Email = "fernandoeliazarclarohigareda841@hotmail.com",
                        Username = "fernandoeliazar46",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoeliazarclarohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Jhonatan",
                        LastName = "Higuera Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 7, 21),
                        PhoneNumber = "+525379734198",
                        Email = "fernandojhonatanhigueraramones329@hotmail.com",
                        Username = "fernandojhonatan72",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandojhonatanhigueraramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Fabrizio",
                        LastName = "León Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 6, 24),
                        PhoneNumber = "+520702041897",
                        Email = "fitzgeraldfabrizioleonquintero713@hotmail.com",
                        Username = "fitzgeraldfabrizio855",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfabrizioleonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Christian",
                        LastName = "Pérez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 2, 11),
                        PhoneNumber = "+529980128311",
                        Email = "amadeuschristianperezperez92@hotmail.com",
                        Username = "amadeuschristian124",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeuschristianperezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Amadeus",
                        LastName = "Árce Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 7, 26),
                        PhoneNumber = "+525612468878",
                        Email = "luisamadeusarcedominguez130@hotmail.com",
                        Username = "luisamadeus414",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisamadeusarcedominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Gerardo",
                        LastName = "Claro Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 4, 19),
                        PhoneNumber = "+525127190954",
                        Email = "gabrielgerardoclaroconriquez845@hotmail.com",
                        Username = "gabrielgerardo738",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielgerardoclaroconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Estéban",
                        LastName = "Pérez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 8, 16),
                        PhoneNumber = "+524081651735",
                        Email = "juanestebanperezprado993@hotmail.com",
                        Username = "juanesteban704",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanestebanperezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Aarón",
                        LastName = "Fernández Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 3, 17),
                        PhoneNumber = "+522705717823",
                        Email = "arturoaaronfernandezgomez971@hotmail.com",
                        Username = "arturoaaron166",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoaaronfernandezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Jhonatan",
                        LastName = "Zavala Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 5, 9),
                        PhoneNumber = "+526527008584",
                        Email = "joaquinjhonatanzavalagonzali917@hotmail.com",
                        Username = "joaquinjhonatan852",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinjhonatanzavalagonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Christian",
                        LastName = "Prado Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 1, 1),
                        PhoneNumber = "+529705827220",
                        Email = "nicolaschristianpradonevarez997@hotmail.com",
                        Username = "nicolaschristian436",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolaschristianpradonevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Arturo",
                        LastName = "Domínguez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 1, 9),
                        PhoneNumber = "+528183099838",
                        Email = "estebanarturodominguezconriquez858@hotmail.com",
                        Username = "estebanarturo630",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanarturodominguezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Alejandro",
                        LastName = "Pérez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 10, 11),
                        PhoneNumber = "+520018057947",
                        Email = "arturoalejandropereztrujillo564@hotmail.com",
                        Username = "arturoalejandro527",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoalejandropereztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Manuel",
                        LastName = "Árce Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 7, 25),
                        PhoneNumber = "+527835730767",
                        Email = "sebastianmanuelarcegonzali151@hotmail.com",
                        Username = "sebastianmanuel491",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianmanuelarcegonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Miguel",
                        LastName = "López Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 12, 4),
                        PhoneNumber = "+520258267235",
                        Email = "eliazarmiguellopezrodriguez510@hotmail.com",
                        Username = "eliazarmiguel609",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarmiguellopezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Sebastián",
                        LastName = "Higareda Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 12, 15),
                        PhoneNumber = "+521389569229",
                        Email = "fitzgeraldsebastianhigaredagomez546@hotmail.com",
                        Username = "fitzgeraldsebastian24",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldsebastianhigaredagomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Ángel",
                        LastName = "Miranda Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 7, 16),
                        PhoneNumber = "+524260362816",
                        Email = "alejandroangelmirandahigareda211@hotmail.com",
                        Username = "alejandroangel245",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroangelmirandahigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Aarón",
                        LastName = "Álvarez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 11, 23),
                        PhoneNumber = "+520714773456",
                        Email = "danielaaronalvarezjuarez855@hotmail.com",
                        Username = "danielaaron116",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielaaronalvarezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Jhonatan",
                        LastName = "Contreras Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 4, 27),
                        PhoneNumber = "+529890688030",
                        Email = "alexanderjhonatancontrerashiguera301@hotmail.com",
                        Username = "alexanderjhonatan445",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjhonatancontrerashiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fitzgerald",
                        LastName = "Contreras Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 10, 6),
                        PhoneNumber = "+525360117606",
                        Email = "danielfitzgeraldcontrerasconriquez569@hotmail.com",
                        Username = "danielfitzgerald144",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfitzgeraldcontrerasconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Jhonatan",
                        LastName = "Pérez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 11, 23),
                        PhoneNumber = "+525836839533",
                        Email = "arturojhonatanperezdominguez566@hotmail.com",
                        Username = "arturojhonatan263",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturojhonatanperezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Fitzgerald",
                        LastName = "Gámez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 2, 5),
                        PhoneNumber = "+528178527277",
                        Email = "josefitzgeraldgamezjimenez34@hotmail.com",
                        Username = "josefitzgerald608",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefitzgeraldgamezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Fernando",
                        LastName = "Higareda Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 1, 27),
                        PhoneNumber = "+522710887199",
                        Email = "rafaelfernandohigaredabustamante671@hotmail.com",
                        Username = "rafaelfernando479",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfernandohigaredabustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Joaquin",
                        LastName = "Claro Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 11, 17),
                        PhoneNumber = "+527136722140",
                        Email = "fernandojoaquinclarohigareda75@hotmail.com",
                        Username = "fernandojoaquin598",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandojoaquinclarohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Amadeus",
                        LastName = "Enríquez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 6, 12),
                        PhoneNumber = "+524193799607",
                        Email = "amadeusamadeusenriquezjimenez739@hotmail.com",
                        Username = "amadeusamadeus939",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusamadeusenriquezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Arturo",
                        LastName = "Nevárez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 6, 8),
                        PhoneNumber = "+527302633251",
                        Email = "eliazararturonevarezmartinez170@hotmail.com",
                        Username = "eliazararturo214",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazararturonevarezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Christian",
                        LastName = "Higuera Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 4, 8),
                        PhoneNumber = "+521643439732",
                        Email = "fernandochristianhiguerajimenez402@hotmail.com",
                        Username = "fernandochristian967",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandochristianhiguerajimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Gerardo",
                        LastName = "Ramones Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 11, 6),
                        PhoneNumber = "+524498420299",
                        Email = "joaquingerardoramoneshigareda942@hotmail.com",
                        Username = "joaquingerardo194",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquingerardoramoneshigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Rafaél",
                        LastName = "Conriquez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 2, 7),
                        PhoneNumber = "+526039899679",
                        Email = "jhonatanrafaelconriquezlastra709@hotmail.com",
                        Username = "jhonatanrafael301",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanrafaelconriquezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Felipe",
                        LastName = "Pérez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 4, 14),
                        PhoneNumber = "+522848991176",
                        Email = "joaquinfelipeperezhigareda986@hotmail.com",
                        Username = "joaquinfelipe186",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinfelipeperezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Carlos",
                        LastName = "Carrillo Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 2, 10),
                        PhoneNumber = "+523550469863",
                        Email = "angelcarloscarrilloconriquez618@hotmail.com",
                        Username = "angelcarlos434",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelcarloscarrilloconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Carlos",
                        LastName = "Jiménez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 1, 17),
                        PhoneNumber = "+528597124540",
                        Email = "joaquincarlosjimenezprado591@hotmail.com",
                        Username = "joaquincarlos113",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquincarlosjimenezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Federico",
                        LastName = "Jiménez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 11, 3),
                        PhoneNumber = "+529952060565",
                        Email = "christianfedericojimenezgonzali887@hotmail.com",
                        Username = "christianfederico555",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfedericojimenezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Manuel",
                        LastName = "Ramones Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 4, 1),
                        PhoneNumber = "+526324389753",
                        Email = "antoniomanuelramonesdominguez822@hotmail.com",
                        Username = "antoniomanuel558",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniomanuelramonesdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Gerardo",
                        LastName = "Martínez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 6, 20),
                        PhoneNumber = "+521245998807",
                        Email = "christiangerardomartinezramones421@hotmail.com",
                        Username = "christiangerardo827",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiangerardomartinezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Fabrizio",
                        LastName = "Higareda Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 3, 10),
                        PhoneNumber = "+521766705394",
                        Email = "gerardofabriziohigaredacarrillo194@hotmail.com",
                        Username = "gerardofabrizio360",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofabriziohigaredacarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Daniel",
                        LastName = "Lastra Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 4, 23),
                        PhoneNumber = "+522052227189",
                        Email = "manueldaniellastracastrejon574@hotmail.com",
                        Username = "manueldaniel437",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueldaniellastracastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Amadeus",
                        LastName = "Lastra Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 7, 23),
                        PhoneNumber = "+527247795480",
                        Email = "christianamadeuslastrafernandez561@hotmail.com",
                        Username = "christianamadeus17",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianamadeuslastrafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Juan",
                        LastName = "González León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 12, 24),
                        PhoneNumber = "+528404546579",
                        Email = "josejuangonzalezleon596@hotmail.com",
                        Username = "josejuan503",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josejuangonzalezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Amadeus",
                        LastName = "Nevárez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 2, 11),
                        PhoneNumber = "+523256760951",
                        Email = "felipeamadeusnevarezgonzali973@hotmail.com",
                        Username = "felipeamadeus41",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeamadeusnevarezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Miguel",
                        LastName = "Nevárez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 6, 21),
                        PhoneNumber = "+520735158007",
                        Email = "jhonatanmiguelnevarezlastra874@hotmail.com",
                        Username = "jhonatanmiguel285",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanmiguelnevarezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Arturo",
                        LastName = "González Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 6, 12),
                        PhoneNumber = "+528383233550",
                        Email = "arturoarturogonzaleztrujillo54@hotmail.com",
                        Username = "arturoarturo459",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoarturogonzaleztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Joaquin",
                        LastName = "Fernández Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 5, 26),
                        PhoneNumber = "+527182233327",
                        Email = "jhonatanjoaquinfernandezramones216@hotmail.com",
                        Username = "jhonatanjoaquin64",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanjoaquinfernandezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Christian",
                        LastName = "Higareda Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 9, 8),
                        PhoneNumber = "+521028320926",
                        Email = "christianchristianhigaredacarrillo940@hotmail.com",
                        Username = "christianchristian950",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianchristianhigaredacarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Juan",
                        LastName = "González Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 10, 17),
                        PhoneNumber = "+528679388554",
                        Email = "christianjuangonzalezalvarez484@hotmail.com",
                        Username = "christianjuan366",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianjuangonzalezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Aarón",
                        LastName = "Gonzalí Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 6, 7),
                        PhoneNumber = "+528925797900",
                        Email = "carlosaarongonzaliquintero501@hotmail.com",
                        Username = "carlosaaron84",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosaarongonzaliquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Miguel",
                        LastName = "León Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 8, 24),
                        PhoneNumber = "+523658096102",
                        Email = "christianmiguelleonquintero691@hotmail.com",
                        Username = "christianmiguel255",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianmiguelleonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Gerardo",
                        LastName = "Ramones Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 10, 27),
                        PhoneNumber = "+521334228834",
                        Email = "eliazargerardoramoneslastra745@hotmail.com",
                        Username = "eliazargerardo610",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazargerardoramoneslastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Manuel",
                        LastName = "Rodríguez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 12, 24),
                        PhoneNumber = "+522828841600",
                        Email = "alexandermanuelrodriguezprado428@hotmail.com",
                        Username = "alexandermanuel411",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandermanuelrodriguezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Amadeus",
                        LastName = "Ramones Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 9, 1),
                        PhoneNumber = "+521447708406",
                        Email = "manuelamadeusramonesgonzali634@hotmail.com",
                        Username = "manuelamadeus315",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelamadeusramonesgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Sebastián",
                        LastName = "Zavala Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 3, 14),
                        PhoneNumber = "+528316409550",
                        Email = "juansebastianzavalamartinez724@hotmail.com",
                        Username = "juansebastian924",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juansebastianzavalamartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Eliazar",
                        LastName = "Nevárez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 4, 23),
                        PhoneNumber = "+528426941874",
                        Email = "joaquineliazarnevarezcarrillo235@hotmail.com",
                        Username = "joaquineliazar449",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquineliazarnevarezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Óscar",
                        LastName = "Martínez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 10, 25),
                        PhoneNumber = "+527591893459",
                        Email = "danieloscarmartinezperez889@hotmail.com",
                        Username = "danieloscar841",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieloscarmartinezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Moisés",
                        LastName = "Martínez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 7, 15),
                        PhoneNumber = "+529836578769",
                        Email = "oscarmoisesmartinezperez318@hotmail.com",
                        Username = "oscarmoises94",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarmoisesmartinezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier António",
                        LastName = "Lastra Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 3, 23),
                        PhoneNumber = "+525888970394",
                        Email = "javierantoniolastracontreras55@hotmail.com",
                        Username = "javierantonio788",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierantoniolastracontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Leonel",
                        LastName = "Carrillo León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 5, 9),
                        PhoneNumber = "+526250698800",
                        Email = "alexanderleonelcarrilloleon723@hotmail.com",
                        Username = "alexanderleonel525",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderleonelcarrilloleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Felipe",
                        LastName = "Martínez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 2, 23),
                        PhoneNumber = "+524935600577",
                        Email = "leonelfelipemartinezgamez439@hotmail.com",
                        Username = "leonelfelipe612",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelfelipemartinezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Felipe",
                        LastName = "Árce Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 3, 16),
                        PhoneNumber = "+521221725285",
                        Email = "eliazarfelipearceperez997@hotmail.com",
                        Username = "eliazarfelipe437",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfelipearceperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "Trujillo Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 10, 18),
                        PhoneNumber = "+529674309135",
                        Email = "alejandronicolastrujillonevarez719@hotmail.com",
                        Username = "alejandronicolas427",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolastrujillonevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Federico",
                        LastName = "Enríquez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 7, 27),
                        PhoneNumber = "+529000652049",
                        Email = "josefedericoenriquezprado840@hotmail.com",
                        Username = "josefederico670",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefedericoenriquezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Arturo",
                        LastName = "Bustamante Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 1, 10),
                        PhoneNumber = "+529830040285",
                        Email = "fitzgeraldarturobustamanteramones398@hotmail.com",
                        Username = "fitzgeraldarturo246",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldarturobustamanteramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Nicolás",
                        LastName = "Carrillo Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 4, 26),
                        PhoneNumber = "+527498883787",
                        Email = "christiannicolascarrillozavala720@hotmail.com",
                        Username = "christiannicolas8",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiannicolascarrillozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis António",
                        LastName = "Pérez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 9, 22),
                        PhoneNumber = "+526713624162",
                        Email = "luisantonioperezzavala703@hotmail.com",
                        Username = "luisantonio930",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisantonioperezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Carlos",
                        LastName = "Trujillo Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 1, 5),
                        PhoneNumber = "+524211191258",
                        Email = "fernandocarlostrujillohiguera589@hotmail.com",
                        Username = "fernandocarlos873",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandocarlostrujillohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Carlos",
                        LastName = "Álvarez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 11, 1),
                        PhoneNumber = "+524550309473",
                        Email = "arturocarlosalvarezclaro959@hotmail.com",
                        Username = "arturocarlos494",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturocarlosalvarezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Carlos",
                        LastName = "Álvarez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 5, 1),
                        PhoneNumber = "+525161543752",
                        Email = "sebastiancarlosalvarezaguirre17@hotmail.com",
                        Username = "sebastiancarlos665",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastiancarlosalvarezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Moisés",
                        LastName = "Enríquez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 6, 10),
                        PhoneNumber = "+522152374748",
                        Email = "aaronmoisesenriqueztrujillo502@hotmail.com",
                        Username = "aaronmoises31",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmoisesenriqueztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Óscar",
                        LastName = "Quintero López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 3, 22),
                        PhoneNumber = "+523117066324",
                        Email = "fernandooscarquinterolopez804@hotmail.com",
                        Username = "fernandooscar301",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandooscarquinterolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Alejandro",
                        LastName = "Bustamante Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 6, 17),
                        PhoneNumber = "+524922695294",
                        Email = "jhonatanalejandrobustamantequintero440@hotmail.com",
                        Username = "jhonatanalejandro469",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanalejandrobustamantequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Alexander",
                        LastName = "Nevárez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 2, 1),
                        PhoneNumber = "+523220751083",
                        Email = "josealexandernevarezcarrillo325@hotmail.com",
                        Username = "josealexander496",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josealexandernevarezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Fernando",
                        LastName = "Castrejón Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 9, 20),
                        PhoneNumber = "+527106721154",
                        Email = "antoniofernandocastrejontrujillo801@hotmail.com",
                        Username = "antoniofernando114",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniofernandocastrejontrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan António",
                        LastName = "Miranda Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 4, 8),
                        PhoneNumber = "+526608017789",
                        Email = "jhonatanantoniomirandatrujillo811@hotmail.com",
                        Username = "jhonatanantonio370",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanantoniomirandatrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Christian",
                        LastName = "Martínez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 12, 6),
                        PhoneNumber = "+528950164026",
                        Email = "aaronchristianmartinezjuarez759@hotmail.com",
                        Username = "aaronchristian59",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronchristianmartinezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Juan",
                        LastName = "Pérez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 10, 20),
                        PhoneNumber = "+528691776569",
                        Email = "arturojuanperezlastra910@hotmail.com",
                        Username = "arturojuan925",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturojuanperezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Fitzgerald",
                        LastName = "León Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 8, 1),
                        PhoneNumber = "+525867809588",
                        Email = "oscarfitzgeraldleonconriquez263@hotmail.com",
                        Username = "oscarfitzgerald487",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfitzgeraldleonconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Federico",
                        LastName = "Lastra González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 10, 3),
                        PhoneNumber = "+527674708197",
                        Email = "gabrielfedericolastragonzalez861@hotmail.com",
                        Username = "gabrielfederico428",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielfedericolastragonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Luis",
                        LastName = "Prado Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 8, 17),
                        PhoneNumber = "+520954296469",
                        Email = "moisesluispradojuarez620@hotmail.com",
                        Username = "moisesluis27",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesluispradojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Nicolás",
                        LastName = "Nevárez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 11, 9),
                        PhoneNumber = "+521793863162",
                        Email = "gabrielnicolasnevarezmartinez368@hotmail.com",
                        Username = "gabrielnicolas999",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielnicolasnevarezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Moisés",
                        LastName = "Ramones Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 2, 6),
                        PhoneNumber = "+523217940554",
                        Email = "aaronmoisesramonesarce293@hotmail.com",
                        Username = "aaronmoises431",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmoisesramonesarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Ángel",
                        LastName = "Castrejón Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 8, 7),
                        PhoneNumber = "+521514316830",
                        Email = "fabrizioangelcastrejonalvarez160@hotmail.com",
                        Username = "fabrizioangel38",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioangelcastrejonalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Ángel",
                        LastName = "Quintero Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 7, 26),
                        PhoneNumber = "+527930941545",
                        Email = "estebanangelquinterogamez632@hotmail.com",
                        Username = "estebanangel253",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanangelquinterogamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander José",
                        LastName = "Gonzalí Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 11, 22),
                        PhoneNumber = "+525294027544",
                        Email = "alexanderjosegonzalidominguez302@hotmail.com",
                        Username = "alexanderjose284",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjosegonzalidominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Óscar",
                        LastName = "León Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 8, 27),
                        PhoneNumber = "+525580111495",
                        Email = "alexanderoscarleonalvarez775@hotmail.com",
                        Username = "alexanderoscar388",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderoscarleonalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Jhonatan",
                        LastName = "Higareda Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 5, 26),
                        PhoneNumber = "+528654787546",
                        Email = "manueljhonatanhigaredagamez912@hotmail.com",
                        Username = "manueljhonatan923",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueljhonatanhigaredagamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Fernando",
                        LastName = "Bustamante León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 8, 6),
                        PhoneNumber = "+527948285451",
                        Email = "arturofernandobustamanteleon795@hotmail.com",
                        Username = "arturofernando140",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturofernandobustamanteleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Fernando",
                        LastName = "Martínez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 11, 8),
                        PhoneNumber = "+523285909800",
                        Email = "oscarfernandomartineznevarez151@hotmail.com",
                        Username = "oscarfernando413",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfernandomartineznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél José",
                        LastName = "Pérez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 2, 17),
                        PhoneNumber = "+522569018003",
                        Email = "rafaeljoseperezmiranda138@hotmail.com",
                        Username = "rafaeljose362",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljoseperezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Jhonatan",
                        LastName = "Prado Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 12, 15),
                        PhoneNumber = "+525774502771",
                        Email = "alexanderjhonatanpradoramones334@hotmail.com",
                        Username = "alexanderjhonatan154",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjhonatanpradoramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Óscar",
                        LastName = "Ramones Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 10, 6),
                        PhoneNumber = "+520327124019",
                        Email = "danieloscarramonesmartinez485@hotmail.com",
                        Username = "danieloscar343",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieloscarramonesmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Moisés",
                        LastName = "León Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 6, 3),
                        PhoneNumber = "+524403330664",
                        Email = "gerardomoisesleonhiguera868@hotmail.com",
                        Username = "gerardomoises3",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardomoisesleonhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Christian",
                        LastName = "Fernández Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 6, 22),
                        PhoneNumber = "+521767832704",
                        Email = "aaronchristianfernandezjimenez526@hotmail.com",
                        Username = "aaronchristian888",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronchristianfernandezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Joaquin",
                        LastName = "Jiménez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 5, 5),
                        PhoneNumber = "+522804566866",
                        Email = "nicolasjoaquinjimenezdominguez603@hotmail.com",
                        Username = "nicolasjoaquin330",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasjoaquinjimenezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Sebastián",
                        LastName = "Trujillo Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 2, 2),
                        PhoneNumber = "+521517909014",
                        Email = "aaronsebastiantrujilloenriquez647@hotmail.com",
                        Username = "aaronsebastian64",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronsebastiantrujilloenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Ángel",
                        LastName = "Enríquez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 12, 18),
                        PhoneNumber = "+525021973699",
                        Email = "gabrielangelenriquezjuarez435@hotmail.com",
                        Username = "gabrielangel178",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielangelenriquezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Leonel",
                        LastName = "Quintero Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 9, 3),
                        PhoneNumber = "+527539383334",
                        Email = "christianleonelquinterocarrillo847@hotmail.com",
                        Username = "christianleonel132",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianleonelquinterocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Javier",
                        LastName = "Gómez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 1, 11),
                        PhoneNumber = "+522453093696",
                        Email = "alexanderjaviergomezbustamante426@hotmail.com",
                        Username = "alexanderjavier202",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjaviergomezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Jhonatan",
                        LastName = "Rodríguez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 9, 20),
                        PhoneNumber = "+523979431004",
                        Email = "christianjhonatanrodriguezfernandez875@hotmail.com",
                        Username = "christianjhonatan951",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianjhonatanrodriguezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Leonel",
                        LastName = "Higareda Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 8, 5),
                        PhoneNumber = "+527133721663",
                        Email = "fernandoleonelhigaredanevarez126@hotmail.com",
                        Username = "fernandoleonel350",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoleonelhigaredanevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél António",
                        LastName = "Jiménez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 6, 24),
                        PhoneNumber = "+525382069878",
                        Email = "rafaelantoniojimenezhiguera158@hotmail.com",
                        Username = "rafaelantonio199",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelantoniojimenezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Amadeus",
                        LastName = "Juárez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 12, 4),
                        PhoneNumber = "+523946680999",
                        Email = "felipeamadeusjuarezcontreras307@hotmail.com",
                        Username = "felipeamadeus846",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeamadeusjuarezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Estéban",
                        LastName = "Jiménez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 5, 21),
                        PhoneNumber = "+527547912453",
                        Email = "miguelestebanjimenezzavala568@hotmail.com",
                        Username = "miguelesteban752",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelestebanjimenezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Alexander",
                        LastName = "González Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 2, 3),
                        PhoneNumber = "+521261862428",
                        Email = "arturoalexandergonzalezmiranda434@hotmail.com",
                        Username = "arturoalexander562",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoalexandergonzalezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Manuel",
                        LastName = "Trujillo Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 12, 5),
                        PhoneNumber = "+521661188518",
                        Email = "federicomanueltrujilloconriquez577@hotmail.com",
                        Username = "federicomanuel105",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicomanueltrujilloconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Sebastián",
                        LastName = "Prado González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 9, 24),
                        PhoneNumber = "+522060876608",
                        Email = "federicosebastianpradogonzalez700@hotmail.com",
                        Username = "federicosebastian424",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicosebastianpradogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Óscar",
                        LastName = "Rodríguez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 1, 2),
                        PhoneNumber = "+524347199626",
                        Email = "alejandrooscarrodriguezrodriguez384@hotmail.com",
                        Username = "alejandrooscar358",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrooscarrodriguezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Luis",
                        LastName = "Quintero Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 5, 4),
                        PhoneNumber = "+524372052252",
                        Email = "gerardoluisquinterozavala771@hotmail.com",
                        Username = "gerardoluis0",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardoluisquinterozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Luis",
                        LastName = "Árce Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 10, 7),
                        PhoneNumber = "+526345125376",
                        Email = "alejandroluisarcecarrillo695@hotmail.com",
                        Username = "alejandroluis307",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroluisarcecarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Alexander",
                        LastName = "Juárez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 1, 23),
                        PhoneNumber = "+520182600466",
                        Email = "oscaralexanderjuareztrujillo704@hotmail.com",
                        Username = "oscaralexander254",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscaralexanderjuareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Joaquin",
                        LastName = "Pérez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 9, 5),
                        PhoneNumber = "+523968693575",
                        Email = "alexanderjoaquinperezjimenez734@hotmail.com",
                        Username = "alexanderjoaquin589",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjoaquinperezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Joaquin",
                        LastName = "Jiménez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 12, 23),
                        PhoneNumber = "+526163442603",
                        Email = "danieljoaquinjimenezprado735@hotmail.com",
                        Username = "danieljoaquin253",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieljoaquinjimenezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Christian",
                        LastName = "Pérez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 5, 11),
                        PhoneNumber = "+520075982064",
                        Email = "josechristianperezenriquez383@hotmail.com",
                        Username = "josechristian621",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josechristianperezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Ángel",
                        LastName = "Conriquez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 7, 27),
                        PhoneNumber = "+523207635238",
                        Email = "angelangelconriquezjimenez456@hotmail.com",
                        Username = "angelangel776",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelangelconriquezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Aarón",
                        LastName = "Trujillo López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 3, 6),
                        PhoneNumber = "+529087045303",
                        Email = "gabrielaarontrujillolopez51@hotmail.com",
                        Username = "gabrielaaron244",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielaarontrujillolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Rafaél",
                        LastName = "Quintero Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 1, 6),
                        PhoneNumber = "+521413900983",
                        Email = "rafaelrafaelquinterofernandez175@hotmail.com",
                        Username = "rafaelrafael630",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelrafaelquinterofernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin António",
                        LastName = "Enríquez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 1, 20),
                        PhoneNumber = "+525813848783",
                        Email = "joaquinantonioenriquezgonzali729@hotmail.com",
                        Username = "joaquinantonio655",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinantonioenriquezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Manuel",
                        LastName = "Higuera Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 3, 6),
                        PhoneNumber = "+528521692743",
                        Email = "aaronmanuelhiguerarodriguez910@hotmail.com",
                        Username = "aaronmanuel143",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmanuelhiguerarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Felipe",
                        LastName = "Contreras León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 11, 11),
                        PhoneNumber = "+524513354155",
                        Email = "rafaelfelipecontrerasleon454@hotmail.com",
                        Username = "rafaelfelipe248",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfelipecontrerasleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro António",
                        LastName = "Carrillo López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 9, 19),
                        PhoneNumber = "+520087536753",
                        Email = "alejandroantoniocarrillolopez923@hotmail.com",
                        Username = "alejandroantonio556",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroantoniocarrillolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Amadeus",
                        LastName = "Castrejón Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 4, 23),
                        PhoneNumber = "+520655226710",
                        Email = "alexanderamadeuscastrejonenriquez92@hotmail.com",
                        Username = "alexanderamadeus594",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderamadeuscastrejonenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Fabrizio",
                        LastName = "Lastra Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 3, 18),
                        PhoneNumber = "+527493016175",
                        Email = "angelfabriziolastraenriquez907@hotmail.com",
                        Username = "angelfabrizio975",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelfabriziolastraenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Jhonatan",
                        LastName = "González Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 10, 12),
                        PhoneNumber = "+522105858217",
                        Email = "joaquinjhonatangonzalezperez599@hotmail.com",
                        Username = "joaquinjhonatan756",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinjhonatangonzalezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Moisés",
                        LastName = "Higareda Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 5, 8),
                        PhoneNumber = "+526855778851",
                        Email = "javiermoiseshigaredarodriguez470@hotmail.com",
                        Username = "javiermoises802",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiermoiseshigaredarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Miguel",
                        LastName = "Contreras León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 10, 14),
                        PhoneNumber = "+525180524009",
                        Email = "eliazarmiguelcontrerasleon309@hotmail.com",
                        Username = "eliazarmiguel652",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarmiguelcontrerasleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Felipe",
                        LastName = "Zavala Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 8, 18),
                        PhoneNumber = "+523706247066",
                        Email = "arturofelipezavalaramones313@hotmail.com",
                        Username = "arturofelipe431",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturofelipezavalaramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin António",
                        LastName = "Quintero Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 6, 15),
                        PhoneNumber = "+528844221982",
                        Email = "joaquinantonioquinterotrujillo418@hotmail.com",
                        Username = "joaquinantonio402",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinantonioquinterotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Fernando",
                        LastName = "Aguirre Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 10, 17),
                        PhoneNumber = "+524060676264",
                        Email = "fitzgeraldfernandoaguirreramones900@hotmail.com",
                        Username = "fitzgeraldfernando284",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfernandoaguirreramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Arturo",
                        LastName = "Gómez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 12, 2),
                        PhoneNumber = "+529491786302",
                        Email = "oscararturogomezperez279@hotmail.com",
                        Username = "oscararturo545",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscararturogomezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Manuel",
                        LastName = "Rodríguez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 4, 16),
                        PhoneNumber = "+520658892683",
                        Email = "eliazarmanuelrodriguezcastrejon235@hotmail.com",
                        Username = "eliazarmanuel810",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarmanuelrodriguezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fitzgerald",
                        LastName = "Domínguez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 6, 12),
                        PhoneNumber = "+528893905507",
                        Email = "danielfitzgeralddominguezgonzali446@hotmail.com",
                        Username = "danielfitzgerald869",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfitzgeralddominguezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Aarón",
                        LastName = "Fernández González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 3, 8),
                        PhoneNumber = "+525852602532",
                        Email = "rafaelaaronfernandezgonzalez25@hotmail.com",
                        Username = "rafaelaaron102",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelaaronfernandezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Sebastián",
                        LastName = "Enríquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 8, 10),
                        PhoneNumber = "+525085076606",
                        Email = "fitzgeraldsebastianenriquezrodriguez323@hotmail.com",
                        Username = "fitzgeraldsebastian141",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldsebastianenriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Fitzgerald",
                        LastName = "Martínez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 2, 14),
                        PhoneNumber = "+529055026877",
                        Email = "juanfitzgeraldmartinezgamez377@hotmail.com",
                        Username = "juanfitzgerald107",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanfitzgeraldmartinezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Gerardo",
                        LastName = "Carrillo Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 12, 6),
                        PhoneNumber = "+524092366634",
                        Email = "javiergerardocarrillodominguez292@hotmail.com",
                        Username = "javiergerardo650",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiergerardocarrillodominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Daniel",
                        LastName = "Aguirre Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 4, 10),
                        PhoneNumber = "+528397858776",
                        Email = "migueldanielaguirreperez153@hotmail.com",
                        Username = "migueldaniel199",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueldanielaguirreperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Manuel",
                        LastName = "Fernández Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 5, 3),
                        PhoneNumber = "+521227014602",
                        Email = "gerardomanuelfernandezarce105@hotmail.com",
                        Username = "gerardomanuel975",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardomanuelfernandezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Jhonatan",
                        LastName = "Aguirre Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 5, 6),
                        PhoneNumber = "+523598565919",
                        Email = "federicojhonatanaguirreramones719@hotmail.com",
                        Username = "federicojhonatan763",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicojhonatanaguirreramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Nicolás",
                        LastName = "Jiménez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 12, 9),
                        PhoneNumber = "+524982894072",
                        Email = "fabrizionicolasjimenezaguirre368@hotmail.com",
                        Username = "fabrizionicolas661",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizionicolasjimenezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Fabrizio",
                        LastName = "Gonzalí Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 11, 5),
                        PhoneNumber = "+520769967921",
                        Email = "sebastianfabriziogonzaliaguirre641@hotmail.com",
                        Username = "sebastianfabrizio148",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianfabriziogonzaliaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Moisés",
                        LastName = "Domínguez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 9, 17),
                        PhoneNumber = "+526908374909",
                        Email = "sebastianmoisesdominguezjimenez564@hotmail.com",
                        Username = "sebastianmoises858",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianmoisesdominguezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Leonel",
                        LastName = "Carrillo Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 12, 19),
                        PhoneNumber = "+525743548744",
                        Email = "arturoleonelcarrillohiguera744@hotmail.com",
                        Username = "arturoleonel584",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoleonelcarrillohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Nicolás",
                        LastName = "Ramones Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 4, 4),
                        PhoneNumber = "+520570874888",
                        Email = "josenicolasramonesgonzali109@hotmail.com",
                        Username = "josenicolas879",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josenicolasramonesgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Gabriel",
                        LastName = "Gonzalí Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 7, 5),
                        PhoneNumber = "+529941783922",
                        Email = "alejandrogabrielgonzaliquintero221@hotmail.com",
                        Username = "alejandrogabriel204",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrogabrielgonzaliquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Leonel",
                        LastName = "Juárez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 12, 16),
                        PhoneNumber = "+521399395506",
                        Email = "antonioleoneljuarezlastra171@hotmail.com",
                        Username = "antonioleonel959",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioleoneljuarezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Fitzgerald",
                        LastName = "Gonzalí Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 6, 11),
                        PhoneNumber = "+521250025360",
                        Email = "miguelfitzgeraldgonzalijimenez82@hotmail.com",
                        Username = "miguelfitzgerald206",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelfitzgeraldgonzalijimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel José",
                        LastName = "Quintero Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 5, 7),
                        PhoneNumber = "+527474790905",
                        Email = "leoneljosequinteroperez645@hotmail.com",
                        Username = "leoneljose267",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leoneljosequinteroperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Amadeus",
                        LastName = "Juárez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 11, 26),
                        PhoneNumber = "+524514023665",
                        Email = "antonioamadeusjuarezfernandez418@hotmail.com",
                        Username = "antonioamadeus498",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioamadeusjuarezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Javier",
                        LastName = "Contreras López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 9, 6),
                        PhoneNumber = "+523515427299",
                        Email = "joaquinjaviercontreraslopez877@hotmail.com",
                        Username = "joaquinjavier628",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinjaviercontreraslopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Javier",
                        LastName = "Contreras Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 10, 10),
                        PhoneNumber = "+528152396847",
                        Email = "nicolasjaviercontreraslastra453@hotmail.com",
                        Username = "nicolasjavier69",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasjaviercontreraslastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Fernando",
                        LastName = "Juárez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 6, 3),
                        PhoneNumber = "+523377241309",
                        Email = "oscarfernandojuarezclaro591@hotmail.com",
                        Username = "oscarfernando179",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfernandojuarezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Javier",
                        LastName = "Gonzalí Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 2, 1),
                        PhoneNumber = "+527236690950",
                        Email = "luisjaviergonzalibustamante523@hotmail.com",
                        Username = "luisjavier25",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjaviergonzalibustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Luis",
                        LastName = "Conriquez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 2, 4),
                        PhoneNumber = "+525157023173",
                        Email = "alexanderluisconriquezjimenez41@hotmail.com",
                        Username = "alexanderluis260",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderluisconriquezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Amadeus",
                        LastName = "Rodríguez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 11, 14),
                        PhoneNumber = "+525395579605",
                        Email = "carlosamadeusrodriguezclaro398@hotmail.com",
                        Username = "carlosamadeus157",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosamadeusrodriguezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Daniel",
                        LastName = "Pérez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 11, 11),
                        PhoneNumber = "+522556620933",
                        Email = "oscardanielperezfernandez322@hotmail.com",
                        Username = "oscardaniel74",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscardanielperezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Nicolás",
                        LastName = "Gómez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 9, 18),
                        PhoneNumber = "+524167767427",
                        Email = "jhonatannicolasgomezleon515@hotmail.com",
                        Username = "jhonatannicolas844",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatannicolasgomezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Christian",
                        LastName = "Trujillo Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 8, 8),
                        PhoneNumber = "+526712482930",
                        Email = "fitzgeraldchristiantrujilloprado906@hotmail.com",
                        Username = "fitzgeraldchristian658",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldchristiantrujilloprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Estéban",
                        LastName = "Fernández Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 12, 15),
                        PhoneNumber = "+525159425792",
                        Email = "oscarestebanfernandeznevarez891@hotmail.com",
                        Username = "oscaresteban283",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarestebanfernandeznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Alejandro",
                        LastName = "Claro Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 11, 2),
                        PhoneNumber = "+527962411593",
                        Email = "danielalejandroclaroconriquez869@hotmail.com",
                        Username = "danielalejandro497",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielalejandroclaroconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Ángel",
                        LastName = "Álvarez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 2, 2),
                        PhoneNumber = "+525210322370",
                        Email = "fernandoangelalvarezmartinez561@hotmail.com",
                        Username = "fernandoangel302",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoangelalvarezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Leonel",
                        LastName = "Aguirre Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 10, 12),
                        PhoneNumber = "+521736334436",
                        Email = "estebanleonelaguirreperez915@hotmail.com",
                        Username = "estebanleonel210",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanleonelaguirreperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Luis",
                        LastName = "Jiménez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 4, 27),
                        PhoneNumber = "+527171750639",
                        Email = "javierluisjimenezclaro224@hotmail.com",
                        Username = "javierluis845",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierluisjimenezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Fabrizio",
                        LastName = "Conriquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 5, 3),
                        PhoneNumber = "+525086920156",
                        Email = "josefabrizioconriquezrodriguez793@hotmail.com",
                        Username = "josefabrizio969",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefabrizioconriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Carlos",
                        LastName = "Enríquez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 6, 13),
                        PhoneNumber = "+524057478180",
                        Email = "moisescarlosenriquezarce702@hotmail.com",
                        Username = "moisescarlos844",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisescarlosenriquezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Fernando",
                        LastName = "Quintero Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 6, 1),
                        PhoneNumber = "+522819271127",
                        Email = "alexanderfernandoquinteroperez348@hotmail.com",
                        Username = "alexanderfernando781",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfernandoquinteroperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian José",
                        LastName = "Nevárez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 6, 10),
                        PhoneNumber = "+524510506691",
                        Email = "christianjosenevarezjimenez114@hotmail.com",
                        Username = "christianjose80",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianjosenevarezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Gerardo",
                        LastName = "Gómez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 2, 17),
                        PhoneNumber = "+527566014438",
                        Email = "joaquingerardogomezgomez317@hotmail.com",
                        Username = "joaquingerardo124",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquingerardogomezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Joaquin",
                        LastName = "González Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 11, 16),
                        PhoneNumber = "+520988575246",
                        Email = "migueljoaquingonzalezperez336@hotmail.com",
                        Username = "migueljoaquin58",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljoaquingonzalezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Arturo",
                        LastName = "Quintero Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 7, 7),
                        PhoneNumber = "+520013216579",
                        Email = "aaronarturoquinterohiguera148@hotmail.com",
                        Username = "aaronarturo346",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronarturoquinterohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos António",
                        LastName = "Gómez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 3, 15),
                        PhoneNumber = "+520109362333",
                        Email = "carlosantoniogomezprado666@hotmail.com",
                        Username = "carlosantonio440",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosantoniogomezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Miguel",
                        LastName = "Claro Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 11, 5),
                        PhoneNumber = "+526550133664",
                        Email = "aaronmiguelclaroalvarez472@hotmail.com",
                        Username = "aaronmiguel593",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmiguelclaroalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Jhonatan",
                        LastName = "Gámez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 7, 13),
                        PhoneNumber = "+520280742985",
                        Email = "felipejhonatangamezrodriguez951@hotmail.com",
                        Username = "felipejhonatan719",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipejhonatangamezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Miguel",
                        LastName = "Gámez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 1, 19),
                        PhoneNumber = "+522692450165",
                        Email = "javiermiguelgamezenriquez800@hotmail.com",
                        Username = "javiermiguel863",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiermiguelgamezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Luis",
                        LastName = "Lastra Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 2, 9),
                        PhoneNumber = "+524531152999",
                        Email = "alejandroluislastralastra245@hotmail.com",
                        Username = "alejandroluis681",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroluislastralastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Felipe",
                        LastName = "Pérez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 3, 27),
                        PhoneNumber = "+522288538794",
                        Email = "moisesfelipeperezperez679@hotmail.com",
                        Username = "moisesfelipe446",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesfelipeperezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Fernando",
                        LastName = "Juárez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 6, 9),
                        PhoneNumber = "+527950183814",
                        Email = "gerardofernandojuareztrujillo479@hotmail.com",
                        Username = "gerardofernando542",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofernandojuareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Nicolás",
                        LastName = "Claro Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 4, 5),
                        PhoneNumber = "+528270411975",
                        Email = "luisnicolasclarobustamante694@hotmail.com",
                        Username = "luisnicolas379",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisnicolasclarobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Estéban",
                        LastName = "Pérez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 5, 3),
                        PhoneNumber = "+521998064563",
                        Email = "antonioestebanperezcontreras68@hotmail.com",
                        Username = "antonioesteban208",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioestebanperezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Eliazar",
                        LastName = "Nevárez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 2, 13),
                        PhoneNumber = "+525139337072",
                        Email = "fitzgeraldeliazarnevareztrujillo16@hotmail.com",
                        Username = "fitzgeraldeliazar505",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldeliazarnevareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Javier",
                        LastName = "Zavala Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 9, 27),
                        PhoneNumber = "+527760757096",
                        Email = "fitzgeraldjavierzavalaaguirre41@hotmail.com",
                        Username = "fitzgeraldjavier689",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldjavierzavalaaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Miguel",
                        LastName = "Miranda Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 6, 4),
                        PhoneNumber = "+522964484049",
                        Email = "danielmiguelmirandanevarez739@hotmail.com",
                        Username = "danielmiguel993",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielmiguelmirandanevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Christian",
                        LastName = "Zavala Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 10, 1),
                        PhoneNumber = "+520787083362",
                        Email = "joaquinchristianzavalaperez411@hotmail.com",
                        Username = "joaquinchristian492",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinchristianzavalaperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Conriquez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 10, 7),
                        PhoneNumber = "+526005367776",
                        Email = "moisesestebanconriquezleon972@hotmail.com",
                        Username = "moisesesteban751",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebanconriquezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Nicolás",
                        LastName = "Higareda Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 9, 24),
                        PhoneNumber = "+524965605432",
                        Email = "estebannicolashigaredanevarez642@hotmail.com",
                        Username = "estebannicolas558",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebannicolashigaredanevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Luis",
                        LastName = "Claro Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 2, 6),
                        PhoneNumber = "+528864360585",
                        Email = "christianluisclarolastra981@hotmail.com",
                        Username = "christianluis814",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianluisclarolastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Sebastián",
                        LastName = "Claro Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 10, 18),
                        PhoneNumber = "+528035663924",
                        Email = "miguelsebastianclarohiguera127@hotmail.com",
                        Username = "miguelsebastian943",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelsebastianclarohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Óscar",
                        LastName = "Domínguez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 10, 1),
                        PhoneNumber = "+520561905248",
                        Email = "felipeoscardominguezjuarez502@hotmail.com",
                        Username = "felipeoscar9",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeoscardominguezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Carlos",
                        LastName = "Gonzalí León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 11, 1),
                        PhoneNumber = "+528188683667",
                        Email = "luiscarlosgonzalileon673@hotmail.com",
                        Username = "luiscarlos560",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luiscarlosgonzalileon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Carlos",
                        LastName = "Jiménez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 7, 9),
                        PhoneNumber = "+529691601273",
                        Email = "nicolascarlosjimenezgamez930@hotmail.com",
                        Username = "nicolascarlos704",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolascarlosjimenezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Christian",
                        LastName = "Juárez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 10, 10),
                        PhoneNumber = "+526475289210",
                        Email = "gabrielchristianjuarezcastrejon131@hotmail.com",
                        Username = "gabrielchristian145",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielchristianjuarezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Christian",
                        LastName = "Domínguez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 11, 21),
                        PhoneNumber = "+529988930981",
                        Email = "eliazarchristiandominguezperez925@hotmail.com",
                        Username = "eliazarchristian231",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarchristiandominguezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Daniel",
                        LastName = "Miranda León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 2, 20),
                        PhoneNumber = "+527345624762",
                        Email = "amadeusdanielmirandaleon193@hotmail.com",
                        Username = "amadeusdaniel992",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusdanielmirandaleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Alejandro",
                        LastName = "Ramones Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 11, 11),
                        PhoneNumber = "+527296976952",
                        Email = "carlosalejandroramonesarce661@hotmail.com",
                        Username = "carlosalejandro691",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosalejandroramonesarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Fernando",
                        LastName = "González Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 9, 8),
                        PhoneNumber = "+526543726629",
                        Email = "christianfernandogonzalezramones26@hotmail.com",
                        Username = "christianfernando890",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfernandogonzalezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Eliazar",
                        LastName = "Domínguez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 8, 18),
                        PhoneNumber = "+524571548365",
                        Email = "estebaneliazardominguezconriquez123@hotmail.com",
                        Username = "estebaneliazar975",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebaneliazardominguezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Felipe",
                        LastName = "Aguirre Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 9, 10),
                        PhoneNumber = "+525257327472",
                        Email = "luisfelipeaguirrearce326@hotmail.com",
                        Username = "luisfelipe700",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisfelipeaguirrearce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Moisés",
                        LastName = "Enríquez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 10, 9),
                        PhoneNumber = "+522864158154",
                        Email = "estebanmoisesenriquezenriquez105@hotmail.com",
                        Username = "estebanmoises304",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanmoisesenriquezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Luis",
                        LastName = "Gonzalí Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 9, 7),
                        PhoneNumber = "+526937586256",
                        Email = "leonelluisgonzaliarce695@hotmail.com",
                        Username = "leonelluis784",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelluisgonzaliarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Fernando",
                        LastName = "Bustamante Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 10, 25),
                        PhoneNumber = "+522699452971",
                        Email = "alejandrofernandobustamantehiguera162@hotmail.com",
                        Username = "alejandrofernando900",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofernandobustamantehiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Federico",
                        LastName = "Gámez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 9, 11),
                        PhoneNumber = "+522663600788",
                        Email = "sebastianfedericogamezcastrejon885@hotmail.com",
                        Username = "sebastianfederico100",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianfedericogamezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Enríquez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 1, 20),
                        PhoneNumber = "+526205147049",
                        Email = "moisesestebanenriquezhigareda238@hotmail.com",
                        Username = "moisesesteban812",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebanenriquezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Fitzgerald",
                        LastName = "Fernández Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 7, 14),
                        PhoneNumber = "+521296456563",
                        Email = "jhonatanfitzgeraldfernandezperez531@hotmail.com",
                        Username = "jhonatanfitzgerald531",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanfitzgeraldfernandezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Federico",
                        LastName = "Carrillo Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 5, 22),
                        PhoneNumber = "+528832136278",
                        Email = "alexanderfedericocarrillojuarez390@hotmail.com",
                        Username = "alexanderfederico54",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfedericocarrillojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Javier",
                        LastName = "Castrejón Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 1, 12),
                        PhoneNumber = "+520648806082",
                        Email = "luisjaviercastrejonclaro651@hotmail.com",
                        Username = "luisjavier74",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjaviercastrejonclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Carlos",
                        LastName = "Martínez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 12, 26),
                        PhoneNumber = "+529499226808",
                        Email = "leonelcarlosmartinezprado461@hotmail.com",
                        Username = "leonelcarlos718",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelcarlosmartinezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Amadeus",
                        LastName = "Fernández González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 3, 21),
                        PhoneNumber = "+526568042581",
                        Email = "christianamadeusfernandezgonzalez592@hotmail.com",
                        Username = "christianamadeus769",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianamadeusfernandezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Christian",
                        LastName = "Contreras Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 10, 27),
                        PhoneNumber = "+524262004428",
                        Email = "fitzgeraldchristiancontrerasramones880@hotmail.com",
                        Username = "fitzgeraldchristian793",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldchristiancontrerasramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Rafaél",
                        LastName = "Gómez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 12, 27),
                        PhoneNumber = "+527148656233",
                        Email = "gerardorafaelgomezzavala361@hotmail.com",
                        Username = "gerardorafael191",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardorafaelgomezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Leonel",
                        LastName = "Domínguez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 7, 20),
                        PhoneNumber = "+521882046881",
                        Email = "luisleoneldominguezramones688@hotmail.com",
                        Username = "luisleonel502",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisleoneldominguezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Joaquin",
                        LastName = "Gómez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 2, 3),
                        PhoneNumber = "+521960860019",
                        Email = "migueljoaquingomeznevarez213@hotmail.com",
                        Username = "migueljoaquin253",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljoaquingomeznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Aarón",
                        LastName = "Bustamante Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 12, 14),
                        PhoneNumber = "+528519463164",
                        Email = "javieraaronbustamantequintero333@hotmail.com",
                        Username = "javieraaron4",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieraaronbustamantequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Alexander",
                        LastName = "Conriquez González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 7, 9),
                        PhoneNumber = "+524757450537",
                        Email = "oscaralexanderconriquezgonzalez148@hotmail.com",
                        Username = "oscaralexander395",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscaralexanderconriquezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Moisés",
                        LastName = "Higareda Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 5, 16),
                        PhoneNumber = "+525170240365",
                        Email = "christianmoiseshigaredamartinez499@hotmail.com",
                        Username = "christianmoises324",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianmoiseshigaredamartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Gerardo",
                        LastName = "Martínez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 1),
                        PhoneNumber = "+528736998027",
                        Email = "manuelgerardomartinezjuarez723@hotmail.com",
                        Username = "manuelgerardo207",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelgerardomartinezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Alexander",
                        LastName = "Higuera Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 11, 8),
                        PhoneNumber = "+524695582033",
                        Email = "federicoalexanderhigueraalvarez195@hotmail.com",
                        Username = "federicoalexander309",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoalexanderhigueraalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Arturo",
                        LastName = "Gonzalí León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 2, 27),
                        PhoneNumber = "+525476880106",
                        Email = "luisarturogonzalileon677@hotmail.com",
                        Username = "luisarturo559",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisarturogonzalileon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Javier",
                        LastName = "Martínez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 6, 25),
                        PhoneNumber = "+524427865856",
                        Email = "fitzgeraldjaviermartinezcastrejon661@hotmail.com",
                        Username = "fitzgeraldjavier668",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldjaviermartinezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Miguel",
                        LastName = "Carrillo Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 4, 15),
                        PhoneNumber = "+522350664009",
                        Email = "amadeusmiguelcarrilloperez106@hotmail.com",
                        Username = "amadeusmiguel674",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusmiguelcarrilloperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Miguel",
                        LastName = "Gámez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 11, 19),
                        PhoneNumber = "+522669603039",
                        Email = "leonelmiguelgamezhiguera443@hotmail.com",
                        Username = "leonelmiguel57",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelmiguelgamezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Gabriel",
                        LastName = "Quintero Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 6, 3),
                        PhoneNumber = "+522596177779",
                        Email = "christiangabrielquinterorodriguez176@hotmail.com",
                        Username = "christiangabriel214",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiangabrielquinterorodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Luis",
                        LastName = "Lastra Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 4, 10),
                        PhoneNumber = "+522813111516",
                        Email = "antonioluislastraclaro249@hotmail.com",
                        Username = "antonioluis917",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioluislastraclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Carlos",
                        LastName = "Domínguez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 4, 26),
                        PhoneNumber = "+524222141180",
                        Email = "fabriziocarlosdominguezgomez521@hotmail.com",
                        Username = "fabriziocarlos457",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziocarlosdominguezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Miguel",
                        LastName = "Quintero León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 1, 10),
                        PhoneNumber = "+521504371508",
                        Email = "miguelmiguelquinteroleon131@hotmail.com",
                        Username = "miguelmiguel613",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelmiguelquinteroleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Carlos",
                        LastName = "Ramones Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 11, 6),
                        PhoneNumber = "+527026459218",
                        Email = "luiscarlosramonesgomez156@hotmail.com",
                        Username = "luiscarlos539",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luiscarlosramonesgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Ángel",
                        LastName = "González Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 1, 25),
                        PhoneNumber = "+521654677202",
                        Email = "fitzgeraldangelgonzalezprado690@hotmail.com",
                        Username = "fitzgeraldangel216",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldangelgonzalezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Rafaél",
                        LastName = "Prado López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 10, 5),
                        PhoneNumber = "+529944117471",
                        Email = "arturorafaelpradolopez57@hotmail.com",
                        Username = "arturorafael684",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturorafaelpradolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Alexander",
                        LastName = "Carrillo Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 3, 19),
                        PhoneNumber = "+524388401153",
                        Email = "amadeusalexandercarrillorodriguez947@hotmail.com",
                        Username = "amadeusalexander978",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusalexandercarrillorodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Amadeus",
                        LastName = "Gómez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 9, 10),
                        PhoneNumber = "+520764699650",
                        Email = "alejandroamadeusgomezconriquez805@hotmail.com",
                        Username = "alejandroamadeus729",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroamadeusgomezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Óscar",
                        LastName = "Jiménez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 12, 17),
                        PhoneNumber = "+522770428242",
                        Email = "fabriziooscarjimenezjimenez507@hotmail.com",
                        Username = "fabriziooscar695",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziooscarjimenezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fernando",
                        LastName = "Fernández Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 9, 19),
                        PhoneNumber = "+527088518615",
                        Email = "danielfernandofernandeztrujillo643@hotmail.com",
                        Username = "danielfernando563",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfernandofernandeztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Estéban",
                        LastName = "Ramones Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 4, 26),
                        PhoneNumber = "+524338836968",
                        Email = "antonioestebanramoneshiguera684@hotmail.com",
                        Username = "antonioesteban830",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioestebanramoneshiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Manuel",
                        LastName = "Miranda Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 3, 6),
                        PhoneNumber = "+524258028540",
                        Email = "josemanuelmirandatrujillo207@hotmail.com",
                        Username = "josemanuel182",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josemanuelmirandatrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Gerardo",
                        LastName = "Carrillo Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 8, 4),
                        PhoneNumber = "+527986003153",
                        Email = "fernandogerardocarrillocarrillo726@hotmail.com",
                        Username = "fernandogerardo252",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandogerardocarrillocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Aarón",
                        LastName = "Pérez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 3, 10),
                        PhoneNumber = "+526789033486",
                        Email = "estebanaaronperezhiguera940@hotmail.com",
                        Username = "estebanaaron994",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanaaronperezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Nicolás",
                        LastName = "Castrejón Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 11, 21),
                        PhoneNumber = "+526843237071",
                        Email = "joaquinnicolascastrejonquintero117@hotmail.com",
                        Username = "joaquinnicolas101",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinnicolascastrejonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Eliazar",
                        LastName = "Contreras Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 4, 6),
                        PhoneNumber = "+524345745434",
                        Email = "rafaeleliazarcontrerasalvarez776@hotmail.com",
                        Username = "rafaeleliazar218",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeleliazarcontrerasalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Amadeus",
                        LastName = "Carrillo Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 4, 18),
                        PhoneNumber = "+522662329152",
                        Email = "aaronamadeuscarrilloperez595@hotmail.com",
                        Username = "aaronamadeus705",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronamadeuscarrilloperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Manuel",
                        LastName = "Bustamante Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 3, 17),
                        PhoneNumber = "+523514882310",
                        Email = "christianmanuelbustamanterodriguez430@hotmail.com",
                        Username = "christianmanuel798",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianmanuelbustamanterodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Luis",
                        LastName = "Enríquez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 8, 2),
                        PhoneNumber = "+521473681181",
                        Email = "rafaelluisenriquezlopez777@hotmail.com",
                        Username = "rafaelluis981",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelluisenriquezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián António",
                        LastName = "Álvarez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 5, 17),
                        PhoneNumber = "+528722977264",
                        Email = "sebastianantonioalvarezlastra438@hotmail.com",
                        Username = "sebastianantonio110",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianantonioalvarezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Nicolás",
                        LastName = "Castrejón Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 9, 12),
                        PhoneNumber = "+526910532888",
                        Email = "leonelnicolascastrejonmiranda143@hotmail.com",
                        Username = "leonelnicolas178",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelnicolascastrejonmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Fabrizio",
                        LastName = "Ramones Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 8, 9),
                        PhoneNumber = "+520382283170",
                        Email = "miguelfabrizioramonesdominguez713@hotmail.com",
                        Username = "miguelfabrizio474",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelfabrizioramonesdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Manuel",
                        LastName = "León González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 2, 3),
                        PhoneNumber = "+527157145931",
                        Email = "danielmanuelleongonzalez572@hotmail.com",
                        Username = "danielmanuel581",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielmanuelleongonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Christian",
                        LastName = "Carrillo Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 1, 11),
                        PhoneNumber = "+526165506010",
                        Email = "sebastianchristiancarrilloquintero309@hotmail.com",
                        Username = "sebastianchristian947",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianchristiancarrilloquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Alexander",
                        LastName = "Contreras Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 7, 25),
                        PhoneNumber = "+524193833466",
                        Email = "eliazaralexandercontrerasgonzali186@hotmail.com",
                        Username = "eliazaralexander929",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazaralexandercontrerasgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Joaquin",
                        LastName = "Domínguez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 5, 17),
                        PhoneNumber = "+524244027954",
                        Email = "felipejoaquindominguezprado869@hotmail.com",
                        Username = "felipejoaquin863",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipejoaquindominguezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Sebastián",
                        LastName = "Juárez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 10, 16),
                        PhoneNumber = "+521042128862",
                        Email = "josesebastianjuarezcontreras488@hotmail.com",
                        Username = "josesebastian223",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josesebastianjuarezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Óscar",
                        LastName = "Domínguez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 12, 23),
                        PhoneNumber = "+523829565043",
                        Email = "felipeoscardominguezrodriguez195@hotmail.com",
                        Username = "felipeoscar536",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeoscardominguezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Alejandro",
                        LastName = "Zavala León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 12, 13),
                        PhoneNumber = "+528297844981",
                        Email = "sebastianalejandrozavalaleon535@hotmail.com",
                        Username = "sebastianalejandro432",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianalejandrozavalaleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel José",
                        LastName = "Gómez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 4, 26),
                        PhoneNumber = "+521557300129",
                        Email = "danieljosegomeztrujillo974@hotmail.com",
                        Username = "danieljose273",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieljosegomeztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Fernando",
                        LastName = "Pérez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 3, 25),
                        PhoneNumber = "+520227791394",
                        Email = "manuelfernandoperezgomez830@hotmail.com",
                        Username = "manuelfernando231",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelfernandoperezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Eliazar",
                        LastName = "Rodríguez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 8, 1),
                        PhoneNumber = "+528259226516",
                        Email = "federicoeliazarrodriguezarce713@hotmail.com",
                        Username = "federicoeliazar509",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoeliazarrodriguezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Javier",
                        LastName = "Higuera Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 12, 16),
                        PhoneNumber = "+521877412875",
                        Email = "fitzgeraldjavierhigueraperez817@hotmail.com",
                        Username = "fitzgeraldjavier22",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldjavierhigueraperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel António",
                        LastName = "Gonzalí Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 7, 19),
                        PhoneNumber = "+527639879247",
                        Email = "gabrielantoniogonzalinevarez420@hotmail.com",
                        Username = "gabrielantonio895",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielantoniogonzalinevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Aarón",
                        LastName = "Miranda Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 6, 13),
                        PhoneNumber = "+524497524927",
                        Email = "federicoaaronmirandadominguez856@hotmail.com",
                        Username = "federicoaaron172",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoaaronmirandadominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Juan",
                        LastName = "González González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 5, 6),
                        PhoneNumber = "+526678279577",
                        Email = "antoniojuangonzalezgonzalez657@hotmail.com",
                        Username = "antoniojuan599",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniojuangonzalezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Sebastián",
                        LastName = "Gonzalí Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 1, 26),
                        PhoneNumber = "+528060570191",
                        Email = "danielsebastiangonzalihiguera500@hotmail.com",
                        Username = "danielsebastian541",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielsebastiangonzalihiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Moisés",
                        LastName = "Enríquez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 3, 22),
                        PhoneNumber = "+529046092994",
                        Email = "aaronmoisesenriquezconriquez216@hotmail.com",
                        Username = "aaronmoises395",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronmoisesenriquezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Rafaél",
                        LastName = "Fernández Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 9, 5),
                        PhoneNumber = "+521381926912",
                        Email = "carlosrafaelfernandeztrujillo550@hotmail.com",
                        Username = "carlosrafael288",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosrafaelfernandeztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Gonzalí Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 5, 10),
                        PhoneNumber = "+525578947642",
                        Email = "moisesestebangonzalicarrillo370@hotmail.com",
                        Username = "moisesesteban636",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebangonzalicarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Juan",
                        LastName = "Higareda López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 7, 13),
                        PhoneNumber = "+526151716788",
                        Email = "alexanderjuanhigaredalopez336@hotmail.com",
                        Username = "alexanderjuan987",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjuanhigaredalopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Moisés",
                        LastName = "Fernández Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 3, 20),
                        PhoneNumber = "+520041846865",
                        Email = "fernandomoisesfernandezfernandez227@hotmail.com",
                        Username = "fernandomoises279",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandomoisesfernandezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Eliazar",
                        LastName = "Castrejón Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 1, 8),
                        PhoneNumber = "+523056142975",
                        Email = "migueleliazarcastrejonmartinez411@hotmail.com",
                        Username = "migueleliazar19",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueleliazarcastrejonmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Juan",
                        LastName = "Gómez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 10, 8),
                        PhoneNumber = "+522844939455",
                        Email = "rafaeljuangomezlastra484@hotmail.com",
                        Username = "rafaeljuan953",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljuangomezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Manuel",
                        LastName = "Castrejón Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 4, 12),
                        PhoneNumber = "+520233501184",
                        Email = "gerardomanuelcastrejoncontreras305@hotmail.com",
                        Username = "gerardomanuel926",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardomanuelcastrejoncontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Fabrizio",
                        LastName = "Juárez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 6, 6),
                        PhoneNumber = "+526521224412",
                        Email = "christianfabriziojuarezgomez358@hotmail.com",
                        Username = "christianfabrizio912",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianfabriziojuarezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Nicolás",
                        LastName = "Enríquez León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 11, 15),
                        PhoneNumber = "+523698105288",
                        Email = "fernandonicolasenriquezleon807@hotmail.com",
                        Username = "fernandonicolas31",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandonicolasenriquezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António José",
                        LastName = "Pérez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 9, 25),
                        PhoneNumber = "+522927792483",
                        Email = "antoniojoseperezhigareda424@hotmail.com",
                        Username = "antoniojose319",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniojoseperezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Christian",
                        LastName = "León Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 4, 9),
                        PhoneNumber = "+521789034367",
                        Email = "fernandochristianleonclaro206@hotmail.com",
                        Username = "fernandochristian80",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandochristianleonclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Leonel",
                        LastName = "Claro González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 8, 27),
                        PhoneNumber = "+526618203583",
                        Email = "miguelleonelclarogonzalez920@hotmail.com",
                        Username = "miguelleonel434",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelleonelclarogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Aarón",
                        LastName = "Domínguez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 1, 13),
                        PhoneNumber = "+524331040911",
                        Email = "miguelaarondominguezcarrillo768@hotmail.com",
                        Username = "miguelaaron602",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelaarondominguezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Gerardo",
                        LastName = "Trujillo Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 10, 20),
                        PhoneNumber = "+520318399285",
                        Email = "javiergerardotrujillogomez19@hotmail.com",
                        Username = "javiergerardo396",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiergerardotrujillogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Felipe",
                        LastName = "Conriquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 2, 14),
                        PhoneNumber = "+527161012800",
                        Email = "sebastianfelipeconriquezrodriguez242@hotmail.com",
                        Username = "sebastianfelipe87",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianfelipeconriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Alexander",
                        LastName = "Árce Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 5, 5),
                        PhoneNumber = "+526886387230",
                        Email = "josealexanderarcequintero98@hotmail.com",
                        Username = "josealexander66",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josealexanderarcequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Leonel",
                        LastName = "Prado Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 1, 22),
                        PhoneNumber = "+527832506681",
                        Email = "felipeleonelpradohiguera29@hotmail.com",
                        Username = "felipeleonel417",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeleonelpradohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Miguel",
                        LastName = "Jiménez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 11, 1),
                        PhoneNumber = "+526417241741",
                        Email = "moisesmigueljimenezjimenez371@hotmail.com",
                        Username = "moisesmiguel283",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesmigueljimenezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Joaquin",
                        LastName = "Fernández Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 3, 13),
                        PhoneNumber = "+525656247210",
                        Email = "alexanderjoaquinfernandezrodriguez85@hotmail.com",
                        Username = "alexanderjoaquin55",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjoaquinfernandezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Daniel",
                        LastName = "González Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 3, 10),
                        PhoneNumber = "+521802590316",
                        Email = "danieldanielgonzalezcarrillo519@hotmail.com",
                        Username = "danieldaniel93",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danieldanielgonzalezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Juan",
                        LastName = "Fernández Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 1),
                        PhoneNumber = "+521392310950",
                        Email = "juanjuanfernandezaguirre690@hotmail.com",
                        Username = "juanjuan933",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanjuanfernandezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Daniel",
                        LastName = "Contreras Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 10, 15),
                        PhoneNumber = "+523873809087",
                        Email = "migueldanielcontrerasmartinez607@hotmail.com",
                        Username = "migueldaniel68",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueldanielcontrerasmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Christian",
                        LastName = "Castrejón González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 5, 3),
                        PhoneNumber = "+529141477321",
                        Email = "gabrielchristiancastrejongonzalez806@hotmail.com",
                        Username = "gabrielchristian793",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielchristiancastrejongonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Amadeus",
                        LastName = "Ramones Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 2, 17),
                        PhoneNumber = "+521333245085",
                        Email = "javieramadeusramonesenriquez492@hotmail.com",
                        Username = "javieramadeus95",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieramadeusramonesenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Eliazar",
                        LastName = "Claro Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 8, 9),
                        PhoneNumber = "+525517376152",
                        Email = "angeleliazarclarotrujillo444@hotmail.com",
                        Username = "angeleliazar379",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angeleliazarclarotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Federico",
                        LastName = "López Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 11, 24),
                        PhoneNumber = "+520545791546",
                        Email = "manuelfedericolopezzavala372@hotmail.com",
                        Username = "manuelfederico160",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelfedericolopezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Óscar",
                        LastName = "Claro Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 8, 18),
                        PhoneNumber = "+528006552071",
                        Email = "antoniooscarclaronevarez826@hotmail.com",
                        Username = "antoniooscar398",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniooscarclaronevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Joaquin",
                        LastName = "Miranda Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 4, 13),
                        PhoneNumber = "+524113036046",
                        Email = "fabriziojoaquinmirandahiguera914@hotmail.com",
                        Username = "fabriziojoaquin692",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziojoaquinmirandahiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Joaquin",
                        LastName = "Miranda Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 10, 19),
                        PhoneNumber = "+528142475439",
                        Email = "joaquinjoaquinmirandaaguirre748@hotmail.com",
                        Username = "joaquinjoaquin383",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinjoaquinmirandaaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Alejandro",
                        LastName = "León Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 2, 10),
                        PhoneNumber = "+527854558920",
                        Email = "fitzgeraldalejandroleonalvarez42@hotmail.com",
                        Username = "fitzgeraldalejandro915",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldalejandroleonalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Federico",
                        LastName = "Rodríguez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 6, 10),
                        PhoneNumber = "+523394936881",
                        Email = "alejandrofedericorodriguezbustamante591@hotmail.com",
                        Username = "alejandrofederico247",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofedericorodriguezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Ángel",
                        LastName = "Nevárez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 1, 26),
                        PhoneNumber = "+520809257601",
                        Email = "eliazarangelnevareznevarez569@hotmail.com",
                        Username = "eliazarangel491",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarangelnevareznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Aarón",
                        LastName = "Quintero Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 10, 19),
                        PhoneNumber = "+528405111202",
                        Email = "antonioaaronquinterofernandez462@hotmail.com",
                        Username = "antonioaaron283",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioaaronquinterofernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Luis",
                        LastName = "Álvarez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 12, 22),
                        PhoneNumber = "+521912991702",
                        Email = "juanluisalvarezaguirre326@hotmail.com",
                        Username = "juanluis834",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanluisalvarezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Gerardo",
                        LastName = "González León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 12, 15),
                        PhoneNumber = "+522390807117",
                        Email = "fernandogerardogonzalezleon907@hotmail.com",
                        Username = "fernandogerardo79",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandogerardogonzalezleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Gabriel",
                        LastName = "Carrillo Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 9, 21),
                        PhoneNumber = "+526269850477",
                        Email = "danielgabrielcarrilloramones39@hotmail.com",
                        Username = "danielgabriel254",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielgabrielcarrilloramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José António",
                        LastName = "Pérez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 27),
                        PhoneNumber = "+521248743889",
                        Email = "joseantonioperezgomez125@hotmail.com",
                        Username = "joseantonio897",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joseantonioperezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Luis",
                        LastName = "Jiménez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 7, 21),
                        PhoneNumber = "+529915226096",
                        Email = "aaronluisjimenezlastra978@hotmail.com",
                        Username = "aaronluis703",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronluisjimenezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Moisés",
                        LastName = "Ramones Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 12, 16),
                        PhoneNumber = "+526948732468",
                        Email = "javiermoisesramonesaguirre30@hotmail.com",
                        Username = "javiermoises701",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiermoisesramonesaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Gerardo",
                        LastName = "Pérez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 4, 11),
                        PhoneNumber = "+525487002274",
                        Email = "luisgerardoperezgonzali440@hotmail.com",
                        Username = "luisgerardo96",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisgerardoperezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin António",
                        LastName = "Domínguez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 3, 10),
                        PhoneNumber = "+523093814775",
                        Email = "joaquinantoniodominguezcontreras511@hotmail.com",
                        Username = "joaquinantonio896",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinantoniodominguezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Rafaél",
                        LastName = "Gómez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 2, 20),
                        PhoneNumber = "+527295001054",
                        Email = "oscarrafaelgomezjimenez870@hotmail.com",
                        Username = "oscarrafael764",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarrafaelgomezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Gerardo",
                        LastName = "Contreras Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 10, 19),
                        PhoneNumber = "+528343409201",
                        Email = "gerardogerardocontrerascarrillo724@hotmail.com",
                        Username = "gerardogerardo509",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardogerardocontrerascarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Gerardo",
                        LastName = "Gómez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 1, 23),
                        PhoneNumber = "+529790412941",
                        Email = "jhonatangerardogomezquintero958@hotmail.com",
                        Username = "jhonatangerardo980",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatangerardogomezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Joaquin",
                        LastName = "Juárez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 10, 27),
                        PhoneNumber = "+528011792306",
                        Email = "antoniojoaquinjuarezcontreras118@hotmail.com",
                        Username = "antoniojoaquin349",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniojoaquinjuarezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Fernando",
                        LastName = "Higareda Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 1, 9),
                        PhoneNumber = "+525995616375",
                        Email = "eliazarfernandohigaredadominguez521@hotmail.com",
                        Username = "eliazarfernando83",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfernandohigaredadominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Ángel",
                        LastName = "Ramones Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 11, 18),
                        PhoneNumber = "+524321385359",
                        Email = "jhonatanangelramonesgomez849@hotmail.com",
                        Username = "jhonatanangel794",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanangelramonesgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander José",
                        LastName = "Bustamante González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 4, 12),
                        PhoneNumber = "+523628800192",
                        Email = "alexanderjosebustamantegonzalez273@hotmail.com",
                        Username = "alexanderjose427",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjosebustamantegonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Rafaél",
                        LastName = "Árce Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 11, 6),
                        PhoneNumber = "+521088770177",
                        Email = "luisrafaelarcemartinez694@hotmail.com",
                        Username = "luisrafael109",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisrafaelarcemartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel José",
                        LastName = "Higuera Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 3, 4),
                        PhoneNumber = "+525857887939",
                        Email = "gabrieljosehigueralastra785@hotmail.com",
                        Username = "gabrieljose461",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrieljosehigueralastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Carlos",
                        LastName = "Jiménez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 9, 1),
                        PhoneNumber = "+520319675476",
                        Email = "luiscarlosjimenezquintero274@hotmail.com",
                        Username = "luiscarlos380",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luiscarlosjimenezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Leonel",
                        LastName = "Zavala Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 9, 8),
                        PhoneNumber = "+529520806688",
                        Email = "antonioleonelzavalaalvarez96@hotmail.com",
                        Username = "antonioleonel483",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioleonelzavalaalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Joaquin",
                        LastName = "Aguirre Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 10, 27),
                        PhoneNumber = "+524107879336",
                        Email = "antoniojoaquinaguirregonzali159@hotmail.com",
                        Username = "antoniojoaquin240",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniojoaquinaguirregonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Aarón",
                        LastName = "Zavala Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 5, 24),
                        PhoneNumber = "+520826207155",
                        Email = "fernandoaaronzavalajuarez620@hotmail.com",
                        Username = "fernandoaaron215",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoaaronzavalajuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Óscar",
                        LastName = "Gómez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 10, 3),
                        PhoneNumber = "+529505129634",
                        Email = "leoneloscargomezbustamante141@hotmail.com",
                        Username = "leoneloscar963",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leoneloscargomezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Óscar",
                        LastName = "Enríquez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 9, 17),
                        PhoneNumber = "+529593094582",
                        Email = "carlososcarenriquezalvarez504@hotmail.com",
                        Username = "carlososcar103",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlososcarenriquezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Leonel",
                        LastName = "Gómez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 3, 21),
                        PhoneNumber = "+520002756333",
                        Email = "carlosleonelgomezhiguera491@hotmail.com",
                        Username = "carlosleonel627",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosleonelgomezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Estéban",
                        LastName = "Gonzalí Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 8, 12),
                        PhoneNumber = "+520831494062",
                        Email = "nicolasestebangonzaliaguirre602@hotmail.com",
                        Username = "nicolasesteban769",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasestebangonzaliaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos José",
                        LastName = "Jiménez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 7, 22),
                        PhoneNumber = "+527536055895",
                        Email = "carlosjosejimenezzavala388@hotmail.com",
                        Username = "carlosjose581",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosjosejimenezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Carlos",
                        LastName = "Gonzalí Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 8, 18),
                        PhoneNumber = "+522435608343",
                        Email = "aaroncarlosgonzaliaguirre111@hotmail.com",
                        Username = "aaroncarlos251",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaroncarlosgonzaliaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Manuel",
                        LastName = "López Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 3, 9),
                        PhoneNumber = "+525204245446",
                        Email = "christianmanuellopezbustamante242@hotmail.com",
                        Username = "christianmanuel149",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianmanuellopezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Alejandro",
                        LastName = "Miranda León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 12, 27),
                        PhoneNumber = "+528160283490",
                        Email = "arturoalejandromirandaleon474@hotmail.com",
                        Username = "arturoalejandro37",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoalejandromirandaleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Moisés",
                        LastName = "Álvarez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 10, 14),
                        PhoneNumber = "+527115560107",
                        Email = "rafaelmoisesalvarezhiguera624@hotmail.com",
                        Username = "rafaelmoises801",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelmoisesalvarezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Gabriel",
                        LastName = "Lastra León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 11, 2),
                        PhoneNumber = "+527155283722",
                        Email = "fitzgeraldgabriellastraleon736@hotmail.com",
                        Username = "fitzgeraldgabriel920",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldgabriellastraleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Felipe",
                        LastName = "Aguirre Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 6, 27),
                        PhoneNumber = "+526953931885",
                        Email = "fitzgeraldfelipeaguirreenriquez241@hotmail.com",
                        Username = "fitzgeraldfelipe597",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfelipeaguirreenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Manuel",
                        LastName = "Enríquez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 12, 26),
                        PhoneNumber = "+527785602289",
                        Email = "fernandomanuelenriquezgamez764@hotmail.com",
                        Username = "fernandomanuel826",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandomanuelenriquezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Manuel",
                        LastName = "Nevárez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 8, 22),
                        PhoneNumber = "+528746410591",
                        Email = "manuelmanuelnevarezjuarez812@hotmail.com",
                        Username = "manuelmanuel28",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelmanuelnevarezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Arturo",
                        LastName = "Aguirre Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 6, 22),
                        PhoneNumber = "+522035496402",
                        Email = "gabrielarturoaguirrehigareda817@hotmail.com",
                        Username = "gabrielarturo457",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielarturoaguirrehigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Nicolás",
                        LastName = "Claro Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 9, 13),
                        PhoneNumber = "+523253356085",
                        Email = "javiernicolasclarocontreras886@hotmail.com",
                        Username = "javiernicolas302",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiernicolasclarocontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Federico",
                        LastName = "Prado Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 1, 4),
                        PhoneNumber = "+526291037286",
                        Email = "carlosfedericopradocastrejon223@hotmail.com",
                        Username = "carlosfederico976",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosfedericopradocastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Gabriel",
                        LastName = "Miranda Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 3, 1),
                        PhoneNumber = "+524983803924",
                        Email = "aarongabrielmirandabustamante465@hotmail.com",
                        Username = "aarongabriel408",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aarongabrielmirandabustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Ángel",
                        LastName = "León Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 9, 18),
                        PhoneNumber = "+522663453953",
                        Email = "joaquinangelleoncontreras117@hotmail.com",
                        Username = "joaquinangel899",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinangelleoncontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Óscar",
                        LastName = "Higareda Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 7, 14),
                        PhoneNumber = "+520275981713",
                        Email = "carlososcarhigaredaarce659@hotmail.com",
                        Username = "carlososcar384",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlososcarhigaredaarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Gabriel",
                        LastName = "León Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 7, 16),
                        PhoneNumber = "+527989752691",
                        Email = "eliazargabrielleonzavala441@hotmail.com",
                        Username = "eliazargabriel657",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazargabrielleonzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Nicolás",
                        LastName = "Lastra Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 3, 24),
                        PhoneNumber = "+528888089797",
                        Email = "miguelnicolaslastraaguirre877@hotmail.com",
                        Username = "miguelnicolas597",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelnicolaslastraaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Joaquin",
                        LastName = "Quintero Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 6, 17),
                        PhoneNumber = "+522172585735",
                        Email = "josejoaquinquinteroclaro948@hotmail.com",
                        Username = "josejoaquin639",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josejoaquinquinteroclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Daniel",
                        LastName = "Conriquez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 4, 18),
                        PhoneNumber = "+525250904203",
                        Email = "oscardanielconriquezjuarez887@hotmail.com",
                        Username = "oscardaniel980",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscardanielconriquezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Óscar",
                        LastName = "León Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 11, 6),
                        PhoneNumber = "+520487308562",
                        Email = "gerardooscarleoncontreras453@hotmail.com",
                        Username = "gerardooscar888",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardooscarleoncontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Amadeus",
                        LastName = "Higareda Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 11, 22),
                        PhoneNumber = "+525481556188",
                        Email = "oscaramadeushigaredaaguirre193@hotmail.com",
                        Username = "oscaramadeus73",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscaramadeushigaredaaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Miguel",
                        LastName = "Carrillo Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 5, 8),
                        PhoneNumber = "+525558401253",
                        Email = "fernandomiguelcarrilloconriquez325@hotmail.com",
                        Username = "fernandomiguel616",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandomiguelcarrilloconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Luis",
                        LastName = "Juárez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 9, 20),
                        PhoneNumber = "+529529220028",
                        Email = "joaquinluisjuarezfernandez948@hotmail.com",
                        Username = "joaquinluis91",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinluisjuarezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Carlos",
                        LastName = "Zavala Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 9, 25),
                        PhoneNumber = "+520448524488",
                        Email = "sebastiancarloszavalagamez570@hotmail.com",
                        Username = "sebastiancarlos614",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastiancarloszavalagamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Leonel",
                        LastName = "Álvarez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 2, 7),
                        PhoneNumber = "+528158810168",
                        Email = "aaronleonelalvarezhiguera763@hotmail.com",
                        Username = "aaronleonel327",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronleonelalvarezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Eliazar",
                        LastName = "Pérez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 3, 3),
                        PhoneNumber = "+525875952965",
                        Email = "christianeliazarperezaguirre171@hotmail.com",
                        Username = "christianeliazar731",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianeliazarperezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón António",
                        LastName = "Álvarez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 5, 2),
                        PhoneNumber = "+521077236555",
                        Email = "aaronantonioalvarezquintero420@hotmail.com",
                        Username = "aaronantonio429",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronantonioalvarezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Óscar",
                        LastName = "Quintero Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 2, 3),
                        PhoneNumber = "+522159567578",
                        Email = "gerardooscarquinterozavala839@hotmail.com",
                        Username = "gerardooscar984",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardooscarquinterozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Federico",
                        LastName = "Árce Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 3, 12),
                        PhoneNumber = "+528007913931",
                        Email = "fitzgeraldfedericoarceperez257@hotmail.com",
                        Username = "fitzgeraldfederico465",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfedericoarceperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Moisés",
                        LastName = "Gómez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 5, 13),
                        PhoneNumber = "+526069780600",
                        Email = "fernandomoisesgomezrodriguez187@hotmail.com",
                        Username = "fernandomoises117",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandomoisesgomezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fernando",
                        LastName = "Trujillo Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 12, 20),
                        PhoneNumber = "+524785574594",
                        Email = "danielfernandotrujillohiguera236@hotmail.com",
                        Username = "danielfernando642",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfernandotrujillohiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Arturo",
                        LastName = "Domínguez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 10, 14),
                        PhoneNumber = "+520970607179",
                        Email = "fitzgeraldarturodominguezaguirre302@hotmail.com",
                        Username = "fitzgeraldarturo108",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldarturodominguezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Óscar",
                        LastName = "Conriquez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 11, 19),
                        PhoneNumber = "+526731707208",
                        Email = "gerardooscarconriquezaguirre706@hotmail.com",
                        Username = "gerardooscar454",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardooscarconriquezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Manuel",
                        LastName = "Gonzalí Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 6, 9),
                        PhoneNumber = "+520616871361",
                        Email = "federicomanuelgonzaliperez425@hotmail.com",
                        Username = "federicomanuel641",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicomanuelgonzaliperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Christian",
                        LastName = "Aguirre Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 12, 14),
                        PhoneNumber = "+520526819653",
                        Email = "javierchristianaguirrejimenez637@hotmail.com",
                        Username = "javierchristian34",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierchristianaguirrejimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Carlos",
                        LastName = "Juárez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 2, 1),
                        PhoneNumber = "+525397295567",
                        Email = "gabrielcarlosjuarezbustamante577@hotmail.com",
                        Username = "gabrielcarlos952",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielcarlosjuarezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Gabriel",
                        LastName = "Ramones Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 12, 16),
                        PhoneNumber = "+525221505731",
                        Email = "moisesgabrielramonesarce531@hotmail.com",
                        Username = "moisesgabriel335",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesgabrielramonesarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Eliazar",
                        LastName = "Castrejón Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 8, 19),
                        PhoneNumber = "+523289408496",
                        Email = "migueleliazarcastrejonrodriguez587@hotmail.com",
                        Username = "migueleliazar284",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueleliazarcastrejonrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Manuel",
                        LastName = "Gonzalí Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 1, 4),
                        PhoneNumber = "+528931521397",
                        Email = "joaquinmanuelgonzalijimenez140@hotmail.com",
                        Username = "joaquinmanuel53",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinmanuelgonzalijimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Alejandro",
                        LastName = "Gómez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 1, 2),
                        PhoneNumber = "+522571012031",
                        Email = "jhonatanalejandrogomezenriquez218@hotmail.com",
                        Username = "jhonatanalejandro631",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanalejandrogomezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Moisés",
                        LastName = "Álvarez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 1, 27),
                        PhoneNumber = "+524133347187",
                        Email = "nicolasmoisesalvarezfernandez773@hotmail.com",
                        Username = "nicolasmoises994",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasmoisesalvarezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Óscar",
                        LastName = "Pérez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 2, 2),
                        PhoneNumber = "+524873687479",
                        Email = "leoneloscarperezgamez776@hotmail.com",
                        Username = "leoneloscar830",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leoneloscarperezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Miguel",
                        LastName = "Gonzalí Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 11, 14),
                        PhoneNumber = "+526686575465",
                        Email = "carlosmiguelgonzalicastrejon604@hotmail.com",
                        Username = "carlosmiguel554",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosmiguelgonzalicastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Aarón",
                        LastName = "González Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 5, 23),
                        PhoneNumber = "+520638057175",
                        Email = "eliazaraarongonzalezzavala313@hotmail.com",
                        Username = "eliazaraaron430",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazaraarongonzalezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Javier",
                        LastName = "Gámez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 5, 3),
                        PhoneNumber = "+525637783293",
                        Email = "gabrieljaviergameznevarez500@hotmail.com",
                        Username = "gabrieljavier61",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrieljaviergameznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Felipe",
                        LastName = "Enríquez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 10, 9),
                        PhoneNumber = "+521604169357",
                        Email = "oscarfelipeenriquezquintero996@hotmail.com",
                        Username = "oscarfelipe744",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfelipeenriquezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Fernando",
                        LastName = "Ramones Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 2, 7),
                        PhoneNumber = "+525681354698",
                        Email = "oscarfernandoramonescarrillo266@hotmail.com",
                        Username = "oscarfernando589",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfernandoramonescarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Gerardo",
                        LastName = "González Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 3, 17),
                        PhoneNumber = "+526799727359",
                        Email = "leonelgerardogonzalezgamez865@hotmail.com",
                        Username = "leonelgerardo299",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelgerardogonzalezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Gabriel",
                        LastName = "Aguirre Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 12, 20),
                        PhoneNumber = "+526553007532",
                        Email = "gerardogabrielaguirregomez492@hotmail.com",
                        Username = "gerardogabriel280",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardogabrielaguirregomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Eliazar",
                        LastName = "Bustamante Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 6, 6),
                        PhoneNumber = "+527589275100",
                        Email = "fitzgeraldeliazarbustamantejuarez289@hotmail.com",
                        Username = "fitzgeraldeliazar234",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldeliazarbustamantejuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Rafaél",
                        LastName = "Fernández Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 3, 17),
                        PhoneNumber = "+528861176747",
                        Email = "joserafaelfernandezmartinez437@hotmail.com",
                        Username = "joserafael151",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joserafaelfernandezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Daniel",
                        LastName = "Conriquez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 8, 17),
                        PhoneNumber = "+528801879513",
                        Email = "rafaeldanielconriquezmiranda97@hotmail.com",
                        Username = "rafaeldaniel746",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeldanielconriquezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Javier",
                        LastName = "Nevárez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 9, 17),
                        PhoneNumber = "+528174343621",
                        Email = "aaronjaviernevarezarce629@hotmail.com",
                        Username = "aaronjavier423",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronjaviernevarezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Daniel",
                        LastName = "Ramones Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 1, 3),
                        PhoneNumber = "+524499864594",
                        Email = "fabriziodanielramonesmartinez337@hotmail.com",
                        Username = "fabriziodaniel895",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziodanielramonesmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Alejandro",
                        LastName = "Contreras González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 1, 7),
                        PhoneNumber = "+521688524400",
                        Email = "fernandoalejandrocontrerasgonzalez664@hotmail.com",
                        Username = "fernandoalejandro985",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoalejandrocontrerasgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián António",
                        LastName = "Higareda Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 7, 9),
                        PhoneNumber = "+523074876346",
                        Email = "sebastianantoniohigaredagomez683@hotmail.com",
                        Username = "sebastianantonio824",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianantoniohigaredagomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando José",
                        LastName = "Carrillo Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 10, 26),
                        PhoneNumber = "+523867697149",
                        Email = "fernandojosecarrilloramones712@hotmail.com",
                        Username = "fernandojose723",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandojosecarrilloramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Sebastián",
                        LastName = "Ramones Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 8, 5),
                        PhoneNumber = "+524179666733",
                        Email = "eliazarsebastianramonesgomez759@hotmail.com",
                        Username = "eliazarsebastian971",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarsebastianramonesgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "Álvarez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 1, 27),
                        PhoneNumber = "+521769539051",
                        Email = "alejandronicolasalvarezaguirre833@hotmail.com",
                        Username = "alejandronicolas584",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolasalvarezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Daniel",
                        LastName = "Gonzalí Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 9, 9),
                        PhoneNumber = "+521878593101",
                        Email = "felipedanielgonzalizavala784@hotmail.com",
                        Username = "felipedaniel370",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipedanielgonzalizavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Manuel",
                        LastName = "Higuera Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 4, 25),
                        PhoneNumber = "+527702922310",
                        Email = "alejandromanuelhigueracontreras507@hotmail.com",
                        Username = "alejandromanuel665",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandromanuelhigueracontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Manuel",
                        LastName = "Gómez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 1, 10),
                        PhoneNumber = "+520283515801",
                        Email = "miguelmanuelgomezalvarez893@hotmail.com",
                        Username = "miguelmanuel236",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelmanuelgomezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Alexander",
                        LastName = "Miranda Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 4, 24),
                        PhoneNumber = "+526061737686",
                        Email = "moisesalexandermirandarodriguez238@hotmail.com",
                        Username = "moisesalexander113",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesalexandermirandarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Javier",
                        LastName = "Martínez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 10, 24),
                        PhoneNumber = "+528593489011",
                        Email = "alexanderjaviermartinezzavala335@hotmail.com",
                        Username = "alexanderjavier941",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjaviermartinezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Joaquin",
                        LastName = "Árce Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 11, 1),
                        PhoneNumber = "+523676318418",
                        Email = "gerardojoaquinarcelastra599@hotmail.com",
                        Username = "gerardojoaquin715",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardojoaquinarcelastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Alejandro",
                        LastName = "Claro Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 8, 22),
                        PhoneNumber = "+527430393059",
                        Email = "fabrizioalejandroclarodominguez980@hotmail.com",
                        Username = "fabrizioalejandro46",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioalejandroclarodominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Javier",
                        LastName = "Nevárez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 1, 5),
                        PhoneNumber = "+522578618282",
                        Email = "estebanjaviernevareznevarez504@hotmail.com",
                        Username = "estebanjavier988",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanjaviernevareznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Amadeus",
                        LastName = "González Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 6, 4),
                        PhoneNumber = "+520676896309",
                        Email = "aaronamadeusgonzalezbustamante84@hotmail.com",
                        Username = "aaronamadeus735",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronamadeusgonzalezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Eliazar",
                        LastName = "López Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 1, 21),
                        PhoneNumber = "+527035023307",
                        Email = "sebastianeliazarlopezbustamante395@hotmail.com",
                        Username = "sebastianeliazar789",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianeliazarlopezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Jhonatan",
                        LastName = "Aguirre Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 8, 12),
                        PhoneNumber = "+529493582206",
                        Email = "josejhonatanaguirreprado458@hotmail.com",
                        Username = "josejhonatan126",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josejhonatanaguirreprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Sebastián",
                        LastName = "Gámez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 6, 20),
                        PhoneNumber = "+529715591169",
                        Email = "rafaelsebastiangamezcarrillo140@hotmail.com",
                        Username = "rafaelsebastian944",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelsebastiangamezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Arturo",
                        LastName = "López Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 22),
                        PhoneNumber = "+525111052905",
                        Email = "federicoarturolopezclaro971@hotmail.com",
                        Username = "federicoarturo442",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoarturolopezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Nicolás",
                        LastName = "Ramones Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 5, 19),
                        PhoneNumber = "+524717691792",
                        Email = "josenicolasramonescastrejon365@hotmail.com",
                        Username = "josenicolas864",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josenicolasramonescastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Javier",
                        LastName = "Prado Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 12, 22),
                        PhoneNumber = "+529343198760",
                        Email = "jhonatanjavierpradotrujillo997@hotmail.com",
                        Username = "jhonatanjavier815",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanjavierpradotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Arturo",
                        LastName = "Pérez Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 1, 16),
                        PhoneNumber = "+526198780591",
                        Email = "fabrizioarturoperezzavala330@hotmail.com",
                        Username = "fabrizioarturo942",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioarturoperezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Jhonatan",
                        LastName = "Rodríguez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 9, 25),
                        PhoneNumber = "+522135037312",
                        Email = "rafaeljhonatanrodriguezmiranda219@hotmail.com",
                        Username = "rafaeljhonatan992",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljhonatanrodriguezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Óscar",
                        LastName = "Quintero Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 1, 14),
                        PhoneNumber = "+526308177467",
                        Email = "felipeoscarquinterocarrillo157@hotmail.com",
                        Username = "felipeoscar319",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeoscarquinterocarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Sebastián",
                        LastName = "Aguirre Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 5, 24),
                        PhoneNumber = "+524232965474",
                        Email = "josesebastianaguirrelastra958@hotmail.com",
                        Username = "josesebastian991",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josesebastianaguirrelastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel António",
                        LastName = "González González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 4, 7),
                        PhoneNumber = "+522512452948",
                        Email = "miguelantoniogonzalezgonzalez671@hotmail.com",
                        Username = "miguelantonio779",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelantoniogonzalezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Javier",
                        LastName = "Higuera Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 12, 11),
                        PhoneNumber = "+525504342350",
                        Email = "federicojavierhiguerahiguera326@hotmail.com",
                        Username = "federicojavier878",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicojavierhiguerahiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Carlos",
                        LastName = "Miranda Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 2, 18),
                        PhoneNumber = "+524654545579",
                        Email = "joaquincarlosmirandajuarez233@hotmail.com",
                        Username = "joaquincarlos382",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquincarlosmirandajuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Nicolás",
                        LastName = "Gámez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 2, 1),
                        PhoneNumber = "+522957410528",
                        Email = "aaronnicolasgamezperez366@hotmail.com",
                        Username = "aaronnicolas42",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronnicolasgamezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Christian",
                        LastName = "Trujillo Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 2, 4),
                        PhoneNumber = "+529673850581",
                        Email = "josechristiantrujilloalvarez426@hotmail.com",
                        Username = "josechristian453",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josechristiantrujilloalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Leonel",
                        LastName = "León González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 8, 7),
                        PhoneNumber = "+521519300518",
                        Email = "eliazarleonelleongonzalez104@hotmail.com",
                        Username = "eliazarleonel947",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarleonelleongonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Felipe",
                        LastName = "López Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 1, 20),
                        PhoneNumber = "+523773383008",
                        Email = "luisfelipelopezarce975@hotmail.com",
                        Username = "luisfelipe707",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisfelipelopezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Moisés",
                        LastName = "Jiménez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 8, 20),
                        PhoneNumber = "+526147667377",
                        Email = "gerardomoisesjimenezlastra415@hotmail.com",
                        Username = "gerardomoises357",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardomoisesjimenezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Leonel",
                        LastName = "López Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 8, 17),
                        PhoneNumber = "+523138020823",
                        Email = "moisesleonellopezzavala942@hotmail.com",
                        Username = "moisesleonel830",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesleonellopezzavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Joaquin",
                        LastName = "Prado Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 8),
                        PhoneNumber = "+528375067925",
                        Email = "oscarjoaquinpradomartinez102@hotmail.com",
                        Username = "oscarjoaquin512",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarjoaquinpradomartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Fabrizio",
                        LastName = "Gámez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 10, 23),
                        PhoneNumber = "+524879259478",
                        Email = "alejandrofabriziogamezmartinez748@hotmail.com",
                        Username = "alejandrofabrizio841",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofabriziogamezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Eliazar",
                        LastName = "Castrejón Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 11, 10),
                        PhoneNumber = "+525760481244",
                        Email = "alejandroeliazarcastrejonperez728@hotmail.com",
                        Username = "alejandroeliazar503",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroeliazarcastrejonperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Moisés",
                        LastName = "López Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 12, 24),
                        PhoneNumber = "+525873931535",
                        Email = "fabriziomoiseslopezdominguez374@hotmail.com",
                        Username = "fabriziomoises923",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziomoiseslopezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Alejandro",
                        LastName = "Higuera Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 8, 14),
                        PhoneNumber = "+529584473273",
                        Email = "federicoalejandrohiguerazavala320@hotmail.com",
                        Username = "federicoalejandro704",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoalejandrohiguerazavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Juan",
                        LastName = "Conriquez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 9, 2),
                        PhoneNumber = "+528789485435",
                        Email = "arturojuanconriquezfernandez472@hotmail.com",
                        Username = "arturojuan783",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturojuanconriquezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Fabrizio",
                        LastName = "Aguirre López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 11, 6),
                        PhoneNumber = "+523703544876",
                        Email = "danielfabrizioaguirrelopez53@hotmail.com",
                        Username = "danielfabrizio717",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfabrizioaguirrelopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Fitzgerald",
                        LastName = "Prado Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1992, 11, 15),
                        PhoneNumber = "+529726102935",
                        Email = "angelfitzgeraldpradotrujillo318@hotmail.com",
                        Username = "angelfitzgerald710",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelfitzgeraldpradotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Miguel",
                        LastName = "Miranda Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 5, 27),
                        PhoneNumber = "+520457326988",
                        Email = "eliazarmiguelmirandazavala446@hotmail.com",
                        Username = "eliazarmiguel609",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarmiguelmirandazavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Javier",
                        LastName = "Fernández Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 6, 8),
                        PhoneNumber = "+522954949068",
                        Email = "nicolasjavierfernandezenriquez636@hotmail.com",
                        Username = "nicolasjavier188",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasjavierfernandezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Fernando",
                        LastName = "Carrillo Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 7, 12),
                        PhoneNumber = "+527876013944",
                        Email = "eliazarfernandocarrillofernandez564@hotmail.com",
                        Username = "eliazarfernando9",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfernandocarrillofernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Federico",
                        LastName = "Aguirre Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 14),
                        PhoneNumber = "+523806040402",
                        Email = "danielfedericoaguirregamez316@hotmail.com",
                        Username = "danielfederico317",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfedericoaguirregamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Miguel",
                        LastName = "Zavala Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 9, 23),
                        PhoneNumber = "+524064573879",
                        Email = "joaquinmiguelzavalalastra552@hotmail.com",
                        Username = "joaquinmiguel973",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinmiguelzavalalastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Manuel",
                        LastName = "Juárez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 3, 1),
                        PhoneNumber = "+526481503701",
                        Email = "fabriziomanueljuarezlopez675@hotmail.com",
                        Username = "fabriziomanuel473",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziomanueljuarezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Eliazar",
                        LastName = "Aguirre Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 12, 14),
                        PhoneNumber = "+526034466052",
                        Email = "manueleliazaraguirredominguez886@hotmail.com",
                        Username = "manueleliazar701",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueleliazaraguirredominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Fitzgerald",
                        LastName = "Claro Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 5, 16),
                        PhoneNumber = "+525136084221",
                        Email = "fitzgeraldfitzgeraldclarocastrejon666@hotmail.com",
                        Username = "fitzgeraldfitzgerald442",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfitzgeraldclarocastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Óscar",
                        LastName = "Gonzalí Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 2, 26),
                        PhoneNumber = "+522426937627",
                        Email = "javieroscargonzalifernandez929@hotmail.com",
                        Username = "javieroscar383",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieroscargonzalifernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Felipe",
                        LastName = "Quintero Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 10, 13),
                        PhoneNumber = "+520176713130",
                        Email = "luisfelipequinterofernandez477@hotmail.com",
                        Username = "luisfelipe535",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisfelipequinterofernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Estéban",
                        LastName = "Domínguez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 7, 2),
                        PhoneNumber = "+526962440961",
                        Email = "oscarestebandominguezarce436@hotmail.com",
                        Username = "oscaresteban646",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarestebandominguezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Juan",
                        LastName = "Claro Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 5, 15),
                        PhoneNumber = "+529563363119",
                        Email = "fabriziojuanclarocastrejon610@hotmail.com",
                        Username = "fabriziojuan597",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziojuanclarocastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Fitzgerald",
                        LastName = "Juárez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 5, 11),
                        PhoneNumber = "+525919904894",
                        Email = "carlosfitzgeraldjuarezhiguera399@hotmail.com",
                        Username = "carlosfitzgerald589",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosfitzgeraldjuarezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Fernando",
                        LastName = "González Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 4, 10),
                        PhoneNumber = "+529990918824",
                        Email = "fernandofernandogonzalezalvarez64@hotmail.com",
                        Username = "fernandofernando261",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandofernandogonzalezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Leonel",
                        LastName = "Fernández González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 4, 3),
                        PhoneNumber = "+525817261014",
                        Email = "manuelleonelfernandezgonzalez260@hotmail.com",
                        Username = "manuelleonel447",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelleonelfernandezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis José",
                        LastName = "López Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 12, 19),
                        PhoneNumber = "+528611631348",
                        Email = "luisjoselopeznevarez261@hotmail.com",
                        Username = "luisjose462",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjoselopeznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Luis",
                        LastName = "Juárez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 1, 6),
                        PhoneNumber = "+521201713869",
                        Email = "estebanluisjuarezdominguez182@hotmail.com",
                        Username = "estebanluis160",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanluisjuarezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Arturo",
                        LastName = "Nevárez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 10, 22),
                        PhoneNumber = "+529505854703",
                        Email = "danielarturonevarezlastra273@hotmail.com",
                        Username = "danielarturo771",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielarturonevarezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Manuel",
                        LastName = "Gámez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 9, 17),
                        PhoneNumber = "+521991382989",
                        Email = "alexandermanuelgamezjuarez765@hotmail.com",
                        Username = "alexandermanuel958",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandermanuelgamezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Joaquin",
                        LastName = "Martínez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 9, 9),
                        PhoneNumber = "+527061718842",
                        Email = "migueljoaquinmartinezhiguera99@hotmail.com",
                        Username = "migueljoaquin421",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljoaquinmartinezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Leonel",
                        LastName = "Carrillo Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 1, 19),
                        PhoneNumber = "+524751457332",
                        Email = "miguelleonelcarrillozavala450@hotmail.com",
                        Username = "miguelleonel991",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelleonelcarrillozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Joaquin",
                        LastName = "Domínguez Conriquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 6, 25),
                        PhoneNumber = "+525242676340",
                        Email = "migueljoaquindominguezconriquez679@hotmail.com",
                        Username = "migueljoaquin550",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljoaquindominguezconriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Leonel",
                        LastName = "Claro Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 1, 8),
                        PhoneNumber = "+522019476173",
                        Email = "miguelleonelclarolastra825@hotmail.com",
                        Username = "miguelleonel22",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelleonelclarolastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Christian",
                        LastName = "Jiménez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 8, 12),
                        PhoneNumber = "+527868157312",
                        Email = "aaronchristianjimenezclaro908@hotmail.com",
                        Username = "aaronchristian268",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronchristianjimenezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Óscar",
                        LastName = "Fernández Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 4, 24),
                        PhoneNumber = "+526640844725",
                        Email = "alexanderoscarfernandezalvarez699@hotmail.com",
                        Username = "alexanderoscar274",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderoscarfernandezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Rafaél",
                        LastName = "Gómez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 10, 14),
                        PhoneNumber = "+527623380646",
                        Email = "fitzgeraldrafaelgomezenriquez57@hotmail.com",
                        Username = "fitzgeraldrafael165",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldrafaelgomezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Eliazar",
                        LastName = "Castrejón Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 12, 16),
                        PhoneNumber = "+522701136381",
                        Email = "jhonataneliazarcastrejondominguez518@hotmail.com",
                        Username = "jhonataneliazar624",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonataneliazarcastrejondominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Fernando",
                        LastName = "Enríquez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 8, 17),
                        PhoneNumber = "+521993847157",
                        Email = "moisesfernandoenriquezprado185@hotmail.com",
                        Username = "moisesfernando602",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesfernandoenriquezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Estéban",
                        LastName = "Martínez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 11, 11),
                        PhoneNumber = "+524778987360",
                        Email = "gabrielestebanmartineztrujillo715@hotmail.com",
                        Username = "gabrielesteban488",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielestebanmartineztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Ángel",
                        LastName = "Higareda Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 6, 1),
                        PhoneNumber = "+524162908327",
                        Email = "alexanderangelhigaredacastrejon525@hotmail.com",
                        Username = "alexanderangel102",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderangelhigaredacastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Jhonatan",
                        LastName = "León Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 2, 22),
                        PhoneNumber = "+526816493222",
                        Email = "fernandojhonatanleonhigareda500@hotmail.com",
                        Username = "fernandojhonatan370",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandojhonatanleonhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Carlos",
                        LastName = "Aguirre Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 11, 4),
                        PhoneNumber = "+527500684596",
                        Email = "gerardocarlosaguirregamez802@hotmail.com",
                        Username = "gerardocarlos978",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardocarlosaguirregamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Fabrizio",
                        LastName = "Castrejón Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 2, 27),
                        PhoneNumber = "+524430097038",
                        Email = "alejandrofabriziocastrejonjimenez422@hotmail.com",
                        Username = "alejandrofabrizio938",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofabriziocastrejonjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Christian",
                        LastName = "Higuera Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 9, 18),
                        PhoneNumber = "+525922423026",
                        Email = "fernandochristianhigueramiranda706@hotmail.com",
                        Username = "fernandochristian653",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandochristianhigueramiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Moisés",
                        LastName = "Carrillo Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 15),
                        PhoneNumber = "+521814320086",
                        Email = "nicolasmoisescarrillogomez481@hotmail.com",
                        Username = "nicolasmoises860",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasmoisescarrillogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Estéban",
                        LastName = "Gómez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 6, 19),
                        PhoneNumber = "+520389607763",
                        Email = "sebastianestebangomezenriquez511@hotmail.com",
                        Username = "sebastianesteban776",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianestebangomezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Manuel",
                        LastName = "Gámez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 1, 17),
                        PhoneNumber = "+526886213035",
                        Email = "leonelmanuelgameznevarez572@hotmail.com",
                        Username = "leonelmanuel267",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelmanuelgameznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Manuel",
                        LastName = "Bustamante León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 11, 8),
                        PhoneNumber = "+527981249877",
                        Email = "sebastianmanuelbustamanteleon522@hotmail.com",
                        Username = "sebastianmanuel875",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianmanuelbustamanteleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Federico",
                        LastName = "Martínez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 2, 4),
                        PhoneNumber = "+524433428650",
                        Email = "danielfedericomartinezalvarez827@hotmail.com",
                        Username = "danielfederico218",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfedericomartinezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Carlos",
                        LastName = "Trujillo Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 11, 25),
                        PhoneNumber = "+521775810052",
                        Email = "juancarlostrujillohigareda743@hotmail.com",
                        Username = "juancarlos902",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juancarlostrujillohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Estéban",
                        LastName = "Álvarez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 10, 7),
                        PhoneNumber = "+522840888861",
                        Email = "gabrielestebanalvarezcastrejon802@hotmail.com",
                        Username = "gabrielesteban120",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielestebanalvarezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Luis",
                        LastName = "Árce Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 9, 16),
                        PhoneNumber = "+520678127440",
                        Email = "eliazarluisarcemiranda644@hotmail.com",
                        Username = "eliazarluis489",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarluisarcemiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Rafaél",
                        LastName = "Quintero Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 9, 20),
                        PhoneNumber = "+524451101803",
                        Email = "joaquinrafaelquinterotrujillo285@hotmail.com",
                        Username = "joaquinrafael17",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinrafaelquinterotrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Estéban",
                        LastName = "Lastra Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 3, 5),
                        PhoneNumber = "+525561916675",
                        Email = "antonioestebanlastraprado34@hotmail.com",
                        Username = "antonioesteban529",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioestebanlastraprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Moisés",
                        LastName = "Álvarez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 8, 4),
                        PhoneNumber = "+528635367927",
                        Email = "eliazarmoisesalvarezgomez226@hotmail.com",
                        Username = "eliazarmoises940",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarmoisesalvarezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Daniel",
                        LastName = "Quintero López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 4, 25),
                        PhoneNumber = "+525323188526",
                        Email = "amadeusdanielquinterolopez43@hotmail.com",
                        Username = "amadeusdaniel463",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusdanielquinterolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Carlos",
                        LastName = "Gómez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 8, 11),
                        PhoneNumber = "+529978802065",
                        Email = "amadeuscarlosgomezfernandez165@hotmail.com",
                        Username = "amadeuscarlos167",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeuscarlosgomezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Arturo",
                        LastName = "Contreras Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 8, 9),
                        PhoneNumber = "+520814018601",
                        Email = "christianarturocontrerasnevarez727@hotmail.com",
                        Username = "christianarturo427",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianarturocontrerasnevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Rafaél",
                        LastName = "Contreras Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 8, 6),
                        PhoneNumber = "+528605466198",
                        Email = "jhonatanrafaelcontrerasquintero339@hotmail.com",
                        Username = "jhonatanrafael867",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanrafaelcontrerasquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Rafaél",
                        LastName = "Ramones Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 11, 12),
                        PhoneNumber = "+522153014558",
                        Email = "jhonatanrafaelramonesalvarez572@hotmail.com",
                        Username = "jhonatanrafael374",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanrafaelramonesalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Fitzgerald",
                        LastName = "Gámez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 12, 11),
                        PhoneNumber = "+522293213586",
                        Email = "angelfitzgeraldgamezdominguez473@hotmail.com",
                        Username = "angelfitzgerald359",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelfitzgeraldgamezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Rafaél",
                        LastName = "Gámez Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 4, 18),
                        PhoneNumber = "+524082001811",
                        Email = "angelrafaelgameznevarez891@hotmail.com",
                        Username = "angelrafael223",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelrafaelgameznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Fabrizio",
                        LastName = "Jiménez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 11, 4),
                        PhoneNumber = "+528459076534",
                        Email = "alejandrofabriziojimenezramones254@hotmail.com",
                        Username = "alejandrofabrizio817",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrofabriziojimenezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Leonel",
                        LastName = "Contreras Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 4, 13),
                        PhoneNumber = "+523942689972",
                        Email = "felipeleonelcontrerasaguirre496@hotmail.com",
                        Username = "felipeleonel473",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeleonelcontrerasaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Amadeus",
                        LastName = "Enríquez Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 12, 4),
                        PhoneNumber = "+526000103536",
                        Email = "jhonatanamadeusenriquezgomez272@hotmail.com",
                        Username = "jhonatanamadeus428",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanamadeusenriquezgomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Eliazar",
                        LastName = "Conriquez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 4, 13),
                        PhoneNumber = "+522306780101",
                        Email = "felipeeliazarconriquezgamez240@hotmail.com",
                        Username = "felipeeliazar210",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeeliazarconriquezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Miguel",
                        LastName = "León Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 3, 1),
                        PhoneNumber = "+525460131446",
                        Email = "moisesmiguelleonmiranda656@hotmail.com",
                        Username = "moisesmiguel377",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesmiguelleonmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Daniel",
                        LastName = "Juárez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 3, 24),
                        PhoneNumber = "+526409071328",
                        Email = "alexanderdanieljuarezdominguez54@hotmail.com",
                        Username = "alexanderdaniel250",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderdanieljuarezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Amadeus",
                        LastName = "Conriquez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 11, 14),
                        PhoneNumber = "+523545722070",
                        Email = "fernandoamadeusconriquezprado498@hotmail.com",
                        Username = "fernandoamadeus851",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoamadeusconriquezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Fabrizio",
                        LastName = "Gonzalí León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 2, 22),
                        PhoneNumber = "+526284917999",
                        Email = "federicofabriziogonzalileon463@hotmail.com",
                        Username = "federicofabrizio137",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofabriziogonzalileon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Daniel",
                        LastName = "Fernández Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 4, 23),
                        PhoneNumber = "+522502317542",
                        Email = "eliazardanielfernandeztrujillo94@hotmail.com",
                        Username = "eliazardaniel548",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazardanielfernandeztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Fernando",
                        LastName = "Zavala Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 2, 11),
                        PhoneNumber = "+524641997229",
                        Email = "rafaelfernandozavalamiranda276@hotmail.com",
                        Username = "rafaelfernando845",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfernandozavalamiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Leonel Alexander",
                        LastName = "Jiménez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 7, 14),
                        PhoneNumber = "+526891978186",
                        Email = "leonelalexanderjimenezhigareda14@hotmail.com",
                        Username = "leonelalexander200",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/leonelalexanderjimenezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Amadeus",
                        LastName = "Gonzalí Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 2, 1),
                        PhoneNumber = "+522005866055",
                        Email = "antonioamadeusgonzalirodriguez702@hotmail.com",
                        Username = "antonioamadeus471",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioamadeusgonzalirodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan José",
                        LastName = "Ramones Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 12, 12),
                        PhoneNumber = "+526717871253",
                        Email = "jhonatanjoseramoneszavala155@hotmail.com",
                        Username = "jhonatanjose563",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanjoseramoneszavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Felipe",
                        LastName = "Nevárez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 7, 8),
                        PhoneNumber = "+529631314790",
                        Email = "eliazarfelipenevareztrujillo623@hotmail.com",
                        Username = "eliazarfelipe257",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarfelipenevareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Felipe",
                        LastName = "Gonzalí Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 7, 3),
                        PhoneNumber = "+526999339255",
                        Email = "federicofelipegonzaligamez719@hotmail.com",
                        Username = "federicofelipe210",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofelipegonzaligamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Rafaél",
                        LastName = "González Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 9, 1),
                        PhoneNumber = "+523874747707",
                        Email = "moisesrafaelgonzalezalvarez35@hotmail.com",
                        Username = "moisesrafael539",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesrafaelgonzalezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Alejandro",
                        LastName = "Higareda Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1984, 7, 8),
                        PhoneNumber = "+525497304657",
                        Email = "carlosalejandrohigaredamartinez712@hotmail.com",
                        Username = "carlosalejandro314",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosalejandrohigaredamartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Felipe",
                        LastName = "Carrillo Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 4, 19),
                        PhoneNumber = "+522498497835",
                        Email = "oscarfelipecarrillolastra648@hotmail.com",
                        Username = "oscarfelipe689",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfelipecarrillolastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Fernando",
                        LastName = "León Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 7, 1),
                        PhoneNumber = "+525744256340",
                        Email = "alexanderfernandoleonquintero639@hotmail.com",
                        Username = "alexanderfernando493",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfernandoleonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo António",
                        LastName = "Enríquez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 5, 2),
                        PhoneNumber = "+521492699561",
                        Email = "arturoantonioenriquezmartinez197@hotmail.com",
                        Username = "arturoantonio981",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoantonioenriquezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Javier",
                        LastName = "Lastra Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 8, 4),
                        PhoneNumber = "+524665473981",
                        Email = "alexanderjavierlastraenriquez439@hotmail.com",
                        Username = "alexanderjavier611",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderjavierlastraenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Juan",
                        LastName = "Zavala Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1979, 8, 13),
                        PhoneNumber = "+525957974142",
                        Email = "manueljuanzavalafernandez458@hotmail.com",
                        Username = "manueljuan616",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manueljuanzavalafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Leonel",
                        LastName = "Domínguez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 1, 24),
                        PhoneNumber = "+524400890944",
                        Email = "oscarleoneldominguezgamez135@hotmail.com",
                        Username = "oscarleonel203",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarleoneldominguezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Luis",
                        LastName = "Trujillo Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 11, 17),
                        PhoneNumber = "+523418959454",
                        Email = "nicolasluistrujilloquintero513@hotmail.com",
                        Username = "nicolasluis818",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasluistrujilloquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Carlos",
                        LastName = "Árce Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 1, 11),
                        PhoneNumber = "+529194393526",
                        Email = "amadeuscarlosarcequintero503@hotmail.com",
                        Username = "amadeuscarlos840",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeuscarlosarcequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier José",
                        LastName = "Domínguez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 3, 26),
                        PhoneNumber = "+522359444332",
                        Email = "javierjosedominguezlopez128@hotmail.com",
                        Username = "javierjose260",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javierjosedominguezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Alejandro",
                        LastName = "Quintero Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 7, 12),
                        PhoneNumber = "+526708882941",
                        Email = "alejandroalejandroquinterofernandez544@hotmail.com",
                        Username = "alejandroalejandro697",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroalejandroquinterofernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Amadeus",
                        LastName = "Aguirre Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 8, 5),
                        PhoneNumber = "+522100402638",
                        Email = "manuelamadeusaguirredominguez680@hotmail.com",
                        Username = "manuelamadeus94",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelamadeusaguirredominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Carlos",
                        LastName = "Trujillo Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 1, 22),
                        PhoneNumber = "+529660449066",
                        Email = "antoniocarlostrujillohigareda120@hotmail.com",
                        Username = "antoniocarlos702",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniocarlostrujillohigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Óscar",
                        LastName = "Enríquez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 8, 8),
                        PhoneNumber = "+522665223978",
                        Email = "christianoscarenriquezramones258@hotmail.com",
                        Username = "christianoscar945",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianoscarenriquezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Juan",
                        LastName = "Contreras Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 7, 12),
                        PhoneNumber = "+523696133998",
                        Email = "gerardojuancontrerasbustamante108@hotmail.com",
                        Username = "gerardojuan785",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardojuancontrerasbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Eliazar",
                        LastName = "Higuera Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 6, 2),
                        PhoneNumber = "+523199846061",
                        Email = "sebastianeliazarhigueracontreras652@hotmail.com",
                        Username = "sebastianeliazar604",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianeliazarhigueracontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Eliazar",
                        LastName = "Pérez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 8, 1),
                        PhoneNumber = "+525303964691",
                        Email = "aaroneliazarperezjimenez544@hotmail.com",
                        Username = "aaroneliazar795",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaroneliazarperezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Castrejón Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 6, 20),
                        PhoneNumber = "+526672428682",
                        Email = "moisesestebancastrejonbustamante816@hotmail.com",
                        Username = "moisesesteban119",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebancastrejonbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Gerardo",
                        LastName = "Conriquez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1956, 11, 3),
                        PhoneNumber = "+525096481068",
                        Email = "antoniogerardoconriquezprado737@hotmail.com",
                        Username = "antoniogerardo187",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antoniogerardoconriquezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Javier",
                        LastName = "Higuera Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 3, 9),
                        PhoneNumber = "+520823384693",
                        Email = "sebastianjavierhigueraaguirre40@hotmail.com",
                        Username = "sebastianjavier574",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianjavierhigueraaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Amadeus",
                        LastName = "Gonzalí Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 7, 1),
                        PhoneNumber = "+529160555266",
                        Email = "nicolasamadeusgonzaligamez40@hotmail.com",
                        Username = "nicolasamadeus16",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasamadeusgonzaligamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Alexander",
                        LastName = "Castrejón Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 6, 14),
                        PhoneNumber = "+529816158536",
                        Email = "josealexandercastrejonclaro868@hotmail.com",
                        Username = "josealexander673",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josealexandercastrejonclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Eliazar",
                        LastName = "Trujillo Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 12, 15),
                        PhoneNumber = "+528277934620",
                        Email = "fitzgeraldeliazartrujillolastra649@hotmail.com",
                        Username = "fitzgeraldeliazar636",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldeliazartrujillolastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Manuel",
                        LastName = "Aguirre Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 1, 27),
                        PhoneNumber = "+527741224758",
                        Email = "alejandromanuelaguirrecontreras262@hotmail.com",
                        Username = "alejandromanuel756",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandromanuelaguirrecontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Estéban",
                        LastName = "Quintero González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 4, 23),
                        PhoneNumber = "+520320783381",
                        Email = "nicolasestebanquinterogonzalez399@hotmail.com",
                        Username = "nicolasesteban51",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasestebanquinterogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Alejandro",
                        LastName = "Quintero Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 4, 21),
                        PhoneNumber = "+521106770411",
                        Email = "josealejandroquinterojuarez36@hotmail.com",
                        Username = "josealejandro505",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josealejandroquinterojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Alejandro",
                        LastName = "Enríquez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 4, 18),
                        PhoneNumber = "+529143394489",
                        Email = "oscaralejandroenriqueztrujillo691@hotmail.com",
                        Username = "oscaralejandro554",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscaralejandroenriqueztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Juan",
                        LastName = "León Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 5, 22),
                        PhoneNumber = "+528069487306",
                        Email = "luisjuanleonenriquez307@hotmail.com",
                        Username = "luisjuan393",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjuanleonenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Leonel",
                        LastName = "Conriquez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 9, 20),
                        PhoneNumber = "+520301207553",
                        Email = "fernandoleonelconriquezjuarez673@hotmail.com",
                        Username = "fernandoleonel108",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoleonelconriquezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Nicolás",
                        LastName = "Carrillo Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 3, 22),
                        PhoneNumber = "+525022538160",
                        Email = "alejandronicolascarrillomiranda532@hotmail.com",
                        Username = "alejandronicolas687",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandronicolascarrillomiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Moisés",
                        LastName = "Castrejón Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 7, 21),
                        PhoneNumber = "+522489395313",
                        Email = "oscarmoisescastrejonalvarez785@hotmail.com",
                        Username = "oscarmoises440",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarmoisescastrejonalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Gerardo",
                        LastName = "Conriquez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 12, 6),
                        PhoneNumber = "+529559154581",
                        Email = "alejandrogerardoconriquezjuarez81@hotmail.com",
                        Username = "alejandrogerardo701",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandrogerardoconriquezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Joaquin",
                        LastName = "Conriquez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 2, 18),
                        PhoneNumber = "+520890626954",
                        Email = "christianjoaquinconriquezrodriguez308@hotmail.com",
                        Username = "christianjoaquin870",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianjoaquinconriquezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Ángel",
                        LastName = "Martínez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 11, 1),
                        PhoneNumber = "+527336412680",
                        Email = "jhonatanangelmartinezarce721@hotmail.com",
                        Username = "jhonatanangel838",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanangelmartinezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Jhonatan",
                        LastName = "Carrillo Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1987, 6, 5),
                        PhoneNumber = "+522244833073",
                        Email = "sebastianjhonatancarrillocastrejon463@hotmail.com",
                        Username = "sebastianjhonatan962",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianjhonatancarrillocastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Carlos",
                        LastName = "Ramones Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 3, 19),
                        PhoneNumber = "+525290928116",
                        Email = "fabriziocarlosramonesdominguez52@hotmail.com",
                        Username = "fabriziocarlos157",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziocarlosramonesdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Gabriel",
                        LastName = "Pérez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 4, 23),
                        PhoneNumber = "+525162691161",
                        Email = "angelgabrielperezcarrillo613@hotmail.com",
                        Username = "angelgabriel760",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelgabrielperezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Alejandro",
                        LastName = "Miranda Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 4, 20),
                        PhoneNumber = "+521759156022",
                        Email = "jhonatanalejandromirandacastrejon928@hotmail.com",
                        Username = "jhonatanalejandro397",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanalejandromirandacastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Óscar",
                        LastName = "López Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1957, 1, 17),
                        PhoneNumber = "+526397410631",
                        Email = "rafaeloscarlopezhigareda520@hotmail.com",
                        Username = "rafaeloscar525",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeloscarlopezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Arturo",
                        LastName = "Bustamante Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 9, 21),
                        PhoneNumber = "+528247483276",
                        Email = "gabrielarturobustamantefernandez176@hotmail.com",
                        Username = "gabrielarturo169",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielarturobustamantefernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Gabriel",
                        LastName = "Prado Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 11, 22),
                        PhoneNumber = "+523115158791",
                        Email = "manuelgabrielpradojuarez404@hotmail.com",
                        Username = "manuelgabriel786",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelgabrielpradojuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Federico",
                        LastName = "López González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 2, 15),
                        PhoneNumber = "+522622340497",
                        Email = "aaronfedericolopezgonzalez973@hotmail.com",
                        Username = "aaronfederico815",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronfedericolopezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Rafaél",
                        LastName = "Higuera Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 2, 25),
                        PhoneNumber = "+526025821876",
                        Email = "gabrielrafaelhigueraquintero904@hotmail.com",
                        Username = "gabrielrafael166",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielrafaelhigueraquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Aarón",
                        LastName = "Enríquez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 5, 12),
                        PhoneNumber = "+523978137761",
                        Email = "rafaelaaronenriqueztrujillo48@hotmail.com",
                        Username = "rafaelaaron787",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelaaronenriqueztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Luis",
                        LastName = "Gámez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 9, 25),
                        PhoneNumber = "+523406422818",
                        Email = "joseluisgamezarce832@hotmail.com",
                        Username = "joseluis739",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joseluisgamezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Alejandro",
                        LastName = "Miranda Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 7, 9),
                        PhoneNumber = "+525097231598",
                        Email = "christianalejandromirandanevarez75@hotmail.com",
                        Username = "christianalejandro147",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianalejandromirandanevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Federico",
                        LastName = "Zavala González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 3, 7),
                        PhoneNumber = "+524039094214",
                        Email = "josefedericozavalagonzalez115@hotmail.com",
                        Username = "josefederico505",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josefedericozavalagonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Alejandro",
                        LastName = "Álvarez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 6, 1),
                        PhoneNumber = "+521707846450",
                        Email = "moisesalejandroalvarezgonzali858@hotmail.com",
                        Username = "moisesalejandro565",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesalejandroalvarezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Christian",
                        LastName = "Miranda Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 12, 10),
                        PhoneNumber = "+521195366538",
                        Email = "manuelchristianmirandarodriguez381@hotmail.com",
                        Username = "manuelchristian980",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelchristianmirandarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Joaquin",
                        LastName = "Miranda Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 4, 15),
                        PhoneNumber = "+524132692940",
                        Email = "luisjoaquinmirandafernandez37@hotmail.com",
                        Username = "luisjoaquin420",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisjoaquinmirandafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Daniel",
                        LastName = "López Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 2, 2),
                        PhoneNumber = "+523119465307",
                        Email = "gerardodaniellopezbustamante588@hotmail.com",
                        Username = "gerardodaniel336",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardodaniellopezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo José",
                        LastName = "Quintero Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 6, 9),
                        PhoneNumber = "+524435367407",
                        Email = "gerardojosequinterodominguez659@hotmail.com",
                        Username = "gerardojose515",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardojosequinterodominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Gabriel",
                        LastName = "Gómez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 8, 9),
                        PhoneNumber = "+522860056628",
                        Email = "javiergabrielgomezcontreras830@hotmail.com",
                        Username = "javiergabriel637",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiergabrielgomezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Miguel",
                        LastName = "Carrillo Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 9, 18),
                        PhoneNumber = "+524182836146",
                        Email = "fitzgeraldmiguelcarrillocontreras254@hotmail.com",
                        Username = "fitzgeraldmiguel850",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldmiguelcarrillocontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Carlos",
                        LastName = "Prado Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 6, 11),
                        PhoneNumber = "+527598938607",
                        Email = "manuelcarlospradozavala677@hotmail.com",
                        Username = "manuelcarlos463",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelcarlospradozavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Alexander",
                        LastName = "Conriquez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 7, 4),
                        PhoneNumber = "+529448376568",
                        Email = "miguelalexanderconriquezalvarez29@hotmail.com",
                        Username = "miguelalexander635",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelalexanderconriquezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Óscar",
                        LastName = "Enríquez Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 3, 10),
                        PhoneNumber = "+524424877461",
                        Email = "sebastianoscarenriquezmartinez786@hotmail.com",
                        Username = "sebastianoscar823",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianoscarenriquezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Federico",
                        LastName = "Fernández Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 6, 24),
                        PhoneNumber = "+521666730458",
                        Email = "miguelfedericofernandezaguirre845@hotmail.com",
                        Username = "miguelfederico697",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelfedericofernandezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Rafaél",
                        LastName = "Quintero Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 1, 25),
                        PhoneNumber = "+522862908885",
                        Email = "angelrafaelquinteromartinez892@hotmail.com",
                        Username = "angelrafael703",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelrafaelquinteromartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Joaquin",
                        LastName = "Domínguez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 6, 6),
                        PhoneNumber = "+521564080878",
                        Email = "felipejoaquindominguezdominguez232@hotmail.com",
                        Username = "felipejoaquin878",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipejoaquindominguezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Rafaél",
                        LastName = "Quintero López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 2, 23),
                        PhoneNumber = "+529473085646",
                        Email = "angelrafaelquinterolopez457@hotmail.com",
                        Username = "angelrafael995",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelrafaelquinterolopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Fitzgerald",
                        LastName = "Gámez Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 5, 12),
                        PhoneNumber = "+525066949337",
                        Email = "alexanderfitzgeraldgamezbustamante713@hotmail.com",
                        Username = "alexanderfitzgerald945",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfitzgeraldgamezbustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Joaquin",
                        LastName = "Árce Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 1, 13),
                        PhoneNumber = "+523131854089",
                        Email = "aaronjoaquinarcemartinez35@hotmail.com",
                        Username = "aaronjoaquin624",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronjoaquinarcemartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Óscar",
                        LastName = "Higuera León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 6, 1),
                        PhoneNumber = "+522261284907",
                        Email = "eliazaroscarhigueraleon328@hotmail.com",
                        Username = "eliazaroscar836",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazaroscarhigueraleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Manuel",
                        LastName = "Castrejón Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 10, 19),
                        PhoneNumber = "+524565175534",
                        Email = "federicomanuelcastrejonjuarez507@hotmail.com",
                        Username = "federicomanuel156",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicomanuelcastrejonjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Eliazar",
                        LastName = "Lastra Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 2, 27),
                        PhoneNumber = "+527714234031",
                        Email = "gerardoeliazarlastragonzali634@hotmail.com",
                        Username = "gerardoeliazar942",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardoeliazarlastragonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Juan",
                        LastName = "Lastra Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 8, 1),
                        PhoneNumber = "+528386436004",
                        Email = "carlosjuanlastraenriquez153@hotmail.com",
                        Username = "carlosjuan835",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosjuanlastraenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Ángel",
                        LastName = "Lastra Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 12, 3),
                        PhoneNumber = "+520466058045",
                        Email = "aaronangellastraarce671@hotmail.com",
                        Username = "aaronangel986",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronangellastraarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Estéban",
                        LastName = "Ramones Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 6, 24),
                        PhoneNumber = "+523697327069",
                        Email = "oscarestebanramonesnevarez116@hotmail.com",
                        Username = "oscaresteban379",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarestebanramonesnevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Alexander",
                        LastName = "Gómez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 9, 12),
                        PhoneNumber = "+528032234367",
                        Email = "sebastianalexandergomezcarrillo462@hotmail.com",
                        Username = "sebastianalexander926",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianalexandergomezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Fitzgerald",
                        LastName = "Quintero Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 5, 18),
                        PhoneNumber = "+528193718009",
                        Email = "estebanfitzgeraldquinterocontreras931@hotmail.com",
                        Username = "estebanfitzgerald146",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanfitzgeraldquinterocontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Rafaél",
                        LastName = "Jiménez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 10, 18),
                        PhoneNumber = "+527383413505",
                        Email = "gerardorafaeljimenezcontreras651@hotmail.com",
                        Username = "gerardorafael635",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardorafaeljimenezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Gabriel",
                        LastName = "Aguirre Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 4, 3),
                        PhoneNumber = "+522171835950",
                        Email = "juangabrielaguirrequintero821@hotmail.com",
                        Username = "juangabriel938",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juangabrielaguirrequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Amadeus Leonel",
                        LastName = "Prado Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 6, 21),
                        PhoneNumber = "+529202761427",
                        Email = "amadeusleonelpradonevarez131@hotmail.com",
                        Username = "amadeusleonel536",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/amadeusleonelpradonevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Fitzgerald",
                        LastName = "Conriquez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 9, 17),
                        PhoneNumber = "+521303040218",
                        Email = "arturofitzgeraldconriquezperez419@hotmail.com",
                        Username = "arturofitzgerald946",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturofitzgeraldconriquezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Miguel",
                        LastName = "Juárez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 10, 4),
                        PhoneNumber = "+522453948583",
                        Email = "rafaelmigueljuarezgamez664@hotmail.com",
                        Username = "rafaelmiguel947",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelmigueljuarezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Gabriel",
                        LastName = "Higareda Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 6, 17),
                        PhoneNumber = "+524317135677",
                        Email = "jhonatangabrielhigaredaenriquez550@hotmail.com",
                        Username = "jhonatangabriel871",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatangabrielhigaredaenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Ángel",
                        LastName = "Árce Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 7, 13),
                        PhoneNumber = "+523933452680",
                        Email = "rafaelangelarceaguirre245@hotmail.com",
                        Username = "rafaelangel123",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelangelarceaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos José",
                        LastName = "Higuera Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1973, 11, 8),
                        PhoneNumber = "+526254738203",
                        Email = "carlosjosehiguerarodriguez854@hotmail.com",
                        Username = "carlosjose38",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosjosehiguerarodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Fabrizio",
                        LastName = "Trujillo Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 1, 16),
                        PhoneNumber = "+528187916167",
                        Email = "fabriziofabriziotrujilloclaro476@hotmail.com",
                        Username = "fabriziofabrizio191",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziofabriziotrujilloclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Felipe",
                        LastName = "Juárez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 5, 4),
                        PhoneNumber = "+526010387833",
                        Email = "danielfelipejuarezgonzali114@hotmail.com",
                        Username = "danielfelipe865",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielfelipejuarezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Daniel Alejandro",
                        LastName = "Fernández Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 1, 25),
                        PhoneNumber = "+520119789508",
                        Email = "danielalejandrofernandezcontreras794@hotmail.com",
                        Username = "danielalejandro531",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/danielalejandrofernandezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Nicolás",
                        LastName = "Conriquez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 12, 25),
                        PhoneNumber = "+523354832346",
                        Email = "oscarnicolasconriquezmiranda887@hotmail.com",
                        Username = "oscarnicolas233",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarnicolasconriquezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Javier",
                        LastName = "Nevárez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 9, 1),
                        PhoneNumber = "+521605055618",
                        Email = "jhonatanjaviernevarezprado914@hotmail.com",
                        Username = "jhonatanjavier671",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanjaviernevarezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Joaquin Jhonatan",
                        LastName = "Miranda León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 4, 26),
                        PhoneNumber = "+528310073215",
                        Email = "joaquinjhonatanmirandaleon724@hotmail.com",
                        Username = "joaquinjhonatan488",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/joaquinjhonatanmirandaleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Sebastián",
                        LastName = "Castrejón González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 4, 14),
                        PhoneNumber = "+521856357726",
                        Email = "carlossebastiancastrejongonzalez897@hotmail.com",
                        Username = "carlossebastian217",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlossebastiancastrejongonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Alejandro",
                        LastName = "Ramones Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 10, 6),
                        PhoneNumber = "+522139558222",
                        Email = "eliazaralejandroramoneslastra681@hotmail.com",
                        Username = "eliazaralejandro499",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazaralejandroramoneslastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Daniel",
                        LastName = "Quintero González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 11, 21),
                        PhoneNumber = "+520422705887",
                        Email = "migueldanielquinterogonzalez737@hotmail.com",
                        Username = "migueldaniel645",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueldanielquinterogonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Federico",
                        LastName = "Gámez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 1, 23),
                        PhoneNumber = "+523587786372",
                        Email = "federicofedericogamezclaro736@hotmail.com",
                        Username = "federicofederico371",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofedericogamezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Estéban",
                        LastName = "Conriquez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1958, 7, 13),
                        PhoneNumber = "+521254650872",
                        Email = "moisesestebanconriquezperez103@hotmail.com",
                        Username = "moisesesteban288",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesestebanconriquezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Moisés",
                        LastName = "Higareda Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 9, 18),
                        PhoneNumber = "+529860876702",
                        Email = "federicomoiseshigaredacontreras942@hotmail.com",
                        Username = "federicomoises598",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicomoiseshigaredacontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Manuel",
                        LastName = "Claro Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 11, 27),
                        PhoneNumber = "+529172692779",
                        Email = "angelmanuelclarogomez980@hotmail.com",
                        Username = "angelmanuel61",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelmanuelclarogomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Javier",
                        LastName = "Bustamante León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 9, 12),
                        PhoneNumber = "+521616387989",
                        Email = "migueljavierbustamanteleon889@hotmail.com",
                        Username = "migueljavier313",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljavierbustamanteleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Sebastián",
                        LastName = "Higuera Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1965, 3, 13),
                        PhoneNumber = "+520980678813",
                        Email = "moisessebastianhiguerafernandez493@hotmail.com",
                        Username = "moisessebastian328",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisessebastianhiguerafernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Fabrizio",
                        LastName = "León Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 6, 3),
                        PhoneNumber = "+520632636439",
                        Email = "gabrielfabrizioleonhigareda259@hotmail.com",
                        Username = "gabrielfabrizio820",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielfabrizioleonhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald José",
                        LastName = "López Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 11, 23),
                        PhoneNumber = "+524832242081",
                        Email = "fitzgeraldjoselopezlastra656@hotmail.com",
                        Username = "fitzgeraldjose886",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldjoselopezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Óscar",
                        LastName = "López Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 1, 27),
                        PhoneNumber = "+526836352356",
                        Email = "carlososcarlopezcarrillo106@hotmail.com",
                        Username = "carlososcar168",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlososcarlopezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Nicolás",
                        LastName = "Domínguez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 1, 16),
                        PhoneNumber = "+524776663252",
                        Email = "javiernicolasdominguezfernandez111@hotmail.com",
                        Username = "javiernicolas759",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javiernicolasdominguezfernandez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Alejandro",
                        LastName = "Claro Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 8, 25),
                        PhoneNumber = "+522162864384",
                        Email = "angelalejandroclarogamez130@hotmail.com",
                        Username = "angelalejandro204",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelalejandroclarogamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Christian",
                        LastName = "Martínez Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 9, 23),
                        PhoneNumber = "+529164237271",
                        Email = "jhonatanchristianmartinezcontreras665@hotmail.com",
                        Username = "jhonatanchristian446",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanchristianmartinezcontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Manuel",
                        LastName = "Zavala Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 9, 9),
                        PhoneNumber = "+524393960146",
                        Email = "juanmanuelzavalamiranda874@hotmail.com",
                        Username = "juanmanuel39",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanmanuelzavalamiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Sebastián",
                        LastName = "Álvarez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 9, 19),
                        PhoneNumber = "+527075364173",
                        Email = "juansebastianalvarezprado817@hotmail.com",
                        Username = "juansebastian204",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juansebastianalvarezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Miguel",
                        LastName = "Nevárez Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 6, 10),
                        PhoneNumber = "+527664560308",
                        Email = "juanmiguelnevarezquintero328@hotmail.com",
                        Username = "juanmiguel300",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanmiguelnevarezquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Jhonatan",
                        LastName = "Rodríguez Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 2, 13),
                        PhoneNumber = "+522833291332",
                        Email = "moisesjhonatanrodriguezperez204@hotmail.com",
                        Username = "moisesjhonatan555",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesjhonatanrodriguezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Fernando",
                        LastName = "Castrejón Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 12, 16),
                        PhoneNumber = "+522827147963",
                        Email = "rafaelfernandocastrejonquintero509@hotmail.com",
                        Username = "rafaelfernando343",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelfernandocastrejonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Estéban",
                        LastName = "Conriquez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 9, 26),
                        PhoneNumber = "+521152575279",
                        Email = "gerardoestebanconriquezcastrejon677@hotmail.com",
                        Username = "gerardoesteban925",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardoestebanconriquezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Eliazar",
                        LastName = "Aguirre Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1953, 2, 24),
                        PhoneNumber = "+520341347834",
                        Email = "fabrizioeliazaraguirrearce897@hotmail.com",
                        Username = "fabrizioeliazar976",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabrizioeliazaraguirrearce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Óscar",
                        LastName = "Domínguez Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1974, 1, 14),
                        PhoneNumber = "+523644608022",
                        Email = "fabriziooscardominguezprado124@hotmail.com",
                        Username = "fabriziooscar674",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziooscardominguezprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel António",
                        LastName = "Higuera Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1959, 12, 12),
                        PhoneNumber = "+527134010604",
                        Email = "gabrielantoniohigueraprado404@hotmail.com",
                        Username = "gabrielantonio411",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielantoniohigueraprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Óscar",
                        LastName = "Álvarez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 11, 23),
                        PhoneNumber = "+526271273244",
                        Email = "estebanoscaralvareztrujillo531@hotmail.com",
                        Username = "estebanoscar599",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebanoscaralvareztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Leonel",
                        LastName = "Zavala González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 7, 20),
                        PhoneNumber = "+520214389098",
                        Email = "christianleonelzavalagonzalez554@hotmail.com",
                        Username = "christianleonel267",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christianleonelzavalagonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Leonel",
                        LastName = "Domínguez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1998, 2, 10),
                        PhoneNumber = "+529608757296",
                        Email = "arturoleoneldominguezarce956@hotmail.com",
                        Username = "arturoleonel659",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoleoneldominguezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Leonel",
                        LastName = "Martínez Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 7, 3),
                        PhoneNumber = "+523343015002",
                        Email = "juanleonelmartinezenriquez684@hotmail.com",
                        Username = "juanleonel964",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanleonelmartinezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Christian",
                        LastName = "León Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1976, 6, 12),
                        PhoneNumber = "+528338304114",
                        Email = "fitzgeraldchristianleonquintero409@hotmail.com",
                        Username = "fitzgeraldchristian930",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldchristianleonquintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Luis",
                        LastName = "Gonzalí Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 11, 23),
                        PhoneNumber = "+521422131712",
                        Email = "arturoluisgonzalijuarez264@hotmail.com",
                        Username = "arturoluis184",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoluisgonzalijuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Federico",
                        LastName = "Jiménez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 9, 21),
                        PhoneNumber = "+522060542682",
                        Email = "fitzgeraldfedericojimenezhiguera516@hotmail.com",
                        Username = "fitzgeraldfederico539",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfedericojimenezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan António",
                        LastName = "Carrillo Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 11, 7),
                        PhoneNumber = "+525585198259",
                        Email = "jhonatanantoniocarrilloaguirre600@hotmail.com",
                        Username = "jhonatanantonio752",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanantoniocarrilloaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Daniel",
                        LastName = "Gonzalí Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 7, 14),
                        PhoneNumber = "+520324331704",
                        Email = "federicodanielgonzalilastra671@hotmail.com",
                        Username = "federicodaniel870",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicodanielgonzalilastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Rafaél",
                        LastName = "Ramones Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 12, 24),
                        PhoneNumber = "+525387728373",
                        Email = "eliazarrafaelramonesperez737@hotmail.com",
                        Username = "eliazarrafael591",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazarrafaelramonesperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Miguel",
                        LastName = "Claro Bustamante",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1995, 11, 4),
                        PhoneNumber = "+522735155833",
                        Email = "juanmiguelclarobustamante679@hotmail.com",
                        Username = "juanmiguel985",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanmiguelclarobustamante"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Amadeus",
                        LastName = "Castrejón Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1952, 11, 13),
                        PhoneNumber = "+522433023750",
                        Email = "fernandoamadeuscastrejonperez646@hotmail.com",
                        Username = "fernandoamadeus98",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoamadeuscastrejonperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Amadeus",
                        LastName = "Prado León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 2, 2),
                        PhoneNumber = "+522028143757",
                        Email = "javieramadeuspradoleon469@hotmail.com",
                        Username = "javieramadeus752",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieramadeuspradoleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Alexander",
                        LastName = "Contreras Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 3, 15),
                        PhoneNumber = "+521074872530",
                        Email = "angelalexandercontrerashigareda349@hotmail.com",
                        Username = "angelalexander759",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelalexandercontrerashigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Javier",
                        LastName = "Miranda Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 1, 3),
                        PhoneNumber = "+522889238886",
                        Email = "felipejaviermirandaramones599@hotmail.com",
                        Username = "felipejavier254",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipejaviermirandaramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Gabriel",
                        LastName = "Rodríguez Lastra",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 3, 7),
                        PhoneNumber = "+529791982965",
                        Email = "oscargabrielrodriguezlastra136@hotmail.com",
                        Username = "oscargabriel353",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscargabrielrodriguezlastra"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Aarón",
                        LastName = "Árce Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 5, 16),
                        PhoneNumber = "+527690631641",
                        Email = "jhonatanaaronarcecastrejon135@hotmail.com",
                        Username = "jhonatanaaron481",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanaaronarcecastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Fitzgerald",
                        LastName = "Martínez Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 5, 27),
                        PhoneNumber = "+526005751230",
                        Email = "gerardofitzgeraldmartineztrujillo690@hotmail.com",
                        Username = "gerardofitzgerald987",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardofitzgeraldmartineztrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Alexander",
                        LastName = "Quintero Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 1, 23),
                        PhoneNumber = "+525937310449",
                        Email = "fernandoalexanderquinterorodriguez888@hotmail.com",
                        Username = "fernandoalexander188",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandoalexanderquinterorodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Fernando",
                        LastName = "Álvarez Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 8, 15),
                        PhoneNumber = "+523175341139",
                        Email = "juanfernandoalvarezgonzali182@hotmail.com",
                        Username = "juanfernando911",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanfernandoalvarezgonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Amadeus",
                        LastName = "Bustamante Quintero",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2000, 3, 3),
                        PhoneNumber = "+525237993969",
                        Email = "alexanderamadeusbustamantequintero993@hotmail.com",
                        Username = "alexanderamadeus49",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderamadeusbustamantequintero"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Gerardo",
                        LastName = "Contreras Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1983, 5, 6),
                        PhoneNumber = "+523891228171",
                        Email = "alexandergerardocontrerasperez196@hotmail.com",
                        Username = "alexandergerardo432",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandergerardocontrerasperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Gabriel",
                        LastName = "Higuera López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1996, 4, 17),
                        PhoneNumber = "+526772994694",
                        Email = "fernandogabrielhigueralopez355@hotmail.com",
                        Username = "fernandogabriel654",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandogabrielhigueralopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Óscar",
                        LastName = "Carrillo Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1977, 2, 8),
                        PhoneNumber = "+527873381622",
                        Email = "jhonatanoscarcarrilloperez699@hotmail.com",
                        Username = "jhonatanoscar125",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanoscarcarrilloperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio Carlos",
                        LastName = "Árce Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1982, 4, 17),
                        PhoneNumber = "+522813777908",
                        Email = "fabriziocarlosarcecastrejon914@hotmail.com",
                        Username = "fabriziocarlos664",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziocarlosarcecastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Leonel",
                        LastName = "López Pérez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 5, 22),
                        PhoneNumber = "+523613636374",
                        Email = "angelleonellopezperez810@hotmail.com",
                        Username = "angelleonel585",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelleonellopezperez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Christian",
                        LastName = "Pérez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1955, 12, 18),
                        PhoneNumber = "+528418798743",
                        Email = "luischristianperezarce130@hotmail.com",
                        Username = "luischristian781",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luischristianperezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel José",
                        LastName = "Martínez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 4, 14),
                        PhoneNumber = "+523610567946",
                        Email = "angeljosemartinezjuarez55@hotmail.com",
                        Username = "angeljose1",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angeljosemartinezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Óscar Federico",
                        LastName = "Claro Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 6, 19),
                        PhoneNumber = "+521146900218",
                        Email = "oscarfedericoclarogonzali423@hotmail.com",
                        Username = "oscarfederico578",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/oscarfedericoclarogonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fernando Rafaél",
                        LastName = "Gámez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1999, 2, 24),
                        PhoneNumber = "+525768985195",
                        Email = "fernandorafaelgamezcastrejon656@hotmail.com",
                        Username = "fernandorafael65",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fernandorafaelgamezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Jhonatan Alejandro",
                        LastName = "Aguirre Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1997, 4, 11),
                        PhoneNumber = "+521245290259",
                        Email = "jhonatanalejandroaguirreclaro615@hotmail.com",
                        Username = "jhonatanalejandro7",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/jhonatanalejandroaguirreclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Christian Nicolás",
                        LastName = "Castrejón Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 12, 16),
                        PhoneNumber = "+520296939512",
                        Email = "christiannicolascastrejonjuarez545@hotmail.com",
                        Username = "christiannicolas702",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/christiannicolascastrejonjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián António",
                        LastName = "Aguirre Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 1, 7),
                        PhoneNumber = "+526823286146",
                        Email = "sebastianantonioaguirrerodriguez378@hotmail.com",
                        Username = "sebastianantonio819",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianantonioaguirrerodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Luis",
                        LastName = "Quintero Gonzalí",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 7, 15),
                        PhoneNumber = "+521092110888",
                        Email = "moisesluisquinterogonzali309@hotmail.com",
                        Username = "moisesluis339",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesluisquinterogonzali"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Carlos",
                        LastName = "Jiménez Juárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 8, 12),
                        PhoneNumber = "+527930144883",
                        Email = "nicolascarlosjimenezjuarez279@hotmail.com",
                        Username = "nicolascarlos716",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolascarlosjimenezjuarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fabrizio José",
                        LastName = "Carrillo Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 12, 18),
                        PhoneNumber = "+521639761719",
                        Email = "fabriziojosecarrillojimenez529@hotmail.com",
                        Username = "fabriziojose201",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fabriziojosecarrillojimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Javier",
                        LastName = "Fernández Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 12, 23),
                        PhoneNumber = "+521171535208",
                        Email = "migueljavierfernandezenriquez562@hotmail.com",
                        Username = "migueljavier355",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljavierfernandezenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Javier Amadeus",
                        LastName = "Rodríguez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2001, 5, 9),
                        PhoneNumber = "+525512903498",
                        Email = "javieramadeusrodriguezhiguera748@hotmail.com",
                        Username = "javieramadeus103",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/javieramadeusrodriguezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Daniel",
                        LastName = "Rodríguez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 2, 27),
                        PhoneNumber = "+529707612142",
                        Email = "estebandanielrodriguezalvarez61@hotmail.com",
                        Username = "estebandaniel339",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebandanielrodriguezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel António",
                        LastName = "León León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1994, 4, 22),
                        PhoneNumber = "+523796023782",
                        Email = "miguelantonioleonleon129@hotmail.com",
                        Username = "miguelantonio515",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelantonioleonleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Felipe",
                        LastName = "Álvarez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1971, 11, 17),
                        PhoneNumber = "+526694261097",
                        Email = "felipefelipealvarezhigareda414@hotmail.com",
                        Username = "felipefelipe69",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipefelipealvarezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Miguel",
                        LastName = "Martínez Domínguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1988, 7, 6),
                        PhoneNumber = "+521129031920",
                        Email = "angelmiguelmartinezdominguez957@hotmail.com",
                        Username = "angelmiguel845",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelmiguelmartinezdominguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Fitzgerald",
                        LastName = "López González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 4, 23),
                        PhoneNumber = "+525504472127",
                        Email = "federicofitzgeraldlopezgonzalez677@hotmail.com",
                        Username = "federicofitzgerald375",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicofitzgeraldlopezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel Gabriel",
                        LastName = "Lastra Gómez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1951, 2, 25),
                        PhoneNumber = "+527279637523",
                        Email = "miguelgabriellastragomez88@hotmail.com",
                        Username = "miguelgabriel815",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/miguelgabriellastragomez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Fernando",
                        LastName = "Quintero Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1962, 8, 21),
                        PhoneNumber = "+525360189574",
                        Email = "alexanderfernandoquinterocontreras977@hotmail.com",
                        Username = "alexanderfernando238",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfernandoquinterocontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Rafaél",
                        LastName = "Jiménez Rodríguez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 8, 2),
                        PhoneNumber = "+522848600829",
                        Email = "rafaelrafaeljimenezrodriguez797@hotmail.com",
                        Username = "rafaelrafael558",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaelrafaeljimenezrodriguez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Alejandro",
                        LastName = "Rodríguez Árce",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1960, 5, 20),
                        PhoneNumber = "+524312936483",
                        Email = "arturoalejandrorodriguezarce411@hotmail.com",
                        Username = "arturoalejandro367",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoalejandrorodriguezarce"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Eliazar",
                        LastName = "Árce Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 6, 11),
                        PhoneNumber = "+526715991213",
                        Email = "eliazareliazararcenevarez702@hotmail.com",
                        Username = "eliazareliazar308",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazareliazararcenevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Manuel",
                        LastName = "Contreras Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1969, 12, 17),
                        PhoneNumber = "+525309095071",
                        Email = "alejandromanuelcontrerasenriquez106@hotmail.com",
                        Username = "alejandromanuel207",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandromanuelcontrerasenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Manuel Fabrizio",
                        LastName = "Higuera León",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1978, 10, 1),
                        PhoneNumber = "+524416341373",
                        Email = "manuelfabriziohigueraleon530@hotmail.com",
                        Username = "manuelfabrizio789",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/manuelfabriziohigueraleon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Luis",
                        LastName = "Rodríguez Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 9, 23),
                        PhoneNumber = "+528329739681",
                        Email = "carlosluisrodriguezalvarez500@hotmail.com",
                        Username = "carlosluis162",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carlosluisrodriguezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Alejandro",
                        LastName = "Gómez Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 5, 14),
                        PhoneNumber = "+526693675194",
                        Email = "angelalejandrogomezgamez467@hotmail.com",
                        Username = "angelalejandro376",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelalejandrogomezgamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Luis",
                        LastName = "Miranda Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1993, 8, 10),
                        PhoneNumber = "+521235652000",
                        Email = "felipeluismirandahigareda888@hotmail.com",
                        Username = "felipeluis755",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipeluismirandahigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Aarón",
                        LastName = "Bustamante Trujillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1967, 7, 21),
                        PhoneNumber = "+529165986924",
                        Email = "nicolasaaronbustamantetrujillo149@hotmail.com",
                        Username = "nicolasaaron94",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasaaronbustamantetrujillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Óscar",
                        LastName = "Contreras Enríquez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1991, 5, 14),
                        PhoneNumber = "+520557940880",
                        Email = "gabrieloscarcontrerasenriquez345@hotmail.com",
                        Username = "gabrieloscar533",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrieloscarcontrerasenriquez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Federico Estéban",
                        LastName = "Gámez Aguirre",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 11, 8),
                        PhoneNumber = "+521132209682",
                        Email = "federicoestebangamezaguirre8@hotmail.com",
                        Username = "federicoesteban862",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/federicoestebangamezaguirre"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Moisés Daniel",
                        LastName = "Conriquez López",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 6, 10),
                        PhoneNumber = "+527926766312",
                        Email = "moisesdanielconriquezlopez594@hotmail.com",
                        Username = "moisesdaniel848",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/moisesdanielconriquezlopez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Miguel",
                        LastName = "Juárez Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2002, 2, 1),
                        PhoneNumber = "+521284388997",
                        Email = "josemigueljuarezmiranda139@hotmail.com",
                        Username = "josemiguel268",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josemigueljuarezmiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Juan Javier",
                        LastName = "Gómez Castrejón",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1989, 9, 20),
                        PhoneNumber = "+521452945768",
                        Email = "juanjaviergomezcastrejon143@hotmail.com",
                        Username = "juanjavier552",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/juanjaviergomezcastrejon"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Carlos Christian",
                        LastName = "Conriquez Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1972, 10, 8),
                        PhoneNumber = "+521453617158",
                        Email = "carloschristianconriquezhigareda629@hotmail.com",
                        Username = "carloschristian887",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/carloschristianconriquezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Miguel",
                        LastName = "Enríquez Ramones",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1954, 3, 27),
                        PhoneNumber = "+520063075810",
                        Email = "alexandermiguelenriquezramones268@hotmail.com",
                        Username = "alexandermiguel587",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexandermiguelenriquezramones"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Ángel Carlos",
                        LastName = "Juárez González",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 2, 23),
                        PhoneNumber = "+523243180935",
                        Email = "angelcarlosjuarezgonzalez414@hotmail.com",
                        Username = "angelcarlos274",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/angelcarlosjuarezgonzalez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Nicolás Estéban",
                        LastName = "Gonzalí Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1975, 11, 9),
                        PhoneNumber = "+522688306080",
                        Email = "nicolasestebangonzaligamez420@hotmail.com",
                        Username = "nicolasesteban596",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/nicolasestebangonzaligamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Aarón Federico",
                        LastName = "López Álvarez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1985, 2, 18),
                        PhoneNumber = "+527938733127",
                        Email = "aaronfedericolopezalvarez782@hotmail.com",
                        Username = "aaronfederico989",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/aaronfedericolopezalvarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alejandro Eliazar",
                        LastName = "Martínez Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 6, 4),
                        PhoneNumber = "+521069314637",
                        Email = "alejandroeliazarmartinezcarrillo631@hotmail.com",
                        Username = "alejandroeliazar557",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alejandroeliazarmartinezcarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Alexander Fernando",
                        LastName = "López Martínez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1961, 4, 13),
                        PhoneNumber = "+525048410425",
                        Email = "alexanderfernandolopezmartinez515@hotmail.com",
                        Username = "alexanderfernando828",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/alexanderfernandolopezmartinez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Sebastián Estéban",
                        LastName = "Árce Contreras",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2003, 10, 10),
                        PhoneNumber = "+529090444559",
                        Email = "sebastianestebanarcecontreras776@hotmail.com",
                        Username = "sebastianesteban316",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/sebastianestebanarcecontreras"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Luis Leonel",
                        LastName = "Lastra Prado",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1950, 8, 22),
                        PhoneNumber = "+527347814263",
                        Email = "luisleonellastraprado329@hotmail.com",
                        Username = "luisleonel824",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/luisleonellastraprado"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Rafaél Juan",
                        LastName = "Trujillo Miranda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1980, 12, 16),
                        PhoneNumber = "+524790308452",
                        Email = "rafaeljuantrujillomiranda721@hotmail.com",
                        Username = "rafaeljuan552",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/rafaeljuantrujillomiranda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Felipe Moisés",
                        LastName = "Castrejón Gámez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1968, 7, 19),
                        PhoneNumber = "+520522128292",
                        Email = "felipemoisescastrejongamez104@hotmail.com",
                        Username = "felipemoises375",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/felipemoisescastrejongamez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Estéban Eliazar",
                        LastName = "Aguirre Zavala",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1963, 1, 26),
                        PhoneNumber = "+525116912422",
                        Email = "estebaneliazaraguirrezavala140@hotmail.com",
                        Username = "estebaneliazar956",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/estebaneliazaraguirrezavala"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Eliazar Gerardo",
                        LastName = "Fernández Nevárez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1981, 3, 10),
                        PhoneNumber = "+523004488306",
                        Email = "eliazargerardofernandeznevarez663@hotmail.com",
                        Username = "eliazargerardo589",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/eliazargerardofernandeznevarez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Miguel José",
                        LastName = "Higareda Carrillo",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 3, 1),
                        PhoneNumber = "+526311659542",
                        Email = "migueljosehigaredacarrillo431@hotmail.com",
                        Username = "migueljose273",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/migueljosehigaredacarrillo"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Fitzgerald Fabrizio",
                        LastName = "Nevárez Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1970, 4, 24),
                        PhoneNumber = "+521081709810",
                        Email = "fitzgeraldfabrizionevarezjimenez397@hotmail.com",
                        Username = "fitzgeraldfabrizio256",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/fitzgeraldfabrizionevarezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Arturo Eliazar",
                        LastName = "López Higareda",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(2004, 7, 3),
                        PhoneNumber = "+525039137837",
                        Email = "arturoeliazarlopezhigareda11@hotmail.com",
                        Username = "arturoeliazar777",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/arturoeliazarlopezhigareda"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gabriel Estéban",
                        LastName = "López Jiménez",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1964, 7, 24),
                        PhoneNumber = "+523394614401",
                        Email = "gabrielestebanlopezjimenez943@hotmail.com",
                        Username = "gabrielesteban158",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gabrielestebanlopezjimenez"
                    }
                    ,
                    new User()
                    {
                        FirstName = "José Miguel",
                        LastName = "Jiménez Higuera",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1986, 3, 24),
                        PhoneNumber = "+528183868298",
                        Email = "josemigueljimenezhiguera449@hotmail.com",
                        Username = "josemiguel963",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/josemigueljimenezhiguera"
                    }
                    ,
                    new User()
                    {
                        FirstName = "António Arturo",
                        LastName = "Gámez Claro",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1966, 8, 9),
                        PhoneNumber = "+526539607875",
                        Email = "antonioarturogamezclaro678@hotmail.com",
                        Username = "antonioarturo216",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/antonioarturogamezclaro"
                    }
                    ,
                    new User()
                    {
                        FirstName = "Gerardo Eliazar",
                        LastName = "Álvarez Fernández",
                        Country = "México",
                        Province = "Sonora",
                        City = "Hermosillo",
                        ZipCode = "83170",
                        Birthdate = new DateTime(1990, 5, 5),
                        PhoneNumber = "+520984058166",
                        Email = "gerardoeliazaralvarezfernandez296@hotmail.com",
                        Username = "gerardoeliazar258",
                        PasswordHash = Util.GetSha256("Um8$qfjp"),
                        LinkedInProfileUrl = "https://www.linkedin.com/in/gerardoeliazaralvarezfernandez"
                    }
                };
                foreach (User user in users)
                {
                    dbContext.Users.Add(user);
                }
                dbContext.SaveChanges();
            }
        }
    }
}
