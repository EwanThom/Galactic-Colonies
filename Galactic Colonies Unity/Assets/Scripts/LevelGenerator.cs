using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject wall;
    public List<Vector3> createdTiles;
    public int tileAmount;
    public int tileSize;
    public float waitTime;
    public int LoadTime;

    public float chanceUp;
    public float chanceRight;
    public float chanceDown;
    public GameObject levelSpawn;
    public GameObject UISpawn;
    public GameObject LoadScreen;

    public float minY = 9999999;
    public float maxY = 0;
    public float minX = 9999999;
    public float MaxX = 0;
    public float xAmount;
    public float yAmount;
    public float extraWallx;
    public float extraWallY;

    void Start()
    {
        StartCoroutine(GenerateLevel());
        LoadTime = 1;
    }

    IEnumerator GenerateLevel()
    {
        for(int i = 0; i < tileAmount; i++)
        {
            float dir = Random.Range(0f, 1f);
            int tile = Random.Range(0, tiles.Length);
            CreateTile(tile);
            CallMoveGen(dir);
            LoadTime = LoadTime + 1;
            yield return new WaitForSeconds(waitTime);
            if (i == tileAmount - 1)
            {
                Finish();
            }
        }

    }

    void CallMoveGen(float randir)
    {
        if(randir < chanceUp)
        {
            MoveGen(0);
        }
        else if(randir < chanceRight)
        {
            MoveGen(1);
        }
        else if(randir < chanceDown)
        {
            MoveGen(2);
        }
        else
        {
            MoveGen(3);
        }

    }

    void MoveGen(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y + tileSize, 0);
                break;

            case 1:
                transform.position = new Vector3(transform.position.x + tileSize, transform.position.y, 0);

                break;

            case 2:
                transform.position = new Vector3(transform.position.x, transform.position.y - tileSize, 0);

                break;

            case 3:
                transform.position = new Vector3(transform.position.x - tileSize, transform.position.y, 0);

                break;
        }
    }

    void CreateTile(int tileIndex)
    {
        if (!createdTiles.Contains(transform.position))
        {
            GameObject tileObject;
            tileObject = Instantiate(tiles[tileIndex], transform.position, transform.rotation) as GameObject;
            createdTiles.Add(tileObject.transform.position);
        }
        else
        {
            tileAmount++;
        }
    }


    void Finish()
    {
        CreateWallValues();
        CreateWalls();
        levelSpawn.SetActive(true);
        UISpawn.SetActive(true);
    }

    void CreateWallValues()
    {
        for(int i = 0; i < createdTiles.Count; i++)
        {
            if(createdTiles[i].y < minY)
            {
                minY = createdTiles[i].y;
            }
            if(createdTiles[i].y > maxY)
            {
                maxY = createdTiles[i].y;
            }
            if (createdTiles[i].x < minX)
            {
                minX = createdTiles[i].x;
            }
            if (createdTiles[i].x > MaxX)
            {
                MaxX = createdTiles[i].x;
            }
            xAmount = ((MaxX - minX) / tileSize) + extraWallx;
            yAmount = ((maxY - minY) / tileSize) + extraWallY;
        }
    }

    void CreateWalls()
    {
        for(int x = 0; x < xAmount; x++)
        {
            for (int y = 0; y <xAmount; y++)
            {
                if(!createdTiles.Contains(new Vector3((minX - (extraWallx * tileSize) / 2) + (x * tileSize), (minY -(extraWallY * tileSize) / 2) + (y * tileSize))))
                {
                    Instantiate(wall, new Vector3((minX - (extraWallx * tileSize) / 2) + (x * tileSize), (minY - (extraWallY * tileSize) / 2) + (y * tileSize)), transform.rotation);
                }
            }
        }
    }
}
