using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject messegeBox;
    [SerializeField, Header("Необходимое количество ключей")] private int amountKeysActive;
    [SerializeField] private UnityEvent enter;

    private bool isActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isActive == true) return;

        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
            if (bag.GetAmountKeys() >= amountKeysActive)
            {
                isActive = true;
                enter.Invoke();
            }
            else
            {
                messegeBox.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messegeBox.SetActive(false);
    }
}
