using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    static PointManager _instance = null;

    int MyPoint = 0;
    public static PointManager Instance()
    {
        return _instance;
    }
    private void Awake()
    {
        if(_instance==null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }
    public void AddPoint(int num)
    {
        MyPoint += num;
    }
    public int GetPoint()
    {
        return MyPoint;
    }
}
