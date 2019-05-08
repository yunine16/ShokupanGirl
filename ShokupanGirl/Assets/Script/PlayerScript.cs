using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public float speed = 0.5f;
    public int jump = 6;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
        //何も押さないと走る、スペースキー押すと止まる
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.zero;
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }


        //エンターキー押すとジャンプ
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jump, 0);
            Debug.Log(1);
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
