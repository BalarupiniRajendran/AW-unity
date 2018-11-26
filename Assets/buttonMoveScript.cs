using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonMoveScript : MonoBehaviour {
	private GameObject cube;
	private GameObject canvas;
	// Use this for initialization
	void Start () {
		cube = GameObject.Find("BlueCube ");
		canvas = GameObject.Find ("Canvas");
	}

	public void Rotate(){
		InputField f = canvas.GetComponentsInChildren<InputField> () [0];
		Debug.Log (f.text);

		if (f.text.ToLower ().Equals ("left")) {
			cube.transform.Translate (0.1f, 0f, 0f);
		} else if (f.text.ToLower ().Equals ("right")) {
			cube.transform.Translate (-0.1f, 0f, 0f);
		} else if (f.text.ToLower ().Equals ("up")) {
			cube.transform.Translate (0f, 0f, 0.1f);
		}
		else if (f.text.ToLower ().Equals ("down")) {
			cube.transform.Translate (0f, 0f, -0.1f);
		}
		else if (f.text.ToLower ().Equals ("out")) {
			cube.transform.Translate (0f, 0.1f, 0f);
		}
		else if (f.text.ToLower ().Equals ("in")) {
			cube.transform.Translate (0f, -0.1f, 0f);
		}
	}
	// Update is called once per frame
	void Update () {

	}

}
