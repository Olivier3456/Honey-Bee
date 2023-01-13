using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaclerLesCadres : MonoBehaviour
{
    [SerializeField] private AudioSource _raclage;
    
    [SerializeField] private Material _cadreMaterialCadrePropre;
    [SerializeField] private Renderer _cadreRenderer;

    int _nbreRaclages;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Racloir"))
        {
            _raclage.Play();
            _nbreRaclages++;
            if (_nbreRaclages >= 3) _cadreRenderer.material = _cadreMaterialCadrePropre;

        }

        else if (collision.gameObject.CompareTag("ZoneDeDepose"))
        {
        gameObject.SetActive(false);
        }
    }
}
