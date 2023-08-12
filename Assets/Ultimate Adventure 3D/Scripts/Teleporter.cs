using UnityEngine;
using SimpleFPS;

public class Teleporter : MonoBehaviour
{
    [SerializeField, Header("Цель перемещения")] private Teleporter target;
    [SerializeField] private new AudioSource audio;
    [HideInInspector] private bool isReceive;

    private void OnTriggerEnter(Collider other)
    {
        if (isReceive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.isReceive = true;
            fps.transform.position = target.transform.position;
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            isReceive = false;
        }
    }
}
