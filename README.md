# Banking-Software

 
Contents
Introduction & Purpose	3
Project Introduction	3
Project Purpose	3
Team Summary	4
Name & Responsibilities / Work Accomplished	4
Signature of Approval	4
Terminology (Technical Language)	5
SCRUM Terminology	5
SOLID Terminology	5
CSI Terminology	5
Dependencies & References	6
Revision History	7
Product Overview	8
Title & Description	8
Objective	8
System Context	9
Project Scope	9
System Functions	9
Application Code	9
Actors	10
Primary	10
Secondary	10
Use Cases	11
Group by Functionality	11
Group by User	11
Artifacts	12
Use Case Analysis Diagrams	12
Activity Diagrams	13
Sequence Diagrams	14
	14
ERD Diagram	15
Domain Object Model	16
Testing	17
Testing Scope	17
In Scope	17
Items Not Tested	17
Metrics	17
Scrum Development Process	18
Product Backlog	18
Sprints	20
Sprint Planning	20
Standups	20
Reviews	20
Retrospective	21
Scrum Burndown	23
Scrum Burndown (VSTS)	24
User Manual	25
Installation	25
System Requirements	25
Installation Procedure	25
Security Requirements	25
User Requirements	25

 
Introduction & Purpose

Project Introduction
CSI needs an application that will allow its Tier 1 support be able to monitor, fix and lower ticket escalations so that higher level employees can allocate their resources elsewhere. For this to happen Tier 1 support must be able to rapidly identify error codes, provide a solution and do so with little or no knowledge of SQL.
Project Purpose
	The purpose of this project is to build an application for two reasons. First, for the team members of this project it is to learn what it is like to build a real-world application that could be used. Additionally, the group will also learn about the fundamentals of Scrum, SOLID and other software building methodologies. For the client, CSI, the purpose is to have a better Tier 1 platform that allows their higher-level employees to spend less time on escalated tickets.
 
Team Summary

Name & Responsibilities / Work Accomplished
	Jamal Al-Sarraf – SCRUM Master
•	Management of SCRUM Process
•	Preparer of Folder
•	Scheduling of Meetings
•	Creator of Database
•	Development of Software
	Max Flores – Developer
•	Development of Software
•	Search Page
•	Integration of Database
	Mathers Hale – Developer
•	Development of Software
•	Analytics Page
•	API








Signature of Approval


   
Terminology (Technical Language)

SCRUM Terminology
•	SCRUM
o	A meeting that takes place between all members. No longer than 15 minutes.
•	SCRUM Master
o	The person who oversees all meetings.
•	Sprint
o	A period when development of backlog features is started
•	Log
o	Summarization of a sprint.
•	Artifacts
o	Product backlog, monitoring progress, and sprint backlog

