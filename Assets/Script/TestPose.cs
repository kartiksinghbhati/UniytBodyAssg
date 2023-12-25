using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPose : MonoBehaviour
{
    public GameObject objToColor;

    public void Colorblue()
    {
        objToColor.GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        Debug.Log("Matched pose!");
    }
}
