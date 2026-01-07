using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rig;
    public float jumpForce;

    void FixedUpdate()
    {
        //Player Movement Code
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2 (moveInput * moveSpeed, rig.linearVelocityY);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
