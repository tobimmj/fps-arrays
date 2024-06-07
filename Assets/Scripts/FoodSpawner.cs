using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    [SerializeField] private float interval;
    [SerializeField] private List<GameObject> food;

    void Start()
    {
        InvokeRepeating(nameof(SpawnFood), interval, 1);
    }

    void Update()
    {
        
    }

    void SpawnFood()
    {
        Instantiate(GetRandomFood(), GetRandomPosition(), Quaternion.identity);
    }

    GameObject GetRandomFood()
    {
        return food[Random.Range(0, food.Count)];
    }

    Vector3 GetRandomPosition()
    {
        float x = Random.Range(-transform.localScale.x/2.0f,
            transform.localScale.x/2.0f);
        float z = Random.Range(-transform.localScale.z / 2.0f,
            transform.localScale.z / 2.0f);

        return new Vector3(x, transform.position.y, z);
    }
}
