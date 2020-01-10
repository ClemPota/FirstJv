using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject EnemyPrefab;

    private GameObject WavesObject;

    private int i = 0;

    float t = 0;

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        WavesObject = GameObject.FindGameObjectWithTag("Waves");

        WavesHandlerScript WavesScript = WavesObject.GetComponent<WavesHandlerScript>();
        if(t > 2)
        {
            while (i <= WavesScript.Waves)
            {
                GameObject g = Instantiate(EnemyPrefab);
                g.transform.position = new Vector3(transform.position.x + Random.Range(-10, 10), 5, transform.position.z + Random.Range(-10, 10));
                i++;
                if (i == WavesScript.Waves)
                {
                    i = 0;
                }
            }
        }
    }
}
