using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMoveController : MonoBehaviour
    {
        public CharacterController controller;
        public CinemachineCamera cameraPosition;
        
        [SerializeField] private float speed = 5f;
        [SerializeField] private float jumpHeight = 2f;
        [SerializeField] private float gravity = -9.8f;
        

        private Vector2 _moveInput;
        private Vector3 _moveDirection;
        
        //TODO move
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            switch (controller.isGrounded)
            {
                case true:
                    _moveDirection = _moveInput.x * cameraPosition.transform.right + _moveInput.y * cameraPosition.transform.forward;
                    break;
                case false:
                    _moveDirection.y += gravity * Time.deltaTime;
                    break;
            }
            
            controller.Move(_moveDirection * (speed * Time.deltaTime));
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _moveInput = context.ReadValue<Vector2>();
        }

        public void OnJump(InputAction.CallbackContext context)
        {
        }
    }
}