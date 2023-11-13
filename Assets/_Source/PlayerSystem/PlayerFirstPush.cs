using System.Collections;
using Core;
using UnityEngine;

namespace PlayerSystem
{
   public class PlayerFirstPush : MonoBehaviour
   {
      private PlayerInvoker _playerInvoker;
      private Game _game;
      public void Construct(PlayerInvoker playerInvoker, Game game)
      {
         _playerInvoker = playerInvoker;
         _game = game;
         StartCoroutine(Push());
      
      }

      private IEnumerator Push()
      {
         _playerInvoker.FirstPush();
         yield return new WaitForSeconds(2f);
         _game.InGame = true;
      }
   }
}
