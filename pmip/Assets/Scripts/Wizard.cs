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

        if (angle < MaxAngle)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, float.PositiveInfinity, 1 << LayerMask.NameToLayer("Player")))
            {
                player.IsSeen = true;
            }
        }
    }
}
