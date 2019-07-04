using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionController : MonoBehaviour {

    EnemyScript enemyScript;
    float speed;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "IntersectionArea")
        {
            //speed = .GetComponent<EnemyScript>().speed;
            speed = speed * 10f;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "IntersectionArea")
        {
            speed = speed / 10f;

        }
    }
}
