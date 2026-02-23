using UnityEngine.InputSystem;

namespace Utilities
{
    public interface IInteractable
    {
        public void OnInteract(InputAction.CallbackContext context);
    }
}