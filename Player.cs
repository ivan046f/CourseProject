using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rigidBody;
    private SpriteRenderer sprite;
    private Animator animator;
    private Vector2 input;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Rotation();
        Animations();
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + input * speed * Time.fixedDeltaTime);
    }
    private void Rotation()
    {
        if (input.x > 0)
            sprite.flipX = false;
        if (input.x < 0)
            sprite.flipX = true;
    }
    private void Animations()
    {
        if (input.x != 0 || input.y != 0)
            animator.SetBool("IsRunning", true);
        else
            animator.SetBool("IsRunning", false);

    }
}
