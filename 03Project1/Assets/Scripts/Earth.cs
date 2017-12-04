using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {
	static int count = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(){

		count++;
		Debug.Log (count + " Laps for Earth!");
	}
}
