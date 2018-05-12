using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderController : MonoBehaviour {

    public GameObject FaderUI;
	
	// Update is called once per frame
	void Update () {
        if (Fader.faderRequired == 1) {
            Destroy(FaderUI);
            Debug.Log("fader deystoryed ");

        }
	}
}
