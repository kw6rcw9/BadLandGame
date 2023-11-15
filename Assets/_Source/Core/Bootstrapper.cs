using System;
using CollisionSystem;
using InputSystem;
using PlayerSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Player player;
        [SerializeField] private CollisionDetector collisionDetector;
         [SerializeField] private PlayerDeath playerDeath;
        [SerializeField] private PlayerFirstPush playerFirstPush;
        private PlayerInvoker _playerInvoker;
        private PlayerMovement _playerMovement;
        private PlayerInput _playerInput;
        private Game _game;
        private void Awake()
        {
            _game = new Game();
            _playerInput = new PlayerInput();
            _playerMovement = new PlayerMovement();
            _playerInvoker = new PlayerInvoker(player,_playerMovement );
            inputListener.Construct(player, _playerInvoker, _playerInput, collisionDetector);
            playerFirstPush.Construct(_playerInvoker, _game);
            playerDeath.Construct(_game, collisionDetector);
            
        }
    }
}
