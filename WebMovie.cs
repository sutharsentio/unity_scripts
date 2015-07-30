using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class WebMovie : MonoBehaviour {

	// Use this for initialization
	//string url = "192.168.1.115:8080";
	//string url = "https://becunningandfulloftricks.files.wordpress.com/2013/04/hedgehog_in_the_fog.ogg";
	//string url = "http://192.168.1.122:8081/camfeed.ogg";
	string url = "http://127.0.0.1:8080/test.ogg";
	WWW wwwData = null;
	MovieTexture movie;
	void Start () {
		wwwData = new WWW (url);
		movie = wwwData.movie;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			if (movie.isReadyToPlay) {
				Renderer r = GetComponent<Renderer> ();
				r.material.mainTexture = movie;
			
				AudioSource audio = GetComponent<AudioSource> ();
				audio.clip = movie.audioClip;

				if (!movie.isPlaying) {
					audio.Play ();
					movie.Play ();
				} else {
					audio.Pause ();
					movie.Pause ();
				}
			} else
				Debug.Log ("Movie is loading yet");

		}
	}
}
