using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Month : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = timeandate.month.ToString();
		timeandate.Reset();
	}
	
	// Update is called once per frame
	void Update () {
		Text myText = GetComponent<Text>();
		myText.text = timeandate.month.ToString();
	}

}

