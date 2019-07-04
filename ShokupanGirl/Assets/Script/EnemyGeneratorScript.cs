using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorScript : MonoBehaviour {

    public GameObject[] Enemy;
    public GameObject generateEnemy;

    public float[] enemyPositionX;
    float posx;
    Vector3 pos;

    float timeOut;
    float timeElapsed;

	// Use this for initialization
	void Start () {
        timeOut = Random.Range(1.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () { 

        if (Input.GetKey(KeyCode.Space))
        {
            timeElapsed += 0;
        }
        else
        {
            timeElapsed += Time.deltaTime;
        }
        

        if (timeElapsed >= timeOut)
        {
            pos = transform.position;
            posx = enemyPositionX[Random.Range(0, enemyPositionX.Length)];
            pos.x = posx;
            transform.position = pos;
            generateEnemy = Enemy[Random.Range(0, Enemy.Length)];
            Instantiate(generateEnemy, pos, transform.rotation);
            timeElapsed = 0;
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goalchecker")
        {
            Destroy(this);
         }

    }
}
