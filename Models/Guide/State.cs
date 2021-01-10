using System.Collections.Generic;

namespace Korelskiy.CityGuide.Models.Guide
{
    internal class State
    {
        public string Name { get; set; }
        public IList<City> Cities { get; set; }
        public int Id { get; set; }

        public static List<State> States { get; set; } = new List<State>();
        public static void GetStates(List<City> cities)
        {

            //List<string> statesname = new List<string>(new string[] { "Ненецкий АО", "Чукотский АО", "Магаданская область", "Еврейская АО", "Республика Алтай", "Республика Калмыкия" });

            //List<State> _states = new List<State>();
            //for (int i = 1; i < statesname.Count + 1; i++)
            //{
            //    uint j = 1;
            //    _states.Add(new State() { Name = statesname[i - 1], Cities = cities.FindAll(index => index.StateIndex == i).ToList().Select(x => new City() { id = j++, Name = x.Name, Population_2000 = x.Population_2000, BecomeCity = x.BecomeCity, Population_2010 = x.Population_2010, Population_2020 = x.Population_2020, StateIndex = x.StateIndex, Id = x.Id }).ToList(), Id = i });
            //}


            var states = new List<State>()
            {//new State(){Name = "", Cities = cities.FindAll(index => index.StateIndex == ), Id = },
                new State(){
                    Name = "Ненецкий АО",
                    Cities = cities.FindAll(index => index.StateIndex == 1),
                    Id = 1
                },

                new State(){Name = "Чукотский АО", Cities = cities.FindAll(index => index.StateIndex == 2), Id = 2},
                new State(){Name = "Магаданская область", Cities = cities.FindAll(index => index.StateIndex == 3), Id = 3},
                new State(){Name = "Еврейская АО", Cities = cities.FindAll(index => index.StateIndex == 4), Id = 4},
                new State(){Name = "Республика Алтай", Cities = cities.FindAll(index => index.StateIndex == 5), Id = 5},
                new State(){Name = "Республика Калмыкия", Cities = cities.FindAll(index => index.StateIndex == 6), Id = 6},
                new State(){Name = "Камчатский край", Cities = cities.FindAll(index => index.StateIndex == 7), Id = 7},
                new State(){Name = "Республика Тыва", Cities = cities.FindAll(index => index.StateIndex == 8), Id = 8},
                new State(){Name = "Город федерального значения", Cities = cities.FindAll(index => index.StateIndex == 9), Id = 9},
                new State(){Name = "Республика Адыгея", Cities = cities.FindAll(index => index.StateIndex == 10), Id = 10},
                new State(){Name = "Карачаево-Черкесская республика", Cities = cities.FindAll(index => index.StateIndex == 11), Id = 11},
                new State(){Name = "Сахалинская область", Cities = cities.FindAll(index => index.StateIndex == 12), Id = 12},
                new State(){Name = "Республика Ингушетия", Cities = cities.FindAll(index => index.StateIndex == 13), Id = 13},
                new State(){Name = "Республика Хакасия", Cities = cities.FindAll(index => index.StateIndex == 14), Id = 14},
                new State(){Name = "Ямало-Ненецкий АО", Cities = cities.FindAll(index => index.StateIndex == 15), Id = 15},
                new State(){Name = "Новгородская область", Cities = cities.FindAll(index => index.StateIndex == 16), Id = 16},
                new State(){Name = "Республика Карелия", Cities = cities.FindAll(index => index.StateIndex == 17), Id = 17},
                new State(){Name = "Псковская область", Cities = cities.FindAll(index => index.StateIndex == 18), Id = 18},
                new State(){Name = "Костромская область", Cities = cities.FindAll(index => index.StateIndex == 19), Id = 19},
                new State(){Name = "Республика Марий-Эл", Cities = cities.FindAll(index => index.StateIndex == 20), Id = 20},
                new State(){Name = "Республика Северная Осетия", Cities = cities.FindAll(index => index.StateIndex == 21), Id = 21},
            };

            States.AddRange(states);
        }
    }
}
