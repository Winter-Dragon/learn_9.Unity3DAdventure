using UnityEngine;

public class Hamburger : PickUp
{
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private int healing;
    private Destructible destructible;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.HealDamage(healing);
            Instantiate(impactEffect);
        }
    }
}
