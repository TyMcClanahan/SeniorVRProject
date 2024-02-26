using System.Security.Cryptography;
using UnityEngine;

public class WizardIdleState : WizardBaseState
{
    public WizardIdleState(WizardStateManager wsm) : base(wsm) { }
    public override void OnStateEnter() { }
    public override void CheckTransitions()
    {
        float dist = Vector3.Distance(wsm.transform.position, wsm.player.transform.position);
        if (dist < 20f)
        {
            wsm.SetState(new WizardChaseState(wsm));
        }
    }
    public override void Act()
    {
        //dance
        Debug.Log("Idle StateIdle StateIdle StateIdle StateIdle StateIdle StateIdle StateIdle StateIdle StateIdle State");
    }
    public override void OnStateExit() { }
}
