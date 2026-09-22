using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public float vel;
    public Transform jugador;
    void Start()
    {
        
    }

    void Update()
    {
        if (jugador != null)
        {
            Vector3 direccion = jugador.position - transform.position;

            transform.position += direccion * vel * Time.deltaTime;
            if (direccion != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(direccion);
            }
        }
    }
}
