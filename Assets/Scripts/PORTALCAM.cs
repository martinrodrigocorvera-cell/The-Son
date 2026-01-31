using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PORTALCAM : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;
private Vector3 localOffset;
    public float zFactor = -0.5f;


    void Start()
    {
        localOffset = transform.position - portal.position;
    }

   void LateUpdate()
    {
        Quaternion rotDiff = otherPortal.rotation * Quaternion.Inverse(portal.rotation);
        transform.rotation = rotDiff * playerCamera.rotation;
        Vector3 localOffset = portal.InverseTransformPoint(playerCamera.position);
        localOffset.x = 0f;
        localOffset.y = 0f;
        localOffset.z *= zFactor;
        Vector3 newPos = otherPortal.TransformPoint(localOffset);
        transform.position = newPos;
    }
}
