/*
 * By Jason Hein
 * 
 */


using UnityEngine;

/// <summary>
/// When placed in a scene.
/// On PC, hitting the print screen button on a keyboard will take a screenshot of the application and save it to the desktop.
/// </summary>
public class ScreenShot : MonoBehaviour {
    
#if UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.SysReq))
        {
            string date = System.DateTime.Now.ToString();
            date = date.Replace("/", "_");
            date = date.Replace(" ", "_");
            date = date.Replace(":", "_");
            ScreenCapture.CaptureScreenshot(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
                + "/" + Application.productName + "_" + date + ".png");
        }
    }
#endif
}
