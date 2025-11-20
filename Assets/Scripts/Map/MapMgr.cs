using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QZGFramework;

public class MapMgr : SingletonMono<MapMgr>
{
    private List<Grid> gridsList = new List<Grid>();
    [SerializeField]
    private Vector2Int grids = new Vector2Int(9, 10);
    [SerializeField]
    private Vector2 gridSize = new Vector2(1, 1);
    [SerializeField]
    private GameObject Map;

    private void GenerateMap()
    {
        for (int i = 0; i < grids.x; i++)
        {
            for (int j = 0; j < grids.y; j++)
            {
                Grid grid = new Grid(new Vector2(i * gridSize.x, j * gridSize.y));
                gridsList.Add(grid);
            }
        }
        ResourceMgr.Instance.LoadMaterial("Graphs_GridGraph",Map);
    }
    public Grid GetGrid(Vector2 pos)
    {
        return gridsList.Find(grid => grid.pos == pos);
    }
}
