using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.C))
        {
            if (!cKeyPressed)
            {
                ToggleCursorVisibility();
                cKeyPressed = true;
            }
            else
            {
                cKeyPressed = false;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.C)){
                ToggleCursorVisibility();
        }

        if (Cursor.visible == false)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            playerBody.Rotate(Vector3.up * mouseX);
        }
    

    }


    void ToggleCursorVisibility()
    {
        // Toggle cursor visibility and lock state
        Cursor.visible = !Cursor.visible;

        if (Cursor.visible)
        {
            Cursor.lockState = CursorLockMode.None; // Cursor is unlocked and visible
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // Cursor is invisible and locked to the center
        }
    }

    /*void HideCursor()
    {
        // Hide and lock the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }*/

}