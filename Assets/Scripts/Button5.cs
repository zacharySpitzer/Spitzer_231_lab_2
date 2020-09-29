using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button5 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbGameObject;
    public GameObject cube;
    public float rotateSpeed = 50f;
    bool isPressed = false;
    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    private void Update()
    {
        if(isPressed == true)
        {
            cube.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
       
       
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        isPressed = true;
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        isPressed = false;
        Debug.Log("vb Released");
    }

}
