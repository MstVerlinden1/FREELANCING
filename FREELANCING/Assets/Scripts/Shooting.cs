using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("References")]
    private PlayerControls inputActions;
    private Camera cam;

    private void OnEnable()
    {
        inputActions = new PlayerControls();
        inputActions.PlayerInput.Shoot.Enable();
        inputActions.PlayerInput.Shoot.performed += _ => Shoot();
        cam = Camera.main;
    }
    private void OnDisable()
    {
        inputActions.PlayerInput.Shoot.Disable();
    }
    private void Shoot()
    {
        //shoot out raycast from the gun in the direction of the cam return the information to hit
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit))
        {
            //if whatever we hit has the target script apply damage from the object
            if (hit.transform.GetComponent<Target>())
            {
                hit.transform.GetComponent<Target>().TakeDamage(50);
            }
        }
    }
}
