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
| EasyMeets.**Emailer**  | 5060 |
| EasyMeets.**Watcher**  | 5090 |
| RabbitMQ               | 5672 |

_Tip: If you want to connect to the specific service outside of docker, then use "localhost" as a service name, but if both services are inside docker, use service_name from a "docker-compose" file instead._

## DB Schema

```mermaid
erDiagram
  User {
      bigint Id
      nvarchar Name
      nvarchar Email
      nvarchar PhoneCode
      nvarchar PhoneNumber
      nvarchar ImagePath
      int Country
      int Language
      int TimeFormat
      int DateFormat
      boolean IsBanned
      boolean IsDeleted
  }

  TeamMember }o--|| User : UserId
  TeamMember }o--|| Team : TeamId
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
      int TimeZone
      string Description
      boolean IsDeleted
  }

  CalendarVisibleForTeam }o--|| Calendar : CalendarId
  CalendarVisibleForTeam }o--|| Team : TeamId
  CalendarVisibleForTeam {
      bigint Id
      bigint CalendarId
      bigint TeamId
      bool IsDeleted
  }

  Calendar }o--|| User : UserId
  Calendar }o--|| Team : AddEventFromTeamId
  Calendar{
      bigint Id
      boolean CheckForConflicts
      bigint UserId
      boolean IsDeleted
      int AddEventFromTeamId
      nvarchar ConnectedCalendar
      nvarchar AccessToken
      nvarchar RefreshToken
      nvarchar Uid
      datetime CreatedAt
      datetime UpdatedAt
  }

  SlotMember }o--|| User : MemberId
  SlotMember }o--|| AvailabilitySlot : SlotId
  SlotMember }o--|| Schedule : ScheduleId
  SlotMember {
      bigint Id
      bigint MemberId
      int SlotId
      bigint ScheduleId
      int Priority
      bool IsDeleted
  }

  Meeting ||--o{ User : AuthorId
  Meeting ||--o{ Team : TeamId
  Meeting }o--o| AvailabilitySlot : AvailabilitySlotId
  Meeting {
      bigint Id
      nvarchar Name
      int Duration
      datetime StartTime
      bigint AuthorId
      bigint TeamId
      int LocationType
      nvarchar MeetingRoom
      boolean IsDeleted
      datetime CreatedAt
      datetime UpdatedAt
      nvarchar MeetingLink
      bigint AvailabilitySlotId
  }

  MeetingMember }o--||Meeting: MeetingId
  MeetingMember }o--||TeamMember: TeamMemberId
  MeetingMember {
      bigint MeetingId
      bigint TeamMemberId
  }

  AvailabilitySlot }o--|| Team : TeamId
  AvailabilitySlot{
    bigint Id
    nvarchar Name
    nvarchar WelcomeMessage
    nvarchar Link
    int State
    int Type
    int Size
    int LocationType
    nvarchar MeetingRoom
    boolean IsDeleted
    bigint AuthorId
    bigint TeamId
    boolean IsEnabled
    boolean IsVisible
    int Color
    nvarchar Language
    int BookingsPerDay
    bool AllowToAddGuests
    bool PasswordProtectionIsUsed
    nvarchar PasswordProtection
    bool TimeZoneVisibility
    datetime CreatedAt
    datetime UpdatedAt
  }

  Questions }o--|| AvailabilitySlot : AvailabilitySlotId
  Questions {
    bigint Id
    bigint Order
    bigint AvailabilitySlotId
    nvarchar QuestionText
    boolean IsMandatory
    boolean IsDeleted
  }

  AdvancedSlotSettings |o--|| AvailabilitySlot : AvailabilitySlotId
  AdvancedSlotSettings {
    bigint Id
    bigint AvailabilitySlotId
    int ActivityType
    int Days
    datetime StartDate
    int MaxNumberOfBookings
    int PaddingMeeting
    int MinBookingMeetingDifference
    int Frequency
    bool IsDeleted
  }

  ExternalAttendee }o--|| AvailabilitySlot : AvailabilitySlotId
  ExternalAttendee }o--|| Meeting : MeetingId
  ExternalAttendee{
    bigint Id
    bigint AvailabilitySlotId
    bigint MeetingId
    nvarchar Name
    nvarchar Email
    nvarchar TimeZone
    boolean IsDeleted
  }

  Schedule{
    bigint Id
    int TimeZone
    bool WithTeamMembers
    bool IsDeleted
  }

  ScheduleItem }o--|| Schedule : ScheduleId
  ScheduleItem{
    bigint Id
    bigint ScheduleId
    time Start
    time End
    int WeekDay
    bool IsEnabled
    bool IsDeleted
  }

  Credentials }o--|| User : UserId
  Credentials{
    bigint Id
    bigint UserId
    nvarchar AccessToken
    nvarchar RefreshToken
    int LifeCycle
    datetimeoffset UpdatedAt
    int Type
    bit IsDeleted
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
2. It might be useful to have EF CLI. Install via command: _dotnet tool install --global dotnet-ef_
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
