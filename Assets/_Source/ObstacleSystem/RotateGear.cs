using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace ObstacleSystem
{
    public class RotateGear : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Vector3 vectorToRotate;


        private void Update()
        {
            transform.Rotate(vectorToRotate * Time.deltaTime * speed);



        }
    }
}
