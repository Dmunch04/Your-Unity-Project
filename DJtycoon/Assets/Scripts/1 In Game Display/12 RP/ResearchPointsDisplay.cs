using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchPointsDisplay: MonoBehaviour {

    void Start()
    {
        Text myText = GetComponent<Text>();
        myText.text = timeandate.researchPoints.ToString();
        timeandate.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Text myText = GetComponent<Text>();
        myText.text = timeandate.researchPoints.ToString();
    }
}
