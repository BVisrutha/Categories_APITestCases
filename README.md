# Test cases for Categories API Testing

* [Overview](#overview)
* [Models](#models)
* [Endpoint](#endpoint)
* [Test Cases](#test-cases)
* [Utilities](#utilities)
* [JSON Response](#json-response)

## Overview

Solution provides Test cases for the below Acceptance criteria.

* Name = "Carbon credits"
* CanRelist = true
* The Promotions element with Name = "Gallery" has a Description that contains the text "2x larger image"

## Models

The solution contains **CategoriesModel** project, which contains the Models to write JSON response from API to Object (Deserialization).

Models have been created using https://json2csharp.com/ 

## Endpoint

The endpoint that was being used to retrieve JSON is: https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false

## Test Cases
I used NUnit Test cases (Fluent Assertions) to validate the Test cases. Three Test cases have been created for each Acceptance criteria.
* **CategoryNameComparision**: This use case validates if the **Name** matches **Carbon credits**
* **CanRelistComparision**: This use case validates if **CanRelist** is true.
* **DescriptionComparision**: This use case validates if the Promotion element with **Gallery** Description  matches **2x larger image**.


## Utilities
The utilities file contains reusable method **GetJSONResponse**, get the API response from API.

## JSON Response

The response from API is as shown below:

{
  "CategoryId": 6327,
  "Name": "Carbon credits",
  "Path": "/Business-farming-industry/Carbon-credits",
  "CanListAuctions": true,
  "CanListClassifieds": true,
  "CanRelist": true,
  "LegalNotice": "Compliance Declaration\nI confirm that these carbon credits are certified and registered with a carbon credits registry. ",
  "DefaultDuration": 14,
  "AllowedDurations": [
    2,
    3,
    4,
    5,
    6,
    7,
    10,
    14
  ],
  "Fees": {
    "Bundle": 15,
    "EndDate": 0.25,
    "Feature": 10,
    "Gallery": 2,
    "Listing": 29,
    "Reserve": 0.25,
    "Subtitle": 0.55,
    "TenDays": 0.25,
    "ListingFeeTiers": [
      {
        "MinimumTierPrice": 0,
        "FixedFee": 29
      }
    ],
    "SecondCategory": 0.99
  },
  "FreePhotoCount": 20,
  "MaximumPhotoCount": 20,
  "IsFreeToRelist": true,
  "Promotions": [
    {
      "Id": 1,
      "Name": "Basic",
      "Description": "Lowest position in category",
      "Price": 0,
      "MinimumPhotoCount": 0
    },
    {
      "Id": 2,
      "Name": "Gallery",
      "Description": "Good position in category",
      "Price": 2,
      "OriginalPrice": 2,
      "MinimumPhotoCount": 0
    },
    {
      "Id": 3,
      "Name": "Feature",
      "Description": "Better position in category",
      "Price": 10,
      "OriginalPrice": 10,
      "Recommended": true,
      "MinimumPhotoCount": 0
    },
    {
      "Id": 4,
      "Name": "Feature Combo",
      "Description": "Best position in category \nIncludes benefits of Feature \nHighlights listing in search results",
      "Price": 15,
      "OriginalPrice": 15,
      "MinimumPhotoCount": 0
    }
  ],
  "EmbeddedContentOptions": [],
  "MaximumTitleLength": 80,
  "AreaOfBusiness": 1,
  "DefaultRelistDuration": 7,
  "CanUseCounterOffers": true
}
