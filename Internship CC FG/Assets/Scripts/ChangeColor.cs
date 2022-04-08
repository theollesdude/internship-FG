//////////////////////////////////////////////////////////////////////////////////
///
///  Change Color Script for Frauenhofer-Gesellschaft (Internship Task)
///  A script that is responisble for changing the color of this object when being clicked. It also handles the orbitings sphere color according to the this objects color.
///  Oliver Werner
///  08.04.2022
/// 
//////////////////////////////////////////////////////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    private Renderer materialComponent;
    private Renderer otherMaterialComponent;
    private Color randomColor;

    void Start()
    {
        this.materialComponent = GetComponent<Renderer>();
        otherMaterialComponent = GameObject.Find("Sphere").GetComponent<Renderer>();
    }



    private void OnMouseDown()
    {
        // randomized color 
        randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        // settomg the radomized color to our "Cube" & "Sphere" object on left mouse click
        materialComponent.material.SetColor("_Color", randomColor);
        otherMaterialComponent.material.SetColor("_Color", randomColor);
    }
}
