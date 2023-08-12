using UnityEngine;
using SimpleFPS;

public class Acceleration : MonoBehaviour
{
    [SerializeField, Header("Бонус прыжка")] private int bonusJump;
    [SerializeField, Header("Бонус ходьбы")] private int bonusWalkSpeed;
    [SerializeField, Header("Бонус бега")] private int bonusRunSpeed;
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
