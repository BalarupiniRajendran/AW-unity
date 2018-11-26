using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whattodowhencollided : MonoBehaviour {

	public GameObject myotherobject, mythisobject;
	float distance;

	// Use this for initialization
	void Start () {
		myotherobject = GameObject.Find("Bluecoin");
		mythisobject = GameObject.Find ("BlueCube ");
		distance = 0.5f;

	}


	// Update is called once per frame
	void Update () {

		if((mythisobject.transform.position - myotherobject.transform.position).sqrMagnitude > distance * distance){
			Debug.Log ("detected something");
		}
	}
//	void OnTriggerEnter(Collider other)
//	{
//		//if (other.gameObject.CompareTag("coin"))
//		if(other.gameObject.name == "Bluecoin")
//		{
//			other.gameObject.SetActive(false);
//		}
//	}
}
