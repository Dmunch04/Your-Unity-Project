using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJName : MonoBehaviour {
	



	// Use this for initialization
	public void Start () {
		Text printablearea = GetComponent<Text>();
		printablearea.text = SaveName.djnametoprint.ToString();
		Debug.Log ("name:");
	}
	
	// Update is called once per frame
	public void Update () {
		Text printablearea = GetComponent<Text>();
		printablearea.text = SaveName.djnametoprint.ToString();
		Debug.Log ("name2");
	
	}
}