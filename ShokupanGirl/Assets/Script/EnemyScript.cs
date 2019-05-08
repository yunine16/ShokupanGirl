using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EnemyScript : MonoBehaviour {

    public int lossTime = 5;

    TimeScript script;
    public Text min;
    public float speed;


    // Use this for initialization
    void Start() {
        Debug.Log(min);
        //script = min.GetComponent<TimeScript>();
    }

    // Update is called once per frame
    void Update() {
        transform.position -= transform.forward * speed * Time.deltaTime;

    }

    public void OnCollisionEnter(Collision collision)
    {

        /*if (collision.gameObject.name == "Player")
        {
            public int gameMin = Convert.ToInt32(min.GetComponent<Text>().text);
            gameMin += lossTime;

            Destroy(gameObject); 
        }
        */
    }
        
}
