using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    public Canvas StartScreen;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartScreen.enabled = false;
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartScreen.enabled = true;
        }
    }
}
