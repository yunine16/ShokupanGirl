using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {

    private Animator animator;
    bool run;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {




        if (Input.GetKeyDown(KeyCode.Space)){
            run = true;
        }

        if (run)
        {
            transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            transform.position += new Vector3(3.0f, 0.0f, 0.0f) * Time.deltaTime;
            animator.SetBool("Running", true);
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
