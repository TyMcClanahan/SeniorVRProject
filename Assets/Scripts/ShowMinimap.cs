using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShowMinimap : MonoBehaviour
{
    public GameObject minimap;

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch) || OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            minimap.SetActive(true);
        }
        else
        {
            minimap.SetActive(false);
        }
    }
}
