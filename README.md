<img align="left" width="200" src="bug_green.png"/>

# TradeWindsTrap

Trap() is a construct I discuss in my book No Bugs! Basically you place this when you write new code, at the entry to each function, inside every if, else, where, case, etc. 

Over decades of programming I have found this to be one of the most effective means of writing good code. Not just finding bugs quickly, but writing better code.

> This is under the MIT license. If you find this very useful I ask (not a requirement) that you consider reading my book [I DON’T KNOW WHAT I’M DOING!: How a Programmer Became a Successful Startup CEO](https://a.co/d/bEpDlJR).
> 
> And if you like it, please review it on Amazon and/or GoodReads. The number of legitimate reviews helps a lot. Much appreciated.

## Use

Add the attached Trap.cs to your project. This needs to be a file in the project, and not in a pre-built library because:

1. It must be compiled using debug/release to match the application.
2. It will drop you in that method when running using the debugger.

When you first run that new code it will drop you in to the debugger at each trap. Mark that Trap() to be deleted and then single step through the new code. 90% of the time the code is fine. 10% of the time the code will do something unexpected and you can then fix the issue.

## Marking a Trap() for deletion

The way I mark the traps to delete when I'm in the debugger is I put a * at the beginning of that line
```csharp
*     Trap();
```
That way the line numbers don't change so the debugger is in sync with the source code. But when your debug session is complete, a compile will fail until you remove those traps you've now walked through.
