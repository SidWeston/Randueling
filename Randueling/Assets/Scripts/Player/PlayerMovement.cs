using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 vMovement;
    private Vector2 vMouseVector;
    private Vector3 velocity;

    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private float mouseSensitivity = 100.0f;

    [SerializeField] private CharacterController playerController;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float fMoveSpeed;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Left and Right(A and D) movement
        //Vector3 vMovementVec = new Vector3(vMovement.x, 0, vMovement.y);
        Vector3 vMovementVector = transform.right * vMovement.x + transform.forward * vMovement.y;
        playerController.Move(vMovementVector * fMoveSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 2, 0);

        xRotation -= vMouseVector.y;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += vMouseVector.x;
        yRotation = Mathf.Clamp(yRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        vMovement = context.ReadValue<Vector2>();
    }

    public void OnMouse(InputAction.CallbackContext context)
    {
        vMouseVector = context.ReadValue<Vector2>();
    }

}
