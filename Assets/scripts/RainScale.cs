using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void updateScale(){
		transform.localScale += new Vector3(1F, 1F, 1F);

	}

	public void downScale(){
		transform.localScale -= new Vector3(1F, 1F, 1F);

	}
}
