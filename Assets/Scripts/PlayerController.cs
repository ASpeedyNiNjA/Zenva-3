using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rig;

    void FixedUpdate()
    {
        //Player Movement Code
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2 (moveInput * moveSpeed, rig.linearVelocityY);
    }
}
