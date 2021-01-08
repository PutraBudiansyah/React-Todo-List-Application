using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    UniWebView webView;

    // Use this for initialization
    void Start()
    {
        // Create a game object to hold UniWebView and add component.
        var webViewGameObject = new GameObject("UniWebView");
        webView = webViewGameObject.AddComponent<UniWebView>();

        // More to add...
        webView.Frame = new Rect(0, 0, Screen.width, Screen.height);
        webView.Load("https://reacttodobudiansyah.000webhostapp.com/");
        webView.Show();
    }

    // Update is called once per frame
    void Update()
    {

    }
}