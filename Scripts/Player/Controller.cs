using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    float s;
    Animator anim;

    // Use this for initialization
    void Start () {
        s = 5f;
        anim = GetComponent<Animator>();
		
	}

    // Update is called once per frame
    void Update() {

        transform.Translate(Vector3.right * Time.deltaTime * s);

    }
}
