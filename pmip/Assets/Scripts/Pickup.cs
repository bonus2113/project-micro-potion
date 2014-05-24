using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour 
{
    public void Pick(Transform newParent)
    {
        transform.parent = newParent;
        rigidbody.velocity = Vector3.zero;
        rigidbody.isKinematic = true;
    }

    public void Throw(Vector3 dir)
    {
        transform.parent = null;
        rigidbody.isKinematic = false;
        rigidbody.AddForce(dir, ForceMode.Impulse);
    }
}
