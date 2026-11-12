using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnObjects;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float startSpawnDelay = 0.5f;

    [SerializeField] private float repeatSpawnDelay = 1f;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), startSpawnDelay, repeatSpawnDelay);
    }

    private GameObject SpawnObject()
    {    
        return Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnPoint.position, Quaternion.identity);
    }
}
