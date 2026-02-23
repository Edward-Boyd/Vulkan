using JetBrains.Annotations;
using Organs;
using UnityEngine;
using UnityEngine.InputSystem;
using Utilities;

namespace OrganSystems
{
    public class OrganSystem : MonoBehaviour, IInteractable
    {
        [CanBeNull]
        public Organ organ;
        
        public void OnInteract(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}