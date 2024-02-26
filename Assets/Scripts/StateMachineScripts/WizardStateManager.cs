using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardStateManager : MonoBehaviour
{
    public WizardBaseState currentState;
    public GameObject player;
    public PlayerHealth playerHealth;

    void Start()
    {
        SetState(new WizardIdleState(this));
    }

    void Update()
    {
        currentState.CheckTransitions();
        currentState.Act();
    }

    public void SetState(WizardBaseState state)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }
        currentState = state;
        if (currentState != null)
        {
            currentState.OnStateEnter();
        }
    }
}
