# Plot

To provide a lifecycle of the solution it is required to have certain tools which are responsible for different areas.  
In general there are 2 options of getting this tools:

*   Option A - to assemble from different tools from different vendors.
*   Option M - to get a pack, so called Solution Lifecycle Management package from one vendor.

It’s like you need a car to ride and you can go to Mercedes store and buy one or you can get to a market buy separate parts and assemble one.

Following document tries to describe in detail pros and cons of both approaches.

First of all let's take a look at possible options:

*   Option **A - A**tlassian based, because it is takes **at least 3 different products** from Atlassian.
*   Option **M - M**icrosoft based, because it is **only 1 product** from Microsoft named Visual Studio Team Services.

## Compare by aspects

Following table compares options by different aspects

| | Area | Option A | | Option M | |
|:---|:---|:---|:---|:---|:---|
| 1 | Price & Payment |- Purchases from each vendor of each service are separate.<br/>- **Separate invoices** at the end of the month.<br/>- Total **cost** of ownership is **greater** than all-in-one solutions.| - |- All services are purchased from one vendor as pack.<br/>- **One invoice** at the end of the month.<br/>- Total **cost** of ownership is **less** than separate systems.| + |
| 2 | Legal | It is required to accept **different policies** from **each vendor**. | - | It is required to accept **one policy** from **only one vendor**. | + |
| 3 | Security & Compliance | [Atlassian has achieved following certificates for some cloud services:](https://www.atlassian.com/trust/compliance)<br/>- GDPR<br/>- ISO 27001<br/>- SOC 2 Type 1<br/>- CSA STAR Level 1|-| [Microsoft has achieved following list of certificates for VSTS:](https://docs.microsoft.com/en-us/vsts/articles/team-services-security-whitepaper)<br/>- GDPR<br/>-  ISO 27001:2013<br/>-  HIPAA<br/>-  BAA<br/>-  EU Model Clauses<br/>-  SOC 1 Type 2 and SOC 2 Type 2| + |
| 4 | Identity & Access Management | Requires **separate** management of each user for each system.  Integration of some products with Identity Service is available for **additional cost.** | - | VSTS provides integration with the Azure Active Directory **out of the box**. | + |
| 5 | Service Management | While most of the services are managed (hosted in the cloud) some services like Jenkins **requires additional infrastructure**, setup and provision. | - | VSTS is **completely managed** service. | + |
| 6 | [Requirements Traceability](https://en.wikipedia.org/wiki/Requirements_traceability) | **Requires purchase** of additional plugins. | - | Provided **out of the box.** | + |
| 7 | IDE | **Requires additional** plugins. | - | Provides **out of the box** integration within the Visual Studio IDE. | + |
| 8 | Adoption | **Some products** are used already. | + | It may require to educate **some people.** | - |
| **Total** | | | **1** | | **7** |

## Compare by price

Following table compares options by price

| | Option A | | Option M | |
|:--|:--|:--------|:--|:---------|
| Area | Product | Price | Tool | Price |
| Knowledge Sharing | [Atlassian Confluence](https://www.atlassian.com/software/confluence) |\<10 users: $10/month<br/>\>10 users: [$5/user/month](https://www.atlassian.com/software/confluence/pricing) | [Wiki](https://www.visualstudio.com/team-services/wiki/) |free: 5 users<br/>extra: [$3/user/month](https://marketplace.visualstudio.com/items?itemName=ms.vss-vstsuser#pricing)|
| Requirements Management | [Atlassian Jira](https://jira.atlassian.com/) |\<10 users: [$10/month](https://www.atlassian.com/software/jira/pricing)<br/>\>10 users: $7/user/month | [Agile Tools](https://www.visualstudio.com/team-services/agile-tools/) | Included |
| Source Control | [Atlassian Bitbucket](https://www.atlassian.com/software/bitbucket) |\<5 users: free<br/>\>5 users: [$5/user/month](https://www.atlassian.com/software/bitbucket/pricing?tab=cloud)| [Git](https://www.visualstudio.com/team-services/git/) | Included |
| Build & Release | [Jenkins](https://jenkins.io/) | \*1 | [CI & CD](https://www.visualstudio.com/team-services/continuous-integration/) | free: 240min/month<br/>extra: [$40/pipe/month](https://marketplace.visualstudio.com/items?itemName=ms.build-release-hosted-pipelines#pricing) |
| Test | [Gurock TestRail](http://www.gurock.com/testrail/) | [$25/user/month](http://www.gurock.com/testrail/pricing/cloud/) | [Test Manager](https://www.visualstudio.com/team-services/testing-tools/) | [$52/user/month](https://marketplace.visualstudio.com/items?itemName=ms.vss-testmanager-web#pricing) |
| Test Performance | [Load Impact](https://loadimpact.com/) | [$300/month](https://loadimpact.com/pricing) | [Cloud Based Load Tests](https://www.visualstudio.com/team-services/cloud-load-testing/) | free: 20k-VUMS/month<br/>extra: [$36/100k-VUMS](https://docs.microsoft.com/en-us/vsts/billing/buy-load-testing-vs#_buy-load-testing) |
| Package Management | [NuGet Server](https://docs.microsoft.com/en-us/nuget/hosting-packages/nuget-server) | \*1 |[Package Manager](https://www.visualstudio.com/team-services/reporting/) | free: 5 users<br/>extra: [$4/user/month](https://marketplace.visualstudio.com/items?itemName=ms.feed#pricing) |
| Symbols Server |  | \*1 | [Package Manager](https://www.visualstudio.com/team-services/reporting/) | Included |

\*1 requires additional infrastructure, setup, provision and maintainance.

## Use scenarios
In order to give understending about total cost of ownership, this section provides several use-case scenarios.
Final cost of **Option M** may be reduced by utilizing existing [Visual Studio Subscriptions](https://www.visualstudio.com/vs/pricing/).
Stakeholder are operating with requirements and test cases only.
Performance tests are not included.

### Scenario #1
Small size team: 3 stakeholders, 5 dev/ops, 1 tester.

| | stakeholder | dev/ops | test | Totoal |
|:----|:----|:----|:----|:----|
| | 3 | 5 | 1 | |
| **Option A** | | | | **$280** |
| Confluence | | | | $10 | 
| Jira | $30 | $50 | $10 | $90 |
| Bitbucket | | $25 | $5 | $30 |
| TestRail | | $125 | $25 | $150 |
| **Option M** | | | | **$61** |
| Wiki, Work, Release | | | $5 | $5 | **$101** |
| Source Control | | | Included | $0 |
| Test | | | $52 | $52 |
| Package Management | | | $4 | $4 | developer | tester | Totoal |

### Scenario #2
Mdium size team: 5 stakeholders, 20 developers, 5 testers.

| | stakeholder | dev/ops | test | Totoal |
|:----|:----|:----|:----|:----|
| | 5 | 20 | 5 | |
| **Option A** | | | | **$1085** |
| Confluence | $25 | $100 | $25 | $150 | 
| Jira | $35 | $140 | $35 | $210 |
| Bitbucket | | $100 | $25 | $125 |
| TestRail | | | | $600 |
| **Option M** | | | | **$490** |
| Wiki, Work, Release | | $150 | Included | $150 |
| Source Control | | Included | Included | $0 |
| Test | | | $260 | $260 |
| Package Management | | $80 | Included | $80 |