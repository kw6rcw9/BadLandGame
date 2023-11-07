using System;
using UnityEngine;

namespace CollisionSystem
{
    public class CollisionDetector : MonoBehaviour
    {
        [SerializeField] private int groundLayerNum;
        public event Action GroundCollisionEnter;
        public event Action GroundCollisionExit;

        private void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionEnter?.Invoke();
        }
        private void OnCollisionExit2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionExit?.Invoke();
        }
    }
}
