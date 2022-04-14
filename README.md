<br />
  <h1 align="center">Helios Bugs Tracker</h1>
  <h3 align="center">Track, Manage and resolve features and bugs</h3>


  <p align="center">
    <a href="https://heliosbugtracker.azurewebsites.net/Tracker">View Demo</a>
  </p>
</p>

<p align="center">Universal bug tracker for everyone! Helios bug tracker allows team members to collaborate, discuss and manage projects effectively.</p>

## ✨ Features

- Team management
- Statistics
- User assignement
- Comment reactions
- Ticket labels
- Ticket history
- Role based organisation
- Change tracker 
- Mail service

## Tech Stack

| Stack    | -                                                                                                                                                                                 | -                                                                                                                                                                           | -                                                                                                | -                                                                                                                | -                                                                                                   |
| -------- | --------------------------------------------------------------------------------------------------                                                                                | -------------------------------------------------------------------------------------------------                                                                           | ------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| FrontEnd | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163143966-609eafd8-f9f0-4fab-a7a0-9d8b5b8bfdde.png" width="100" height="100"> <br />Bootstrap</p>  | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163144526-78d0ee34-90bc-4ece-8f68-74c6cbf973f8.jpg" width="100" height="100"> <br />Css</p>  | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163145017-3f047134-9497-4e0f-a964-c71eb9796b5d.png" width="100" height="100"> <br />Jquery</p>   | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163145256-54dc954e-ad9b-48dd-9b8b-6b2d811faefb.jpg" width="100" height="100"> <br />Chart.js</p>              | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163145555-e17e94c9-8ea1-4a7c-87ca-7fbc31511bb9.png" width="100" height="100"> <br />Font awesome</p>
| BackEnd  | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163146965-611202e6-6d9f-4267-8a98-3a379083fdba.png" width="100" height="100"> <br />.NET 5</p>     | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163147294-3e442920-0a02-42c0-a1c0-f2f54c70d774.jpg" width="100" height="100"> <br />SQL SERVER</p> | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163147498-de4bbe22-a143-4cdb-804b-89c1f302762c.png" width="100" height="100"> <br />EF CORE</p> | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163147911-4579e0eb-e89c-46b1-91b1-432c416e0966.png" width="100" height="100"> <br />MEDIATR</p>               | <p align="center"><img src="https://user-images.githubusercontent.com/71494857/163148141-bb42ce9a-9c17-4e7c-910d-2fd8148fca5d.png" width="100" height="100"> <br />Azure</p> |


## :rocket: Quick start

### Installation
 <i>General requirement</i> - <br/>
  In order for those projects to work, you'll need to have: <br/>
  <ul>
  <li>
    An IDE of your choice, but I'd really recommand Visual Studio 2019. Community version would be 100% fine. If you do not own it yet, take a look
    <a href="https://visualstudio.microsoft.com/fr/"> here </a>.
  </li>
    <li>
      An instance of SQL server installed. If you need help with that, here's a <a href="https://computingforgeeks.com/install-sql-server-developer-edition-on-windows-server/">cool guide</a>. 
    </li>
    <li>
    The .Net 5 (<a href="https://dotnet.microsoft.com/download/dotnet/5.0">Click here!</a> )framework installed. 
    </li>
  </ul>

### Step 1: Clone the repo
Clone the repo locally by doing -

```sh
git clone https://github.com/heliosCreation/BugsTracker.git
```

### Step 2: Set the data store
  The application will make use of a default store, so, before we can use it, we'll have to instantiate it. The migrations being already ready, you'll only have to Update the database <br/>
  To do so, open your package manager, select the persistence Project and type: 
  
 ```bash
Update-database
```



#### And you are good to go



# Application presentation and flow:
## I - Authentication
Since the core application is protected through authentication and authorization, the first page you will directed to will be the login page
<img src="https://user-images.githubusercontent.com/71494857/163155466-6dd57559-3d32-4ad6-924c-c7a123dd4fe9.PNG">

If you do not have an account yet, you can go through the registration process and wait for the confirmation mail. <br/>
But registering itself won't give you access to the application yet, you will to wait for the admin approval.
<kvb>
  <img src="https://user-images.githubusercontent.com/71494857/163165580-12db8b4f-5d18-4340-9e53-0dee143407d5.PNG">
</kvb>
Alternatively, if you don't want to go throuh the whole process of creating an identity, demo user representing each application's role are also available. The catch
being that you won't be able to modify any data on the server with those users:
<img src="https://user-images.githubusercontent.com/71494857/163156031-5ac1576e-53a2-4540-a4b7-03e7942ec637.PNG">
<br/>

# II - The application :fire:

<br/>

## A - Home Page
Upon successful authentication, you will be redirected to the main page. As for the demo, I decided to register as the admin to display all the features available. 
Here, it adds the User management, and system logs tabs. You have the choice to fold the sidebar for a better view if you decide so.
<kbd>
  <img alt="Home page" src="https://user-images.githubusercontent.com/71494857/163367084-a66ca5a0-0d35-475d-b555-e67cba793972.jpg"/>
</kbd>

The upper part of the page will be in charge to display the projects while the lower part will display ticket related statistics to get an immediate idea of the state of the organization.
<br/>
## B - Project

#### Creation
From the home page, an admin can create new project to work with through the organization and assign a team to it. Only the users linked to this project will have access to it and its tickets.
<kbd>
  <img src="https://user-images.githubusercontent.com/71494857/163176737-fdfed0b0-4297-4a23-85d9-7053f7c08b90.jpg"/>
