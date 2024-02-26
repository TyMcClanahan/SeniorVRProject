using UnityEngine;

public class WizardHealingState : WizardBaseState
{
    public WizardHealingState(WizardStateManager wsm) : base(wsm) { }
    public override void OnStateEnter() { }
    public override void CheckTransitions()
    {
        float dist = Vector3.Distance(wsm.transform.position, wsm.player.transform.position);
        if (dist > 6f)
        {
            wsm.SetState(new WizardChaseState(wsm));
        }
        if (wsm.playerHealth.currentHealth == 100f)
        {
            wsm.SetState(new WizardGatherState(wsm));
        }
    }
    public override void Act()
    {
        Debug.Log("Healing StateHealing StateHealing StateHealing StateHealing StateHealing StateHealing StateHealing StateHealing State");
        if (wsm.playerHealth.currentHealth != 100f) //test if this is necessary
        {
            wsm.playerHealth.currentHealth += 1f;
        }
    }
    public override void OnStateExit() { }
}
