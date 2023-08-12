using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    private int keysAmount;

    public UnityEvent changeAmountKeys;

    public void AddKey(int amount)
    {
        keysAmount += amount;
        changeAmountKeys.Invoke();
    }

    public bool DeleteKey(int amount)
    {
        if (keysAmount - amount < 0) return false;

        keysAmount -= amount;
        changeAmountKeys.Invoke();
        return true;
    }

    public int GetAmountKeys()
    {
        return keysAmount;
    }
}
