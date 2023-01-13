using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meuh : MonoBehaviour
{
    [SerializeField] private AudioSource _meuh;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) _meuh.Play();
    }
}
