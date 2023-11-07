using System;
using PlayerSystem;
using UnityEngine;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _playerController;
        public void Construct(PlayerController playerController)
        {
            _playerController = playerController;
        }

        private void Update()
        {
            ReadJump();
        }

        private void ReadJump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Jump");
                _playerController.Jump();
            }
        }
    }
}
