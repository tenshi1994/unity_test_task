using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public string[] AttackAnimList = { "Jab", "Hikick", "Spinkick" };
    Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {

    }


    public void Attack(int attackIndex)
    {
        _anim.SetTrigger(AttackAnimList[ attackIndex ]);
    }

    public void Reset()
    {
        _anim.SetTrigger("Reset");
    }
}
