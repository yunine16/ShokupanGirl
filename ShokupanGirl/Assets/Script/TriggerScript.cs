using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    //public GameObject Stopper;

    DrivingCar drivingCar;
    //GameObject car;

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
        waTrafficScript = trafficLight.GetComponent<waTrafficScript>();
        bool red = waTrafficScript.red;

        //Debug.Log("aaa");

        if (col.gameObject.tag == "FrontBox")
        {
            //Debug.Log(col.transform.root);
            drivingCar = col.transform.root.GetComponent<DrivingCar>();

            if (red)
            {
                drivingCar.StopCar();
            }
            else
            {
                drivingCar.StartCar();
            }

        }
    }


}
