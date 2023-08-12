using UnityEngine;

public class MechanismActivator : MonoBehaviour
{
    [SerializeField, Header("Механизм для активации")] private MultipleActivator mechanism;

    private bool isActivated = false;

    public void Start()
    {
        if (isActivated == true) return;

        mechanism.AddActiveMechanism();
        isActivated = true;
    }
}
