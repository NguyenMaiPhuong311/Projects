using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Walk1(bool move)
    {
        animator.SetBool(Monsteranimation.WALKING, move);
    }
    public void MonsterAttack(int attack)
    {
        if(attack == 0)
        {
            animator.SetTrigger(Monsteranimation.SWIPING);
        }
        if(attack == 1)
        {
            animator.SetTrigger(Monsteranimation.PUNCH);
        }
    }
}
