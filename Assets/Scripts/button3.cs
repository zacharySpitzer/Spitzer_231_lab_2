using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class button3 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbGameObject;
    public GameObject cube;
    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        Debug.Log("vb Released");
    }

}
