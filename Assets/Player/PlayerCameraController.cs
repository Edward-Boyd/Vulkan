using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerCameraController : MonoBehaviour
    {
        public float sensitivity;
        public float verticalLookLimit;

        public Transform orientation;

        private float _xRotation;
        private float _yRotation;

        private Vector2 _lookInput;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            /*float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xSensitivity;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * ySensitivity;

            _yRotation += mouseX;
            _xRotation += mouseY;

            _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
            
            transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, _yRotation, 0);*/
        }


        public void OnLook(InputAction.CallbackContext context)
        {
            //orientation.Rotate(Vector3.up * _lookInput.x * sensitivity);
            
            _lookInput = context.ReadValue<Vector2>();

            _xRotation -= _lookInput.y * sensitivity;
            _yRotation -= _lookInput.x * sensitivity;
            _xRotation = Mathf.Clamp(_xRotation, -verticalLookLimit, verticalLookLimit);

            transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, _yRotation, 0);
        }
    }
}