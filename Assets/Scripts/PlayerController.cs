using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float vmove = Input.GetAxisRaw ("Vertical");
		float hmove = Input.GetAxisRaw ("Horizontal");

		Vector3 movement = new Vector3 (hmove,vmove);

		transform.Translate (movement*speed*Time.deltaTime);

		
	}
}
