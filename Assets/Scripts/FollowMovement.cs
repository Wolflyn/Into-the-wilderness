using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public GameObject target;
    public float Sped = 5f;
    public Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * Sped);
    }

    /* void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.fixedDeltaTime * Sped);
    } */
}
