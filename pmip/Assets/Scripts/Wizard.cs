using UnityEngine;
using System.Collections;

public class Wizard : MonoBehaviour
{
    public float MaxAngle = 60;
    private Player player;

    void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        Vector3 playerDir = player.transform.position - transform.position;

        float angle = Vector3.Angle(playerDir, transform.forward);
        Debug.Log(angle < MaxAngle);
        if (angle * 2 < MaxAngle)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                player.IsSeen = hit.collider.gameObject.layer == LayerMask.NameToLayer("Player"); ;
            }
        }
    }
}
