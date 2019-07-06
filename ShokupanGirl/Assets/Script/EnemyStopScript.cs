using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStopScript : MonoBehaviour {

    waTrafficPScript waTrafficPScript;
    GameObject trafficLightP;

    EnemyScript enemyScript;

    // Use this for initialization
    void Start () {
        trafficLightP = GameObject.Find("TrafficLightP");
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void OnTriggerStay(Collider other)
    {
        enemyScript = other.GetComponent<EnemyScript>();

        if (other.gameObject.tag == "Enemy")
        {
            waTrafficPScript = trafficLightP.GetComponent<waTrafficPScript>();
            bool redP = waTrafficPScript.redP;

            if (redP)
            {
                enemyScript.StopEnemy();
            }
            else
            {
                enemyScript.UsualEnemy();
            }
        }
    }
}
