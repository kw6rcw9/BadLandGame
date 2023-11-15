using System;
using System.Collections;
using System.Collections.Generic;
using CollisionSystem;
using UnityEngine;

public class TriggerObs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private CollisionDetector _collisionDetector;
    public void Construct(CollisionDetector collisionDetector)
    {
        _collisionDetector = collisionDetector;
        _collisionDetector.TriggerZoneEnter += GravityOff;
        rb.gravityScale = 0;
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        _collisionDetector.TriggerZoneEnter -= GravityOff;
    }

    private void GravityOff()
    {
        StartCoroutine(GravityOffTime());
    }

    IEnumerator GravityOffTime()
    {
        yield return new WaitForSeconds(1f);
        rb.gravityScale = 1;
    }
}
