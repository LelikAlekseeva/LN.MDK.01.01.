using System;
using System.Collections.Generic;
using System.Linq;


namespace LR2_new
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();///"аппетитные игры"

            Team team1 = new Team();
            team1.Name = "Овощи";
            team1.Points = 1;
            team1.Players = new List<Player>
            {
                new Player { Name = "Пупкин", Goals = 8 },
                new Player { Name = "Петров", Goals = 5 },
                new Player { Name = "Сидоров", Goals = 3 },
                new Player { Name = "Козлов", Goals = 1 }
            };
            teams.Add(team1);

            Team team2 = new Team();
            team1.Name = "Урожай";
            team1.Points = 100;
            team1.Players = new List<Player>
            {
                new Player { Name = "Смирнов", Goals = 10 },
                new Player { Name = "Васильев", Goals=4 },
                new Player { Name = "Николаев", Goals=2 },
                new Player { Name = "Орлов", Goals=1 }
            };
            teams.Add(team2);

            Team team3 = new Team();
            team1.Name = "Фрукты";
            team1.Points = 50;
            team1.Players = new List<Player>
            {
                new Player { Name = "Зенченко", Goals = 1 },
                new Player { Name = "Воскресенский", Goals= 7},
                new Player { Name = "Алексеева", Goals=1},
                new Player { Name = "Гавриш", Goals=3 }
            };
            teams.Add(team3);

            Team team4 = new Team();
            team1.Name = "Зелень";
            team1.Points = 25;
            team1.Players = new List<Player>
            {
                new Player { Name = "Курочкин", Goals = 10 },
                new Player { Name = "Голубев", Goals= 10},
                new Player { Name = "Педалькин", Goals=1},
                new Player { Name = "Шмелёв", Goals=4 }
            };
            teams.Add(team4);

            Team team5 = new Team();
            team1.Name = "Мясо";
            team1.Points = 30;
            team1.Players = new List<Player>
            {
                new Player { Name = "Долматов", Goals = 10 },
                new Player { Name = "Пирогов", Goals= 10},
                new Player { Name = "Кукушкин", Goals=1},
                new Player { Name = "Пчёлкин", Goals=4 }
            };
            teams.Add(team5);

            Team team6 = new Team();
            team1.Name = "Снеки";
            team1.Points = 40;
            team1.Players = new List<Player>
            {
                new Player { Name = "Попандуполо", Goals = 10 },
                new Player { Name = "Федосеев", Goals= 10},
                new Player { Name = "Федотов", Goals=1},
                new Player { Name = "Федоткин", Goals=4 }
            };
            teams.Add(team6);
        }
    }
}
