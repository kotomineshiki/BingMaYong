using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {
    public Tile[,] tiles;
    public GameObject tilePrefab;

    public int column = 10;
    public int row = 14;

	// Use this for initialization
	void Awake () {
        Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Initialize()//这个函数用来逐行逐列创建地图
    {
        tiles = new Tile[column, row];
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                GameObject obj = MonoBehaviour.Instantiate(tilePrefab, new Vector3((i - (column / 2)) * 1.1f, (j - (row / 2))*1.1f,0), Quaternion.identity) as GameObject;

                tiles[i, j] = obj.GetComponent<Tile>();
                tiles[i, j].tilePosition = new Vector2Int(i, j);
                obj.transform.SetParent(transform);
            }
        }
    }
}
