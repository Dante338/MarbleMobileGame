using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Movement ball = other.gameObject.GetComponentInParent<Movement>(); 
        if (ball)
        {
            ball.Reset(); 
        }
    }
}
