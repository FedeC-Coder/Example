namespace BlaisePascal.Example.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        /// private         modificatore di accessibilità
        /// int             tipo
        /// health          definizione variabile
        private int _health;
        // int Health { get; private set; }

        // proprietà
        //public int Health
        //{
        //    get { return _health; }
        //    set {
        //        if (value < 0)
        //        {
        //            _health = 0;
        //        }
        //        else if (value > maxHealth)
        //        {
        //            _health = 100;
        //        }
        //        else
        //        {
        //            _health = value;
        //        }
        //    }
        //}

        // attributo costante private
        private const int maxHealth = 100;
        public Enemy() { 
        }

        public int SetHealt(int newHealth) {
            if (newHealth < 0)
            {
                _health = 0;
            }
            else if (newHealth > maxHealth)
            {
                _health = maxHealth;
            }
            else {
                _health = newHealth;
            }
            return _health;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public void TakeDamage(int damage) {
            if (damage>=0)
            {
                SetHealt(_health - damage);
            }
        }
    }
}
