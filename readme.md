# Project Overview
------------
## Project Title
Project SIMS[^1] - Simple Inventory Management System

[^1]: No affiliation with the sims game series. The name is purely coincidental and chosen for its simplicity and relevance to the project's purpose.

------------------------
## Author(s)
[Alex Foreman](https://github.com/agforeman)

-------------------------

## Project Description
This project aims to deliver a simple inventory management system (SIMS) that allows users to add and remove products from the catalogue and manage inventory levels. User interaction will be handled via a command-line interface (CLI), providing a simple and straightforward way to interact with the system and manager inventory effectively without the need for a graphical user interface (GUI).

-------------------------

## Requirements
### Functional
- The system shall allow users to add products to the catalogue.
- The user shall be able to define products' names, prices, and stock quantities upon adding them to the catalogue.
- The system shall allow users to remove products from the catalogue.
- The system shall allow users to update inventory levels for products.
- The system shall allow users to view the product catalog and each product's details, including stock levels.
- When adding a product the system shall validate the product does not currently exist. If it does the system shall ask the user if they want to override the existing product. If yes, the system shall update the existing product with the new information. If no, the system shall cancel the add operation.

### Non-Functional
- The system shall allow at most 20 products in the catalogue.
- The system shall provide simple storage capabilities to persist product data between sessions.
- The system shall process user input within 500 ms.
- The system shall display error messages for invalid input and allow the user to retry the operation.

--------------------------

## Objectives
### Product Catalog
- Product CRUD operations complete within 1 hour.
- Product Catalog display functionality complete within 2 hours.
- Error handling for invalid input complete within 4 hours.

### Data Persistence
- Implement basic file-based storage for product data complete within 5 hours.

---------------------------
## Design Outline
### Modules
- Product Management
- Catalog Management
- Data Persistence

### Diagrams
![project design diagram](./assets/Overview.svg)