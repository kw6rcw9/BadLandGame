using System;
using CollisionSystem;
using InputSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Player player;
        [SerializeField] private CollisionDetector collisionDetector;
        private PlayerInvoker _playerInvoker;
        private PlayerMovement _playerMovement;
        private PlayerInput _playerInput;
        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerMovement = new PlayerMovement();
            _playerInvoker = new PlayerInvoker(player,_playerMovement );
            inputListener.Construct(player, _playerInvoker, _playerInput, collisionDetector);
            
        }
    }
}
