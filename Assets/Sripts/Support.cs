using System;
using UnityEngine;
using UnityEngine.Events;

public class Support : MonoBehaviour
{
    public event Action StopperTouched;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent<Stopper>(out _))
        {
            StopperTouched?.Invoke();
        }
    }
}
