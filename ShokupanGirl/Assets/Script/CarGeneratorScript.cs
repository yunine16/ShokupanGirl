using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGeneratorScript : MonoBehaviour {

    public GameObject car;
    GameObject carGenerator;

    float timeOut;
    float timeElapsed;

	// Use this for initialization
	void Start () {
        timeOut = Random.Range(1.0f, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            Instantiate(car, transform.position, transform.rotation);
            timeElapsed = 0;

            timeOut = Random.Range(1.0f, 5.0f);
        }
	}
}
