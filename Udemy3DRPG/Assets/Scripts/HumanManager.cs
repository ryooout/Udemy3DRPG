using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HumanManager : MonoBehaviour
{
    //baseクラスを使うと、継承元にアクセスすることが可能
    [SerializeField]protected Collider weaponCollider;
    public int maxHp = 100;
    public int hp = 100;
    protected bool isDie;
    [SerializeField]protected Animator animator;
     Rigidbody rb;
    private void Start()
    {
        hp = maxHp;
        rb = GetComponent<Rigidbody>();
    }
    //武器の判定の有無
    public virtual void HideColliderWeapon()
    {
        weaponCollider.enabled = false;
    }

    protected virtual void ShowColliderWeapon()
    {
        weaponCollider.enabled = true;
    }
    protected virtual void Damage(int damage)
    {
        if(isDie)
        {
            return;
        }
        if (hp <= 0)
        {
            hp = 0;
            animator.SetTrigger("Die");
            isDie = true;
            //死んだあと動かないように
            HideColliderWeapon();
        }
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        //ダメージを与えるものにぶつかったら
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            animator.SetTrigger("Hurt");
            Damage(damager.damage);
        }
    }
}
