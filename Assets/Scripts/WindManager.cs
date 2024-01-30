using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    
    [SerializeField]
    public Vector3 direction;
    [SerializeField]
    public float speed;
    [SerializeField]
    public float windAngle;


    private void Update()
    {
        Debug.DrawRay(transform.position, Wind());
    }

    public Vector3 Wind()
    {
        transform.rotation = Quaternion.AngleAxis(windAngle, Vector3.up);
        return transform.forward * speed;
    }
}
