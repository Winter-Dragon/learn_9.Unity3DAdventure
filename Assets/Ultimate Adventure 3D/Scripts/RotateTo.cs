using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField, Header("���� ��������")] private Transform target;
    [SerializeField, Header("�������� ��������")] private float speed;
    [SerializeField, Header("������� ����������")] private Vector3 targetRotate;

    private void Update()
    {
        target.localRotation = Quaternion.RotateTowards(target.localRotation, Quaternion.Euler(targetRotate), speed * Time.deltaTime);
    }
}
