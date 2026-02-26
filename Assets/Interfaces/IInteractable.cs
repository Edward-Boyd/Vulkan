using Player;
using UnityEngine;

namespace Utilities
{
    public interface IInteractable
    {
        public void Interact(GameObject interactionOrigin);
    }
}