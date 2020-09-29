using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button2Script : MonoBehaviour, IVirtualButtonEventHandler
{
   
    public GameObject vbGameObject;
    public GameObject cube;
    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.transform.Translate(.1f,0,0); 
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.transform.Translate(-.1f, 0, 0);
        Debug.Log("vb Released");
    }

}
