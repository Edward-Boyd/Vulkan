using UnityEngine;
using UnityEngine.InputSystem;
using Utilities;

namespace Player
{
    public class PlayerInteractController : MonoBehaviour
    {
        public float interactionDistance = 3f;
        public Camera playerCamera;
        private IInteractable _currentInteractable;

        void Update()
        {
            Ray ray = playerCamera.ViewportPointToRay(new (0.5f, 0.5f, 0f));

            if (Physics.Raycast(ray, out var hit, interactionDistance))
            {
                if (hit.collider.TryGetComponent(out _currentInteractable))
                {
                    // Optional: Display UI prompt (e.g., "Press E to open")
                }
                else
                {
                    _currentInteractable = null;
                }
            }
            else
            {
                _currentInteractable = null;
            }
        }
        
        public void OnInteract(InputAction.CallbackContext context)
        {
            if (context.performed && _currentInteractable != null)
            {
                _currentInteractable.Interact(gameObject);
            }
        }
    }
}