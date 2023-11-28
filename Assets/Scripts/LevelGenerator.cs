using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public List<GameObject> platforms;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    public float startDelay = 1.0f;
    public float repeatRate = 1.0f;

    Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnPlatform", startDelay, repeatRate);
        SpawnPlatform();
    }

    //void SpawnPlatform()
    //{
    //    int indexOfPlatform = Random.Range(0, platforms.Count);
    //    Instantiate(platforms[indexOfPlatform], RandomPos(), Quaternion.identity);
    //}

    Vector3 RandomPos()
    {
        spawnPos.y = spawnPos.y + Random.Range(minY, maxY);
        spawnPos.x = Random.Range(-levelWidth, levelWidth);
        return spawnPos;
    }

    void SpawnPlatform()
    {
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            int indexOfPlatform = Random.Range(0, platforms.Count);
            Instantiate(platforms[indexOfPlatform], RandomPos(), Quaternion.identity);
        }

        //    GameObject platform = ObjectPool.SharedInstance.GetPooledObjects();
        //    if (platform != null)
        //    {
        //        platform.transform.position = RandomPos();
        //        platform.transform.rotation = Quaternion.identity;
        //        platform.SetActive(true);
        //    }
    }

    //void DestroyOutOfBounds()
    //{
    //    gameObject.SetActive(false);
    //}
}
