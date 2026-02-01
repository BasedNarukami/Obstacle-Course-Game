using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") // Check if the object collided with has the tag "Player and change color to black"
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit"; // Change the tag of the object to "Hit" to avoid multiple color changes.
        }
    }
}
