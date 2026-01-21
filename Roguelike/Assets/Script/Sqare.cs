using UnityEngine;

public class Sqare : Enemy
{
    [SerializeField] private Transform[] _patrolingPoints;
    private int _patrolingIndex = 0;
    private bool _isMoving = false;
    private float _patrolingTime = 0f;
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

    public void Update()
    {
        OnPatroling();
    }

    public override void OnPatroling()
    {
        float distance = Vector3.Distance(transform.position, _patrolingPoints[_patrolingIndex].position);
        if (distance < 0.1f)
        {
            _isMoving = false;
        }
        else
        {
            _isMoving = true;
        }

        if(_isMoving)
        {
            Vector3 curentPos = _patrolingPoints[_patrolingIndex].position;
            Vector3 nextPos = _patrolingPoints[(_patrolingIndex + 1) % _patrolingPoints.Length].position;
            transform.position = Vector3.Lerp(curentPos, nextPos, _enemyData.Speed * Time.deltaTime);
        }
        else
        {
            _patrolingTime += Time.deltaTime;
            if(_patrolingTime > _enemyData.PatrolingDelay)
            {
                _isMoving = true;
                _patrolingTime = 0f;
                _patrolingIndex = (_patrolingIndex + 1) % _patrolingPoints.Length;
                _patrolingIndex += 1;
                if(_patrolingIndex > _patrolingPoints.Length)
                {
                    _patrolingIndex = 0;
                }
            }
        }
    }
}
