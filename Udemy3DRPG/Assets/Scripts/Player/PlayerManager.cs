using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerManager : HumanManager
{
    float x;
    float z;
   public float moveSpeed ;
    int maxHp = 100;
    int hp = 100;

    Rigidbody rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        HideColliderWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        //キーボード入力
     x = Input.GetAxisRaw("Horizontal");
     z = Input.GetAxisRaw("Vertical");
       
        //攻撃入力:Spaceボタンを押したら
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("攻撃");
            animator.SetTrigger("Attack");
        }
    }
    private void FixedUpdate()
    {
        Vector3 direction = transform.position+ new Vector3(x, 0, z) * moveSpeed;
        transform.LookAt(direction);
        //速度設定
        rb.velocity = new Vector3(x, 0, z)*moveSpeed;
        animator.SetFloat("Speed",rb.velocity.magnitude);
                                          //magnitudeをつけることによって
                                          //大きさを取得することが出来る
                                           //velocityの大きさ
    }
    protected override void Damage(int damage)
    {
        hp -= damage;
        if(hp<=0)
        {
            hp = 0;
        }
        Debug.Log("残りHP:" + hp);
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
        if (damager != null)
        {
            //ダメージを与えるものにぶつかったら
            Debug.Log("Playerはダメージを受ける");
            animator.SetTrigger("Hurt");
            Damage(damager.damage);
        }
    }
}
