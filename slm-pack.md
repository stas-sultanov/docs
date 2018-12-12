# Plot

To provide a lifecycle of the solution it is required to have certain tools which are responsible for different areas.  
In general there are 2 options of getting this tools:

* assemble from different tools from different vendors.
* get a pack, so called Solution Lifecycle Management package, from one vendor.

It’s like you need a car to ride and you can go to Mercedes store and buy one or you can get to a market buy separate parts and assemble one.

Following document tries to describe in detail pros and cons of both approaches.

First of all let's take a look at possible options:

*   Option **A - A**tlassian based, as it is takes **at least 3 different products** from [Atlassian](https://www.atlassian.com/).
*   Option **M - M**icrosoft based, as it is **only 1 product** from Microsoft named [Azure DevOps](https://azure.microsoft.com/en-us/services/devops).

## Compare by aspects

Following table compares options by different aspects

| | Area | Option A | | Option M | |
|:--|:----|:------|:--|:------|:--|
| 1 | Cost & Payment |- Purchases from each vendor of each service are separate.<br/>- **Separate invoices** at the end of the month.<br/>- Total **cost** of ownership is **greater** than all-in-one solutions.| - |- All services are purchased from one vendor as pack.<br/>- **One invoice** at the end of the month.<br/>- Total **cost** of ownership is **less** than separate systems.| + |
| 2 | Legal | It is required to accept **different policies** from **each vendor**. | - | It is required to accept **one policy** from **only one vendor**. | + |
| 3 | Security & Compliance | [Atlassian has achieved following certificates for some cloud services:](https://www.atlassian.com/trust/compliance)<br/>- GDPR<br/>- ISO 27001<br/>- SOC 2 Type 1<br/>- CSA STAR Level 1|-| [Microsoft has achieved following list of certificates for Azure DevOps:](https://docs.microsoft.com/en-us/azure/devops/articles/team-services-security-whitepaper?view=vsts#compliance-certifications)<br/>- GDPR<br/>-  ISO 27001:2013<br/>-  SOC 1 Type 2 and SOC 2 Type 2<br/>-  HIPAA<br/>-  BAA<br/>-  EU Model Clauses| + |
| 4 | Identity & Access Management | Requires **separate** management of each user for each system.  Integration of some products with Identity Service is available for **additional cost.** | - | Integrated with Azure Active Directory and has [B2B Collaboration](https://docs.microsoft.com/en-us/azure/active-directory/b2b/what-is-b2b) **out of the box**. | + |
| 5 | Service Management | While most of the services are managed (hosted in the cloud) some services like Jenkins **requires additional infrastructure**, setup and provision. | - | Is **completely managed** service. | + |
| 6 | [Requirements Traceability](https://en.wikipedia.org/wiki/Requirements_traceability) | **Requires purchase** of additional plugins and investment on integartion. | - | Provided **out of the box.** | + |
| 7 | IDE | **Requires additional** plugins. | - | Provides **out of the box** integration within the Visual Studio IDE. | + |
| 8 | Adoption | **Some products** are used already. | + | It may require to educate **some people.** | - |
| **Total** | | | **1** | | **7** |

## Compare by cost

Following table compares options by cost per month

| | Option A | | Option M | |
|:--|:----|:--|:----|:--|
| Area | Product | Cost | Tool | Cost |
| Knowledge Sharing | [Atlassian Confluence](https://www.atlassian.com/software/confluence) |\<10 users: $10<br/>\>10 users: [$5/user](https://www.atlassian.com/software/confluence/pricing) | [Wiki](https://azure.microsoft.com/en-us/services/devops/wiki/) |free: 5 users<br/>extra: [$6/user](https://marketplace.visualstudio.com/items?itemName=ms.vss-vstsuser#pricing)|
| Requirements Management | [Atlassian Jira](https://jira.atlassian.com/) |\<10 users: $10<br/>\>10 users: [$7/user](https://www.atlassian.com/software/jira/pricing) | [Boards](https://azure.microsoft.com/en-us/services/devops/boards/) | Included |
| Repos | [Atlassian Bitbucket](https://www.atlassian.com/software/bitbucket) |\<5 users: free<br/>\>5 users: [$5/user](https://www.atlassian.com/software/bitbucket/pricing?tab=cloud)| [Repos](https://azure.microsoft.com/en-us/services/devops/repos/) | Included |
| Pipelines | [Jenkins](https://jenkins.io/) | \*1 | [Pipelines](https://azure.microsoft.com/en-us/services/devops/pipelines/) | free: 1<br/>extra: [$40/pipe](https://marketplace.visualstudio.com/items?itemName=ms.build-release-hosted-pipelines#pricing) |
| Artifacts | [NuGet Server](https://docs.microsoft.com/en-us/nuget/hosting-packages/nuget-server) | \*1 |[Artifacts](https://azure.microsoft.com/en-us/services/devops/artifacts/) | free: 5 users<br/>extra: [$4/user](https://marketplace.visualstudio.com/items?itemName=ms.feed#pricing) |
| Symbols Server |  | \*1 | [Artifacts](https://azure.microsoft.com/en-us/services/devops/artifacts/) | Included |
| Test | [Gurock TestRail](http://www.gurock.com/testrail/) | [$30/user](http://www.gurock.com/testrail/pricing/cloud/) | [Test Plans](https://azure.microsoft.com/en-us/services/devops/test-plans/) | [$52/user](https://marketplace.visualstudio.com/items?itemName=ms.vss-testmanager-web#pricing) |
| Test Load | [Load Impact](https://loadimpact.com/) | [$300](https://loadimpact.com/pricing) | [Test Plans](https://marketplace.visualstudio.com/items?itemName=ms.vss-testmanager-web#pricing) | free: 20k<br/>extra: [$36/100k](https://docs.microsoft.com/en-us/vsts/billing/buy-load-testing-vs#_buy-load-testing) |

\*1 requires additional infrastructure, setup, provision and maintainance.

## Use scenarios
In order to give understending about aproximate cost of ownership, this section provides several use-case scenarios.
* Stakeholders are operating with requirements only.
* Performance tests, Build & Release agents and Package Management are not included.
* Cost of **Option M** may be reduced if users have [Visual Studio Subscriptions](https://www.visualstudio.com/vs/pricing/).
* Cost to setup and maintan **Opnios A** is not included.

### Scenario 1
Small size team: 3 stakeholders, 5 dev/op, 1 tester.

| | stakeholder | dev/op | test | Totoal |
|:----|:----|:----|:----|:----|
| | 3 | 5 | 1 | |
| **Option A** | | | | **$280** |
| Confluence | | | | $10 | 
| Jira | $30 | $50 | $10 | $90 |
| Bitbucket | | $25 | $5 | $30 |
| TestRail | | $150 | $50 | $180 |
| **Option M** | | | | **$58** |
| Wiki & Boards | | | $6 | $6 |
| Repos | | | Included | $0 |
| Test | | | $52 | $52 |

### Scenario 2
Medium size team: 5 stakeholders, 20 dev/op, 5 testers.

| | stakeholder | dev/op | test | Totoal |
|:----|:----|:----|:----|:----|
| | 5 | 20 | 5 | |
| **Option A** | | | | **$1085** |
| Confluence | $25 | $100 | $25 | $150 | 
| Jira | $35 | $140 | $35 | $210 |
| Bitbucket | | $100 | $25 | $125 |
| TestRail | | | | $600 |
| **Option M** | | | | **$410** |
| Wiki & Boards | | $150 | Included | $150 |
| Repos | | Included | Included | $0 |
| Test | | | $260 | $260 |
