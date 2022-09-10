using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int hp;

    public void Attack()
    {
        Debug.Log("攻撃");
    }

    public void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
    }
}
