using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHelmet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Helmet"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
