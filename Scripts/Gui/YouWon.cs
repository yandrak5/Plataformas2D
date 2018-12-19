using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWon : MonoBehaviour {
	public object LoadScene { get; private set; }

	void OnCollisionEnter2D(Collision2D c){

		if(c.transform.tag == "coche") {

			SceneManager.LoadScene ("HasGanado");

		}
	}
}
