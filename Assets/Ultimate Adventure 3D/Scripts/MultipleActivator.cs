using UnityEngine;
using UnityEngine.Events;

public class MultipleActivator : MonoBehaviour
{
    [SerializeField] private UnityEvent allMechanismsAreActivated;
    [SerializeField, Header("����������� ���-�� ���������� ��� ���������")] private int mechanismsNeed;

    private int activeMechanisms;
    private void Update()
    {
        if (mechanismsNeed > activeMechanisms) return;

        allMechanismsAreActivated.Invoke();
    }

    public void AddActiveMechanism()
    {
        activeMechanisms++;
    }
}
