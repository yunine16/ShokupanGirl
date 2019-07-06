using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorScript : MonoBehaviour {

    public GameObject[] Enemy;
    GameObject enemyGenerator;

    float timeOut;
    float timeElapsed;

    Vector3 pos;
    public float[] positionX;

	// Use this for initialization
	void Start () {
        timeOut = Random.Range(1.0f, 4.0f);
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
            enemyGenerator = Enemy[Random.Range(0, Enemy.Length)];

            pos = transform.position;
            pos.x = positionX[Random.Range(0, positionX.Length)];
            transform.position = pos;

            Instantiate(enemyGenerator, transform.position, transform.rotation);

            timeElapsed = 0.0f;
        }
	}
}
