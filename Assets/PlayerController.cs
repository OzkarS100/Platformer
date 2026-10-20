using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   Rigidbody2D rb; // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnJump(InputValue value)
    {
        print("JUMP");
        rb.AddForce(Vector2.up * 2000);
    }
}
