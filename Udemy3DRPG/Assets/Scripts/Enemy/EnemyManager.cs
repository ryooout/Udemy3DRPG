using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyManager : HumanManager
{
    public Transform target;
    //追跡
    NavMeshAgent agent;
    Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        //敵の目的地を、プレイヤーの位置に設定。
        agent.destination = target.position;
        HideColliderWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
        animator.SetFloat("Distance", agent.remainingDistance);
    }
    //武器の判定の有無
   protected override void HideColliderWeapon()
   {
        base.HideColliderWeapon();
   }

    protected override void ShowColliderWeapon()
    {
        base.ShowColliderWeapon();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        //ダメージを与えるものにぶつかったら
        Damager damager = other.GetComponent<Damager>();
        if(damager!=null)
        {
            //ダメージを与えるものにぶつかったら
            Debug.Log("敵はダメージを受ける");
            animator.SetTrigger("Hurt");
        }
    }
}
