using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : TopCharacter
{
    [SerializeField]
    GameObject target;
    public enum States
    {
        idle,
        berserk,
        coward
    }
    [SerializeField]
    States state = 0;

    [SerializeField]
    int lives = 3;

    protected override void MyInput()
    {
        switch (state)
        {
            case States.idle:
                base.move = Vector2.zero;
                break;
            case States.berserk:
                base.move = (target.transform.position - transform.position).normalized;
                break;
            case States.coward:
                base.move = (transform.position - target.transform.position ).normalized;
                break;

        }
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            state = States.berserk;
        }
    }

}
