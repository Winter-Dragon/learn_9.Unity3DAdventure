using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private float maxHitPoints;

    public UnityEvent hpAreOver;
    public UnityEvent changeHitPoints;
    private float hitPoints;

    private void Start()
    {
        hitPoints = maxHitPoints;
        changeHitPoints.Invoke();
    }
    public void ApplyDamage(int damage)
    {
        hitPoints -= damage;
        changeHitPoints.Invoke();

        if (hitPoints <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        hitPoints = 0;

        changeHitPoints.Invoke();
        hpAreOver.Invoke();
    }

    public void HealDamage(int heal)
    {
        if (heal + hitPoints >= maxHitPoints)
        {
            hitPoints = maxHitPoints;
        }
        else hitPoints += heal;

        changeHitPoints.Invoke();
    }

    public float GetHitPoints()
    {
        return hitPoints;
    }

    public float GetMaxHitPoints()
    {
        return maxHitPoints;
    }

    public float GetNormalizeHitPoints()
    {
        return GetHitPoints() / GetMaxHitPoints();
    }
}
