using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int lossTime = 3;


    public float speedEnemy;
    float speedNowEnemy;
    private Animator animator;

   


    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
        speedNowEnemy = speedEnemy;
    }

    // Update is called once per frame
    void Update() {
        transform.position += transform.forward * speedNowEnemy * Time.deltaTime;
        animator.SetBool("Walking", true);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            animator.SetBool("Walking", false);
            Destroy(this.gameObject);
        }else if (collision.gameObject.name == "DestroyWall")
        {
            Destroy(this.gameObject);
        }
    }


    public void SpeedUpEnemy()
    {
       speedNowEnemy = 10 * speedEnemy;
       //Debug.Log("EnemySpeedUp");
    }

    public void UsualEnemy()
    {
        speedNowEnemy = speedEnemy;
        animator.SetBool("Walking", true);
    }

    public void StopEnemy()
    {
        speedNowEnemy = 0;
        animator.SetBool("Walking", false);
    }

}
