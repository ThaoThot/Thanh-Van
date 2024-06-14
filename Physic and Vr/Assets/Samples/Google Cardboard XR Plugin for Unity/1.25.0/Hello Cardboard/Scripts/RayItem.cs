using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayItem : MonoBehaviour, IRayItem
{
    public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
    }
}
   
    

