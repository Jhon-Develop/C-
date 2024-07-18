using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_workshop.Models
{
    public class Player(string position, byte tall, byte weight, string actualClub, string skillfulFool)
    {
        public string Position { get; set;} = position;
        public double Tall { get; set;} = tall;
        public double Weight { get; set;} = weight;
        public string ActualClub { get; set;} = actualClub;
        public string SkillfulFool { get; set;} = skillfulFool;

        public double Imc(byte Tall, double weight)
        {
            double ActualImc = weight / (Tall * Tall);

            return ActualImc;
        }
    }
}