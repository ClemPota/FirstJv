using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public GameObject PlayerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject g = Instantiate(PlayerPrefab);
        g.transform.position = transform.position;
    }

}
