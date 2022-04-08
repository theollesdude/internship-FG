//////////////////////////////////////////////////////////////////////////////////
///
///  Rotate Around Me Script for Frauenhofer-Gesellschaft (Internship Task)
///  A script that lets a "Sphere" object orbit around the origin object "Cube".
///  Oliver Werner
///  08.04.2022
/// 
//////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundMe : MonoBehaviour
{
    private GameObject rotatingObject;
    private GameObject originObject;
    private float speed;

    void Start()
    {
        rotatingObject = GameObject.Find("Sphere");
        originObject = GameObject.Find("Cube");
        speed = 100.0f;
    }

    
    void Update()
    {
        // The rotating object ("Sphere") is orbiting around its origin ("Cube") with a fixed value ("speed").
        rotatingObject.transform.RotateAround(originObject.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
