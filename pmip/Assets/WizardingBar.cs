using UnityEngine;
using System.Collections;

public class WizardingBar : MonoBehaviour
{
    private Player player;
    private UISlider slider;
    public UILabel wizardingLabel;
	// Use this for initialization
	void Awake ()
	{
	    player = FindObjectOfType<Player>();
	    slider = GetComponent<UISlider>();
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
	    wizardingLabel.enabled = !player.IsSeen;
	    Debug.Log(player.WankAmount);
	    slider.value = player.WankAmount;
	}
}
