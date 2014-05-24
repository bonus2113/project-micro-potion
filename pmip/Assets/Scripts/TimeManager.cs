using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

    private float m_InternalTimer = 0.0f;
    private const float TimeToFamilyReturn = 60.0f;

    public UISprite m_TimerSprite = null;


    public float NormalisedTimeToParentReturn
    {
        get
        {
            return this.m_InternalTimer / TimeToFamilyReturn;
        }
    }


	// Use this for initialization
	void Start () {

        this.m_TimerSprite.fillAmount = 0.0f;
        this.m_TimerSprite.fillDirection = UISprite.FillDirection.Radial360;

	}
	
	// Update is called once per frame
	void Update () {

        this.m_InternalTimer += Time.deltaTime;

        this.m_TimerSprite.fillDirection = UISprite.FillDirection.Radial360;
        this.m_TimerSprite.fillAmount = NormalisedTimeToParentReturn;

        if (this.m_InternalTimer > TimeToFamilyReturn)
        {
            Lose();
        }
	}

    private void Lose()
    {
        Debug.Log("Lose!");
        Application.LoadLevel(0);
    }
}
