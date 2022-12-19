using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    // [SerializeField]
    public GameObject panel;
   // public AudioSource audioClip;

    public void OpenPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }


    }

    //public void PlayAudio() 
    //{

    //    audioClip.Play();
    //}
}
