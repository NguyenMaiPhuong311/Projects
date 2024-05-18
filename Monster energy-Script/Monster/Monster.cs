using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public GameObject player;
    Animator animator;

    NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG);
        nav = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.transform.position);
        if (nav.velocity.x ==0 && nav.velocity.y == 0 && nav.velocity.z == 0)
        {
            animator.SetBool("walk", false);
        }
        else
        {
            animator.SetBool("walk", true);
        }
    }
}
