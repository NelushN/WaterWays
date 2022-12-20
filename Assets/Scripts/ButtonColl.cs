using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColl : MonoBehaviour
   
{
    //public GameObject animal;
    public GameObject buttonTest;
   
    //Debug.Log("Collision Detected ho ho ho");
  
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected111110fdgg00000"+other.gameObject.name);
        if (other.gameObject.name == "Main Camera")
            //{
            //    Debug.Log("Collision Detected11111000000");
            //    buttonTest.SetActive(false);
            //}

            if (buttonTest != null)
            {
                bool isActive = buttonTest.activeSelf;
                buttonTest.SetActive(!isActive);
            }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Collision Detected ho ho ho");
        if (other.gameObject.name == "Main Camera")
        {
            buttonTest.SetActive(true);
            Debug.Log("Collision Detected99999999999999");
        }
    }

}
