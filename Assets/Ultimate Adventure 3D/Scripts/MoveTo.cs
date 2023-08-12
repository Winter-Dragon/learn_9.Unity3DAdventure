using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField, Header("Скорость передвижения")] private float speed;
    [SerializeField, Header("Целевые координаты")] private Transform target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
