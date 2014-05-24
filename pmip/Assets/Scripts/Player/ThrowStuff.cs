using UnityEngine;
using System.Collections;

public class ThrowStuff : MonoBehaviour
{
    public KeyCode ThrowKey;
    public GameObject ObjectPrefab;
    public float ThrowStrength = 10;
	
	void Update () 
    {
	    if (Input.GetMouseButtonDown(0))
	    {
	        ThrowObject();
	    }
	}

    void ThrowObject()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));

        var obj = (GameObject) GameObject.Instantiate(ObjectPrefab);
        obj.transform.position = ray.origin;
        obj.rigidbody.AddForce(ray.direction * ThrowStrength, ForceMode.Impulse);
    }
}
