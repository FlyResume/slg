using System;
using System.Collections;
using System.Collections.Generic;
using QZGFramework;
using UnityEngine;
using UnityEngine.PlayerLoop;
public class GameStateMachine : QZGFramework.StateMachine
{
    public StateBase[] states = new StateBase[]
    {
        new PreInit(),
        new Pause(),
        new UpInit(),
        new Active(),
        new Shutdown(),
    };
    public void InitStateMachine(Action callback = null)
    {
        Init(states, this);
        callback?.Invoke();
    }
}
