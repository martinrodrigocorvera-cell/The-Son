using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Camera cam;
    public float rayDistance = 100f;
    public LayerMask layerMask;
    public bool on;
    public GameObject lightx;
    public Player player;
    public bool freeze;
    public GameObject home;
    public EffectFeature ef;
    public bool unc;

    void Update()
    {
      freeze = player.freeze;
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        
        if (Physics.Raycast(ray, out RaycastHit hit, rayDistance, layerMask))
        {
            transform.LookAt(hit.point);
        }
        else
        {
            Vector3 pointAhead = ray.origin + ray.direction * rayDistance;
            transform.LookAt(pointAhead);
        }

    if ((Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.JoystickButton4)) && (!home.activeInHierarchy) && freeze == false && unc == false)
    {
        on = !on;
        lightx.SetActive(on);
    }

    }
void OnTriggerEnter(Collider other2)
{
    if (other2.CompareTag("Finish"))
    {
      unc = true;
    }
    if (other2.CompareTag("portal2"))
    {
      unc = false;
    }
}
}
