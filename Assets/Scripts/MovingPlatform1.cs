using UnityEngine;

public class MovingPlatform1 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;
    private Transform target;
    public bool PlayerOn = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = pointB;
        transform.position = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerOn)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            target = pointB;
        }else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            target = pointA;
        }
        
    }
}
