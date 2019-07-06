using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waTrafficPScript : MonoBehaviour
{

    Light greenLight, redLight;

    public float greenTime, blinkTime, redTime;
    public bool beginInRed;

    float cTime, allTime;
    float blinkInterval = 0.5f;

    public bool redP;

    // Use this for initialization
    void Start()
    {

        //いじらない
        greenLight = gameObject.transform.Find("TPLightGroupG").gameObject.transform.Find("PointLightPG").gameObject.GetComponent<Light>();
        redLight = gameObject.transform.Find("TPLightGroupR").gameObject.transform.Find("PointLightPR").gameObject.GetComponent<Light>();
        //ここまで

        allTime = greenTime + blinkTime + redTime;
        if (beginInRed)
        {
            cTime = greenTime + blinkTime + 1;

        }

    }

    // Update is called once per frame
    void Update()
    {
        cTime += Time.deltaTime;
        if (cTime < greenTime)
        {
            GreenOn();
            redP = false;
        }
        else if (cTime < greenTime + blinkTime)
        {
            Blink();
            redP = false;
        }
        else if (cTime < greenTime + blinkTime + redTime)
        {
            RedOn();
            redP = true;
        }
        else
        {
            cTime = 0;
        }
    }


    void GreenOn()
    {
        greenLight.intensity = 5;
        redLight.intensity = 0;
    }

    void Blink()
    {
        float spendTime = cTime - greenTime;
        if (spendTime % blinkInterval < blinkInterval / 2)
        {
            greenLight.intensity = 0;
            redLight.intensity = 0;
        }
        else
        {
            greenLight.intensity = 5;
            redLight.intensity = 0;
        }

    }

    void RedOn()
    {
        greenLight.intensity = 0;
        redLight.intensity = 5;
    }
}
