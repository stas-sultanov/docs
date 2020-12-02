# Plot

Continuous Production aka CP is a flow production method that allows to build most efficient process of transformation **Idea** to **Value** within the software soultion lifecyle. Important to define that idea is a concept of actions the implementation of which will lead to an increase in net profit, both cost reduction and revenue increase are considered. And by efficiency both time and money are considered.

**CP** is adaptive and value-driven approach, read more [here](https://en.wikipedia.org/wiki/Agile_software_development#Adaptive_vs._predictive). It means that it is focusesd on adapting quickly to changing realities and at the same time focus on bring value to business as soon as possible.

**CP** is designed in the way that if only today an idea on how to make customers bring more money has appeared,
the company has a most efficient process for a team to transform this idea in actual value that must be can be brought to the customers.

At high level Continous Production is a variant of [Kanban](https://en.wikipedia.org/wiki/Kanban_(development)) approach.

## Digression

It is crucial to accept the fact that in most IT projects work can be done when it can be done and not earlier.
The reason for that is unlike in [Construction](https://en.wikipedia.org/wiki/Construction), from which projects are originated, in software development it is impossible to predict time required to perform work.
This happens because of 2 major reasons:

### Rapid changes
Unlike in Construction, in software external factors and requirements are changing to often, and too often there is a situation that current solution can not support new requirements and significant rework is required.
Interesting point is that for most of people it is easy to understand that on late stages of a building construction it is impossible to change it's  shape, purpose, add ore romove floors. But at the same time they do not understand that exactly same rules are applied to the software solutions.

### No statistics
2. Most of the work is going to be done at first time. It means that there is no statistics which allows
This is why in most of the cases estimates either lie 
The reason for that is most of the projects are done at first time and most of work also is going 

## CP Process Decomposition 

Actual process of transforming **Idea** to **Value** may be spitted in to 5 simple higlevel steps:
1. Analysis
1. Design (Requirements Production)
1. Implementation
1. Verification
1. Rollout

Lets take a closer look at steps.

### Analysis
At this step, basing on research, input from business side or customers, **Ideas** are created.
It is important to understand that ideas creation is creative process this why it's time line can not be predicted.
Results are placed in **Ideas Bucket** in order to be considered for requirements production on the Design phase.

### Design (Requirements Production)
At this steps, ideas are taken from **Ideas Bucket** and process of designing ouccurs.
During this step requirements are created that must contain exhaustive information, which is enough for engineers to implement and verify.
There must be functional requirements, non function requirements and steps required to verify.
The results of this step are placed into **Design Bucket** in order to be considered for implementation.

### Implementation
On this steps, requirements are taken from **Design Bucket** and implemented.
It is important to note that engineers which implement the requiremnts get more understanding by reading test cases on how they should perfom initial verification that they did everything right.
The results of this step are placed into **Implementation Bucket** in order to be considered for verification.

### Verification
On this step, implementation is taken from **Implementation Bucket** and verified against the requirements.
The goal of this track is to ensure that actual implementation meets all the requirements which were originally specified.
The results of this step are placed into **Rollout Bucket** in order to be delivered to customers.

### Rollout
On this step, value which is ready to rollout is taken from **Rollout Bucket** and delivered to the consumers.

### Process Visualization

Below is a visualization of the process from the sequence view.

![process](./2.svg)

## Threads

At this point we have an understanding what high level steps should be performed to transform **Idea** to **Value**.
Each step takes time to perform and there are dependencies between steps.
In sake of efficiency, same type steps must be performed on separate thread.

This bring us to the idea on having 5 parallel threads.

Because for most of the steps it is required to have input(result of previous step), we utilise buckets to avoid the need of threads syncronisation.

It is important to understand why bucket instead of list is considered. This happens because items for further processing may be taken based on different reasons, likely this is priority but it also may be logical dependency and other reasons.

### Process Visualization

Below is a visualization of the process from the parallel view.

![process](3.svg)

## Notes to consider

At last visualization it's clear to see that less idle occurs, because each thread takes next work to do whenever it is possible.

It is important to understand that there is no sense in trying to feet work in time boundaries.

At this point it should be clear that there is no sense in low level planing, because work occurs as soon as input occurs.
This is why it is important to have bucket full of ideas ready for the next step.

### Rule
There should be only one rule to follow, is that each constantly must have something on input.

## Cross cuting example

Step 1 : Analysis.
Based on customer input PO decidedes to implement a scheduler that would allow to schedule appointments online.
After discussion with SA, it has been decided to implement with O365 \ Exchange.

Step 2 : Design.
PO works together with SA and LQA on exact requirements on how to implement functionality are created, test steps required to test functionality are created also.

Step 3: Implementation.
LDE takes requirement, splits the work between engineers and implementes.
Engineers perform initial verification that everything is done according to requirements

Step 4: Verification.
LQE pefroms tests against the requirements and test cases.
If only implementation meets PO expectations it is considered for rollout.

Step 5: Rollout.
Functionality to schedule the appointments appears in the applications, education materials are prepared, users are informed about new possibilities.

## Roles and Responsibilities

![Roles&Responsiblitise](./rr.png)

### Legend

| Acronym | Full
|:---|:----
| PO | Product Owner
| SA | Solutions Architect
| LE | Lead Engineer
| QE | Quality Engineer
| DE | Dev Engineer
| IX | Interface & Experienc
| BA | Business Analyst
