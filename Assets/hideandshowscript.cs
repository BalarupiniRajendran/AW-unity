using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hideandshowscript : MonoBehaviour {

	public GameObject Panel;
	int counter;


	void Start () {
		Panel = GameObject.Find("helpPanel");
		Panel.SetActive (false);
	}

	public void showHidePanel(){
		
//		counter++;
//		if (counter % 2 == 0) {
//			Panel.gameObject.SetActive (false);
//		}
//		else{
//			Panel.gameObject.SetActive (true);
//		}

		Panel.SetActive (!Panel.activeSelf);
	}
		
}
