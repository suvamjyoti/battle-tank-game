﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateMoveToStart : EnemyTankState
{
    private EnemyManager enemyManager;
    [SerializeField]private NavMeshAgent agent;

    private Coroutine homeComing;
    
    public override void OnEnterState(){
        base.OnEnterState();
        enemyManager = GetComponent<EnemyManager>();
        agent.SetDestination(enemyManager.startingPosition);
    }

    public override void OnExitState(){
        base.OnExitState();
    }

}