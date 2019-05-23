using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonS1Click()
    {
        SceneManager.LoadScene("Stage1");
    }


    public void ButtonS2Click()
    {
        SceneManager.LoadScene("Stage2");
    }


    public void ButtonG1_1Click()
    {
        SceneManager.LoadScene("Title");
    }


    public void ButtonG1_2Click()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void ButtonG2_1Click()
    {
        SceneManager.LoadScene("Title");
    }


    public void ButtonG2_2Click()
    {
        SceneManager.LoadScene("Stage2");
    }


    public void ButtonClearClick()
    {
        SceneManager.LoadScene("Title");
    }


}
