using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the" +
                "Solar system. In English, it is named after the ancient. Roman god Mercurius (Mercury)" +
                "The surface of Mercury is similar to Earth's Moon, being heavily cratered, " +
                "with an expansive rupes system generated from thrust faults, and bright ray" +
                "systems, formed by ejecta. Its largest crater, Caloris Planitia, has a diameter" +
                "of 1,550 km (960 mi), which is about one-third the diameter of the planet" +
                "(4,880 km or 3,030 mi).",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },
               new()
            {
                Name = "Venus",
                Subtitle = "The second planet",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is often called Earth's \"twin\" or \"sister" +
                "among the planets of the Solar System for its orbit being the closest to Earth's, " +
                "both being rocky planets, and having the most similar and nearly equal size, " +
                "mass, and surface gravity. Venus, though, is significantly different, especially as it has no liquid water," +
                "and its atmosphere is far thicker and denser than that of any other rocky body in the Solar System." +
                "The atmosphere is composed mostly of carbon dioxide and has a thick" +
                "cloud layer of sulfuric acid that spans the whole planet.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },

                new()
            {
                Name = "Earth",
                Subtitle = "The third planet",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only astronomical object" +
                "known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar " +
                "System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean," +
                "covering 70.8% of Earth's crust. The remaining 29.2% of Earth's" +
                "crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere." +
                "Most of Earth's land is at least somewhat humid and covered by vegetation," +
                "while large ice sheets at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers," + 
                "and atmospheric water combined.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

                new()
            {
                Name = "Mars",
                Subtitle = "The fourth planet ",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun. It is also known as the \"Red Planet\", " +
                "because of its orange-red appearance. Mars is a desert-like rocky planet with a " +
                "tenuous atmosphere that is primarily carbon dioxide (CO2). At the average surface level the " +
                "atmospheric pressure is a few thousandths of Earth’s, atmospheric temperature ranges" +
                "from −153 to 20 °C (−243 to 68 °F)[24] and cosmic radiation is high." +
                "Mars retains some water, in the ground as well as thinly in the atmosphere," +
                "forming cirrus clouds, fog, frost, larger polar regions of permafrost and ice caps," +
                "but no bodies of liquid surface water. .",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

                new()
            {
                Name = "Jupiter",
                Subtitle = "The fifth planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System." +
                "It is a gas giant with a mass nearly 2.5 times that of all the other planets" +
                "in the Solar System combined and slightly less than one-thousandth the mass " +
                "of the Sun. Its diameter is 11 times that of Earth and a tenth that of the Sun." +
                "Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm), with an orbital period of 11.86 years." +
                "It is the third-brightest natural object in the Earth's night sky, after the Moon" +
                "and Venus, and has been observed since prehistoric times.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                       "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

                 new()
            {
                Name = "Saturn",
                Subtitle = "The sixth planet ",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second largest in the Solar System," +
                "after Jupiter. It is a gas giant, with an average radius of about 9 times that of Earth. " +
                "It has an eighth of the average density of Earth,  " +
                "but is over 95 times more massive. Even though Saturn is almost as" +
                "big as Jupiter, Saturn has less than a third of its mass. Saturn orbits the Sun at a distance of 9.59 AU" +
                "(1,434 million km), with an orbital period of 29.45 years.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                        "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                        "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },


                new()
            {
                Name = "Uranus",
                Subtitle = "The seventh planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant." +
                "Most of the planet is made of water, ammonia, and methane in a supercritical phase of " +
                "matter, which astronomy calls \"ice\" or volatiles. " +
                "The planet's atmosphere has a complex layered cloud structure and has the lowest" +
                "It has a marked axial tilt of 82.23° with a " +
                "retrograde rotation period of 17 hours and 14 minutes. " ,
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                       "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },


                new()
            {
                Name = "Neptune",
                Subtitle = "The eighth and farthest known planet ",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet orbiting the Sun." +
                "It is the fourth-largest planet in the Solar System by diameter, " +
                "the third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth. Compared to Uranus, its neighbouring ice giant, " +
                "Neptune is slightly smaller, but more massive and denser. " +
                "Being composed primarily of gases and liquids, it has no well-defined solid surface." +
                "cNeptune orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical" + 
                "units (4.5 billion kilometres; 2.8 billion miles).",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

                // KODUTÖÖ 06/10/2025

                new()
            {
                Name = "Pluto",
                Subtitle = "The ninth planet. ",
                HeroImage = "pluto.png",
                Description = "Pluto is a complex and mysterious world with mountains, valleys, plains, craters, and glaciers." +
                "It is located in the distant Kuiper Belt. " +
                "Discovered in 1930, Pluto was long considered our solar system's ninth planet. But after " +
                "the discovery of similar worlds deeper in the Kuiper Belt, Pluto was reclassified as a dwarf planet in 2006 " +
                "by the International Astronomical Union. " +
                "Pluto is only about 1,400 miles wide. At that small size, Pluto is only about half the width of the United States." +
                "It's about 3.6 billion miles away from the Sun, and it has a thin atmosphere composed " +
                "mostly of nitrogen, methane, and carbon monoxide.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://science.nasa.gov/wp-content/uploads/2024/03/pluto-new-horizons-pia20291-16x9-1.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },


                new()
            {
                Name = "Ceres",
                Subtitle = "The eighth and farthest known planet ",
                HeroImage = "neptune.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, " +
                "and it's the only dwarf planet located in the inner solar system. " +
                "It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801." +
                "When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft. " +
                "Called an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that " +
                "scientists classified it as a dwarf planet in 2006. " +
                "Even though Ceres comprises 25% of the asteroid belt's total" +
                "mass, Pluto is still 14 times more massive..",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },



                new()
            {
                Name = "Haumea",
                Subtitle = "It is oval-shaped, and is one of the fastest rotating large objects",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf planet that is one of the fastest rotating large objects " +
                "in our solar system. The fast spin distorts Haumea's shape, " +
                "making this dwarf planet look like a football." +
                "Two teams claim credit for discovering Haumea citing evidence from observations made in 2003 and 2004. " +
                "The International Astronomical Union’s Gazetteer of Planetary Nomenclature " +
                "lists the discovery location as Sierra Nevada Observatory in Spain on March 7, 2003, but no official discoverer is listed. " +
                "Haumea is named after the Hawaiian goddess of fertility.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },



                 new()
            {
                Name = "MakeMake",
                Subtitle = "Slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt ",
                HeroImage = "makemake.png",
                Description = "Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt" +
                "as seen from Earth while Pluto is the brightest. " +
                "It takes about 305 Earth years for this dwarf planet to make one trip around the Sun. " +
                "Makemake holds an important place in the history of solar system studies because " +
                " it was one of the objects – along with Eris – whose discovery prompted the International Astronomical Union " +
                "o reconsider the definition of a planet, and to create the new group of dwarf planets." ,
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                       "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

                 
                new()
            {
                Name = "Erics",
                Subtitle = "The eighth and farthest known planet ",
                HeroImage = "erics.png",
                Description = "The discovery of Eris help trigger a debate in the scientific community that led to the" +
                "International Astronomical Union's decision in 2006 to clarify the definition of a planet." +
                "Pluto, Eris, and other similar objects are now classified as dwarf planets. " +
                "Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003,  " +
                "during a Palomar Observatory survey of the outer solar system by Mike Brown, " +
                "a professor of planetary astronomy at the California Institute of Technology;" +
                "Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University." ,
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                      "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                      "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

        };





        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
