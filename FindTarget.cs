using UnityEngine;
using System.Collections;

public class FindTarget : MonoBehaviour {
	//public Camera camera;
	//public Material church;
	//public Material house;

	private CardboardHead head;

	void Start(){
		head = Camera.main.GetComponent<StereoController>().Head;

	}

	public void changeSkybox(Material sky){
		RenderSettings.skybox = sky;
	}


	void Update() {
		RaycastHit hit;
		//Ray rais;
		//if (Input.GetButtonDown ("Fire1")) {
			//rais = camera.ScreenPointToRay (Input.mousePosition);
			//bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);
			//rais = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
			//rais = camera.ScreenPointToRay(new Vector3(0.5f, 0.5f, 0f));
			//Debug.Log (head.Gaze);
			if (Physics.Raycast (head.Gaze, out hit, Mathf.Infinity)) {
				//Debug.DrawLine (rais.origin, hit.point);
				Debug.Log (hit.collider.name);
				if(hit.collider.name == "sphere"){
			//		RenderSettings.skybox = sky;
					hit.collider.gameObject.SetActive(false);
				}
			}
		//}
	}
}
	

