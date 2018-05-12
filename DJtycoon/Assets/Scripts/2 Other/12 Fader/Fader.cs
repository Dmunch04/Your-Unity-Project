using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{

    public float fadeInTime;

    private Image fadePanel;
    private Color currentColor = Color.black;
    public static int faderRequired = 0;

    // Use this for initialization
    void Start()
    {
        fadePanel = GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeSinceLevelLoad < fadeInTime)

            {
                // Fade In
                float alphaChange = Time.deltaTime / fadeInTime;
                currentColor.a -= alphaChange;
                fadePanel.color = currentColor;
                
            }
       
            
            else
            {
                gameObject.SetActive(false);
            }



        }
    public void faderAdded () {
        faderRequired = 1;
        Debug.Log("faderrequired at 1");
    }
    }

