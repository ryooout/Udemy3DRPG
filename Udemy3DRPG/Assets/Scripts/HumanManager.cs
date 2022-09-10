using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    //baseクラスを使うと、継承元にアクセスすることが可能
    public Collider weaponCollider;
    int maxHp = 100;
    int hp = 100;
    Animator animator;
    protected virtual void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
        Debug.Log("残りHP:" + hp);
    }
    //武器の判定の有無
    protected virtual void HideColliderWeapon()
    {
        weaponCollider.enabled = false;
    }

    protected virtual void ShowColliderWeapon()
    {
        weaponCollider.enabled = true;
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        //ダメージを与えるものにぶつかったら
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            //ダメージを与えるものにぶつかったら
            Debug.Log("Playerはダメージを受ける");
            animator.SetTrigger("Hurt");
            Damage(damager.damage);
        }
    }
}
