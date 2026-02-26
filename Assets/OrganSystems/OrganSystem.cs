using JetBrains.Annotations;
using Organs;
using Player;
using UnityEngine;
using Utilities;

namespace OrganSystems
{
    public class OrganSystem : MonoBehaviour, IInteractable
    {
        [CanBeNull]
        public Organ organ;
        
        public void Interact(GameObject interactionOrigin)
        {
            throw new System.NotImplementedException();
        }
    }
}