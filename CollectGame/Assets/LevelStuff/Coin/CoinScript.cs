using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    //CoinAmount
    public static int CoinCount = 0;

	// Use this for initialization
	void Start () {

        ++CoinScript.CoinCount;
		
	}

    void OnTriggerEnter(Collider Col)
    {
        if (Col.CompareTag("Player"))
            Destroy(gameObject);
    }

    void OnDestroy()
    {
        --CoinScript.CoinCount;

        if(CoinCount <= 0)
        {
            //victory
            //Destroy timer and launch fireworks
            GameObject Timer = GameObject.Find("LevelTimer");
            Destroy(Timer);

            GameObject[] FireworkSystems = GameObject.FindGameObjectsWithTag("Firework");
            foreach (GameObject GO in FireworkSystems)
            {
                GO.GetComponent<ParticleSystem>().Play();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
