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

- [Website](https://bsa-easymeets.westeurope.cloudapp.azure.com)
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
      bigint Id
      nvarchar Name
      nvarchar Email
      nvarchar PhoneNumber
      nvarchar ImagePath
      int Country
      int Language
      int TimeFormat
      int DateFormat
      int TimeZone
      boolean IsBanned
      boolean IsDeleted
  }

  TeamMember ||--o{ User : UserId
  TeamMember ||--o{ Team : TeamId
  TeamMember {
      bigint Id
      bigint UserId
      int Role
      int Status
      bigint TeamId
      boolean IsDeleted
  }

  Team {
      bigint Id
      nvarchar LogoPath
      nvarchar Name
      nvarchar PageLink
      nvarchar TimeZone
      string Description
      boolean IsDeleted
  }

  CalendarVisibleForTeam ||--o{ Calendar : CalendarId
  CalendarVisibleForTeam ||--o{ Team : TeamId
  CalendarVisibleForTeam {
      bigint Id
      bigint CalendarId
      bigint TeamId
      bool IsDeleted
  }

  Calendar ||--o{ User : UserId
  Calendar ||--o{ Team : AddEventFromTeamId
  Calendar{
      bigint Id
      boolean CheckForConflicts
      bigint UserId
      boolean IsDeleted
      int AddEventFromTeamId
      datetime CreatedAt
      datetime UpdatedAt
  }

  TeamMemberMeeting ||--o{ User : UserTeamId
  TeamMemberMeeting ||--o{ Meeting : EventId
  TeamMemberMeeting {
      bigint Id
      bigint UserTeamId
      int EventId
      int Priority
      bool IsDeleted
  }

  Meeting ||--o{ User : AuthorId
  Meeting ||--o{ Team : TeamId
  Meeting ||--o{ Location : LocationId
  Meeting {
      bigint Id
      nvarchar Name
      nvarchar Description
      int Duration
      datetime StartTime
      bigint AuthorId
      bigint TeamId
      bigint LocationId
      boolean IsDeleted
      datetime CreatedAt
      datetime UpdatedAt
  }

  Location {
    bigint Id
    nvarchar Name
    bool IsDeleted
  }

  UserSlot ||--o{ User : UserId
  UserSlot ||--o{ AvailabilitySlot : AvailabilitySlotId
  UserSlot {
    bigint Id
    bigint UserId
    bigint AvailabilitySlotId
    bool IsDeleted
  }

  AvailabilitySlot ||--o{ Location : LocationId
  AvailabilitySlot{
    bigint Id
    nvarchar Name
    nvarchar WelcomeMessage
    nvarchar Link
    int State
    int Type
    int Size
    bigint LocationId
    boolean IsDeleted
    bigint AuthorId
    bigint TeamId
    boolean IsEnabled
    boolean IsVisible
    int Frequency
    nvarchar Language
    int BookingsPerDay
    bool AllowToAddGuests
    nvarchar PasswordProtection
    bool TimeZoneVisibility
    datetime CreatedAt
    datetime UpdatedAt
  }

  Questions ||--o{ AvailabilitySlot : AvailabilitySlotId
  Questions {
    bigint Id
    bigint AvailabilitySlotId
    nvarchar QuestionText
    boolean IsDeleted
  }

  AdvansedSlotSettings ||--o{ AvailabilitySlot : AvailabilitySlotId
  AdvansedSlotSettings {
    bigint Id
    bigint AvailabilitySlotId
    int ActivityType
    int Days
    datetime StartDate
    int MaxNumberOfBookings
    int PaddingMeeting
    int MinBookingMeetingDifference
    int Color
    bool IsDeleted
  }

  ExternalAttendee ||--o{ AvailabilitySlot : AvailabilitySlotId
  ExternalAttendee{
    bigint Id
    bigint AvailabilitySlotId
    datetime EventTime
    nvarchar Name
    nvarchar Email
    boolean IsDeleted
  }

  ExternalAttendeeAvailability ||--o{ ExternalAttendee : ExternalAttendeeId
  ExternalAttendeeAvailability{
    bigint Id
    bigint ExternalAttendeeId
    datetime StartDate
    datetime EndDate
    bool IsDeleted
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
