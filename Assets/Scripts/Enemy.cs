using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.Play("zombie_walk_forward");
        agent = GetComponent<NavMeshAgent>();
        if (target == null) target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
        
    }
}
