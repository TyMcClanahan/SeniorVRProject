using UnityEngine;

public class WizardGatherState : WizardBaseState
{
    private float stateTimerValue;
    private float stateTimerMax = 3f;
    
    public WizardGatherState(WizardStateManager wsm) : base(wsm) { }
    public override void OnStateEnter() { }
    public override void CheckTransitions()
    {
        stateTimerValue += Time.deltaTime;
        if(stateTimerValue > stateTimerMax)
        {
            wsm.SetState(new WizardIdleState(wsm));
        }
    }
    public override void Act()
    {
        Debug.Log("GatherGatherGatherGatherGatherGatherGatherGather");
        Debug.Log("GatherGatherGatherGatherGatherGatherGatherGather");
    }
    public override void OnStateExit() { }
}
