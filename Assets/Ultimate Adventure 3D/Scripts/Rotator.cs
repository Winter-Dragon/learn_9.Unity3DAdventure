using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField, Header("Объект вращения")] private Transform target;
    [SerializeField, Header("Скорость вращения")] private Vector3 speed;

    private void Update()
    {
        target.transform.Rotate(speed * Time.deltaTime);
    }
}
