using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ce scrpit est commun a TOUT les ennemis. implémenter seulement les elements en communs a tout les enemis dans ce scipt
public class EnemyRoot : MonoBehaviour
{
    [Header("Stats of the enemy")]
    public int maxHp;
    public string type;
    public int baseSpeed;

    private GameObject _target;
    
    
    private int _hp;

    private void Awake()
    {
        _hp = maxHp;
        _target = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        Vector3 dir = _target.transform.position - transform.position;
        transform.Translate(dir.normalized * (baseSpeed * Time.deltaTime), Space.Self);
    }
}
