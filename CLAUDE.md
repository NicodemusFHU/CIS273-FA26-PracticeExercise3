# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

CIS273 practice exercise: implement generic Stack, Queue, and Deque data structures in C# (.NET 10, nullable enabled) on top of `System.Collections.Generic.LinkedList<T>`. The solution (`PracticeExercise3.sln`) has two projects: `PracticeExercise3` (console app / library code) and `UnitTests` (MSTest, references the main project).

## Commands

Run from the repo root:

- Build: `dotnet build`
- Run demo: `dotnet run --project PracticeExercise3`
- All tests: `dotnet test`
- Single test: `dotnet test --filter "FullyQualifiedName~TestStackPop"`

## Architecture

- Each structure has an interface (`IStack<T>`, `IQueue<T>`, `IDeque<T>`) and a class implementing it, all in namespace `PracticeExercise3`. Each class wraps a private `LinkedList<T> linkedList` field.
- `Stack<T>` is implemented except `Clear()`, which is a stub for students: the top of the stack is the **head** (`First`) of the list; `Push` = `AddFirst`, `Pop` = `RemoveFirst`. Empty `Peek`/`Pop` throw `EmptyStackException`.
- `Queue<T>` and `Deque<T>` are scaffolds: every member throws `NotImplementedException` (only `ToString` is written). Their `ToString` prints from `Last` back to `First` as `<Back> a → b <Front>`, so the **front** is the list head (`First`) and the **back** is the list tail (`Last`); implementations must follow that orientation. Both `Queue<T>` and `Deque<T>` throw `EmptyQueueException` when read or removed from while empty (there is no separate Deque exception).
- `Stack<T>.ToString` yields one item per line, top first, each followed by `\n` (tests assert this exact format, e.g. `"8\n5\n3\n2\n1\n"`).
- Name clash: the custom `Stack<T>`/`Queue<T>` shadow the BCL types, so tests fully qualify them (`new PracticeExercise3.Stack<int>()`).
- `Quiz.md` holds conceptual quiz questions; it is not code.
