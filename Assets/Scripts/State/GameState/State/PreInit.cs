using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QZGFramework
{
    public class PreInit : StateBase
    {
        public override void Enter()
        {
            Debug.Log("Enter PreInit State");
            EventCenter.Instance.EventTrigger(E_EventType.E_PauseEnter);
        }
        public override void Update()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_PauseUpdate);
        }
        public override void FixedUpdate()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_PauseFixedUpdate);
        }
        public override void Exit()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_PauseExit);
        }
    }
}
