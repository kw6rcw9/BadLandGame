using UnityEngine;

namespace PlayerSystem
{
    public class PlayerInvoker
    {
        private PlayerMovement _playerMovement;
        private Player _player;
        public PlayerInvoker(Player player, PlayerMovement playerMovement)
        {
            _player = player;
            _playerMovement = playerMovement;
        }
        public void Move(float axisInput)
        {
            _playerMovement.Move(_player.Rb, _player.MoveSpeed, axisInput);
        }

        public void Jump()
        {
            _playerMovement.Jump(_player.Rb, _player.JumpForce);
        }

        public void Rotate(float axisInput)
        {
            _playerMovement.Rotate(_player.Rb, _player.RotationSpeed, _player.transform,new Vector2(axisInput, 0) );
        }
        
    }
}
