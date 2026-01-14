using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollower : MonoBehaviour
{

    [SerializeField] private Transform _target;
    [SerializeField][Range(0.1f, 10)] float _speed;
    [SerializeField] private float _zOffest = -10f;
    
    void Start()
    {
        transform.position = _target.position + new Vector3(0, 0, _zOffest);
    }

    void LateUpdete()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = _target.position;
        Vector3 newPos = Vector3.Lerp(startPos, endPos, _speed * Time.deltaTime);
        transform.position = new Vector3(newPos.x, newPos.y, _zOffest);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Hit trigger");
    }
}
