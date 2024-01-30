using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ship : MonoBehaviour
{
    public Vector3 inputVector;
    private Cannon[] armament = new Cannon[] { };
    public bool firePort;
    [Range(0, 1)]
    public float sailAmount;
    public float shipSpeed;
    public float hullDamage;
    public float sailDamage;
    WindManager windManager;
    public float windSlower = 0.01f;

    public float angle;

    private void Start()
    {
        windManager = FindObjectOfType<WindManager>();

        armament = GetComponentsInChildren<Cannon>();
    }

    public void Fire()
    {
        foreach (Cannon gun in armament)
        {
            gun.Fire();
        }
    }
    public void Turn(Vector3 inputVector)
    {
        transform.Rotate(inputVector);
    }
    public void ReactToWind()
    {

        Vector3 forward = transform.forward;
        angle = Vector3.SignedAngle(forward, windManager.Wind(), Vector3.up) ;
        float speedMultiplier;

        speedMultiplier = Mathf.Abs((1f/4f)*angle); // y=mx+b


        

        transform.position += (windManager.Wind() * windSlower) + forward * sailAmount * shipSpeed * speedMultiplier * Time.deltaTime;
    }
    public void SetSail(float amount)
    {
        sailAmount += amount;
        sailAmount = Mathf.Clamp(sailAmount, 0, 1);
    }


}
