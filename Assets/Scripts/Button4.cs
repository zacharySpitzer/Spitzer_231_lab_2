using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button4 : MonoBehaviour, IVirtualButtonEventHandler
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
        cube.transform.localScale += new Vector3(0, 0, .09f);
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.transform.localScale += new Vector3(0, 0, -.09f);
        Debug.Log("vb Released");
    }

}