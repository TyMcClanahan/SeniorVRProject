using UnityEngine;

public class WizardChaseState : WizardBaseState
{
    public WizardChaseState(WizardStateManager wsm) : base(wsm) { }
    public override void OnStateEnter() { }
    public override void CheckTransitions()
    {
        float dist = Vector3.Distance(wsm.transform.position, wsm.player.transform.position);
        if (dist > 20f)
        {
            wsm.SetState(new WizardIdleState(wsm));
        }
        if (dist < 5f)
        {
            wsm.SetState(new WizardHealingState(wsm));
        }
    }
    public override void Act()
    {
        Debug.Log("Chase StateChase StateChase StateChase StateChase StateChase StateChase StateChase StateChase StateChase State");
        Vector3 direction = (wsm.player.transform.position - wsm.transform.position).normalized;
        wsm.transform.Translate(direction * 4f * Time.deltaTime);
    }
    public override void OnStateExit() { }
}
