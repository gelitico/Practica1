using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 direction;
    public float vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(vel);
    }

    // Update is called once per frame
    void Update()
    {
        Transform transformar = GetComponent <Transform>();
        transformar.position += direction * Time.deltaTime;
    }
}
