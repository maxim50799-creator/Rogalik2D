using UnityEngine;

public class Sqare : Enemy
{
    [SerializeField] private EnemyData _enemyData;
    public int MaxHealth { get; set; }
    public int Damage { get; set; }
    public override void Attack(IDamageable target, int damage)
    {
        target.GetDamage(damage);
    }

    public override void GetDamage(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6) 
        {
            collision.GetComponent<IDamageable>().GetDamage(_damage);
        }
    }
}
