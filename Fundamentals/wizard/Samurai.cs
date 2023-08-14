using System;

namespace wizard
{
class Samurai : Human
{

    public Samurai(string name):base(name,3,3,3,200)
    {
    }
    public override int Attack(Human target){
        int remainingHealth=Attack(target);
        if(remainingHealth<50){
            target.health=0;
        }
        return remainingHealth;
    }
     public void Meditate()
        {
            health = 200;
        }

}
}