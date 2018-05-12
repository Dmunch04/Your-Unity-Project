using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Year : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = timeandate.year.ToString();
		timeandate.Reset();
	}
	
	// Update is called once per frame
	void Update () {
		Text myText = GetComponent<Text>();
		myText.text = timeandate.year.ToString();
	}
}
