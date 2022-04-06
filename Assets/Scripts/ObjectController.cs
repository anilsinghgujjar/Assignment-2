using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject myCube;
    public float value;
    public Vector3 sizeChange;
    
    //move right function
    public void MoveRight()
    {
        value = value + 5f;
        myCube.transform.position = new Vector3(value, 500, 0);
    }

    //move left function
    public void MoveLeft()
    {
        value = value - 5f;
        myCube.transform.position = new Vector3(value, 500, 0);
    }

    //move up function
    public void MoveUp()
    {
        value = value + 5f;
        myCube.transform.position = new Vector3(500, value, 0);
    }

    //move down function
    public void MoveDown()
    {
        value = value - 5f;
        myCube.transform.position = new Vector3(500, value, 0);
    }

    //rotate right function
    public void RotateRight()
    {
        myCube.transform.Rotate(-5f, 0, 0);
    }

    //rotate left function
    public void RotateLeft()
    {
       myCube.transform.Rotate(5f, 0, 0);
    }
    
     //zoom in function
    public void ZoomIn()
    {
       myCube.transform.localScale = myCube.transform.localScale + sizeChange;
    }

     //zoom out function
    public void ZoomOut()
    {
       myCube.transform.localScale = myCube.transform.localScale - sizeChange;
    }

    //reset funtion
    public void Reset()
    {
        myCube.transform.position = new Vector3 (500, 500, 0);
        myCube.transform.rotation = Quaternion.Euler (new Vector3(0, 0, 0));
        myCube.transform.localScale = Vector3.one;
    }
}
