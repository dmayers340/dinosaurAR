using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Website : MonoBehaviour
{

    // Use this for initialization
    public void openWebsite()
    {
        Debug.Log("opening URL");
        Application.OpenURL("http://debmayers.com");
    }

    public void openGSCWebsite()
    {
        Debug.Log("opening URL");
        Application.OpenURL("https://www.glasgowsciencecentre.org/");
    }
}
