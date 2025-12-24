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
    [SerializeField][Min(0)] private float _attackTime;
    [SerializeField][Min(0)] private EnemyState _state;

    public string Name => _name;
    private int Health => _health;
    private int Armor => _armor;
    private int Speed => _speed;
    private int AttackRange => _attackRange;
    private float AttackDelay => _attackDelay;
    private float AttackTime => _attackTime;
}

public enum EnemyState
{ 
    Idle, Patroling, Aggresive, Attacking, Dead
}