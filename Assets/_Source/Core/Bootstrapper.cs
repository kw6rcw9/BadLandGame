using System;
using InputSystem;
using PlayerSystem;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerController playerController;
        [SerializeField] private InputListener inputListener;
        private void Awake()
        {
            playerController.Construct();
            inputListener.Construct(playerController);
        }
    }
}
