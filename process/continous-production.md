# Plot

Continuous Production is a flow production method.
This method allows to build most efficient process of transformation **Idea** to **Value** within the software soultion lifecyle.
By efficiency time and money are considered.

For example:
If today PO will generate an idea on how to make customers bring more money.
What would be the most efficient process by which engineers may transform this idea in actual value that must be brought to the customers?

## Digression 
It is crucial to accept the fact that work can be done when it can be done and not earlier.

## Steps

Actual process of transforming **Idea** to **Value** may be spitted in to 5 simple higlevel steps:
1. Idea Creation
1. Requirements Production
1. Implementation
1. Verification
1. Rollout

Lets take a closer look at steps.

### Creation
At this step, basing on research, input from business side or customers, **Ideas** are created.
It is important to understand that ideas creation is creative process this why it's time line can not be predicted.
Results are placed in **Ideas Bucket** in order to be considered for requirements production.

### Requirements
At this steps, ideas are taken from **Ideas Bucket** and transformed into requirements.
Requirements must contain exhaustive information, which is enough for engineers to implement and verify.
There must be functional requirements, non function requirements and steps required to verify.
The results of this step are placed into **Requirements Bucket** in order to be considered for implementation.

### Implementation
On this steps, requirements are taken from **Requirements Bucket** and implemented.
It is important to note that engineers which implement the requiremnts get more understanding by reading test cases on how they should perfom initial verification that they did everything right.
The results of this step are placed into **Implementation Bucket** in order to be considered for verification.

### Verification
On this step, implementation is taken from **Implementation Bucket** and verified against the requirements.
The goal of this track is to ensure that actual implementation meets all the requirements which were originally specified.
The results of this step are placed into **Rollout Bucket** in order to be delivered to customers.

### Rollout
On this step, value which is ready to rollout is taken from **Rollout Bucket** and delivered to the consumers.

## Threads

At this point we have an understanding what high level steps should be performed to transform **Idea** to **Value**.
Each step takes time to perform and there are dependencies between steps.
In sake of efficiency, same type steps must be performed on separate thread.

This bring us to the idea on having 5 parallel threads.

Because for most of the steps it is required to have input(result of previous step), we utilise buckets to avoid the need of threads syncronisation.

It is important to understand why bucket instead of list is considered. This happens because items for further processing may be taken based on different reasons, likely this is priority but it also may be logical dependency and other reasons.

## Process Visualization

Below is a visualization of the process of continuous production.

![process](./2.svg)

Visualization of the bare same process, but from another point of view.
At this visualization it's clear to see that no idle occurs, because each thread takes next work to do whenever it is possible.

![process](3.svg)

It is important to understand that there is no sense in trying to feet work in time boundaries.

At this point it should be clear that there is no sense in low level planing, because work occurs as soon as input occurs.
This is why it is important to have bucket full of ideas ready for the next step.

### Rule
There should be only one rule to follow, is that each constantly must have something on input.

## Cross cuting example

Step 1 : Idea creation.
Based on customer input PO decidedes to implement a scheduler that would allow to schedule appointments online.
After discussion with SA, it has been decided to implement with O365 \ Exchange.

Step 2 : Requiremtes production.
PO works together with SA and LQA on exact requirements on how to implement functionality are created, test steps required to test functionality are created also.

Step 3: Implementation.
LDE takes requirement, splits the work between engineers and implementes.
Engineers perform initial verification that everything is done according to requirements

Step 4: Verification.
LQE pefroms tests against the requirements and test cases.
If only implementation meets PO expectations it is considered for rollout.

Step 5: Rollout.
Functionality to schedule the appointments appears in the applications, education materials are prepared, users are informed about new possibilities.
