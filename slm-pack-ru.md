## Выбор средств обеспечения жизненого цикла решений

> Жизненный цикл решения - совокупность стадий развития, которые проходит решение за период своего существования начиная от момента возникновения идеи до утилизации.

Все привет! Меня зовут Стас и по долгу службы мне часто приходится иницировать старт проектов.
Одним из первых вопросов возникающих при запуске проекта является выбор средств обеспечения жизненого цикла решения. То есть какие именно средства разработчики будут использовать.
Стоит отметить, что так-же довольно часто приходится присоеднеится к уже идущему проекту который старотовали на чем было и возникает вопрос о изменении средств.

Для обеспечения жизненого цикла необходимо иметь ряд утелит ответсвенных за разные зоны
Минимальный набор выглядит следующим образом
Знания например Wiki, Управление требованиями Kanban board, Репозиторий git, Система сборки и управления выпусками (piplines), Тестирование (функциональное и нагрузочное). 
По хорошему еще нужна
- IDE интегрирвоанная со всеми системами
- Система мониторинга и предиктивной аналитики
- Система сбора 

В общем, есть 2 варианта получения этого набора сервисов:

* собрать из разных инструментов от разных поставщиков.
* использовать пакет от одного поставщика.

Это как будто вам нужна машина, чтобы ездить, и вы можете взять ее купить или взять в аренду и ездить сразу, или вы можете купить запчасти и собрать из них папелац.

Текущий документ пытается подробно описать плюсы и минусы обоих подходов.

Прежде всего, давайте посмотрим на возможные варианты:
Естественно что на рынке существует огромное количество сервисов 
В данной статье я рассматривается именно те и в той комбинации которые мне больше всего встречались по ходу работы. 

* Вариант A - на основе Atlassian, так как он принимает ** как минимум 3 различных продукта ** от [Atlassian] (https://www.atlassian.com/) иногда Atlassian Stack.
* Опция ** M - M ** на базе Microsoft, так как это ** только 1 продукт ** от Microsoft с именем [Azure DevOps] (https://azure.microsoft.com/en-us/services/devops). До недавнего времени являлся одним продуктом Visual Studio Team Services.

### Сравнение по аспектам

Following table compares options by different aspects

| Area | Вариант A | Вариант M |
|:-----|:----------|:----------|
| Цена и Оплата |- Отдельная покупка каждого сервиса у разных поставщиков.<br/> - Отдельные счета-фактуры в конце месяца.<br/> - Совокупная стоимость владения **больше**, чем решение 'все в одном'.| - Все услуги приобретаются у одного поставщика в виде пакета.<br/> - **Один счет-фактура** в конец месяца.<br/> - Совокупная стоимость владения **меньше**, чем у отдельных систем.|
| Юридический | Требуется принять **различные политики** от каждого поставщика. | Требуется принять только **одну политику** от одного поставщика. | + |
| Аутентификация и управление доступом | Требуется ** отдельное ** управление каждым пользователем для каждой системы. Интеграция некоторых продуктов с централизированной системой аутентификации доступна за **дополнительную плату**. | Интегрирован с Azure Active Directory и имеет [B2B Collaboration] (https://docs.microsoft.com/en-us/azure/active-directory/b2b/what-is-b2b) **из коробки**. |
| Service Management | While most of the services are managed (hosted in the cloud) some services like Jenkins **requires additional infrastructure**, setup and provision. | - | Is **completely managed** service. | + |
| [Requirements Traceability](https://en.wikipedia.org/wiki/Requirements_traceability) | **Requires purchase** of additional plugins and investment on integartion. | - | Provided **out of the box.** | + |
| IDE | **Requires additional** plugins. | - | Provides **out of the box** integration within the Visual Studio IDE. | + |
| Adoption | **Some products** are used already. | + | It may require to educate **some people.** | - |
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

