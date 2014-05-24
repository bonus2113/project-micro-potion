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
        if (angle * 2 < MaxAngle && playerDir.magnitude < 10)
        {
            player.IsSeen = true;
            
        }
    }
}