<kbd>
  
<br/>
  
#### Update / Delete
  
  <br/>
From the same page, by hitting the triple dots in the action section of the table, you are able to update or delete the projects. 
The update being pretty similar in term of UI to the creation, no sreenshot will be provided. The deletion is fairly different.
Upon using the corresponding button, you will be prompted with a modal asking you to confirm your action. Deleting a project will as well delete every ticket linked to the project.
<kbd>
  <img src="https://user-images.githubusercontent.com/71494857/163179821-b7b5d687-22fe-45e7-9448-96a8d4157597.PNG"/>
</kbd>

  <br/>
  
## C - Tickets
  
  <br/>
Upon clicking one of the purple project name, you will be taken to the tickets linked to the projects. They are sorted from the newest to the oldest and can be access by performing query corresponding to any of the fields presents in the table below.
  <br/>
  
<kbd>
  <img width="959" alt="TicketList" src="https://user-images.githubusercontent.com/71494857/163184883-88013069-a394-43a9-87ee-133f3b5ba5b5.PNG">
</kbd>
  
<br/>
  
  #### Create
  
<br/>
Clicking on the blue "New Ticket" button will open a modal with two tabs allowing you to create the specific fields of your new ticket and assign the developers that will work on it. 
  <br/>
  
<kbd>
  <img alt="Ticket creation" src="https://user-images.githubusercontent.com/71494857/163187126-75ba49e8-8689-40e5-a6ce-20f9283b24e1.jpg"/>
</kbd>
  
<br/>
  
### Update / Delete
  
  <br/>
Once again, by clicking on the three dots, you will gain access to the update and delete modal. The flow of updating a ticket is again very similar to the creation. Choosing the "Delete" option will prompt you with a modal asking for confirmation. 
<br/>
  
### Details
If you choose to click on the ticket name, rendered in purple in the table, you will access the ticket details.<br/>
Those details are divided in 4 categories:
  - <ins>Description</ins>: A description of the tickets and its necessities.
  - <ins>Comments</ins>: Let's you discuss with the members of the ticket.
  - <ins>Team</ins>: Show the other developers assigned to the ticket and the project manager.
  - <ins>History</ins>: Give information about the ticket creation and each update it when through. 
<br/>
  
  <kbd>
      <img alt="Ticket details" src="https://user-images.githubusercontent.com/71494857/163348938-1a407283-b157-4d5f-945e-192e9a35d7e8.jpg"/>
  <img alt="Ticket details" src="https://user-images.githubusercontent.com/71494857/163348937-2ed46a2f-9923-48a2-807b-dc3e45b2874f.jpg"/>   
  </kbd>
<br/>
  
### Assigned tickets
On the left hand side resides the main tabs of the application. If a user click on the ticket tab, it will take him to a page holding all ticket relatid to him/her.
The way tickets would be fetch will depend on the role assigned to the user:
  - <ins>Admin:</ins> Will fetch all the tickets of the system. Has the possibility to filter the result down to the tickets he/she created.
  - <ins>Project Manager:</ins> Will fetch all the tickets linked to the projects the PM is assigned to. 
  - <ins>Developer</ins>: Will fetch all the tickets they are assigned to.
  - <ins>Submitter</ins>: Will fetch all the tickets they created.
  
  <br/>
  
  <kbd>
    <img width="959" alt="TicketByUser" src="https://user-images.githubusercontent.com/71494857/163365177-0b108c35-fd51-4875-966f-50b90b83dda1.PNG">
  </kbd>
  
## C - User Management 
If the user is logged in as an Admin, he/she will have the option to click on the User management tab. <br/>
This page will fetch all the user in the system, display their name, email and roles, and allow the admin to perform diverse operations.

  <kbd>    <img alt="User management" src="https://user-images.githubusercontent.com/71494857/163371145-d520743f-7d50-4d8b-8423-2ec7442bfff2.PNG"/></kbd>

  

  By clicking on the triple dot of each row, the admin will be able to perform three type of action: 
  
### Manage role
Each user of the system can and should be associated to a role. That's the responsability of the admin to assign and modify said roles. <br/> Clicking on the manage role button will result in the display of the bellow modal. All that will be left will to click and validate your choice.

<kbd>
<img width="943" alt="Role management" src="https://user-images.githubusercontent.com/71494857/163376915-f344f5a3-164d-46b0-a5d8-de989352f0cc.PNG"/>
</kbd>

  ### Lock / Unlock user
Users can be both locked and unlocked from the system. Still by clicking the triple dots the admin will be able to access the below modal. If the user is locked, the option will be defaulted to unlock and vice-versa.
<kbd>
  <img alt="Lock and unlock" src="https://user-images.githubusercontent.com/71494857/163384768-02246056-5a4e-403f-abc1-e19d52793112.jpg"/>
  </kbd>
  
### Delete user
  
Finally, the admin might want to remove permanently somebody from the organization. If he/she wish to do so, the triple dots also give access to a delete user modal. He/She, will be asked for confirmation and will then be able to validate the action.
<kbd>
<img width="959" alt="DeleteUser" src="https://user-images.githubusercontent.com/71494857/163405273-970d5d9e-eb7a-4c5c-9e40-60a382e491b2.PNG">  
</kbd>
