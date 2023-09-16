using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionDespawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpawnPrefab;
    public float despawn_position_x;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < despawn_position_x)
        {
            Destroy(gameObject);
        }
        
    }
}
