# Summary

The **Spotify Clone using ASP.NET MVC** is a database course project aimed at developing a web application that replicates the functionalities of Spotify. The project utilizes the ASP.NET MVC framework, C# programming language, and SQL Server database management system. The primary goals of the project include creating a user-friendly web application with features such as music search, playlist creation, artist following, and secure user management. The project focuses on designing an efficient database schema and integrating it with the ASP.NET MVC framework. The system architecture includes a presentation layer, controller layer, model layer, and database. The database design encompasses entities such as users, artists, albums, tracks, and playlists with appropriate relationships. The implementation process involves setting up the project structure, implementing authentication and authorization, designing the database schema, creating controllers and views, and integrating the database access logic. Upon completion, the Spotify Clone using ASP.NET MVC project demonstrates an understanding of database concepts, ASP.NET MVC framework, and web development principles.

![image](https://github.com/OpticalAbyss/Notify/assets/91399719/7f20f5c3-fbc7-44db-acd4-92beea0764fa)

## Project Proposal

### I. Primary Goals

1. Develop a user-friendly web application with a similar user experience to Spotify.
2. Implement a secure authentication and authorization system for user management.
3. Enable users to search and play music, create, and manage playlists, and follow their favorite artists.
4. Ensure smooth integration of the database with the ASP.NET MVC framework.
5. Demonstrate understanding of database concepts, ASP.NET MVC framework, and web development principles.

### II. Technologies Used

- ASP.NET MVC: Web application framework for building scalable and maintainable web applications.
- C#: Programming language used for developing application logic.
- MS SQL Server: Relational database management system for storing and managing the application's data.
- Entity Framework: Object-relational mapping framework for interacting with the database.
- HTML, CSS, JavaScript: Front-end technologies for designing and implementing the user interface.
- Bootstrap: CSS framework for responsive and visually appealing web design.
- JWT: JSON-based web token system for sessions.

### III. System Architecture

1. Presentation Layer: Implements the user interface using HTML, CSS, and JavaScript. Utilizes the ASP.NET MVC framework for routing requests and rendering views.
2. Controller Layer: Handles user requests, processes business logic, and interacts with the database through the model layer.
3. Model Layer: Contains the data access logic and interacts with the database using Entity Framework.
4. Database: Stores user information, music, playlists, artists, and other relational data.

## Design

### I. Database Design

![image](https://github.com/OpticalAbyss/Notify/assets/91399719/a3428f9b-f872-4d0e-8d6d-60916c0058b4)

The database design for the Spotify Clone project includes the following entities and relationships:

- User: Stores user information such as username, password, email, and isAdmin flag.
- Artist: Represents music artists with attributes like name, genre, and image.
- Album: Contains information about music albums, including title, release date, and cover image.
- Track: Represents individual music tracks with attributes like title, duration, and artist information.
- Playlist: Stores user-created playlists with attributes like title, description, and image.
- Play track: Contains the relationship between playlists and associated tracks.
- Likes: Contains the relationship between users and associated tracks.

The relationships between these entities are established using foreign key constraints, allowing efficient retrieval of related data.

## Implementation I

### I. Basic SQL

Table creation SQL statements for the database entities:

```sql
-- Table creation statements

CREATE TABLE [Notify].[dbo].[Albums] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [Atrist_ID] INT NOT NULL,
    [Image] NVARCHAR(MAX) NOT NULL,
    [Name] NVARCHAR(MAX) NOT NULL,
    [ReleaseDate] DATETIME2
);

-- Additional table creation statements...

```

Sample SELECT query:

```sql
-- Sample SELECT query

SELECT TOP (1000) [ID], [Name], [Image], [User_ID], [Description]
FROM [Notify].[dbo].[Playlists]
```

### II. Advanced SQL

Sample trigger creation SQL statement:

```sql
-- Trigger creation statement

CREATE TRIGGER UpdateLikesCount
ON [Likes]
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [Tracks]
    SET [LikesCount] = (SELECT COUNT(*) FROM [Likes] WHERE [Tracks].[ID] = inserted.[Track_ID])
    FROM [Tracks]
    INNER JOIN inserted ON [Tracks].[ID] = inserted.[Track_ID];
END;
```

## Implementation II

![image](https://github.com/OpticalAbyss/Notify/assets/91399719/4c0536ce-d232-42af-ab1e-dd6a10a5cee7)

The implementation of the Spotify Clone project involves the following major steps:

1. Setting up the ASP.NET MVC project structure and configuring the necessary dependencies.
2. Implementing the user authentication and authorization system for secure user management.
3. Designing and implementing the database schema using Entity Framework Code First approach.
4. Creating controllers and views for handling user requests and rendering the user interface.
5. Integrating the database access logic with the ASP.NET MVC controllers using Entity Framework.
6. Implementing the music search functionality, playlist management, and other core features.
7. Applying front-end design using HTML, CSS, and JavaScript to create an intuitive user interface.
8. Setting up a GitHub repository for easy access to rollbacks and changes.

## Conclusion

The development of the Spotify Clone using ASP.NET MVC was a significant undertaking that showcased the capabilities of the ASP.NET MVC framework and highlighted the importance of efficient database management in a web application. Throughout the project, various features were implemented, including user registration and authentication, a music catalog, playlist management, and responsive design.

Moving forward, the Spotify Clone project can serve as a foundation for further enhancements and additions. Future iterations could include features like recommendations based on user preferences, personalized playlists curated by AI, and integration with external APIs for music metadata.

In conclusion, the Spotify Clone project successfully achieved its goals of creating a showcase of a Database application using ASP.NET MVC. It served as a valuable learning experience, showcasing the ability to develop sophisticated web applications while emphasizing the significance of database management, responsive design, and user authentication in delivering a seamless user experience.
