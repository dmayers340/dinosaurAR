using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjects : MonoBehaviour
{
    public GameObject objectToChange;
    public Button button;
    public bool currentState;

    public void Start()
    {
        button.onClick.AddListener(showObject);
        objectToChange.SetActive(false);
        currentState = false;
    }
    public void showObject()
    {

        if (currentState)
        {
            objectToChange.SetActive(false);
        }
        else
        {
            objectToChange.SetActive(true);
        }
        currentState = !currentState;
    }
}
