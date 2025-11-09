using UnityEngine;


public class InputMgr : MonoBehaviour
{
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    public Vector2 moveDir = Vector2.zero;
    public void MoveControl()
    {
    }
}
