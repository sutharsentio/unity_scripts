using UnityEngine;
using UnityEngine.UI;
using System.Collections;
  

public class SkyHandler : MonoBehaviour {
	GameObject prev, next;
	GameObject[] menus, homeButton;
	int index;
	public Material[] CasaMats, MercMats, OfficeMats, ChurchMats, mats;

	// Use this for initialization
	public void Start(){

		homeButton = GameObject.FindGameObjectsWithTag("Home");
		prev = GameObject.Find("bottom_left");
		Debug.Log (prev.name);
		next = GameObject.Find("bottom_right");
		Debug.Log (next.name);
		setHome (false);
		menus = GameObject.FindGameObjectsWithTag("Menu");
	}

	public void skyHome(Material sky){
		setHome (false);
		setMenu (true);
		RenderSettings.skybox = sky;
	}

	Material[] getMaterial(string name){
		if (name == "casa")
			return CasaMats;
		else if (name == "mercedes")
			return MercMats;
		else if (name == "office")
			return OfficeMats;
		else if (name == "church")
			return ChurchMats;
		else
			return null;
	}

	public void skyChange(string skyName){
		mats = getMaterial (skyName);
		if (mats == null)
			return;
		setHome (true);
		setMenu (false);
		index = 0;
		if (mats.Length > 1) {
			prev.SetActive (true);
			next.SetActive (true);
		} else {
			prev.SetActive (false);
			next.SetActive (false);
		}
		RenderSettings.skybox = mats[index%mats.Length];
	}

	public void skyNav(int mv){
		index = index + mv;
		Debug.Log ("Index number " + index);
		RenderSettings.skybox = mats[(index+mats.Length)%mats.Length];
	}

	void setHome(bool state){
		foreach (GameObject home in homeButton)
			home.SetActive (state);
	}

	void setMenu(bool state){
		foreach (GameObject menu in menus)
			menu.SetActive (state);
	}
}
