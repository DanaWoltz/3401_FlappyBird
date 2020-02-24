using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeSetPrefab;
    public float spawnTime;
    public Transform spawnPosition;
    void Start()
    {
       InvokeRepeating("SpawnPipeSet", 0, spawnTime); 
    }
    void SpawnPipeSet()
    {
        Instantiate(pipeSetPrefab, spawnPosition.position, Quaternion.identity);

    }
}
