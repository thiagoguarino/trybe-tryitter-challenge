namespace Trybe.Tryitter.Test;
using Trybe.Tryitter.Controllers;
using FluentAssertions;

public class UsersTest
{
    [Fact(DisplayName="Creates User successfully")]
    public void AddUser()
    {
        // arrange

        // act  

        // assert  
    }

    [Fact(DisplayName="Creates User - FAILURE - tries to add user without inputs")]
    public void AddUserFailure()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Deletes User successfully")]
    public void DeleteUser()
    {
        // arrange  

        // act  

        // assert  
    }


    [Fact(DisplayName="Deletes a User - FAILURE - tries to delete user that does not exist")]
    public void DeleteUserFailure()
    {
        // arrange  

        // act  

        // assert
    }

    [Fact(DisplayName="Updates User data successfully")]
    public void UpdateUser()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Get all Users successfully")]
    public void GetUsers()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Get one User successfully")]
    public void GetUser()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Get one User - FAILURE - tries to get user that does not exist")]
    public void GetUserFailure()
    {
        // arrange  

        // act  

        // assert  
    }
}
