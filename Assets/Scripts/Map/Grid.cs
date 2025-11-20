using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    //实际位置
    public Vector2 pos;
    /// <summary>
    /// 创建后把相应坐标存入
    /// </summary>
    /// <param name="pos"></param>
    public Grid(Vector2 pos)
    {
        this.pos = pos;
    }
}
