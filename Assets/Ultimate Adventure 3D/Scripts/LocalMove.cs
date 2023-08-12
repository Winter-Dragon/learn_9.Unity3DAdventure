using UnityEngine;

public class LocalMove : MonoBehaviour
{
    [SerializeField, Header("������ �����������")] private Transform target;
    [SerializeField, Header("�������� �����������")] private float speed;
    [SerializeField, Header("������� ����������")] private Vector3 targetPosition;

    private void Update()
    {
        if (target != null)
        {
            target.localPosition = Vector3.MoveTowards(target.localPosition, targetPosition, speed * Time.deltaTime);
        }
    }
}
