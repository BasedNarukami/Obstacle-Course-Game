using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player; //get position of player
    [SerializeField] float projectileSpeed = 5.0f;
    Vector3 playerPosition;
    
    void Start()
    {
        playerPosition = player.transform.position; // store player position at start
        DestroyWhenReached();
    }

    
    void Update()
    {
        MoveTowardsPlayerPosition();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void MoveTowardsPlayerPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime); // move towards stored player position
    }
}
