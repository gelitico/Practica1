using UnityEngine;

public class ProjSpawner : MonoBehaviour
{
    public float strength;
    public GameObject projectileTemplate;
    Transform transform;
    public float coldon;
    public float taimer;


    void Fire()
    {
        transform = GetComponent<Transform>();
        GameObject newProjectile = Instantiate(projectileTemplate, transform.position, Quaternion.identity);
        Rigidbody rigidbody = newProjectile.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * strength, ForceMode.Impulse);
    }

    void Start()
    {
        
    }

    void Update()
    {
        taimer += Time.deltaTime;
        if (taimer >= coldon)
        {
            taimer = 0;
            Fire();
        }
    }
}
