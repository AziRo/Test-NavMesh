using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform _follow;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.position = new Vector3(_follow.transform.position.x, transform.position.y, _follow.transform.position.z+8);
		transform.position = new Vector3(_follow.transform.position.x, transform.position.y, _follow.transform.position.z); 
	}
}
