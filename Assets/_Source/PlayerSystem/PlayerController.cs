using System;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float jumpPower;
         private Vector3 endPosition;
        [SerializeField] private int jumpsCount;
        [SerializeField] private float jumpDuration;
        [SerializeField] private float moveSpeed;
        private PlayerModel _player;
        private PlayerMovement _playerMovement;
        public void Construct()
        {
            _player = new PlayerModel(moveSpeed, jumpPower, endPosition, jumpsCount, jumpDuration);
            _playerMovement = new PlayerMovement();
        }

        private void FixedUpdate()
        {
            endPosition = transform.position;
        }

        private void Update()
        {
            _playerMovement.Move(transform, new Vector3(1 * moveSpeed * Time.deltaTime, 0, 0));
        }

        public void Jump()
        {
            _playerMovement.Jump(transform, endPosition, jumpPower, jumpsCount, jumpDuration);
        }
    }
}
