using System;
using UnityEngine;

namespace CollisionSystem
{
    public class CollisionDetector : MonoBehaviour
    {
        [SerializeField] private int groundLayerNum;
        [SerializeField] private int sawLayerNum;
        [SerializeField] private int dangerObsLayerNum;
        [SerializeField] private int triggerLayerNum;
        public event Action GroundCollisionEnter;
        public event Action GroundCollisionExit;
        public event Action SawCollision;
        public event Action DangerObsCollision;
        public event Action TriggerZoneEnter;

        private void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionEnter?.Invoke();
            if(col.gameObject.layer == sawLayerNum)
                SawCollision?.Invoke();
            if(col.gameObject.layer == dangerObsLayerNum)
                DangerObsCollision?.Invoke();
        }
        private void OnCollisionExit2D(Collision2D col)
        {
            if(col.gameObject.layer == groundLayerNum)
                GroundCollisionExit?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if(col.gameObject.layer == triggerLayerNum)
                TriggerZoneEnter?.Invoke();
                
        }
    }
}
