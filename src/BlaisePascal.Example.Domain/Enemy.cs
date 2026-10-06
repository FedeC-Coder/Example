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
        // attribuyo costante private
        private const int maxHealth = 100;
        public Enemy() { 
        }
    }
}
