using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Ship))]
public class ShipController : MonoBehaviour
{
    Ship ship;
    PlayerShipControls playerInput;

    private void Awake()
    {
        ship = GetComponent<Ship>();
        playerInput = new();
        playerInput.Helm.Enable();
        playerInput.Helm.SailAmount.performed += Sail;

    }
    private void Update()
    {
        
        ship.Turn(new Vector3(0, playerInput.Helm.Turn.ReadValue<float>(), 0));
        ship.ReactToWind();
    }

    void Sail(InputAction.CallbackContext context)
    {
        float amount = 0.25f * playerInput.Helm.SailAmount.ReadValue<float>();
        //amount = Mathf.Clamp(amount,0,1);
        ship.SetSail(amount) ;
    }
    
}
