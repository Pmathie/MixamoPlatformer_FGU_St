using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;
    private Vector3 target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointB.position;
        transform.position = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
    }
}
