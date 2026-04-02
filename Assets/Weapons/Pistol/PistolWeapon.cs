using System;
using UnityEngine;
using Utilities;

namespace Weapons.Pistol
{
    public class Pistol : Weapon
    {
        
        [SerializeField] private Camera playerCamera;

        [SerializeField] private int damage;
        [SerializeField] private int clipSize;
        [SerializeField] private int maxAmmo;
        [SerializeField] private int projectiles;
        [SerializeField] private float spread;
        [SerializeField] private float effectiveWeaponRange;

        private void OnEnable()
        {
            Clip = clipSize;
            Ammo = maxAmmo;
        }

        public override void Fire()
        {
            if (Clip <= 0)
            {
                //TODO sounds/animation out of ammo
                return;
            }
            
            Clip = Math.Clamp(Clip - 1, 0, clipSize);
            Debug.Log($"{Clip} in clip, {Ammo} ammo left");
            
            for (int i = 0; i < projectiles; i++)
            {
                Ray ray = playerCamera.ViewportPointToRay(new (0.5f, 0.5f, 0f)); //TODO spread here as vector

                if (!Physics.Raycast(ray, out var hit, effectiveWeaponRange)) continue;
                
                if (hit.collider.TryGetComponent(out IDamageable currentHit))
                {
                    currentHit.TakeDamage(damage);
                }

            }
        }
        public override bool IsClipEmpty()
        {
            return Clip <= 0;
        }
        public override void Reload()
        {
            if (Reloading) return;

            Reloading = true;
            
            int clipDeficit = clipSize - Clip;

            if (clipDeficit > Ammo) //TODO do this with math
            {
                Clip += Ammo;
            }
            else
            {
                Clip += clipDeficit;
            }
          
            Ammo = Math.Clamp(Ammo - clipDeficit, 0, 100);

            Reloading = false;
        }
    }
}