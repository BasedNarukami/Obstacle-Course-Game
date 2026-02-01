using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 2f; //rotation around y-axis
    [SerializeField] float zAngle = 0f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
