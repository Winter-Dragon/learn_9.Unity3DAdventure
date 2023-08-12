using UnityEngine;

public class LocalMove : MonoBehaviour
{
    [SerializeField, Header("Объект перемещения")] private Transform target;
    [SerializeField, Header("Скорость перемещения")] private float speed;
    [SerializeField, Header("Целевые координаты")] private Vector3 targetPosition;

    private void Update()
    {
        if (target != null)
        {
            target.localPosition = Vector3.MoveTowards(target.localPosition, targetPosition, speed * Time.deltaTime);
        }
    }
}
