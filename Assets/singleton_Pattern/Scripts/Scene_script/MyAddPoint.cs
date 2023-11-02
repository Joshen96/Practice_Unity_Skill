using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAddPoint : MonoBehaviour
{
   [SerializeField]
    private int point = 0;

    void Start()
    {
        Myfunc();
    }


    void Myfunc()
    {
        PointManager.Instance().AddPoint(point);
        int myResult = PointManager.Instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }


}
