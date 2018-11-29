using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_ : MonoBehaviour {

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
			again_text_script ag = GameObject.Find("again_text").GetComponent<again_text_script>();
			ag.updateScale ();
			Debug.Log (other.gameObject.tag);
			Debug.Log("entered");
			Debug.Log(other);
		}
	}

}
