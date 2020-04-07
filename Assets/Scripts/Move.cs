using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Move : MonoBehaviour
{
    private Camera cam;

    public NavMeshAgent agent;

    //public ThirdPersonCharacter character;

    public Rigidbody rb;
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("clicked");

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Debug.Log(Physics.Raycast(ray, out hit));
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
                //Debug.Log("hit");
            }
        }

        //if (agent.remainingDistance > agent.stoppingDistance)
        //{
        //    character.Move(agent.desiredVelocity, false, false);
        //}
        //else
        //{
        //    character.Move(Vector3.zero, false, false);
        //}
    }
}
