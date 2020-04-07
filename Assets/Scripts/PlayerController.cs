using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 forward = transform.forward * speed * Time.deltaTime * vertical;
        Vector3 right = transform.right * speed * Time.deltaTime * horizontal;

        rb.MovePosition(transform.position + forward + right);
    }
}
