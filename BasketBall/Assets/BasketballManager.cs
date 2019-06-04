using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballManager : MonoBehaviour {

    public GameObject Basketball;
    public Transform Spawn;
    Vector3 SpawnPoint;

    private void Start()
    {
        SpawnPoint = Spawn.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Basketball, SpawnPoint, Quaternion.identity);
        }
    }
}
