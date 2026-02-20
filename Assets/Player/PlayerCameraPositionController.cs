using System;
using UnityEngine;

namespace Player
{
    public class PlayerCameraPositionController : MonoBehaviour
    {
        public Transform camaraPosition;

        private void Update()
        {
            transform.position = camaraPosition.position;
        }
    }
}