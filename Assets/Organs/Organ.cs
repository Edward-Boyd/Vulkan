using Inventory;
using Player;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Utilities;

namespace Organs
{
    public class Organ : MonoBehaviour, IInteractable, IDamageable
    {
        //TODO make SO
        public int fuel; //NRD amount?
        public int health;
        public int productionAmount;
        public float craftingTime;
        public bool isCraftingComplete;


        private float _craftingTimer;
        private void Update()
        {
            if (isCraftingComplete) return;
            
            _craftingTimer -= Time.deltaTime;

            if (_craftingTimer <= 0f)
            {
                isCraftingComplete = true;
                _craftingTimer = craftingTime;
            }
        }

        public void Interact(GameObject interactionOrigin)
        {
            if (isCraftingComplete)
            {
                interactionOrigin.GetComponent<PlayerInventory>().inventory.AddInventoryItem(InventoryItems.Nrd, productionAmount);
                isCraftingComplete = false;
                
                Debug.Log( interactionOrigin.GetComponent<PlayerInventory>().inventory.GetInventoryItem(InventoryItems.Nrd));
            }
        }
        
        public void TakeDamage(int amount)
        {
            health -= amount;

            if (health <= 0)
            {
                //TODO destory
            }
        }
    }
}