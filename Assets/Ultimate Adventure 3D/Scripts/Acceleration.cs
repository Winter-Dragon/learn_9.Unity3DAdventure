using UnityEngine;
using SimpleFPS;

public class Acceleration : MonoBehaviour
{
    [SerializeField, Header("����� ������")] private int bonusJump;
    [SerializeField, Header("����� ������")] private int bonusWalkSpeed;
    [SerializeField, Header("����� ����")] private int bonusRunSpeed;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed += bonusJump;
            fps.m_WalkSpeed += bonusWalkSpeed;
            fps.m_RunSpeed += bonusRunSpeed;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed -= bonusJump;
            fps.m_WalkSpeed -= bonusWalkSpeed;
            fps.m_RunSpeed -= bonusRunSpeed;
        }
    }
}
