using UnityEngine;
using UnityEngine.InputSystem;
using Weapons;

namespace Player
{
    public class PlayerWeaponController : MonoBehaviour
    {
        public Weapon Weapon;

        public void OnAttack(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Weapon.Fire();
            }
            
        }

        public void OnReload(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Weapon.Reload();  
            }
        }
    }
}