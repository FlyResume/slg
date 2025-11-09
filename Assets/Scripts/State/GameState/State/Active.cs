using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QZGFramework
{
    public class Active : StateBase
    {
        public override void Enter()
        {
            Debug.Log("Enter Active State");
            EventCenter.Instance.EventTrigger(E_EventType.E_ActiveEnter);
        }
        public override void Update()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ActiveUpdate);
        }
        public override void FixedUpdate()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ActiveFixedUpdate);
        }
        public override void Exit()
        {
            EventCenter.Instance.EventTrigger(E_EventType.E_ActiveExit);
        }
    }
}
