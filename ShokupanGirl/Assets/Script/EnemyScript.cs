using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyScript : MonoBehaviour {

    public int lossTime = 3;


    public float speed;
    private Animator animator;


    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
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

        }
    }



}
