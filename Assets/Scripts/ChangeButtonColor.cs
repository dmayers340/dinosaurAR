using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour {
    private bool buttonHasBeenPressed = false;
    public Button button;
    public Color pressedColor;
    public Color firstColor;

    public void ButtonWasPressed()
    {
        buttonHasBeenPressed = !buttonHasBeenPressed;
        if (buttonHasBeenPressed)
        {
            button.image.color = pressedColor;
        }
        else
        {
            button.image.color = firstColor;
        }
    }

}
