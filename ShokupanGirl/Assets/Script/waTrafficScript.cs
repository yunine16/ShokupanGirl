using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waTrafficScript : MonoBehaviour
{


    Light greenLight, yellowLight, redLight;

    public float greenTime, yellowTime, redTime;
    public bool beginInRed;


    float cTime, allTime;


    /*
    //車停止用
    GameObject Car;
    DrivingCar drivingCar;
    */


    GameObject TLightGroupG;
    GameObject PointLightG;


    //車の速さ
    //public float gMater;
    //public float yMater;
    //public float rMater;


    public bool red;


    // Use this for initialization
    void Start()
    {



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
        //車
        //Car = GameObject.FindWithTag("Cars");
        //drivingCar = Car.GetComponent<DrivingCar>();

        cTime += Time.deltaTime;
        if (cTime < greenTime)
        {
            GreenOn();
            //drivingCar.speedNow = gMater;
            red = false;
        }
        else if (cTime < greenTime + yellowTime)
        {
            YellowOn();
            //drivingCar.speedNow = yMater;
            red = false;
        }
        else if (cTime < greenTime + yellowTime + redTime)
        {
            RedOn();
            //車停止
            //drivingCar.speedNow = rMater;
            red = true;
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
