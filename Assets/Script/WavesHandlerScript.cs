using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesHandlerScript : MonoBehaviour
{

    private int nbEnemy;

    public int Waves = 0;

    private void OnTriggerStay(Collider other)
    {
        if (nbEnemy == 0)
        {
            Waves += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Enemy")
        nbEnemy++;
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag == "Enemy")
            nbEnemy--;
    }
}
