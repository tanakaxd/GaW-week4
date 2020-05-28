using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;


public class Move : MonoBehaviour
{
    //private Camera cam;

    public NavMeshAgent agent;
    //public ThirdPersonCharacter character;
    public List<GameObject> wayPointsSystem = new List<GameObject>();

    [SerializeField] private int[] genes;
    private int currentWayPoint = 0;
    private Transform currentTarget;

    //public ThirdPersonCharacter character;

    //public Rigidbody rb;
    private void Awake()
    {
        for (int i = 0; i < genes.Length; i++)
        {
            genes[i] = Random.Range(0, 4);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        //agent.updateRotation = false;


        //cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        currentTarget = wayPointsSystem[currentWayPoint].transform.GetChild(genes[currentWayPoint]);
        agent.SetDestination(currentTarget.position);
    }

    // Update is called once per frame
    private void Update()
    {
        //MoveToWayPoint();
        ChangeWayPoint();
    }

    private void MoveToWayPoint()
    {
        //if (agent.remainingDistance > agent.stoppingDistance)
        //{
        //    character.Move(agent.desiredVelocity, false, false);
        //}
        //else
        //{
        //    character.Move(Vector3.zero, false, false);
        //}
    }

    private void ChangeWayPoint()
    {
        //if (!agent.pathPending && agent.remainingDistance < 0.5f)
        if (!agent.pathPending && agent.remainingDistance < agent.stoppingDistance) //!agent.pathPendingが重要

        {
            currentWayPoint++;
            if (currentWayPoint >= wayPointsSystem.Count)
                currentWayPoint = 0;
            //Debug.Log(currentWayPoint);
            //Debug.Log(genes[currentWayPoint]);
            //Debug.Log(wayPointsSystem[currentWayPoint].name);
            currentTarget = wayPointsSystem[currentWayPoint].transform.GetChild(genes[currentWayPoint]);
            //Debug.Log(currentTarget.position);
            agent.SetDestination(currentTarget.position);
        }
    }
}