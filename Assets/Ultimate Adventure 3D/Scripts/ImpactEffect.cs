using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffect : MonoBehaviour
{
    [SerializeField] private int lifeTime;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
