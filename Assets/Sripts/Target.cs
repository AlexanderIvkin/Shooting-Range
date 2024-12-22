using UnityEngine;

[SelectionBase]
[RequireComponent(typeof(Rigidbody))]
public class Target : MonoBehaviour
{
    [SerializeField] private Support _support;
    private Rigidbody _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _support.StopperTouched += ActivateKinematic;
    }

    private void OnDisable()
    {
        _support.StopperTouched -= ActivateKinematic;
    }

    public void ActivateKinematic()
    {
        _rigidbody.isKinematic = true;
    }

    private void DeactivateKinematic()
    {
        _rigidbody.isKinematic = false;
    }
}
