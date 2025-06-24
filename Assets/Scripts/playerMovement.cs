using UnityEngine;

using UnityEngine.Scripting.APIUpdating;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    public float speed = 5f;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        animator.SetFloat("Speed", moveDirection.sqrMagnitude);
        if (moveDirection.x != 0)
        {
            SetFacingDirection(moveDirection.x);
        }  
    }
    private void SetFacingDirection(float x)
    {
        float scaleX = Mathf.Abs(transform.localScale.x);

        if (x < -0.01f)
            scaleX = -scaleX;
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
}
    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * speed;
    }
}
