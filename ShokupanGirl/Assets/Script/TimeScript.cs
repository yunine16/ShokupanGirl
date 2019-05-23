using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {

    public Text hourText;
    public Text minText;
    public int hour;
    public int min;
    private float timeLeft;
    public float timePerMin;

	// Use this for initialization
	void Start () {
        hour = 8;
        min = 9;
        hourText.text = hour.ToString();
        minText.text = min.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //10秒ごとに処理
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0.0)
        {
            timeLeft = timePerMin;
            min += 1;
        }

        //60分になったら時間に１を足す
        if (min == 60)
        {
            min = 0;
            hour += 1;
        }

        //制限時間(8:30)になったらゲームオーバー画面に遷移
        if (min > 30)
        {
            if (SceneManager.GetActiveScene().name == "Stage1")
            {
                SceneManager.LoadScene("GameOver1");
            }
            else
            {
                SceneManager.LoadScene("GameOver2");
            }
        }


        minText.text = min.ToString();
        hourText.text = hour.ToString();

	}

    public void LossTime(int counter)
    {
        //Debug.Log(counter);

        if(counter >= 1)
        {
            min += 5;
        }
    }
}
