using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour {
	public static string djAlias;
	public  Text DJAlias;
	public static string djnametoprint;


	// Use this for initialization
	public void Start () {
		DJAlias.text = ("DJ Alias");
		Debug.Log ("DJ Alias Reset");
	}


	public void submitName ()
	{

 		string inputdj = GameObject.Find ("InputField").GetComponent<InputField>().text;
		print ("Saving "+inputdj);
		DJAlias.text = DJAlias.text = inputdj;
		Debug.Log ("DJ Alias Changed");
		djnametoprint = djnametoprint = inputdj;
		DontDestroyOnLoad(this.gameObject);

}

}
