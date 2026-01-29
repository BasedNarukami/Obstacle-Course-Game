using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or Arrow keys to move the player object.");
        Debug.Log("Have fun!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // left and right movement, as well as make it frame rate independent
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // forward and backward movement, as well as make it frame rate independent

        transform.Translate(xValue, yValue, zValue);
    }

}
