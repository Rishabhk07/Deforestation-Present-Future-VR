using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//	void OnCollisionEnter(Collision collision)
	//	{
	//		Debug.Log ("Collision");
	//	}
	//
	void OnTriggerEnter(Collider other)
	{

		if (other)
		{	
			if_we_plant_text ag = GameObject.Find("if we grow regularly text").GetComponent<if_we_plant_text>();
			ag.updateScale ();
			Debug.Log (other.gameObject.tag);
			Debug.Log("entered");
			Debug.Log(other);
		}
	}

}
