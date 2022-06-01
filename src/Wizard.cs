using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafiorpg
{
     public class Wizard : Hero
     {
          public Wizard(string Name, int Level, string heroType) : base(Name, Level, heroType)
          {
               this.Name = Name;
               this.Level = Level;
               this.HeroType = heroType;
          }

          public override string Attack()
          {
               return Name + " Atacou com sua magia, sem tecnologia!!";
          }
     }
}