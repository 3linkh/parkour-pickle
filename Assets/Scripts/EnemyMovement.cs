using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    void FixedUpdate()
    {
        Move();
    }
    void Update()
    {
        
    }

    void Move()
    {
        navMeshAgent.SetDestination(target.position);
    }
}
