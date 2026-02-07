using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class MovementCam : MonoBehaviour
{
    public float mouseSensitivity;
    public Transform playerBody;

    float xRotation;
    float yRotation;
    public GameObject spooky;
    public bool freeze;
    public Player player;
    public GameObject menu;
    public GameObject gam;
    public GameObject home;
    public GameObject wino;
    public bool flip;
    public GameObject intr1;
    public GameObject intr2;
    public GameObject intr3;

    public float cameraRotateSpeed = 5f;

    public Material retroMaterial;

    public bool ign;

    void Start()
    {
       spooky.SetActive(true);
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (retroMaterial != null)
            Graphics.Blit(src, dest, retroMaterial);
        else
            Graphics.Blit(src, dest);
    }

    void Update()
    {
    if(ign == false)
    {
        freeze = player.freeze;
        if(freeze == false)
        {
     if(!menu.activeInHierarchy && !gam.activeInHierarchy && !wino.activeInHierarchy && !home.activeInHierarchy)
     {
        Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
     }
     if(menu.activeInHierarchy)
     {
        Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
     }
     if(gam.activeInHierarchy)
     {
        Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
     }
     if(wino.activeInHierarchy)
     {
        Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
     }
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float joystickX = 0f;
        float joystickY = 0f;

        if (Gamepad.current != null)
        {
            joystickX = Gamepad.current.rightStick.x.ReadValue();
            joystickY = Gamepad.current.rightStick.y.ReadValue();
        }
     
        float combinedX = (mouseX + joystickX) * mouseSensitivity * Time.deltaTime * 2.5f;
        float combinedY = (mouseY + joystickY) * mouseSensitivity * Time.deltaTime * 2.5f;

        xRotation -= combinedY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        if(flip == false)
        {
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        }
        if(flip == true)
        {
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 180f);
        }
        playerBody.Rotate(Vector3.up * combinedX);
        }
    }
    }
}
