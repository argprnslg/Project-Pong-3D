using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public List<GameObject> SpawnArea;
    public int maxPowerUpAmount = 3;
    public int spawnInterval;
    public GameObject ball;
    private List<GameObject> ballList;
   

    private List<GameObject> powerUpList;
    private float timer;

    private void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        GenerateSpawner(1);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            generateBall();
            timer -= spawnInterval;
        }
    }

    public void generateBall()
    {
        int spawnPos = Random.Range(1,5);
        if (spawnPos == 1)
        {
            GenerateSpawner(1);
        }
        else if (spawnPos == 2)
        {
            GenerateSpawner(2);
        }
        else if (spawnPos == 3)
        {
            GenerateSpawner(3);
        }
        else if (spawnPos == 4)
        {
            GenerateSpawner(4);
        }
    }

    public void GenerateSpawner(int spawnPoints)
    {
        Vector3 speedSpawned;
        Vector3 spawnPos;

        if(ballList.Count >= maxPowerUpAmount)
        {
           return;
        }

        if (spawnPoints == 1)
        {
            speedSpawned = new Vector3(15, 0, 15);
            spawnPos = new Vector3(-11, 1, -11);
            SpawnBall(speedSpawned, spawnPos);
        }

        if (spawnPoints == 2)
        {
            speedSpawned = new Vector3(-15, 0, 15);
            spawnPos = new Vector3(11, 1, -11);
            SpawnBall(speedSpawned, spawnPos);
        }

        if (spawnPoints == 3)
        {
            speedSpawned = new Vector3(-15, 0, -15);
            spawnPos = new Vector3(11, 1, 11);
            SpawnBall(speedSpawned, spawnPos);
        }

        if (spawnPoints == 4)
        {
            speedSpawned = new Vector3(-15, 0, 15);
            spawnPos = new Vector3(-11, 1, 11);
            SpawnBall(speedSpawned, spawnPos);
        }
    }

    public void SpawnBall(Vector3 speedSpawned, Vector3 spawnPos)
    {
        //int randomIndex = Random.Range(0, SpawnArea.Count);

        GameObject bola = Instantiate(ball, new Vector3 (spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        bola.GetComponent<BallControll>().speed = speedSpawned;
        bola.SetActive(true);
        ballList.Add(bola);
    }

    public void RemoveBall(GameObject ballObject)
    {
        ballList.Remove(ballObject);
        Destroy(ballObject);
    }

}
