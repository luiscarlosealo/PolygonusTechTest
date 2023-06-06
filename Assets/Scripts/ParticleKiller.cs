using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKiller : MonoBehaviour
{
    public float life = 2f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}
