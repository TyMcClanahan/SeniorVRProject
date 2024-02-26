using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class EnableDisable : MonoBehaviour
{
    public GameObject hook1;
    public GameObject gun1;
    public GameObject hook2;
    public GameObject gun2;
    private bool leftDefaultPostion = true;
    private bool rightDefaultPostion = true;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            if(leftDefaultPostion == true)
            {
                hook1.SetActive(false);
                gun1.SetActive(true);
                leftDefaultPostion = false;
            }else
            {
                hook1.SetActive(true);
                gun1.SetActive(false);
                leftDefaultPostion = true;
                
            }
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (rightDefaultPostion == true)
            {
                hook2.SetActive(false);
                gun2.SetActive(true);
                rightDefaultPostion = false;
            } else
            {
                hook2.SetActive(true);
                gun2.SetActive(false);
                rightDefaultPostion = true;
            }
        }
    }
}
