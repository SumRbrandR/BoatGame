using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WindManager
{
    public static WindManager instance = new WindManager();
    Vector3 direction;
    float speed;

    public Vector3 Wind;// = direction * speed;
}
