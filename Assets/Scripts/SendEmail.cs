using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEmail : MonoBehaviour
{

    public void EmailToSend()
    {
        string email = "dmayers340@gmail.com";
        string subject = MyEscapeURL("Email After Seeing AR Idea");
        string body = MyEscapeURL("It was great to see your AR idea. I really enjoyed learning more about dinosaurs using AR and thought there was a lot of potential. \r\nI thought it was a great and valuable idea and would like to keep in contact.");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
