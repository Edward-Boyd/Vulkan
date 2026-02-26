using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu]
    public class InventorySo : ScriptableObject
    {
        [SerializeField] private List<InventoryItems> itemKeys = new();
        [SerializeField] private List<int> itemAmounts = new();
        
        private Dictionary<InventoryItems, int> _items;

        public int GetInventoryItem(InventoryItems item)
        {
            return _items.GetValueOrDefault(item, 0);
        }

        public void AddInventoryItem(InventoryItems item, int amount)
        {
            _items[item] += amount;
        }

        private void OnEnable()
        {
            _items = new();

            for (int i = 0; i < itemKeys.Count; i++)
            {
                _items.Add(itemKeys[i], itemAmounts[i]);
            }
        }
    }

    public enum InventoryItems
    {
        Nrd,
    }
}