SOLID Terminology
•	Single responsibility principle
o	a class should have only a single responsibility (i.e. changes to only one part of the software's specification should be able to affect the specification of the class).
•	Open/closed principle
o	 software entities … should be open for extension but closed for modification."
	Liskov substitution principle
o	"objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." See also design by contract.
•	Interface segregation principle
o	 "many client-specific interfaces are better than one general-purpose interface."
•	Dependency inversion principle
o	 one should "depend upon abstractions, [not] concretions."

CSI Terminology
•	CSI
o	Computer Services Inc.
•	Session
o	When a user is connected to the application
 
Dependencies & References

•	"Microsoft.AspNetCore" Version="2.0.2"
•	"Microsoft.AspNetCore.All" Version="2.0.6"
•	"Microsoft.EntityFrameworkCore" Version="2.0.2"
•	"Microsoft.EntityFrameworkCore.Design" Version="2.0.2"
•	"Microsoft.EntityFrameworkCore.Sqlite" Version="2.0.2"
•	"Microsoft.EntityFrameworkCore.SqlServer" Version="2.0.2"
•	"Microsoft.EntityFrameworkCore.Tools" Version="2.0.2"
•	"Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="2.0.2"
•	"Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.1"
•	"Microsoft.Extensions.SecretManager.Tools" Version="2.0.0"
•	"Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.2"
 
Revision History
March 7 – First Commit to MVC
March 20 – UI Added and added local database
March 27 – Test
March 28- Redo
March 31 – Added new database
April 2 – Edited database context
April 4 – Redo 2
April 9 – Added complete database
April 11 – Database fixed and connected
April 17 – More non-solid work
April 19 – Database connected 
April 23 – Added search method, API search method and merged
April 30 – Added pagination, views showed and changed connection string to Azure
May 1 – Added second table 
May 2 – Added RequestDetails table
May 3 – Additional addons




 
Product Overview

Title & Description
Title – CSI Application
Description – This application makes it easy for CSI’s support technicians to search through sessions via multiple search criteria. 

Objective
	The objective is to create an application for CSI that will lower the ticket amounts created by Tier 1 support employees. The application will also allow Tier 1 support employees to solve more problems encountered by their users and ensure ease of search when looking up an error code. Analytics will also be provided so that CSI will see what errors are the most common and allow higher level employees to fix them if they become a numerous problem. 
System Context

Project Scope
	The purpose of this project is to provide CSI with a solution to lower the amount of escalated tickets from their Tier 1 support. By lowering the amount of tickets this allows upper level staff to work on more important projects and makes Tier 1 support more productive.

System Functions
	Search – This page allows the user to search the metrics from the existing database using multiple criteria.
	Analytics – This page allows the user to analyze the data of the results of a search and compare it to the global analytics of the database.

Application Code
The code of the application can be found on Bitbucket here: https://bitbucket.org/cidm4390spring2018winners/cidm4390-spring2018-winners/branches/

	 
 
Actors

Primary
•	Support Technician
Secondary
•	Software Engineer
•	Product Owner
 
Use Cases

Group by Functionality
•	Viewing user sessions
•	Identifying errors
•	View specific statistics
•	Giving performance feedback
•	Building error tickets
Group by User
•	CSI Employee
•	Financial Institution
•	Financial Institution Customer
 
Artifacts

Use Case Analysis Diagrams
















Activity Diagrams
Sequence Diagrams









ERD Diagram

 
 
Domain Object Model


 










Testing

Testing Scope
•	Check is search functions work
•	Check database connection
•	Test if analytics from Google functions
•	Test speed of application
•	Pagination
•	Testing UI
In Scope
•	Search functions
•	UI
•	Database connection
•	Pagination
•	Speed of application
Items Not Tested
•	Google analytics
Metrics
•	Search function accuracy
•	Speed of pagination
•	UI clarity and function
•	Database connection speed
 
Scrum Development Process

Product Backlog
•	User Search
As a CSI support team member
I need a UI
So that I can easily navigate through the app and all its features
Scenario: Support team member uses app for the first time
Given that a support team member opens the app
When the app loads
Then it should easily and clearly provide information to allow navigation of the app

•	Get log by Bank Number
As Front End Designer - Doug Nettles,
I need an API call to get log entries related to a Bank Number,
so that I may display the information in a visual and analytic form to the users sorted by a Bank Number.
Given the API and its documentation,
when I can call upon the documented API call with the parameter BankNumber I should get back a JSON file giving all logs in the Metrics table, the related details table, and extended details table.
Then It will be finished.


•	Sort by API method
As Kyle (Software Engineer)
I want/need to be able to sort given data by API method
So that I may analyze the sessions that occurred in the API method given in a ticket forwarded to me.
Given a forwarded issue from a support tech requiring further assistance.
When I filter the session logs by API method
Then a table displays with the sessions that have the chosen API method.

•	Data Analytics
As a Project Manager
I want/need to figure out all analytics included in that error
So that these analytics will help prevent from happening again
Given an error
When a problem occurs within a bank's user experience
Then grab analytics and display


•	Database connection R&D
As a Winners team member
I need to research how to connect the database
So that we can test with the actual data from CSI
Given the database provided by CSI
When I connect the database to the solution
Then the database should seed

•	Working UI
As a CSI support team member
I need a UI
So that I can easily navigate through the app and all its features
Scenario: Support team member uses app for the first time
Given that a support team member opens the app
When the app loads
Then it should easily and clearly provide information to allow navigation of the app

•	Search by Time Stamp

As a support desk analyst,
I need to be able to search the database by timestamp
so that I can find request metrics faster and narrow them down easier.
Given A search field that allows input for a certain timeframe
When I input the timeframe
Then The search narrows down the results to that timeframe.

•	Search by Known Error

As a support desk analyst,
I need to be able to search the database by is error
so that I can find request metrics faster and narrow them down easier.
Given A search field that specifies if an error is known
When I choose an option
Then the search returns that option.

•	Pagination

As a support desk analyst,
I need to be able to cycle through multiple pages of search results
so that I can find the specific request metric I am looking for.
Given A search results page is shown with next and previous buttons
When click on the buttons
Then The results should cycle through one page at a time.




All backlog items can be found here: https://cidm4390winners.visualstudio.com/CIDM4390-Spring2018-winners/_backlogs/board/Backlog%20items

Sprints
Sprint Planning
•	Sprint 0.5
o	Learned the fundamentals of AGILE and SOLID began work as a team and learned the standup process.
•	Sprint 1
o	Wireframed a UI
o	Made the UI work
•	Sprint 2
o	Database Connection R&D
•	Sprint 3
o	User Search
o	Get log by bank number
o	Sort by API method
o	Data Analytics
Standups
o	Sprint 0.5
o	Began to gel the group together
o	Sprint 1
o	Project was wiped
o	All members began to take on their roles within the team
o	Sprint 2
o	Synergy between team members was greatly improved
o	Had trouble with database connection which plagued the project until first presentation to CSI
o	Health issues with Scrum master
o	Sprint 3
o	All features began to form
o	Working application but with a local database
o	Sprint 4
o	Working project completed for minimum viable product
Reviews
Sprint 0.5
1)	A backlog was not started yet because the group was starting
Sprint 1
1)	We reviewed how our UI would work and conformed to an agreed upon UI that the class decided on
2)	Coded the UI and integrated LINQ to make it work
Sprint 2
1)	Database was compiled and put into SQLite
2)	Created a local database to check if the application worked
Sprint 3
1)	Backlogs began to rapidly complete
2)	User search code was completed
3)	Sort by API method completed
4)	Data Analytics integrated
Sprint 4
1)	Minimum viable project completed, and code compiled 

