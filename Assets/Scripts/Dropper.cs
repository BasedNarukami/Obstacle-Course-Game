using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;                //hides obstacle in air from player at the start

        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.useGravity = false;                //disables gravity at start
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myRigidBody.useGravity = true;         //enables gravity if timeToWait is more than 3 seconds
            myMeshRenderer.enabled = true;         //shows obstacle in air from player if timeToWait is more than 3 seconds
        }
    }
}
