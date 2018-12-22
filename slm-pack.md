# Plot

Solution Lifecycle Management is a very complicated process.
To ensure the proces it is required to have certain types of services which provides different functionality.
Following table describes types of services and their functionality:

| Service                 | Functionality 
|-------------------------|--------------
| Auth                    | Centralized authentication and authorization of users, services and applications.<br/>All other tools integrate with this.
| Communication           | Chat-based communication within the team.<br/>Audio and video calls with record, index and search by keywords.
| Knowledge Sharing       | Share project knowledge between all team members.<br/>Based on the de facto industrial standard [Markdown](https://en.wikipedia.org/wiki/Markdown).
| Requirements Management | Plan and track work, bugs, and issues.
| Repos                   | Version control system.<br/>Implementation of the de facto industrial standard  [Git](https://en.wikipedia.org/wiki/Git).
| Pipelines               | Automatically build, test and deploy solution to any stage and environment.
| Artifacts               | Organize and control access to packages.</br>Including [Debug Symbols](https://en.wikipedia.org/wiki/Debug_symbol), [NuGet](https://en.wikipedia.org/wiki/NuGet), [NPM](https://en.wikipedia.org/wiki/Npm_(software)), [Maven](https://en.wikipedia.org/wiki/Apache_Maven) and others.
| Test                    | Provide all types of tests and continous testing.
| Load Test               | Generate a load and measure quality of service. 
| Monitor                 | Мониторинг решения и предиктивная аналитики.
| Feedback                | Сбор отзывов о использовании решения.
| IDE                     | Development environment.</br>Integrated with all other services.

## Asembly

In general there are two options to assemble all the services requeired.
First one is to get different services from different vendors and the other is to get a pack of services from one vendor.

It is like you need a car to ride and you can go to Tesla web site and buy one or you can get to a market buy separate parts and assemble one.

1. option is Atlassian based, and it takes **at max 3 different services** from [Atlassian](https://www.atlassian.com/).
2. option is Microsoft based, and **all services** are provided by Microsoft.

## Compare options by aspects

Following table compares options by different aspects.

| Aspects            | Option 1 | Option 2 |
|:-------------------|:---------|:---------|
| Identity & Access  | Requires **separate** management of each user for each system.<br/>Integration with Auth service requires **additional investment.** | Integrated with Azure Active Directory and provides [B2B Collaboration](https://docs.microsoft.com/en-us/azure/active-directory/b2b/what-is-b2b) **out of the box**.
| Management         | While most of the services are managed hosted in the cloud.<br/>Some services **requires additional** infrastructure, setup and provision. | Is **completely managed** solution.
| Legal              | It is required to accept **different policies** from **each vendor**. | It is required to accept policy from **only one vendor**.
| Compliance         | [Atlassian declares](https://www.atlassian.com/trust/compliance) compliance with the following requirements:<br/>GDPR, ISO 27001, SOC 2 Type 1, CSA STAR Level 1.<br/>Compliance with other services supplier requirements - the big question. | [Microsoft declares](https://docs.microsoft.com/en-us/azure/devops/articles/team-services-security-whitepaper?view=vsts#compliance-certifications) compliance with the following requirements:<br/>GDPR, ISO 27001: 2013, SOC 1 Type 2, SOC 2 Type 2, HIPAA, BAA, EU Model Clauses.
| Traceability       | **Requires investment** to setup. | Provided **out of the box**.
| Cost & Payment     | Purchases from each vendor of each service are separate.<br/>**Separate invoices** at the end of the month.<br/>Total **cost** of ownership is **greater** than all-in-one solutions.| All services are purchased from one vendor as pack.<br/>**One invoice** at the end of the month.<br/>Total **cost** of ownership is **less** than separate systems.

Following table describes what exact services are included in the options and how much do they cost per month.

| Area                    | Option 1 Tool | Cost | Option 2 Tool | Cost
|:------------------------|:--------------|:-----|:--------------|:-----
| Auth                    | [G Suit](https://confluence.atlassian.com/cloud/security-with-g-suite-938859740.html) | ??? | [Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/) | free: basic<br/>extra: [$1/user](https://azure.microsoft.com/en-us/pricing/details/active-directory/)
| Communicatinos          | [Slack](https://slack.com/) | [$6.67/user](https://slack.com/pricing) | [Teams](https://products.office.com/en-us/microsoft-teams/group-chat-software) | domain: [$5/user](https://products.office.com/en-us/microsoft-teams/free)<br/>guests: free
| Knowledge Sharing       | [Atlassian Confluence](https://www.atlassian.com/software/confluence) |\<10 users: $10<br/>\>10 users: [$5/user](https://www.atlassian.com/software/confluence/pricing) | [Wiki](https://azure.microsoft.com/en-us/services/devops/wiki/) |free: 5 users<br/>extra: [$6/user](https://marketplace.visualstudio.com/items?itemName=ms.vss-vstsuser#pricing)
| Requirements Management | [Atlassian Jira](https://jira.atlassian.com/) |\<10 users: $10<br/>\>10 users: [$7/user](https://www.atlassian.com/software/jira/pricing) | [Boards](https://azure.microsoft.com/en-us/services/devops/boards/) | Included
| Repos                   | [Atlassian Bitbucket](https://www.atlassian.com/software/bitbucket) |\<5 users: free<br/>\>5 users: [$5/user](https://www.atlassian.com/software/bitbucket/pricing?tab=cloud)| [Repos](https://azure.microsoft.com/en-us/services/devops/repos/) | Included
| Pipelines               | [Jenkins](https://jenkins.io/) | \*1 | [Pipelines](https://azure.microsoft.com/en-us/services/devops/pipelines/) | free: 1<br/>extra: [$40/pipe](https://marketplace.visualstudio.com/items?itemName=ms.build-release-hosted-pipelines#pricing)
| Artifacts               | [MyGet](https://www.myget.org) | 5 feeds: [$40](https://www.myget.org/pricing) | [Artifacts](https://azure.microsoft.com/en-us/services/devops/artifacts/) | free: 5 users<br/>extra: [$4/user](https://marketplace.visualstudio.com/items?itemName=ms.feed#pricing)
| Test                    | [Gurock TestRail](http://www.gurock.com/testrail/) | [$30/user](http://www.gurock.com/testrail/pricing/cloud/) | [Test Plans](https://azure.microsoft.com/en-us/services/devops/test-plans/) | [$52/user](https://marketplace.visualstudio.com/items?itemName=ms.vss-testmanager-web#pricing)
| Test Load               | [Load Impact](https://loadimpact.com/) | [$300](https://loadimpact.com/pricing) | [Load Tests](https://docs.microsoft.com/en-us/azure/devops/test/load-test/get-started-simple-cloud-load-test?view=vsts) | free: 20k<br/>extra: [$36/100k](https://docs.microsoft.com/en-us/vsts/billing/buy-load-testing-vs#_buy-load-testing)

### Cost of ownership

In order to give understending about aproximate cost of ownership, this section provides several use-case scenarios.

- Stakeholders are operating with requirements only.
- All team members have at least read access to tests system.
- Cost of Load Tests and Pipelines Agents is not included.
- Cost of **Option M** may be reduced if users have [Visual Studio Subscriptions](https://www.visualstudio.com/vs/pricing/).

**Case 1** - Small size team: 3 stakeholders, 5 devs, 1 tester.

|              | 3х stakeholder | 5х dev   | 1х test      | Total
|--------------|----------------|----------|--------------|------
| **Option 1** |                |          |              | **\$350**
| Confluence   | Pack           | Pack     | Pack         | \$10
| Jira         | \$30           | \$50     | \$10         | \$90
| Bitbucket    | Not Required   | \$25     | \$5          | \$30
| MyGet        | Not Required   | \$40     | Not Required | \$40
| TestRail     | Not Required   | \$150    | \$30         | \$180
| **Option 2** |                |          |              | [**\$58**](https://azure.com/e/e2fab501432549e9838fda96a28209fe)
| Wiki         | Included       | Included | Included     | \$0
| Boards       | Included       | Included | \$6          | \$6
| Repos        | Not Required   | Included | Included     | \$0
| Artifacts    | Not Required   | Included | Not Required | \$0
| Test Plans   | Not Required   | Included | \$52         | \$52

**Case 2** - Medium size team: 5 stakeholders, 20 devs, 5 testers.

|              | 5х stakeholder | 20х dev  | 5х test      | Total
|--------------|----------------|----------|--------------|------
| **Option 1** |                |          |              | **\$1422**
| Confluence   | \$25           | \$100    | \$25         | \$150
| Jira         | \$35           | \$140    | \$35         | \$210
| Bitbucket    | Not Required   | \$100    | \$25         | \$125
| MyGet        | Not Required   | \$117    | Not Required | \$117
| TestRail     | Not Required   | Pack     | Pack         | \$820
| **Option 2** |                |          |              | [**\$470**](https://azure.com/e/b924bc65abf04e2090a7d171aa9a2cac)
| Wiki         | Included       | Included | Included     | \$0
| Boards       | Included       | \$150    | Included     | \$150
| Repos        | Not Required   | Included | Included     | \$0
| Artifacts    | Not Required   | \$60     | Not Required | \$60
| Test Plans   | Not Required   | Included | \$260        | \$260