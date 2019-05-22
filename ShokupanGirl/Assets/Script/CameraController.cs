using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject Player;
    PlayerScript PlayerScript;
    Vector3 pos;

    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player").gameObject;
        PlayerScript = Player.GetComponent<PlayerScript>();
    }
	
	// Update is called once per frame
	void Update () {

        pos = Player.transform.position;
        pos.x = -14.48f;
        pos.y = 9.2f;
        pos.z = pos.z - 10;

        gameObject.transform.position = pos;


    }
}
