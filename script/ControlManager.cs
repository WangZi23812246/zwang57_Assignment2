using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public GameObject target;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft() {
        value -= 0.5f;
        target.transform.position = new Vector3(value, -3.4f, -0.35f);
    }
    
    public void MoveRight() {
        value += 0.5f;
        target.transform.position = new Vector3(value, -3.4f, -0.35f);
    }

    public void RotateRight() {
        target.transform.Rotate(0f, -5f, 0f);
    }

    public void Grow() {
        target.transform.localScale += sizeChange;
    }

    public void Reset() {
        target.transform.position = new Vector3(6.86f, -3.4f, -0.35f);
        target.transform.rotation = Quaternion.Euler(new Vector3(0, -152, 0));
        target.transform.localScale = new Vector3(1, 1, 1);
        value = 6.86f;
    }
}
