using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class again_text_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScale(){
		transform.localScale += new Vector3(1F, 1F, 1F);
	}

	public void changeText(){
		TextMesh t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
		t.text = "water seed and provide sunlight";
	}

	public void downScale(){
		transform.localScale -= new Vector3(1F, 1F, 1F);
	}

}
