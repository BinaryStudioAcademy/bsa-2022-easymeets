# BSA 2022 | .NET | EasyMeets

EasyMeets is is a scheduling platform that makes it easier to track users' availability and schedule meetings with internal teams and external people. It's responsible for tracking and managing user's calendars, sharing their availability, automatic event creation, and reminder sending.

**Technologies:**

Backend:

- Platform: .NET 6
- Network: REST, SignalR, RabbitMQ
- Database: MS SQL Server, Entity Framework Core
- Cloud: Azure
- Other: JWT, Firebase, Docker

Frontend:

- Angular
- HTML5/CSS3/SASS

## Links:

- [Website]()
- [Trello Board](https://trello.com/b/8iNdzdLQ/easymeets)

## Building sources

By default, apps run on the following ports:

| Application            | Port |
| ---------------------- | ---- |
| EasyMeets.**Core**     | 5050 |
| EasyMeets.**Notifier** | 5070 |
| RabbitMQ               | 5672 |

_Tip: If you want to connect to the specific service outside of docker, then use "localhost" as a service name, but if both services are inside docker, use service_name from a "docker-compose" file instead._

## DB Schema

```mermaid
erDiagram
  User {
      int Id
      nvarchar Name
      nvarchar Email
      nvarchar PhoneNumber
      nvarchar ImagePath
      nvarchar Country
      nvarchar TimeZone
      datetime CreatedAt
      datetime UpdatedAt
  }

  Event ||--o{ User : CreatorId
  Event ||--o{ Team : TeamId
  Event {
      int Id
      nvarchar Name
      string Description
      int Duration
      datetime EventStartTime
      int CreatorId
      int TeamId
      datetime CreatedAt
      datetime UpdatedAt
  }

  Team {
      int Id
      nvarchar LogoPath
      nvarchar Name
      nvarchar Email
      nvarchar PageLink
      nvarchar TimeZone
      string Description
      datetime CreatedAt
      datetime UpdatedAt
  }

  TeamCalendar ||--o{ Team : FromTeamId
  TeamCalendar ||--o{ Team : VisibleForTeamId
  TeamCalendar ||--o{ Calendar : CalendarId
  TeamCalendar {
      int Id
      int FromTeamId
      int VisibleForTeamId
      int CalendarId
      boolean CheckForConflicts
      datetime CreatedAt
      datetime UpdatedAt
  }

  Calendar ||--o{ User : UserId
  Calendar {
      int Id
      nvarchar Email
      int UserId
      datetime CreatedAt
      datetime UpdatedAt
  }

  ExternalAttendee ||--o{ Event : EventId
  ExternalAttendee {
      int Id
      int EventId
      time EventTime
      nvarchar Name
      nvarchar Email
      datetime CreatedAt
      datetime UpdatedAt
  }

  ExternalAttendeeAvailability ||--o{ ExternalAttendee : ExternalAttendeeId
  ExternalAttendeeAvailability {
      int Id
      int ExternalAttendeeId
      datetime StartEvent
      datetime EndEvent
  }

  TeamMemberEvent ||--o{ Event : EventId
  TeamMemberEvent ||--o{ Team : UserTeamId
  TeamMemberEvent {
      int EventId
      int UserTeamId
      datetime CreatedAt
      datetime UpdatedAt
  }

  UserTeam ||--o{ User : UserId
  UserTeam ||--o{ Team : TeamId
  UserTeam ||--o{ Role : RoleId
  UserTeam {
      int UserId
      int RoleId
      int TeamId
      int Status
      datetime CreatedAt
      datetime UpdatedAt
  }

  Role {
      int Id
      string Name
      datetime CreatedAt
      datetime UpdatedAt
  }

  Question ||--o{ AvailabilitySlot : AvailabilitySlotId
  Question {
      int Id
      int AvailabilitySlotId
      string QuestionText
      datetime CreatedAt
      datetime UpdatedAt
  }

  AvailabilitySlot ||--o{ MeetingLocation : MeetingLocationId
  AvailabilitySlot {
      int Id
      nvarchar Name
      string Description
      string Link
      int State
      int Type
      int Size
      int LocationId
      datetime CreatedAt
      datetime UpdatedAt
  }

  MeetingLocation {
      int Id
      string Name
      datetime CreatedAt
      datetime UpdatedAt
  }
```

## Code quality

Make sure you read and follow [.NET Quality Criteria](https://github.com/BinaryStudioAcademy/quality-criteria/blob/production/source/dotnet.md).
Also, there are some best practices for frontend development: [Angular](https://angular.io/guide/styleguide) and [Typescript](https://google.github.io/styleguide/tsguide.html)

#### Docker:

1. Make sure you have [Docker](https://www.docker.com) and [Docker Compose](https://docs.docker.com/compose/install).
2. Pull this repo to your machine.
3. You can build and run all application containers via `docker-compose -f docker-compose.apps.yml up -d` command.
4. You can pull and run all 3rd-party services (MSSQL Server, RabbitMQ) via `docker-compose -f docker-compose.services.yml up -d` command.
5. Happy coding! :sunglasses:

#### Setup environment for local development:

1. Download and install [.NET 6 SDK](https://dotnet.microsoft.com/download).
2. It might be usefull to have EF CLI. Install via command: _dotnet tool install --global dotnet-ef_
3. Download and install LTS version of [Node.js](https://nodejs.org/en/)
4. Install Angular-CLI via: _npm install -g @angular/cli_. _[What is Angular-CLI?](https://angular.io/cli)_

## Extensions for frontend development (required):

- ESLint (analysis tool that checks TypeScript\JavaScript code for readability, maintainability, and functionality errors)
- EditorConfig (helps maintain consistent coding styles for multiple developers working on the same project)

Some extra extensions which can significantly help to work with Angular:

- Angular Language Service (intelliSense for Angular templates)
- Angular Snippets
- Angular Schematics (working with Angular schematics via UI)

## Environment variables

This is a list of the required environment variables:

#### RabbitMQ

**RABBIT_MQ_USERNAME** - RabbitMQ username

**RABBIT_MQ_PASSWORD** - RabbitMQ user password

#### MSSQL Server

**SA_PASSWORD** - MSSQL Server "SA" user password
