using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public GameObject target;
    public float Sped = 5f;
    public Vector3 offset;
    private Round round;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject.Find("Enemy Spawner").TryGetComponent<EnemySpawn>(out EnemySpawn Spawner);

        target = GameObject.Find("Player");
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * Sped);
        GameObject.Find("Player").TryGetComponent<Round>(out round);



    }
    // Update is called once per frame
    void Update()
    {
         
        if (round.pause == false)
        {
         transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * Sped);
        }
    }

    /* void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.fixedDeltaTime * Sped);
    } */
}
