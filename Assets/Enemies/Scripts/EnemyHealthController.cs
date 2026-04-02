using UnityEngine;
using Utilities;

namespace Enemies.Scripts
{
    public abstract class EnemyHealthController : MonoBehaviour, IDamageable
    { 
        public abstract void TakeDamage(int amount);
    }
}