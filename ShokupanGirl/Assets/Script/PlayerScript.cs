using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public float speed = 100.0f;
    public float wide = 3.5f;
    private Animator animator;
    public int counter = 0;
    GameObject hour;
    TimeScript timeScript;

    //GameObject Car;
    public float damageTime;



    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        hour = GameObject.Find("hour").gameObject;
        timeScript = hour.GetComponent<TimeScript>();
	}

    // Update is called once per frame
    void Update()
    {

        //何も押さないと走る、スペースキー押すと止まる
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.zero;
            animator.SetBool("Running", false);
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("Running", true);
        }



        
            //上矢印キー押すと奥いく
            if (Input.GetKeyDown(KeyCode.UpArrow) && (gameObject.transform.position.x < -1.5f))
            {
                transform.position += new Vector3(wide, 0, 0);
            }

            //下矢印キー押すと手前いく
            if (Input.GetKeyDown(KeyCode.DownArrow) && (-4 <= gameObject.transform.position.x))
            {
                transform.position -= new Vector3(wide, 0, 0);
            }



        timeScript.LossTime(counter);

        counter = 0;


        if(damageTime >= 0)
        {
            damageTime -= Time.deltaTime;
        }
        else
        {
            animator.SetBool("Damaging", false);
        }




    }


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "GoalChecker")
        {

            SceneManager.LoadScene("Clear");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Car = GameObject.FindWithTag("Cars");

        if (collision.gameObject.tag == "Enemy")
        {
            animator.SetBool("Damaging", true);
            counter++;
            damageTime = 0.3f;
        }
        else if(collision.gameObject.tag == "Cars")
        {
            animator.SetBool("Damaging", true);

            if(SceneManager.GetActiveScene().name== "Stage1")
            {
                SceneManager.LoadScene("GameOver1");
            }
            else
            {
                SceneManager.LoadScene("GameOver2");
            }
        }


    }



}
