using System;

namespace Napilnic01
{
    class Program
    {
    }

    class Weapon
    {
        private int _damage;
        private int _bullets;

        public void Fire(Player player)
        {
            player.Damadge(_damage);
            _bullets -= 1;
        }
    }

    class Player
    {
        private int _health;

        public void Damadge(int damadge)
        {
            if (damadge <= 0)
                throw new ArgumentOutOfRangeException();

            _health -= damadge;

            if (_health < 0)
                _health = 0;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
