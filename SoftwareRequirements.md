# Software Requirements

## Vision
The box office in a theatre, cinema, or concert hall is the place where the tickets are sold. When people talk about the box office, they are referring to the degree of success of a film or play in terms of the number of people who go to watch it or the amount of money it makes.

## IN
- Allow an easy way to buying a ticket 

- Allows Admin to create, update, and delete a Movie ,Cinema , Actor and Producer.

- Allows customers to buying a ticket and serch for movies

## OUT
- Our website will never turn into an IOS or Android app.
- Won’t manage sales
- Will not track expenses

## Minimum Viable Product

- Able to view, update, create, and delete movies, Actor , Producer and Cinema, as appropriate with the user’s permissions.

- Include unit tests for all application services.

## Stretch

- Ability for users to create an account using an external login provider like Facebook or google. 

- Add roles for users in our project.

- Add user interface and user experiance to make it useful. 

## Functional Requirements

- Admin can update, create, and delete all entities, view all movies, Cinema,Actor, and Producer

- Customers can update, create, and delete order, and view all movies.


## Data Flow

There will be a controller for each entity implemented, which will take in a DTO object (when necessary) through an API route, and return data.

Each controller will use dependency injection to access a service object which will perform the actual database operations, and return DTO data back to the controller. The controller will not have access to actual entity data, but will only work with DTOs.


## Non-Functional Requirements

- **Security**

    We will employ ASP.NET Core Authorization and Identity to create cookies for users when they log in, and then those users will employ their token to gain access to the functionalities they have access to.

    Users can create an account with the login information stored in database. 

- **Testability** 

    We will employ xUnit to perform unit tests, and build the project using TDD.

    Every publicly accessible method in every service will be tested, with the unit tests written before the method(s).

- **Usability**

    API will be RESTful and return predictable data for a given internal state.

    API routes will be logical and consistent, with correct spelling and consistent pluralization.