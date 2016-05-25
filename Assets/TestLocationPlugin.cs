using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestLocationPlugin : MonoBehaviour
{

    public Text t;
    AndroidJavaClass unity;

    public void Start()
    {
        unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    }
    public void callShareApp()
    {
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        string tt = currentActivity.CallStatic<double>("getAccuracy").ToString();
        t.text = tt;
    }
}