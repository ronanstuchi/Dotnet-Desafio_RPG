namespace desafiorpg
{
     public class Knight : Hero
     {
          public Knight(string name, int level, string heroType) : base(name, level, heroType)
          {
               Name = name;
               Level = level;
               HeroType = heroType;
          }

           public override string Attack()
          {
               return Name + " Atacou com sua Catana bem afiada!";
          }
     }
    
}