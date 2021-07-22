# Hotel Model Binding MVC
Assignment: Create an ASP.NET Core MVC application to demonstrate that you understand the concepts of the MVC pattern.

*You need to meet the following requirements:*

    Choose an object like a Product, Automobile, Animal, or another of your choosing

    Make a view with an HTML form that will allow you to create your object (no model-binding)
    
    In the controller:
    create an object and populate it with the form data
    (Hint: Your controller action method should take a IFormCollection object)

    NO VALIDATION IS NECESSARY

    Make another view that will allow you to create your object but this time use model-binding

    In both cases, add your object to a database using ADO.NET OR 
    simply add a comment where you would add to the database

    If you create the DB code, 
    make a database class with a method to do the insert (we don't want too much code in our controllers)
    
    This method should be called for both Action Methods (the modelbinding and html form data versions) OR
    there should be a comment in both methods showing where the entity would be added
