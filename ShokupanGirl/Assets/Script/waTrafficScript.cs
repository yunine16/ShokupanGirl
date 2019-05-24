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
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    DrivingCar drivingCar1;
    DrivingCar drivingCar2;
    //DrivingCar drivingCar3;

    GameObject TLightGroupG;
    GameObject PointLightG;


    //車の速さ
    public float gMater;
    public float yMater;
    public float rMater;



    // Use this for initialization
    void Start()
    {
        //車
        //Car1 = GameObject.Find("Car").gameObject;
        drivingCar1 = Car1.GetComponent<DrivingCar>();
        //drivingCar2 = Car2.GetComponent<DrivingCar>();
        //drivingCar3 = Car3.GetComponent<DrivingCar>();

        TLightGroupG = gameObject.transform.Find("TLightGroupG").gameObject;
        //Debug.Log(TLightGroupG.name);
        PointLightG = TLightGroupG.transform.Find("PointLightG").gameObject;
        //Debug.Log(PointLightG.name);

        greenLight = PointLightG.GetComponent<Light>();
        //greenLight = gameObject.transform.Find("TLightGroupG").gameObject.transform.Find("PointLightG").gameObject.GetComponent<Light>();
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
            drivingCar1.speedNow = gMater;
            //drivingCar2.speedNow = 50.0f;
            //drivingCar3.speedNow = 50.0f;
        }
        else if (cTime < greenTime + yellowTime)
        {
            YellowOn();
            drivingCar1.speedNow = yMater;
            //drivingCar2.speedNow = 30.0f;
            //drivingCar3.speedNow = 30.0f;
        }
        else if (cTime < greenTime + yellowTime + redTime)
        {
            RedOn();
            //車停止
            drivingCar1.speedNow = rMater;
            //drivingCar2.speedNow = 0f;
            //drivingCar3.speedNow = 0f;
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
