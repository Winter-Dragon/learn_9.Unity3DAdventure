using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField, Header("Цель вращения")] private Transform target;
    [SerializeField, Header("Скорость вращения")] private float speed;
    [SerializeField, Header("Целевые координаты")] private Vector3 targetRotate;

    private void Update()
    {
        target.localRotation = Quaternion.RotateTowards(target.localRotation, Quaternion.Euler(targetRotate), speed * Time.deltaTime);
    }
}
