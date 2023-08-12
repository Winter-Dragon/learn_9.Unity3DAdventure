using UnityEngine;

public class KillZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.Kill();
        }
    }
}
