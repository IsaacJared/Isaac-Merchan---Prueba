using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEsfera : MonoBehaviour
{

    public GameObject[] esferaPrefab;

    private float spawnLimitXLeft = 1;
    private float spawnLimitXRight = 1;
    private float spawnPosY = 1;

    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(0, spawnInterval));
    }
    void SpawnRandomBall()
    {
        int randomBallIndex = Random.Range(0, esferaPrefab.Length);


        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(esferaPrefab[randomBallIndex], spawnPos, esferaPrefab[randomBallIndex].transform.rotation);

        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
}
