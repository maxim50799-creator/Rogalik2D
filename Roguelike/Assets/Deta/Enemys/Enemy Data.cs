using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField][Min(0)] private int _health;
    [SerializeField][Min(0)] private int _damage;
    [SerializeField][Min(0)] private int _armor;
    [SerializeField][Min(0)] private float _speed;
    [SerializeField][Min(0)] private float _attackRange;
    [SerializeField][Min(0)] private float _attackDelay;
    [SerializeField][Min(0)] private float _potrolingDelay;
    [SerializeField][Min(0)] private float _attackTime;
    [SerializeField][Min(0)] private EnemyState _state;

    public string Name => _name;
    public int Health => _health;
    public int Damage => _damage;
    public int Armor => _armor;
    public float Speed => _speed;
    public float AttackRange => _attackRange;
    public float AttackDelay => _attackDelay;
    public float AttackTime => _attackTime;
    public float PatrolingDelay => _potrolingDelay;
}

public enum EnemyState
{ 
    Idle, Patroling, Pursue, Attacking, Dead
}