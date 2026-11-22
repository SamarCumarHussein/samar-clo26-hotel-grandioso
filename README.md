# Hotel Grandioso — Inlämning 1

**Namn:** [ditt namn]

## Så kör du projektet

1. Forka repot på GitHub och klona din fork
2. Öppna `HotelGrandioso.slnx` i Visual Studio (eller öppna mappen i VS Code)
3. Tryck **F5** för att starta

Via terminalen:

```bash
dotnet run --project HotelGrandioso
```

## Databas

- Databas: [SQLite eller LocalDB]
- Migrationer: [hur du skapar och kör dem]

## UML-klassdiagram

```mermaid
classDiagram
    class Room {
        +int Id
        +int RoomNumber
        +int RoomTypeId
        +RoomType RoomType
        +List~Booking~ Bookings
    }

    class RoomType {
        +int Id
        +string Name
        +decimal PricePerNight
        +List~Room~ Rooms
    }

    class Guest {
        +int Id
        +string FirstName
        +string LastName
        +string Email
        +List~Booking~ Bookings
    }

    class Booking {
        +int Id
        +int RoomId
        +int GuestId
        +DateTime CheckIn
        +DateTime CheckOut
        +Room Room
        +Guest Guest
    }

    RoomType "1" --> "*" Room : har
    Room "1" --> "*" Booking : bokas
    Guest "1" --> "*" Booking : gör
```

```

## GDPR

Utvärdera fälten i `Guest` ett i taget. Vad bygger du in, och varför?

>

## Designmönster

Beskriv det designmönster du använt (till exempel Repository), vad det gör och varför du valde det.

>

## Tekniker

- C# / .NET 10
- Entity Framework Core
