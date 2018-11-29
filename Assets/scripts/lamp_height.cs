using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp_height : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScale(){
		transform.localScale += new Vector3(30F, 30F, 30F);

	}

	public void downScale(){
		transform.localScale -= new Vector3(30F, 30F, 30F);

	}
}
