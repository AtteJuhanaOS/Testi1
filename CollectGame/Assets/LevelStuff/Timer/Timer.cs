using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    //LevelTime
    public float MaxTime = 60f;

    [SerializeField]
    private float CountDown = 0;

	// Use this for initialization
	void Start () {

        CountDown = MaxTime;
		
	}
	
	// Update is called once per frame
	void Update () {

        CountDown -= Time.deltaTime;

        //Restart level if time runs out
        if(CountDown <= 0)
        {
            //Reset coin count
            CoinScript.CoinCount = 0;
            SceneManager.LoadScene("SampleScene");
        }
		
	}
}
