using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Centrifugeuse : MonoBehaviour
{
    [SerializeField] private AudioSource _mielQuiCoule;
    [SerializeField] private TextMeshPro _texteMielRecolte;

    private int _nbreMielRecolte = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cadre"))
        {
            _mielQuiCoule.Play();
            _nbreMielRecolte++;
            _texteMielRecolte.text = "Miel récolté : " + _nbreMielRecolte;
        }

    }
}
