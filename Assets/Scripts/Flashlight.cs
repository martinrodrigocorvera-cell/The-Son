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

    Vector3 targetPoint;

    if (Physics.Raycast(ray, out RaycastHit hit, rayDistance, layerMask))
    {
        targetPoint = hit.point;
    }
    else
    {
        targetPoint = ray.origin + ray.direction * rayDistance;
    }

    Vector3 originalScale = transform.localScale;

    transform.LookAt(targetPoint);

    transform.localScale = originalScale;

    if ((Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.JoystickButton4)) 
        && (!home.activeInHierarchy) && freeze == false && unc == false && player.lx == false)
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
