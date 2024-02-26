using BehaviourAPI.UnityToolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 1;
    public float turnSpeed = 1;
    private bool isMoving = true;

    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (isMoving)
        {
            //transform.position += transform.forward * moveSpeed * Time.deltaTime;
            Vector3 movement = transform.forward * Time.deltaTime * agent.speed;
            agent.Move(movement);
        }
    }
}