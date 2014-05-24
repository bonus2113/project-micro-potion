using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float WPS = 0.1f;
    public float WankAmount { get; private set; }
    public bool IsSeen = false;

    void LateUpdate()
    {
        if (!IsSeen)
        {
            WankAmount += WPS*Time.deltaTime;
        }
        WankAmount = Mathf.Clamp01(WankAmount);
        if (WankAmount == 1)
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, 20);
            foreach (Collider hit in colliders)
            {
                if (hit && hit.rigidbody)
                    hit.rigidbody.AddExplosionForce(20, explosionPos, 20, 3.0F);
            }
        }
        IsSeen = false;
    }
}
