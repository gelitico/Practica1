using UnityEngine;

public class Scale : MonoBehaviour
{
    public Vector3 escale;
    public float vel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(vel);
    }

    // Update is called once per frame
    void Update()
    {
        Transform scale = GetComponent <Transform>();
        scale.localScale += escale*Time.deltaTime;
    }
}
