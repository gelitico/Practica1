using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform playerFollowPoint;
    public InputActionAsset inputActions;
    InputAction interactAction;
    public float Speed;
    public bool estaSiguiendo = false;
    Transform transform;
    public float distanciaHit = 2.0f;
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
        transform = GetComponent<Transform>();

        if (inputActions != null)
        {
            interactAction = inputActions.FindAction("Interact");
        }
    }
    void Update()
    {
            if (interactAction != null && interactAction.WasPressedThisFrame() && playerFollowPoint != null)
            {
                if (estaSiguiendo)
                {
                    estaSiguiendo = false;
                }
                else
                {
                    float distanciaActual = Vector3.Distance(transform.position, playerFollowPoint.position);
                    if (distanciaActual <= distanciaHit)
                    {
                        estaSiguiendo = true;
                    }
                }

            }
            if (estaSiguiendo && playerFollowPoint != null)
            {
            transform.position = Vector3.Lerp(transform.position, playerFollowPoint.position, Speed * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, playerFollowPoint.rotation, Speed * Time.deltaTime);
            }
    }
}
