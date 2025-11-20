using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QZGFramework
{
    public class RoundStart : StateBase
    {
        public override void Enter()
        {
            Debug.Log("Enter Round State");
            EventCenter.Instance.EventTrigger(E_EventType.E_UpInitEnter);
        }
        public override void Update()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_UpInitUpdate);
        }
        public override void FixedUpdate()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_UpInitFixedUpdate);
        }
        public override void Exit()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_UpInitExit);
        }
    }
}
