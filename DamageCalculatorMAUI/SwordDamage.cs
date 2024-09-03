namespace DamageCalculator
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        
        public int Damage {  get; private set; }

        private int _roll;
        private bool _flaming;
        private bool _magic;

        public SwordDamage()
        {
            CalculateDamage();
        }

        public bool Flaming
        {
            get => _flaming;
            set
            {
                _flaming = value;
                CalculateDamage();
            }
        }

        public bool Magic
        {
            get => _magic;
            set
            {
                _magic = value;
                CalculateDamage();
            }
        }

        public int Roll
        {
            get => _roll; set
            {
                _roll = value;
                CalculateDamage();
            }
        }   

        private void CalculateDamage()
        {
            decimal dmg = Roll;

            if (_magic) {
                dmg *= 1.75M;
            }

            if (_flaming)
            {
                dmg += FLAME_DAMAGE;
            }

            Damage = (int)dmg + BASE_DAMAGE;
        }
  
    }
}
