using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other)
		{	
//			again_text_script ag = GameObject.Find("if we grow regularly text").GetComponent<again_text_script>();
//			ag.updateScale ();

			tree_grow tg = GameObject.Find("tree_1_grow").GetComponent<tree_grow>();
			tg.transformX ();

			tree_grow tg1 = GameObject.Find("tree_1_grow_1").GetComponent<tree_grow>();
			tg1.transformX ();

			tree_grow tg2 = GameObject.Find("tree_1_grow_2").GetComponent<tree_grow>();
			tg2.transformX ();

			tree_grow tg3 = GameObject.Find("tree_1_grow_3").GetComponent<tree_grow>();
			tg3.transformX ();

			tree_grow tg4 = GameObject.Find("tree_1_grow_4").GetComponent<tree_grow>();
			tg4.transformX ();

			tree_grow tg5 = GameObject.Find("tree_1_grow_5").GetComponent<tree_grow>();
			tg.transformX ();

			tree_grow tg6 = GameObject.Find("tree_1_grow_6").GetComponent<tree_grow>();
			tg6.transformX ();



			go_down gd = GameObject.Find("DeadTree_down").GetComponent<go_down>();
			gd.goDown ();


			go_down gd1 = GameObject.Find("DeadTree_down_1").GetComponent<go_down>();
			gd1.goDown ();


			go_down gd2 = GameObject.Find("DeadTree_down_2").GetComponent<go_down>();
			gd2.goDown ();


			go_down gd3 = GameObject.Find("DeadTree_down_3").GetComponent<go_down>();
			gd3.goDown ();


			go_down gd4 = GameObject.Find("DeadTree_down_4").GetComponent<go_down>();
			gd4.goDown ();


			go_down gd5 = GameObject.Find("DeadTree_down_5").GetComponent<go_down>();
			gd5.goDown ();

			go_down gd6 = GameObject.Find("DeadTree_down_6").GetComponent<go_down>();
			gd6.goDown ();
		}
	}
}
