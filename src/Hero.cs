namespace desafiorpg
{
     public abstract class Hero
     {
          public string Name;
          public int Level;
          public string HeroType;
          public Hero(string name, int level, string heroType)
          {
               Name = name;
               Level = level;
               HeroType = heroType;
          }
          public override string ToString()
          {
               return Name + " " + Level + " " + HeroType;
          }
          public virtual string Attack()
          {
               return Name + " Atacou com a sua espadachim!";
          }
     }
}