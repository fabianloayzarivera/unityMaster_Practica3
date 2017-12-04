using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanoidBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (0, 200 * Time.deltaTime * Input.GetAxis ("Horizontal"), 0);
		gameObject.transform.Translate (Vector3.forward * 40 * Time.deltaTime * Input.GetAxis ("Vertical"));


	}


}
