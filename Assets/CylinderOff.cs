using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forCylinder : MonoBehaviour
{
    public GameObject objectCylinder;
    private bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    public void tapOnButton()
    {
        if (isActive)
        {
            isActive = false;
            objectCylinder.SetActive(isActive);
        }
        else
        {
            isActive = true;
            objectCylinder.SetActive(isActive);
        }
    }
}