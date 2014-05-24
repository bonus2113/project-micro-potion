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
        Debug.Log(IsSeen);
        IsSeen = false;
    }
}
