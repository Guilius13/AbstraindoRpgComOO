namespace dotnet_poo.src.Entities
{
    public abstract class Hero //clase abstrata não se pode herdar, é uma classe mãe, utilizada por outras classes.
    {
        public Hero(string Name, int level, string HeroType) // ctor ou construtor
        {
            this.Name = Name; // o this indica que a proriedade Name é a propriedade Name da própria classe a que se refere o construtor. Por tanto, a propriedade Name desta classe vai receber um parâmetro Name informado no chamamento do método.
            this.level = level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }
        public string Name;
        public int level;
        public string HeroType; 

        public override string ToString()
        {
            return this.Name + " " + this.level + " " + this.HeroType;
        }

        public virtual string Attack() // virtual: eu permito que qualquer filho meu modifique este comportamento meu.
        {
            return this.Name + " atacou com a sua espada.";
        }
    }
}