using Stateless;
using Stateless.Graph;

public enum CoffeeMachineState
{
    Off,
    Ready,
    Broken
}

public enum CoffeeMachineTrigger
{
    TurnOn,
    TurnOff,
    Fail,
    Repair
}

public class CoffeeMachine
{
    // stateless (FSM)

    private readonly StateMachine<CoffeeMachineState, CoffeeMachineTrigger> _machine;

    public CoffeeMachineState State => _machine.State;

    public CoffeeMachine()
    {
        _machine = new StateMachine<CoffeeMachineState, CoffeeMachineTrigger>(
            CoffeeMachineState.Off);

        _machine.Configure(CoffeeMachineState.Off)
            .Permit(CoffeeMachineTrigger.TurnOn, CoffeeMachineState.Ready)
            .Permit(CoffeeMachineTrigger.Fail, CoffeeMachineState.Broken)
            ;

        _machine.Configure(CoffeeMachineState.Ready)
            .Permit(CoffeeMachineTrigger.TurnOff, CoffeeMachineState.Off)
            .Permit(CoffeeMachineTrigger.Fail, CoffeeMachineState.Broken);

        _machine.Configure(CoffeeMachineState.Broken)
            .Permit(CoffeeMachineTrigger.Repair, CoffeeMachineState.Off);
    }

    public void TurnOn() => _machine.Fire(CoffeeMachineTrigger.TurnOn);

    public void TurnOff() => _machine.Fire(CoffeeMachineTrigger.TurnOff);

    public void Fail() => _machine.Fire(CoffeeMachineTrigger.Fail);

    public void Repair() => _machine.Fire(CoffeeMachineTrigger.Repair);

    public string ToMermaidGraph() => MermaidGraph.Format(_machine.GetInfo());
}
