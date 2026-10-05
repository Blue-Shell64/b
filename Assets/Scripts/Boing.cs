using UnityEngine;

public class Boing : MonoBehaviour
{
    public float springForce = 1000f;
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.up * springForce);
    }
}
