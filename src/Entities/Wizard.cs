namespace dotnet_poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)//método construtor
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou magia.";
        }

        public string Attack(int Bonus) //polimorfismo e sobrecarga
        {

            if(Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma magia fraca com bônus de " + Bonus;
            }
            
        }
    }
}