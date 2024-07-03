using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEnlarger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {        
        transform.localScale *= _speed;
    }
}
