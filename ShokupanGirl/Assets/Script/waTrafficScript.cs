using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waTrafficScript : MonoBehaviour
{


    Light greenLight, yellowLight, redLight;

    public float greenTime, yellowTime, redTime;
    public bool beginInRed;


    float cTime, allTime;


    //車停止用
    GameObject Car;
    public DrivingCar drivingCar;



    // Use this for initialization
    void Start()
    {
        //車
        Car = GameObject.Find("Car").gameObject;
        drivingCar = Car.GetComponent<DrivingCar>();


        greenLight = gameObject.transform.Find("TLightGroupG").gameObject.transform.Find("PointLightG").gameObject.GetComponent<Light>();
        yellowLight = gameObject.transform.Find("TLightGroupY").gameObject.transform.Find("PointLightY").gameObject.GetComponent<Light>();
        redLight = gameObject.transform.Find("TLightGroupR").gameObject.transform.Find("PointLightR").gameObject.GetComponent<Light>();
        allTime = greenTime + yellowTime + redTime;
        if (beginInRed)
        {
            cTime = greenTime + yellowTime + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cTime += Time.deltaTime;
        if (cTime < greenTime)
        {
            GreenOn();
            drivingCar.speedNow = 10.0f;
        }
        else if (cTime < greenTime + yellowTime)
        {
            YellowOn();
            drivingCar.speedNow = 10.0f;
        }
        else if (cTime < greenTime + yellowTime + redTime)
        {
            RedOn();
            //車停止
            drivingCar.speedNow = 0f;
        }
        else
        {
            cTime = 0;
        }
    }

    void GreenOn()
    {
        greenLight.intensity = 5;
        yellowLight.intensity = 0;
        redLight.intensity = 0;
    }

    void YellowOn()
    {
        greenLight.intensity = 0;
        yellowLight.intensity = 5;
        redLight.intensity = 0;
    }

    void RedOn()
    {
        greenLight.intensity = 0;
        yellowLight.intensity = 0;
        redLight.intensity = 5;
    }

}
