using System.Collections.Generic;
using UnityEngine;

public class Soldier : CharacterBase
{
    public override void Movement()
    {
        //士兵的移动逻辑
        //先获取可移动格子，然后修改格子的不同颜色，表示可移动
        //兵的移动为如果没有过河则只能向前移动
        //如果过河了，则可以向前、左、右移动
        //先设置为兵可以左右前移动
        List<Vector2> canMoveGrid = GetCanMoveGrid();
        //移动到目标格子
        //修改格子的颜色，表示已经移动
        //可以添加更多士兵特有的移动逻辑

    }
    public List<Vector2> GetCanMoveGrid()
    {
        List<Vector2> moveGrid = new List<Vector2>();
        if(grid != null)
        {
            Vector2 currentPos = grid.pos;
            moveGrid.Add(new Vector2(currentPos.x, currentPos.y + 1)); // 前方格子
            moveGrid.Add(new Vector2(currentPos.x - 1, currentPos.y)); // 左方格子
            moveGrid.Add(new Vector2(currentPos.x + 1, currentPos.y)); // 右方格子
        }
        return moveGrid;

    }
}
