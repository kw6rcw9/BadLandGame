using System.Collections;
using Core;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerLateCamera : MonoBehaviour
    {
        [SerializeField] private Camera cameraMain;
        private Game _game;
        public void Construct(Game game)
        {
            _game = game;
        }
        // Update is called once per frame
        void Update()
        {
            StartCoroutine(InCameraRangeCheck());
        }

        private IEnumerator InCameraRangeCheck()
        {
            
            if (cameraMain.transform.position.x - transform.position.x >= 10 && _game.InGame)
            {
                yield return new WaitForSeconds(1f);
                _game.Lose();
            }
                
            
        }
    }
}
