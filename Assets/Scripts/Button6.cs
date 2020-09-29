using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button6 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbGameObject;
    public GameObject cube;
   
    bool isPressed = false;
    public Transform target;
    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
   

   
        // Rotate the camera every frame so it keeps looking at the target
       

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
     
        private void Update()
    {
      
        if (isPressed == true)
        {
            transform.LookAt(target, Vector3.left);
            
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

