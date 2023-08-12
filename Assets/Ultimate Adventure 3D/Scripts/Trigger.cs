using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField, Header("Триггер соприкосновения")]  private UnityEvent onEnter;
    [SerializeField, Header("Триггер выхода")]  private UnityEvent onExit;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            onExit.Invoke();
        }
    }
}
