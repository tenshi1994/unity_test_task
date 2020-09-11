using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerAnimation _anim;
    [SerializeField] private float _attackResetTime = 1f;
    private int _attackNo;
    private float _reset;
    void Start()
    {
        _anim = GetComponent<PlayerAnimation>();
    }

    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            _anim.Attack( _attackNo );
            _attackNo++;
            _reset = 0f;
        }

        if (_attackNo > 0)
        {
            _reset += Time.deltaTime;
            if (_reset > _attackResetTime)
            {
                _anim.Reset();
                _attackNo = 0;
            }
        }


        if (_attackNo == _anim.AttackAnimList.Length)
        {
            _attackNo = 0;
        }
    }
}
