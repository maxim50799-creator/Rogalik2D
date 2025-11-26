using UnityEngine;

public interface IDamageable
{
    public int MaxHealth { get; set; }
    public int Damage {  get; set; }

    public void Attack(int gamage);
    public void GetDamage(int damage);
}
