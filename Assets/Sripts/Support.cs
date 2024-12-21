using System;
using UnityEngine;

public class Support : MonoBehaviour
{
    public event Action StopperTouched;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("������� ���� ��������");
        if (collision.collider.TryGetComponent<Stopper>(out _))
        {
            Debug.Log("��������� ��������");
            StopperTouched?.Invoke();
        }
    }
}
