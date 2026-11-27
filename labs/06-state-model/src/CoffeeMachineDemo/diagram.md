
## Diagram stanów

```mermaid
stateDiagram-v2
        Off --> Ready : TurnOn
        Off --> Broken : Fail
        Off --> Off : TurnOff
        Ready --> Off : TurnOff
        Ready --> Broken : Fail
        Broken --> Off : Repair
[*] --> Off
```