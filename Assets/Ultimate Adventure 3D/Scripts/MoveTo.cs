using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField, Header("�������� ������������")] private float speed;
    [SerializeField, Header("������� ����������")] private Transform target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
