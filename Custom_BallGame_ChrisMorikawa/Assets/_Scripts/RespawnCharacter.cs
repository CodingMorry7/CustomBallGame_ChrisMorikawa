using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCharacter : MonoBehaviour {
	public float OOB; //OOB = Out of Bounds
	void FixedUpdate() {
		if(transform.position.y < OOB){
			transform.position = new Vector3(0,0,0);
		}
	}
}
