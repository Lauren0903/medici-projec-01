using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController cc;
    public float speed = 5;
    public float MoveSpeed;
    Vector3 lookDirection;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    public float jumpPower = 10;
    public float gravity = -9.81f;
    float yVelocity;
    public int jumpCount;
    public int maxJumpCount = 2;

    void Update()
    {

        if (cc.isGrounded)
        {
            jumpCount = 0;
        }
        else
        {
            yVelocity += gravity * Time.deltaTime;
        }

        if (jumpCount < maxJumpCount && Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
            jumpCount++;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        dir.Normalize();
        Vector3 velocity = dir * speed;
        velocity.y = yVelocity;

        cc.Move(velocity * Time.deltaTime);

        lookDirection = v * Vector3.forward + h * Vector3.right;

        this.transform.rotation = Quaternion.LookRotation(lookDirection);
        this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);

    }
}
