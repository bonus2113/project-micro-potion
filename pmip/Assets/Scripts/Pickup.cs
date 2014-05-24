using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour 
{
    public void Pick(Transform newParent)
    {
        transform.parent = newParent;
        collider.isTrigger = true;
        rigidbody.velocity = Vector3.zero;
        rigidbody.isKinematic = true;
    }

    public void Throw(Vector3 dir)
    {
        collider.isTrigger = false;
        transform.parent = null;
        rigidbody.isKinematic = false;
        rigidbody.AddForce(dir, ForceMode.Impulse);
    }
}
