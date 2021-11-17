using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public GameObject playerManager;

    private Vector2 vMovement;
    private Vector2 vMouseVector;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    [SerializeField] [Range(0.1f,1.0f)] private float mouseSensitivity = 0.1f;

    [SerializeField] private CharacterController playerController;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float fMoveSpeed;

    public float zLocationLock;
    public bool invertXClamp = false;
    public bool rotationEnabled = false;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Left and Right(A and D) movement
        Vector3 vMovementVector = transform.right * vMovement.x + transform.forward * vMovement.y;
        playerController.Move(vMovementVector * fMoveSpeed * Time.deltaTime);
        //Keeps player on single axis
        transform.position = new Vector3(transform.position.x, 2, zLocationLock);

        //Camera rotation section
        if(rotationEnabled)
        {
            xRotation -= vMouseVector.y * mouseSensitivity;
            xRotation = Mathf.Clamp(xRotation, -90, 90);
            yRotation += vMouseVector.x * mouseSensitivity;
            if (!invertXClamp)
            {
                yRotation = Mathf.Clamp(yRotation, 90, 270);
            }
            else if (invertXClamp)
            {
                yRotation = Mathf.Clamp(yRotation, 270, 450);
            }

            transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        }

    }

    //input functions return a value from player input
    public void OnMove(InputAction.CallbackContext context)
    {
        vMovement = context.ReadValue<Vector2>();
    }

    public void OnMouse(InputAction.CallbackContext context)
    {
        vMouseVector = context.ReadValue<Vector2>();
    }

}
