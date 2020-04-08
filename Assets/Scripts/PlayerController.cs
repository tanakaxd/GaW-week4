using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    public Rigidbody rb;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
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
        //Vector3 right = transform.right * speed * Time.deltaTime * horizontal;

        transform.Translate(forward, Space.World);
        transform.Rotate(transform.up, horizontal);

        //rb.MovePosition(transform.position + forward + right);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //Debug.Log("clicked");

        //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    //Debug.Log(Physics.Raycast(ray, out hit));
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        agent.SetDestination(hit.point);
        //        //Debug.Log("hit");
        //    }
        //}

    }
}
