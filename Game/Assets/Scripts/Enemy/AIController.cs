using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    [SerializeField] float chaseDistance = 5f;
    GameObject player;
    Animator anim;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
       if(DistanceToPlayer() < chaseDistance)
        {
            GetComponent<NavMeshAgent>().isStopped = false;
            anim.SetTrigger("Walk");
            GetComponent<NavMeshAgent>().destination = player.transform.position;
        }
        else
        {
            GetComponent<NavMeshAgent>().isStopped = true;
            anim.SetTrigger("Idle");

        }
    }

    private float DistanceToPlayer()
    {
        
        return Vector3.Distance(player.transform.position, transform.position);
    }
}
