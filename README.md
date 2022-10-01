# Online Shop

## Goals

- Use the tech stack of an awesome promising startup:
	- .NET Core
	- mongoDB
	- React
	- Docker

- The project is easy to setup. Just run:
	- git clone https://github.com/andon-andonov/OnlineShop.git
	- docker-compose build
	- docker-compose up

- Use Clean Architecture to easily allow changing dependencies.

## Overview

When opening the web ui, the user is presented with a list of products. Users can open a detail view of each product. From the list view and detail view, products can be added to a shopping cart. This action only increments a counter presented in the top right of the screen.

## Architecture

The backend is a monolith because it is best suited for an MVP solution. Gathering more information in the future will enable the dev team to make decisions on how to split it to different services.

The solution is separated in 5 projects - Domain, Application, Infrastructure, Web API, Web UI.

### Domain

This is the core of the application. It does not depend on anything else. Currently, it contains only the domain entities.

### Application

This is the place for all the functionalities of the system. What this application is about can be seen from the directory structure. On top level there is directory for each entity. In each of those entity directories we have 'Commands' and 'Queries' directory, implementing CQRS. This will enable us in the future to easily refactor, separate and scale differently the parts of the application. The Application layer depends only on the Domain layer.


### Infrastructure

This is the place for all infrastructure concerns. Currenly, mongoDB is used as a database, but it can be easily swapped with another data store. The Application and Domain layers do not depend on concrete infrastructure concerns.

### Web API and Web UI

This is the user interaction layer of the application. It depends on Domain, Application and Infrastructure but not the other way around. This enables us to easily swap this UI with another. For example, we can have console UI using the same Domain, Application and Infrastructure layers.

## UI

In OnlineShop.WebUI/ClientApp/src the directory structure follows the same theme as in the backend - we can see what this app is about just by looking at it. The cart shared state is implemented via /cart/CartContext.jsx.