Retrospective
Sprint 0.5
1)	What went well:
a.	Everyone was able to meet on time
b.	Established ground rules for the group
2)	What could have gone better:
a.	VSTS integration could have been learned better and setup to proper dates
3)	What we can improve:
a.	Better use of VSTS and assigning tasks
4)	What was working:
a.	Communication was excellent, and everyone was able to meet on time
Sprint 1
1)	What went well:
a.	We made a UI
b.	The UI, once it was made, worked
2)	What could have gone better:
a.	More work could have been done during this sprint
b.	Health issues with some team members
c.	Wipe of code effected work
3)	What we can improve:
a.	More tasks should have been assigned during this sprint
b.	Database should have been complete in this sprint
4)	What was working:
a.	Communication became excellent
b.	Synergy became better
Sprint 2
1)	What went well:
a.	Database was complete after switching services multiple times
2)	What could have gone better:
a.	The team should have stuck with Microsoft SQL rather than switch to SQLite
b.	A connection string should have been implemented so that the database would work from azure
3)	What we can improve:
a.	Better Azure familiarity needed to be known
4)	What was working:
a.	Communication was excellent
b.	Backlog features were being fleshed out members knew who would be doing what
Sprint 3
1)	What went well:
a.	Many backlog items were finished
b.	Search function was complete
2)	What could have gone better:
a.	Database connection should have been done earlier
b.	Database began to plague the project at this point and should have been addressed during this sprint
3)	What we can improve:
a.	Ensuring one critical feature works before moving on to other features
4)	What went well:
a.	Backlog features were being completed on time
b.	Search function went well
c.	Communication stayed excellent

Sprint 4
1)	What went well:
a.	Minimum viable project was complete
2)	What could have gone better:
a.	The database should have been fixed by sprint 3 rather than spring 4
b.	CSS should have been integrated but the database was a higher priority
c.	Communications took a slight slump
d.	We should have been ready to present to CSI
3)	What we can improve:
a.	Better communication during the final sprint
b.	Ensured that the database was working and connected to Azure
4)	What went well:
a.	Minimum viable project was met
Sprint 5
1)	What went well:
a.	Pagination is working
b.	Search by time stamp is working
c.	Search by known error is working
2)	What could have gone better:
a.	CSS could have been integrated
b.	Communications took a hit because of final exams
3)	What we can improve:
a.	Better communication
b.	Better time management
4)	What went well:
a.	We improved the minimum viable project

Sprint logs and notes can be found here: https://drive.google.com/open?id=1otMGWsoLFXZuRFd2GmuAtZmddRWHx9qB

Scrum Burndown

This burndown represents the group’s actual burndown since VSTS was setup incorrectly from the beginning.















Scrum Burndown (VSTS) 

This table shows that errors were made with the sprint planning in VSTS.















User Manual

1)	Before using this application ensure that a backup of your current code is made.
2)	Create a branch outside of your master code branch and integrate it into the code of this project.
3)	Merge the two codes.
4)	Ensure the search function is working by clicking search at the top.
5)	Ensure the analytics is working by clicking analytics.
6)	Perform a test search.
7)	If the test search works, the code has been integrated successfully.
Installation

System Requirements
•	1 Ghz Processor
•	2GB Ram
•	1-2 GB of disk space
•	Screen resolution of at least 1280 X 800
•	Windows 7 SP1 or higher
•	At least .Net 3.5
•	Latest browser version
Installation Procedure
•	Add coding to existing sections where necessary
•	Ensure that the code does not cause conflicts
•	Connect new code with existing database to ensure functionality
Security Requirements
•	When used outside of a CSI office a VPN is strongly recommended
User Requirements
•	Understanding of CSI’s requirements
•	When to escalate an error
•	Knowledge of Internet browsers
•	Ability to filter errors as needed
•	Knowledge of SQL preferred but not required


