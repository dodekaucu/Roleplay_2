namespace RoleplayGame
{
    public class Archer
    {
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Helmet.DefenseValue;
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