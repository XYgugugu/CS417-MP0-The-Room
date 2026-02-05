using UnityEngine;
using UnityEngine.InputSystem;

public class TP : MonoBehaviour
{
    public Transform playerCamera;
    public InputActionReference action;
    public Vector3 destination;

    void Start()
    {
        action.action.Enable();
        action.action.performed += _ =>
        {
            if (playerCamera == null || destination == null) return;
            (destination, playerCamera.position) = (playerCamera.position, destination);
        };
    }
}
