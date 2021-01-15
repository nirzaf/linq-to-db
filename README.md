# .NET Essentials: LINQ for Databases
This is the repository for the LinkedIn Learning course .NET Essentials: LINQ for Databases. The full course is available from [LinkedIn Learning][lil-course-url].

![.NET Essentials: LINQ for Databases][lil-thumbnail-url] 
The first explanation you typically hear about Microsoft LINQ is that it provides an in-language query tool to manipulate the contents of arrays and lists. Explore LINQ further and you’ll find it works with other popular data sources like databases and XML files. That makes it a universal query tool that simplifies working with any data source. In this course, part of a three-course series, LinkedIn Learning staff author Walt Ritscher uses LINQPad, a lightweight, powerful code editor, to illustrate useful topics like queryable types, basic query syntax, finding data by date range, and how to use LINQ queries to reduce database network traffic. After completing this course, you’ll have a solid foundation on using LINQ to query database and Entity Framework data.

## Instructions
This repository has branches for each of the videos in the course. You can use the branch pop up menu in github to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you will get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


## Installing
1. To use these exercise files, you must have the following installed:
	- [Visual Studio](https://visualstudio.microsoft.com/)
	- [LINQPad](https://www.linqpad.net/) 
2. Clone this repository into your local machine using the Visual Studio, or OS command line tool (Powershell, Windows Terminal) or MAC equivalent .
3. See the intro chapter for information about this course Git branches.

### Instructor

**Walt Ritscher **

_Walt Ritscher is a programmer, UI designer, and staff author at LinkedIn Learning._

Check out some of my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/walt-ritscher?u=104).

[lil-course-url]: https://www.linkedin.com/learning/dot-net-essentials-linq-for-databases
[lil-thumbnail-url]: https://cdn.lynda.com/course/2858036/2858036-1610558892801-16x9.jpg
