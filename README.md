# C# Delegates, Func, Action, Lambdas and Events - Mini Lab

## Overview

This mini lab demonstrates important C# concepts through a simple threat-monitoring example inspired by Network Intrusion Detection Systems (NIDS).

The program checks threat scores and raises an event when a high-risk event is detected.

## Concepts Covered

- Delegates and callback-style behavior
- `Action` for methods that return no value
- `Func` for methods that return a value
- Lambda expressions
- Events and event handlers
- Event subscription using `+=`
- Event unsubscription using `-=`
- Null-conditional invocation using `?.Invoke()`

## How It Works

1. The `ThreatMonitor` receives a source IP address and threat score.
2. A `Func<int, bool>` determines whether the score is high risk.
3. If the score is 80 or above, the monitor raises the `ThreatDetected` event.
4. An `Action<string, int>` handler prints the alert.
5. The handler is unsubscribed after the demonstration.

## Requirements

- .NET SDK
- Terminal or command prompt

## Run the Project

```bash
dotnet run --project DelegatesEventsLab
```

## Sample Output

```text
Checking 192.168.1.5
Checking 10.0.0.15
HIGH RISK: 10.0.0.15, score=95
```

## Learning Outcome

This lab demonstrates how delegates, built-in delegate types, lambdas, and events can be combined to build loosely coupled components.

The example is for learning purposes and is not a production-ready intrusion detection system.
