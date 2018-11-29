using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head_keyboard_input : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)){
			Debug.Log ("P clicked");
			plant_seed p = GameObject.Find("Oak_Tree_33").GetComponent<plant_seed>();
			p.transformX ();
			again_text_script ag = GameObject.Find("plant_tree").GetComponent<again_text_script>();
			ag.updateScale ();
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			RainScale rainscale = GameObject.Find("RainPrefab").GetComponent<RainScale>();
			rainscale.updateScale ();
			lamp_height lh = GameObject.Find("Old_USSR_Lamp_01").GetComponent<lamp_height>();
			lh.updateScale ();
			again_text_script ag = GameObject.Find("plant_tree").GetComponent<again_text_script>();
			ag.changeText ();
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			again_text_script ag = GameObject.Find("plant_tree").GetComponent<again_text_script>();
			ag.downScale ();
			go_down gd  = GameObject.Find("Oak_Tree_33").GetComponent<go_down>();
			gd.goDown();
			lamp_height lh = GameObject.Find("Old_USSR_Lamp_01").GetComponent<lamp_height>();
			lh.downScale ();
			RainScale rainscale = GameObject.Find("RainPrefab").GetComponent<RainScale>();
			rainscale.downScale ();

			tree_grow bt = GameObject.Find("tree_1").GetComponent<tree_grow>();
			bt.transformX ();

			tree_grow bT = GameObject.Find("tree_1_20").GetComponent<tree_grow>();
			bT.transformX ();

		}
		
	}
}
