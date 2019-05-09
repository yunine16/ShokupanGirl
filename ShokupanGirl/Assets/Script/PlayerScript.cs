using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public float speed = 0.5f;
    public float wide = 3.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
        //何も押さないと走る、スペースキー押すと止まる
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position -= Vector3.zero;
        }
        else
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }


        //上矢印キー押すと奥いく
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(wide, 0, 0);
            Debug.Log(1);
        }

        //下矢印キー押すと手前いく
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(wide, 0, 0);
            Debug.Log(2);
        }

    }


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "GoalChecker")
        {

            SceneManager.LoadScene("Clear");
        }
    }

}
