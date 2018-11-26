using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showandhidequestionscript : MonoBehaviour {

	public GameObject Qpanel;
	int counter;


	// Use this for initialization
	void Start () {
		Qpanel = GameObject.Find("questionPanel");
		Qpanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showHideqPanel (){
		Qpanel.SetActive (!Qpanel.activeSelf);
	}

}
