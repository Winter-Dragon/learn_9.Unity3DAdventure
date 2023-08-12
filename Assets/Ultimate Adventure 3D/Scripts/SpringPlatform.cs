using UnityEngine;
using SimpleFPS;

public class SpringPlatform : MonoBehaviour
{
    [SerializeField, Header("Бонус прыжка")] private int jumpForce;
    [SerializeField, Header("Время активности")] private float activeTime;
    [SerializeField] private new AudioSource audio;
    [SerializeField] private bool isActive = false;

    [SerializeField, Header("Объект платформы")] private Transform target;
    private float speed = 1;
    private Vector3 targetPosition;
    private float timer;

    private float previousJumpForce;
    private void OnTriggerEnter(Collider other)
    {
        if (isActive == false) return;
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previousJumpForce = fps.m_JumpSpeed;
            fps.m_JumpSpeed += jumpForce;
            fps.m_Jump = true;
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isActive == false) return;
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previousJumpForce;
        }
    }

    private void Update()
    {
        switch (isActive){
            case true:
                targetPosition = new Vector3(0, (float)0.13, 0);
                timer += Time.deltaTime;
                if (timer >= activeTime)
                {
                    isActive = false;
                    timer = 0;
                }
                break;
            case false:
                targetPosition = new Vector3(0, (float)0.03, 0);
                break;
        }

        target.localPosition = Vector3.MoveTowards(target.localPosition, targetPosition, speed * Time.deltaTime);
    }

    public void setDisable()
    {
        isActive = false;
    }

    public void setEnable()
    {
        isActive = true;
    }
}
