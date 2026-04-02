using UnityEngine;
using Utilities;

namespace Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        internal int Clip;
        internal int Ammo;
        internal IDamageable CurrentHit;
        internal bool Reloading;

        public abstract void Fire();
        
        public abstract bool IsClipEmpty();

        public abstract void Reload();
    }
}