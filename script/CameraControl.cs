using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    public float xvalue;
    public float yvalue;
    public float zvalue;
    public GameObject camera;

    public void Moveleft()
    {
        xvalue = xvalue - 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveright()
    {
        xvalue = xvalue + 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveforward()
    {
        zvalue = zvalue + 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movebackward()
    {
        zvalue = zvalue - 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Moveup()
    {
        yvalue = yvalue + 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }

    public void Movedown()
    {
        yvalue = yvalue - 5f;
        camera.transform.position = new Vector3(xvalue, yvalue, zvalue);
    }
}
