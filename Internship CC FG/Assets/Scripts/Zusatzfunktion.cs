//////////////////////////////////////////////////////////////////////////////////
///
///  Zusatzfunktions Script for Frauenhofer-Gesellschaft (Internship Task)
///  It handels the objects scale. When hovering with the mouse over the object the script is attached to, the object will scale up and down as an indicator you are hovering over it.
///  Oliver Werner
///  08.04.2022
/// 
//////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zusatzfunktion : MonoBehaviour
{

    private Transform target;
    private Vector3 minSize;
    private Vector3 maxSize;
    private Vector3 scaleFactor;
    private bool swapDirection;


    void Start()
    {
        target = GetComponent<Transform>();
        minSize = new Vector3 (0.9f, 0.9f, 0.9f);
        maxSize = new Vector3 (1.1f, 1.1f, 1.1f);
        scaleFactor = new Vector3 (0.0005f, 0.0005f, 0.0005f);
        swapDirection = false;
    }


    private void OnMouseOver()
    {
        // We check if the object has its maxSize that we want and compare it with the acutal scale of the object. If it is not at the value maxSize we increase the scale by the scaleFactor.
        // After hitting our maxSize we stop this if statment 
        if( (target.transform.localScale.x <= maxSize.x)  &&  (swapDirection == false) )
        {
            target.transform.localScale = target.transform.localScale + scaleFactor;

            if ( target.transform.localScale.x >= maxSize.x)
            {
                swapDirection = true;
            }
        }
        // We do the exact same but the other way around and srink the object in here. 
        // After hitting our minSize we stop this if statment 
        else if ( (target.transform.localScale.x >= minSize.x)  && (swapDirection == true) )
        {
            target.transform.localScale = target.transform.localScale - scaleFactor;

            if (target.transform.localScale.x <= minSize.x)
            {
                swapDirection = false;
            }
        }
    }
}
