using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField, Header("������ ��������")] private Transform target;
    [SerializeField, Header("�������� ��������")] private Vector3 speed;

    private void Update()
    {
        target.transform.Rotate(speed * Time.deltaTime);
    }
}
