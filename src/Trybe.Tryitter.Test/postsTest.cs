namespace Trybe.Tryitter.Test;
using Trybe.Tryitter.Controllers;
using FluentAssertions;

public class PostsTest
{
    [Fact(DisplayName="Creates a new post successfully")]
    public void AddPost()
    {
        // arrange  

        // act  

        // assert
    }

    [Fact(DisplayName="Creates a new post - FAILURE 1 - tries to add post with more than 300 characters")]
    public void AddPostFailureOne()
    {
        // arrange  

        // act  

        // assert
    }

    [Fact(DisplayName="Creates a new post - FAILURE 2 - tries to add post with 0 characters")]
    public void AddPostFailureTwo()
    {
        // arrange  

        // act  

        // assert
    }

    [Fact(DisplayName="Get all posts from User successfully")]
    public void GetAllUserPosts()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Get one post from User successfully")]
    public void GetPostById()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Get one post from User - FAILURE - tries to get post that does not exist")]
    public void GetPostByIdFailure()
    {
        // arrange  

        // act  

        // assert  
    }


    [Fact(DisplayName="Get last Post from User successfully")]
    public void GetLastPost()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Deletes a post from User successfully")]
    public void DeletePost()
    {
        // arrange  

        // act  

        // assert  
    }

    [Fact(DisplayName="Deletes a post from User - FAILURE - tries to delete post that does not exist")]
    public void DeletePostFailure()
    {
        // arrange  

        // act  

        // assert
    }

    [Fact(DisplayName="Updates a post from User successfully")]
    public void UpdatePost()
    {
        // arrange  

        // act  

        // assert  
    }
}
