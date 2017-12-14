using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public GameObject projectile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (0, 200 * Time.deltaTime * Input.GetAxis ("Horizontal"), 0);
		gameObject.transform.Translate (Vector3.forward * 40 * Time.deltaTime * Input.GetAxis ("Vertical"));

		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log ("fire!");

			GameObject shot = Instantiate (projectile, gameObject.transform.position, Quaternion.identity) as GameObject;
			shot.GetComponent<Rigidbody> ().AddForce (gameObject.transform.forward * 10000);
		}
	}
}
