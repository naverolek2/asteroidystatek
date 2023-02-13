using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMenager : MonoBehaviour
{
    // Start is called before the first frame update
    camera_Script cs;
    public GameObject asteroidPreFab;
    private float maxHorizontal, maxVertical;
    private float spawnTimer, spawnInterval;
    void Start()
    {
        cs = Camera.main.GetComponent<camera_Script>();
        
        spawnInterval = 3;
        spawnTimer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(maxHorizontal+ " " + maxVertical);
        maxHorizontal = cs.worldWidth / 2 * 1.2f;
        maxVertical = cs.worldHeight / 2 * 1.2f;
        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0 )
        {
            Spawn();
            spawnTimer = spawnInterval;
        }
    }
    void Spawn()
    {
        
        float randomX, randomZ;
        
        if (Mathf.RoundToInt(Random.Range(0, 1)) == 0)
        {
            int random = Random.Range(0, 1);
            randomZ = randomSign() * maxVertical;
            randomX = Random.Range(0, maxHorizontal);
        }
        else
        {
            int random = Random.Range(0, 1);
            randomX = randomSign() * maxHorizontal;
            randomZ = Random.Range(0, maxVertical);
        }
       Vector3 spawnPoint = new Vector3 (randomX, 0, randomZ);
       
        Instantiate(asteroidPreFab, spawnPoint, Quaternion.identity);
    }
    int randomSign()
    {
        int[] tabela = { -1, 1 };

        return tabela[Random.Range(0, 1)];
    }

}
