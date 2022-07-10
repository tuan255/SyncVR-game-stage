using System;
using System.Collections.Generic;
using UnityEngine;

public class MapMaker : MonoBehaviour
{

    public List<LevelInfo> depthLevel = new List<LevelInfo>();
    public GameObject[,] map;
    [SerializeField] private GameObject dirt;
    [SerializeField] private GameObject stone;
    [SerializeField] private GameObject silver;
    [SerializeField] private GameObject gold;
    [SerializeField] private GameObject diamond;
    [SerializeField] private GameObject hardrock;

    [SerializeField] private int width = 10;
    [SerializeField] private int maxChance, minChance;

    // Start is called before the first frame update
    void Start()
    {
        map = new GameObject[width, depthLevel.Count];
        ConstructMap();
    }

    public void ConstructMap()
    {
        for (int y = 0; y < depthLevel.Count; y++)
        {
            for (int x = 0; x < width; x++)
            {
                WhatBlock(x, y);
            }
        }
    }

    public void WhatBlock(int x ,int y)
    {
        int chance = UnityEngine.Random.Range(minChance, maxChance);
        int currentChance = depthLevel[y].dirt;
        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(dirt);
            tile.name = "dirt";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }

        currentChance += depthLevel[y].stone;

        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(stone);
            tile.name = "stone";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }

        currentChance += depthLevel[y].silver;

        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(silver);
            tile.name = "silver";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }

        currentChance += depthLevel[y].gold;

        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(gold);
            tile.name = "gold";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }

        currentChance += depthLevel[y].diamond;

        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(diamond);
            tile.name = "diamond";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }

        currentChance += depthLevel[y].hardrock;

        if (chance - currentChance < minChance)
        {
            GameObject tile = Instantiate(hardrock);
            tile.name = "hardrock";
            tile.transform.position = new Vector2(x, -y);
            map[x, y] = tile;
            return;
        }
        else
        {
            GameObject tile = Instantiate(stone);
            tile.transform.position = new Vector2(x,-y);
            map[x, y] = tile;
            return;
        }
    }

}

[Serializable]
public class LevelInfo
{
    [SerializeField]
    public int dirt, stone, silver, gold, diamond, hardrock;
}
