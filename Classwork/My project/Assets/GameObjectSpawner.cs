using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    public GameObject SpawnPrefab;

    public float HeightOffset;
    public float SpawnInterval;
    private float _spawnTimer=0f;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (_spawnTimer < SpawnInterval)
        {
            _spawnTimer += Time.deltaTime;
        } else {
            _spawnTimer = 0f;
            Spawn();
        }
        
    }

    private void Spawn() {
        float highest_point = transform.position.x + HeightOffset;
        float lowest_point = transform.position.y - HeightOffset;
        float position_y = Random.Range(lowest_point, highest_point);
        Instantiate(SpawnPrefab, transform.position, transform.rotation);
    }
}
