using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    Transform target = null;
    float enemyMoveSpeed = 0.1f;
    NavMeshAgent agent;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            target = col.gameObject.transform;
            Debug.Log("Box Enemy : Target found");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        target = null;
        Debug.Log("Box Enemy : Target lost");
    }
}
