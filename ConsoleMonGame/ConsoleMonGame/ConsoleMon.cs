﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
   
        internal int energy;

        internal string name;

        internal void damage(int damage)
        {
             health = health - damage;
        }

        internal void DepleteEnergy(int energy)
        {
           this.energy -= energy;
        }

        private List<Skill> skills = new List<Skill>();

    }

}
