# TeleHeath (Angular / .Net Core / EF Core)

System which displays patients and allows for adding of patient.
  - Type some Markdown on the left
  - See HTML in the right
  - Magic

# Solution setup.

  - TeleHealth - Main API controller
  - TeleHealth ClientApp - Angualr project
  - TeleHealth.Core - Services which communicate to the Entity layer and respond back to the TeleHeath.
  - TeleHealth.Entity - Everything related to the database.

### The following would have been implemented / enhanced if I had more time.

* Implement Authentication / Authorization.
* Extend patient model to include the fields that define a patient.
* Extend validation, at present the validation is extremely basic, given the nature of the application and the type of data we're handling we'd need to ensure the application is sealed tight.
* I'm a huge advocate for unit tests, but due to my own personal time constraints this weekend I was unable to implement those into the solution.  However it would be something I would have implemented if I had more time.
* Add service layer to frontend which would move the logic for calling the API directly from the component
* Implement Swagger to handle the configuration of API's 

### How to start the application

* Change connection string value within  appsettings.development.json
* run npm install within ClientApp folder to ensure all frontend dependancies are installed.

### UI

> The UI is very basic, reason being I wanted to ensure the application was functional and worry about styling later, from my experience when it comes to designing the front end you could potential spend hours upon hours changing / tweaking the UI which would leave little hours for actual backend development, so I thought it be best I get basic UI in place and focus on retrieving / saving data and if I had time at the end I would come back and make it look relatively decent.

