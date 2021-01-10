using System;
using System.Collections.Generic;
using System.Linq;

namespace Korelskiy.CityGuide.Models.Guide
{
    internal class City
    {
        public uint id { get; set; }
        public string Name { get; set; }
        public int BecomeCity { get; set; }
        public int Population_2000 { get; set; }
        public int Population_2010 { get; set; }
        public int Population_2020 { get; set; }
        public double Growth_2000_2010 { get; set; }
        public double Growth_2010_2020 { get; set; }
        public double Growth_2000_2020 { get; set; }
        public int StateIndex { get; set; }
        public int Id { get; set; }

        public string StateName { get; set; }

        public static List<City> Cities { get; set; }

        public static void AddCities()
        {
            // new City(){Name = "", BecomeCity = , Population_2000 = , Population_2010 = , Population_2020 = , StateIndex = , Id = },
            var cities = new List<City>()
            {
                new City(){Name = "Нарьян-Мар", BecomeCity = 1935, Population_2000 = 18611, Population_2010 = 21658, Population_2020 = 25151, StateIndex = 1, Id = 1},

                new City(){Name = "Анадырь", BecomeCity = 1965, Population_2000 = 11900, Population_2010 = 13045, Population_2020 = 15819, StateIndex = 2, Id = 2},
                new City(){Name = "Билибино", BecomeCity = 1993, Population_2000 = 7700, Population_2010 = 5506, Population_2020 = 5516, StateIndex = 2, Id = 3},
                new City(){Name = "Певек", BecomeCity = 1967, Population_2000 = 5600, Population_2010 = 4162, Population_2020 = 4494, StateIndex = 2, Id = 4},

                new City(){Name = "Магадан", BecomeCity = 1939, Population_2000 = 120931, Population_2010 = 95463, Population_2020 = 92052, StateIndex = 3, Id = 5},
                new City(){Name = "Сусуман", BecomeCity = 1964, Population_2000 = 8901, Population_2010 = 5855, Population_2020 = 4355, StateIndex = 3, Id = 6},

                new City(){Name = "Биробиджан", BecomeCity = 1937, Population_2000 = 79800, Population_2010 = 75413, Population_2020 = 71843, StateIndex = 4, Id = 7},
                new City(){Name = "Облучье", BecomeCity = 1938, Population_2000 = 11300, Population_2010 = 9379, Population_2020 = 8365, StateIndex = 4, Id = 8},

                new City(){Name = "Горно-Алтайск", BecomeCity = 1928, Population_2000 = 52200, Population_2010 = 56933, Population_2020 = 64464, StateIndex = 5, Id = 9},

                new City(){Name = "Элиста", BecomeCity = 1930, Population_2000 = 101988, Population_2010 = 103749, Population_2020 = 103122, StateIndex = 6, Id = 10},
                new City(){Name = "Лагань", BecomeCity = 1963, Population_2000 = 15300, Population_2010 = 14323, Population_2020 = 12769, StateIndex = 6, Id = 11},
                new City(){Name = "Городовиковск", BecomeCity = 1971, Population_2000 = 10300, Population_2010 = 9565, Population_2020 = 8571, StateIndex = 6, Id = 12},

                new City(){Name = "Петропавловск-Камчатский", BecomeCity = 1812, Population_2000 = 194100, Population_2010 = 179780, Population_2020 = 179586, StateIndex = 7, Id = 13},
                new City(){Name = "Елизово", BecomeCity = 1975, Population_2000 = 37600, Population_2010 = 39569, Population_2020 = 39345, StateIndex = 7, Id = 14},
                new City(){Name = "Вилючинск", BecomeCity = 1968, Population_2000 = 32300, Population_2010 = 25401, Population_2020 = 22223, StateIndex = 7, Id = 15},

                new City(){Name = "Кызыл", BecomeCity = 1914, Population_2000 = 99868, Population_2010 = 109918, Population_2020 = 119438, StateIndex = 8, Id = 16},
                new City(){Name = "Ак-Довурак", BecomeCity = 1964, Population_2000 = 12686, Population_2010 = 13468, Population_2020 = 13609, StateIndex = 8, Id = 17},
                new City(){Name = "Шагонар", BecomeCity = 1945, Population_2000 = 9000, Population_2010 = 10956, Population_2020 = 11182, StateIndex = 8, Id = 18},
                new City(){Name = "Чадан", BecomeCity = 1945, Population_2000 = 8600, Population_2010 = 9035, Population_2020 = 9351, StateIndex = 8, Id = 19},
                new City(){Name = "Туран", BecomeCity = 1945, Population_2000 = 5700, Population_2010 = 4981, Population_2020 = 4903, StateIndex = 8, Id = 20},

                new City(){Name = "Севастополь", BecomeCity = 1783, Population_2000 = 348000, Population_2010 = 340102, Population_2020 = 449138, StateIndex = 9, Id = 21},

                new City(){Name = "Майкоп", BecomeCity = 1870, Population_2000 = 167300, Population_2010 = 144249, Population_2020 = 141475, StateIndex = 10, Id = 22},
                new City(){Name = "Адыгейск", BecomeCity = 1976, Population_2000 = 12400, Population_2010 = 12237, Population_2020 = 12721, StateIndex = 10, Id = 23},

                new City(){Name = "Черкесск", BecomeCity = 1935, Population_2000 = 121700, Population_2010 = 129069, Population_2020 = 123168, StateIndex = 11, Id = 24},
                new City(){Name = "Усть-Джегута", BecomeCity = 1975, Population_2000 = 31500, Population_2010 = 30566, Population_2020 = 30559, StateIndex = 11, Id = 25},
                new City(){Name = "Карачаевск", BecomeCity = 1929, Population_2000 = 22113, Population_2010 = 21483, Population_2020 = 20828, StateIndex = 11, Id = 26},
                new City(){Name = "Теберда", BecomeCity = 1971, Population_2000 = 7600, Population_2010 = 9058, Population_2020 = 8648 , StateIndex = 11, Id = 27},

                new City(){Name = "Южно-Сахалинск", BecomeCity = 1915, Population_2000 = 179200, Population_2010 = 181728, Population_2020 = 200636, StateIndex = 12, Id = 28},
                new City(){Name = "Корсаков", BecomeCity = 1907, Population_2000 = 37000, Population_2010 = 33526, Population_2020 = 34023, StateIndex = 12, Id = 29},
                new City(){Name = "Холмск", BecomeCity = 1922, Population_2000 = 39900, Population_2010 = 30937, Population_2020 = 27148, StateIndex = 12, Id = 30},
                new City(){Name = "Оха", BecomeCity = 1938, Population_2000 = 28200, Population_2010 = 23008, Population_2020 = 20016, StateIndex = 12, Id = 31},
                new City(){Name = "Поронайск", BecomeCity = 1946, Population_2000 = 21800, Population_2010 = 16120, Population_2020 = 15561, StateIndex = 12, Id = 32},
                new City(){Name = "Долинск", BecomeCity = 1922, Population_2000 = 14000, Population_2010 = 12200, Population_2020 = 11851, StateIndex = 12, Id = 33},
                new City(){Name = "Невельск", BecomeCity = 1946, Population_2000 = 20600, Population_2010 = 11682, Population_2020 = 9815, StateIndex = 12, Id = 34},
                new City(){Name = "Анива", BecomeCity = 1947, Population_2000 = 8600, Population_2010 = 9115, Population_2020 = 9378, StateIndex = 12, Id = 35},
                new City(){Name = "Александровск-Сахалинский", BecomeCity = 1917, Population_2000 = 15800, Population_2010 = 10613, Population_2020 = 9125, StateIndex = 12, Id = 36},
                new City(){Name = "Углегорск", BecomeCity = 1946, Population_2000 = 15700, Population_2010 = 10381, Population_2020 = 8710, StateIndex = 12, Id = 37},
                new City(){Name = "Макаров", BecomeCity = 1947, Population_2000 = 8900, Population_2010 = 6705, Population_2020 = 6324, StateIndex = 12, Id = 38},
                new City(){Name = "Томари", BecomeCity = 1947, Population_2000 = 6700, Population_2010 = 4541, Population_2020 = 3771, StateIndex = 12, Id = 39},
                new City(){Name = "Северо-Курильск", BecomeCity = 1947, Population_2000 = 3700, Population_2010 = 2536, Population_2020 = 2592, StateIndex = 12, Id = 40},
                new City(){Name = "Курильск", BecomeCity = 1947, Population_2000 = 2100, Population_2010 = 2070, Population_2020 = 1519, StateIndex = 12, Id = 41},

                new City(){Name = "Назрань", BecomeCity = 1967, Population_2000 = 78000, Population_2010 = 93335, Population_2020 = 122261, StateIndex = 13, Id = 42},
                new City(){Name = "Сунжа", BecomeCity = 2016, Population_2000 = 65112, Population_2010 = 61598, Population_2020 = 66344, StateIndex = 13, Id = 43},
                new City(){Name = "Карабулак", BecomeCity = 1995, Population_2000 = 27700, Population_2010 = 30961, Population_2020 = 42724, StateIndex = 13, Id = 44},
                new City(){Name = "Малгобек", BecomeCity = 1939, Population_2000 = 55200, Population_2010 = 31018, Population_2020 = 38649 , StateIndex = 13, Id = 45},
                new City(){Name = "Магас", BecomeCity = 2000, Population_2000 = 100, Population_2010 = 2502, Population_2020 = 12170 , StateIndex = 13, Id = 46},

                new City(){Name = "Абакан", BecomeCity = 1931, Population_2000 = 169200, Population_2010 = 165214, Population_2020 = 186797, StateIndex = 14, Id = 47},
                new City(){Name = "Черногорск", BecomeCity = 1907, Population_2000 = 78700, Population_2010 = 72147, Population_2020 = 75419, StateIndex = 14, Id = 48},
                new City(){Name = "Саяногорск", BecomeCity = 1830, Population_2000 = 55100, Population_2010 = 49887, Population_2020 = 45951, StateIndex = 14, Id = 49},
                new City(){Name = "Абаза", BecomeCity = 1867, Population_2000 = 18700, Population_2010 = 17115, Population_2020 = 14990, StateIndex = 14, Id = 50},
                new City(){Name = "Сорск", BecomeCity = 1940, Population_2000 = 14900, Population_2010 = 12143, Population_2020 = 11215 , StateIndex = 14, Id = 51},

                new City(){Name = "Новый Уренгой", BecomeCity = 1980, Population_2000 = 89200, Population_2010 = 104107, Population_2020 = 118033, StateIndex = 15, Id = 52},
                new City(){Name = "Ноябрьск", BecomeCity = 1982, Population_2000 = 96400, Population_2010 = 110620, Population_2020 = 106911, StateIndex = 15, Id = 53},
                new City(){Name = "Салехард", BecomeCity = 1938, Population_2000 = 36827, Population_2010 = 42544, Population_2020 = 50976, StateIndex = 15, Id = 54},
                new City(){Name = "Надым", BecomeCity = 1972, Population_2000 = 44900, Population_2010 = 46611, Population_2020 = 44830, StateIndex = 15, Id = 55},
                new City(){Name = "Муравленко", BecomeCity = 1990, Population_2000 = 36200, Population_2010 = 33391, Population_2020 = 31561, StateIndex = 15, Id = 56},
                new City(){Name = "Губкинский", BecomeCity = 1996, Population_2000 = 19200, Population_2010 = 23335, Population_2020 = 29161, StateIndex = 15, Id = 57},
                new City(){Name = "Лабытнанги", BecomeCity = 1975, Population_2000 = 26500, Population_2010 = 26936, Population_2020 = 26295, StateIndex = 15, Id = 58},
                new City(){Name = "Тарко-Сале", BecomeCity = 2004, Population_2000 = 18300, Population_2010 = 20398, Population_2020 = 21501, StateIndex = 15, Id = 59},

                new City(){Name = "Великий Новгород", BecomeCity = 859, Population_2000 = 229500, Population_2010 = 218717, Population_2020 = 224936, StateIndex = 16, Id = 60},
                new City(){Name = "Боровичи", BecomeCity = 1770, Population_2000 = 61400, Population_2010 = 53690, Population_2020 = 49012, StateIndex = 16, Id = 61},
                new City(){Name = "Старая Русса", BecomeCity = 1167, Population_2000 = 40900, Population_2010 = 31809, Population_2020 = 27739, StateIndex = 16, Id = 62},
                new City(){Name = "Пестово", BecomeCity = 1965, Population_2000 = 16300, Population_2010 = 15903, Population_2020 = 14985, StateIndex = 16, Id = 63},
                new City(){Name = "Валдай", BecomeCity = 1770, Population_2000 = 18800, Population_2010 = 16098, Population_2020 = 13987, StateIndex = 16, Id = 64},
                new City(){Name = "Чудово", BecomeCity = 1937, Population_2000 = 18000, Population_2010 = 15397, Population_2020 = 13909, StateIndex = 16, Id = 65},
                new City(){Name = "Малая Вишера", BecomeCity = 1921, Population_2000 = 14500, Population_2010 = 12461, Population_2020 = 10253, StateIndex = 16, Id = 66},
                new City(){Name = "Окуловка", BecomeCity = 1965, Population_2000 = 15500, Population_2010 = 12464, Population_2020 = 9772, StateIndex = 16, Id = 67},
                new City(){Name = "Сольцы", BecomeCity = 1914, Population_2000 = 12700, Population_2010 = 10086, Population_2020 = 8535, StateIndex = 16, Id = 68},
                new City(){Name = "Холм", BecomeCity = 1777, Population_2000 = 4700, Population_2010 = 3830, Population_2020 = 3359, StateIndex = 16, Id = 69},

                new City(){Name = "Петрозводск", BecomeCity = 1777, Population_2000 = 282100, Population_2010 = 261987, Population_2020 = 281023, StateIndex = 17, Id = 70},
                new City(){Name = "Костомукша", BecomeCity = 1983, Population_2000 = 31800, Population_2010 = 28436, Population_2020 = 29634, StateIndex = 17, Id = 71},
                new City(){Name = "Кондопога", BecomeCity = 1938, Population_2000 = 36700, Population_2010 = 32987, Population_2020 = 29128, StateIndex = 17, Id = 72},
                new City(){Name = "Сегежа", BecomeCity = 1943, Population_2000 = 34600, Population_2010 = 29631, Population_2020 = 26000, StateIndex = 17, Id = 73},
                new City(){Name = "Сортавала", BecomeCity = 1783, Population_2000 = 20600, Population_2010 = 19235, Population_2020 = 18831, StateIndex = 17, Id = 74},
                new City(){Name = "Медвежьегорск", BecomeCity = 1938, Population_2000 = 18400, Population_2010 = 15533, Population_2020 = 14091, StateIndex = 17, Id = 75},
                new City(){Name = "Кемь", BecomeCity = 1785, Population_2000 = 16700, Population_2010 = 13051, Population_2020 = 10648, StateIndex = 17, Id = 76},
                new City(){Name = "Питкяранта", BecomeCity = 1940, Population_2000 = 14400, Population_2010 = 11429, Population_2020 = 10184, StateIndex = 17, Id = 77},
                new City(){Name = "Беломорск", BecomeCity = 1938, Population_2000 = 15600, Population_2010 = 11217, Population_2020 = 9199, StateIndex = 17, Id = 78},
                new City(){Name = "Суоярви", BecomeCity = 1940, Population_2000 = 11100, Population_2010 = 9766, Population_2020 = 8678, StateIndex = 17, Id = 79},
                new City(){Name = "Пудож", BecomeCity = 1785, Population_2000 = 10632, Population_2010 = 9698, Population_2020 = 8606, StateIndex = 17, Id = 80},
                new City(){Name = "Олонец", BecomeCity = 1649, Population_2000 = 10240, Population_2010 = 9056, Population_2020 = 8026, StateIndex = 17, Id = 81},
                new City(){Name = "Лахденпохья", BecomeCity = 1945, Population_2000 = 10300, Population_2010 = 7813, Population_2020 = 7050, StateIndex = 17, Id = 82},

                new City(){Name = "Псков", BecomeCity = 903, Population_2000 = 201500, Population_2010 = 203279, Population_2020 = 210340, StateIndex = 18, Id = 83},
                new City(){Name = "Великие Луки", BecomeCity = 1777, Population_2000 = 116300, Population_2010 = 98778, Population_2020 = 90922, StateIndex = 18, Id = 84},
                new City(){Name = "Остров", BecomeCity = 1341, Population_2000 = 29100, Population_2010 = 21668, Population_2020 = 20506, StateIndex = 18, Id = 85},
                new City(){Name = "Невель", BecomeCity = 1773, Population_2000 = 20400, Population_2010 = 16324, Population_2020 = 14481, StateIndex = 18, Id = 86},
                new City(){Name = "Опочка", BecomeCity = 1412, Population_2000 = 14800, Population_2010 = 11603, Population_2020 = 9495, StateIndex = 18, Id = 87},
                new City(){Name = "Печоры", BecomeCity = 1782, Population_2000 = 14000, Population_2010 = 11195, Population_2020 = 9333, StateIndex = 18, Id = 88},
                new City(){Name = "Порхов", BecomeCity = 1239, Population_2000 = 13300, Population_2010 = 10608, Population_2020 = 8347, StateIndex = 18, Id = 89},
                new City(){Name = "Дно", BecomeCity = 1925, Population_2000 = 11700, Population_2010 = 9061, Population_2020 = 7381, StateIndex = 18, Id = 90},
                new City(){Name = "Новосокольники", BecomeCity = 1925, Population_2000 = 10300, Population_2010 = 8119, Population_2020 = 7003, StateIndex = 18, Id = 91},
                new City(){Name = "Пыталово", BecomeCity = 1933, Population_2000 = 7200, Population_2010 = 5826, Population_2020 = 5354, StateIndex = 18, Id = 92},
                new City(){Name = "Себеж", BecomeCity = 1772, Population_2000 = 6300, Population_2010 = 6375, Population_2020 = 5301, StateIndex = 18, Id = 93},
                new City(){Name = "Пустошка", BecomeCity = 1925, Population_2000 = 5509, Population_2010 = 4619, Population_2020 = 3862, StateIndex = 18, Id = 94},
                new City(){Name = "Гдов", BecomeCity = 1322, Population_2000 = 5800, Population_2010 = 4379, Population_2020 = 3257, StateIndex = 18, Id = 95},
                new City(){Name = "Новоржев", BecomeCity = 1777, Population_2000 = 4800, Population_2010 = 3695, Population_2020 = 3107, StateIndex = 18, Id = 96},

                new City(){Name = "Кострома", BecomeCity = 1152, Population_2000 = 288100, Population_2010 = 268742, Population_2020 = 276929, StateIndex = 19, Id = 97},
                new City(){Name = "Шарья", BecomeCity = 1938, Population_2000 = 26300, Population_2010 = 23681, Population_2020 = 23544, StateIndex = 19, Id = 98},
                new City(){Name = "Буй", BecomeCity = 1719, Population_2000 = 28800, Population_2010 = 25763, Population_2020 = 23233, StateIndex = 19, Id = 99},
                new City(){Name = "Нерехта", BecomeCity = 1778, Population_2000 = 28000, Population_2010 = 22828, Population_2020 = 20929, StateIndex = 19, Id = 100},
                new City(){Name = "Галич", BecomeCity = 1237, Population_2000 = 20200, Population_2010 = 17346, Population_2020 = 16754, StateIndex = 19, Id = 101},
                new City(){Name = "Волгореченск", BecomeCity = 1994, Population_2000 = 19000, Population_2010 = 17104, Population_2020 = 16276, StateIndex = 19, Id = 102},
                new City(){Name = "Мантурово", BecomeCity = 1958, Population_2000 = 19457, Population_2010 = 17479, Population_2020 = 14988, StateIndex = 19, Id = 103},
                new City(){Name = "Нея", BecomeCity = 1958, Population_2000 = 11506, Population_2010 = 9827, Population_2020 = 8573, StateIndex = 19, Id = 104},
                new City(){Name = "Макарьев", BecomeCity = 1778, Population_2000 = 8300, Population_2010 = 7274, Population_2020 = 6390, StateIndex = 19, Id = 105},
                new City(){Name = "Солигалич", BecomeCity = 1778, Population_2000 = 7000, Population_2010 = 6438, Population_2020 = 5918, StateIndex = 19, Id = 106},
                new City(){Name = "Чухлома", BecomeCity = 1778, Population_2000 = 5600, Population_2010 = 5411, Population_2020 = 4936, StateIndex = 19, Id = 107},
                new City(){Name = "Кологрив", BecomeCity = 1778, Population_2000 = 4000, Population_2010 = 3314, Population_2020 = 2882, StateIndex = 19, Id = 108},

                new City(){Name = "Йошкар-Ола", BecomeCity = 1781, Population_2000 = 249200, Population_2010 = 248782, Population_2020 = 274715, StateIndex = 20, Id = 109},
                new City(){Name = "Волжск", BecomeCity = 1940, Population_2000 = 61500, Population_2010 = 55659, Population_2020 = 53216, StateIndex = 20, Id = 110},
                new City(){Name = "Козьмодемьянск", BecomeCity = 1781, Population_2000 = 24700, Population_2010 = 21257, Population_2020 = 20062, StateIndex = 20, Id = 111},
                new City(){Name = "Звенигово", BecomeCity = 1974, Population_2000 = 14200, Population_2010 = 11946, Population_2020 = 10904, StateIndex = 20, Id = 112},

                new City(){Name = "Владикавказ", BecomeCity = 1860, Population_2000 = 310100, Population_2010 = 311693, Population_2020 = 303597, StateIndex = 21, Id = 113},
                new City(){Name = "Моздок", BecomeCity = 1785, Population_2000 = 39300, Population_2010 = 38768, Population_2020 = 42039, StateIndex = 21, Id = 114},
                new City(){Name = "Беслан", BecomeCity = 1950, Population_2000 = 34500, Population_2010 = 36728, Population_2020 = 37371, StateIndex = 21, Id = 115},
                new City(){Name = "Алагир", BecomeCity = 1938, Population_2000 = 23100, Population_2010 = 20949, Population_2020 = 19737, StateIndex = 21, Id = 116},
                new City(){Name = "Ардон", BecomeCity = 1964, Population_2000 = 16400, Population_2010 = 18774, Population_2020 = 19298, StateIndex = 21, Id = 117},
                new City(){Name = "Дигора", BecomeCity = 1962, Population_2000 = 12200, Population_2010 = 10856, Population_2020 = 10089, StateIndex = 21, Id = 118},

            };
             Cities = new List<City>();
            //uint i = 1;
            //var t = cities.Select(x => new City() { id = i++, Name = x.Name, Population_2000 = x.Population_2000, BecomeCity = x.BecomeCity, Population_2010 = x.Population_2010, Population_2020 = x.Population_2020, StateName = x.StateName, StateIndex = x.StateIndex, Id = x.Id}).ToList();
            Cities.AddRange(cities);
        }

        public static void PopulationChange(List<City> cities)
        {
            double num;
            foreach (City city in cities)
            {
                num = (double)(1 - (double)city.Population_2020 / city.Population_2000) * 100;
                num = Math.Round(num, 4) * -1;
                city.Growth_2000_2020 = num;
                
                city.StateName = State.States.Find(item => item.Id == city.StateIndex).Name;
            }
        }
    }
}
