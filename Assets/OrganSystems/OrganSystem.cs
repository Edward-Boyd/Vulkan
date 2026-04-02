using JetBrains.Annotations;
using Organs;
using Unity.Serialization;
using UnityEngine;
using Utilities;

namespace OrganSystems
{
    public class OrganSystem : MonoBehaviour, IInteractable
    {
        [CanBeNull][DontSerialize]
        public Organ organ;

        [SerializeField]
        private GameObject organInstance;
        
        public void Interact(GameObject interactionOrigin)
        {
            if (organ != null) return;

            Instantiate(organInstance, transform.position, transform.rotation);
        }
    }
}