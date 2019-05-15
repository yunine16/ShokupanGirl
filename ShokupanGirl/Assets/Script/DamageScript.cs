using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour {

    TimeScript script;
    public Text min;
    public int lossTime;
    private int count;
    public GameObject Player;
    PlayerScript playerScript;

    // Use this for initialization
    void Start () {
        //script = min.GetComponent<TimeScript>();
        playerScript = Player.GetComponent<PlayerScript>();
        //Debug.Log(min);

    }

    // Update is called once per frame
    void Update () {
        //count = playerScript.GetCounter();
        //Debug.Log(count);
        //public int gameMin = Convert.ToInt32(min.GetComponent<Text>().text);
        //gameMin += lossTime;
    }

    public void View(int counter)
    {
        Debug.Log(counter);
    }


}
