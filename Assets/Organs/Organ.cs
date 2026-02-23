using UnityEngine;
using UnityEngine.InputSystem;
using Utilities;

namespace Organs
{
    public class Organ : MonoBehaviour, IInteractable, IDamageable
    {

        public int fuel; //NRD amount?
        public int health;
        public int progress;
        public bool isCraftingComplete;
        
        
        public void OnInteract(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        public void TakeDamage(int amount)
        {
            throw new System.NotImplementedException();
        }
    }
}