using System;
using System.Collections;
using CollisionSystem;
using Core;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private Camera cameraMain;
        private Game _game;
        private CollisionDetector _collisionDetector;
        public void Construct(Game game, CollisionDetector collisionDetector)
        {
            _game = game;
            _collisionDetector = collisionDetector;
        }
        // Update is called once per frame
        void Update()
        {
            StartCoroutine(InCameraRangeCheck());
        }

        private void OnEnable()
        {
            _collisionDetector.SawCollision += SawDeath;
        }

        private void OnDisable()
        {
            _collisionDetector.SawCollision -= SawDeath;
        }

        private IEnumerator InCameraRangeCheck()
        {
            
            if (cameraMain.transform.position.x - transform.position.x >= 10 && _game.InGame)
            {
                yield return new WaitForSeconds(1f);
                _game.Lose();
            }
                
            
        }

        private void SawDeath()
        {
            _game.Lose();
        }
    }
}
