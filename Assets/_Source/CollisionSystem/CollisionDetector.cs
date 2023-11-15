using System;
using UnityEngine;

namespace CollisionSystem
{
    public class CollisionDetector : MonoBehaviour
    {
        [SerializeField] private int groundLayerNum;
        [SerializeField] private int sawLayerNum;
        public event Action GroundCollisionEnter;
        public event Action GroundCollisionExit;
        public event Action SawCollision;

        private void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionEnter?.Invoke();
            if(col.gameObject.layer == sawLayerNum)
                SawCollision?.Invoke();
        }
        private void OnCollisionExit2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionExit?.Invoke();
        }
    }
}
