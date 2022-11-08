using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallGrass : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if(Random.Range(1, 101) <= 10)
        {
            Debug.Log("OH SHIT A POKEMON");
        }
    }
}
