[Docs ⬇️](https://github.com/b14ck0ps/WebNewsAPI#category-endpoints)
## News API

This API is a news platform that provides a range of endpoints for managing news articles and categories. With this API, users can create, update, and delete categories as well as add, modify, and delete news articles. The API supports several retrieval options, including accessing news articles by ID, category, and date, and allows filtering of news articles by category and date. The endpoints are designed to be intuitive and easy to use, providing developers with a comprehensive set of tools to build custom applications that leverage the features of the API. This documentation will provide a detailed guide on how to use the API and its endpoints, along with examples of sample requests and responses.

This project is a Web API built on the ASP.NET framework 4.8.1. It uses Entity Framework 6.1.1 (code first approach) to interact with a SQL Server database called NewsDB. The API is designed using the 3-tier architecture to separate concerns between the presentation layer, business logic layer, and data access layer.

The API allows users to perform CRUD operations on news articles and categories. The API endpoints include GET, POST, PATCH, and DELETE methods for categories and news articles.

To run this project, follow these steps:

- Open Visual Studio 2019 or later.
- Clone or download the project from the GitHub repository.
- Open the solution file (.sln) in Visual Studio.
- Build the solution to restore the NuGet packages.
- Set the Web API project as the startup project.
- Configure the database connection string in the web.config file.
- Run the project using IIS Express or a local web server.
- Test the API endpoints using a tool like Postman or a web browser.
Please note that this project requires the .NET Framework 4.8.1 runtime and Entity Framework 6.1.1 to be installed on the machine.
# Category Endpoints

## Retrieve All Categories

### Request

```GET http://localhost:15465/api/category/```


### Response
```
[
    {
        "Id": 1,
        "Name": "Sports"
    },
    {
        "Id": 1003,
        "Name": "E-Sports"
    }
]
```


## Retrieve Category by ID

### Request

```GET http://localhost:15465/api/category/1003```
### Response

```
{
    "Id": 1003,
    "Name": "E-Sports"
}
```

## Create New Category

### Request

```POST http://localhost:15465/api/category/```
```
{
    "Name": "Aliens"
}
```
### Response

``true``

## Update Category

### Request

```PATCH http://localhost:15465/api/category```

### Request
```
{
    "Id": 1004,
    "Name": "Space Aliens "
}
```

### Response

``true``

## Delete Category by ID

### Request

```DELETE http://localhost:15465/api/category/1004```
### Response

`true`

# News Endpoints
## Get All News

### Request
`GET http://localhost:15465/api/news/ `
### Response

```
[
    {
        "Id": 7,
        "Title": "Football",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    },
    {
        "Id": 1002,
        "Title": "Cricket 69",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    }
]
```
## Get News By Id

### Request
`GET http://localhost:15465/api/news/7 `
### Response

```
{
    "Id": 7,
    "Title": "Football",
    "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
    "Cid": 1,
    "Date": "2023-03-29T00:00:00",
    "Category": {
        "Id": 1,
        "Name": "Sports"
    }
}

```

## Get News By Category

### Request
`GET http://localhost:15465/api/news/category/sports `
### Response

```
[
    {
        "Id": 7,
        "Title": "Football",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    },
    {
        "Id": 1002,
        "Title": "Cricket 69",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    }
]

```
## Get News By Date

### Request
`GET http://localhost:15465/api/news/date/2023-03-30 `
### Response

```
[
    {
        "Id": 1005,
        "Title": "Cricket 2",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-30T00:01:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    }
]

```
## Get News By Date and category

### Request
`GET http://localhost:15465/api/news/category/sports/date/2023-03-29 `
### Response

```
[
    {
        "Id": 7,
        "Title": "Football",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    },
    {
        "Id": 1002,
        "Title": "Cricket 69",
        "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
        "Cid": 1,
        "Date": "2023-03-29T00:00:00",
        "Category": {
            "Id": 1,
            "Name": "Sports"
        }
    }
]
```

## Add New News

### Request
`POST http://localhost:15465/api/news`
```
{
    "Id": 7,
    "Title": "Football",
    "Description": "Lorem Lorem Lorem Lorem Lorem Lorem Lorem ",
    "Cid": 1,
    "Date": "2023-03-29T00:00:00"
}
```
### Response
`` true ``


## Update News

### Request
`PATCH http://localhost:15465/api/news`
```
{
    "Id": 7,
    "Title": "Football 77",
}
```
### Response
`` true ``

## Delete News

### Request
`DELETE http://localhost:15465/api/news/7`
### Response
`` true ``
