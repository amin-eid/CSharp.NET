using System;

namespace wizard
{
class Wizard : Human
{

    public Wizard(string name):base( name,3,25,3,50)
    {
    }

    public override int  Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.health -= dmg;
        health+=dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.health;
    }

public void Heal(Human target)
        {
            int heal = 10 * Intelligence;    
            target.Health += heal;
        }

}
}