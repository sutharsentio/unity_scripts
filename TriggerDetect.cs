using UnityEngine;
using System.Collections;

public class TriggerDetect : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider col){
		Debug.Log ("Entered into trigger Area");
		Debug.Log (col.tag);
	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("Collision occured");
		Debug.Log (col.gameObject.tag);
	}

}