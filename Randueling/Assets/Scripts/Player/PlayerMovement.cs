using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private float fMovement;
    private Vector2 vMouseVector;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private float mouseSensitivity = 100.0f;


    [SerializeField] private CharacterController playerController;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float fGravity = -9.8f;
    [SerializeField] private float fMoveSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Left and Right(A and D) movement
        Vector3 vMovement = new Vector3(fMovement, 0, 0);
        playerController.Move(vMovement * fMoveSpeed * Time.deltaTime);

        xRotation -= vMouseVector.y;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += vMouseVector.x;
        yRotation = Mathf.Clamp(yRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

    }
    public void OnMove(InputAction.CallbackContext context)
    {
        fMovement = context.ReadValue<float>();
    }

    public void OnMouse(InputAction.CallbackContext context)
    {
        vMouseVector = context.ReadValue<Vector2>();
    }

}
