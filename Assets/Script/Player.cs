using UnityEngine.InputSystem;
using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using System.Collections;

public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    private Vector2 movePlayer = Vector2.zero;
    [SerializeField] private float movementSpeed;
    [HideInInspector] public bool isRunning;

    private bool die;
    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Enable();
        playerInput.Player.Movement.performed += Movement_Performed;
        playerInput.Player.Movement.canceled += Movement_Canceled;

        PlayerHealth.OnDying += PlayerHealth_OnDying;
    }
    private void Movement_Performed(InputAction.CallbackContext value)
    {
        movePlayer = movementSpeed * value.ReadValue<Vector2>();
        isRunning = true;
    }
    private void Movement_Canceled(InputAction.CallbackContext value)
    {
        movePlayer = Vector2.zero;
        isRunning = false;
    }
    private void FixedUpdate()
    {
        transform.position += (Vector3)movePlayer * Time.deltaTime;
    }
    private void PlayerHealth_OnDying()
    {
        die = true;
    }
    private void Update()
    {
        if (!die)
        {
            FollowMouseDirection followMouseDirection = GetComponentInChildren<FollowMouseDirection>();
            if (followMouseDirection != null)
            {
                FlipSprite(followMouseDirection);
            }
        }
    }
    private void FlipSprite(FollowMouseDirection followMouseDirection)
    {
        float rotateByMouseDirection = followMouseDirection.difference.x;
        float rotateY = rotateByMouseDirection > 0 ? 0 : 180;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotateY, 0));
    }
}
