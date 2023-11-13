using System;
using CollisionSystem;
using PlayerSystem;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        private Player _player;
        private PlayerInvoker _playerInvoker;
        private PlayerInput _playerInput;
        private float _moveInput;
        private CollisionDetector _collisionDetector;
        public void Construct(Player player, PlayerInvoker playerInvoker,
            PlayerInput playerInput, CollisionDetector collisionDetector)
        {
            _player = player;
            _playerInvoker = playerInvoker;
            _playerInput = playerInput;
            _collisionDetector = collisionDetector;
            Debug.Log(_playerInput);
        }

        private void Start()
        {
            Debug.Log("OnEnable: " + _playerInput);
            _playerInput.Enable();
            _playerInput.Main.Jump.performed += context => ReadJump();
            _collisionDetector.GroundCollisionEnter += () => _playerInput.Main.Move.Disable();
            _collisionDetector.GroundCollisionExit += () => _playerInput.Main.Move.Enable();
            
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
            _playerInput.Disable();
        }

        private void Update()
        {
            
            ReadMove();
           
        }

     
        private void ReadJump()
        {
            
                Debug.Log("Jump");
                _playerInvoker.Jump();
            
        }

       

        private void ReadMove()
        {
            _moveInput = _playerInput.Main.Move.ReadValue<float>();
            _playerInvoker.Move(_moveInput);
            _playerInvoker.Rotate(_moveInput);
        }

       
    }
}
