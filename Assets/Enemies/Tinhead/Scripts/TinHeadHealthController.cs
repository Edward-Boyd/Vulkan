using Enemies.Scripts;
using UnityEngine;

namespace Enemies.Tinhead.Scripts
{
    public class TinHeadHealthController : EnemyHealthController
    {
        [SerializeField] private int health;
        public override void TakeDamage(int amount)
        {
            health -= amount;

            if (health <= 0)
            {
                //TODO animations and ect
                Destroy(gameObject);
            }
        }
    }
}