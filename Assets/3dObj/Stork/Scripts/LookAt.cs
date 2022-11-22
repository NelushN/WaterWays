using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.LookAt(target);
	}
}
