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
    private Animator animator;


    // Use this for initialization
    void Start() {
        Debug.Log(min);
        animator = GetComponent<Animator>();
        //script = min.GetComponent<TimeScript>();
    }

    // Update is called once per frame
    void Update() {
        transform.position += transform.forward * speed * Time.deltaTime;
        animator.SetBool("Walking", true);
    }

    public void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "Player")
        {
            animator.SetBool("Walking", false);
            Destroy(gameObject);
            Debug.Log("ss");
        }

    }
        
}
// public int gameMin = Convert.ToInt32(min.GetComponent<Text>().text);
//gameMin += lossTime;
