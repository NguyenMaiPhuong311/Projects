using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterMovement : MonoBehaviour
{
  


    private Rigidbody rb;
    private Transform playerTransform;
    private MonsterAnimation monsterAnimation;


    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float attackDistance =5f;
    [SerializeField] private float defaultAttackTimer = 2f;
    private float timer;
    private bool followPlayer ;
    private bool attackPlayer;

    // Start is called before the first frame update
    void Start()
    {
        

        rb = GetComponent<Rigidbody>();
        playerTransform = GameObject.FindGameObjectWithTag(Tags.PLAYER_TAG).transform;
        followPlayer = true;
        attackPlayer = false;

        monsterAnimation= GetComponentInChildren<MonsterAnimation>();
        timer = defaultAttackTimer;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void FixedUpdate()
    {
        FollowPlayer();
    }
    void FollowPlayer()
    {
        if (!followPlayer) return;
        

        if(Vector3.Distance(transform.position, playerTransform.position) > attackDistance&& Vector3.Distance(transform.position, playerTransform.position)<20f)
        {

            transform.LookAt(playerTransform);
           rb.velocity = transform.forward * moveSpeed;
           monsterAnimation.Walk1(true);


       }
       if(Vector3.Distance(transform.position, playerTransform.position) <= attackDistance)
        {
          rb.velocity = Vector3.zero;
           followPlayer = false;
           monsterAnimation.Walk1(false);
           attackPlayer = true;
        }
    }
    
    
    void Attack()
    {
        if(!attackPlayer) return;
      
        timer += Time.deltaTime;

        if (timer > defaultAttackTimer)
        {
            monsterAnimation.MonsterAttack(Random.Range(0,2));
            timer = 0;
           
        }
        
        if (Vector3.Distance(transform.position, playerTransform.position) > (attackDistance + 1))
        {
            followPlayer=true;
            attackPlayer = false;
        }
    }
   
}
