using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour {

    public int lossTime;
    private int count;
    public GameObject Player;
    PlayerScript playerScript;
    int addTime = 0;

    // Use this for initialization
    void Start () {
        playerScript = Player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update () {

    }

    /*public void Count(int counter)
    {
        
        addTime +=  counter;
        Debug.Log(addTime);
        Debug.Log(counter);

    }*/


}
