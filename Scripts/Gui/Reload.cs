using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {
    public object LoadScene { get; private set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetTouch(0).phase == TouchPhase.Began)

        {
            SceneManager.LoadScene("SampleScene");
        }


    }
}
