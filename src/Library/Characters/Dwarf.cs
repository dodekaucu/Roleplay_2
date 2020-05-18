namespace RoleplayGame
{
    public class Dwarf
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            this.Health -= this.DefenseValue >= power ? 0 : power - this.DefenseValue;
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}