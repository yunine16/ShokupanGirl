using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    //public GameObject Stopper;

    DrivingCar drivingCar;
    //(GameObject car;

    waTrafficScript waTrafficScript;
    GameObject trafficLight;

    public bool stop;

    // Use this for initialization
    void Start () {
        trafficLight = GameObject.Find("TrafficLight");
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerStay(Collider col)
    {
        //car = GameObject.FindWithTag("Cars");

        drivingCar = col.GetComponent<DrivingCar>();

        if (col.gameObject.tag == "Cars")
        {
            waTrafficScript = trafficLight.GetComponent<waTrafficScript>();
            bool red = waTrafficScript.red;

            if (red)
            {
                float speedCar = drivingCar.speedNow;
                stop = true;
                drivingCar.StopCar(stop);
            }
            else
            {
                drivingCar.StartCar();
            }
            
        }
    }
}
