using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : HumanManager
{
    private float x;
    private float z;
    public float moveSpeed ;
    [SerializeField] PlayerUiManager playerUiManager;
    [SerializeField] private Transform target;
    Rigidbody rb;
    public int maxStamina = 100;
    int stamina;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        stamina = maxStamina;
        hp = maxHp;
        playerUiManager.Init(this);
        HideColliderWeapon();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //入力をうけつけさせないときはReturnで返す。
        if(isDie)
        {
            return;
        }
        //キーボード入力
     x = Input.GetAxisRaw("Horizontal");
     z = Input.GetAxisRaw("Vertical");
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        IncreseStamina();
    }
    private void FixedUpdate()
    {
        if (isDie)
        {
            return;
        }
        Vector3 direction = transform.position+ new Vector3(x, 0, z) * moveSpeed;
        transform.LookAt(direction);
        //速度設定
        rb.velocity = new Vector3(x, 0, z)*moveSpeed;
        animator.SetFloat("Speed",rb.velocity.magnitude);
                                          //magnitudeをつけることによって
                                          //大きさを取得することが出来る
                                           //velocityの大きさ
    }
    void IncreseStamina()
    {
        float span = 3.0f;
        time += Time.deltaTime;
        if(span<=time)
        {
            //スタミナの自動回復
            stamina++;
        }
        if (stamina >= maxStamina)
        {
            stamina = maxStamina;
        }
        playerUiManager.UpdateStamina(stamina);
    }
    /// <summary>攻撃</summary>
    void Attack()
    {
        if(stamina >=20)
        {
            stamina -= 40;
            playerUiManager.UpdateStamina(stamina);
            LookAtTarget();
            animator.SetTrigger("Attack");
        }
    }
    /// <summary>敵の方向を向く</summary>
    void LookAtTarget()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance<=2f)
        {
            transform.LookAt(target);
        }
    }
    /// <summary>ダメージ </summary>
    /// <param name="damage"></param>
    protected override void Damage(int damage)
    {
        hp -= damage;
        playerUiManager.UpdateHp(hp);
        base.Damage(damage);
        if(hp<=0)
        {
            rb.velocity = Vector3.zero;
        }
    }
    //武器の判定の有無
    public override void HideColliderWeapon()
    {
        base.HideColliderWeapon();
    }

    protected override void ShowColliderWeapon()
    {
        base.ShowColliderWeapon();
    }
    protected override void OnTriggerEnter(Collider other)
    {
        if (isDie)
        {
            return;
        }
        base.OnTriggerEnter(other);
    }
}
