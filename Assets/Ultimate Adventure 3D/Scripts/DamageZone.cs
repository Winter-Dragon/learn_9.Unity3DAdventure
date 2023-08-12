using SimpleFPS;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField, Header("Урон объекта")] private int damage;
    [SerializeField, Header("Частота нанесения урона")] private float damageRate;
    [SerializeField] private new AudioSource audio;

    private FirstPersonController fps;
    private Destructible destructible;
    private float timer;
    private float soundTimer;

    private void Update()
    {
        if (destructible == null)
        {
            return;
        }

        timer += Time.deltaTime;
        soundTimer += Time.deltaTime;

        if (timer >= damageRate)
        {
            destructible.ApplyDamage(damage);

            timer = 0;

            if (soundTimer > audio.time + damageRate && fps != null)
            {
                audio.Play();

                soundTimer = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        destructible = other.GetComponent<Destructible>();
        fps = other.GetComponent<FirstPersonController>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructible>() == destructible) destructible = null;
        if (other.GetComponent<FirstPersonController>() == fps) fps = null;
    }
}
