using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_we_plant_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScale(){
		transform.localScale += new Vector3(3F, 3F, 3F);
	}
}
