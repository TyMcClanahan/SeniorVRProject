using UnityEngine;

public abstract class WizardBaseState : WizardStateManager
{
    protected WizardStateManager wsm;
    public abstract void CheckTransitions();
    public abstract void Act();
    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }
    public WizardBaseState(WizardStateManager wsm)
    {
        this.wsm = wsm;
    }
}
