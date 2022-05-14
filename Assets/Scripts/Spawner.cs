using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coin, bomb;

    public float xBounds, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        if (Random.value <= .6f)
        {
            Instantiate(coin, new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(bomb, new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomGameObject());
    }

}
