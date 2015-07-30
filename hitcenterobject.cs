using UnityEngine;
using System.Collections;

public class hitcenterobject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Camera camera = GetComponent<Camera> ();
		Vector3 cameraCenter = camera.ScreenToWorldPoint(new Vector3(Screen.width / 2f, Screen.height / 2f, camera.nearClipPlane));
		if (Physics.Raycast(cameraCenter, transform.forward, out hit, 1000))
		{
			Debug.Log("Ou yeah!");
		}
	}
}
