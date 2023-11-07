using DG.Tweening;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Jump(Transform transform, Vector3 endValue, float jumpPower, int numJumps, float duration )
        {
            transform.DOJump(endValue, jumpPower, numJumps, duration);
        }
        
        //TODO move 
        //TODO add physics

        public void Move(Transform transform, Vector3 newVector)
        {
            transform.Translate(newVector);
        }
    }
}
