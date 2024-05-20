- To start the project: Right click on the solution -> Properties -> Common Properties -> Configure Startup Projects -> Check 'Multiple startup project' -> set 'WebAPI' and 'EventManagerFrontend''s action to 'Start' -> Press OK -> Start the project.

  !! IMPORTANT !!
  - The backend of the project (api) is fully functional (with what it has in it) - Events, Users, Tickets, etc. CRUD operations functional.
  - The frontend doesn't allow to delete nor update.
  - The 'login' is based on a localStorage so no professional authetification.
  - The 'register' page doesn't work (ERROR 404) -> couldn't figure out why.
  - Some options in the fronend will be available only after login.
  - Added some data in the table through the 'OnModelCreating' method.
  - Added the migrations.
