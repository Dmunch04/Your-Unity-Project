using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	void Awake() {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);

	}

	void Start () {
		audioSource = GetComponent<AudioSource>();

	}

	void OnLevelWasLoaded (int level) {
		AudioClip thislevelmusic = levelMusicChangeArray[level];
		Debug.Log ("Playing clip: " + thislevelmusic);

		if (thislevelmusic) { // if there's some music attached 
			audioSource.clip = thislevelmusic;
			audioSource.loop = true;
			audioSource.Play ();
	}

}
}
