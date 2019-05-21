﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.Space)){
            transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            transform.position += new Vector3(3.0f,0.0f,0.0f) * Time.deltaTime;
            animator.SetBool("Running", true);
            Debug.Log("ss");
        }
        else
        {
            transform.position += Vector3.zero;

        }
       
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Wall")
        {

            SceneManager.LoadScene("SelectStage");
        }
    }
}
