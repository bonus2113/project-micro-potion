using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    AudioClip m_Poem;

	// Use this for initialization
	void Start () {

        AudioSource.PlayClipAtPoint(m_Poem, Camera.main.transform.position);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
