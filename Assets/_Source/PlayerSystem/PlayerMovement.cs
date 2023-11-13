using System.Numerics;
using DG.Tweening;
using TMPro.EditorUtilities;
using Unity.Mathematics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;

namespace PlayerSystem
{
    public class PlayerMovement
    {
       
        public void Jump(Rigidbody2D rb, float jumpForce)
        {
            rb.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);

        }
        
        //TODO move 
        //TODO add physics

        public void Move(Rigidbody2D rb, float moveSpeed, float axisInput)
        {
            
            
            rb.AddForce(new Vector2(axisInput * moveSpeed * Time.deltaTime, 0), ForceMode2D.Impulse);
            
        }

        public void Rotate(Rigidbody2D rb, float rotationSpeed, Transform transform, Vector2 axisInput)
        {
           
            if (axisInput != Vector2.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(transform.forward, axisInput);
                Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                rb.MoveRotation(rotation);
            }
                
        }

        public void FirstPush(Rigidbody2D rb, float speed, Vector2 distance)
        {
            rb.DOMove(distance, speed);



        }
    }
}
