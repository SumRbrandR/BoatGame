using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship : MonoBehaviour 
{
    public Vector3 inputVector;
    private Cannon[] armament = new Cannon[] { };
    public bool firePort;
    [Range(0,1)]
    public float sailAmount;
    public float shipSpeed;
    public float hullDamage;
    public float sailDamage;

    private void Start()
    {
        armament = GetComponentsInChildren<Cannon>();
    }

    void Fire() 
    {
        foreach (Cannon gun in armament)
        {
            gun.Fire();
        }
    }
    void Turn(Vector3 inputVector) 
    {
        transform.Rotate(inputVector);
    }
    void ReactToWind() 
    {
        //this is unfinshed
        transform.Translate(transform.forward + WindManager.instance.Wind);
        //Comment from GANON
    }
}
