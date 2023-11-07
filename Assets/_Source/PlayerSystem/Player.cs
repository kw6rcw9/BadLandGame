using System;
using UnityEngine;


namespace PlayerSystem
{
   [RequireComponent(typeof(Rigidbody2D))]
    public class Player: MonoBehaviour
    {
        [field: SerializeField] public float MoveSpeed { get; private set; }

        [field: SerializeField] public float JumpForce { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }
        
        [field: SerializeField] public Rigidbody2D Rb { get; private set; }
        
       
    }
}
