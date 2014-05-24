using UnityEngine;

public class ThrowStuff : MonoBehaviour
{
    public GameObject CrossHair;
    public KeyCode ThrowKey;
    public GameObject ObjectToThrow;
    public float ThrowStrength = 10;
	
	void Update () 
    {
	    if (Input.GetMouseButtonDown(0))
	    {
	        if (ObjectToThrow == null)
	        {
	            PickObject();
	        }
	        else
	        {
                ThrowObject();
	        }
	    }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3))
        {
            CrossHair.transform.position = hit.point;
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Pickup"))
            {
                CrossHair.renderer.material.color = Color.green;
            }
            else
            {
                CrossHair.renderer.material.color = Color.red;
            }
        }
        else
        {
            CrossHair.renderer.material.color = Color.red;
        }
	}

    void PickObject()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3, 1 << LayerMask.NameToLayer("Pickup")))
        {
            ObjectToThrow = hit.collider.gameObject;
            ObjectToThrow.GetComponent<Pickup>().Pick(Camera.main.transform);
        }
    }

    void ThrowObject()
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));

        ObjectToThrow.GetComponent<Pickup>().Throw(ray.direction * ThrowStrength);
        ObjectToThrow = null;
    }
}
