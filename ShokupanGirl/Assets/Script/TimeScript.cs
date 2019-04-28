using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {

    public Text hourText;
    public Text minText;
    public int hour;
    public int min;
    private float timeLeft;

	// Use this for initialization
	void Start () {
        hour = 7;
        min = 20;
        hourText.text = hour.ToString();
        minText.text = min.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //10秒ごとに処理
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0.0)
        {
            timeLeft = 3.0f;
            min += 5;
        }

        //60分になったら時間に１を足す
        if (min == 60)
        {
            min = 0;
            hour += 1;
        }
        

        minText.text = min.ToString();
        hourText.text = hour.ToString();

	}
}
