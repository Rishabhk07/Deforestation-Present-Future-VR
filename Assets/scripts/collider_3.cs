using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_3 : MonoBehaviour {

	// Use this for initialization
	float x;
	bool up = false;
	Vector3 tempPos;
	public float moveSpeed = 5f;
	public float turnSpeed = 30f;
	float y = 27f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnTriggerEnter(Collider other)
	{
		terrain_tranlate tt = GameObject.Find("Terrain").GetComponent<terrain_tranlate>();
		tt.transformX ();
	}
}
