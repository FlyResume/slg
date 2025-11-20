using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QZGFramework;

public class GameMgr : MonoBehaviour
{
    [SerializeField]
    private GameStateMachine mainMachine;
    [SerializeField]
    private InputMgr inputMgr;
    [SerializeField]
    private MapMgr mapMgr;
    public void Init()
    {
        EventCenter.Instance.AddEventListener(E_EventType.E_ActiveEnter, mapMgr.MapInit);
        EventCenter.Instance.AddEventListener(E_EventType.E_ActiveUpdate, inputMgr.MoveControl);
    }
    private void Start()
    {
        Init();
        mainMachine.InitStateMachine(() =>
        {
            mainMachine.SwitchState(typeof(UpInit));
        });
    }
    private void Update()
    {
        //暂时进入游戏的方法
        if(Input.GetKeyDown(KeyCode.L))
        {
            mainMachine.SwitchState(typeof(Active));
        }
    }
}
