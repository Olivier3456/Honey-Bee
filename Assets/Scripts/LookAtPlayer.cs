using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Transform _player;
    
    void Start()
    {
        _player= GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.LookAt(new Vector3(_player.position.x, transform.position.y, _player.position.z));
    }
}
