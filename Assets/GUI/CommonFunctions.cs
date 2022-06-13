using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ARLocation.Utils;
public class CommonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject A, B, C;  public DevCameraController dcc;
    // Update is called once per frame
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                A.SetActive(true); B.SetActive(false); C.SetActive(false);
                dcc.ReloadALLCOSTIL();
            }
        }
    }
}
