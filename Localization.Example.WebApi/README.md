# Localization Example WebApi

This project is an example of how to implement localization in a .NET Core API. It demonstrates how to support multiple languages in API responses (both success and error messages) based on the user's language preference using the `Accept-Language` header.

## Features

- **Dynamic Language Support:** Automatically adjusts API messages (response and error) based on the user's language.
- **Resource-Based Localization:** Uses `.resx` resource files to store localized messages.
- **Culture Management:** Supports multiple cultures (e.g., `en-US`, `tr-TR`) with the ability to add more.
- **Request Localization:** Utilizes the `Accept-Language` header to switch between languages dynamically.
- **Middleware Integration:** Demonstrates how to set up localization middleware in a .NET Core API.

## Project Setup

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/LocalizationExampleApi.git
cd LocalizationExampleApi
```

### 2. Build and Run the Project

```bash
dotnet build
dotnet run
```

The API should be running at https://localhost:5186.

## Usage

### 1. Set the Language

To set the language, include the `Accept-Language` header in your request with the desired language code (e.g., `en-US`, `tr-TR`).

### 2. Make a Request

Send a request to the API, and the response messages will be in the language specified in the `Accept-Language` header.

## Endpoints

### 1. GET /api/values

- **Description:** Returns a list of values.
- **URL:** https://localhost:5186/api/test/greeting/{value}
- **Method:** GET
- **Response:**
    ```json
    {
        "message": "Values retrieved successfully."
    }
    ```
- **Error Response:**
    ```json
    {
        "message": "An error occurred while retrieving values."
    }
    ```
- **Sample Request:**
    ```bash
    curl -X GET "http://localhost:5186/api/greeting/4" -H "Accept-Language: en-US"
    ```






