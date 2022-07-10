using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Version : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Update the text of the host game object text component with the current application version.
        GetComponent<Text>().text = "Version: " + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
