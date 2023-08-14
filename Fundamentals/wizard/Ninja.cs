using System;

namespace wizard
{
    class Ninja : Human
{

    public Ninja(string name):base(name,3,3,175,100)
    {
    }
public override int Attack(Human target){
 Random r = new Random();
            int dmg = 5 * Dexterity;
            if(r.Next(100) <= 20)
                dmg += 10;
            target.health-=dmg;
             Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! ,the health now of the target is {target.health}");
            return target.health;
}
public void Steal(Human target)
        {
            target.health-=5;
            health += 5;
        }
}
}