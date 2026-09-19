using UnityEngine;
using UnityEngine.InputSystem;

public class NavigateByInput : MonoBehaviour
{
    public InputActionAsset inputActions;
    public float moveSpeed;
    InputAction moveAction;
    CharacterController controller;
    Transform transform;
    
    
    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        transform = GetComponent<Transform>();

        if (inputActions != null)
        {
            moveAction = inputActions.FindAction("Move");
        }
    }

    void Update()
    {
        if (moveAction != null)
        {
            Vector2 inputValue = moveAction.ReadValue<Vector2>();
            Vector3 direction = new Vector3(inputValue.x, 0, inputValue.y);
            if (controller != null)
            {
                controller.Move(direction * moveSpeed * Time.deltaTime);
            }

            if (transform != null)
            {
                transform.LookAt(transform.position + direction);
            }
        }
    }
}
