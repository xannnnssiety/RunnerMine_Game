using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnPos = 0;
    private float tileLength = 50;
    /*public float tileSpeed = 5f;*/  // Скорость движения тайлов

    [SerializeField] private Transform player;
    private int startTiles = 6;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startTiles; i++)
        {
            if(i == 0)
            {
                SpawnTile(30);
            }
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*MoveTiles();*/  // Добавлен вызов функции для движения тайлов

        if (player.position.z - 60 > spawnPos - (startTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

/*    private void MoveTiles()
    {
        foreach (GameObject tile in activeTiles)
        {
            tile.transform.Translate(-Vector3.forward * tileSpeed * Time.deltaTime);
        }
    }*/

    private void SpawnTile(int tileIndex)
    {
        GameObject nextTile = Instantiate(tilePrefabs[tileIndex], new Vector3(0, 0, spawnPos), Quaternion.identity);
        activeTiles.Add(nextTile);
        spawnPos += tileLength;
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
