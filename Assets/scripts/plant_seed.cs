using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_seed : MonoBehaviour {

	// Use this for initialization
	float x;
	bool up = false;
	Vector3 tempPos;
	public float moveSpeed = 5f;
	public float turnSpeed = 30f;
	float y = 27.5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y < y && up)
			transform.Translate (Vector3.up * 2f * Time.deltaTime);
	}

	public void transformX(){
		Debug.Log ("transformX called ");
		up = true;

	}
}
