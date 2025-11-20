using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QZGFramework
{
    public class Shutdown : StateBase
    {
        public override void Enter()
        {
            Debug.Log("Enter Shutdown State");
            EventCenter.Instance.EventTrigger(E_EventType.E_ShutdownEnter);
        }
        public override void Update()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ShutdownUpdate);
        }
        public override void FixedUpdate()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ShutdownFixedUpdate);
        }
        public override void Exit()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ShutdownExit);
        }
    }
}