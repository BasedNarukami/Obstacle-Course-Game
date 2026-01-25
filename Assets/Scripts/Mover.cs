using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // left and right movement, as well as make it frame rate independent
       float yValue = 0f;
       float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // forward and backward movement, as well as make it frame rate independent

       transform.Translate(xValue, yValue, zValue);
    }
}
